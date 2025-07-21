namespace ControlLibrary
{
    partial class uc_MessageBox
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
            this.uc_TextBoxDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_x_ = new System.Windows.Forms.Label();
            this.lbl_Resiver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uc_TextBoxDate1
            // 
            this.uc_TextBoxDate1.accept = false;
            this.uc_TextBoxDate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_TextBoxDate1.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDate1.Location = new System.Drawing.Point(713, 18);
            this.uc_TextBoxDate1.Mask = "0000/00/00";
            this.uc_TextBoxDate1.Name = "uc_TextBoxDate1";
            this.uc_TextBoxDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_TextBoxDate1.Size = new System.Drawing.Size(66, 21);
            this.uc_TextBoxDate1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 176);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbl_x_
            // 
            this.lbl_x_.AutoSize = true;
            this.lbl_x_.Location = new System.Drawing.Point(23, 20);
            this.lbl_x_.Name = "lbl_x_";
            this.lbl_x_.Size = new System.Drawing.Size(18, 13);
            this.lbl_x_.TabIndex = 2;
            this.lbl_x_.Text = "ID";
            // 
            // lbl_Resiver
            // 
            this.lbl_Resiver.AutoSize = true;
            this.lbl_Resiver.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl_Resiver.Location = new System.Drawing.Point(595, 20);
            this.lbl_Resiver.Name = "lbl_Resiver";
            this.lbl_Resiver.Size = new System.Drawing.Size(64, 13);
            this.lbl_Resiver.TabIndex = 3;
            this.lbl_Resiver.Text = "دریافت کننده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(306, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "فرستنده";
            // 
            // uc_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Resiver);
            this.Controls.Add(this.lbl_x_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc_TextBoxDate1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "uc_MessageBox";
            this.Size = new System.Drawing.Size(793, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uc_TextBoxDate uc_TextBoxDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_x_;
        private System.Windows.Forms.Label lbl_Resiver;
        private System.Windows.Forms.Label label2;
    }
}
