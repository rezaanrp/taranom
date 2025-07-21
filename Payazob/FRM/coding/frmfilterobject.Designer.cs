namespace PAYAZOBNET.form
{
    partial class frmfilterobject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new DevComponents.DotNetBar.ButtonX();
            this.cancel = new DevComponents.DotNetBar.ButtonX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xname,
            this.xdetails});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(811, 397);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // xname
            // 
            this.xname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xname.DataPropertyName = "xname";
            this.xname.HeaderText = "نام قطعه";
            this.xname.Name = "xname";
            this.xname.ReadOnly = true;
            this.xname.Width = 72;
            // 
            // xdetails
            // 
            this.xdetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xdetails.DataPropertyName = "xdetails";
            this.xdetails.HeaderText = "جزئیات";
            this.xdetails.Name = "xdetails";
            this.xdetails.ReadOnly = true;
            // 
            // select
            // 
            this.select.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.select.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.select.Image = global::PAYAZOBNET.Properties.Resources._1261;
            this.select.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.select.Location = new System.Drawing.Point(744, 459);
            this.select.Name = "select";
            this.select.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.select.Size = new System.Drawing.Size(44, 38);
            this.select.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.select.TabIndex = 1;
            this.select.Tooltip = "انتخاب قطعه مورد نظر";
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // cancel
            // 
            this.cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancel.Image = global::PAYAZOBNET.Properties.Resources._4159;
            this.cancel.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.cancel.Location = new System.Drawing.Point(673, 459);
            this.cancel.Name = "cancel";
            this.cancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.cancel.Size = new System.Drawing.Size(42, 38);
            this.cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancel.TabIndex = 2;
            this.cancel.Tooltip = "انصراف";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(576, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "فیلتر براساس نام";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // frmfilterobject
            // 
            this.AcceptButton = this.select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmfilterobject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "انتخاب قطعه";
            this.Load += new System.EventHandler(this.frmfilterobject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX cancel;
        private DevComponents.DotNetBar.ButtonX select;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xname;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdetails;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}