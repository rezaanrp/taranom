namespace Payazob
{
    partial class frmProductInspection
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uc_cmbAuto_Pieces = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbAuto_superviser = new ControlLibrary.uc_cmbAuto();
            this.uc_cmbAuto_shift = new ControlLibrary.uc_cmbAuto();
            this.uc_txtControlNumbers = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txt_DayOfYear = new ControlLibrary.uc_txtBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_Year = new System.Windows.Forms.NumericUpDown();
            this.lbl_defectNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxt_dateinspection = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.uc_RegisteringGroup1 = new ControlLibrary.uc_RegisteringGroup();
            this.ucStatusBar1 = new ControlLibrary.ucStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(9);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(962, 462);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 17);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(938, 331);
            this.splitContainer2.SplitterDistance = 448;
            this.splitContainer2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uc_cmbAuto_Pieces);
            this.groupBox2.Controls.Add(this.uc_cmbAuto_superviser);
            this.groupBox2.Controls.Add(this.uc_cmbAuto_shift);
            this.groupBox2.Controls.Add(this.uc_txtControlNumbers);
            this.groupBox2.Controls.Add(this.uc_txt_DayOfYear);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown_Year);
            this.groupBox2.Controls.Add(this.lbl_defectNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mtxt_dateinspection);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 325);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // uc_cmbAuto_Pieces
            // 
            this.uc_cmbAuto_Pieces.DropDownWidth = 180;
            this.uc_cmbAuto_Pieces.FormattingEnabled = true;
            this.uc_cmbAuto_Pieces.LimitToList = true;
            this.uc_cmbAuto_Pieces.Location = new System.Drawing.Point(236, 143);
            this.uc_cmbAuto_Pieces.Name = "uc_cmbAuto_Pieces";
            this.uc_cmbAuto_Pieces.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_Pieces.TabIndex = 5;
            // 
            // uc_cmbAuto_superviser
            // 
            this.uc_cmbAuto_superviser.DropDownWidth = 180;
            this.uc_cmbAuto_superviser.FormattingEnabled = true;
            this.uc_cmbAuto_superviser.LimitToList = true;
            this.uc_cmbAuto_superviser.Location = new System.Drawing.Point(15, 100);
            this.uc_cmbAuto_superviser.Name = "uc_cmbAuto_superviser";
            this.uc_cmbAuto_superviser.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_superviser.TabIndex = 4;
            // 
            // uc_cmbAuto_shift
            // 
            this.uc_cmbAuto_shift.DropDownWidth = 180;
            this.uc_cmbAuto_shift.FormattingEnabled = true;
            this.uc_cmbAuto_shift.LimitToList = true;
            this.uc_cmbAuto_shift.Location = new System.Drawing.Point(236, 98);
            this.uc_cmbAuto_shift.Name = "uc_cmbAuto_shift";
            this.uc_cmbAuto_shift.Size = new System.Drawing.Size(121, 21);
            this.uc_cmbAuto_shift.TabIndex = 3;
            // 
            // uc_txtControlNumbers
            // 
            this.uc_txtControlNumbers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtControlNumbers.IsInteger = true;
            this.uc_txtControlNumbers.IsNumber = true;
            this.uc_txtControlNumbers.IsTime = false;
            this.uc_txtControlNumbers.Location = new System.Drawing.Point(15, 143);
            this.uc_txtControlNumbers.MaxLength = 7;
            this.uc_txtControlNumbers.Name = "uc_txtControlNumbers";
            this.uc_txtControlNumbers.Size = new System.Drawing.Size(121, 21);
            this.uc_txtControlNumbers.TabIndex = 6;
            this.uc_txtControlNumbers.Text = "0";
            this.uc_txtControlNumbers.textWithcomma = null;
            this.uc_txtControlNumbers.textWithoutcomma = null;
            // 
            // uc_txt_DayOfYear
            // 
            this.uc_txt_DayOfYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txt_DayOfYear.IsInteger = true;
            this.uc_txt_DayOfYear.IsNumber = true;
            this.uc_txt_DayOfYear.IsTime = false;
            this.uc_txt_DayOfYear.Location = new System.Drawing.Point(94, 44);
            this.uc_txt_DayOfYear.MaxLength = 3;
            this.uc_txt_DayOfYear.Name = "uc_txt_DayOfYear";
            this.uc_txt_DayOfYear.Size = new System.Drawing.Size(47, 21);
            this.uc_txt_DayOfYear.TabIndex = 1;
            this.uc_txt_DayOfYear.Text = "0";
            this.uc_txt_DayOfYear.textWithcomma = null;
            this.uc_txt_DayOfYear.textWithoutcomma = null;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "سال:";
            // 
            // numericUpDown_Year
            // 
            this.numericUpDown_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Year.Location = new System.Drawing.Point(6, 44);
            this.numericUpDown_Year.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown_Year.Minimum = new decimal(new int[] {
            1391,
            0,
            0,
            0});
            this.numericUpDown_Year.Name = "numericUpDown_Year";
            this.numericUpDown_Year.Size = new System.Drawing.Size(51, 21);
            this.numericUpDown_Year.TabIndex = 2;
            this.numericUpDown_Year.Value = new decimal(new int[] {
            1395,
            0,
            0,
            0});
            // 
            // lbl_defectNumber
            // 
            this.lbl_defectNumber.AutoSize = true;
            this.lbl_defectNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_defectNumber.ForeColor = System.Drawing.Color.Red;
            this.lbl_defectNumber.Location = new System.Drawing.Point(194, 232);
            this.lbl_defectNumber.Name = "lbl_defectNumber";
            this.lbl_defectNumber.Size = new System.Drawing.Size(91, 14);
            this.lbl_defectNumber.TabIndex = 32;
            this.lbl_defectNumber.Text = "مجموع ضایعات";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "تعداد کنترل شده:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "تاریخ بازرسی:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "نام قطعه:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "نام شیفت:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "سرپرست شیفت:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "روز شمار قطعه:";
            // 
            // mtxt_dateinspection
            // 
            this.mtxt_dateinspection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_dateinspection.Location = new System.Drawing.Point(236, 44);
            this.mtxt_dateinspection.Mask = "0000/00/00";
            this.mtxt_dateinspection.Name = "mtxt_dateinspection";
            this.mtxt_dateinspection.Size = new System.Drawing.Size(120, 21);
            this.mtxt_dateinspection.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 325);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تفکیک ضایعات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(474, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lbl_Message);
            this.splitContainer3.Panel1.Controls.Add(this.btn_send);
            this.splitContainer3.Panel1.Controls.Add(this.uc_RegisteringGroup1);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ucStatusBar1);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(962, 89);
            this.splitContainer3.SplitterDistance = 60;
            this.splitContainer3.TabIndex = 0;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_Message.Location = new System.Drawing.Point(181, 23);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 13);
            this.lbl_Message.TabIndex = 30;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(18, 13);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 32);
            this.btn_send.TabIndex = 29;
            this.btn_send.Text = "ارسال";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // uc_RegisteringGroup1
            // 
            this.uc_RegisteringGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_RegisteringGroup1.approve = false;
            this.uc_RegisteringGroup1.approveEnabled = false;
            this.uc_RegisteringGroup1.GroupAndName = "بازرسی ضایعات";
            this.uc_RegisteringGroup1.Location = new System.Drawing.Point(843, 3);
            this.uc_RegisteringGroup1.Name = "uc_RegisteringGroup1";
            this.uc_RegisteringGroup1.register = false;
            this.uc_RegisteringGroup1.registerEnabled = false;
            this.uc_RegisteringGroup1.Size = new System.Drawing.Size(77, 56);
            this.uc_RegisteringGroup1.supplier = false;
            this.uc_RegisteringGroup1.supplierEnabled = false;
            this.uc_RegisteringGroup1.TabIndex = 28;
            this.uc_RegisteringGroup1.Visible = false;
            // 
            // ucStatusBar1
            // 
            this.ucStatusBar1.DgvCell = null;
            this.ucStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucStatusBar1.Location = new System.Drawing.Point(0, 1);
            this.ucStatusBar1.Name = "ucStatusBar1";
            this.ucStatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucStatusBar1.Size = new System.Drawing.Size(962, 24);
            this.ucStatusBar1.TabIndex = 0;
            // 
            // frmProductInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 462);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmProductInspection";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmProductInspection_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxt_dateinspection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private ControlLibrary.ucStatusBar ucStatusBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlLibrary.uc_RegisteringGroup uc_RegisteringGroup1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_defectNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown_Year;
        private System.Windows.Forms.Label label6;
        private ControlLibrary.uc_txtBox uc_txt_DayOfYear;
        private ControlLibrary.uc_txtBox uc_txtControlNumbers;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_shift;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_Pieces;
        private ControlLibrary.uc_cmbAuto uc_cmbAuto_superviser;
        private System.Windows.Forms.Label lbl_Message;
    }
}