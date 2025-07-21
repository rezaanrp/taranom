namespace Payazob
{
    partial class frmSchedule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uc_txtBoxIp = new ControlLibrary.uc_txtBox(this.components);
            this.uc_TextBoxDate1 = new ControlLibrary.uc_TextBoxDate(this.components);
            this.uc_txtBoxNetBios = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBoxMessage = new ControlLibrary.uc_txtBox(this.components);
            this.rdb_Close = new System.Windows.Forms.RadioButton();
            this.rdb_Reset = new System.Windows.Forms.RadioButton();
            this.rdb_turnOff = new System.Windows.Forms.RadioButton();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Delete);
            this.splitContainer1.Panel2.Controls.Add(this.btn_send);
            this.splitContainer1.Panel2.Controls.Add(this.rdb_turnOff);
            this.splitContainer1.Panel2.Controls.Add(this.rdb_Reset);
            this.splitContainer1.Panel2.Controls.Add(this.rdb_Close);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBoxMessage);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBoxNetBios);
            this.splitContainer1.Panel2.Controls.Add(this.uc_TextBoxDate1);
            this.splitContainer1.Panel2.Controls.Add(this.uc_txtBoxIp);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(683, 387);
            this.splitContainer1.SplitterDistance = 124;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 124);
            this.dataGridView1.TabIndex = 0;
            // 
            // uc_txtBoxIp
            // 
            this.uc_txtBoxIp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBoxIp.IsInteger = false;
            this.uc_txtBoxIp.IsNumber = false;
            this.uc_txtBoxIp.IsTime = false;
            this.uc_txtBoxIp.Location = new System.Drawing.Point(369, 59);
            this.uc_txtBoxIp.Multiline = true;
            this.uc_txtBoxIp.Name = "uc_txtBoxIp";
            this.uc_txtBoxIp.Size = new System.Drawing.Size(238, 48);
            this.uc_txtBoxIp.TabIndex = 3;
            // 
            // uc_TextBoxDate1
            // 
            this.uc_TextBoxDate1.accept = false;
            this.uc_TextBoxDate1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uc_TextBoxDate1.BackColor = System.Drawing.Color.Pink;
            this.uc_TextBoxDate1.Location = new System.Drawing.Point(487, 18);
            this.uc_TextBoxDate1.Mask = "0000/00/00";
            this.uc_TextBoxDate1.Name = "uc_TextBoxDate1";
            this.uc_TextBoxDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_TextBoxDate1.Size = new System.Drawing.Size(120, 21);
            this.uc_TextBoxDate1.TabIndex = 4;
            // 
            // uc_txtBoxNetBios
            // 
            this.uc_txtBoxNetBios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBoxNetBios.IsInteger = false;
            this.uc_txtBoxNetBios.IsNumber = false;
            this.uc_txtBoxNetBios.IsTime = false;
            this.uc_txtBoxNetBios.Location = new System.Drawing.Point(23, 59);
            this.uc_txtBoxNetBios.Multiline = true;
            this.uc_txtBoxNetBios.Name = "uc_txtBoxNetBios";
            this.uc_txtBoxNetBios.Size = new System.Drawing.Size(290, 48);
            this.uc_txtBoxNetBios.TabIndex = 5;
            // 
            // uc_txtBoxMessage
            // 
            this.uc_txtBoxMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBoxMessage.IsInteger = false;
            this.uc_txtBoxMessage.IsNumber = false;
            this.uc_txtBoxMessage.IsTime = false;
            this.uc_txtBoxMessage.Location = new System.Drawing.Point(23, 131);
            this.uc_txtBoxMessage.Multiline = true;
            this.uc_txtBoxMessage.Name = "uc_txtBoxMessage";
            this.uc_txtBoxMessage.Size = new System.Drawing.Size(584, 52);
            this.uc_txtBoxMessage.TabIndex = 6;
            // 
            // rdb_Close
            // 
            this.rdb_Close.AutoSize = true;
            this.rdb_Close.Location = new System.Drawing.Point(520, 209);
            this.rdb_Close.Name = "rdb_Close";
            this.rdb_Close.Size = new System.Drawing.Size(81, 17);
            this.rdb_Close.TabIndex = 7;
            this.rdb_Close.TabStop = true;
            this.rdb_Close.Text = "بستن برنامه";
            this.rdb_Close.UseVisualStyleBackColor = true;
            // 
            // rdb_Reset
            // 
            this.rdb_Reset.AutoSize = true;
            this.rdb_Reset.Location = new System.Drawing.Point(416, 209);
            this.rdb_Reset.Name = "rdb_Reset";
            this.rdb_Reset.Size = new System.Drawing.Size(79, 17);
            this.rdb_Reset.TabIndex = 8;
            this.rdb_Reset.TabStop = true;
            this.rdb_Reset.Text = "ریست کردن";
            this.rdb_Reset.UseVisualStyleBackColor = true;
            // 
            // rdb_turnOff
            // 
            this.rdb_turnOff.AutoSize = true;
            this.rdb_turnOff.Location = new System.Drawing.Point(305, 209);
            this.rdb_turnOff.Name = "rdb_turnOff";
            this.rdb_turnOff.Size = new System.Drawing.Size(84, 17);
            this.rdb_turnOff.TabIndex = 9;
            this.rdb_turnOff.TabStop = true;
            this.rdb_turnOff.Text = "خاموش کردن";
            this.rdb_turnOff.UseVisualStyleBackColor = true;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(110, 209);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "ارسال";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(29, 209);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NetBios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "پیغام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "تاریخ";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmSchedule";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دادن برنامه به سیستم ها";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RadioButton rdb_turnOff;
        private System.Windows.Forms.RadioButton rdb_Reset;
        private System.Windows.Forms.RadioButton rdb_Close;
        private ControlLibrary.uc_txtBox uc_txtBoxMessage;
        private ControlLibrary.uc_txtBox uc_txtBoxNetBios;
        private ControlLibrary.uc_TextBoxDate uc_TextBoxDate1;
        private ControlLibrary.uc_txtBox uc_txtBoxIp;
    }
}