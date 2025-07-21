using System;
using System.Windows.Forms;

namespace Payazob.FRM.Model
{
    public partial class frmModel : Form
    {
        public frmModel(string TypeUser)
        {
            InitializeComponent();
            if (TypeUser == "usr")
            {
             toolStripButton11.Visible = false;
             dataGridView2.ReadOnly = true;

             dataGridView1.ReadOnly = true;
             SavetoolStripButton13.Visible = false;
            }
        }
        DAL.Model.DataSet_Model.SlModelPiecesDataTable dt_MP;
        private void frmModel_Load(object sender, EventArgs e)
        {
            ShowDateGrid1();
        }
        DAL.Model.DataSet_Model.SlModelDataTable dt_M;


        void ShowDateGrid1()
        {
            BLL.Model.csModel cs = new BLL.Model.csModel();
            dataGridView1.DataSource = dt_MP = cs.SlModelPieces();
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";

            dataGridView1.Columns["x_"].Visible = false;

            dataGridView1.Columns["xName"].Width = 200;
            //dataGridView1.Columns["xHaveModel"].Width = 100;
            //dataGridView1.Columns["xCustomerConfirm"].Width = 100;
            dataGridView1.Columns["Customers"].Width = 800;

            dataGridView1.Columns["xName"].HeaderText = "نام مدل";
            dataGridView1.Columns["xName"].ReadOnly = true;

            dataGridView1.Columns["xHaveModel"].HeaderText = "صفحه مدل اختصاصی دارد";
            dataGridView1.Columns["xCustomerConfirm"].HeaderText = "تاییدیه مشتری دارد";
            dataGridView1.Columns["Customers"].HeaderText = "مشتریان";
        }
        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
                MessageBox.Show(new BLL.Model.csModel().UdModel(dt_M), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void ShowData(int x_)
        {
            dt_M = new BLL.Model.csModel().SlModel(x_);
            bindingSource2.DataSource = dt_M;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            dt_M.xPieces_Column.DefaultValue = x_;

            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xPieces_"].Visible = false;

            dataGridView2.Columns["xDescription"].HeaderText = "شرح اقدامات";
            dataGridView2.Columns["xDescription"].Width = 500;
            //dataGridView2.Rows. = 500;


        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                ShowData((int)dataGridView1["x_", e.RowIndex].Value);
            }
        }

        private void SavetoolStripButton13_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(new BLL.Model.csModel().UdModelPieces(dt_MP), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDateGrid1();
        }


    }
}
