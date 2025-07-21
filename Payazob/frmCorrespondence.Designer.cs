namespace Payazob
{
    partial class frmCorrespondence
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbInput = new System.Windows.Forms.TabPage();
            this.uc_cmb_SerialNumberRefrence = new ControlLibrary.uc_combobox();
            this.label8 = new System.Windows.Forms.Label();
            this.uc_txtComment = new UC.uc_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uc_txtSubject = new UC.uc_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uc_txtTo = new UC.uc_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_cmbCompony = new ControlLibrary.uc_combobox();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_txtSerialNumber = new UC.uc_TextBox();
            this.uc_mtxtDate = new ControlLibrary.uc_mtxtDate();
            this.tbOutput = new System.Windows.Forms.TabPage();
            this.uc_cmbSerialNumber = new ControlLibrary.uc_combobox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.uc_txtToOutput = new UC.uc_TextBox();
            this.uc_cmb_user = new ControlLibrary.uc_combobox();
            this.uc_txtCommentOutput = new UC.uc_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uc_txtSubjectOutput = new UC.uc_TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.uc_componyOutput = new ControlLibrary.uc_combobox();
            this.label12 = new System.Windows.Forms.Label();
            this.uc_SerialNumberOutput = new UC.uc_TextBox();
            this.uc_mtxtDateOutput = new ControlLibrary.uc_mtxtDate();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lst_image = new System.Windows.Forms.ListBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.ucStatusBar1 = new ControlLibrary.ucStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbInput.SuspendLayout();
            this.tbOutput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucStatusBar1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(962, 462);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.panel1.Size = new System.Drawing.Size(962, 430);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(9, 9);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_send);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(944, 421);
            this.splitContainer2.SplitterDistance = 388;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(944, 388);
            this.splitContainer3.SplitterDistance = 636;
            this.splitContainer3.TabIndex = 73;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbInput);
            this.tabControl1.Controls.Add(this.tbOutput);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.Controls.Add(this.uc_cmb_SerialNumberRefrence);
            this.tbInput.Controls.Add(this.label8);
            this.tbInput.Controls.Add(this.uc_txtComment);
            this.tbInput.Controls.Add(this.label7);
            this.tbInput.Controls.Add(this.label4);
            this.tbInput.Controls.Add(this.uc_txtSubject);
            this.tbInput.Controls.Add(this.label3);
            this.tbInput.Controls.Add(this.uc_txtTo);
            this.tbInput.Controls.Add(this.label2);
            this.tbInput.Controls.Add(this.uc_cmbCompony);
            this.tbInput.Controls.Add(this.label1);
            this.tbInput.Controls.Add(this.uc_txtSerialNumber);
            this.tbInput.Controls.Add(this.uc_mtxtDate);
            this.tbInput.Location = new System.Drawing.Point(4, 22);
            this.tbInput.Name = "tbInput";
            this.tbInput.Padding = new System.Windows.Forms.Padding(3);
            this.tbInput.Size = new System.Drawing.Size(628, 362);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "نامه های وارده";
            this.tbInput.UseVisualStyleBackColor = true;
            // 
            // uc_cmb_SerialNumberRefrence
            // 
            this.uc_cmb_SerialNumberRefrence.DataSource = null;
            this.uc_cmb_SerialNumberRefrence.DisplayMember = "";
            this.uc_cmb_SerialNumberRefrence.Location = new System.Drawing.Point(425, 103);
            this.uc_cmb_SerialNumberRefrence.Name = "uc_cmb_SerialNumberRefrence";
            this.uc_cmb_SerialNumberRefrence.SelectedIndex = -1;
            this.uc_cmb_SerialNumberRefrence.SelectedText = "";
            this.uc_cmb_SerialNumberRefrence.SelectedValue = null;
            this.uc_cmb_SerialNumberRefrence.Size = new System.Drawing.Size(112, 21);
            this.uc_cmb_SerialNumberRefrence.TabIndex = 5;
            this.uc_cmb_SerialNumberRefrence.ucSize = new System.Drawing.Size(112, 21);
            this.uc_cmb_SerialNumberRefrence.ValueMember = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "عطف به نامه:";
            // 
            // uc_txtComment
            // 
            this.uc_txtComment.IsInteger = false;
            this.uc_txtComment.IsNumber = false;
            this.uc_txtComment.IsTime = false;
            this.uc_txtComment.Location = new System.Drawing.Point(17, 162);
            this.uc_txtComment.multitextbox = true;
            this.uc_txtComment.Name = "uc_txtComment";
            this.uc_txtComment.Size = new System.Drawing.Size(522, 80);
            this.uc_txtComment.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "توضیحات:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "موضوع:";
            // 
            // uc_txtSubject
            // 
            this.uc_txtSubject.IsInteger = false;
            this.uc_txtSubject.IsNumber = false;
            this.uc_txtSubject.IsTime = false;
            this.uc_txtSubject.Location = new System.Drawing.Point(228, 14);
            this.uc_txtSubject.multitextbox = false;
            this.uc_txtSubject.Name = "uc_txtSubject";
            this.uc_txtSubject.Size = new System.Drawing.Size(311, 22);
            this.uc_txtSubject.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "جناب آقا/خانم:";
            // 
            // uc_txtTo
            // 
            this.uc_txtTo.IsInteger = false;
            this.uc_txtTo.IsNumber = false;
            this.uc_txtTo.IsTime = false;
            this.uc_txtTo.Location = new System.Drawing.Point(17, 59);
            this.uc_txtTo.multitextbox = false;
            this.uc_txtTo.Name = "uc_txtTo";
            this.uc_txtTo.Size = new System.Drawing.Size(115, 22);
            this.uc_txtTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام شرکت:";
            // 
            // uc_cmbCompony
            // 
            this.uc_cmbCompony.DataSource = null;
            this.uc_cmbCompony.DisplayMember = "";
            this.uc_cmbCompony.Location = new System.Drawing.Point(228, 59);
            this.uc_cmbCompony.Name = "uc_cmbCompony";
            this.uc_cmbCompony.SelectedIndex = -1;
            this.uc_cmbCompony.SelectedText = "";
            this.uc_cmbCompony.SelectedValue = null;
            this.uc_cmbCompony.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbCompony.TabIndex = 3;
            this.uc_cmbCompony.ucSize = new System.Drawing.Size(112, 21);
            this.uc_cmbCompony.ValueMember = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "شماره نامه:";
            // 
            // uc_txtSerialNumber
            // 
            this.uc_txtSerialNumber.IsInteger = false;
            this.uc_txtSerialNumber.IsNumber = false;
            this.uc_txtSerialNumber.IsTime = false;
            this.uc_txtSerialNumber.Location = new System.Drawing.Point(17, 17);
            this.uc_txtSerialNumber.multitextbox = false;
            this.uc_txtSerialNumber.Name = "uc_txtSerialNumber";
            this.uc_txtSerialNumber.Size = new System.Drawing.Size(115, 22);
            this.uc_txtSerialNumber.TabIndex = 1;
            // 
            // uc_mtxtDate
            // 
            this.uc_mtxtDate.Location = new System.Drawing.Point(417, 54);
            this.uc_mtxtDate.Name = "uc_mtxtDate";
            this.uc_mtxtDate.Size = new System.Drawing.Size(179, 27);
            this.uc_mtxtDate.TabIndex = 2;
            this.uc_mtxtDate.Text_label = "تاریخ:";
            // 
            // tbOutput
            // 
            this.tbOutput.Controls.Add(this.uc_cmbSerialNumber);
            this.tbOutput.Controls.Add(this.label5);
            this.tbOutput.Controls.Add(this.label13);
            this.tbOutput.Controls.Add(this.uc_txtToOutput);
            this.tbOutput.Controls.Add(this.uc_cmb_user);
            this.tbOutput.Controls.Add(this.uc_txtCommentOutput);
            this.tbOutput.Controls.Add(this.label6);
            this.tbOutput.Controls.Add(this.label9);
            this.tbOutput.Controls.Add(this.uc_txtSubjectOutput);
            this.tbOutput.Controls.Add(this.label10);
            this.tbOutput.Controls.Add(this.label11);
            this.tbOutput.Controls.Add(this.uc_componyOutput);
            this.tbOutput.Controls.Add(this.label12);
            this.tbOutput.Controls.Add(this.uc_SerialNumberOutput);
            this.tbOutput.Controls.Add(this.uc_mtxtDateOutput);
            this.tbOutput.Location = new System.Drawing.Point(4, 22);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tbOutput.Size = new System.Drawing.Size(628, 362);
            this.tbOutput.TabIndex = 1;
            this.tbOutput.Text = "نامه های صادره";
            this.tbOutput.UseVisualStyleBackColor = true;
            // 
            // uc_cmbSerialNumber
            // 
            this.uc_cmbSerialNumber.DataSource = null;
            this.uc_cmbSerialNumber.DisplayMember = "";
            this.uc_cmbSerialNumber.Location = new System.Drawing.Point(430, 111);
            this.uc_cmbSerialNumber.Name = "uc_cmbSerialNumber";
            this.uc_cmbSerialNumber.SelectedIndex = -1;
            this.uc_cmbSerialNumber.SelectedText = "";
            this.uc_cmbSerialNumber.SelectedValue = null;
            this.uc_cmbSerialNumber.Size = new System.Drawing.Size(112, 21);
            this.uc_cmbSerialNumber.TabIndex = 5;
            this.uc_cmbSerialNumber.ucSize = new System.Drawing.Size(112, 21);
            this.uc_cmbSerialNumber.ValueMember = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "عطف به نامه:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 94;
            this.label13.Text = "جناب آقا/خانم:";
            // 
            // uc_txtToOutput
            // 
            this.uc_txtToOutput.IsInteger = false;
            this.uc_txtToOutput.IsNumber = false;
            this.uc_txtToOutput.IsTime = false;
            this.uc_txtToOutput.Location = new System.Drawing.Point(20, 67);
            this.uc_txtToOutput.multitextbox = false;
            this.uc_txtToOutput.Name = "uc_txtToOutput";
            this.uc_txtToOutput.Size = new System.Drawing.Size(115, 22);
            this.uc_txtToOutput.TabIndex = 4;
            // 
            // uc_cmb_user
            // 
            this.uc_cmb_user.DataSource = null;
            this.uc_cmb_user.DisplayMember = "";
            this.uc_cmb_user.Location = new System.Drawing.Point(231, 111);
            this.uc_cmb_user.Name = "uc_cmb_user";
            this.uc_cmb_user.SelectedIndex = -1;
            this.uc_cmb_user.SelectedText = "";
            this.uc_cmb_user.SelectedValue = null;
            this.uc_cmb_user.Size = new System.Drawing.Size(112, 21);
            this.uc_cmb_user.TabIndex = 6;
            this.uc_cmb_user.ucSize = new System.Drawing.Size(112, 21);
            this.uc_cmb_user.ValueMember = "";
            // 
            // uc_txtCommentOutput
            // 
            this.uc_txtCommentOutput.IsInteger = false;
            this.uc_txtCommentOutput.IsNumber = false;
            this.uc_txtCommentOutput.IsTime = false;
            this.uc_txtCommentOutput.Location = new System.Drawing.Point(20, 170);
            this.uc_txtCommentOutput.multitextbox = true;
            this.uc_txtCommentOutput.Name = "uc_txtCommentOutput";
            this.uc_txtCommentOutput.Size = new System.Drawing.Size(522, 80);
            this.uc_txtCommentOutput.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "توضیحات:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "موضوع:";
            // 
            // uc_txtSubjectOutput
            // 
            this.uc_txtSubjectOutput.IsInteger = false;
            this.uc_txtSubjectOutput.IsNumber = false;
            this.uc_txtSubjectOutput.IsTime = false;
            this.uc_txtSubjectOutput.Location = new System.Drawing.Point(231, 22);
            this.uc_txtSubjectOutput.multitextbox = false;
            this.uc_txtSubjectOutput.Name = "uc_txtSubjectOutput";
            this.uc_txtSubjectOutput.Size = new System.Drawing.Size(311, 22);
            this.uc_txtSubjectOutput.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "از طرف:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "نام شرکت:";
            // 
            // uc_componyOutput
            // 
            this.uc_componyOutput.DataSource = null;
            this.uc_componyOutput.DisplayMember = "";
            this.uc_componyOutput.Location = new System.Drawing.Point(231, 67);
            this.uc_componyOutput.Name = "uc_componyOutput";
            this.uc_componyOutput.SelectedIndex = -1;
            this.uc_componyOutput.SelectedText = "";
            this.uc_componyOutput.SelectedValue = null;
            this.uc_componyOutput.Size = new System.Drawing.Size(112, 21);
            this.uc_componyOutput.TabIndex = 3;
            this.uc_componyOutput.ucSize = new System.Drawing.Size(112, 21);
            this.uc_componyOutput.ValueMember = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "شماره نامه:";
            // 
            // uc_SerialNumberOutput
            // 
            this.uc_SerialNumberOutput.IsInteger = false;
            this.uc_SerialNumberOutput.IsNumber = false;
            this.uc_SerialNumberOutput.IsTime = false;
            this.uc_SerialNumberOutput.Location = new System.Drawing.Point(20, 25);
            this.uc_SerialNumberOutput.multitextbox = false;
            this.uc_SerialNumberOutput.Name = "uc_SerialNumberOutput";
            this.uc_SerialNumberOutput.Size = new System.Drawing.Size(115, 22);
            this.uc_SerialNumberOutput.TabIndex = 1;
            // 
            // uc_mtxtDateOutput
            // 
            this.uc_mtxtDateOutput.Location = new System.Drawing.Point(420, 62);
            this.uc_mtxtDateOutput.Name = "uc_mtxtDateOutput";
            this.uc_mtxtDateOutput.Size = new System.Drawing.Size(179, 27);
            this.uc_mtxtDateOutput.TabIndex = 2;
            this.uc_mtxtDateOutput.Text_label = "تاریخ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lst_image);
            this.groupBox1.Controls.Add(this.btn_Select);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 388);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصویر نامه";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(13, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // lst_image
            // 
            this.lst_image.FormattingEnabled = true;
            this.lst_image.Location = new System.Drawing.Point(13, 249);
            this.lst_image.Name = "lst_image";
            this.lst_image.Size = new System.Drawing.Size(276, 69);
            this.lst_image.TabIndex = 71;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(174, 338);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(69, 22);
            this.btn_Select.TabIndex = 0;
            this.btn_Select.Text = "انتخاب تصویر";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(61, 338);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 22);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(13, 2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "ارسال";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // ucStatusBar1
            // 
            this.ucStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucStatusBar1.Location = new System.Drawing.Point(0, 4);
            this.ucStatusBar1.Name = "ucStatusBar1";
            this.ucStatusBar1.Size = new System.Drawing.Size(962, 24);
            this.ucStatusBar1.TabIndex = 0;
            // 
            // frmCorrespondence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 462);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCorrespondence";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmCorrespondence";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbInput.ResumeLayout(false);
            this.tbInput.PerformLayout();
            this.tbOutput.ResumeLayout(false);
            this.tbOutput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbInput;
        private System.Windows.Forms.TabPage tbOutput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ControlLibrary.ucStatusBar ucStatusBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_send;
        private ControlLibrary.uc_mtxtDate uc_mtxtDate;
        private System.Windows.Forms.Label label2;
        private ControlLibrary.uc_combobox uc_cmbCompony;
        private System.Windows.Forms.Label label1;
        private UC.uc_TextBox uc_txtSerialNumber;
        private System.Windows.Forms.Label label4;
        private UC.uc_TextBox uc_txtSubject;
        private System.Windows.Forms.Label label3;
        private UC.uc_TextBox uc_txtTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ListBox lst_image;
        private UC.uc_TextBox uc_txtComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private UC.uc_TextBox uc_txtCommentOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private UC.uc_TextBox uc_txtSubjectOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ControlLibrary.uc_combobox uc_componyOutput;
        private System.Windows.Forms.Label label12;
        private UC.uc_TextBox uc_SerialNumberOutput;
        private ControlLibrary.uc_mtxtDate uc_mtxtDateOutput;
        private ControlLibrary.uc_combobox uc_cmb_user;
        private System.Windows.Forms.Label label13;
        private UC.uc_TextBox uc_txtToOutput;
        private ControlLibrary.uc_combobox uc_cmb_SerialNumberRefrence;
        private System.Windows.Forms.Label label8;
        private ControlLibrary.uc_combobox uc_cmbSerialNumber;
        private System.Windows.Forms.Label label5;
    }
}