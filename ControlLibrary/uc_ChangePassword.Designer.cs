namespace ControlLibrary
{
    partial class uc_ChangePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ChangePassword));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.uc_txtBoxRePass = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxNewPass = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxOldPass = new ControlLibrary.uc_txtBox(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Ok);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uc_txtBoxRePass);
            this.groupBox1.Controls.Add(this.uc_txtBoxNewPass);
            this.groupBox1.Controls.Add(this.uc_txtBoxOldPass);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تغییر رمز عبور";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "رمز عبور قبلی:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "رمز عبور جدید:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تکرار رمز عبور جدید:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(376, 162);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 39);
            this.btn_Ok.TabIndex = 7;
            this.btn_Ok.Text = "تایید";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(272, 162);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 39);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "انصراف";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // uc_txtBoxRePass
            // 
            this.uc_txtBoxRePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxRePass.IsInteger = false;
            this.uc_txtBoxRePass.IsNumber = false;
            this.uc_txtBoxRePass.IsTime = false;
            this.uc_txtBoxRePass.Location = new System.Drawing.Point(220, 107);
            this.uc_txtBoxRePass.Name = "uc_txtBoxRePass";
            this.uc_txtBoxRePass.PasswordChar = '*';
            this.uc_txtBoxRePass.Size = new System.Drawing.Size(153, 21);
            this.uc_txtBoxRePass.TabIndex = 2;
            this.uc_txtBoxRePass.UseSystemPasswordChar = true;
            this.uc_txtBoxRePass.TextChanged += new System.EventHandler(this.uc_txtBoxNewPass_TextChanged);
            // 
            // uc_txtBoxNewPass
            // 
            this.uc_txtBoxNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxNewPass.IsInteger = false;
            this.uc_txtBoxNewPass.IsNumber = false;
            this.uc_txtBoxNewPass.IsTime = false;
            this.uc_txtBoxNewPass.Location = new System.Drawing.Point(220, 63);
            this.uc_txtBoxNewPass.Name = "uc_txtBoxNewPass";
            this.uc_txtBoxNewPass.PasswordChar = '*';
            this.uc_txtBoxNewPass.Size = new System.Drawing.Size(153, 21);
            this.uc_txtBoxNewPass.TabIndex = 1;
            this.uc_txtBoxNewPass.UseSystemPasswordChar = true;
            this.uc_txtBoxNewPass.TextChanged += new System.EventHandler(this.uc_txtBoxNewPass_TextChanged);
            // 
            // uc_txtBoxOldPass
            // 
            this.uc_txtBoxOldPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxOldPass.IsInteger = false;
            this.uc_txtBoxOldPass.IsNumber = false;
            this.uc_txtBoxOldPass.IsTime = false;
            this.uc_txtBoxOldPass.Location = new System.Drawing.Point(220, 20);
            this.uc_txtBoxOldPass.Name = "uc_txtBoxOldPass";
            this.uc_txtBoxOldPass.Size = new System.Drawing.Size(153, 21);
            this.uc_txtBoxOldPass.TabIndex = 0;
            this.uc_txtBoxOldPass.UseSystemPasswordChar = true;
            // 
            // uc_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "uc_ChangePassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(509, 218);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private uc_txtBox uc_txtBoxRePass;
        private uc_txtBox uc_txtBoxNewPass;
        private uc_txtBox uc_txtBoxOldPass;
    }
}
