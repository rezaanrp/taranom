namespace TARANOM
{
    partial class Form2
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
            this.uc_ExportExcelFile1 = new ControlLibrary.uc_ExportExcelFile();
            this.SuspendLayout();
            // 
            // uc_ExportExcelFile1
            // 
            this.uc_ExportExcelFile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_ExportExcelFile1.Fildvg = null;
            this.uc_ExportExcelFile1.Location = new System.Drawing.Point(0, 10);
            this.uc_ExportExcelFile1.Name = "uc_ExportExcelFile1";
            this.uc_ExportExcelFile1.Size = new System.Drawing.Size(278, 82);
            this.uc_ExportExcelFile1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 102);
            this.Controls.Add(this.uc_ExportExcelFile1);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.uc_ExportExcelFile uc_ExportExcelFile1;
    }
}