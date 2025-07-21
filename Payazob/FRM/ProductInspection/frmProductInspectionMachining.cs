using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL.Defect;

namespace Payazob.FRM.ProductInspection
{
    public partial class frmProductInspectionMachining : Form
    {
        public frmProductInspectionMachining()
        {
            InitializeComponent();

            BLL.csPieces pieces = new BLL.csPieces();
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام قطعه",
                DataSource = pieces.mPiecesDataTable(0x99),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "combobox_PiecesLine1_",
                Visible = true,
                DataPropertyName = "xPieces_",
                Width = 200,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام OP",
                DataSource = new BLL.ProductOperation.csProductOperation().ProductOperationOpName(-1),
                DisplayMember = "xOpName",
                ValueMember = "x_",
                Name = "cmb_xOP_",
                DataPropertyName = "xOP_",
                Visible = true,
                Width = 70,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column2);
            DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام شیفت",
                DataSource = new BLL.csShift().mShiftDataTable(),
                DisplayMember = "xShiftName",
                ValueMember = "x_",
                Name = "combobox_Shift_",
                DataPropertyName = "xShift_",
                Visible = true,
                Width = 50,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column3);
            DataGridViewComboBoxColumn column4 = new DataGridViewComboBoxColumn
            {
                HeaderText = "مورد ضایعات",
                DataSource = new csDefect().mDefectListMachining(-1),
                DisplayMember = "xDefectName",
                ValueMember = "x_",
                Name = "combobox_Defect_",
                DataPropertyName = "xDefectList_",
                Visible = true,
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView_D.Columns.Add(column4);

            DataGridViewComboBoxColumn column66 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نوع ضایعات",
                DataSource = new csDefect().mDefectListTypeMachining(),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "xDefectListType_",
               DataPropertyName = "xDefectListType_",
                Visible = true,
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView_D.Columns.Add(column66);


            DataGridViewComboBoxColumn column5 = new DataGridViewComboBoxColumn
            {
                HeaderText = "علت ضایعات",
                DataSource = new csDefect().mDefectListCauseMachining(-1),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "combobox_DefectListCauseMachining_",
                DataPropertyName = "xDefectListCauseMachining_",
                Visible = true,
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView_D.Columns.Add(column5);
            DataGridViewComboBoxColumn column6 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام اپراتور",
                DataSource = new BLL.Person.csPersonInfo().mPersonInfoBySec(0x9a),
                DisplayMember = "name",
                ValueMember = "x_",
                DataPropertyName = "xPerson_",
                Name = "cmb_xPerId_",
                Visible = true,
                DisplayIndex = 7,
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView_D.Columns.Add(column6);
            this.dt_I = new DAL.QualityControl.DataSet_PruductInspection.mProductInspectionMachiningDataTable();
            this.bindingSource1.DataSource = this.dt_I;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.dt_I.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            this.ShowDateDetails(-1);
            BLL.csCompony compony = new BLL.csCompony();
            DataGridViewComboBoxColumn column7 = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 5,
                HeaderText = "نام تامین کننده",
                DataSource = compony.SelectSupplier(),
                DisplayMember = "xComponyName",
                ValueMember = "x_",
                DataPropertyName = "xCompany_",
                Name = "cmb_Supplier",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
              //  DisplayIndex = 5
            };
            this.dataGridView_D.Columns.Add(column7);
            this.Generate();
            this.dataGridView1.Columns["Column1"].DisplayIndex = 6;
            this.uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            this.uc_DataGridViewBtn1.Ds = compony.SelectSupplier();
            this.uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            this.uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            this.uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xAddress", "xTel", "xFax", "xEmail", "xWebsite", "xSupplyManager", "xSupplyManagerTel", "xDirectorFactor", "xDirectorFactorTel" };
            this.formFunctionPointer += new functioncall(this.Replicate);
            this.uc_DataGridViewBtn1.userFunctionPointer = this.formFunctionPointer;

        }

        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                this.dataGridView_D["xCompany_", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
                this.dataGridView_D["cmb_Supplier", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }

        }
        private DAL.QualityControl.DataSet_PruductInspection.mProductInspectionMachiningDetailsDataTable dt_D;
        private DAL.QualityControl.DataSet_PruductInspection.mProductInspectionMachiningDataTable dt_I;
        private void Generate()
        {
            Payazob.CS.csDic dic = new Payazob.CS.csDic();
            foreach (DataColumn column in this.dt_I.Columns)
            {
                if (this.dataGridView1.Columns[column.ColumnName] != null)
                {
                    this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
                }
            }
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xSupplier_"].Visible = false;
            this.dataGridView1.Columns["xDate"].DisplayIndex = 0;
        }

