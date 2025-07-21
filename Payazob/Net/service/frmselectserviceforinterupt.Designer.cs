namespace PAYAZOBNET.form.service
{
    partial class frmselectserviceforinterupt
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdevicecod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnamedevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdevicenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtimestart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtimeend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCselectyearandmonth1 = new ControlLibrary.UCselectyearandmonth();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(312, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "انصراف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(231, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "تایید";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(39, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "نمایش";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xid,
            this.xdevicecod,
            this.xnamedevice,
            this.xdevicenumber,
            this.xdate,
            this.xtimestart,
            this.xtimeend});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(28, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(566, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "xid";
            this.dataGridViewTextBoxColumn1.HeaderText = "xid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xdevicecod";
            this.dataGridViewTextBoxColumn2.HeaderText = "xdevicecod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "xnamedevice";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام دستگاه";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "xdevicenumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "شماره";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "xdate";
            this.dataGridViewTextBoxColumn5.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "xtimestart";
            this.dataGridViewTextBoxColumn6.HeaderText = "زمان آغاز";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "xtimeend";
            this.dataGridViewTextBoxColumn7.HeaderText = "زمان پایان";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // xid
            // 
            this.xid.DataPropertyName = "xid";
            this.xid.HeaderText = "xid";
            this.xid.Name = "xid";
            this.xid.ReadOnly = true;
            this.xid.Visible = false;
            // 
            // xdevicecod
            // 
            this.xdevicecod.DataPropertyName = "xdevicecod";
            this.xdevicecod.HeaderText = "xdevicecod";
            this.xdevicecod.Name = "xdevicecod";
            this.xdevicecod.ReadOnly = true;
            this.xdevicecod.Visible = false;
            // 
            // xnamedevice
            // 
            this.xnamedevice.DataPropertyName = "xnamedevice";
            this.xnamedevice.HeaderText = "نام دستگاه";
            this.xnamedevice.Name = "xnamedevice";
            this.xnamedevice.ReadOnly = true;
            // 
            // xdevicenumber
            // 
            this.xdevicenumber.DataPropertyName = "xdevicenumber";
            this.xdevicenumber.HeaderText = "شماره";
            this.xdevicenumber.Name = "xdevicenumber";
            this.xdevicenumber.ReadOnly = true;
            // 
            // xdate
            // 
            this.xdate.DataPropertyName = "xdate";
            this.xdate.HeaderText = "تاریخ";
            this.xdate.Name = "xdate";
            this.xdate.ReadOnly = true;
            // 
            // xtimestart
            // 
            this.xtimestart.DataPropertyName = "xtimestart";
            this.xtimestart.HeaderText = "زمان آغاز";
            this.xtimestart.Name = "xtimestart";
            this.xtimestart.ReadOnly = true;
            // 
            // xtimeend
            // 
            this.xtimeend.DataPropertyName = "xtimeend";
            this.xtimeend.HeaderText = "زمان پایان";
            this.xtimeend.Name = "xtimeend";
            this.xtimeend.ReadOnly = true;
            // 
            // uCselectyearandmonth1
            // 
            this.uCselectyearandmonth1.BackColor = System.Drawing.Color.Transparent;
            this.uCselectyearandmonth1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uCselectyearandmonth1.fillinformation = true;
            this.uCselectyearandmonth1.Location = new System.Drawing.Point(312, 17);
            this.uCselectyearandmonth1.month = 2;
            this.uCselectyearandmonth1.Name = "uCselectyearandmonth1";
            this.uCselectyearandmonth1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uCselectyearandmonth1.selecteddate = "1394/02";
            this.uCselectyearandmonth1.Size = new System.Drawing.Size(280, 44);
            this.uCselectyearandmonth1.TabIndex = 0;
            this.uCselectyearandmonth1.textforview = "";
            this.uCselectyearandmonth1.year = 1394;
            // 
            // frmselectserviceforinterupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uCselectyearandmonth1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmselectserviceforinterupt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmselectserviceforinterupt";
            this.Load += new System.EventHandler(this.frmselectserviceforinterupt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.UCselectyearandmonth uCselectyearandmonth1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn xid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdevicecod;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnamedevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdevicenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtimestart;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtimeend;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}