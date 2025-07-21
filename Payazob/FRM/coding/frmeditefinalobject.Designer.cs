namespace PAYAZOBNET.form.coding
{
    partial class frmeditefinalobject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
           
            this.usnumericupdown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usnumericupdown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(229, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد قطعه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(229, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تعداد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(229, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اولویت";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "بالا",
            "متوسط",
            "کم ",
            "بی اهمیت"});
            this.comboBox1.Location = new System.Drawing.Point(57, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.BackColor = System.Drawing.Color.Transparent;
            this.lblcod.Location = new System.Drawing.Point(54, 53);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(179, 13);
            this.lblcod.TabIndex = 5;
            this.lblcod.Text = "label4....................................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(229, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "نام قطعه";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Location = new System.Drawing.Point(54, 79);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(179, 13);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "label4....................................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ویرایش تعداد قطعه و اولویت قطعات دستگاه ها";
            // 
            // shapeContainer1
            // 
       
            this.usnumericupdown1.BackColor = System.Drawing.SystemColors.Info;
            this.usnumericupdown1.Location = new System.Drawing.Point(57, 105);
            this.usnumericupdown1.Name = "usnumericupdown1";
            this.usnumericupdown1.Size = new System.Drawing.Size(120, 21);
            this.usnumericupdown1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmeditefinalobject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
           // this.BackgroundImage = global::PAYAZOBNET.Properties.Resources.backgranduploadmap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usnumericupdown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
           
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmeditefinalobject";
            this.Text = "ویرایش تعداد و اولویت قطعات دستگاه ها";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmeditefinalobject_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmeditefinalobject_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmeditefinalobject_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.usnumericupdown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label lblcod;
        public System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown usnumericupdown1;
        private System.Windows.Forms.Button button1;
    }
}