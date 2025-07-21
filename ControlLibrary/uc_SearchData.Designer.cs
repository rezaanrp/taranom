namespace ControlLibrary
{
    partial class uc_SearchData
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
            this.components = new System.ComponentModel.Container();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.uc_txtBox_Filter = new ControlLibrary.uc_txtBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::ControlLibrary.Properties.Resources.delete;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.Location = new System.Drawing.Point(6, 181);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(40, 35);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(508, 169);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ControlLibrary.Properties.Resources.reload;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(265, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = global::ControlLibrary.Properties.Resources.check;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ok.Location = new System.Drawing.Point(52, 181);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(40, 35);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.BackgroundImage = global::ControlLibrary.Properties.Resources.filter;
            this.btn_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_filter.Location = new System.Drawing.Point(308, 180);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(37, 35);
            this.btn_filter.TabIndex = 1;
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // uc_txtBox_Filter
            // 
            this.uc_txtBox_Filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uc_txtBox_Filter.IsInteger = false;
            this.uc_txtBox_Filter.IsNumber = false;
            this.uc_txtBox_Filter.IsTime = false;
            this.uc_txtBox_Filter.Location = new System.Drawing.Point(357, 188);
            this.uc_txtBox_Filter.Name = "uc_txtBox_Filter";
            this.uc_txtBox_Filter.Size = new System.Drawing.Size(154, 21);
            this.uc_txtBox_Filter.TabIndex = 0;
            this.uc_txtBox_Filter.textWithcomma = null;
            this.uc_txtBox_Filter.textWithoutcomma = null;
            this.uc_txtBox_Filter.TextChanged += new System.EventHandler(this.uc_txtBox_Filter_TextChanged);
            // 
            // uc_SearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uc_txtBox_Filter);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "uc_SearchData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(519, 220);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private uc_txtBox uc_txtBox_Filter;
        private System.Windows.Forms.Button button1;
    }
}
