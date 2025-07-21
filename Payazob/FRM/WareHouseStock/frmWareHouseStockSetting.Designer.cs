namespace TARANOM.FRM.WareHouseStock
{
    partial class frmWareHouseStockSetting
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
            this.button_Ok = new System.Windows.Forms.Button();
            this.mtxt_dateto = new System.Windows.Forms.MaskedTextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_datefrom = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_txtBox_Profit = new ControlLibrary.uc_txtBox(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uc_txtBox_FCT = new ControlLibrary.uc_txtBox(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.Honeydew;
            this.button_Ok.Location = new System.Drawing.Point(12, 31);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 6;
            this.button_Ok.Text = "ثبت";
            this.button_Ok.UseVisualStyleBackColor = false;
            this.button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // mtxt_dateto
            // 
            this.mtxt_dateto.Location = new System.Drawing.Point(10, 22);
            this.mtxt_dateto.Mask = "0000/00/00";
            this.mtxt_dateto.Name = "mtxt_dateto";
            this.mtxt_dateto.Size = new System.Drawing.Size(62, 21);
            this.mtxt_dateto.TabIndex = 2;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Bisque;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(12, 62);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "لغو";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxt_datefrom);
            this.groupBox1.Controls.Add(this.mtxt_dateto);
            this.groupBox1.Location = new System.Drawing.Point(111, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "تا";
            // 
            // mtxt_datefrom
            // 
            this.mtxt_datefrom.Location = new System.Drawing.Point(97, 21);
            this.mtxt_datefrom.Mask = "0000/00/00";
            this.mtxt_datefrom.Name = "mtxt_datefrom";
            this.mtxt_datefrom.Size = new System.Drawing.Size(63, 21);
            this.mtxt_datefrom.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.uc_txtBox_Profit);
            this.groupBox2.Location = new System.Drawing.Point(213, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حاشیه سود";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "درصد";
            // 
            // uc_txtBox_Profit
            // 
            this.uc_txtBox_Profit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_Profit.IsInteger = false;
            this.uc_txtBox_Profit.IsNumber = true;
            this.uc_txtBox_Profit.IsTime = false;
            this.uc_txtBox_Profit.Location = new System.Drawing.Point(38, 20);
            this.uc_txtBox_Profit.MaxLength = 4;
            this.uc_txtBox_Profit.Name = "uc_txtBox_Profit";
            this.uc_txtBox_Profit.Size = new System.Drawing.Size(44, 21);
            this.uc_txtBox_Profit.TabIndex = 3;
            this.uc_txtBox_Profit.Text = "0";
            this.uc_txtBox_Profit.textWithcomma = null;
            this.uc_txtBox_Profit.textWithoutcomma = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uc_txtBox_FCT);
            this.groupBox3.Location = new System.Drawing.Point(111, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 52);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "شروع فاکتور";
            // 
            // uc_txtBox_FCT
            // 
            this.uc_txtBox_FCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBox_FCT.IsInteger = true;
            this.uc_txtBox_FCT.IsNumber = true;
            this.uc_txtBox_FCT.IsTime = false;
            this.uc_txtBox_FCT.Location = new System.Drawing.Point(10, 20);
            this.uc_txtBox_FCT.MaxLength = 10;
            this.uc_txtBox_FCT.Name = "uc_txtBox_FCT";
            this.uc_txtBox_FCT.Size = new System.Drawing.Size(72, 21);
            this.uc_txtBox_FCT.TabIndex = 4;
            this.uc_txtBox_FCT.Text = "1";
            this.uc_txtBox_FCT.textWithcomma = "1";
            this.uc_txtBox_FCT.textWithoutcomma = "1";
            // 
            // frmWareHouseStockSetting
            // 
            this.AcceptButton = this.button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(322, 134);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWareHouseStockSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.MaskedTextBox mtxt_dateto;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_datefrom;
        private ControlLibrary.uc_txtBox uc_txtBox_Profit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private ControlLibrary.uc_txtBox uc_txtBox_FCT;
    }
}