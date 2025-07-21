namespace PAYAZOBNET.form
{
    partial class frmedit_cod_objects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmedit_cod_objects));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.payazobnetDataSet = new PAYADATA.payazobnetDataSet();
            this.mobjectcodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobjectcodTableAdapter = new PAYADATA.payazobnetDataSetTableAdapters.mobjectcodTableAdapter();
            this.tableAdapterManager = new PAYADATA.payazobnetDataSetTableAdapters.TableAdapterManager();
            this.mobjectcodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mobjectcodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mobjectcodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ustextbox2 = new System.Windows.Forms.TextBox();
            this.ustextbox1 = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.payazobnetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobjectcodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobjectcodBindingNavigator)).BeginInit();
            this.mobjectcodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobjectcodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "E",
            "M"});
            this.comboBox2.Location = new System.Drawing.Point(202, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "عدد",
            "دستگاه",
            "حلقه",
            "متر",
            "بسته",
            "کیلوگرم",
            "گرم",
            "جعبه",
            "دست",
            "جفت",
            "ست",
            "مترمربع",
            "لیتر",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(202, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "نوع قطعه- الکترونیکی- مکانیکی";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "واحد شمارش";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "نام قطعه";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "کد قطعه";
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(202, 123);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(121, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "ذخیره";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "نام انگلیسی قطعه";
            // 
            // payazobnetDataSet
            // 
            this.payazobnetDataSet.DataSetName = "payazobnetDataSet";
            this.payazobnetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mobjectcodBindingSource
            // 
            this.mobjectcodBindingSource.DataMember = "mobjectcod";
            this.mobjectcodBindingSource.DataSource = this.payazobnetDataSet;
            // 
            // mobjectcodTableAdapter
            // 
            this.mobjectcodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deviceTableAdapter = null;
            this.tableAdapterManager.mallobjectTableAdapter = null;
            this.tableAdapterManager.mdetailsdeviceTableAdapter = null;
            this.tableAdapterManager.mdeviceset1TableAdapter = null;
            this.tableAdapterManager.mdeviceset2TableAdapter = null;
            this.tableAdapterManager.mdeviceset3TableAdapter = null;
            this.tableAdapterManager.mobjectcodTableAdapter = this.mobjectcodTableAdapter;
            this.tableAdapterManager.objecttableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAYADATA.payazobnetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mobjectcodBindingNavigator
            // 
            this.mobjectcodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mobjectcodBindingNavigator.BindingSource = this.mobjectcodBindingSource;
            this.mobjectcodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mobjectcodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mobjectcodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mobjectcodBindingNavigatorSaveItem});
            this.mobjectcodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mobjectcodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mobjectcodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mobjectcodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mobjectcodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mobjectcodBindingNavigator.Name = "mobjectcodBindingNavigator";
            this.mobjectcodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mobjectcodBindingNavigator.Size = new System.Drawing.Size(771, 25);
            this.mobjectcodBindingNavigator.TabIndex = 25;
            this.mobjectcodBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mobjectcodBindingNavigatorSaveItem
            // 
            this.mobjectcodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mobjectcodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mobjectcodBindingNavigatorSaveItem.Image")));
            this.mobjectcodBindingNavigatorSaveItem.Name = "mobjectcodBindingNavigatorSaveItem";
            this.mobjectcodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mobjectcodBindingNavigatorSaveItem.Text = "Save Data";
            this.mobjectcodBindingNavigatorSaveItem.Click += new System.EventHandler(this.mobjectcodBindingNavigatorSaveItem_Click_1);
            // 
            // mobjectcodDataGridView
            // 
            this.mobjectcodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
           | System.Windows.Forms.AnchorStyles.Left)
           | System.Windows.Forms.AnchorStyles.Right)));
            this.mobjectcodDataGridView.AutoGenerateColumns = false;
            this.mobjectcodDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.mobjectcodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mobjectcodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.mobjectcodDataGridView.DataSource = this.mobjectcodBindingSource;
            this.mobjectcodDataGridView.Location = new System.Drawing.Point(12, 170);
            this.mobjectcodDataGridView.Name = "mobjectcodDataGridView";
            this.mobjectcodDataGridView.RowTemplate.Height = 24;
            this.mobjectcodDataGridView.Size = new System.Drawing.Size(747, 251);
            this.mobjectcodDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "xname";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "نام قطعه";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xcod";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "کد قطعه";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "knid";
            this.dataGridViewTextBoxColumn3.HeaderText = "نوع قطعه";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "xcodfinal";
            this.dataGridViewTextBoxColumn4.HeaderText = "کد نهایی قطعه";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "xvahed";
            this.dataGridViewTextBoxColumn5.HeaderText = "واحد شمارش";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "عدد",
            "دستگاه",
            "حلقه",
            "متر",
            "بسته",
            "کیلوگرم",
            "گرم",
            "جعبه",
            "دست",
            "جفت",
            "ست",
            "مترمربع",
            "لیتر"});
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "xname_English";
            this.dataGridViewTextBoxColumn6.HeaderText = "نام انگلیسی";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ustextbox2
            // 
            this.ustextbox2.Location = new System.Drawing.Point(558, 32);
            this.ustextbox2.Name = "ustextbox2";
            this.ustextbox2.Size = new System.Drawing.Size(100, 21);
            this.ustextbox2.TabIndex = 26;
            // 
            // ustextbox1
            // 
            this.ustextbox1.Location = new System.Drawing.Point(558, 73);
            this.ustextbox1.Name = "ustextbox1";
            this.ustextbox1.Size = new System.Drawing.Size(100, 21);
            this.ustextbox1.TabIndex = 26;
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(558, 110);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(100, 21);
            this.txteng.TabIndex = 26;
            // 
            // frmedit_cod_objects
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(771, 423);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.ustextbox1);
            this.Controls.Add(this.ustextbox2);
            this.Controls.Add(this.mobjectcodDataGridView);
            this.Controls.Add(this.mobjectcodBindingNavigator);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmedit_cod_objects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اختصاص کد های سه رقمی به قطعات";
            this.Load += new System.EventHandler(this.frmedit_cod_objects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payazobnetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobjectcodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobjectcodBindingNavigator)).EndInit();
            this.mobjectcodBindingNavigator.ResumeLayout(false);
            this.mobjectcodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobjectcodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private PAYADATA.payazobnetDataSet payazobnetDataSet;
        private System.Windows.Forms.BindingSource mobjectcodBindingSource;
        private PAYADATA.payazobnetDataSetTableAdapters.mobjectcodTableAdapter mobjectcodTableAdapter;
        private PAYADATA.payazobnetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mobjectcodBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mobjectcodBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mobjectcodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox ustextbox2;
        private System.Windows.Forms.TextBox ustextbox1;
        private System.Windows.Forms.TextBox txteng;
    }
}