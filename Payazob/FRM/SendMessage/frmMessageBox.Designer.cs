namespace Payazob.FRM.SendMessage
{
    partial class frmMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBox));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_OutBox = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Elan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inbox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_NewMessage = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tstb_Search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_Search = new System.Windows.Forms.ToolStripDropDownButton();
            this.tst_Context = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_title = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_reply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uc_txtBoxReciver = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxSender = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_Time = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxSendDate = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxSubject = new ControlLibrary.uc_txtBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(761, 226);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_OutBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(165, 53);
            this.panel1.TabIndex = 2;
            // 
            // btn_OutBox
            // 
            this.btn_OutBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_OutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OutBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutBox.Image = global::TARANOM.Properties.Resources.mail_replay;
            this.btn_OutBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OutBox.Location = new System.Drawing.Point(0, 10);
            this.btn_OutBox.Name = "btn_OutBox";
            this.btn_OutBox.Size = new System.Drawing.Size(165, 33);
            this.btn_OutBox.TabIndex = 0;
            this.btn_OutBox.Text = "پیام های ارسالی";
            this.btn_OutBox.UseVisualStyleBackColor = false;
            this.btn_OutBox.Click += new System.EventHandler(this.btn_OutBox_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(930, 510);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Elan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 189);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel4.Size = new System.Drawing.Size(165, 53);
            this.panel4.TabIndex = 4;
            // 
            // btn_Elan
            // 
            this.btn_Elan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Elan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Elan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Elan.Image = global::TARANOM.Properties.Resources.mailbox_1;
            this.btn_Elan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Elan.Location = new System.Drawing.Point(0, 10);
            this.btn_Elan.Name = "btn_Elan";
            this.btn_Elan.Size = new System.Drawing.Size(165, 33);
            this.btn_Elan.TabIndex = 0;
            this.btn_Elan.Text = "اعلانات";
            this.btn_Elan.UseVisualStyleBackColor = false;
            this.btn_Elan.Click += new System.EventHandler(this.btn_Elan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_inbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(165, 53);
            this.panel2.TabIndex = 1;
            // 
            // btn_inbox
            // 
            this.btn_inbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_inbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_inbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inbox.Image = global::TARANOM.Properties.Resources.e_mail;
            this.btn_inbox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inbox.Location = new System.Drawing.Point(0, 10);
            this.btn_inbox.Name = "btn_inbox";
            this.btn_inbox.Size = new System.Drawing.Size(165, 33);
            this.btn_inbox.TabIndex = 0;
            this.btn_inbox.Text = "پیام های دریافتی";
            this.btn_inbox.UseVisualStyleBackColor = false;
            this.btn_inbox.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_NewMessage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel3.Size = new System.Drawing.Size(165, 53);
            this.panel3.TabIndex = 3;
            // 
            // btn_NewMessage
            // 
            this.btn_NewMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_NewMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_NewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewMessage.Image = global::TARANOM.Properties.Resources.mail_new;
            this.btn_NewMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NewMessage.Location = new System.Drawing.Point(0, 10);
            this.btn_NewMessage.Name = "btn_NewMessage";
            this.btn_NewMessage.Size = new System.Drawing.Size(165, 33);
            this.btn_NewMessage.TabIndex = 0;
            this.btn_NewMessage.Text = "پیام جدید";
            this.btn_NewMessage.UseVisualStyleBackColor = false;
            this.btn_NewMessage.Click += new System.EventHandler(this.btn_NewMessage_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Panel2.Controls.Add(this.btn_Forward);
            this.splitContainer2.Panel2.Controls.Add(this.btn_reply);
            this.splitContainer2.Panel2.Controls.Add(this.uc_txtBoxReciver);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.uc_txtBoxSender);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.uc_txtBox_Time);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.uc_txtBoxSendDate);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.uc_txtBoxSubject);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(761, 510);
            this.splitContainer2.SplitterDistance = 254;
            this.splitContainer2.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.CountItemFormat = "{0} تعداد پیام";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.tstb_Search,
            this.toolStripButton_Search});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 229);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(761, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel1.Text = "{0} تعداد پیام";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move first";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move last";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tstb_Search
            // 
            this.tstb_Search.Name = "tstb_Search";
            this.tstb_Search.Size = new System.Drawing.Size(100, 25);
            this.tstb_Search.TextChanged += new System.EventHandler(this.tstb_Search_TextChanged);
            // 
            // toolStripButton_Search
            // 
            this.toolStripButton_Search.BackColor = System.Drawing.Color.Black;
            this.toolStripButton_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_Context,
            this.tst_title});
            this.toolStripButton_Search.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripButton_Search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Search.Image")));
            this.toolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Search.Name = "toolStripButton_Search";
            this.toolStripButton_Search.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton_Search.Text = "جستجو";
            this.toolStripButton_Search.Click += new System.EventHandler(this.toolStripButton_Search_Click_1);
            // 
            // tst_Context
            // 
            this.tst_Context.Name = "tst_Context";
            this.tst_Context.Size = new System.Drawing.Size(139, 22);
            this.tst_Context.Text = "جستجو محتوا";
            this.tst_Context.Click += new System.EventHandler(this.tst_Context_Click);
            // 
            // tst_title
            // 
            this.tst_title.Name = "tst_title";
            this.tst_title.Size = new System.Drawing.Size(139, 22);
            this.tst_title.Text = "جستجو عنوان";
            this.tst_title.Click += new System.EventHandler(this.tst_title_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(758, 163);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btn_Forward
            // 
            this.btn_Forward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Forward.Location = new System.Drawing.Point(91, 62);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(75, 23);
            this.btn_Forward.TabIndex = 9;
            this.btn_Forward.Text = "ارسال به";
            this.btn_Forward.UseVisualStyleBackColor = false;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_reply
            // 
            this.btn_reply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_reply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reply.Location = new System.Drawing.Point(10, 61);
            this.btn_reply.Name = "btn_reply";
            this.btn_reply.Size = new System.Drawing.Size(75, 23);
            this.btn_reply.TabIndex = 9;
            this.btn_reply.Text = "پاسخ";
            this.btn_reply.UseVisualStyleBackColor = false;
            this.btn_reply.Click += new System.EventHandler(this.btn_reply_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "دریافت کننده";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "فرستنده";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "زمان ارسال";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ ارسال";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "موضوع";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.UseAnimation = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // uc_txtBoxReciver
            // 
            this.uc_txtBoxReciver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxReciver.BackColor = System.Drawing.Color.White;
            this.uc_txtBoxReciver.IsInteger = false;
            this.uc_txtBoxReciver.IsNumber = false;
            this.uc_txtBoxReciver.IsTime = false;
            this.uc_txtBoxReciver.Location = new System.Drawing.Point(12, 8);
            this.uc_txtBoxReciver.Name = "uc_txtBoxReciver";
            this.uc_txtBoxReciver.ReadOnly = true;
            this.uc_txtBoxReciver.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uc_txtBoxReciver.Size = new System.Drawing.Size(408, 21);
            this.uc_txtBoxReciver.TabIndex = 8;
            this.uc_txtBoxReciver.textWithcomma = null;
            this.uc_txtBoxReciver.textWithoutcomma = null;
            // 
            // uc_txtBoxSender
            // 
            this.uc_txtBoxSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxSender.BackColor = System.Drawing.Color.White;
            this.uc_txtBoxSender.IsInteger = false;
            this.uc_txtBoxSender.IsNumber = false;
            this.uc_txtBoxSender.IsTime = false;
            this.uc_txtBoxSender.Location = new System.Drawing.Point(493, 8);
            this.uc_txtBoxSender.Name = "uc_txtBoxSender";
            this.uc_txtBoxSender.ReadOnly = true;
            this.uc_txtBoxSender.Size = new System.Drawing.Size(194, 21);
            this.uc_txtBoxSender.TabIndex = 8;
            this.uc_txtBoxSender.textWithcomma = null;
            this.uc_txtBoxSender.textWithoutcomma = null;
            // 
            // uc_txtBox_Time
            // 
            this.uc_txtBox_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_Time.BackColor = System.Drawing.Color.White;
            this.uc_txtBox_Time.IsInteger = false;
            this.uc_txtBox_Time.IsNumber = false;
            this.uc_txtBox_Time.IsTime = false;
            this.uc_txtBox_Time.Location = new System.Drawing.Point(328, 35);
            this.uc_txtBox_Time.Name = "uc_txtBox_Time";
            this.uc_txtBox_Time.ReadOnly = true;
            this.uc_txtBox_Time.Size = new System.Drawing.Size(92, 21);
            this.uc_txtBox_Time.TabIndex = 4;
            this.uc_txtBox_Time.textWithcomma = null;
            this.uc_txtBox_Time.textWithoutcomma = null;
            // 
            // uc_txtBoxSendDate
            // 
            this.uc_txtBoxSendDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxSendDate.BackColor = System.Drawing.Color.White;
            this.uc_txtBoxSendDate.IsInteger = false;
            this.uc_txtBoxSendDate.IsNumber = false;
            this.uc_txtBoxSendDate.IsTime = false;
            this.uc_txtBoxSendDate.Location = new System.Drawing.Point(595, 35);
            this.uc_txtBoxSendDate.Name = "uc_txtBoxSendDate";
            this.uc_txtBoxSendDate.ReadOnly = true;
            this.uc_txtBoxSendDate.Size = new System.Drawing.Size(92, 21);
            this.uc_txtBoxSendDate.TabIndex = 4;
            this.uc_txtBoxSendDate.textWithcomma = null;
            this.uc_txtBoxSendDate.textWithoutcomma = null;
            // 
            // uc_txtBoxSubject
            // 
            this.uc_txtBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxSubject.BackColor = System.Drawing.Color.White;
            this.uc_txtBoxSubject.IsInteger = false;
            this.uc_txtBoxSubject.IsNumber = false;
            this.uc_txtBoxSubject.IsTime = false;
            this.uc_txtBoxSubject.Location = new System.Drawing.Point(175, 62);
            this.uc_txtBoxSubject.Name = "uc_txtBoxSubject";
            this.uc_txtBoxSubject.ReadOnly = true;
            this.uc_txtBoxSubject.Size = new System.Drawing.Size(512, 21);
            this.uc_txtBoxSubject.TabIndex = 2;
            this.uc_txtBoxSubject.textWithcomma = null;
            this.uc_txtBoxSubject.textWithoutcomma = null;
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 510);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btn_OutBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_NewMessage;
        private ControlLibrary.uc_txtBox uc_txtBoxReciver;
        private System.Windows.Forms.Label label5;
        private ControlLibrary.uc_txtBox uc_txtBoxSender;
        private System.Windows.Forms.Label label4;
        private ControlLibrary.uc_txtBox uc_txtBoxSendDate;
        private System.Windows.Forms.Label label2;
        private ControlLibrary.uc_txtBox uc_txtBoxSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reply;
        private ControlLibrary.uc_txtBox uc_txtBox_Time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Elan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.ToolStripTextBox tstb_Search;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton_Search;
        private System.Windows.Forms.ToolStripMenuItem tst_Context;
        private System.Windows.Forms.ToolStripMenuItem tst_title;
    }
}