        private void GenerateD()
        {
            Payazob.CS.csDic dic = new Payazob.CS.csDic();
            foreach (DataColumn column in this.dt_D.Columns)
            {
                if (this.dataGridView_D.Columns[column.ColumnName] != null)
                {
                    this.dataGridView_D.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
                }
            }
            this.dataGridView_D.Columns["x_"].Visible = false;
            this.dataGridView_D.Columns["xProductInspection_"].Visible = false;
            this.dataGridView_D.Columns["xCompany_"].HeaderText = "کد تامین کننده";

            //this.dataGridView_D.Columns["xDefectListType_"].DisplayIndex = 0;
            this.dataGridView_D.Columns["combobox_DefectListCauseMachining_"].DisplayIndex = 1;
           // this.dataGridView_D.Columns["xDefectNumberCause"].DisplayIndex = 2;

            this.dataGridView_D.Columns["combobox_Defect_"].DisplayIndex = 3;
            this.dataGridView_D.Columns["xDefectNumber"].DisplayIndex = 4;

            this.dataGridView_D.Columns["cmb_xPerId_"].DisplayIndex = 5;

 //           this.dataGridView_D.Columns["cmb_Supplier"].DisplayIndex = 6;
            this.dataGridView_D.Columns["xCompany_"].DisplayIndex = 7;
            

        }

 

