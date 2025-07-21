namespace Payazob
{
    partial class frmProductionPlanning
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_show = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.mtxt_dateto = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtxt_datefrom = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmb_superviser = new System.Windows.Forms.ComboBox();
            this.cmb_shift = new System.Windows.Forms.ComboBox();
            this.cmb_Pieces = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.uc_RegisteringGroup1 = new ControlLibrary.uc_RegisteringGroup();
            this.txt_templatecount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Pieceweight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Solutionweight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_piececount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(785, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmb_superviser);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_shift);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Pieces);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ok);
            this.splitContainer1.Panel2.Controls.Add(this.uc_RegisteringGroup1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_templatecount);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Pieceweight);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Solutionweight);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txt_comment);
            this.splitContainer1.Panel2.Controls.Add(this.txt_date);
            this.splitContainer1.Panel2.Controls.Add(this.txt_piececount);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(785, 462);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_show
            // 
            this.btn_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show.Location = new System.Drawing.Point(374, 14);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(55, 23);
            this.btn_show.TabIndex = 3;
            this.btn_show.Text = "نمایش";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(707, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "تاریخ";
            // 
            // mtxt_dateto
            // 
            this.mtxt_dateto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_dateto.Location = new System.Drawing.Point(462, 14);
            this.mtxt_dateto.Mask = "0000/00/00";
            this.mtxt_dateto.Name = "mtxt_dateto";
            this.mtxt_dateto.Size = new System.Drawing.Size(100, 21);
            this.mtxt_dateto.TabIndex = 1;
            this.mtxt_dateto.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(575, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "تا";
            // 
            // mtxt_datefrom
            // 
            this.mtxt_datefrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_datefrom.Location = new System.Drawing.Point(597, 14);
            this.mtxt_datefrom.Mask = "0000/00/00";
            this.mtxt_datefrom.Name = "mtxt_datefrom";
            this.mtxt_datefrom.Size = new System.Drawing.Size(100, 21);
            this.mtxt_datefrom.TabIndex = 0;
            this.mtxt_datefrom.ValidatingType = typeof(System.DateTime);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "تایید شده ها";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmb_superviser
            // 
            this.cmb_superviser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_superviser.FormattingEnabled = true;
            this.cmb_superviser.Location = new System.Drawing.Point(8, 62);
            this.cmb_superviser.Name = "cmb_superviser";
            this.cmb_superviser.Size = new System.Drawing.Size(121, 21);
            this.cmb_superviser.TabIndex = 31;
            // 
            // cmb_shift
            // 
            this.cmb_shift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_shift.FormattingEnabled = true;
            this.cmb_shift.Location = new System.Drawing.Point(8, 28);
            this.cmb_shift.Name = "cmb_shift";
            this.cmb_shift.Size = new System.Drawing.Size(121, 21);
            this.cmb_shift.TabIndex = 30;
            // 
            // cmb_Pieces
            // 
            this.cmb_Pieces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Pieces.FormattingEnabled = true;
            this.cmb_Pieces.Location = new System.Drawing.Point(411, 28);
            this.cmb_Pieces.Name = "cmb_Pieces";
            this.cmb_Pieces.Size = new System.Drawing.Size(121, 21);
            this.cmb_Pieces.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "سرپرست شیفت:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "نام شیفت:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "نام قطعه:";
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(45, 166);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(54, 33);
            this.btn_ok.TabIndex = 28;
            this.btn_ok.Text = "ثبت";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // uc_RegisteringGroup1
            // 
            this.uc_RegisteringGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_RegisteringGroup1.approve = false;
            this.uc_RegisteringGroup1.approveEnabled = false;
            this.uc_RegisteringGroup1.GroupAndName = "برنامه ریزی";
            this.uc_RegisteringGroup1.Location = new System.Drawing.Point(128, 152);
            this.uc_RegisteringGroup1.Name = "uc_RegisteringGroup1";
            this.uc_RegisteringGroup1.register = false;
            this.uc_RegisteringGroup1.registerEnabled = false;
            this.uc_RegisteringGroup1.Size = new System.Drawing.Size(518, 56);
            this.uc_RegisteringGroup1.supplier = false;
            this.uc_RegisteringGroup1.supplierEnabled = false;
            this.uc_RegisteringGroup1.TabIndex = 27;
            // 
            // txt_templatecount
            // 
            this.txt_templatecount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_templatecount.Enabled = false;
            this.txt_templatecount.Location = new System.Drawing.Point(226, 62);
            this.txt_templatecount.Name = "txt_templatecount";
            this.txt_templatecount.Size = new System.Drawing.Size(100, 21);
            this.txt_templatecount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "تعداد قالب:";
            // 
            // txt_Pieceweight
            // 
            this.txt_Pieceweight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pieceweight.Enabled = false;
            this.txt_Pieceweight.Location = new System.Drawing.Point(411, 64);
            this.txt_Pieceweight.Name = "txt_Pieceweight";
            this.txt_Pieceweight.Size = new System.Drawing.Size(100, 21);
            this.txt_Pieceweight.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "وزن قطعه ها:";
            // 
            // txt_Solutionweight
            // 
            this.txt_Solutionweight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Solutionweight.Enabled = false;
            this.txt_Solutionweight.Location = new System.Drawing.Point(594, 65);
            this.txt_Solutionweight.Name = "txt_Solutionweight";
            this.txt_Solutionweight.Size = new System.Drawing.Size(100, 21);
            this.txt_Solutionweight.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(695, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = " وزن با سیستم راهکاری:";
            // 
            // txt_comment
            // 
            this.txt_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_comment.Location = new System.Drawing.Point(8, 102);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(686, 44);
            this.txt_comment.TabIndex = 8;
            // 
            // txt_date
            // 
            this.txt_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_date.Enabled = false;
            this.txt_date.Location = new System.Drawing.Point(594, 28);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 21);
            this.txt_date.TabIndex = 0;
            // 
            // txt_piececount
            // 
            this.txt_piececount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_piececount.Location = new System.Drawing.Point(226, 28);
            this.txt_piececount.Name = "txt_piececount";
            this.txt_piececount.Size = new System.Drawing.Size(100, 21);
            this.txt_piececount.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "تاریخ:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "توضیحات:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تعداد قطعه:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_show);
            this.splitContainer2.Panel1.Controls.Add(this.mtxt_datefrom);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.mtxt_dateto);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(785, 244);
            this.splitContainer2.SplitterDistance = 42;
            this.splitContainer2.TabIndex = 6;
            // 
            // frmProductionPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 462);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductionPlanning";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برنامه تولید";
            this.Load += new System.EventHandler(this.frmProductionPlanning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtxt_dateto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtxt_datefrom;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.TextBox txt_piececount;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_templatecount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Pieceweight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Solutionweight;
        private System.Windows.Forms.Label label6;
        private ControlLibrary.uc_RegisteringGroup uc_RegisteringGroup1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ComboBox cmb_superviser;
        private System.Windows.Forms.ComboBox cmb_shift;
        private System.Windows.Forms.ComboBox cmb_Pieces;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SplitContainer splitContainer2;

    }
}