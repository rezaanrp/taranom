namespace PAYAZOBNET.form.coding
{
    partial class frm_gridviewdevice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xnamedevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.xnamedevice,
            this.xnumber});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(28, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewX1.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.Default;
            this.dataGridViewX1.Size = new System.Drawing.Size(229, 391);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // select
            // 
            this.select.FillWeight = 20F;
            this.select.HeaderText = "انتخاب";
            this.select.Name = "select";
            this.select.TrueValue = "1";
            this.select.Width = 50;
            // 
            // xnamedevice
            // 
            this.xnamedevice.DataPropertyName = "xnamedevice";
            this.xnamedevice.FillWeight = 80F;
            this.xnamedevice.HeaderText = " نام دستگاه";
            this.xnamedevice.Name = "xnamedevice";
            this.xnamedevice.Width = 80;
            // 
            // xnumber
            // 
            this.xnumber.DataPropertyName = "xnumber";
            this.xnumber.FillWeight = 50F;
            this.xnumber.HeaderText = "شماره دستگاه";
            this.xnumber.Name = "xnumber";
            this.xnumber.Width = 50;
            // 
            // cancel
            // 
            this.cancel.Image = global::PAYAZOBNET.Properties.Resources.closebtn;
            this.cancel.Location = new System.Drawing.Point(154, 409);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 48);
            this.cancel.TabIndex = 2;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btnok
            // 
            this.btnok.Image = global::PAYAZOBNET.Properties.Resources._7171;
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnok.Location = new System.Drawing.Point(53, 409);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 48);
            this.btnok.TabIndex = 1;
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frm_gridviewdevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(282, 467);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.dataGridViewX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_gridviewdevice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_gridviewdevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private  DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnamedevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnumber;


    }
}