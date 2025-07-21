namespace Payazob
{
    partial class frmSendReport
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
            this.components = new System.ComponentModel.Container();
            this.btn_Show = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_mtxtDateTo = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_mtxtDateFrom = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_cmbType = new ControlLibrary.uc_cmbAuto();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(10, 5);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(74, 32);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "نمایش";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.uc_mtxtDateTo);
            this.splitContainer1.Panel1.Controls.Add(this.uc_mtxtDateFrom);
            this.splitContainer1.Panel1.Controls.Add(this.uc_cmbType);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(531, 286);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "تاریخ:";
            // 
            // uc_mtxtDateTo
            // 
            this.uc_mtxtDateTo.accept = false;
            this.uc_mtxtDateTo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDateTo.BackColor = System.Drawing.Color.Pink;
            this.uc_mtxtDateTo.Location = new System.Drawing.Point(208, 10);
            this.uc_mtxtDateTo.Mask = "0000/00/00";
            this.uc_mtxtDateTo.Name = "uc_mtxtDateTo";
            this.uc_mtxtDateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDateTo.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDateTo.TabIndex = 1;
            // 
            // uc_mtxtDateFrom
            // 
            this.uc_mtxtDateFrom.accept = false;
            this.uc_mtxtDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDateFrom.BackColor = System.Drawing.Color.Pink;
            this.uc_mtxtDateFrom.Location = new System.Drawing.Point(353, 10);
            this.uc_mtxtDateFrom.Mask = "0000/00/00";
            this.uc_mtxtDateFrom.Name = "uc_mtxtDateFrom";
            this.uc_mtxtDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDateFrom.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDateFrom.TabIndex = 0;
            // 
            // uc_cmbType
            // 
            this.uc_cmbType.DropDownWidth = 180;
            this.uc_cmbType.FormattingEnabled = true;
            this.uc_cmbType.Items.AddRange(new object[] {
            "درصد رطوبت",
            "عبور گاز",
            "استحکام فشاری",
            "تراکم پذیری"});
            this.uc_cmbType.LimitToList = true;
            this.uc_cmbType.Location = new System.Drawing.Point(12, 9);
            this.uc_cmbType.Name = "uc_cmbType";
            this.uc_cmbType.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "تا";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_Show);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(531, 245);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 0;
            // 
            // frmSendReport
            // 
            this.AcceptButton = this.btn_Show;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 286);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSendReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmSendReport_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDateTo;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDateFrom;
        private ControlLibrary.uc_cmbAuto uc_cmbType;
    }
}