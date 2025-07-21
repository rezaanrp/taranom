namespace Payazob.FRM.MaterialLocation
{
    partial class frmMatrialLocation_Grp
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uc_txtBox1 = new ControlLibrary.uc_txtBox(this.components);
            this.uc_txtBox2 = new ControlLibrary.uc_txtBox(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uc_txtBox2);
            this.groupBox3.Controls.Add(this.uc_txtBox1);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(565, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مجموعه فرعی";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(327, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "این مجموعه یک وسیله مکانیکی می باشد";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "نام مجموعه فرعی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "شرح جزئیات";
            // 
            // uc_txtBox1
            // 
            this.uc_txtBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBox1.IsInteger = false;
            this.uc_txtBox1.IsNumber = false;
            this.uc_txtBox1.IsTime = false;
            this.uc_txtBox1.Location = new System.Drawing.Point(39, 19);
            this.uc_txtBox1.Name = "uc_txtBox1";
            this.uc_txtBox1.Size = new System.Drawing.Size(406, 21);
            this.uc_txtBox1.TabIndex = 4;
            this.uc_txtBox1.textWithcomma = null;
            this.uc_txtBox1.textWithoutcomma = null;
            // 
            // uc_txtBox2
            // 
            this.uc_txtBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBox2.IsInteger = false;
            this.uc_txtBox2.IsNumber = false;
            this.uc_txtBox2.IsTime = false;
            this.uc_txtBox2.Location = new System.Drawing.Point(39, 57);
            this.uc_txtBox2.Multiline = true;
            this.uc_txtBox2.Name = "uc_txtBox2";
            this.uc_txtBox2.Size = new System.Drawing.Size(406, 74);
            this.uc_txtBox2.TabIndex = 4;
            this.uc_txtBox2.textWithcomma = null;
            this.uc_txtBox2.textWithoutcomma = null;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(104, 202);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 202);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "انصراف";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // frmMatrialLocation_Grp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 237);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMatrialLocation_Grp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmMatrialLocation_Grp";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private ControlLibrary.uc_txtBox uc_txtBox2;
        private ControlLibrary.uc_txtBox uc_txtBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}