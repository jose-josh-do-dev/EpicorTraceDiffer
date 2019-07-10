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
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
            this.tabC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(12, 32);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(75, 23);
            this.btnTrace.TabIndex = 0;
            this.btnTrace.Text = "Trace File";
            this.btnTrace.UseVisualStyleBackColor = true;
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // txtTraceFile
            // 
            this.txtTraceFile.Location = new System.Drawing.Point(94, 34);
            this.txtTraceFile.Name = "txtTraceFile";
            this.txtTraceFile.Size = new System.Drawing.Size(537, 20);
            this.txtTraceFile.TabIndex = 1;
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(87, 97);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(369, 21);
            this.cmbFrom.TabIndex = 2;
            // 
            // lblFromMethod
            // 
            this.lblFromMethod.AutoSize = true;
            this.lblFromMethod.Location = new System.Drawing.Point(12, 100);
            this.lblFromMethod.Name = "lblFromMethod";
            this.lblFromMethod.Size = new System.Drawing.Size(69, 13);
            this.lblFromMethod.TabIndex = 3;
            this.lblFromMethod.Text = "From Method";
            // 
            // lblToMethod
            // 
            this.lblToMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToMethod.AutoSize = true;
            this.lblToMethod.Location = new System.Drawing.Point(462, 100);
            this.lblToMethod.Name = "lblToMethod";
            this.lblToMethod.Size = new System.Drawing.Size(59, 13);
            this.lblToMethod.TabIndex = 5;
            this.lblToMethod.Text = "To Method";
            // 
            // cmdTo
            // 
            this.cmdTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTo.FormattingEnabled = true;
            this.cmdTo.Location = new System.Drawing.Point(527, 97);
            this.cmdTo.Name = "cmdTo";
            this.cmdTo.Size = new System.Drawing.Size(378, 21);
            this.cmdTo.TabIndex = 4;
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(3, 3);
            this.spcMain.Name = "spcMain";
            this.spcMain.Size = new System.Drawing.Size(888, 337);
            this.spcMain.SplitterDistance = 444;
            this.spcMain.SplitterWidth = 1;
            this.spcMain.TabIndex = 6;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompare.Location = new System.Drawing.Point(3, 499);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // cmbBO
            // 
            this.cmbBO.FormattingEnabled = true;
            this.cmbBO.Location = new System.Drawing.Point(87, 70);
            this.cmbBO.Name = "cmbBO";
            this.cmbBO.Size = new System.Drawing.Size(369, 21);
            this.cmbBO.TabIndex = 8;
            this.cmbBO.SelectedIndexChanged += new System.EventHandler(this.cmbBO_SelectedIndexChanged);
            // 
            // lblBO
            // 
            this.lblBO.AutoSize = true;
            this.lblBO.Location = new System.Drawing.Point(56, 73);
            this.lblBO.Name = "lblBO";
            this.lblBO.Size = new System.Drawing.Size(22, 13);
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
            this.tabC.Location = new System.Drawing.Point(3, 124);
            this.tabC.Name = "tabC";
            this.tabC.SelectedIndex = 0;
            this.tabC.Size = new System.Drawing.Size(902, 369);
            this.tabC.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Diff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dc
            // 
            this.dc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dc.Location = new System.Drawing.Point(3, 3);
            this.dc.Name = "dc";
            this.dc.OverviewWidth = 38;
            this.dc.ShowWhiteSpaceInLineDiff = true;
            this.dc.Size = new System.Drawing.Size(888, 337);
            this.dc.TabIndex = 0;
            this.dc.ViewFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.spcMain);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmTraceDiffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 534);
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
            this.Name = "frmTraceDiffer";
            this.Text = "Epicor Trace Differ";
            this.Load += new System.EventHandler(this.frmTraceDiffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.tabC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
    }
}

