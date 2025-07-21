namespace Payazob
{
    partial class frmSandMaterialUsage
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
            this.uc_txtComment = new UC.uc_TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uc_txtSumBetonit = new UC.uc_TextBox();
            this.uc_txtSumSandNew = new UC.uc_TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.uc_txtSumCoalDust = new UC.uc_TextBox();
            this.uc_txtSumWater = new UC.uc_TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.uc_txtSumOther = new UC.uc_TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.uc_txtSumSandReturn = new UC.uc_TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uc_txtBatchCount = new UC.uc_TextBox();
            this.grp_usagematerial = new System.Windows.Forms.GroupBox();
            this.btn_Other = new System.Windows.Forms.Button();
            this.uc_txtOther = new UC.uc_TextBox();
            this.uc_txtOtherNumber = new UC.uc_TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uc_txtSandReturn = new UC.uc_TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uc_txtWater = new UC.uc_TextBox();
            this.uc_txtCoalDust = new UC.uc_TextBox();
            this.uc_NewSand = new UC.uc_TextBox();
            this.uc_txtbentonit = new UC.uc_TextBox();
            this.uc_txtReportOther = new UC.uc_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uc_txtElectric = new UC.uc_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uc_txtMechanical = new UC.uc_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ucStatusBar1 = new ControlLibrary.ucStatusBar();
            this.uc_cmbAuto_piece = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbAuto_Shift = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbAuto_Superviser = new ControlLibrary.uc_cmbAuto();
            this.uc_mtxtDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_usagematerial.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Calc);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtComment);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtBatchCount);
            this.splitContainer1.Panel1.Controls.Add(this.btn_send);
            this.splitContainer1.Panel1.Controls.Add(this.grp_usagematerial);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtReportOther);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtElectric);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.uc_txtMechanical);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucStatusBar1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(962, 462);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.TabIndex = 0;
            // 
            // uc_txtComment
            // 
            this.uc_txtComment.IsInteger = false;
            this.uc_txtComment.IsNumber = false;
            this.uc_txtComment.IsTime = false;
            this.uc_txtComment.Location = new System.Drawing.Point(17, 325);
            this.uc_txtComment.multitextbox = true;
            this.uc_txtComment.Name = "uc_txtComment";
            this.uc_txtComment.Size = new System.Drawing.Size(382, 46);
            this.uc_txtComment.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "توضیحات:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uc_txtSumBetonit);
            this.groupBox2.Controls.Add(this.uc_txtSumSandNew);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.uc_txtSumCoalDust);
            this.groupBox2.Controls.Add(this.uc_txtSumWater);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.uc_txtSumOther);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.uc_txtSumSandReturn);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مجموع مواد مصرفی";
            // 
            // uc_txtSumBetonit
            // 
            this.uc_txtSumBetonit.Enabled = false;
            this.uc_txtSumBetonit.IsInteger = false;
            this.uc_txtSumBetonit.IsNumber = false;
            this.uc_txtSumBetonit.IsTime = false;
            this.uc_txtSumBetonit.Location = new System.Drawing.Point(799, 30);
            this.uc_txtSumBetonit.multitextbox = false;
            this.uc_txtSumBetonit.Name = "uc_txtSumBetonit";
            this.uc_txtSumBetonit.Size = new System.Drawing.Size(79, 22);
            this.uc_txtSumBetonit.TabIndex = 1;
            // 
            // uc_txtSumSandNew
            // 
            this.uc_txtSumSandNew.Enabled = false;
            this.uc_txtSumSandNew.IsInteger = false;
            this.uc_txtSumSandNew.IsNumber = false;
            this.uc_txtSumSandNew.IsTime = false;
            this.uc_txtSumSandNew.Location = new System.Drawing.Point(666, 30);
            this.uc_txtSumSandNew.multitextbox = false;
            this.uc_txtSumSandNew.Name = "uc_txtSumSandNew";
            this.uc_txtSumSandNew.Size = new System.Drawing.Size(79, 22);
            this.uc_txtSumSandNew.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(187, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "دیگر:";
            // 
            // uc_txtSumCoalDust
            // 
            this.uc_txtSumCoalDust.Enabled = false;
            this.uc_txtSumCoalDust.IsInteger = false;
            this.uc_txtSumCoalDust.IsNumber = false;
            this.uc_txtSumCoalDust.IsTime = false;
            this.uc_txtSumCoalDust.Location = new System.Drawing.Point(524, 30);
            this.uc_txtSumCoalDust.multitextbox = false;
            this.uc_txtSumCoalDust.Name = "uc_txtSumCoalDust";
            this.uc_txtSumCoalDust.Size = new System.Drawing.Size(79, 22);
            this.uc_txtSumCoalDust.TabIndex = 5;
            // 
            // uc_txtSumWater
            // 
            this.uc_txtSumWater.Enabled = false;
            this.uc_txtSumWater.IsInteger = false;
            this.uc_txtSumWater.IsNumber = false;
            this.uc_txtSumWater.IsTime = false;
            this.uc_txtSumWater.Location = new System.Drawing.Point(403, 30);
            this.uc_txtSumWater.multitextbox = false;
            this.uc_txtSumWater.Name = "uc_txtSumWater";
            this.uc_txtSumWater.Size = new System.Drawing.Size(79, 22);
            this.uc_txtSumWater.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(884, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "بنتونیت:";
            // 
            // uc_txtSumOther
            // 
            this.uc_txtSumOther.Enabled = false;
            this.uc_txtSumOther.IsInteger = false;
            this.uc_txtSumOther.IsNumber = false;
            this.uc_txtSumOther.IsTime = false;
            this.uc_txtSumOther.Location = new System.Drawing.Point(102, 30);
            this.uc_txtSumOther.multitextbox = false;
            this.uc_txtSumOther.Name = "uc_txtSumOther";
            this.uc_txtSumOther.Size = new System.Drawing.Size(79, 22);
            this.uc_txtSumOther.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(751, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "ماسه نو:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "ماسه برگشتی:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(609, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "گرد زغال:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(488, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "آب:";
            // 
            // uc_txtSumSandReturn
            // 
            this.uc_txtSumSandReturn.Enabled = false;
            this.uc_txtSumSandReturn.IsInteger = false;
            this.uc_txtSumSandReturn.IsNumber = false;
            this.uc_txtSumSandReturn.IsTime = false;
            this.uc_txtSumSandReturn.Location = new System.Drawing.Point(231, 30);
            this.uc_txtSumSandReturn.multitextbox = false;
            this.uc_txtSumSandReturn.Name = "uc_txtSumSandReturn";
            this.uc_txtSumSandReturn.Size = new System.Drawing.Size(79, 22);
            this.uc_txtSumSandReturn.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(900, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "مقدار بچ:";
            // 
            // uc_txtBatchCount
            // 
            this.uc_txtBatchCount.IsInteger = true;
            this.uc_txtBatchCount.IsNumber = true;
            this.uc_txtBatchCount.IsTime = false;
            this.uc_txtBatchCount.Location = new System.Drawing.Point(815, 119);
            this.uc_txtBatchCount.multitextbox = false;
            this.uc_txtBatchCount.Name = "uc_txtBatchCount";
            this.uc_txtBatchCount.Size = new System.Drawing.Size(79, 22);
            this.uc_txtBatchCount.TabIndex = 2;
            this.uc_txtBatchCount.Leave += new System.EventHandler(this.uc_txtBatchCount_Leave);
            // 
            // grp_usagematerial
            // 
            this.grp_usagematerial.Controls.Add(this.btn_Other);
            this.grp_usagematerial.Controls.Add(this.uc_txtOther);
            this.grp_usagematerial.Controls.Add(this.uc_txtOtherNumber);
            this.grp_usagematerial.Controls.Add(this.label11);
            this.grp_usagematerial.Controls.Add(this.uc_txtSandReturn);
            this.grp_usagematerial.Controls.Add(this.label10);
            this.grp_usagematerial.Controls.Add(this.label8);
            this.grp_usagematerial.Controls.Add(this.label6);
            this.grp_usagematerial.Controls.Add(this.label5);
            this.grp_usagematerial.Controls.Add(this.uc_txtWater);
            this.grp_usagematerial.Controls.Add(this.uc_txtCoalDust);
            this.grp_usagematerial.Controls.Add(this.uc_NewSand);
            this.grp_usagematerial.Controls.Add(this.uc_txtbentonit);
            this.grp_usagematerial.Location = new System.Drawing.Point(12, 48);
            this.grp_usagematerial.Name = "grp_usagematerial";
            this.grp_usagematerial.Size = new System.Drawing.Size(940, 65);
            this.grp_usagematerial.TabIndex = 1;
            this.grp_usagematerial.TabStop = false;
            this.grp_usagematerial.Text = "مواد مصرفی:";
            // 
            // btn_Other
            // 
            this.btn_Other.Location = new System.Drawing.Point(177, 23);
            this.btn_Other.Name = "btn_Other";
            this.btn_Other.Size = new System.Drawing.Size(48, 23);
            this.btn_Other.TabIndex = 5;
            this.btn_Other.Text = "دیگر";
            this.btn_Other.UseVisualStyleBackColor = true;
            this.btn_Other.Click += new System.EventHandler(this.btn_Other_Click);
            // 
            // uc_txtOther
            // 
            this.uc_txtOther.IsInteger = false;
            this.uc_txtOther.IsNumber = false;
            this.uc_txtOther.IsTime = false;
            this.uc_txtOther.Location = new System.Drawing.Point(92, 25);
            this.uc_txtOther.multitextbox = false;
            this.uc_txtOther.Name = "uc_txtOther";
            this.uc_txtOther.Size = new System.Drawing.Size(79, 22);
            this.uc_txtOther.TabIndex = 6;
            this.uc_txtOther.Visible = false;
            // 
            // uc_txtOtherNumber
            // 
            this.uc_txtOtherNumber.IsInteger = false;
            this.uc_txtOtherNumber.IsNumber = true;
            this.uc_txtOtherNumber.IsTime = false;
            this.uc_txtOtherNumber.Location = new System.Drawing.Point(7, 25);
            this.uc_txtOtherNumber.multitextbox = false;
            this.uc_txtOtherNumber.Name = "uc_txtOtherNumber";
            this.uc_txtOtherNumber.Size = new System.Drawing.Size(79, 22);
            this.uc_txtOtherNumber.TabIndex = 7;
            this.uc_txtOtherNumber.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "ماسه برگشتی:";
            // 
            // uc_txtSandReturn
            // 
            this.uc_txtSandReturn.IsInteger = false;
            this.uc_txtSandReturn.IsNumber = true;
            this.uc_txtSandReturn.IsTime = false;
            this.uc_txtSandReturn.Location = new System.Drawing.Point(235, 24);
            this.uc_txtSandReturn.multitextbox = false;
            this.uc_txtSandReturn.Name = "uc_txtSandReturn";
            this.uc_txtSandReturn.Size = new System.Drawing.Size(79, 22);
            this.uc_txtSandReturn.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "آب:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "گرد زغال:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ماسه نو:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(888, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "بنتونیت:";
            // 
            // uc_txtWater
            // 
            this.uc_txtWater.IsInteger = false;
            this.uc_txtWater.IsNumber = true;
            this.uc_txtWater.IsTime = false;
            this.uc_txtWater.Location = new System.Drawing.Point(407, 24);
            this.uc_txtWater.multitextbox = false;
            this.uc_txtWater.Name = "uc_txtWater";
            this.uc_txtWater.Size = new System.Drawing.Size(79, 22);
            this.uc_txtWater.TabIndex = 3;
            // 
            // uc_txtCoalDust
            // 
            this.uc_txtCoalDust.IsInteger = false;
            this.uc_txtCoalDust.IsNumber = true;
            this.uc_txtCoalDust.IsTime = false;
            this.uc_txtCoalDust.Location = new System.Drawing.Point(528, 24);
            this.uc_txtCoalDust.multitextbox = false;
            this.uc_txtCoalDust.Name = "uc_txtCoalDust";
            this.uc_txtCoalDust.Size = new System.Drawing.Size(79, 22);
            this.uc_txtCoalDust.TabIndex = 2;
            // 
            // uc_NewSand
            // 
            this.uc_NewSand.IsInteger = false;
            this.uc_NewSand.IsNumber = true;
            this.uc_NewSand.IsTime = false;
            this.uc_NewSand.Location = new System.Drawing.Point(670, 24);
            this.uc_NewSand.multitextbox = false;
            this.uc_NewSand.Name = "uc_NewSand";
            this.uc_NewSand.Size = new System.Drawing.Size(79, 22);
            this.uc_NewSand.TabIndex = 1;
            // 
            // uc_txtbentonit
            // 
            this.uc_txtbentonit.IsInteger = false;
            this.uc_txtbentonit.IsNumber = true;
            this.uc_txtbentonit.IsTime = false;
            this.uc_txtbentonit.Location = new System.Drawing.Point(803, 24);
            this.uc_txtbentonit.multitextbox = false;
            this.uc_txtbentonit.Name = "uc_txtbentonit";
            this.uc_txtbentonit.Size = new System.Drawing.Size(79, 22);
            this.uc_txtbentonit.TabIndex = 0;
            // 
            // uc_txtReportOther
            // 
            this.uc_txtReportOther.IsInteger = false;
            this.uc_txtReportOther.IsNumber = false;
            this.uc_txtReportOther.IsTime = false;
            this.uc_txtReportOther.Location = new System.Drawing.Point(482, 325);
            this.uc_txtReportOther.multitextbox = true;
            this.uc_txtReportOther.Name = "uc_txtReportOther";
            this.uc_txtReportOther.Size = new System.Drawing.Size(382, 46);
            this.uc_txtReportOther.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "سایر:";
            // 
            // uc_txtElectric
            // 
            this.uc_txtElectric.IsInteger = false;
            this.uc_txtElectric.IsNumber = false;
            this.uc_txtElectric.IsTime = false;
            this.uc_txtElectric.Location = new System.Drawing.Point(17, 246);
            this.uc_txtElectric.multitextbox = true;
            this.uc_txtElectric.Name = "uc_txtElectric";
            this.uc_txtElectric.Size = new System.Drawing.Size(382, 46);
            this.uc_txtElectric.TabIndex = 6;
            this.uc_txtElectric.Load += new System.EventHandler(this.uc_TextBox1_Load);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "گزارش برقی:";
            // 
            // uc_txtMechanical
            // 
            this.uc_txtMechanical.IsInteger = false;
            this.uc_txtMechanical.IsNumber = false;
            this.uc_txtMechanical.IsTime = false;
            this.uc_txtMechanical.Location = new System.Drawing.Point(482, 246);
            this.uc_txtMechanical.multitextbox = true;
            this.uc_txtMechanical.Name = "uc_txtMechanical";
            this.uc_txtMechanical.Size = new System.Drawing.Size(382, 46);
            this.uc_txtMechanical.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(870, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "گزارش مکانیکی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "مسئول شیفت:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "شیفت:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "نام قطعه:";
            // 
            // ucStatusBar1
            // 
            this.ucStatusBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.ucStatusBar1.Name = "ucStatusBar1";
            this.ucStatusBar1.Size = new System.Drawing.Size(962, 25);
            this.ucStatusBar1.TabIndex = 0;
            // 
            // uc_cmbAuto_piece
            // 
            this.uc_cmbAuto_piece.FormattingEnabled = true;
            this.uc_cmbAuto_piece.LimitToList = true;
            this.uc_cmbAuto_piece.Location = new System.Drawing.Point(572, 7);
            this.uc_cmbAuto_piece.Name = "uc_cmbAuto_piece";
            this.uc_cmbAuto_piece.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_piece.TabIndex = 1;
            // 
            // uc_cmbAuto_Shift
            // 
            this.uc_cmbAuto_Shift.FormattingEnabled = true;
            this.uc_cmbAuto_Shift.LimitToList = true;
            this.uc_cmbAuto_Shift.Location = new System.Drawing.Point(389, 5);
            this.uc_cmbAuto_Shift.Name = "uc_cmbAuto_Shift";
            this.uc_cmbAuto_Shift.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_Shift.TabIndex = 2;
            // 
            // uc_cmbAuto_Superviser
            // 
            this.uc_cmbAuto_Superviser.FormattingEnabled = true;
            this.uc_cmbAuto_Superviser.LimitToList = true;
            this.uc_cmbAuto_Superviser.Location = new System.Drawing.Point(184, 5);
            this.uc_cmbAuto_Superviser.Name = "uc_cmbAuto_Superviser";
            this.uc_cmbAuto_Superviser.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_Superviser.TabIndex = 3;
            // 
            // uc_mtxtDate1
            // 
            this.uc_mtxtDate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_mtxtDate1.Location = new System.Drawing.Point(762, 9);
            this.uc_mtxtDate1.Mask = "0000/00/00";
            this.uc_mtxtDate1.Name = "uc_mtxtDate1";
            this.uc_mtxtDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_mtxtDate1.Size = new System.Drawing.Size(120, 21);
            this.uc_mtxtDate1.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(888, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "تاریخ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.uc_cmbAuto_Superviser);
            this.panel1.Controls.Add(this.uc_mtxtDate1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uc_cmbAuto_Shift);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uc_cmbAuto_piece);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 42);
            this.panel1.TabIndex = 0;
            // 
            // btn_Calc
            // 
            this.btn_Calc.BackgroundImage = global::Payazob.Properties.Resources.calculator;
            this.btn_Calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Calc.Location = new System.Drawing.Point(774, 117);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(32, 28);
            this.btn_Calc.TabIndex = 3;
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_send
            // 
            this.btn_send.BackgroundImage = global::Payazob.Properties.Resources.check;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.Location = new System.Drawing.Point(19, 385);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(43, 37);
            this.btn_send.TabIndex = 9;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Payazob.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(90, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 91;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSandMaterialUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 462);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSandMaterialUsage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مواد مصرفی ماسه";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_usagematerial.ResumeLayout(false);
            this.grp_usagematerial.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ControlLibrary.ucStatusBar ucStatusBar1;
        private System.Windows.Forms.GroupBox grp_usagematerial;
        private UC.uc_TextBox uc_txtReportOther;
        private System.Windows.Forms.Label label4;
        private UC.uc_TextBox uc_txtElectric;
        private System.Windows.Forms.Label label3;
        private UC.uc_TextBox uc_txtMechanical;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private UC.uc_TextBox uc_txtBatchCount;
        private System.Windows.Forms.Label label11;
        private UC.uc_TextBox uc_txtSandReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private UC.uc_TextBox uc_txtWater;
        private UC.uc_TextBox uc_txtCoalDust;
        private UC.uc_TextBox uc_NewSand;
        private UC.uc_TextBox uc_txtbentonit;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label14;
        private UC.uc_TextBox uc_txtSumOther;
        private System.Windows.Forms.Label label15;
        private UC.uc_TextBox uc_txtSumSandReturn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private UC.uc_TextBox uc_txtSumWater;
        private UC.uc_TextBox uc_txtSumCoalDust;
        private UC.uc_TextBox uc_txtSumSandNew;
        private UC.uc_TextBox uc_txtSumBetonit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Other;
        private UC.uc_TextBox uc_txtOther;
        private UC.uc_TextBox uc_txtOtherNumber;
        private UC.uc_TextBox uc_txtComment;
        private System.Windows.Forms.Label label12;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_piece;
        private System.Windows.Forms.Label label20;
        private ControlLibrary.uc_TextBoxDate uc_mtxtDate1;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_Superviser;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_Shift;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button button1;
    }
}