namespace PAYAZOBNET.form.coding
{
    partial class frm_objectfordisposal
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
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new System.Windows.Forms.Button();
            this.btnobject = new System.Windows.Forms.Button();
            this.combo_object_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_set1_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboset3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_set2_name = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_saloon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_device_no = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_device_name = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(83, 270);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(78, 21);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonX1);
            this.groupBox4.Controls.Add(this.btnobject);
            this.groupBox4.Controls.Add(this.combo_object_name);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(21, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(306, 63);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مشخصات قطعه";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
          //  this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
           // this.buttonX1.Image = global::PAYAZOBNET.Properties.Resources._0457;
          //  this.buttonX1.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonX1.Location = new System.Drawing.Point(38, 22);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(30, 23);
           // this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
           // this.buttonX1.Tooltip = "انتخاب قطعه";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnobject
            // 
            this.btnobject.Location = new System.Drawing.Point(8, 22);
            this.btnobject.Name = "btnobject";
            this.btnobject.Size = new System.Drawing.Size(25, 23);
            this.btnobject.TabIndex = 4;
            this.btnobject.Text = "...";
            this.btnobject.UseVisualStyleBackColor = true;
            // 
            // combo_object_name
            // 
            this.combo_object_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_object_name.FormattingEnabled = true;
            this.combo_object_name.Location = new System.Drawing.Point(74, 24);
            this.combo_object_name.MaxDropDownItems = 15;
            this.combo_object_name.Name = "combo_object_name";
            this.combo_object_name.Size = new System.Drawing.Size(170, 21);
            this.combo_object_name.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "نام قطعه ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_set1_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(304, 56);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مجموعه اصلی";
            // 
            // combo_set1_name
            // 
            this.combo_set1_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_set1_name.FormattingEnabled = true;
            this.combo_set1_name.Location = new System.Drawing.Point(34, 24);
            this.combo_set1_name.MaxDropDownItems = 12;
            this.combo_set1_name.Name = "combo_set1_name";
            this.combo_set1_name.Size = new System.Drawing.Size(154, 21);
            this.combo_set1_name.TabIndex = 0;
            this.combo_set1_name.SelectedIndexChanged += new System.EventHandler(this.combo_set1_name_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام مجموعه اصلی";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboset3);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(21, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(304, 56);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "مجموعه فرعی 2";
            // 
            // comboset3
            // 
            this.comboset3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboset3.FormattingEnabled = true;
            this.comboset3.Location = new System.Drawing.Point(34, 19);
            this.comboset3.MaxDropDownItems = 12;
            this.comboset3.Name = "comboset3";
            this.comboset3.Size = new System.Drawing.Size(154, 21);
            this.comboset3.TabIndex = 0;
            this.comboset3.SelectedIndexChanged += new System.EventHandler(this.comboset3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "نام مجموعه فرعی";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_set2_name);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(21, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(304, 56);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مجموعه فرعی";
            // 
            // combo_set2_name
            // 
            this.combo_set2_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_set2_name.FormattingEnabled = true;
            this.combo_set2_name.Location = new System.Drawing.Point(34, 19);
            this.combo_set2_name.MaxDropDownItems = 12;
            this.combo_set2_name.Name = "combo_set2_name";
            this.combo_set2_name.Size = new System.Drawing.Size(154, 21);
            this.combo_set2_name.TabIndex = 0;
            this.combo_set2_name.SelectedIndexChanged += new System.EventHandler(this.combo_set2_name_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "نام مجموعه فرعی";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comb_saloon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_device_no);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_device_name);
            this.groupBox1.Location = new System.Drawing.Point(17, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(310, 11);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات دستگاه";
            this.groupBox1.Visible = false;
            // 
            // comb_saloon
            // 
            this.comb_saloon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_saloon.FormattingEnabled = true;
            this.comb_saloon.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comb_saloon.Location = new System.Drawing.Point(34, 19);
            this.comb_saloon.Name = "comb_saloon";
            this.comb_saloon.Size = new System.Drawing.Size(160, 21);
            this.comb_saloon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "محل استقرار وسیله ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام دستگاه";
            // 
            // combo_device_no
            // 
            this.combo_device_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_device_no.FormattingEnabled = true;
            this.combo_device_no.Location = new System.Drawing.Point(34, 78);
            this.combo_device_no.Name = "combo_device_no";
            this.combo_device_no.Size = new System.Drawing.Size(160, 21);
            this.combo_device_no.TabIndex = 2;
            this.combo_device_no.SelectedIndexChanged += new System.EventHandler(this.combo_device_no_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "شماره دستگاه";
            // 
            // combo_device_name
            // 
            this.combo_device_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_device_name.FormattingEnabled = true;
            this.combo_device_name.ItemHeight = 13;
            this.combo_device_name.Location = new System.Drawing.Point(34, 46);
            this.combo_device_name.MaxDropDownItems = 12;
            this.combo_device_name.Name = "combo_device_name";
            this.combo_device_name.Size = new System.Drawing.Size(160, 21);
            this.combo_device_name.TabIndex = 1;
            this.combo_device_name.SelectedIndexChanged += new System.EventHandler(this.combo_device_name_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 21);
            this.button1.TabIndex = 17;
            this.button1.Text = "انصراف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_objectfordisposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(327, 309);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_objectfordisposal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "قطعه مصرفی";
            this.Load += new System.EventHandler(this.frm_objectfordisposal_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonX1;
        private System.Windows.Forms.Button btnobject;
        private System.Windows.Forms.ComboBox combo_object_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_set1_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboset3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_set2_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_saloon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public  System.Windows.Forms.ComboBox combo_device_no;
        private System.Windows.Forms.Label label3;
       public   System.Windows.Forms.ComboBox combo_device_name;
       private System.Windows.Forms.Button button1;
    }
}