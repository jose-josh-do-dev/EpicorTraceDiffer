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
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.SuspendLayout();
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
            this.cmbFrom.Location = new System.Drawing.Point(87, 80);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(369, 21);
            this.cmbFrom.TabIndex = 2;
            // 
            // lblFromMethod
            // 
            this.lblFromMethod.AutoSize = true;
            this.lblFromMethod.Location = new System.Drawing.Point(9, 83);
            this.lblFromMethod.Name = "lblFromMethod";
            this.lblFromMethod.Size = new System.Drawing.Size(69, 13);
            this.lblFromMethod.TabIndex = 3;
            this.lblFromMethod.Text = "From Method";
            // 
            // lblToMethod
            // 
            this.lblToMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToMethod.AutoSize = true;
            this.lblToMethod.Location = new System.Drawing.Point(462, 86);
            this.lblToMethod.Name = "lblToMethod";
            this.lblToMethod.Size = new System.Drawing.Size(59, 13);
            this.lblToMethod.TabIndex = 5;
            this.lblToMethod.Text = "To Method";
            // 
            // cmdTo
            // 
            this.cmdTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTo.FormattingEnabled = true;
            this.cmdTo.Location = new System.Drawing.Point(527, 83);
            this.cmdTo.Name = "cmdTo";
            this.cmdTo.Size = new System.Drawing.Size(378, 21);
            this.cmdTo.TabIndex = 4;
            // 
            // spcMain
            // 
            this.spcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(1, 124);
            this.spcMain.Name = "spcMain";
            this.spcMain.Size = new System.Drawing.Size(904, 359);
            this.spcMain.SplitterDistance = 452;
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
            // frmTraceDiffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 534);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.spcMain);
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
    }
}

