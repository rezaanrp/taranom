namespace Payazob
{
    partial class frmDowntime
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.uc_TextBoxDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxt_StopTime = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_StartTime = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvg_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_shift_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_cmbSectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_Section_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_cmbDowntimeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_downtime_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_dmbshiftname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_send = new System.Windows.Forms.Button();
            this.uc_cmbAuto_SectionType = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbAuto_DowntiomeType = new ControlLibrary.uc_cmbAuto();
            this.txt_Duration = new ControlLibrary.uc_txtBox(this.components);
            this.uc_cmbAuto_shift = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbAuto_superviser = new ControlLibrary.uc_cmbAuto();
            this.uc_txt_comment = new ControlLibrary.uc_txtBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(962, 462);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uc_txt_comment);
            this.groupBox1.Controls.Add(this.uc_cmbAuto_superviser);
            this.groupBox1.Controls.Add(this.uc_cmbAuto_shift);
            this.groupBox1.Controls.Add(this.txt_Duration);
            this.groupBox1.Controls.Add(this.uc_cmbAuto_DowntiomeType);
            this.groupBox1.Controls.Add(this.uc_cmbAuto_SectionType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.uc_TextBoxDate1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mtxt_StopTime);
            this.groupBox1.Controls.Add(this.mtxt_StartTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "توقفات";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(863, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "تاريخ:";
            // 
            // uc_TextBoxDate1
            // 
            this.uc_TextBoxDate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_TextBoxDate1.Location = new System.Drawing.Point(741, 20);
            this.uc_TextBoxDate1.Mask = "0000/00/00";
            this.uc_TextBoxDate1.Name = "uc_TextBoxDate1";
            this.uc_TextBoxDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_TextBoxDate1.Size = new System.Drawing.Size(120, 21);
            this.uc_TextBoxDate1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "نوع توقف:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "تا";
            // 
            // mtxt_StopTime
            // 
            this.mtxt_StopTime.Location = new System.Drawing.Point(13, 20);
            this.mtxt_StopTime.Mask = "00:00";
            this.mtxt_StopTime.Name = "mtxt_StopTime";
            this.mtxt_StopTime.Size = new System.Drawing.Size(36, 21);
            this.mtxt_StopTime.TabIndex = 12;
            this.mtxt_StopTime.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_StartTime
            // 
            this.mtxt_StartTime.Location = new System.Drawing.Point(74, 19);
            this.mtxt_StartTime.Mask = "00:00";
            this.mtxt_StartTime.Name = "mtxt_StartTime";
            this.mtxt_StartTime.Size = new System.Drawing.Size(36, 21);
            this.mtxt_StartTime.TabIndex = 10;
            this.mtxt_StartTime.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = ": دقیقه";
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.Location = new System.Drawing.Point(539, 100);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(65, 23);
            this.btn_new.TabIndex = 22;
            this.btn_new.Text = "جدید";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(625, 100);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(65, 23);
            this.btn_edit.TabIndex = 21;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(711, 100);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(65, 23);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.Location = new System.Drawing.Point(797, 100);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(65, 23);
            this.btn_insert.TabIndex = 19;
            this.btn_insert.Text = "درج";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "توضیحات:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "زمان:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "سرپرست شیفت:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "نام شیفت:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "مدت توقف:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام قسمت:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(942, 283);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست توقفات";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(10, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_send);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(922, 249);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvg_Date,
            this.dvg_shift_,
            this.dvg_cmbSectionName,
            this.dvg_Section_,
            this.dvg_cmbDowntimeType,
            this.dvg_downtime_,
            this.dvg_dmbshiftname,
            this.dvg_Duration,
            this.dvg_Start,
            this.dvg_End,
            this.dvg_comment});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // dvg_Date
            // 
            this.dvg_Date.HeaderText = "تاريخ";
            this.dvg_Date.Name = "dvg_Date";
            this.dvg_Date.ReadOnly = true;
            // 
            // dvg_shift_
            // 
            this.dvg_shift_.HeaderText = "shift_";
            this.dvg_shift_.MaxInputLength = 20;
            this.dvg_shift_.Name = "dvg_shift_";
            this.dvg_shift_.ReadOnly = true;
            this.dvg_shift_.Visible = false;
            // 
            // dvg_cmbSectionName
            // 
            this.dvg_cmbSectionName.HeaderText = "نام قسمت";
            this.dvg_cmbSectionName.Name = "dvg_cmbSectionName";
            this.dvg_cmbSectionName.ReadOnly = true;
            this.dvg_cmbSectionName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_cmbSectionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dvg_Section_
            // 
            this.dvg_Section_.HeaderText = "";
            this.dvg_Section_.Name = "dvg_Section_";
            this.dvg_Section_.ReadOnly = true;
            this.dvg_Section_.Visible = false;
            // 
            // dvg_cmbDowntimeType
            // 
            this.dvg_cmbDowntimeType.HeaderText = "نوع توقف";
            this.dvg_cmbDowntimeType.Name = "dvg_cmbDowntimeType";
            this.dvg_cmbDowntimeType.ReadOnly = true;
            this.dvg_cmbDowntimeType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_cmbDowntimeType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dvg_downtime_
            // 
            this.dvg_downtime_.HeaderText = "Column1";
            this.dvg_downtime_.Name = "dvg_downtime_";
            this.dvg_downtime_.ReadOnly = true;
            this.dvg_downtime_.Visible = false;
            // 
            // dvg_dmbshiftname
            // 
            this.dvg_dmbshiftname.FillWeight = 132.382F;
            this.dvg_dmbshiftname.HeaderText = "نام شیفت";
            this.dvg_dmbshiftname.Name = "dvg_dmbshiftname";
            this.dvg_dmbshiftname.ReadOnly = true;
            this.dvg_dmbshiftname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_dmbshiftname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dvg_Duration
            // 
            this.dvg_Duration.HeaderText = "مدت توقف";
            this.dvg_Duration.Name = "dvg_Duration";
            this.dvg_Duration.ReadOnly = true;
            // 
            // dvg_Start
            // 
            this.dvg_Start.HeaderText = "زمان شروع";
            this.dvg_Start.Name = "dvg_Start";
            this.dvg_Start.ReadOnly = true;
            // 
            // dvg_End
            // 
            this.dvg_End.HeaderText = "زمان پایان";
            this.dvg_End.Name = "dvg_End";
            this.dvg_End.ReadOnly = true;
            // 
            // dvg_comment
            // 
            this.dvg_comment.HeaderText = "comment";
            this.dvg_comment.Name = "dvg_comment";
            this.dvg_comment.ReadOnly = true;
            this.dvg_comment.Visible = false;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(25, 25);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "ارسال";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // uc_cmbAuto_SectionType
            // 
            this.uc_cmbAuto_SectionType.FormattingEnabled = true;
            this.uc_cmbAuto_SectionType.LimitToList = true;
            this.uc_cmbAuto_SectionType.Location = new System.Drawing.Point(522, 20);
            this.uc_cmbAuto_SectionType.Name = "uc_cmbAuto_SectionType";
            this.uc_cmbAuto_SectionType.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_SectionType.TabIndex = 3;
            // 
            // uc_cmbAuto_DowntiomeType
            // 
            this.uc_cmbAuto_DowntiomeType.FormattingEnabled = true;
            this.uc_cmbAuto_DowntiomeType.LimitToList = true;
            this.uc_cmbAuto_DowntiomeType.Location = new System.Drawing.Point(331, 20);
            this.uc_cmbAuto_DowntiomeType.Name = "uc_cmbAuto_DowntiomeType";
            this.uc_cmbAuto_DowntiomeType.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_DowntiomeType.TabIndex = 5;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Duration.IsInteger = true;
            this.txt_Duration.IsNumber = true;
            this.txt_Duration.IsTime = false;
            this.txt_Duration.Location = new System.Drawing.Point(213, 20);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(55, 21);
            this.txt_Duration.TabIndex = 7;
            // 
            // uc_cmbAuto_shift
            // 
            this.uc_cmbAuto_shift.FormattingEnabled = true;
            this.uc_cmbAuto_shift.LimitToList = true;
            this.uc_cmbAuto_shift.Location = new System.Drawing.Point(741, 61);
            this.uc_cmbAuto_shift.Name = "uc_cmbAuto_shift";
            this.uc_cmbAuto_shift.Size = new System.Drawing.Size(120, 21);
            this.uc_cmbAuto_shift.TabIndex = 14;
            // 
            // uc_cmbAuto_superviser
            // 
            this.uc_cmbAuto_superviser.FormattingEnabled = true;
            this.uc_cmbAuto_superviser.LimitToList = true;
            this.uc_cmbAuto_superviser.Location = new System.Drawing.Point(522, 61);
            this.uc_cmbAuto_superviser.Name = "uc_cmbAuto_superviser";
            this.uc_cmbAuto_superviser.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_superviser.TabIndex = 16;
            // 
            // uc_txt_comment
            // 
            this.uc_txt_comment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txt_comment.IsInteger = false;
            this.uc_txt_comment.IsNumber = false;
            this.uc_txt_comment.IsTime = false;
            this.uc_txt_comment.Location = new System.Drawing.Point(10, 61);
            this.uc_txt_comment.Multiline = true;
            this.uc_txt_comment.Name = "uc_txt_comment";
            this.uc_txt_comment.Size = new System.Drawing.Size(442, 62);
            this.uc_txt_comment.TabIndex = 18;
            // 
            // frmDowntime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 462);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDowntime";
            this.Text = "frmDowntime";
            this.Load += new System.EventHandler(this.frmDowntime_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxt_StopTime;
        private System.Windows.Forms.MaskedTextBox mtxt_StartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private ControlLibrary.uc_TextBoxDate uc_TextBoxDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_shift_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_cmbSectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_Section_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_cmbDowntimeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_downtime_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_dmbshiftname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_End;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_comment;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_SectionType;
        private ControlLibrary.uc_txtBox txt_Duration;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_DowntiomeType;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_shift;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_superviser;
        private ControlLibrary.uc_txtBox uc_txt_comment;

    }
}