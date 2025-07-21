namespace Payazob.FRM.SendMessage
{
    partial class frmNewMessage
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
            this.btn_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddReciver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uc_TextBoxDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_txtBox_reciver = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxDate = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox_Subject = new ControlLibrary.uc_txtBox(this.components);
            this.btn_abadan = new System.Windows.Forms.Button();
            this.btn_akh = new System.Windows.Forms.Button();
            this.btn_asabani = new System.Windows.Forms.Button();
            this.btn_cheshmak = new System.Windows.Forms.Button();
            this.btn_cry = new System.Windows.Forms.Button();
            this.btn_khande = new System.Windows.Forms.Button();
            this.btn_labkhand = new System.Windows.Forms.Button();
            this.btn_narahat = new System.Windows.Forms.Button();
            this.btn_like = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb_Elan = new System.Windows.Forms.CheckBox();
            this.uc_txtBox_Context = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Location = new System.Drawing.Point(12, 324);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 38);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "ارسال";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "موضوع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "گیرنده";
            // 
            // btn_AddReciver
            // 
            this.btn_AddReciver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddReciver.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddReciver.Location = new System.Drawing.Point(140, 48);
            this.btn_AddReciver.Name = "btn_AddReciver";
            this.btn_AddReciver.Size = new System.Drawing.Size(24, 21);
            this.btn_AddReciver.TabIndex = 4;
            this.btn_AddReciver.Text = "+";
            this.btn_AddReciver.UseVisualStyleBackColor = true;
            this.btn_AddReciver.Click += new System.EventHandler(this.btn_AddReciver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاریخ اعتبار";
            this.label4.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(336, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "فوریت";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "متن";
            // 
            // uc_TextBoxDate1
            // 
            this.uc_TextBoxDate1.accept = false;
            this.uc_TextBoxDate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_TextBoxDate1.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDate1.Location = new System.Drawing.Point(464, 14);
            this.uc_TextBoxDate1.Mask = "0000/00/00";
            this.uc_TextBoxDate1.Name = "uc_TextBoxDate1";
            this.uc_TextBoxDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_TextBoxDate1.Size = new System.Drawing.Size(88, 21);
            this.uc_TextBoxDate1.TabIndex = 1;
            this.uc_TextBoxDate1.Visible = false;
            // 
            // uc_txtBox_reciver
            // 
            this.uc_txtBox_reciver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBox_reciver.BackColor = System.Drawing.Color.White;
            this.uc_txtBox_reciver.IsInteger = false;
            this.uc_txtBox_reciver.IsNumber = false;
            this.uc_txtBox_reciver.IsTime = false;
            this.uc_txtBox_reciver.Location = new System.Drawing.Point(170, 48);
            this.uc_txtBox_reciver.Name = "uc_txtBox_reciver";
            this.uc_txtBox_reciver.ReadOnly = true;
            this.uc_txtBox_reciver.Size = new System.Drawing.Size(543, 21);
            this.uc_txtBox_reciver.TabIndex = 3;
            this.uc_txtBox_reciver.textWithcomma = null;
            this.uc_txtBox_reciver.textWithoutcomma = null;
            // 
            // uc_txtBoxDate
            // 
            this.uc_txtBoxDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBoxDate.BackColor = System.Drawing.Color.White;
            this.uc_txtBoxDate.IsInteger = false;
            this.uc_txtBoxDate.IsNumber = false;
            this.uc_txtBoxDate.IsTime = false;
            this.uc_txtBoxDate.Location = new System.Drawing.Point(625, 14);
            this.uc_txtBoxDate.Name = "uc_txtBoxDate";
            this.uc_txtBoxDate.ReadOnly = true;
            this.uc_txtBoxDate.Size = new System.Drawing.Size(88, 21);
            this.uc_txtBoxDate.TabIndex = 0;
            this.uc_txtBoxDate.textWithcomma = null;
            this.uc_txtBoxDate.textWithoutcomma = null;
            // 
            // uc_txtBox_Subject
            // 
            this.uc_txtBox_Subject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBox_Subject.IsInteger = false;
            this.uc_txtBox_Subject.IsNumber = false;
            this.uc_txtBox_Subject.IsTime = false;
            this.uc_txtBox_Subject.Location = new System.Drawing.Point(12, 84);
            this.uc_txtBox_Subject.MaxLength = 100;
            this.uc_txtBox_Subject.Name = "uc_txtBox_Subject";
            this.uc_txtBox_Subject.Size = new System.Drawing.Size(701, 21);
            this.uc_txtBox_Subject.TabIndex = 6;
            this.uc_txtBox_Subject.textWithcomma = null;
            this.uc_txtBox_Subject.textWithoutcomma = null;
            // 
            // btn_abadan
            // 
            this.btn_abadan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_abadan.BackgroundImage = global::TARANOM.Properties.Resources.abadan;
            this.btn_abadan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_abadan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abadan.Location = new System.Drawing.Point(226, 7);
            this.btn_abadan.Name = "btn_abadan";
            this.btn_abadan.Size = new System.Drawing.Size(26, 23);
            this.btn_abadan.TabIndex = 12;
            this.btn_abadan.UseVisualStyleBackColor = true;
            this.btn_abadan.Visible = false;
            this.btn_abadan.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_akh
            // 
            this.btn_akh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_akh.BackgroundImage = global::TARANOM.Properties.Resources.akh;
            this.btn_akh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_akh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_akh.Location = new System.Drawing.Point(200, 7);
            this.btn_akh.Name = "btn_akh";
            this.btn_akh.Size = new System.Drawing.Size(26, 23);
            this.btn_akh.TabIndex = 12;
            this.btn_akh.UseVisualStyleBackColor = true;
            this.btn_akh.Visible = false;
            this.btn_akh.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_asabani
            // 
            this.btn_asabani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_asabani.BackgroundImage = global::TARANOM.Properties.Resources.asabani;
            this.btn_asabani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_asabani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asabani.Location = new System.Drawing.Point(174, 7);
            this.btn_asabani.Name = "btn_asabani";
            this.btn_asabani.Size = new System.Drawing.Size(26, 23);
            this.btn_asabani.TabIndex = 12;
            this.btn_asabani.UseVisualStyleBackColor = true;
            this.btn_asabani.Visible = false;
            this.btn_asabani.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_cheshmak
            // 
            this.btn_cheshmak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cheshmak.BackgroundImage = global::TARANOM.Properties.Resources.cheshmak;
            this.btn_cheshmak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cheshmak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cheshmak.Location = new System.Drawing.Point(148, 7);
            this.btn_cheshmak.Name = "btn_cheshmak";
            this.btn_cheshmak.Size = new System.Drawing.Size(26, 23);
            this.btn_cheshmak.TabIndex = 12;
            this.btn_cheshmak.UseVisualStyleBackColor = true;
            this.btn_cheshmak.Visible = false;
            this.btn_cheshmak.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_cry
            // 
            this.btn_cry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cry.BackgroundImage = global::TARANOM.Properties.Resources.cry;
            this.btn_cry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cry.Location = new System.Drawing.Point(122, 7);
            this.btn_cry.Name = "btn_cry";
            this.btn_cry.Size = new System.Drawing.Size(26, 23);
            this.btn_cry.TabIndex = 12;
            this.btn_cry.UseVisualStyleBackColor = true;
            this.btn_cry.Visible = false;
            this.btn_cry.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_khande
            // 
            this.btn_khande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_khande.BackgroundImage = global::TARANOM.Properties.Resources.khande;
            this.btn_khande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_khande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khande.Location = new System.Drawing.Point(96, 7);
            this.btn_khande.Name = "btn_khande";
            this.btn_khande.Size = new System.Drawing.Size(26, 23);
            this.btn_khande.TabIndex = 12;
            this.btn_khande.UseVisualStyleBackColor = true;
            this.btn_khande.Visible = false;
            this.btn_khande.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_labkhand
            // 
            this.btn_labkhand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_labkhand.BackgroundImage = global::TARANOM.Properties.Resources.labkhand;
            this.btn_labkhand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_labkhand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_labkhand.Location = new System.Drawing.Point(70, 7);
            this.btn_labkhand.Name = "btn_labkhand";
            this.btn_labkhand.Size = new System.Drawing.Size(26, 23);
            this.btn_labkhand.TabIndex = 12;
            this.btn_labkhand.UseVisualStyleBackColor = true;
            this.btn_labkhand.Visible = false;
            this.btn_labkhand.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_narahat
            // 
            this.btn_narahat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_narahat.BackgroundImage = global::TARANOM.Properties.Resources.narahat;
            this.btn_narahat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_narahat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_narahat.Location = new System.Drawing.Point(44, 7);
            this.btn_narahat.Name = "btn_narahat";
            this.btn_narahat.Size = new System.Drawing.Size(26, 23);
            this.btn_narahat.TabIndex = 12;
            this.btn_narahat.UseVisualStyleBackColor = true;
            this.btn_narahat.Visible = false;
            this.btn_narahat.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // btn_like
            // 
            this.btn_like.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_like.BackgroundImage = global::TARANOM.Properties.Resources.like;
            this.btn_like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_like.Location = new System.Drawing.Point(18, 7);
            this.btn_like.Name = "btn_like";
            this.btn_like.Size = new System.Drawing.Size(26, 23);
            this.btn_like.TabIndex = 12;
            this.btn_like.UseVisualStyleBackColor = true;
            this.btn_like.Visible = false;
            this.btn_like.Click += new System.EventHandler(this.btn_abadan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_like);
            this.panel1.Controls.Add(this.btn_abadan);
            this.panel1.Controls.Add(this.btn_narahat);
            this.panel1.Controls.Add(this.btn_akh);
            this.panel1.Controls.Add(this.btn_labkhand);
            this.panel1.Controls.Add(this.btn_asabani);
            this.panel1.Controls.Add(this.btn_khande);
            this.panel1.Controls.Add(this.btn_cheshmak);
            this.panel1.Controls.Add(this.btn_cry);
            this.panel1.Location = new System.Drawing.Point(449, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 38);
            this.panel1.TabIndex = 13;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // chb_Elan
            // 
            this.chb_Elan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chb_Elan.Location = new System.Drawing.Point(12, 48);
            this.chb_Elan.Name = "chb_Elan";
            this.chb_Elan.Size = new System.Drawing.Size(122, 21);
            this.chb_Elan.TabIndex = 5;
            this.chb_Elan.Text = "اعلان";
            this.chb_Elan.UseVisualStyleBackColor = false;
            // 
            // uc_txtBox_Context
            // 
            this.uc_txtBox_Context.Location = new System.Drawing.Point(12, 114);
            this.uc_txtBox_Context.Name = "uc_txtBox_Context";
            this.uc_txtBox_Context.Size = new System.Drawing.Size(701, 204);
            this.uc_txtBox_Context.TabIndex = 7;
            this.uc_txtBox_Context.Text = "";
            // 
            // frmNewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 370);
            this.Controls.Add(this.uc_txtBox_Context);
            this.Controls.Add(this.chb_Elan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.uc_TextBoxDate1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_AddReciver);
            this.Controls.Add(this.uc_txtBox_reciver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc_txtBoxDate);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.uc_txtBox_Subject);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNewMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ارسال پیام جدید";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.uc_txtBox uc_txtBox_Subject;
        private System.Windows.Forms.Button btn_Send;
        private ControlLibrary.uc_txtBox uc_txtBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ControlLibrary.uc_txtBox uc_txtBox_reciver;
        private System.Windows.Forms.Button btn_AddReciver;
        private System.Windows.Forms.Label label4;
        private ControlLibrary.uc_TextBoxDate uc_TextBoxDate1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_abadan;
        private System.Windows.Forms.Button btn_akh;
        private System.Windows.Forms.Button btn_asabani;
        private System.Windows.Forms.Button btn_cheshmak;
        private System.Windows.Forms.Button btn_cry;
        private System.Windows.Forms.Button btn_khande;
        private System.Windows.Forms.Button btn_labkhand;
        private System.Windows.Forms.Button btn_narahat;
        private System.Windows.Forms.Button btn_like;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chb_Elan;
        private System.Windows.Forms.RichTextBox uc_txtBox_Context;
    }
}