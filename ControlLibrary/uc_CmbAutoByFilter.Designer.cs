namespace ControlLibrary
{
    partial class uc_CmbAutoByFilter
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
            this.button1 = new System.Windows.Forms.Button();
            this.uc_cmbAuto1 = new ControlLibrary.uc_cmbAuto();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_cmbAuto1
            // 
            this.uc_cmbAuto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_cmbAuto1.DropDownWidth = 180;
            this.uc_cmbAuto1.FormattingEnabled = true;
            this.uc_cmbAuto1.LimitToList = true;
            this.uc_cmbAuto1.Location = new System.Drawing.Point(0, 0);
            this.uc_cmbAuto1.MaxDropDownItems = 30;
            this.uc_cmbAuto1.Name = "uc_cmbAuto1";
            this.uc_cmbAuto1.Size = new System.Drawing.Size(168, 21);
            this.uc_cmbAuto1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uc_cmbAuto1);
            this.splitContainer1.Size = new System.Drawing.Size(200, 21);
            this.splitContainer1.SplitterDistance = 28;
            this.splitContainer1.TabIndex = 2;
            // 
            // uc_CmbAutoByFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(300, 21);
            this.MinimumSize = new System.Drawing.Size(50, 21);
            this.Name = "uc_CmbAutoByFilter";
            this.Size = new System.Drawing.Size(200, 21);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public uc_cmbAuto uc_cmbAuto1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
