namespace Payazob.FRM.MaterialLocation
{
    partial class frmMaterialOfLocation_D
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
            this.uc_TextBoxDateStart = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_TextBoxDateMade = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_txtBoxLifeTime = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_xLocation = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_Serial = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_Name = new ControlLibrary.uc_txtBox(this.components);
            this.comboBox_pirority = new System.Windows.Forms.ComboBox();
            this.comboBoxlevel = new System.Windows.Forms.ComboBox();
            this.comboBox_TypeSell = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save_device = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.uc_txtBox_Model = new ControlLibrary.uc_txtBox(this.components);
            this.comboBoxperiod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_save_device);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(648, 393);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uc_TextBoxDateStart);
            this.groupBox1.Controls.Add(this.uc_TextBoxDateMade);
            this.groupBox1.Controls.Add(this.uc_txtBoxLifeTime);
            this.groupBox1.Controls.Add(this.uc_txtBox_xLocation);
            this.groupBox1.Controls.Add(this.uc_txtBox_Serial);
            this.groupBox1.Controls.Add(this.uc_txtBox_Model);
            this.groupBox1.Controls.Add(this.uc_txtBox_Name);
            this.groupBox1.Controls.Add(this.comboBoxperiod);
            this.groupBox1.Controls.Add(this.comboBox_pirority);
            this.groupBox1.Controls.Add(this.comboBoxlevel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox_TypeSell);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 328);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات دستگاه";
            // 
            // uc_TextBoxDateStart
            // 
            this.uc_TextBoxDateStart.accept = false;
            this.uc_TextBoxDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_TextBoxDateStart.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDateStart.Location = new System.Drawing.Point(62, 59);
            this.uc_TextBoxDateStart.Mask = "0000/00/00";
            this.uc_TextBoxDateStart.Name = "uc_TextBoxDateStart";
            this.uc_TextBoxDateStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_TextBoxDateStart.Size = new System.Drawing.Size(121, 21);
            this.uc_TextBoxDateStart.TabIndex = 4;
            // 
            // uc_TextBoxDateMade
            // 
            this.uc_TextBoxDateMade.accept = false;
            this.uc_TextBoxDateMade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_TextBoxDateMade.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDateMade.Location = new System.Drawing.Point(63, 17);
            this.uc_TextBoxDateMade.Mask = "0000/00/00";
            this.uc_TextBoxDateMade.Name = "uc_TextBoxDateMade";
            this.uc_TextBoxDateMade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uc_TextBoxDateMade.Size = new System.Drawing.Size(121, 21);
            this.uc_TextBoxDateMade.TabIndex = 3;
            // 
            // uc_txtBoxLifeTime
            // 
            this.uc_txtBoxLifeTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxLifeTime.BackColor = System.Drawing.Color.White;
            this.uc_txtBoxLifeTime.IsInteger = true;
            this.uc_txtBoxLifeTime.IsNumber = true;
            this.uc_txtBoxLifeTime.IsTime = false;
            this.uc_txtBoxLifeTime.Location = new System.Drawing.Point(364, 143);
            this.uc_txtBoxLifeTime.Name = "uc_txtBoxLifeTime";
            this.uc_txtBoxLifeTime.Size = new System.Drawing.Size(169, 21);
            this.uc_txtBoxLifeTime.TabIndex = 2;
            this.uc_txtBoxLifeTime.Text = "0";
            this.uc_txtBoxLifeTime.textWithcomma = null;
            this.uc_txtBoxLifeTime.textWithoutcomma = null;
            // 
            // uc_txtBox_xLocation
            // 
            this.uc_txtBox_xLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_xLocation.BackColor = System.Drawing.Color.White;
            this.uc_txtBox_xLocation.IsInteger = false;
            this.uc_txtBox_xLocation.IsNumber = false;
            this.uc_txtBox_xLocation.IsTime = false;
            this.uc_txtBox_xLocation.Location = new System.Drawing.Point(364, 60);
            this.uc_txtBox_xLocation.MaxLength = 2;
            this.uc_txtBox_xLocation.Name = "uc_txtBox_xLocation";
            this.uc_txtBox_xLocation.Size = new System.Drawing.Size(169, 21);
            this.uc_txtBox_xLocation.TabIndex = 2;
            this.uc_txtBox_xLocation.textWithcomma = null;
            this.uc_txtBox_xLocation.textWithoutcomma = null;
            // 
            // uc_txtBox_Serial
            // 
            this.uc_txtBox_Serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_Serial.BackColor = System.Drawing.Color.White;
            this.uc_txtBox_Serial.IsInteger = false;
            this.uc_txtBox_Serial.IsNumber = false;
            this.uc_txtBox_Serial.IsTime = false;
            this.uc_txtBox_Serial.Location = new System.Drawing.Point(364, 101);
            this.uc_txtBox_Serial.Name = "uc_txtBox_Serial";
            this.uc_txtBox_Serial.Size = new System.Drawing.Size(169, 21);
            this.uc_txtBox_Serial.TabIndex = 2;
            this.uc_txtBox_Serial.textWithcomma = null;
            this.uc_txtBox_Serial.textWithoutcomma = null;
            // 
            // uc_txtBox_Name
            // 
            this.uc_txtBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_Name.BackColor = System.Drawing.Color.LightYellow;
            this.uc_txtBox_Name.IsInteger = false;
            this.uc_txtBox_Name.IsNumber = false;
            this.uc_txtBox_Name.IsTime = false;
            this.uc_txtBox_Name.Location = new System.Drawing.Point(364, 17);
            this.uc_txtBox_Name.Name = "uc_txtBox_Name";
            this.uc_txtBox_Name.Size = new System.Drawing.Size(169, 21);
            this.uc_txtBox_Name.TabIndex = 0;
            this.uc_txtBox_Name.textWithcomma = null;
            this.uc_txtBox_Name.textWithoutcomma = null;
            // 
            // comboBox_pirority
            // 
            this.comboBox_pirority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_pirority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pirority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_pirority.FormattingEnabled = true;
            this.comboBox_pirority.Location = new System.Drawing.Point(412, 185);
            this.comboBox_pirority.Name = "comboBox_pirority";
            this.comboBox_pirority.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pirority.TabIndex = 6;
            // 
            // comboBoxlevel
            // 
            this.comboBoxlevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxlevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxlevel.FormattingEnabled = true;
            this.comboBoxlevel.Location = new System.Drawing.Point(63, 143);
            this.comboBoxlevel.Name = "comboBoxlevel";
            this.comboBoxlevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxlevel.TabIndex = 6;
            // 
            // comboBox_TypeSell
            // 
            this.comboBox_TypeSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TypeSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_TypeSell.FormattingEnabled = true;
            this.comboBox_TypeSell.Location = new System.Drawing.Point(63, 101);
            this.comboBox_TypeSell.Name = "comboBox_TypeSell";
            this.comboBox_TypeSell.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TypeSell.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام دستگاه";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "دوره تناوب سرویس دستگاه";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اولویت";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "سطح اتوماسیون";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "وضعیت هنگام خرید";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "تاریخ شروع به کار";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "تاریخ ساخت";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "شماره سریال سازنده";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "طول عمر";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " محل استقرار";
            // 
            // btn_save_device
            // 
            this.btn_save_device.Location = new System.Drawing.Point(130, 21);
            this.btn_save_device.Name = "btn_save_device";
            this.btn_save_device.Size = new System.Drawing.Size(108, 28);
            this.btn_save_device.TabIndex = 1;
            this.btn_save_device.Text = "ذخیره";
            this.btn_save_device.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "انصراف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "مدل";
            // 
            // uc_txtBox_Model
            // 
            this.uc_txtBox_Model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_Model.BackColor = System.Drawing.Color.LightYellow;
            this.uc_txtBox_Model.IsInteger = false;
            this.uc_txtBox_Model.IsNumber = false;
            this.uc_txtBox_Model.IsTime = false;
            this.uc_txtBox_Model.Location = new System.Drawing.Point(364, 228);
            this.uc_txtBox_Model.Name = "uc_txtBox_Model";
            this.uc_txtBox_Model.Size = new System.Drawing.Size(169, 21);
            this.uc_txtBox_Model.TabIndex = 0;
            this.uc_txtBox_Model.textWithcomma = null;
            this.uc_txtBox_Model.textWithoutcomma = null;
            // 
            // comboBoxperiod
            // 
            this.comboBoxperiod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxperiod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxperiod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxperiod.FormattingEnabled = true;
            this.comboBoxperiod.Location = new System.Drawing.Point(63, 185);
            this.comboBoxperiod.Name = "comboBoxperiod";
            this.comboBoxperiod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxperiod.TabIndex = 7;
            // 
            // frmMaterialOfLocation_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 393);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmMaterialOfLocation_D";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save_device;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        public ControlLibrary.uc_txtBox uc_txtBox_xLocation;
        public System.Windows.Forms.ComboBox comboBoxlevel;
        public System.Windows.Forms.ComboBox comboBox_TypeSell;
        public ControlLibrary.uc_TextBoxDate uc_TextBoxDateStart;
        public ControlLibrary.uc_TextBoxDate uc_TextBoxDateMade;
        public ControlLibrary.uc_txtBox uc_txtBox_Serial;
        public ControlLibrary.uc_txtBox uc_txtBox_Name;
        public System.Windows.Forms.ComboBox comboBox_pirority;
        private System.Windows.Forms.Label label3;
        public ControlLibrary.uc_txtBox uc_txtBoxLifeTime;
        private System.Windows.Forms.Label label9;
        public ControlLibrary.uc_txtBox uc_txtBox_Model;
        public System.Windows.Forms.ComboBox comboBoxperiod;
        private System.Windows.Forms.Label label11;

    }
}