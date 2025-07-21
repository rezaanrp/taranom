namespace Payazob
{
    partial class frmNonConforming
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uc_cmbAuto_piece = new ControlLibrary.uc_cmbAuto();
            this.label10 = new System.Windows.Forms.Label();
            this.uc_mtxtDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_txtFormNumber = new UC.uc_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uc_txtTime = new UC.uc_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_txtQuarantineNumber = new UC.uc_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_txtSubstancePiece = new UC.uc_TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.uc_mtxtDateResult = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_mtxtDateActionApproval = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_mtxtDateTakenAction = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_mtxtDateNonConformTitle = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_txtResult = new UC.uc_TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uc_txtActionApproval = new UC.uc_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uc_txtTakenAction = new UC.uc_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uc_txtNonConformTitle = new UC.uc_TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.ucStatusBar1 = new ControlLibrary.ucStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.uc_cmbAuto_piece);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.uc_mtxtDate1);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtFormNumber);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtTime);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtQuarantineNumber);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtSubstancePiece);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(938, 442);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 0;
            // 
            // uc_cmbAuto_piece
            // 
            this.uc_cmbAuto_piece.DropDownWidth = 180;
            this.uc_cmbAuto_piece.FormattingEnabled = true;
            this.uc_cmbAuto_piece.LimitToList = true;
            this.uc_cmbAuto_piece.Location = new System.Drawing.Point(561, 31);
            this.uc_cmbAuto_piece.Name = "uc_cmbAuto_piece";
            this.uc_cmbAuto_piece.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_piece.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(865, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "تاریخ:";
            // 
            // uc_mtxtDate1
            // 
            this.uc_mtxtDate1.accept = false;
            this.uc_mtxtDate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDate1.Location = new System.Drawing.Point(740, 35);
            this.uc_mtxtDate1.Mask = "0000/00/00";
            this.uc_mtxtDate1.Name = "uc_mtxtDate1";
            this.uc_mtxtDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDate1.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDate1.TabIndex = 1;
            // 
            // uc_txtFormNumber
            // 
            this.uc_txtFormNumber.IsInteger = true;
            this.uc_txtFormNumber.IsNumber = true;
            this.uc_txtFormNumber.IsTime = false;
            this.uc_txtFormNumber.Location = new System.Drawing.Point(740, 7);
            this.uc_txtFormNumber.multitextbox = false;
            this.uc_txtFormNumber.Name = "uc_txtFormNumber";
            this.uc_txtFormNumber.Size = new System.Drawing.Size(119, 22);
            this.uc_txtFormNumber.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(865, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "شماره فرم:";
            // 
            // uc_txtTime
            // 
            this.uc_txtTime.IsInteger = false;
            this.uc_txtTime.IsNumber = false;
            this.uc_txtTime.IsTime = true;
            this.uc_txtTime.Location = new System.Drawing.Point(35, 29);
            this.uc_txtTime.multitextbox = false;
            this.uc_txtTime.Name = "uc_txtTime";
            this.uc_txtTime.Size = new System.Drawing.Size(70, 22);
            this.uc_txtTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "ساعت:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "تعداد قرنطینه:";
            // 
            // uc_txtQuarantineNumber
            // 
            this.uc_txtQuarantineNumber.IsInteger = true;
            this.uc_txtQuarantineNumber.IsNumber = true;
            this.uc_txtQuarantineNumber.IsTime = false;
            this.uc_txtQuarantineNumber.Location = new System.Drawing.Point(164, 29);
            this.uc_txtQuarantineNumber.multitextbox = false;
            this.uc_txtQuarantineNumber.Name = "uc_txtQuarantineNumber";
            this.uc_txtQuarantineNumber.Size = new System.Drawing.Size(124, 22);
            this.uc_txtQuarantineNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "جنس قطعه:";
            // 
            // uc_txtSubstancePiece
            // 
            this.uc_txtSubstancePiece.IsInteger = false;
            this.uc_txtSubstancePiece.IsNumber = false;
            this.uc_txtSubstancePiece.IsTime = false;
            this.uc_txtSubstancePiece.Location = new System.Drawing.Point(366, 29);
            this.uc_txtSubstancePiece.multitextbox = false;
            this.uc_txtSubstancePiece.Name = "uc_txtSubstancePiece";
            this.uc_txtSubstancePiece.Size = new System.Drawing.Size(114, 22);
            this.uc_txtSubstancePiece.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(688, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "نام قطعه:";
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
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.uc_mtxtDateResult);
            this.splitContainer2.Panel1.Controls.Add(this.uc_mtxtDateActionApproval);
            this.splitContainer2.Panel1.Controls.Add(this.uc_mtxtDateTakenAction);
            this.splitContainer2.Panel1.Controls.Add(this.uc_mtxtDateNonConformTitle);
            this.splitContainer2.Panel1.Controls.Add(this.uc_txtResult);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.uc_txtActionApproval);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.uc_txtTakenAction);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.uc_txtNonConformTitle);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_send);
            this.splitContainer2.Panel2.Controls.Add(this.ucStatusBar1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(938, 371);
            this.splitContainer2.SplitterDistance = 309;
            this.splitContainer2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(687, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "تاریخ:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(680, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "تاریخ:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(687, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "تاریخ:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(687, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "تاریخ:";
            // 
            // uc_mtxtDateResult
            // 
            this.uc_mtxtDateResult.accept = false;
            this.uc_mtxtDateResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDateResult.Location = new System.Drawing.Point(562, 222);
            this.uc_mtxtDateResult.Mask = "0000/00/00";
            this.uc_mtxtDateResult.Name = "uc_mtxtDateResult";
            this.uc_mtxtDateResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDateResult.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDateResult.TabIndex = 14;
            // 
            // uc_mtxtDateActionApproval
            // 
            this.uc_mtxtDateActionApproval.accept = false;
            this.uc_mtxtDateActionApproval.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDateActionApproval.Location = new System.Drawing.Point(562, 152);
            this.uc_mtxtDateActionApproval.Mask = "0000/00/00";
            this.uc_mtxtDateActionApproval.Name = "uc_mtxtDateActionApproval";
            this.uc_mtxtDateActionApproval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDateActionApproval.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDateActionApproval.TabIndex = 10;
            // 
            // uc_mtxtDateTakenAction
            // 
            this.uc_mtxtDateTakenAction.accept = false;
            this.uc_mtxtDateTakenAction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDateTakenAction.Location = new System.Drawing.Point(562, 82);
            this.uc_mtxtDateTakenAction.Mask = "0000/00/00";
            this.uc_mtxtDateTakenAction.Name = "uc_mtxtDateTakenAction";
            this.uc_mtxtDateTakenAction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDateTakenAction.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDateTakenAction.TabIndex = 6;
            // 
            // uc_mtxtDateNonConformTitle
            // 
            this.uc_mtxtDateNonConformTitle.accept = false;
            this.uc_mtxtDateNonConformTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDateNonConformTitle.Location = new System.Drawing.Point(562, 11);
            this.uc_mtxtDateNonConformTitle.Mask = "0000/00/00";
            this.uc_mtxtDateNonConformTitle.Name = "uc_mtxtDateNonConformTitle";
            this.uc_mtxtDateNonConformTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDateNonConformTitle.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDateNonConformTitle.TabIndex = 2;
            // 
            // uc_txtResult
            // 
            this.uc_txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtResult.IsInteger = false;
            this.uc_txtResult.IsNumber = false;
            this.uc_txtResult.IsTime = false;
            this.uc_txtResult.Location = new System.Drawing.Point(10, 247);
            this.uc_txtResult.multitextbox = true;
            this.uc_txtResult.Name = "uc_txtResult";
            this.uc_txtResult.Size = new System.Drawing.Size(911, 40);
            this.uc_txtResult.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(811, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "نتیجه اقدام انجام شده:";
            // 
            // uc_txtActionApproval
            // 
            this.uc_txtActionApproval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtActionApproval.IsInteger = false;
            this.uc_txtActionApproval.IsNumber = false;
            this.uc_txtActionApproval.IsTime = false;
            this.uc_txtActionApproval.Location = new System.Drawing.Point(10, 176);
            this.uc_txtActionApproval.multitextbox = true;
            this.uc_txtActionApproval.Name = "uc_txtActionApproval";
            this.uc_txtActionApproval.Size = new System.Drawing.Size(911, 40);
            this.uc_txtActionApproval.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(855, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "تائیده اقدام:";
            // 
            // uc_txtTakenAction
            // 
            this.uc_txtTakenAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtTakenAction.IsInteger = false;
            this.uc_txtTakenAction.IsNumber = false;
            this.uc_txtTakenAction.IsTime = false;
            this.uc_txtTakenAction.Location = new System.Drawing.Point(10, 106);
            this.uc_txtTakenAction.multitextbox = true;
            this.uc_txtTakenAction.Name = "uc_txtTakenAction";
            this.uc_txtTakenAction.Size = new System.Drawing.Size(911, 40);
            this.uc_txtTakenAction.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(835, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "اقدام انجام گرفته:";
            // 
            // uc_txtNonConformTitle
            // 
            this.uc_txtNonConformTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtNonConformTitle.IsInteger = false;
            this.uc_txtNonConformTitle.IsNumber = false;
            this.uc_txtNonConformTitle.IsTime = false;
            this.uc_txtNonConformTitle.Location = new System.Drawing.Point(10, 35);
            this.uc_txtNonConformTitle.multitextbox = true;
            this.uc_txtNonConformTitle.Name = "uc_txtNonConformTitle";
            this.uc_txtNonConformTitle.Size = new System.Drawing.Size(911, 40);
            this.uc_txtNonConformTitle.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "عنوان مغایرت:";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(10, 5);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "ارسال";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // ucStatusBar1
            // 
            this.ucStatusBar1.CausesValidation = false;
            this.ucStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucStatusBar1.Location = new System.Drawing.Point(0, 34);
            this.ucStatusBar1.Name = "ucStatusBar1";
            this.ucStatusBar1.Size = new System.Drawing.Size(938, 24);
            this.ucStatusBar1.TabIndex = 1;
            // 
            // frmNonConforming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 442);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNonConforming";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم عدم تطابق";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UC.uc_TextBox uc_txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private UC.uc_TextBox uc_txtQuarantineNumber;
        private System.Windows.Forms.Label label1;
        private UC.uc_TextBox uc_txtSubstancePiece;
        private System.Windows.Forms.Label label9;
        private UC.uc_TextBox uc_txtFormNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private UC.uc_TextBox uc_txtResult;
        private System.Windows.Forms.Label label8;
        private UC.uc_TextBox uc_txtActionApproval;
        private System.Windows.Forms.Label label7;
        private UC.uc_TextBox uc_txtTakenAction;
        private System.Windows.Forms.Label label6;
        private UC.uc_TextBox uc_txtNonConformTitle;
        private System.Windows.Forms.Label label5;
        private ControlLibrary.ucStatusBar ucStatusBar1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label10;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDate1;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_piece;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDateResult;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDateActionApproval;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDateTakenAction;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDateNonConformTitle;
    }
}