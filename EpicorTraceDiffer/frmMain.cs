using EpicorTraceDiffer.XPathDiscovery;
using Menees.Diffs;
using Microsoft.XmlDiffPatch;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace EpicorTraceDiffer
{
    public partial class frmTraceDiffer : Form
    {
        public frmTraceDiffer()
        {
            InitializeComponent();
            
        }
        ScintillaNET.Scintilla TextArea1, TextArea2;
        XDocument xmlDoc;
        List<XElement> methods;
        List<Methods> methodListFrom, methodListTo;
        List<string> bos;
        //Menees.Diffs.Controls.DiffControl dc;
        private void frmTraceDiffer_Load(object sender, EventArgs e)
        {
            TextArea1 = new ScintillaNET.Scintilla();
            TextArea2 = new ScintillaNET.Scintilla();
            InitSyntaxColoring(TextArea1);
            InitSyntaxColoring(TextArea2);
            InitSyntaxColoring(traceParams);
            InitXmlSyntax(scinTrace);
            TextArea1.Dock = DockStyle.Fill;
            TextArea2.Dock = DockStyle.Fill;
            spcMain.Panel1.Controls.Add(TextArea1);
            spcMain.Panel2.Controls.Add(TextArea2);
            var mi = dc.GetType().GetField("btnViewFile", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var ts = mi.GetValue(dc);
            (ts as ToolStripButton).Visible = false;
        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="txt files (*.txt)|*.txt|xml files (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtTraceFile.Text = ofd.FileName;
                var fragments = File.ReadAllText(ofd.FileName);
                var myXml = $"<root>{fragments}</root>";

                xmlDoc = XDocument.Parse(myXml);
                methods = xmlDoc.Descendants("methodName").ToList();
                methodListFrom = new List<Methods>();
                methodListTo = new List<Methods>();
                bos = new List<string>();
                foreach (var x in methods)
                {
                    Methods m = new Methods();
                    m.BO = (x.PreviousNode as XElement).Value;
                    m.Method = x.Value;
                    m.Parameters = x.Parent.Descendants("parameters").FirstOrDefault();
                    m.ReturnValue = x.Parent.Descendants("returnValues").FirstOrDefault();
                    m.FullPacket = x.Parent;
                    methodListFrom.Add(m);
                    methodListTo.Add(m);
                    if (!bos.Contains(m.BO))
                        bos.Add(m.BO);
                }
                cmbBO.DataSource = bos;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(cmbFrom.SelectedItem!=null && cmdTo.SelectedItem!=null)
            {
                Methods from = cmbFrom.SelectedItem as Methods;
                Methods to = cmdTo.SelectedItem as Methods;
                XElement fromDS=null;
                XElement toDS=null;
                bool equals = false;
                if(!from.BO.Equals(to.BO))
                {
                    MessageBox.Show("You can't compare methods in different BO's");
                }
                else if(cmbFrom.SelectedIndex> cmdTo.SelectedIndex)
                {
                    MessageBox.Show("You can't compare Methods in reverse order (swap prior and target to comapre");
                }
                else if(from.Equals(to))
                {
                    fromDS = from.Parameters.Descendants().Where(d => d.Name.ToString().Contains("DataSet")).FirstOrDefault();
                    toDS = to.ReturnValue.Descendants().Where(d => d.Name.ToString().Contains("DataSet")).FirstOrDefault();
                    equals = true;
                }
                else { 
                
                    fromDS =from.ReturnValue.Descendants().Where(d => d.Name.ToString().Contains("DataSet")).FirstOrDefault();
                    toDS = to.Parameters.Descendants().Where(d => d.Name.ToString().Contains("DataSet")).FirstOrDefault();

                    if(fromDS==null)
                    {
                        MessageBox.Show("From Method isn't returning any data sets");
                    }
                    else if(toDS==null)
                    {
                        MessageBox.Show("To methods doesn't take a data set");
                    }
                    else
                    {
                        
                    }

                }
                if(toDS!=null && fromDS!=null)
                {
                    Comparer(fromDS, toDS, equals);
                }
            }
            else
            {
                MessageBox.Show("You must select which methods to compare");
            }
        }

        private void Comparer(XElement fromDS, XElement toDS, bool equal = false)
        {
            string from = fromDS.ToString();
            string to = toDS.ToString();


            
            XmlDiff diff = new XmlDiff();
            diff.IgnoreChildOrder = true;
            diff.IgnoreComments = true;
            diff.IgnoreDtd = true;
            diff.IgnoreNamespaces = true;
            diff.IgnorePI = true;
            diff.IgnorePrefixes = true;
            diff.IgnoreWhitespace = true;
            diff.IgnoreXmlDecl = true;

            StringWriter diffgramString = new StringWriter();
            XmlTextWriter diffgramXml = new XmlTextWriter(diffgramString);
            bool diffBool = diff.Compare(new XmlTextReader(new StringReader(from)), new XmlTextReader(new StringReader(to)),diffgramXml);
      
            IList<string> linesFrom = GetLines(from); ;
            IList<string> linesTo = GetLines(to);
            TextDiff Diff = new TextDiff(HashType.Crc32, true, true);
            var es = Diff.Execute(linesFrom, linesTo);
            
            
            dc.SetData(linesFrom, linesTo, es,$"{(equal ? "Data Sent To:":"Returned From:")} {(cmbFrom.SelectedItem as Methods).Method}",$"{(equal ?"Data Returned From:":"Data Sent To:")}{(cmdTo.SelectedItem as Methods).Method}");

            var dic = GenerateDiffCode(fromDS.Parent, XElement.Load(new StringReader(diffgramString.ToString())));
            bool first = true;
            StringBuilder sbOrig = new StringBuilder();
            sbOrig.AppendLine($"//Data Returned from Prior Method{Environment.NewLine}");
            sbOrig.AppendLine("//Note data type of each field not known maye not be a string allow the compiler to assist");
            StringBuilder sbChanged = new StringBuilder();
            
            sbChanged.AppendLine($"//Data Changed and Sent to the Selected Method {Environment.NewLine}");
            sbChanged.AppendLine("//Note data type of each field not known maye not be a string allow the compiler to assist");
            if (!equal)
            foreach (var x in dic)
            {
                string[] ds = x.Key.GetXPath().Split('/');
                bool found=false;
                string dataSet="";
                string dataTable = "";
                string field = "";
                int dsIdx = -1;

                foreach(string s in ds)
                {
                    dsIdx++;
                    if (s.Contains("DataSet"))
                    {
                        found = true;
                        break;
                    }
                   
                }
                if(found)
                {
                    if(first)
                    {
                        dataSet = ds[dsIdx].Substring(0, ds[dsIdx].IndexOf("["));
                        sbOrig.AppendLine($"{dataSet} ds = new {dataSet}();");
                        sbChanged.AppendLine($"{dataSet} ds = new {dataSet}();");
                        first = false;
                    }
                    dataTable = ds[++dsIdx].Substring(0, ds[dsIdx].Length); //TODO: Josh fix this line to subtract 1 from index;
                    sbOrig.Append($"ds.{dataTable}");
                    sbChanged.Append($"ds.{dataTable}");
                    field = ds[++dsIdx].Substring(0, ds[dsIdx].IndexOf("["));
                    sbOrig.Append($".{field} = ");
                    sbChanged.Append($".{field} = ");
                    sbOrig.AppendLine($"\"{x.Key.Value};\"");
                    sbChanged.AppendLine($"\"{x.Value}\";");
                }
            }
            TextArea1.Text = sbOrig.ToString();
            TextArea2.Text = sbChanged.ToString();
            



        }

        private Dictionary<XElement, string> GenerateDiffCode(XElement fromDS, XElement xElement, Dictionary<XElement,string> changedDta=null)
        {
            Dictionary<XElement, string> dc;
            if (changedDta == null)
                dc = new Dictionary<XElement, string>();
            else
                dc = changedDta;
            //fromDS = fromDS.Parent;
            XNamespace ns = "http://schemas.microsoft.com/xmltools/2002/xmldiff";
            foreach (var xe in xElement.Elements(ns + "node"))
            {
                var newfromDs = fromDS.Elements().ToList()[Convert.ToInt32(xe.Attribute("match").Value) -1];
                

                if (xe.Elements(ns+"node").Count()>0)
                {
                    dc=GenerateDiffCode(newfromDs, xe,dc);
                }
                else
                {
                    dc.Add(newfromDs, xe.Value);
                }
            }
            return dc;
        }

        private IList<string> GetLines(string text)
        {
            IList<string> lines = new List<string>();
            foreach(var s in text.Split(new[] { Environment.NewLine },StringSplitOptions.None))
            {
                lines.Add(s);
            }

            return lines;
        }

        private void cmbBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFrom.DataSource = methodListFrom.Where(b => b.BO == cmbBO.SelectedItem.ToString()).ToList();
            cmdTo.DataSource = methodListTo.Where(b => b.BO == cmbBO.SelectedItem.ToString()).ToList();
        }

        private void CmdTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var meth = cmdTo.SelectedItem as Methods;
            scinTrace.Text = meth.FullPacket.ToString();
            traceParams.Text = $"//Method Parameters{Environment.NewLine}";
            foreach (var param in meth.FullPacket.Descendants("parameter"))
            {
                string value = param.Value;
                if (param.Attribute("type").Value == "System.String")
                {
                    value = $"\"{value}\"";
                }
                else if (param.Attribute("type").Value.Contains("DataSet"))
                {
                    value = $"new {param.Attribute("type").Value}()";
                }
                traceParams.Text += $"{param.Attribute("type").Value} {param.Attribute("name").Value} = {value}{(param.Attribute("type").Value.Contains("DataSet") ? ";//Dataset should not be new this is an example,rather use your current dataset or pull from adapter" : ";")}{Environment.NewLine}";
            }
            ClearCompare();
        }

        private void ClearCompare()
        {
            TextArea1.Text = "";
            TextArea2.Text = "";
            dc.ResetText();
        }

        private void InitXmlSyntax(Scintilla TextArea)
        {
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 10;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.StyleClearAll();
            TextArea.Styles[Style.Xml.Entity].ForeColor = IntToColor(0x1670C4);
            TextArea.Styles[Style.Xml.Attribute].ForeColor = IntToColor(0x95DBFD);
            TextArea.Styles[Style.Xml.AttributeUnknown].ForeColor = IntToColor(0x860023);
            TextArea.Styles[Style.Xml.CData].ForeColor = IntToColor(0xffffff);
            TextArea.Styles[Style.Xml.Default].ForeColor = IntToColor(0xffffff);
            TextArea.Styles[Style.Xml.DoubleString].ForeColor = Color.Salmon;
            TextArea.Styles[Style.Xml.Tag].ForeColor = IntToColor(0x1670C4);
            
        }

        private void CmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCompare();
        }

        private void InitSyntaxColoring(ScintillaNET.Scintilla TextArea)
        {

            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 10;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            TextArea.Lexer = Lexer.Cpp;

            TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");


            


        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }
    }
}
