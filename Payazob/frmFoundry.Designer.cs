namespace Payazob
{
    partial class frmFoundry
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Zinter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_khakestari = new System.Windows.Forms.RadioButton();
            this.rdb_daktil = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_shift = new System.Windows.Forms.ComboBox();
            this.cmb_superviser = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.uc_TextBoxDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_txt_comment = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txt_SlagWeight = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txt_CastedMold = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txt_FowardMelt = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txt_ReceivedMelt = new ControlLibrary.uc_txtBox(this.components);
            this.ucStatusBar1 = new ControlLibrary.ucStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Send);
            this.splitContainer1.Panel2.Controls.Add(this.ucStatusBar1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(877, 324);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Zinter);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.uc_TextBoxDate1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.uc_txt_comment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.uc_txt_SlagWeight);
            this.groupBox2.Controls.Add(this.cmb_shift);
            this.groupBox2.Controls.Add(this.uc_txt_CastedMold);
            this.groupBox2.Controls.Add(this.uc_txt_FowardMelt);
            this.groupBox2.Controls.Add(this.cmb_superviser);
            this.groupBox2.Controls.Add(this.uc_txt_ReceivedMelt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 235);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btn_Zinter
            // 
            this.btn_Zinter.Location = new System.Drawing.Point(694, 182);
            this.btn_Zinter.Name = "btn_Zinter";
            this.btn_Zinter.Size = new System.Drawing.Size(62, 38);
            this.btn_Zinter.TabIndex = 85;
            this.btn_Zinter.Text = "زینتر";
            this.btn_Zinter.UseVisualStyleBackColor = true;
            this.btn_Zinter.Click += new System.EventHandler(this.btn_Zinter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_khakestari);
            this.groupBox1.Controls.Add(this.rdb_daktil);
            this.groupBox1.Location = new System.Drawing.Point(38, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 47);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع قطعه";
            // 
            // rdb_khakestari
            // 
            this.rdb_khakestari.AutoSize = true;
            this.rdb_khakestari.Location = new System.Drawing.Point(10, 20);
            this.rdb_khakestari.Name = "rdb_khakestari";
            this.rdb_khakestari.Size = new System.Drawing.Size(71, 17);
            this.rdb_khakestari.TabIndex = 1;
            this.rdb_khakestari.TabStop = true;
            this.rdb_khakestari.Text = "خاکستری";
            this.rdb_khakestari.UseVisualStyleBackColor = true;
            // 
            // rdb_daktil
            // 
            this.rdb_daktil.AutoSize = true;
            this.rdb_daktil.Location = new System.Drawing.Point(113, 20);
            this.rdb_daktil.Name = "rdb_daktil";
            this.rdb_daktil.Size = new System.Drawing.Size(54, 17);
            this.rdb_daktil.TabIndex = 0;
            this.rdb_daktil.TabStop = true;
            this.rdb_daktil.Text = "داکتیل";
            this.rdb_daktil.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "نام شیفت:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "سرپرست شیفت:";
            // 
            // cmb_shift
            // 
            this.cmb_shift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_shift.FormattingEnabled = true;
            this.cmb_shift.Location = new System.Drawing.Point(421, 20);
            this.cmb_shift.Name = "cmb_shift";
            this.cmb_shift.Size = new System.Drawing.Size(121, 21);
            this.cmb_shift.TabIndex = 1;
            // 
            // cmb_superviser
            // 
            this.cmb_superviser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_superviser.FormattingEnabled = true;
            this.cmb_superviser.Location = new System.Drawing.Point(186, 20);
            this.cmb_superviser.Name = "cmb_superviser";
            this.cmb_superviser.Size = new System.Drawing.Size(121, 21);
            this.cmb_superviser.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(762, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "تاریخ :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "توضیحات:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = " وزن سرباره:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(539, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 30);
            this.label8.TabIndex = 72;
            this.label8.Text = "مقدار ذوب تحویل شده به شیفت بعد:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(295, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 69;
            this.label2.Text = "تعداد کل قالب ریخته گری شده:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(757, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 44);
            this.label6.TabIndex = 71;
            this.label6.Text = "مقدار ذوب تحویل گرفته از شیفت قبل:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::TARANOM.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(28, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.BackgroundImage = global::TARANOM.Properties.Resources.check;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.Location = new System.Drawing.Point(95, 5);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(42, 34);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // uc_TextBoxDate1
            // 
            this.uc_TextBoxDate1.accept = false;
            this.uc_TextBoxDate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_TextBoxDate1.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDate1.Location = new System.Drawing.Point(657, 24);
            this.uc_TextBoxDate1.Mask = "0000/00/00";
            this.uc_TextBoxDate1.Name = "uc_TextBoxDate1";
            this.uc_TextBoxDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_TextBoxDate1.Size = new System.Drawing.Size(100, 21);
            this.uc_TextBoxDate1.TabIndex = 0;
            // 
            // uc_txt_comment
            // 
            this.uc_txt_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txt_comment.IsInteger = false;
            this.uc_txt_comment.IsNumber = false;
            this.uc_txt_comment.IsTime = false;
            this.uc_txt_comment.Location = new System.Drawing.Point(38, 112);
            this.uc_txt_comment.Multiline = true;
            this.uc_txt_comment.Name = "uc_txt_comment";
            this.uc_txt_comment.Size = new System.Drawing.Size(718, 55);
            this.uc_txt_comment.TabIndex = 7;
            this.uc_txt_comment.textWithcomma = null;
            this.uc_txt_comment.textWithoutcomma = null;
            // 
            // uc_txt_SlagWeight
            // 
            this.uc_txt_SlagWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txt_SlagWeight.IsInteger = true;
            this.uc_txt_SlagWeight.IsNumber = true;
            this.uc_txt_SlagWeight.IsTime = false;
            this.uc_txt_SlagWeight.Location = new System.Drawing.Point(38, 60);
            this.uc_txt_SlagWeight.Name = "uc_txt_SlagWeight";
            this.uc_txt_SlagWeight.Size = new System.Drawing.Size(100, 21);
            this.uc_txt_SlagWeight.TabIndex = 6;
            this.uc_txt_SlagWeight.Text = "0";
            this.uc_txt_SlagWeight.textWithcomma = null;
            this.uc_txt_SlagWeight.textWithoutcomma = null;
            // 
            // uc_txt_CastedMold
            // 
            this.uc_txt_CastedMold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txt_CastedMold.IsInteger = true;
            this.uc_txt_CastedMold.IsNumber = true;
            this.uc_txt_CastedMold.IsTime = false;
            this.uc_txt_CastedMold.Location = new System.Drawing.Point(207, 60);
            this.uc_txt_CastedMold.Name = "uc_txt_CastedMold";
            this.uc_txt_CastedMold.Size = new System.Drawing.Size(100, 21);
            this.uc_txt_CastedMold.TabIndex = 5;
            this.uc_txt_CastedMold.Text = "0";
            this.uc_txt_CastedMold.textWithcomma = null;
            this.uc_txt_CastedMold.textWithoutcomma = null;
            // 
            // uc_txt_FowardMelt
            // 
            this.uc_txt_FowardMelt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txt_FowardMelt.IsInteger = true;
            this.uc_txt_FowardMelt.IsNumber = true;
            this.uc_txt_FowardMelt.IsTime = false;
            this.uc_txt_FowardMelt.Location = new System.Drawing.Point(442, 60);
            this.uc_txt_FowardMelt.Name = "uc_txt_FowardMelt";
            this.uc_txt_FowardMelt.Size = new System.Drawing.Size(100, 21);
            this.uc_txt_FowardMelt.TabIndex = 4;
            this.uc_txt_FowardMelt.Text = "0";
            this.uc_txt_FowardMelt.textWithcomma = null;
            this.uc_txt_FowardMelt.textWithoutcomma = null;
            // 
            // uc_txt_ReceivedMelt
            // 
            this.uc_txt_ReceivedMelt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txt_ReceivedMelt.IsInteger = true;
            this.uc_txt_ReceivedMelt.IsNumber = true;
            this.uc_txt_ReceivedMelt.IsTime = false;
            this.uc_txt_ReceivedMelt.Location = new System.Drawing.Point(656, 60);
            this.uc_txt_ReceivedMelt.Name = "uc_txt_ReceivedMelt";
            this.uc_txt_ReceivedMelt.Size = new System.Drawing.Size(100, 21);
            this.uc_txt_ReceivedMelt.TabIndex = 3;
            this.uc_txt_ReceivedMelt.Text = "0";
            this.uc_txt_ReceivedMelt.textWithcomma = null;
            this.uc_txt_ReceivedMelt.textWithoutcomma = null;
            // 
            // ucStatusBar1
            // 
            this.ucStatusBar1.DgvCell = null;
            this.ucStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucStatusBar1.Location = new System.Drawing.Point(0, 45);
            this.ucStatusBar1.Name = "ucStatusBar1";
            this.ucStatusBar1.Size = new System.Drawing.Size(877, 24);
            this.ucStatusBar1.TabIndex = 35;
            // 
            // frmFoundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 324);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFoundry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmFoundry_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.ComboBox cmb_superviser;
        private System.Windows.Forms.ComboBox cmb_shift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ControlLibrary.ucStatusBar ucStatusBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private ControlLibrary.uc_txtBox uc_txt_ReceivedMelt;
        private ControlLibrary.uc_txtBox uc_txt_FowardMelt;
        private ControlLibrary.uc_txtBox uc_txt_CastedMold;
        private ControlLibrary.uc_txtBox uc_txt_comment;
        private ControlLibrary.uc_txtBox uc_txt_SlagWeight;
        private ControlLibrary.uc_TextBoxDate uc_TextBoxDate1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_khakestari;
        private System.Windows.Forms.RadioButton rdb_daktil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Zinter;
    }
}