namespace PAYAZOBNET.form.construct
{
    partial class frmconsructdetails
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
        /// 

        
        private void InitializeComponent()
        {
            this.textname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.radioButtoninternalmake = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxadress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxval = new System.Windows.Forms.CheckBox();
            this.checkBoxhistory = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox3ismap = new System.Windows.Forms.CheckBox();
            this.textboxdete1 = new ControlLibrary.textboxdete();
            this.ucselectdistancetime1 = new ControlLibrary.ucselectdistancetime();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textname.Location = new System.Drawing.Point(431, 27);
            this.textname.Name = "textname";
            this.textname.ReadOnly = true;
            this.textname.Size = new System.Drawing.Size(185, 20);
            this.textname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام قطعه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "انجام عملیات ساخت";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radioButton);
            this.panel1.Controls.Add(this.radioButtoninternalmake);
            this.panel1.Location = new System.Drawing.Point(190, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 49);
            this.panel1.TabIndex = 4;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(15, 10);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(138, 17);
            this.radioButton.TabIndex = 1;
            this.radioButton.Text = "ساخت خارجی ( پیمانکار)";
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtoninternalmake
            // 
            this.radioButtoninternalmake.AutoSize = true;
            this.radioButtoninternalmake.Location = new System.Drawing.Point(281, 10);
            this.radioButtoninternalmake.Name = "radioButtoninternalmake";
            this.radioButtoninternalmake.Size = new System.Drawing.Size(78, 17);
            this.radioButtoninternalmake.TabIndex = 0;
            this.radioButtoninternalmake.TabStop = true;
            this.radioButtoninternalmake.Text = "ساخت داخل";
            this.radioButtoninternalmake.UseVisualStyleBackColor = true;
            this.radioButtoninternalmake.CheckedChanged += new System.EventHandler(this.radioButtoninternalmake_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(669, 263);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textboxdete1);
            this.panel2.Controls.Add(this.textBoxadress);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBoxval);
            this.panel2.Controls.Add(this.checkBoxhistory);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 141);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // textBoxadress
            // 
            this.textBoxadress.Location = new System.Drawing.Point(15, 57);
            this.textBoxadress.Multiline = true;
            this.textBoxadress.Name = "textBoxadress";
            this.textBoxadress.Size = new System.Drawing.Size(538, 30);
            this.textBoxadress.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "تاریخ ارسال سفارش";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "آدرس پیمانکار";
            // 
            // checkBoxval
            // 
            this.checkBoxval.AutoSize = true;
            this.checkBoxval.Location = new System.Drawing.Point(454, 26);
            this.checkBoxval.Name = "checkBoxval";
            this.checkBoxval.Size = new System.Drawing.Size(200, 17);
            this.checkBoxval.TabIndex = 0;
            this.checkBoxval.Text = "آیا پیمانکار نیاز به ارزیابی اولیه دارد؟";
            this.checkBoxval.UseVisualStyleBackColor = true;
            // 
            // checkBoxhistory
            // 
            this.checkBoxhistory.AutoSize = true;
            this.checkBoxhistory.Location = new System.Drawing.Point(492, 3);
            this.checkBoxhistory.Name = "checkBoxhistory";
            this.checkBoxhistory.Size = new System.Drawing.Size(162, 17);
            this.checkBoxhistory.TabIndex = 0;
            this.checkBoxhistory.Text = "آیا پیمانکار سابقه قبلی دارد؟";
            this.checkBoxhistory.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucselectdistancetime1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 67);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "مدت زمان برای انجام سفارش";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ذخیره تغیرات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox3ismap
            // 
            this.checkBox3ismap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3ismap.AutoSize = true;
            this.checkBox3ismap.Location = new System.Drawing.Point(190, 27);
            this.checkBox3ismap.Name = "checkBox3ismap";
            this.checkBox3ismap.Size = new System.Drawing.Size(153, 17);
            this.checkBox3ismap.TabIndex = 0;
            this.checkBox3ismap.Text = "تجهیز نیاز به تهیه نقشه دارد";
            this.checkBox3ismap.UseVisualStyleBackColor = true;
            // 
            // textboxdete1
            // 
            this.textboxdete1.accept = false;
            this.textboxdete1.Location = new System.Drawing.Point(383, 99);
            this.textboxdete1.Name = "textboxdete1";
            this.textboxdete1.showbutton = true;
            this.textboxdete1.Size = new System.Drawing.Size(170, 21);
            this.textboxdete1.TabIndex = 3;
            // 
            // ucselectdistancetime1
            // 
            this.ucselectdistancetime1.Location = new System.Drawing.Point(333, 3);
            this.ucselectdistancetime1.MaximumSize = new System.Drawing.Size(210, 24);
            this.ucselectdistancetime1.MinimumSize = new System.Drawing.Size(120, 24);
            this.ucselectdistancetime1.Name = "ucselectdistancetime1";
            this.ucselectdistancetime1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucselectdistancetime1.selecteddistansbyday = 0;
            this.ucselectdistancetime1.Size = new System.Drawing.Size(183, 24);
            this.ucselectdistancetime1.TabIndex = 2;
            // 
            // frmconsructdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 389);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.checkBox3ismap);
            this.Name = "frmconsructdetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مشخصات قطعات ساختی";
            this.Load += new System.EventHandler(this.frmconsructdetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textname;
        public System.Windows.Forms.RadioButton radioButton;
        public System.Windows.Forms.RadioButton radioButtoninternalmake;
        public System.Windows.Forms.TextBox textBoxadress;
        public System.Windows.Forms.CheckBox checkBoxval;
        public System.Windows.Forms.CheckBox checkBoxhistory;
        public System.Windows.Forms.CheckBox checkBox3ismap;
        public ControlLibrary.textboxdete textboxdete1;
        public ControlLibrary.ucselectdistancetime ucselectdistancetime1;
       

    }
}