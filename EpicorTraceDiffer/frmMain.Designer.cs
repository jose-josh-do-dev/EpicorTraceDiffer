using Menees.Diffs.Controls;

namespace EpicorTraceDiffer
{
    partial class frmTraceDiffer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTrace = new System.Windows.Forms.Button();
            this.txtTraceFile = new System.Windows.Forms.TextBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.lblFromMethod = new System.Windows.Forms.Label();
            this.lblToMethod = new System.Windows.Forms.Label();
            this.cmdTo = new System.Windows.Forms.ComboBox();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.btnCompare = new System.Windows.Forms.Button();
            this.cmbBO = new System.Windows.Forms.ComboBox();
            this.lblBO = new System.Windows.Forms.Label();
            this.tabC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dc = new Menees.Diffs.Controls.DiffControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitTrace = new System.Windows.Forms.SplitContainer();
            this.traceParams = new ScintillaNET.Scintilla();
            this.scinTrace = new ScintillaNET.Scintilla();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
            this.tabC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTrace)).BeginInit();
            this.splitTrace.Panel1.SuspendLayout();
            this.splitTrace.Panel2.SuspendLayout();
            this.splitTrace.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(18, 49);
            this.btnTrace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(112, 35);
            this.btnTrace.TabIndex = 0;
            this.btnTrace.Text = "Trace File";
            this.btnTrace.UseVisualStyleBackColor = true;
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // txtTraceFile
            // 
            this.txtTraceFile.Location = new System.Drawing.Point(141, 52);
            this.txtTraceFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTraceFile.Name = "txtTraceFile";
            this.txtTraceFile.Size = new System.Drawing.Size(804, 26);
            this.txtTraceFile.TabIndex = 1;
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(130, 149);
            this.cmbFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(552, 28);
            this.cmbFrom.TabIndex = 2;
            // 
            // lblFromMethod
            // 
            this.lblFromMethod.AutoSize = true;
            this.lblFromMethod.Location = new System.Drawing.Point(18, 154);
            this.lblFromMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromMethod.Name = "lblFromMethod";
            this.lblFromMethod.Size = new System.Drawing.Size(104, 20);
            this.lblFromMethod.TabIndex = 3;
            this.lblFromMethod.Text = "From Method";
            // 
            // lblToMethod
            // 
            this.lblToMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToMethod.AutoSize = true;
            this.lblToMethod.Location = new System.Drawing.Point(693, 154);
            this.lblToMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToMethod.Name = "lblToMethod";
            this.lblToMethod.Size = new System.Drawing.Size(85, 20);
            this.lblToMethod.TabIndex = 5;
            this.lblToMethod.Text = "To Method";
            // 
            // cmdTo
            // 
            this.cmdTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTo.FormattingEnabled = true;
            this.cmdTo.Location = new System.Drawing.Point(790, 149);
            this.cmdTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdTo.Name = "cmdTo";
            this.cmdTo.Size = new System.Drawing.Size(565, 28);
            this.cmdTo.TabIndex = 4;
            this.cmdTo.SelectedIndexChanged += new System.EventHandler(this.CmdTo_SelectedIndexChanged);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(4, 5);
            this.spcMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spcMain.Name = "spcMain";
            this.spcMain.Size = new System.Drawing.Size(1337, 525);
            this.spcMain.SplitterDistance = 668;
            this.spcMain.SplitterWidth = 2;
            this.spcMain.TabIndex = 6;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompare.Location = new System.Drawing.Point(4, 768);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(112, 35);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // cmbBO
            // 
            this.cmbBO.FormattingEnabled = true;
            this.cmbBO.Location = new System.Drawing.Point(130, 108);
            this.cmbBO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBO.Name = "cmbBO";
            this.cmbBO.Size = new System.Drawing.Size(552, 28);
            this.cmbBO.TabIndex = 8;
            this.cmbBO.SelectedIndexChanged += new System.EventHandler(this.cmbBO_SelectedIndexChanged);
            // 
            // lblBO
            // 
            this.lblBO.AutoSize = true;
            this.lblBO.Location = new System.Drawing.Point(84, 112);
            this.lblBO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBO.Name = "lblBO";
            this.lblBO.Size = new System.Drawing.Size(32, 20);
            this.lblBO.TabIndex = 9;
            this.lblBO.Text = "BO";
            // 
            // tabC
            // 
            this.tabC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabC.Controls.Add(this.tabPage1);
            this.tabC.Controls.Add(this.tabPage2);
            this.tabC.Controls.Add(this.tabPage3);
            this.tabC.Location = new System.Drawing.Point(4, 191);
            this.tabC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabC.Name = "tabC";
            this.tabC.SelectedIndex = 0;
            this.tabC.Size = new System.Drawing.Size(1353, 568);
            this.tabC.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dc);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1345, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Diff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dc
            // 
            this.dc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dc.LineDiffHeight = 63;
            this.dc.Location = new System.Drawing.Point(4, 5);
            this.dc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dc.Name = "dc";
            this.dc.OverviewWidth = 38;
            this.dc.ShowWhiteSpaceInLineDiff = true;
            this.dc.Size = new System.Drawing.Size(1337, 525);
            this.dc.TabIndex = 0;
            this.dc.ViewFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.spcMain);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1345, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitTrace);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1345, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "To Method Trace";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitTrace
            // 
            this.splitTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTrace.Location = new System.Drawing.Point(3, 3);
            this.splitTrace.Name = "splitTrace";
            this.splitTrace.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitTrace.Panel1
            // 
            this.splitTrace.Panel1.Controls.Add(this.traceParams);
            // 
            // splitTrace.Panel2
            // 
            this.splitTrace.Panel2.Controls.Add(this.scinTrace);
            this.splitTrace.Size = new System.Drawing.Size(1339, 529);
            this.splitTrace.SplitterDistance = 100;
            this.splitTrace.SplitterWidth = 1;
            this.splitTrace.TabIndex = 0;
            // 
            // traceParams
            // 
            this.traceParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.traceParams.Location = new System.Drawing.Point(0, 0);
            this.traceParams.Name = "traceParams";
            this.traceParams.Size = new System.Drawing.Size(1339, 100);
            this.traceParams.TabIndex = 0;
            // 
            // scinTrace
            // 
            this.scinTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scinTrace.Lexer = ScintillaNET.Lexer.Xml;
            this.scinTrace.Location = new System.Drawing.Point(0, 0);
            this.scinTrace.Name = "scinTrace";
            this.scinTrace.Size = new System.Drawing.Size(1339, 428);
            this.scinTrace.TabIndex = 0;
            // 
            // frmTraceDiffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 822);
            this.Controls.Add(this.tabC);
            this.Controls.Add(this.lblBO);
            this.Controls.Add(this.cmbBO);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblToMethod);
            this.Controls.Add(this.cmdTo);
            this.Controls.Add(this.lblFromMethod);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.txtTraceFile);
            this.Controls.Add(this.btnTrace);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTraceDiffer";
            this.Text = "Epicor Trace Differ";
            this.Load += new System.EventHandler(this.frmTraceDiffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.tabC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitTrace.Panel1.ResumeLayout(false);
            this.splitTrace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTrace)).EndInit();
            this.splitTrace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrace;
        private System.Windows.Forms.TextBox txtTraceFile;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label lblFromMethod;
        private System.Windows.Forms.Label lblToMethod;
        private System.Windows.Forms.ComboBox cmdTo;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.ComboBox cmbBO;
        private System.Windows.Forms.Label lblBO;
        private System.Windows.Forms.TabControl tabC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DiffControl dc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitTrace;
        private ScintillaNET.Scintilla traceParams;
        private ScintillaNET.Scintilla scinTrace;
    }
}

