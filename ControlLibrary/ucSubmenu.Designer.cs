namespace ControlLibrary
{
    partial class ucSubmenu
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
            this.btn_planning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_planning
            // 
            this.btn_planning.Location = new System.Drawing.Point(465, 32);
            this.btn_planning.Name = "btn_planning";
            this.btn_planning.Size = new System.Drawing.Size(70, 41);
            this.btn_planning.TabIndex = 0;
            this.btn_planning.Text = "برنامه ریزی";
            this.btn_planning.UseVisualStyleBackColor = true;
            this.btn_planning.Click += new System.EventHandler(this.btn_planning_Click);
            // 
            // ucSubmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_planning);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ucSubmenu";
            this.Size = new System.Drawing.Size(577, 442);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_planning;
    }
}
