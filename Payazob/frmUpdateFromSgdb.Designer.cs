namespace Payazob
{
    partial class frmUpdateFromSgdb
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.chb_Pieces = new System.Windows.Forms.CheckBox();
            this.chb_melt = new System.Windows.Forms.CheckBox();
            this.chb_Customer = new System.Windows.Forms.CheckBox();
            this.chb_Supplier = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_Supplier);
            this.groupBox2.Controls.Add(this.chb_Customer);
            this.groupBox2.Controls.Add(this.chb_melt);
            this.groupBox2.Controls.Add(this.chb_Pieces);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بروز رسانی";
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::TARANOM.Properties.Resources.software_update;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(6, 117);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(60, 53);
            this.btn_update.TabIndex = 1;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // chb_Pieces
            // 
            this.chb_Pieces.AutoSize = true;
            this.chb_Pieces.Location = new System.Drawing.Point(363, 28);
            this.chb_Pieces.Name = "chb_Pieces";
            this.chb_Pieces.Size = new System.Drawing.Size(69, 17);
            this.chb_Pieces.TabIndex = 2;
            this.chb_Pieces.Text = "محصولات";
            this.chb_Pieces.UseVisualStyleBackColor = true;
            // 
            // chb_melt
            // 
            this.chb_melt.AutoSize = true;
            this.chb_melt.Location = new System.Drawing.Point(363, 51);
            this.chb_melt.Name = "chb_melt";
            this.chb_melt.Size = new System.Drawing.Size(69, 17);
            this.chb_melt.TabIndex = 3;
            this.chb_melt.Text = "مواد اولیه";
            this.chb_melt.UseVisualStyleBackColor = true;
            // 
            // chb_Customer
            // 
            this.chb_Customer.AutoSize = true;
            this.chb_Customer.Location = new System.Drawing.Point(368, 74);
            this.chb_Customer.Name = "chb_Customer";
            this.chb_Customer.Size = new System.Drawing.Size(63, 17);
            this.chb_Customer.TabIndex = 4;
            this.chb_Customer.Text = "مشتری";
            this.chb_Customer.UseVisualStyleBackColor = true;
            // 
            // chb_Supplier
            // 
            this.chb_Supplier.AutoSize = true;
            this.chb_Supplier.Location = new System.Drawing.Point(354, 97);
            this.chb_Supplier.Name = "chb_Supplier";
            this.chb_Supplier.Size = new System.Drawing.Size(77, 17);
            this.chb_Supplier.TabIndex = 5;
            this.chb_Supplier.Text = "تامین کننده";
            this.chb_Supplier.UseVisualStyleBackColor = true;
            // 
            // frmUpdateFromSgdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 212);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmUpdateFromSgdb";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.CheckBox chb_Supplier;
        private System.Windows.Forms.CheckBox chb_Customer;
        private System.Windows.Forms.CheckBox chb_melt;
        private System.Windows.Forms.CheckBox chb_Pieces;
    }
}