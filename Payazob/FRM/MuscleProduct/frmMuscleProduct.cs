using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.MuscleProduct
{
    public partial class frmMuscleProduct : Form
    {
        public frmMuscleProduct()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("SHI"),
                DisplayMember = "xName",
                HeaderText = "شیفت",
                ValueMember = "x_",
                DataPropertyName = "xShift_",
                Name = "cmb_Type",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_Type_);

            DataGridViewComboBoxColumn combobox_Muscle_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "نام ماهیچه",
                DataSource = new BLL.MuscleProduct.csMuscleProduct().SlMuscleByMachine_(-1),
                DisplayMember = "xMuscleName",
                ValueMember = "x_",
                Name = "combobox_Muscle_",
                DataPropertyName = "xPieces_",
                Visible = true,
                MaxDropDownItems = 30,
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_Muscle_);

            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام دستگاه",
                DataSource = new BLL.Machine.csMachine().mMachine((int)CS.csEnum.Factory.Site2),
                DisplayMember = "CodeName",
                ValueMember = "x_",
                Name = "MachineName",
                Visible = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };
            this.dataGridView1.Columns.Add(column2);

            //------------------------------------

            uc_DataGridViewBtn1.ColumnsFilter_ = "Name";
            uc_DataGridViewBtn1.Ds = new BLL.Person.csPersonInfo().mPersonInfoBySec(76);
            uc_DataGridViewBtn1.ParamName = new string[] { "Name" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام پرسنل" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_" };
            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;

            //-----------------------------------


            dt_M = new DAL.MuscleProduct.DataSet_MuscleProduct.SlMuscleProductDataTable();
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            DataGridViewComboBoxColumn combobox_Person = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.Person.csPersonInfo().mPersonInfoBySec(76),
                DisplayMember = "Name",
                HeaderText = "نام اپراتور دستگاه",
                ValueMember = "x_",
                DataPropertyName = "xOperatorName_",
                Name = "PI_Name",
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_Person);
            dataGridView1.Columns["xOperatorName_"].ReadOnly = true;

            Genration();

        }

        //------------------------------------------------------------------
        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;
        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xOperatorName_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }

        }

        //------------------------------------------------------------------

        DAL.MuscleProduct.DataSet_MuscleProduct.SlMuscleProductDataTable dt_M;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();
            dt_M = cs.SlMuscleProduct(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }
        void Genration()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_M.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["xDate"].DisplayIndex = 0;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xOperatorName_"].HeaderText = "شماره اپراتور دستگاه";
        }

        void SaveData()
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(cs.UdMuscleProduct(dt_M), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dt_M = cs.SlMuscleProduct(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Genration();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            SaveData();

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xOperatorName_")
            {
                uc_DataGridViewBtn1.Visible = true;
                var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y);
                uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                uc_DataGridViewBtn1.RI = e.RowIndex;
                uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }

            else
                uc_DataGridViewBtn1.Visible = false;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    fr.StartPosition = FormStartPosition.CenterParent;
                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridView1.Columns[e.ColumnIndex].Name == "MachineName"))
            {
                this.dataGridView1["combobox_Muscle_", e.RowIndex].Value = DBNull.Value;
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    (this.dataGridView1["combobox_Muscle_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.MuscleProduct.csMuscleProduct().SlMuscleByMachine_((int)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                }
                else
                {
                    (this.dataGridView1["combobox_Muscle_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.MuscleProduct.csMuscleProduct().SlMuscleByMachine_(-1);
                }
            }
        }
    }
}
