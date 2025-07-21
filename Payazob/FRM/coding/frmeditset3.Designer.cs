namespace PAYAZOBNET.form
{
    partial class frmeditset3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmeditset3));
            this.payazobnetDataSet = new PAYADATA.payazobnetDataSet();
            this.mdeviceset3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mdeviceset3TableAdapter = new PAYADATA.payazobnetDataSetTableAdapters.mdeviceset3TableAdapter();
            this.tableAdapterManager = new PAYADATA.payazobnetDataSetTableAdapters.TableAdapterManager();
            this.mdeviceset3BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mdeviceset3BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mdeviceset3DataGridView = new System.Windows.Forms.DataGridView();
            this.xcodfinalset3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xparentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xismecanical = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xdetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtProNet1 = new TextBoxtest.TxtProNet();
            this.ustextbox2 = new TextBoxtest.TxtProNet();
            this.ustextbox1 = new TextBoxtest.TxtProNet();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_set1_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_device_no = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_set2_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_device_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.payazobnetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdeviceset3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdeviceset3BindingNavigator)).BeginInit();
            this.mdeviceset3BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdeviceset3DataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payazobnetDataSet
            // 
            this.payazobnetDataSet.DataSetName = "payazobnetDataSet";
            this.payazobnetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mdeviceset3BindingSource
            // 
            this.mdeviceset3BindingSource.DataMember = "mdeviceset3";
            this.mdeviceset3BindingSource.DataSource = this.payazobnetDataSet;
            // 
            // mdeviceset3TableAdapter
            // 
            this.mdeviceset3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deviceTableAdapter = null;
            this.tableAdapterManager.mallobjectTableAdapter = null;
            this.tableAdapterManager.mdetailsdeviceTableAdapter = null;
            this.tableAdapterManager.mdeviceset1TableAdapter = null;
            this.tableAdapterManager.mdeviceset2TableAdapter = null;
            this.tableAdapterManager.mdeviceset3TableAdapter = this.mdeviceset3TableAdapter;
            this.tableAdapterManager.mobjectcodTableAdapter = null;
            this.tableAdapterManager.objecttableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAYADATA.payazobnetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mdeviceset3BindingNavigator
            // 
            this.mdeviceset3BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mdeviceset3BindingNavigator.BindingSource = this.mdeviceset3BindingSource;
            this.mdeviceset3BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mdeviceset3BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mdeviceset3BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mdeviceset3BindingNavigatorSaveItem});
            this.mdeviceset3BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mdeviceset3BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mdeviceset3BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mdeviceset3BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mdeviceset3BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mdeviceset3BindingNavigator.Name = "mdeviceset3BindingNavigator";
            this.mdeviceset3BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mdeviceset3BindingNavigator.Size = new System.Drawing.Size(615, 25);
            this.mdeviceset3BindingNavigator.TabIndex = 0;
            this.mdeviceset3BindingNavigator.Text = "bindingNavigator1";
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
            // mdeviceset3BindingNavigatorSaveItem
            // 
            this.mdeviceset3BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mdeviceset3BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mdeviceset3BindingNavigatorSaveItem.Image")));
            this.mdeviceset3BindingNavigatorSaveItem.Name = "mdeviceset3BindingNavigatorSaveItem";
            this.mdeviceset3BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mdeviceset3BindingNavigatorSaveItem.Text = "Save Data";
            this.mdeviceset3BindingNavigatorSaveItem.Click += new System.EventHandler(this.mdeviceset3BindingNavigatorSaveItem_Click);
            // 
            // mdeviceset3DataGridView
            // 
            this.mdeviceset3DataGridView.AllowUserToAddRows = false;
            this.mdeviceset3DataGridView.AllowUserToDeleteRows = false;
            this.mdeviceset3DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
           | System.Windows.Forms.AnchorStyles.Left)
           | System.Windows.Forms.AnchorStyles.Right)));
            this.mdeviceset3DataGridView.AutoGenerateColumns = false;
            this.mdeviceset3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdeviceset3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xcodfinalset3,
            this.dataGridViewTextBoxColumn2,
            this.xparentid,
            this.xid,
            this.xismecanical,
            this.xdetails});
            this.mdeviceset3DataGridView.DataSource = this.mdeviceset3BindingSource;
            this.mdeviceset3DataGridView.Location = new System.Drawing.Point(12, 237);
            this.mdeviceset3DataGridView.Name = "mdeviceset3DataGridView";
            this.mdeviceset3DataGridView.Size = new System.Drawing.Size(591, 162);
            this.mdeviceset3DataGridView.TabIndex = 3;
            // 
            // xcodfinalset3
            // 
            this.xcodfinalset3.DataPropertyName = "xcodfinalset3";
            this.xcodfinalset3.HeaderText = "کد این مجموعه";
            this.xcodfinalset3.Name = "xcodfinalset3";
            this.xcodfinalset3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xnameset3";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام مجموعه فرعی دوم";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // xparentid
            // 
            this.xparentid.DataPropertyName = "xparentid";
            this.xparentid.HeaderText = "xparentid";
            this.xparentid.Name = "xparentid";
            this.xparentid.Visible = false;
            // 
            // xid
            // 
            this.xid.DataPropertyName = "xid";
            this.xid.HeaderText = "xid";
            this.xid.Name = "xid";
            this.xid.Visible = false;
            // 
            // xismecanical
            // 
            this.xismecanical.DataPropertyName = "xismecanical";
            this.xismecanical.HeaderText = "مکانیکی است؟";
            this.xismecanical.Name = "xismecanical";
            // 
            // xdetails
            // 
            this.xdetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xdetails.DataPropertyName = "xdetails";
            this.xdetails.HeaderText = "جزئیات";
            this.xdetails.Name = "xdetails";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(10, 194);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(145, 28);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "ذخیره قطعه جدید";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.txtProNet1);
            this.groupBox3.Controls.Add(this.ustextbox2);
            this.groupBox3.Controls.Add(this.ustextbox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(0, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(299, 160);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مجموعه فرعی 2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(148, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "این مجموعه مکانیکی است";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtProNet1
            // 
            this.txtProNet1.AutoSprator = false;
            this.txtProNet1.EnterToTab = true;
            this.txtProNet1.EscToClose = true;
            this.txtProNet1.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet1.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtProNet1.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet1.FocusTextSelect = true;
            this.txtProNet1.Location = new System.Drawing.Point(12, 87);
            this.txtProNet1.MessageEmptyShowDialog = false;
            this.txtProNet1.MessegeEmpty = "";
            this.txtProNet1.MessegeEmptyInFormRight = true;
            this.txtProNet1.MessegeEmptyShowInForm = false;
            this.txtProNet1.Multiline = true;
            this.txtProNet1.Name = "txtProNet1";
            this.txtProNet1.Size = new System.Drawing.Size(192, 46);
            this.txtProNet1.TabIndex = 2;
            this.txtProNet1.TypeAllChar = true;
            this.txtProNet1.TypeDateShamsi = false;
            this.txtProNet1.TypeEnglishOnly = false;
            this.txtProNet1.TypeFarsiOnly = false;
            this.txtProNet1.TypeNumricOnly = false;
            this.txtProNet1.TypeOtherChar = "";
            // 
            // ustextbox2
            // 
            this.ustextbox2.AutoSprator = false;
            this.ustextbox2.BackColor = System.Drawing.Color.White;
            this.ustextbox2.EnterToTab = true;
            this.ustextbox2.EscToClose = true;
            this.ustextbox2.FocusBackColor = System.Drawing.Color.Yellow;
            this.ustextbox2.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ustextbox2.FocusForeColor = System.Drawing.Color.Blue;
            this.ustextbox2.FocusTextSelect = true;
            this.ustextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ustextbox2.ForeColor = System.Drawing.Color.Blue;
            this.ustextbox2.Location = new System.Drawing.Point(12, 63);
            this.ustextbox2.MaxLength = 2;
            this.ustextbox2.MessageEmptyShowDialog = false;
            this.ustextbox2.MessegeEmpty = "";
            this.ustextbox2.MessegeEmptyInFormRight = true;
            this.ustextbox2.MessegeEmptyShowInForm = false;
            this.ustextbox2.Name = "ustextbox2";
            this.ustextbox2.Size = new System.Drawing.Size(192, 20);
            this.ustextbox2.TabIndex = 1;
            this.ustextbox2.TypeAllChar = false;
            this.ustextbox2.TypeDateShamsi = false;
            this.ustextbox2.TypeEnglishOnly = false;
            this.ustextbox2.TypeFarsiOnly = false;
            this.ustextbox2.TypeNumricOnly = true;
            this.ustextbox2.TypeOtherChar = "";
            // 
            // ustextbox1
            // 
            this.ustextbox1.AutoSprator = false;
            this.ustextbox1.EnterToTab = true;
            this.ustextbox1.EscToClose = true;
            this.ustextbox1.FocusBackColor = System.Drawing.Color.Yellow;
            this.ustextbox1.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ustextbox1.FocusForeColor = System.Drawing.Color.Blue;
            this.ustextbox1.FocusTextSelect = true;
            this.ustextbox1.Location = new System.Drawing.Point(12, 24);
            this.ustextbox1.MessageEmptyShowDialog = false;
            this.ustextbox1.MessegeEmpty = "";
            this.ustextbox1.MessegeEmptyInFormRight = true;
            this.ustextbox1.MessegeEmptyShowInForm = false;
            this.ustextbox1.Name = "ustextbox1";
            this.ustextbox1.Size = new System.Drawing.Size(192, 21);
            this.ustextbox1.TabIndex = 0;
            this.ustextbox1.TypeAllChar = true;
            this.ustextbox1.TypeDateShamsi = false;
            this.ustextbox1.TypeEnglishOnly = false;
            this.ustextbox1.TypeFarsiOnly = false;
            this.ustextbox1.TypeNumricOnly = false;
            this.ustextbox1.TypeOtherChar = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "نام مجموعه فرعی";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "جزئیات مجموعه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "کد مجموعه فرعی";
            // 
            // combo_set1_name
            // 
            this.combo_set1_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_set1_name.FormattingEnabled = true;
            this.combo_set1_name.Location = new System.Drawing.Point(34, 87);
            this.combo_set1_name.Name = "combo_set1_name";
            this.combo_set1_name.Size = new System.Drawing.Size(121, 21);
            this.combo_set1_name.TabIndex = 2;
            this.combo_set1_name.SelectedIndexChanged += new System.EventHandler(this.combo_set1_name_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام مجموعه اصلی";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_device_no);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combo_set2_name);
            this.groupBox1.Controls.Add(this.combo_set1_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combo_device_name);
            this.groupBox1.Location = new System.Drawing.Point(305, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(310, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات دستگاه";
            // 
            // combo_device_no
            // 
            this.combo_device_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_device_no.FormattingEnabled = true;
            this.combo_device_no.Location = new System.Drawing.Point(34, 58);
            this.combo_device_no.Name = "combo_device_no";
            this.combo_device_no.Size = new System.Drawing.Size(121, 21);
            this.combo_device_no.TabIndex = 1;
            this.combo_device_no.SelectedIndexChanged += new System.EventHandler(this.combo_device_no_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره دستگاه";
            // 
            // combo_set2_name
            // 
            this.combo_set2_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_set2_name.FormattingEnabled = true;
            this.combo_set2_name.Location = new System.Drawing.Point(34, 125);
            this.combo_set2_name.MaxDropDownItems = 12;
            this.combo_set2_name.Name = "combo_set2_name";
            this.combo_set2_name.Size = new System.Drawing.Size(121, 21);
            this.combo_set2_name.TabIndex = 3;
            this.combo_set2_name.SelectedIndexChanged += new System.EventHandler(this.combo_set2_name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام دستگاه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام مجموعه فرعی";
            // 
            // combo_device_name
            // 
            this.combo_device_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_device_name.FormattingEnabled = true;
            this.combo_device_name.Location = new System.Drawing.Point(34, 24);
            this.combo_device_name.Name = "combo_device_name";
            this.combo_device_name.Size = new System.Drawing.Size(121, 21);
            this.combo_device_name.TabIndex = 0;
            this.combo_device_name.SelectedIndexChanged += new System.EventHandler(this.combo_device_name_SelectedIndexChanged);
            // 
            // frmeditset3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 411);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mdeviceset3DataGridView);
            this.Controls.Add(this.mdeviceset3BindingNavigator);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmeditset3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ویرایش مجموعه فرعی دوم";
            this.Load += new System.EventHandler(this.frmeditset3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payazobnetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdeviceset3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdeviceset3BindingNavigator)).EndInit();
            this.mdeviceset3BindingNavigator.ResumeLayout(false);
            this.mdeviceset3BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdeviceset3DataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PAYADATA.payazobnetDataSet payazobnetDataSet;
        private System.Windows.Forms.BindingSource mdeviceset3BindingSource;
        private PAYADATA.payazobnetDataSetTableAdapters.mdeviceset3TableAdapter mdeviceset3TableAdapter;
        private PAYADATA.payazobnetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mdeviceset3BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mdeviceset3BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mdeviceset3DataGridView;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox3;
        private TextBoxtest.TxtProNet ustextbox2;
        private TextBoxtest.TxtProNet ustextbox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox combo_set1_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combo_device_name;
        private System.Windows.Forms.ComboBox combo_set2_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox combo_device_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcodfinalset3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xparentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xismecanical;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdetails;
        private System.Windows.Forms.CheckBox checkBox1;
        private TextBoxtest.TxtProNet txtProNet1;
        private System.Windows.Forms.Label label7;
    }
}