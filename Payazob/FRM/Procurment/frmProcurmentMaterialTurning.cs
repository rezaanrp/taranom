using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentMaterialTurning : Form
    {
        public frmProcurmentMaterialTurning()
        {
            InitializeComponent();

            this.dt_P = new DAL.Procurement.DataSet_ProcurmentMaterialTurning.mProcurmentMaterialTurningDataTable();
            this.dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            this.dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            this.bindingSource1.DataSource = this.dt_P;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            BLL.csMaterial material = new BLL.csMaterial();
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 4,
                HeaderText = "نوع مواد",
                DataSource = material.SelectMeltName(160, -1, false),
                DisplayMember = "xMaterialName",
                ValueMember = "x_",
                DataPropertyName = "xMaterial_",
                Name = "cmb_Material",
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);
            BLL.csCompony compony = new BLL.csCompony();
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 3,
                HeaderText = "تامین کننده",
                DataSource = compony.SelectSupplier(),
                DisplayMember = "xComponyName",
                ValueMember = "x_",
                DataPropertyName = "xSupplierCompany_",
                Name = "cmb_Supplier",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column2);
            this.Generate();
            this.uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            this.uc_DataGridViewBtn1.Ds = compony.SelectSupplier();
            this.uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            this.uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            this.uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xAddress", "xTel", "xFax", "xEmail", "xWebsite", 
                "xSupplyManager", "xSupplyManagerTel", "xDirectorFactor", "xDirectorFactorTel" };
            this.formFunctionPointer += new functioncall(this.Replicate);
            this.uc_DataGridViewBtn1.userFunctionPointer = this.formFunctionPointer;

        }
        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                this.dataGridView1["xSupplierCompany_", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
                this.dataGridView1["cmb_Supplier", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }

        }
        DAL.Procurement.DataSet_ProcurmentMaterialTurning.mProcurmentMaterialTurningDataTable dt_P;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {

            this.dt_P = new BLL.Procurement.csProcurmentMaterialTurning().mProcurmentMaterialTurning(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
            this.dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            this.dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            this.bindingSource1.DataSource = this.dt_P;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.Generate();

        }
        private void Generate()
        {
            CS.csDic dic = new CS.csDic();
            foreach (DataColumn column in this.dt_P.Columns)
            {
                this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
            }
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xMaterial_"].Visible = false;
            this.dataGridView1.Columns["xSupplier_"].Visible = false;
            this.dataGridView1.Columns["xSupplierCompany_"].DisplayIndex = 3;
            this.dataGridView1.Columns["cmb_Supplier"].DisplayIndex = 4;
            this.dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            base.Validate();
            BLL.Procurement.csProcurmentMaterialTurning turning = new BLL.Procurement.csProcurmentMaterialTurning();
            MessageBox.Show(turning.UdProcurmentMaterialTurning(this.dt_P));
            this.dt_P = turning.mProcurmentMaterialTurning(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
            this.dt_P.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            this.dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            this.bindingSource1.DataSource = this.dt_P;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.Generate();

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!this.dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly && (this.dataGridView1.Columns[e.ColumnIndex].Name == "xDate"))
            {
                Payazob.FRM.frmDate.frmDate date = new Payazob.FRM.frmDate.frmDate();
                Rectangle rectangle = this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                date.Location = new Point(rectangle.X, rectangle.Y);
                date.ShowDialog();
                if (date.accept)
                {
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = date.fDate;
                }
            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xSupplierCompany_")
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }


    }
}
