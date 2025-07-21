namespace ControlLibrary
{
    partial class uc_mtxtDate
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
            this.mtxt_dateinspection = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxt_dateinspection
            // 
            this.mtxt_dateinspection.Location = new System.Drawing.Point(1, 0);
            this.mtxt_dateinspection.Mask = "0000/00/00";
            this.mtxt_dateinspection.Name = "mtxt_dateinspection";
            this.mtxt_dateinspection.Size = new System.Drawing.Size(120, 20);
            this.mtxt_dateinspection.TabIndex = 3;
            this.mtxt_dateinspection.Leave += new System.EventHandler(this.mtxt_dateinspection_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تاریخ: ";
            // 
            // uc_mtxtDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_dateinspection);
            this.Name = "uc_mtxtDate";
            this.Size = new System.Drawing.Size(179, 27);
            this.Load += new System.EventHandler(this.uc_mtxtDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_dateinspection;
        private System.Windows.Forms.Label label1;
    }
}
