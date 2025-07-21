namespace Payazob.FRM.Resume
{
    partial class frmResume1
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
            this.uc_cmbAutoPiecesLine1 = new ControlLibrary.uc_cmbAuto();
            this.uc_TextBoxDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_txtMechanical = new UC.uc_TextBox();
            this.uc_TextBox1 = new UC.uc_TextBox();
            this.uc_txtControlNumbers = new ControlLibrary.uc_txtBox(this.components);
            this.SuspendLayout();
            // 
            // uc_cmbAutoPiecesLine1
            // 
            this.uc_cmbAutoPiecesLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_cmbAutoPiecesLine1.DropDownWidth = 180;
            this.uc_cmbAutoPiecesLine1.FormattingEnabled = true;
            this.uc_cmbAutoPiecesLine1.LimitToList = true;
            this.uc_cmbAutoPiecesLine1.Location = new System.Drawing.Point(544, 143);
            this.uc_cmbAutoPiecesLine1.Name = "uc_cmbAutoPiecesLine1";
            this.uc_cmbAutoPiecesLine1.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbAutoPiecesLine1.TabIndex = 7;
            // 
            // uc_TextBoxDate1
            // 
            this.uc_TextBoxDate1.accept = false;
            this.uc_TextBoxDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_TextBoxDate1.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDate1.Location = new System.Drawing.Point(630, 23);
            this.uc_TextBoxDate1.Mask = "0000/00/00";
            this.uc_TextBoxDate1.Name = "uc_TextBoxDate1";
            this.uc_TextBoxDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_TextBoxDate1.Size = new System.Drawing.Size(112, 20);
            this.uc_TextBoxDate1.TabIndex = 6;
            // 
            // uc_txtMechanical
            // 
            this.uc_txtMechanical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtMechanical.IsInteger = false;
            this.uc_txtMechanical.IsNumber = false;
            this.uc_txtMechanical.IsTime = false;
            this.uc_txtMechanical.Location = new System.Drawing.Point(300, 185);
            this.uc_txtMechanical.multitextbox = true;
            this.uc_txtMechanical.Name = "uc_txtMechanical";
            this.uc_txtMechanical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_txtMechanical.Size = new System.Drawing.Size(356, 51);
            this.uc_txtMechanical.TabIndex = 8;
            // 
            // uc_TextBox1
            // 
            this.uc_TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_TextBox1.IsInteger = false;
            this.uc_TextBox1.IsNumber = false;
            this.uc_TextBox1.IsTime = false;
            this.uc_TextBox1.Location = new System.Drawing.Point(463, 66);
            this.uc_TextBox1.multitextbox = false;
            this.uc_TextBox1.Name = "uc_TextBox1";
            this.uc_TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_TextBox1.Size = new System.Drawing.Size(243, 21);
            this.uc_TextBox1.TabIndex = 8;
            // 
            // uc_txtControlNumbers
            // 
            this.uc_txtControlNumbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtControlNumbers.IsInteger = false;
            this.uc_txtControlNumbers.IsNumber = false;
            this.uc_txtControlNumbers.IsTime = false;
            this.uc_txtControlNumbers.Location = new System.Drawing.Point(225, 44);
            this.uc_txtControlNumbers.MaxLength = 7;
            this.uc_txtControlNumbers.Name = "uc_txtControlNumbers";
            this.uc_txtControlNumbers.Size = new System.Drawing.Size(121, 20);
            this.uc_txtControlNumbers.TabIndex = 9;
            this.uc_txtControlNumbers.Text = "0";
            this.uc_txtControlNumbers.textWithcomma = null;
            this.uc_txtControlNumbers.textWithoutcomma = null;
            // 
            // frmResume1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 453);
            this.Controls.Add(this.uc_txtControlNumbers);
            this.Controls.Add(this.uc_cmbAutoPiecesLine1);
            this.Controls.Add(this.uc_TextBoxDate1);
            this.Controls.Add(this.uc_TextBox1);
            this.Controls.Add(this.uc_txtMechanical);
            this.Name = "frmResume1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmResume1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.uc_cmbAuto uc_cmbAutoPiecesLine1;
        private ControlLibrary.uc_TextBoxDate uc_TextBoxDate1;
        private UC.uc_TextBox uc_txtMechanical;
        private UC.uc_TextBox uc_TextBox1;
        private ControlLibrary.uc_txtBox uc_txtControlNumbers;
    }
}