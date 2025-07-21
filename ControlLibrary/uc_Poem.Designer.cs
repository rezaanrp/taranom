namespace ControlLibrary
{
    partial class uc_Poem
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
            this.lbl_Poem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Poem
            // 
            this.lbl_Poem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Poem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Poem.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Poem.ForeColor = System.Drawing.Color.Black;
            this.lbl_Poem.Location = new System.Drawing.Point(0, 0);
            this.lbl_Poem.Name = "lbl_Poem";
            this.lbl_Poem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Poem.Size = new System.Drawing.Size(678, 227);
            this.lbl_Poem.TabIndex = 1;
            this.lbl_Poem.Text = " بخشش کنید، اما نگذارید از شما سوء استفاده شود.\r\n6";
            this.lbl_Poem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_Poem.DoubleClick += new System.EventHandler(this.lbl_Poem_DoubleClick);
            // 
            // uc_Poem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Poem);
            this.Name = "uc_Poem";
            this.Size = new System.Drawing.Size(678, 227);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Poem;
    }
}
