namespace ControlLibrary
{
    partial class uc_Filter_Date
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_To = new ShDateTimePicker.DateTimePicker();
            this.dateTimePicker_From = new ShDateTimePicker.DateTimePicker();
            this.lbl_TA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Header = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dateTimePicker_To);
            this.panel1.Controls.Add(this.dateTimePicker_From);
            this.panel1.Controls.Add(this.lbl_TA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 48);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_To.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dateTimePicker_To.DateValue = null;
            this.dateTimePicker_To.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker_To.Format = ShDateTimePicker.DateTimePicker.ShDateFormat.ShortDate;
            this.dateTimePicker_To.Location = new System.Drawing.Point(4, 3);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(101, 28);
            this.dateTimePicker_To.TabIndex = 4;
            this.dateTimePicker_To.Tag = "test";
            this.dateTimePicker_To.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_From.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dateTimePicker_From.DateValue = "1395/8/8";
            this.dateTimePicker_From.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker_From.Format = ShDateTimePicker.DateTimePicker.ShDateFormat.ShortDate;
            this.dateTimePicker_From.Location = new System.Drawing.Point(134, 3);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(101, 28);
            this.dateTimePicker_From.TabIndex = 4;
            this.dateTimePicker_From.Tag = "test";
            this.dateTimePicker_From.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // lbl_TA
            // 
            this.lbl_TA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TA.AutoSize = true;
            this.lbl_TA.Location = new System.Drawing.Point(113, 10);
            this.lbl_TA.Name = "lbl_TA";
            this.lbl_TA.Size = new System.Drawing.Size(15, 13);
            this.lbl_TA.TabIndex = 3;
            this.lbl_TA.Text = "تا";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "تاریخ:";
            // 
            // groupBox_Header
            // 
            this.groupBox_Header.Controls.Add(this.panel1);
            this.groupBox_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Header.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Header.Name = "groupBox_Header";
            this.groupBox_Header.Size = new System.Drawing.Size(333, 67);
            this.groupBox_Header.TabIndex = 5;
            this.groupBox_Header.TabStop = false;
            this.groupBox_Header.Text = "فیلتر تاریخ";
            // 
            // uc_Filter_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Header);
            this.Name = "uc_Filter_Date";
            this.Size = new System.Drawing.Size(333, 67);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox_Header;
        private System.Windows.Forms.Label lbl_TA;
        private System.Windows.Forms.Label label5;
        private ShDateTimePicker.DateTimePicker dateTimePicker_From;
        private ShDateTimePicker.DateTimePicker dateTimePicker_To;
    }
}
