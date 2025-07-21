using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.BalanceBeginningMaterial
{
    public partial class frmmBalanceBeginningMaterialTuring : Form
    {
        public frmmBalanceBeginningMaterialTuring()
        {
            InitializeComponent();

            this.dt_B = new BLL.BalanceBeginningMaterial.csBalanceBeginningMaterial().mBalanceBeginningMaterialTuring(Payazob.Properties.Settings.Default.WorkYear);
            this.bindingSource1.DataSource = this.dt_B;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
   DisplayIndex = 3,
   HeaderText = "نوع مواد",
   DataSource = new BLL.csMaterial().SlMaterial("#", 160),
   DisplayMember = "xMaterialName",
   ValueMember = "x_",
   DataPropertyName = "xPieces_",
   Name = "cmb_Material",
   Width = 150,
   ReadOnly = true,
   DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);
            this.uc_DataGridViewBtn1.ColumnsFilter_ = "xMaterialName";
            this.uc_DataGridViewBtn1.Ds = new BLL.csMaterial().SlMaterial("#", 160);
            this.uc_DataGridViewBtn1.ParamName = new string[] { "xMaterialName" };
            this.uc_DataGridViewBtn1.ParamValue = new string[] { "نام مواد" };
            this.uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xType", "xModule_", "xGenType_", "Module", "xConditionMaintenance", "xFeature", "xAcceptCriteria", "xControlTools", "xSupplier_", "xSupplier", "xDateEdit" };
            this.formFunctionPointer += new functioncall(this.Replicate);
            this.uc_DataGridViewBtn1.userFunctionPointer = this.formFunctionPointer;
            this.dt_B.xDateColumn.DefaultValue = Payazob.Properties.Settings.Default.WorkYear;
            this.Generate();
            this.label1.Text = "  موجودی ابتدای دوره انبار مواد اولیه سایت 3 سال" + Payazob.Properties.Settings.Default.WorkYear.Substring(2, 2);
            base.ActiveControl = this.dataGridView1;

        }
        DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterial.mBalanceBeginningMaterialTuringDataTable dt_B;
        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
   dataGridView1["xPieces_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
   dataGridView1["cmb_Material", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
   dataGridView1.CurrentCell = dataGridView1["cmb_Material", uc_DataGridViewBtn1.RI];
            }
        }


        private void Generate()
        {
            CS.csDic dic = new CS.csDic();
            foreach (DataColumn column in this.dt_B.Columns)
            {
   this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
            }
            this.dt_B.xDateColumn.DefaultValue = Payazob.Properties.Settings.Default.WorkYear;
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xDate"].Visible = false;
            this.dataGridView1.Columns["xPieces_"].HeaderText = "کد مواد";
            this.dataGridView1.Columns["xPieces_"].ReadOnly = true;
            this.dataGridView1.Columns["cmb_Material"].HeaderText = "نام مواد";
            this.dataGridView1.Columns["xBalanceBegin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xPieces_")
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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException exception = new Validation.VTranslateException();
            MessageBox.Show(exception.EnToFarsiCatalog(e.Exception.Message));

        }
        private void SaveData()
        {
            base.Validate();
            this.dataGridView1.EndEdit();
            BLL.BalanceBeginningMaterial.csBalanceBeginningMaterial material = new BLL.BalanceBeginningMaterial.csBalanceBeginningMaterial();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   MessageBox.Show(material.UdmBalanceBeginningMaterialTuring(this.dt_B), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }



    }
}