        private void ShowDateDetails(int x_)
        {
            this.dt_D = new BLL.QualityControl.csProductInspectionMachining().mProductInspectionMachiningDetails(x_);
            this.bindingSource_D.DataSource = this.dt_D;
            this.dataGridView_D.DataSource = this.bindingSource_D;
            this.bindingNavigator_D.BindingSource = this.bindingSource_D;
            this.GenerateD();
        }


        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDate(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
        }
        private void ShowDate(string DateFrom, string DateTo)
        {
            this.dt_I = new BLL.QualityControl.csProductInspectionMachining().mProductInspectionMachining(DateFrom, DateTo);
            this.bindingSource1.DataSource = this.dt_I;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.dt_I.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((!row.IsNewRow && (row.Cells["combobox_PiecesLine1_"].Value != DBNull.Value)) && (row.Cells["combobox_PiecesLine1_"].Value != null))
                {
                    (row.Cells["cmb_xOP_"] as DataGridViewComboBoxCell).DataSource = 
                        new BLL.ProductOperation.csProductOperation().ProductOperationOpName((int?)row.Cells["combobox_PiecesLine1_"].Value);
                }
            }
            this.Generate();
            this.dataGridView_D.Enabled = true;
            foreach (DataGridViewRow row2 in dataGridView1.Rows)
            {
                if (!row2.IsNewRow)
                {
                    row2.Cells["cmb_xOP_"].ReadOnly = true;
                    row2.Cells["combobox_PiecesLine1_"].ReadOnly = true;
                }
            }
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            SaveDataDetails();
        }
        private void SaveData()
        {
            base.Validate();
            this.dataGridView1.EndEdit();
            BLL.QualityControl.csProductInspectionMachining machining = new BLL.QualityControl.csProductInspectionMachining();
            if (new Payazob.CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(machining.UdProductInspectionMachining(this.dt_I), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.bindingSource1.DataSource = this.dt_I;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.ShowDate(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
            this.dataGridView_D.Enabled = true;
        }

        private void SaveDataDetails()
        {
            base.Validate();
            this.dataGridView_D.EndEdit();
            BLL.QualityControl.csProductInspectionMachining machining = new BLL.QualityControl.csProductInspectionMachining();
            if (new Payazob.CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(machining.UdProductInspectionMachiningDetails(this.dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.bindingSource_D.DataSource = this.dt_D;
            this.dataGridView_D.DataSource = this.bindingSource_D;
            this.bindingNavigator_D.BindingSource = this.bindingSource_D;
            this.ShowDate(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.dataGridView_D.Enabled && (e.RowIndex > -1)) && ((this.dataGridView1["combobox_PiecesLine1_", e.RowIndex].Value != DBNull.Value) && (this.dataGridView1["cmb_xOP_", e.RowIndex].Value != DBNull.Value)))
            {
                this.ShowDateDetails((int)this.dataGridView1["x_", e.RowIndex].Value);
                //this.bindingSource_D.DataSource = this.dt_D;
                //this.dataGridView_D.DataSource = this.bindingSource_D;
                //this.bindingNavigator_D.BindingSource = this.bindingSource_D;
                //this.GenerateD();
                this.dt_D.xProductInspection_Column.DefaultValue = (int)this.dataGridView1["x_", e.RowIndex].Value;
                (this.dataGridView_D.Columns["combobox_Defect_"] as DataGridViewComboBoxColumn).DataSource = new csDefect().mDefectListMachining((int?)this.dataGridView1["combobox_PiecesLine1_", e.RowIndex].Value);

                (this.dataGridView_D.Columns["combobox_DefectListCauseMachining_"] as DataGridViewComboBoxColumn).DataSource =
                    new csDefect().mDefectListCauseMachining(-1);
              
                //(this.dataGridView_D.Columns["combobox_DefectCode_"] as DataGridViewComboBoxColumn).DataSource = new csDefect().mDefectListMachining((int?)this.dataGridView1["combobox_PiecesLine1_", e.RowIndex].Value, (int?)this.dataGridView1["cmb_xOP_", e.RowIndex].Value);

              
            }
            if (e.RowIndex != -1)
            {
                int columnIndex = e.ColumnIndex;
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "combobox_PiecesLine1_")
                {
                    this.dataGridView1["cmb_xOP_", e.RowIndex].Value = DBNull.Value;
                    if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                    {
                        (this.dataGridView1["cmb_xOP_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.ProductOperation.csProductOperation().ProductOperationOpName((int?)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                    }
                    else
                    {
                        (this.dataGridView1["cmb_xOP_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.ProductOperation.csProductOperation().ProductOperationOpName(-1);
                    }
                }
                this.dataGridView_D.Enabled = false;
                this.ShowDateDetails(-1);
            }

        }

        private void dataGridView_D_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView_D.Columns[e.ColumnIndex].Name == "xCompany_")
            {
                this.uc_DataGridViewBtn1.Visible = true;
                Rectangle rectangle = this.dataGridView_D.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                this.uc_DataGridViewBtn1.Location = new Point(rectangle.X, rectangle.Y);
                this.uc_DataGridViewBtn1.Size = new Size(20, this.dataGridView_D.Rows[e.RowIndex].Height);
                this.uc_DataGridViewBtn1.RI = e.RowIndex;
                this.uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }
            else
            {
                this.uc_DataGridViewBtn1.Visible = false;
            }

        }

        private void dataGridView_D_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                if (this.dataGridView_D.Columns[e.ColumnIndex].Name == "xDefectListType_" && this.dataGridView_D[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    this.dataGridView_D["combobox_DefectListCauseMachining_", e.RowIndex].Value = DBNull.Value;
                    if (this.dataGridView_D[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                    {
                        (this.dataGridView_D["combobox_DefectListCauseMachining_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = 
                            new csDefect().mDefectListCauseMachining((int?)this.dataGridView_D[e.ColumnIndex, e.RowIndex].Value);
                    }
                    else
                    {
                        (this.dataGridView_D["combobox_DefectListCauseMachining_", e.RowIndex] as DataGridViewComboBoxCell).DataSource =
                            new csDefect().mDefectListCauseMachining(-1);
                    }
                }
              //  this.dataGridView_D.Enabled = false;
                //this.ShowDateDetails(-1);
            }
        }
    }
}
