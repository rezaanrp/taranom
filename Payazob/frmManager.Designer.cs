namespace Payazob
{
    partial class frmManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.glassButtonINV = new Glass.GlassButton();
            this.glassButton_EXit = new Glass.GlassButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 555);
            this.panel1.TabIndex = 31;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel2.Controls.Add(this.glassButton_EXit);
            this.splitContainer1.Panel2.Controls.Add(this.glassButtonINV);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(971, 555);
            this.splitContainer1.SplitterDistance = 771;
            this.splitContainer1.TabIndex = 33;
            // 
            // radPanel1
            // 

            // 
            // glassButtonINV
            // 
            this.glassButtonINV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.glassButtonINV.Location = new System.Drawing.Point(15, 12);
            this.glassButtonINV.Name = "glassButtonINV";
            this.glassButtonINV.Size = new System.Drawing.Size(169, 61);
            this.glassButtonINV.TabIndex = 3;
            this.glassButtonINV.Text = "موجودی کل در جریان";
            this.glassButtonINV.Click += new System.EventHandler(this.glassButtonINV_Click);
            // 
            // glassButton_EXit
            // 
            this.glassButton_EXit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.glassButton_EXit.Location = new System.Drawing.Point(14, 98);
            this.glassButton_EXit.Name = "glassButton_EXit";
            this.glassButton_EXit.Size = new System.Drawing.Size(169, 61);
            this.glassButton_EXit.TabIndex = 4;
            this.glassButton_EXit.Text = "خروج";
            this.glassButton_EXit.Click += new System.EventHandler(this.glassButton_EXit_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(971, 555);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Glass.GlassButton glassButtonINV;
        private Glass.GlassButton glassButton_EXit;
    }
}