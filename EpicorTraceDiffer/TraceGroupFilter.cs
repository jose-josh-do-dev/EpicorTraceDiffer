using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EpicorTraceDiffer
{
    public partial class TraceGroupFilter : Form
    {
        public XElement selectedTraceGroup = null;
        public TraceGroupFilter(List<XElement> tgs)
        {
            InitializeComponent();
            this.cmbTraceGroup.DataSource = tgs;
            this.cmbTraceGroup.DisplayMember = "FirstAttribute";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.selectedTraceGroup = cmbTraceGroup?.SelectedItem as XElement;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.selectedTraceGroup = null;
        }
    }
}
