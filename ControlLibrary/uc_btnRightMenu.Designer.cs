namespace ControlLibrary
{
    partial class uc_btnRightMenu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_MailBox = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_MailBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel3.Size = new System.Drawing.Size(180, 65);
            this.panel3.TabIndex = 5;
            // 
            // btn_MailBox
            // 
            this.btn_MailBox.BackColor = System.Drawing.Color.Azure;
            this.btn_MailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MailBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MailBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MailBox.Location = new System.Drawing.Point(0, 20);
            this.btn_MailBox.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MailBox.Name = "btn_MailBox";
            this.btn_MailBox.Size = new System.Drawing.Size(180, 45);
            this.btn_MailBox.TabIndex = 1;
            this.btn_MailBox.Text = "دکمه";
            this.btn_MailBox.UseVisualStyleBackColor = false;
            // 
            // uc_btnRightMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "uc_btnRightMenu";
            this.Size = new System.Drawing.Size(180, 65);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_MailBox;
    }
}
