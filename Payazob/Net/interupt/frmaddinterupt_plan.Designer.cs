namespace PAYAZOBNET.form.interupt
{
    partial class frmaddinterupt_plan
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
            this.txtdateplan = new TextBoxtest.TxtProNet();
            this.txtexplainhavoc = new TextBoxtest.TxtProNet();
            this.combo_operator_name_first = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_device_no = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_device_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combosecondoperator = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtexplainactivity = new TextBoxtest.TxtProNet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonX1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txttime = new TextBoxtest.TxtProNet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txthend = new ControlLibrary.textboxtime();
            this.txth1 = new ControlLibrary.textboxtime();
            this.txtdateend = new ControlLibrary.textboxdete();
            this.txtdatestart = new ControlLibrary.textboxdete();
            this.uStatusBar1 = new ControlLibrary.ucStatusBar();
            this.dataGridView222 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView222)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdateplan
            // 
            this.txtdateplan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdateplan.AutoSprator = false;
            this.txtdateplan.BackColor = System.Drawing.Color.White;
            this.txtdateplan.Enabled = false;
            this.txtdateplan.EnterToTab = true;
            this.txtdateplan.EscToClose = true;
            this.txtdateplan.FocusBackColor = System.Drawing.Color.Cornsilk;
            this.txtdateplan.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdateplan.FocusForeColor = System.Drawing.Color.Blue;
            this.txtdateplan.FocusTextSelect = true;
            this.txtdateplan.Location = new System.Drawing.Point(48, 20);
            this.txtdateplan.MessageEmptyShowDialog = true;
            this.txtdateplan.MessegeEmpty = "تاریخ وارد شده صحیح نیست";
            this.txtdateplan.MessegeEmptyInFormRight = true;
            this.txtdateplan.MessegeEmptyShowInForm = false;
            this.txtdateplan.Name = "txtdateplan";
            this.txtdateplan.ReadOnly = true;
            this.txtdateplan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdateplan.Size = new System.Drawing.Size(68, 21);
            this.txtdateplan.TabIndex = 2;
            this.txtdateplan.Text = "13__/__/__";
            this.txtdateplan.TypeAllChar = false;
            this.txtdateplan.TypeDateShamsi = true;
            this.txtdateplan.TypeEnglishOnly = false;
            this.txtdateplan.TypeFarsiOnly = false;
            this.txtdateplan.TypeNumricOnly = false;
            this.txtdateplan.TypeOtherChar = "";
            this.txtdateplan.Leave += new System.EventHandler(this.txtdateplan_Leave);
            // 
            // txtexplainhavoc
            // 
            this.txtexplainhavoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtexplainhavoc.AutoSprator = false;
            this.txtexplainhavoc.EnterToTab = false;
            this.txtexplainhavoc.EscToClose = true;
            this.txtexplainhavoc.FocusBackColor = System.Drawing.Color.Cornsilk;
            this.txtexplainhavoc.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtexplainhavoc.FocusForeColor = System.Drawing.Color.Blue;
            this.txtexplainhavoc.FocusTextSelect = true;
            this.txtexplainhavoc.Location = new System.Drawing.Point(148, 145);
            this.txtexplainhavoc.MessageEmptyShowDialog = false;
            this.txtexplainhavoc.MessegeEmpty = "";
            this.txtexplainhavoc.MessegeEmptyInFormRight = true;
            this.txtexplainhavoc.MessegeEmptyShowInForm = false;
            this.txtexplainhavoc.Multiline = true;
            this.txtexplainhavoc.Name = "txtexplainhavoc";
            this.txtexplainhavoc.Size = new System.Drawing.Size(438, 82);
            this.txtexplainhavoc.TabIndex = 6;
            this.txtexplainhavoc.TypeAllChar = true;
            this.txtexplainhavoc.TypeDateShamsi = false;
            this.txtexplainhavoc.TypeEnglishOnly = false;
            this.txtexplainhavoc.TypeFarsiOnly = false;
            this.txtexplainhavoc.TypeNumricOnly = false;
            this.txtexplainhavoc.TypeOtherChar = "";
            // 
            // combo_operator_name_first
            // 
            this.combo_operator_name_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_operator_name_first.FormattingEnabled = true;
            this.combo_operator_name_first.Location = new System.Drawing.Point(436, 114);
            this.combo_operator_name_first.Name = "combo_operator_name_first";
            this.combo_operator_name_first.Size = new System.Drawing.Size(150, 21);
            this.combo_operator_name_first.TabIndex = 4;
            this.combo_operator_name_first.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ساعت شروع سرویس";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "شرح مشکلات دستگاه";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "تاریخ برنامه ریزی شده برای سرویس";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "نام اپراتور تحویل دهنده";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "نام دستگاه";
            // 
            // combo_device_no
            // 
            this.combo_device_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_device_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.combo_device_no.Enabled = false;
            this.combo_device_no.FormattingEnabled = true;
            this.combo_device_no.Location = new System.Drawing.Point(300, 48);
            this.combo_device_no.Name = "combo_device_no";
            this.combo_device_no.Size = new System.Drawing.Size(150, 21);
            this.combo_device_no.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "شماره دستگاه";
            // 
            // combo_device_name
            // 
            this.combo_device_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_device_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.combo_device_name.Enabled = false;
            this.combo_device_name.FormattingEnabled = true;
            this.combo_device_name.ItemHeight = 13;
            this.combo_device_name.Location = new System.Drawing.Point(300, 22);
            this.combo_device_name.MaxDropDownItems = 12;
            this.combo_device_name.Name = "combo_device_name";
            this.combo_device_name.Size = new System.Drawing.Size(150, 21);
            this.combo_device_name.TabIndex = 0;
            this.combo_device_name.SelectedIndexChanged += new System.EventHandler(this.combo_device_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "تاریخ شروع سرویس";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "تاریخ پایان سرویس";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ساعت پایان سرویس";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "نام اپراتور تحویل گیرنده";
            this.label10.Visible = false;
            // 
            // combosecondoperator
            // 
            this.combosecondoperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combosecondoperator.FormattingEnabled = true;
            this.combosecondoperator.Location = new System.Drawing.Point(433, 236);
            this.combosecondoperator.Name = "combosecondoperator";
            this.combosecondoperator.Size = new System.Drawing.Size(150, 21);
            this.combosecondoperator.TabIndex = 7;
            this.combosecondoperator.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "شرح فعالیتهای انجام شده";
            // 
            // txtexplainactivity
            // 
            this.txtexplainactivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtexplainactivity.AutoSprator = false;
            this.txtexplainactivity.EnterToTab = false;
            this.txtexplainactivity.EscToClose = true;
            this.txtexplainactivity.FocusBackColor = System.Drawing.Color.Cornsilk;
            this.txtexplainactivity.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtexplainactivity.FocusForeColor = System.Drawing.Color.Blue;
            this.txtexplainactivity.FocusTextSelect = true;
            this.txtexplainactivity.Location = new System.Drawing.Point(148, 301);
            this.txtexplainactivity.MessageEmptyShowDialog = false;
            this.txtexplainactivity.MessegeEmpty = "";
            this.txtexplainactivity.MessegeEmptyInFormRight = true;
            this.txtexplainactivity.MessegeEmptyShowInForm = false;
            this.txtexplainactivity.Multiline = true;
            this.txtexplainactivity.Name = "txtexplainactivity";
            this.txtexplainactivity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtexplainactivity.Size = new System.Drawing.Size(438, 61);
            this.txtexplainactivity.TabIndex = 10;
            this.txtexplainactivity.TypeAllChar = true;
            this.txtexplainactivity.TypeDateShamsi = false;
            this.txtexplainactivity.TypeEnglishOnly = false;
            this.txtexplainactivity.TypeFarsiOnly = false;
            this.txtexplainactivity.TypeNumricOnly = false;
            this.txtexplainactivity.TypeOtherChar = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.dataGridView222);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(128, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(626, 122);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xid,
            this.text,
            this.select});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 95);
            this.dataGridView1.TabIndex = 16;
            // 
            // select
            // 
            this.select.FalseValue = "0";
            this.select.HeaderText = "انتخاب";
            this.select.Name = "select";
            this.select.TrueValue = "1";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "علت تاخیر در سرویس دستگاه";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonX1.Location = new System.Drawing.Point(8, 463);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(118, 48);
            this.buttonX1.TabIndex = 14;
            this.buttonX1.Text = "ذخیره";
            this.buttonX1.UseVisualStyleBackColor = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(592, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "مدت زمان سرویس،توقف";
            // 
            // txttime
            // 
            this.txttime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttime.AutoSprator = false;
            this.txttime.EnterToTab = true;
            this.txttime.EscToClose = true;
            this.txttime.FocusBackColor = System.Drawing.Color.Cornsilk;
            this.txttime.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txttime.FocusForeColor = System.Drawing.Color.Blue;
            this.txttime.FocusTextSelect = true;
            this.txttime.Location = new System.Drawing.Point(504, 376);
            this.txttime.MaxLength = 5;
            this.txttime.MessageEmptyShowDialog = false;
            this.txttime.MessegeEmpty = "ساعت پایان سرویس را وارد کنید";
            this.txttime.MessegeEmptyInFormRight = false;
            this.txttime.MessegeEmptyShowInForm = true;
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(82, 21);
            this.txttime.TabIndex = 11;
            this.txttime.TypeAllChar = false;
            this.txttime.TypeDateShamsi = false;
            this.txttime.TypeEnglishOnly = false;
            this.txttime.TypeFarsiOnly = false;
            this.txttime.TypeNumricOnly = false;
            this.txttime.TypeOtherChar = ":";
            this.txttime.Leave += new System.EventHandler(this.txth1_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combo_device_no);
            this.groupBox2.Controls.Add(this.combo_device_name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtdateplan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(139, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 75);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سرویس برنامه ریزی شده";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(48, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "اتخاب سرویس";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(8, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 48);
            this.button2.TabIndex = 34;
            this.button2.Text = "ورود مشکلات دستگاه";
            this.toolTip1.SetToolTip(this.button2, "دریافت مشکلات اعلام شده دستگاه از سوی مدیریت تولید");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txthend
            // 
            this.txthend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txthend.Location = new System.Drawing.Point(148, 274);
            this.txthend.Name = "txthend";
            this.txthend.showbutton = true;
            this.txthend.Size = new System.Drawing.Size(137, 21);
            this.txthend.TabIndex = 33;
            this.txthend.Time = "  :";
            // 
            // txth1
            // 
            this.txth1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txth1.Location = new System.Drawing.Point(148, 114);
            this.txth1.Name = "txth1";
            this.txth1.showbutton = true;
            this.txth1.Size = new System.Drawing.Size(138, 21);
            this.txth1.TabIndex = 33;
            this.txth1.Tag = "";
            this.txth1.Time = "  :";
            // 
            // txtdateend
            // 
            this.txtdateend.accept = false;
            this.txtdateend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdateend.Location = new System.Drawing.Point(148, 240);
            this.txtdateend.Name = "txtdateend";
            this.txtdateend.showbutton = true;
            this.txtdateend.Size = new System.Drawing.Size(138, 21);
            this.txtdateend.TabIndex = 32;
            // 
            // txtdatestart
            // 
            this.txtdatestart.accept = false;
            this.txtdatestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdatestart.Location = new System.Drawing.Point(436, 84);
            this.txtdatestart.Name = "txtdatestart";
            this.txtdatestart.showbutton = true;
            this.txtdatestart.Size = new System.Drawing.Size(153, 21);
            this.txtdatestart.TabIndex = 32;
            // 
            // uStatusBar1
            // 
            this.uStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uStatusBar1.DgvCell = null;
            this.uStatusBar1.Location = new System.Drawing.Point(1, 532);
            this.uStatusBar1.Name = "uStatusBar1";
            this.uStatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uStatusBar1.Size = new System.Drawing.Size(764, 24);
            this.uStatusBar1.TabIndex = 27;
            this.uStatusBar1.Load += new System.EventHandler(this.uStatusBar1_Load);
            // 
            // dataGridView222
            // 
            this.dataGridView222.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView222.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView222.Location = new System.Drawing.Point(561, 93);
            this.dataGridView222.Name = "dataGridView222";
            this.dataGridView222.Size = new System.Drawing.Size(28, 18);
            this.dataGridView222.TabIndex = 29;
            this.dataGridView222.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "xid";
            this.dataGridViewTextBoxColumn1.HeaderText = "xid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "text";
            this.dataGridViewTextBoxColumn2.HeaderText = "علت";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // xid
            // 
            this.xid.DataPropertyName = "xid";
            this.xid.HeaderText = "xid";
            this.xid.Name = "xid";
            this.xid.Visible = false;
            // 
            // text
            // 
            this.text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.text.DataPropertyName = "text";
            this.text.HeaderText = "علت";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            // 
            // frmaddinterupt_plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(765, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txthend);
            this.Controls.Add(this.txth1);
            this.Controls.Add(this.txtdateend);
            this.Controls.Add(this.txtdatestart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.uStatusBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.txtexplainactivity);
            this.Controls.Add(this.txtexplainhavoc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combosecondoperator);
            this.Controls.Add(this.combo_operator_name_first);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmaddinterupt_plan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "توقفات برنامه ریزی شده";
            this.Load += new System.EventHandler(this.frmaddinterupt_plan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView222)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonX1;
        private ControlLibrary.ucStatusBar uStatusBar1;
        public TextBoxtest.TxtProNet txtdateplan;
        public TextBoxtest.TxtProNet txtexplainhavoc;
        public System.Windows.Forms.ComboBox combo_operator_name_first;
        public System.Windows.Forms.ComboBox combo_device_no;
        public System.Windows.Forms.ComboBox combo_device_name;
        public System.Windows.Forms.ComboBox combosecondoperator;
        public TextBoxtest.TxtProNet txtexplainactivity;
        private System.Windows.Forms.Label label12;
        public TextBoxtest.TxtProNet txttime;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xid;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        public ControlLibrary.textboxdete txtdatestart;
        public ControlLibrary.textboxdete txtdateend;
        public ControlLibrary.textboxtime txth1;
        public ControlLibrary.textboxtime txthend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView222;
    }
}