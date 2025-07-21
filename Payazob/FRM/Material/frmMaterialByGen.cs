using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Material
{
    public partial class frmMaterialByGen : Form
    {
        public frmMaterialByGen(int GenType_)
        {
            InitializeComponent();
            GenType = GenType_;
            BLL.csMaterial csmt = new BLL.csMaterial();
            dt_P = csmt.SlMaterial("#",  GenType_);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            Generate();
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xGenType_Column.DefaultValue = GenType_;
        }
        DAL.DataSet_Material.SlMaterialDataTable dt_P;
        int GenType;
        private void frmTools_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.Visible = false;
            }
            this.Generate();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.csMaterial css = new BLL.csMaterial();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdMaterial(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csMaterial csmt = new BLL.csMaterial();
            dt_P = csmt.SlMaterial("#", GenType);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            Generate();
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xGenType_Column.DefaultValue = GenType;
        }
        void Generate()
        {

            CS.csDic dic = new CS.csDic();
            foreach (DataColumn column in this.dt_P.Columns)
            {
                this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
            }
            dataGridView1.Columns["xMaterialName"].Visible = true;
            dataGridView1.Columns["xMaterialName"].Width = 300;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int Ri = dataGridView1.SelectedCells[0].RowIndex;
                if (dataGridView1.Rows[Ri].Cells["xMaterialName"].Value != null)
                    lbl_Comment.Text = dataGridView1.Rows[Ri].Cells["xMaterialName"].Value.ToString();
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
