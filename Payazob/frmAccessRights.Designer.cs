namespace Payazob
{
    partial class frmAccessRights
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_show = new System.Windows.Forms.Button();
            this.rdb_User = new System.Windows.Forms.RadioButton();
            this.rdb_Group = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.uc_CmbAutoByFilter1 = new ControlLibrary.uc_CmbAutoByFilter();
            this.uc_txtBoxSearch = new ControlLibrary.uc_txtBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel1.Controls.Add(this.btn_show);
            this.splitContainer1.Panel1.Controls.Add(this.uc_CmbAutoByFilter1);
            this.splitContainer1.Panel1.Controls.Add(this.rdb_User);
            this.splitContainer1.Panel1.Controls.Add(this.rdb_Group);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(715, 471);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(23, 43);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "نمایش";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // rdb_User
            // 
            this.rdb_User.AutoSize = true;
            this.rdb_User.Checked = true;
            this.rdb_User.Location = new System.Drawing.Point(113, 13);
            this.rdb_User.Name = "rdb_User";
            this.rdb_User.Size = new System.Drawing.Size(45, 17);
            this.rdb_User.TabIndex = 3;
            this.rdb_User.TabStop = true;
            this.rdb_User.Text = "کاربر";
            this.rdb_User.UseVisualStyleBackColor = true;
            this.rdb_User.CheckedChanged += new System.EventHandler(this.rdb_User_CheckedChanged);
            // 
            // rdb_Group
            // 
            this.rdb_Group.AutoSize = true;
            this.rdb_Group.Location = new System.Drawing.Point(27, 13);
            this.rdb_Group.Name = "rdb_Group";
            this.rdb_Group.Size = new System.Drawing.Size(45, 17);
            this.rdb_Group.TabIndex = 2;
            this.rdb_Group.Text = "گروه";
            this.rdb_Group.UseVisualStyleBackColor = true;
            this.rdb_Group.CheckedChanged += new System.EventHandler(this.rdb_User_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_Save);
            this.splitContainer2.Panel2.Controls.Add(this.btn_Search);
            this.splitContainer2.Panel2.Controls.Add(this.uc_txtBoxSearch);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(715, 394);
            this.splitContainer2.SplitterDistance = 347;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(23, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(497, 11);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "جستجو";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // uc_CmbAutoByFilter1
            // 
            this.uc_CmbAutoByFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_CmbAutoByFilter1.Location = new System.Drawing.Point(561, 13);
            this.uc_CmbAutoByFilter1.Name = "uc_CmbAutoByFilter1";
            this.uc_CmbAutoByFilter1.Size = new System.Drawing.Size(142, 27);
            this.uc_CmbAutoByFilter1.TabIndex = 4;
            // 
            // uc_txtBoxSearch
            // 
            this.uc_txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uc_txtBoxSearch.BackColor = System.Drawing.Color.LightYellow;
            this.uc_txtBoxSearch.IsInteger = false;
            this.uc_txtBoxSearch.IsNumber = false;
            this.uc_txtBoxSearch.IsTime = false;
            this.uc_txtBoxSearch.Location = new System.Drawing.Point(578, 13);
            this.uc_txtBoxSearch.Name = "uc_txtBoxSearch";
            this.uc_txtBoxSearch.Size = new System.Drawing.Size(125, 21);
            this.uc_txtBoxSearch.TabIndex = 1;
            this.uc_txtBoxSearch.textWithcomma = null;
            this.uc_txtBoxSearch.textWithoutcomma = null;
            this.uc_txtBoxSearch.TextChanged += new System.EventHandler(this.uc_txtBoxSearch_TextChanged);
            // 
            // frmAccessRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 471);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccessRights";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "حقوق دسترسی";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rdb_User;
        private System.Windows.Forms.RadioButton rdb_Group;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_Search;
        private ControlLibrary.uc_txtBox uc_txtBoxSearch;
        private ControlLibrary.uc_CmbAutoByFilter uc_CmbAutoByFilter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_Save;
    }
}