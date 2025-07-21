namespace ControlLibrary
{
    partial class uc_RegisteringGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chb_registerby = new System.Windows.Forms.CheckBox();
            this.chb_supplierby = new System.Windows.Forms.CheckBox();
            this.chb_approveby = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chb_registerby);
            this.groupBox3.Controls.Add(this.chb_supplierby);
            this.groupBox3.Controls.Add(this.chb_approveby);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 46);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تایید کنندگان";
            // 
            // chb_registerby
            // 
            this.chb_registerby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_registerby.AutoSize = true;
            this.chb_registerby.Enabled = false;
            this.chb_registerby.Location = new System.Drawing.Point(36, 20);
            this.chb_registerby.Name = "chb_registerby";
            this.chb_registerby.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_registerby.Size = new System.Drawing.Size(80, 17);
            this.chb_registerby.TabIndex = 2;
            this.chb_registerby.Text = "checkBox3";
            this.chb_registerby.UseVisualStyleBackColor = true;
            this.chb_registerby.CheckedChanged += new System.EventHandler(this.chb_supplierby_CheckedChanged);
            // 
            // chb_supplierby
            // 
            this.chb_supplierby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_supplierby.AutoSize = true;
            this.chb_supplierby.Enabled = false;
            this.chb_supplierby.Location = new System.Drawing.Point(387, 20);
            this.chb_supplierby.Name = "chb_supplierby";
            this.chb_supplierby.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_supplierby.Size = new System.Drawing.Size(80, 17);
            this.chb_supplierby.TabIndex = 0;
            this.chb_supplierby.Text = "checkBox1";
            this.chb_supplierby.UseVisualStyleBackColor = true;
            this.chb_supplierby.CheckedChanged += new System.EventHandler(this.chb_supplierby_CheckedChanged);
            // 
            // chb_approveby
            // 
            this.chb_approveby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_approveby.AutoSize = true;
            this.chb_approveby.Enabled = false;
            this.chb_approveby.Location = new System.Drawing.Point(220, 20);
            this.chb_approveby.Name = "chb_approveby";
            this.chb_approveby.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_approveby.Size = new System.Drawing.Size(80, 17);
            this.chb_approveby.TabIndex = 1;
            this.chb_approveby.Text = "checkBox2";
            this.chb_approveby.UseVisualStyleBackColor = true;
            this.chb_approveby.CheckedChanged += new System.EventHandler(this.chb_supplierby_CheckedChanged);
            // 
            // uc_RegisteringGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "uc_RegisteringGroup";
            this.Size = new System.Drawing.Size(518, 56);
            this.Load += new System.EventHandler(this.uc_RegisteringGroup_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chb_registerby;
        private System.Windows.Forms.CheckBox chb_supplierby;
        private System.Windows.Forms.CheckBox chb_approveby;
    }
}
