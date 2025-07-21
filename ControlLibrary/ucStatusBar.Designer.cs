namespace ControlLibrary
{
    partial class ucStatusBar
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tStSL_ShamciDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Min = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_MinV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Avg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_AvgV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Max = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_MaxV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Sum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_SumV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Count = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_CountV = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStSL_ShamciDate,
            this.tssl_Min,
            this.tssl_MinV,
            this.tssl_Avg,
            this.tssl_AvgV,
            this.tss_Max,
            this.tss_MaxV,
            this.tss_Sum,
            this.tss_SumV,
            this.tss_Count,
            this.tss_CountV});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tStSL_ShamciDate
            // 
            this.tStSL_ShamciDate.Name = "tStSL_ShamciDate";
            this.tStSL_ShamciDate.Size = new System.Drawing.Size(0, 19);
            // 
            // tssl_Min
            // 
            this.tssl_Min.ForeColor = System.Drawing.Color.Black;
            this.tssl_Min.Name = "tssl_Min";
            this.tssl_Min.Size = new System.Drawing.Size(45, 19);
            this.tssl_Min.Text = " کمترین";
            this.tssl_Min.Visible = false;
            // 
            // tssl_MinV
            // 
            this.tssl_MinV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tssl_MinV.Name = "tssl_MinV";
            this.tssl_MinV.Size = new System.Drawing.Size(14, 19);
            this.tssl_MinV.Text = "0";
            this.tssl_MinV.Visible = false;
            // 
            // tssl_Avg
            // 
            this.tssl_Avg.ForeColor = System.Drawing.Color.Black;
            this.tssl_Avg.Name = "tssl_Avg";
            this.tssl_Avg.Size = new System.Drawing.Size(43, 19);
            this.tssl_Avg.Text = "میانگین";
            this.tssl_Avg.Visible = false;
            // 
            // tssl_AvgV
            // 
            this.tssl_AvgV.ForeColor = System.Drawing.Color.Green;
            this.tssl_AvgV.Name = "tssl_AvgV";
            this.tssl_AvgV.Size = new System.Drawing.Size(14, 19);
            this.tssl_AvgV.Text = "0";
            this.tssl_AvgV.Visible = false;
            // 
            // tss_Max
            // 
            this.tss_Max.ForeColor = System.Drawing.Color.Black;
            this.tss_Max.Name = "tss_Max";
            this.tss_Max.Size = new System.Drawing.Size(48, 19);
            this.tss_Max.Text = "بیشترین";
            this.tss_Max.Visible = false;
            // 
            // tss_MaxV
            // 
            this.tss_MaxV.ForeColor = System.Drawing.Color.Red;
            this.tss_MaxV.Name = "tss_MaxV";
            this.tss_MaxV.Size = new System.Drawing.Size(14, 19);
            this.tss_MaxV.Text = "0";
            this.tss_MaxV.Visible = false;
            // 
            // tss_Sum
            // 
            this.tss_Sum.ForeColor = System.Drawing.Color.Black;
            this.tss_Sum.Name = "tss_Sum";
            this.tss_Sum.Size = new System.Drawing.Size(44, 19);
            this.tss_Sum.Text = " مجموع";
            this.tss_Sum.Visible = false;
            // 
            // tss_SumV
            // 
            this.tss_SumV.ForeColor = System.Drawing.Color.Blue;
            this.tss_SumV.Name = "tss_SumV";
            this.tss_SumV.Size = new System.Drawing.Size(14, 19);
            this.tss_SumV.Text = "0";
            this.tss_SumV.Visible = false;
            // 
            // tss_Count
            // 
            this.tss_Count.ForeColor = System.Drawing.Color.Black;
            this.tss_Count.Name = "tss_Count";
            this.tss_Count.Size = new System.Drawing.Size(32, 19);
            this.tss_Count.Text = "تعداد";
            this.tss_Count.Visible = false;
            // 
            // tss_CountV
            // 
            this.tss_CountV.ForeColor = System.Drawing.Color.OrangeRed;
            this.tss_CountV.Name = "tss_CountV";
            this.tss_CountV.Size = new System.Drawing.Size(14, 19);
            this.tss_CountV.Text = "0";
            this.tss_CountV.Visible = false;
            // 
            // ucStatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Name = "ucStatusBar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(631, 24);
            this.Load += new System.EventHandler(this.ucStatusBar_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tStSL_ShamciDate;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Min;
        private System.Windows.Forms.ToolStripStatusLabel tssl_MinV;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Avg;
        private System.Windows.Forms.ToolStripStatusLabel tssl_AvgV;
        private System.Windows.Forms.ToolStripStatusLabel tss_Max;
        private System.Windows.Forms.ToolStripStatusLabel tss_MaxV;
        private System.Windows.Forms.ToolStripStatusLabel tss_Sum;
        private System.Windows.Forms.ToolStripStatusLabel tss_SumV;
        private System.Windows.Forms.ToolStripStatusLabel tss_Count;
        private System.Windows.Forms.ToolStripStatusLabel tss_CountV;
    }
}
