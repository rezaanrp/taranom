using System;
using System.Windows.Forms;

namespace Payazob.FRM.MuscleProduct
{
    public partial class frmMinStockMuscle : Form
    {
        public frmMinStockMuscle()
        {
            InitializeComponent();
        }
        DAL.MuscleProduct.DataSet_MuscleINV.mPiecesDataTable dt_M;
        private void frmMinStockMuscle_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            dt_M = new BLL.MuscleProduct.csMuscleProduct().SlMinStockMuscle();
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void SaveDate()
        {

            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();

                MessageBox.Show(cs.UdMinStockMuscle(dt_M));
            }
        }
        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xName"].ReadOnly = true;
            dataGridView1.Columns["xMuscleName"].ReadOnly = true;

            dataGridView1.Columns["xName"].Width = 300;
            dataGridView1.Columns["xMuscleName"].Width = 150;

            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["xMuscleName"].HeaderText = "نام ماهیچه";
            dataGridView1.Columns["xMinStock"].HeaderText = "حداقل موجودی";

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDate();
            ShowData();
        }
    }
}
