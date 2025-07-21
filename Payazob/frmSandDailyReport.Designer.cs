namespace Payazob
{
    partial class frmSandDailyReport
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
            this.uc_txtComment = new UC.uc_TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uc_txtReportOther = new UC.uc_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uc_txtElectric = new UC.uc_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uc_txtMechanical = new UC.uc_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_cmbSuperviser = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbShift = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbAutoPiecesLine2 = new ControlLibrary.uc_cmbAuto();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uc_TextBoxDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.uc_cmbAutoPiecesLine1 = new ControlLibrary.uc_cmbAuto();
            this.label8 = new System.Windows.Forms.Label();
            this.uc_cmbAutoMachine = new ControlLibrary.uc_cmbAuto();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uc_txtComment
            // 
            this.uc_txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtComment.IsInteger = false;
            this.uc_txtComment.IsNumber = false;
            this.uc_txtComment.IsTime = false;
            this.uc_txtComment.Location = new System.Drawing.Point(13, 158);
            this.uc_txtComment.multitextbox = true;
            this.uc_txtComment.Name = "uc_txtComment";
            this.uc_txtComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_txtComment.Size = new System.Drawing.Size(356, 51);
            this.uc_txtComment.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 158);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "توضیحات:";
            // 
            // uc_txtReportOther
            // 
            this.uc_txtReportOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtReportOther.IsInteger = false;
            this.uc_txtReportOther.IsNumber = false;
            this.uc_txtReportOther.IsTime = false;
            this.uc_txtReportOther.Location = new System.Drawing.Point(492, 158);
            this.uc_txtReportOther.multitextbox = true;
            this.uc_txtReportOther.Name = "uc_txtReportOther";
            this.uc_txtReportOther.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_txtReportOther.Size = new System.Drawing.Size(356, 51);
            this.uc_txtReportOther.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 158);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "سایر:";
            // 
            // uc_txtElectric
            // 
            this.uc_txtElectric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtElectric.IsInteger = false;
            this.uc_txtElectric.IsNumber = false;
            this.uc_txtElectric.IsTime = false;
            this.uc_txtElectric.Location = new System.Drawing.Point(13, 90);
            this.uc_txtElectric.multitextbox = true;
            this.uc_txtElectric.Name = "uc_txtElectric";
            this.uc_txtElectric.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_txtElectric.Size = new System.Drawing.Size(356, 51);
            this.uc_txtElectric.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 90);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "گزارش برقی:";
            // 
            // uc_txtMechanical
            // 
            this.uc_txtMechanical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtMechanical.IsInteger = false;
            this.uc_txtMechanical.IsNumber = false;
            this.uc_txtMechanical.IsTime = false;
            this.uc_txtMechanical.Location = new System.Drawing.Point(492, 90);
            this.uc_txtMechanical.multitextbox = true;
            this.uc_txtMechanical.Name = "uc_txtMechanical";
            this.uc_txtMechanical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_txtMechanical.Size = new System.Drawing.Size(356, 51);
            this.uc_txtMechanical.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(854, 90);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "گزارش مکانیکی:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "تاریخ:";
            // 
            // uc_cmbSuperviser
            // 
            this.uc_cmbSuperviser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_cmbSuperviser.DropDownWidth = 180;
            this.uc_cmbSuperviser.FormattingEnabled = true;
            this.uc_cmbSuperviser.LimitToList = true;
            this.uc_cmbSuperviser.Location = new System.Drawing.Point(13, 48);
            this.uc_cmbSuperviser.Name = "uc_cmbSuperviser";
            this.uc_cmbSuperviser.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbSuperviser.TabIndex = 4;
            // 
            // uc_cmbShift
            // 
            this.uc_cmbShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_cmbShift.DropDownWidth = 180;
            this.uc_cmbShift.FormattingEnabled = true;
            this.uc_cmbShift.LimitToList = true;
            this.uc_cmbShift.Location = new System.Drawing.Point(257, 48);
            this.uc_cmbShift.Name = "uc_cmbShift";
            this.uc_cmbShift.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbShift.TabIndex = 3;
            // 
            // uc_cmbAutoPiecesLine2
            // 
            this.uc_cmbAutoPiecesLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_cmbAutoPiecesLine2.DropDownWidth = 180;
            this.uc_cmbAutoPiecesLine2.FormattingEnabled = true;
            this.uc_cmbAutoPiecesLine2.LimitToList = true;
            this.uc_cmbAutoPiecesLine2.Location = new System.Drawing.Point(492, 48);
            this.uc_cmbAutoPiecesLine2.Name = "uc_cmbAutoPiecesLine2";
            this.uc_cmbAutoPiecesLine2.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbAutoPiecesLine2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "قطعه خط 2:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "نام شیفت:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "مسئول ماسه سازی:";
            // 
            // uc_TextBoxDate1
            // 
            this.uc_TextBoxDate1.accept = false;
            this.uc_TextBoxDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_TextBoxDate1.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDate1.Location = new System.Drawing.Point(736, 16);
            this.uc_TextBoxDate1.Mask = "0000/00/00";
            this.uc_TextBoxDate1.Name = "uc_TextBoxDate1";
            this.uc_TextBoxDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_TextBoxDate1.Size = new System.Drawing.Size(112, 21);
            this.uc_TextBoxDate1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TARANOM.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(71, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_send
            // 
            this.btn_send.BackgroundImage = global::TARANOM.Properties.Resources.check;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.Location = new System.Drawing.Point(13, 224);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(43, 37);
            this.btn_send.TabIndex = 10;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // uc_cmbAutoPiecesLine1
            // 
            this.uc_cmbAutoPiecesLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_cmbAutoPiecesLine1.DropDownWidth = 180;
            this.uc_cmbAutoPiecesLine1.FormattingEnabled = true;
            this.uc_cmbAutoPiecesLine1.LimitToList = true;
            this.uc_cmbAutoPiecesLine1.Location = new System.Drawing.Point(736, 48);
            this.uc_cmbAutoPiecesLine1.Name = "uc_cmbAutoPiecesLine1";
            this.uc_cmbAutoPiecesLine1.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbAutoPiecesLine1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(849, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "قطعه خط 1:";
            // 
            // uc_cmbAutoMachine
            // 
            this.uc_cmbAutoMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_cmbAutoMachine.DropDownWidth = 180;
            this.uc_cmbAutoMachine.FormattingEnabled = true;
            this.uc_cmbAutoMachine.LimitToList = true;
            this.uc_cmbAutoMachine.Location = new System.Drawing.Point(492, 17);
            this.uc_cmbAutoMachine.Name = "uc_cmbAutoMachine";
            this.uc_cmbAutoMachine.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbAutoMachine.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 113;
            this.label9.Text = "نام دستگاه:";
            // 
            // frmSandDailyReport
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(943, 268);
            this.Controls.Add(this.uc_cmbAutoMachine);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uc_cmbAutoPiecesLine1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.uc_TextBoxDate1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uc_cmbSuperviser);
            this.Controls.Add(this.uc_cmbShift);
            this.Controls.Add(this.uc_cmbAutoPiecesLine2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uc_txtComment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uc_txtReportOther);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uc_txtElectric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uc_txtMechanical);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSandDailyReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.uc_TextBox uc_txtComment;
        private System.Windows.Forms.Label label12;
        private UC.uc_TextBox uc_txtReportOther;
        private System.Windows.Forms.Label label4;
        private UC.uc_TextBox uc_txtElectric;
        private System.Windows.Forms.Label label3;
        private UC.uc_TextBox uc_txtMechanical;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private ControlLibrary.uc_cmbAuto uc_cmbSuperviser;
        private ControlLibrary.uc_cmbAuto uc_cmbShift;
        private ControlLibrary.uc_cmbAuto uc_cmbAutoPiecesLine2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ControlLibrary.uc_TextBoxDate uc_TextBoxDate1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_send;
        private ControlLibrary.uc_cmbAuto uc_cmbAutoPiecesLine1;
        private System.Windows.Forms.Label label8;
        private ControlLibrary.uc_cmbAuto uc_cmbAutoMachine;
        private System.Windows.Forms.Label label9;
    }
}