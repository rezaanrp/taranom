namespace ControlLibrary
{
    partial class uc_filter_Picese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_filter_Picese));
            this.groupBox_Header = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_and = new System.Windows.Forms.Button();
            this.uc_cmbAuto = new ControlLibrary.uc_cmbAuto();
            this.lbl_type = new System.Windows.Forms.Label();
            this.groupBox_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Header
            // 
            this.groupBox_Header.Controls.Add(this.panel1);
            this.groupBox_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Header.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Header.Name = "groupBox_Header";
            this.groupBox_Header.Size = new System.Drawing.Size(279, 120);
            this.groupBox_Header.TabIndex = 4;
            this.groupBox_Header.TabStop = false;
            this.groupBox_Header.Text = "فیلتر نوع جنس";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.btn_and);
            this.panel1.Controls.Add(this.uc_cmbAuto);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 101);
            this.panel1.TabIndex = 0;
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_del.BackgroundImage")));
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del.Location = new System.Drawing.Point(21, 14);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(28, 23);
            this.btn_del.TabIndex = 2;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_and
            // 
            this.btn_and.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_and.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_and.BackgroundImage")));
            this.btn_and.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_and.Location = new System.Drawing.Point(55, 14);
            this.btn_and.Name = "btn_and";
            this.btn_and.Size = new System.Drawing.Size(28, 23);
            this.btn_and.TabIndex = 1;
            this.btn_and.UseVisualStyleBackColor = true;
            this.btn_and.Click += new System.EventHandler(this.btn_and_Click);
            // 
            // uc_cmbAuto
            // 
            this.uc_cmbAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_cmbAuto.DropDownWidth = 180;
            this.uc_cmbAuto.FormattingEnabled = true;
            this.uc_cmbAuto.LimitToList = true;
            this.uc_cmbAuto.Location = new System.Drawing.Point(94, 14);
            this.uc_cmbAuto.Name = "uc_cmbAuto";
            this.uc_cmbAuto.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbAuto.TabIndex = 0;
            // 
            // lbl_type
            // 
            this.lbl_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(208, 17);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(50, 13);
            this.lbl_type.TabIndex = 70;
            this.lbl_type.Text = "نوع جنس:";
            // 
            // uc_filter_Picese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Header);
            this.Name = "uc_filter_Picese";
            this.Size = new System.Drawing.Size(279, 120);
            this.groupBox_Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_and;
        public System.Windows.Forms.GroupBox groupBox_Header;
        public System.Windows.Forms.Label lbl_type;
        private uc_cmbAuto uc_cmbAuto;
    }
}
