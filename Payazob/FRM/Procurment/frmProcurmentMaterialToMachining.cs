using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentMaterialToMachining : Form
    {
        public frmProcurmentMaterialToMachining(CS.csEnum.Factory fct)
        {
            InitializeComponent();
            this.dt_P = new DAL.Procurement.DataSet_ProcurmentMaterialToMachining.SlProcurmentMaterialToMachiningDataTable();
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
 
            this.Generate();
            this.uc_DataGridViewBtn1.ColumnsFilter_ = "xMaterialName";
            this.uc_DataGridViewBtn1.ParamName = new string[] { "xMaterialName" };
            this.uc_DataGridViewBtn1.ParamValue = new string[] { "نام " };
            this.uc_DataGridViewBtn1.ParamHide = new string[] { "x_" };
            this.formFunctionPointer += new functioncall(this.Replicate);
            this.uc_DataGridViewBtn1.userFunctionPointer = this.formFunctionPointer;

        }
        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                this.dataGridView1["xMaterial_", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
                this.dataGridView1["cmb_Material", this.uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }

        }
        DAL.Procurement.DataSet_ProcurmentMaterialToMachining.SlProcurmentMaterialToMachiningDataTable dt_P;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {

            this.dt_P = new BLL.Procurement.csProcurmentMaterialToMachining().mProcurmentMaterialToMachining(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
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
            this.dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            base.Validate();
            BLL.Procurement.csProcurmentMaterialToMachining turning = new BLL.Procurement.csProcurmentMaterialToMachining();
            MessageBox.Show(turning.UdProcurmentMaterialToMachining(this.dt_P));
            this.dt_P = turning.mProcurmentMaterialToMachining(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
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
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xMaterial_")
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
        private void frmProcurmentMaterialToMachining_Load(object sender, EventArgs e)
        {

        }
    }
}
