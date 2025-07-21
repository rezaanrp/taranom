using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL.CustomerReturn;

namespace Payazob.FRM.CustomerReturn
{
    public partial class frmCustomerReturnTurning : Form
    {
        public frmCustomerReturnTurning()
        {
            InitializeComponent();

            BLL.csMaterial material = new BLL.csMaterial();
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
   DisplayIndex = 3,
   HeaderText = "نوع مواد",
   DataSource = material.SelectMeltName(160, -1, false),
   DisplayMember = "xMaterialName",
   ValueMember = "x_",
   DataPropertyName = "xMaterial_",
   Name = "xMaterial_",
   Width = 150,
   DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);

            dt_R = new DAL.CustomerReturn.DataSet_CustomerReturnTurning.mCustomerReturnTurningDataTable(); ;
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            Generate();

            BLL.csCompony compony = new BLL.csCompony();
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
   DisplayIndex = 4,
   HeaderText = "نام شرکت",
   DataSource = compony.SelectSupplier(),
   DisplayMember = "xComponyName",
   ValueMember = "x_",
   DataPropertyName = "xCompany_",
   Name = "cmb_Supplier",
   DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            this.dataGridView1.Columns.Add(column2);
            this.Generate();
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
   this.dataGridView1["xCompany_", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
   this.dataGridView1["cmb_Supplier", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }

        }
        DAL.CustomerReturn.DataSet_CustomerReturnTurning.mCustomerReturnTurningDataTable dt_R;

        void Generate()
        {
            CS.csDic dic = new CS.csDic();
            foreach (DataColumn column in this.dt_R.Columns)
            {
   this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
            }
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
           // dataGridView1.Columns["cmb_Supplier"].DisplayIndex = 4;
            dataGridView1.Columns["xComment"].Width = 300;
            dataGridView1.Columns["xCompany_"].DisplayIndex = 5;
            dataGridView1.Columns["xCompany_"].HeaderText = "کد شرکت";

        }

        void ShowDataGridView()
        {

            dt_R = new csCustomerReturnTurning().CustomerReturnTurning(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            Generate();
        }

        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   this.Validate();
   dataGridView1.EndEdit();
   BLL.RequestItService.csRequestItService cs = new BLL.RequestItService.csRequestItService();


   MessageBox.Show(new csCustomerReturnTurning().UdCustomerReturnTurning(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
   ShowDataGridView();
   Generate();

            }
        }

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new ControlLibrary.uc_ExportExcelFile { Fildvg = dataGridView1 }.RunExcel();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xCompany_")
            {
   this.uc_DataGridViewBtn1.Visible = true;
   Rectangle rectangle = this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
   this.uc_DataGridViewBtn1.Location = new Point(rectangle.X, rectangle.Y);
   this.uc_DataGridViewBtn1.Size = new Size(20, this.dataGridView1.Rows[e.RowIndex].Height);
   this.uc_DataGridViewBtn1.RI = e.RowIndex;
   this.uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }
            else
            {
   this.uc_DataGridViewBtn1.Visible = false;
            }
        }
    }
}
