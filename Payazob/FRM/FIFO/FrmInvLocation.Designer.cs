namespace Payazob.FRM.FIFO
{
    partial class FrmInvLocation
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
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Mon = new System.Windows.Forms.ComboBox();
            this.cmb_Day = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_Year
            // 
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cmb_Year.Location = new System.Drawing.Point(13, 8);
            this.cmb_Year.MaxLength = 1;
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(48, 21);
            this.cmb_Year.TabIndex = 17;
            this.cmb_Year.TextChanged += new System.EventHandler(this.cmb_Day_TextChanged);
            // 
            // cmb_Mon
            // 
            this.cmb_Mon.FormattingEnabled = true;
            this.cmb_Mon.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmb_Mon.Location = new System.Drawing.Point(70, 8);
            this.cmb_Mon.MaxLength = 2;
            this.cmb_Mon.Name = "cmb_Mon";
            this.cmb_Mon.Size = new System.Drawing.Size(48, 21);
            this.cmb_Mon.TabIndex = 16;
            this.cmb_Mon.TextChanged += new System.EventHandler(this.cmb_Day_TextChanged);
            // 
            // cmb_Day
            // 
            this.cmb_Day.FormattingEnabled = true;
            this.cmb_Day.Items.AddRange(new object[] {
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
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmb_Day.Location = new System.Drawing.Point(141, 8);
            this.cmb_Day.MaxLength = 2;
            this.cmb_Day.Name = "cmb_Day";
            this.cmb_Day.Size = new System.Drawing.Size(48, 21);
            this.cmb_Day.TabIndex = 15;
            this.cmb_Day.TextChanged += new System.EventHandler(this.cmb_Day_TextChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::Payazob.Properties.Resources.delete;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(70, 49);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(35, 28);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackgroundImage = global::Payazob.Properties.Resources.check;
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(12, 49);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(35, 28);
            this.btn_OK.TabIndex = 18;
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "/";
            // 
            // FrmInvLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 87);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Mon);
            this.Controls.Add(this.cmb_Day);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmInvLocation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInvLocation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Mon;
        private System.Windows.Forms.ComboBox cmb_Day;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label2;
    }
}