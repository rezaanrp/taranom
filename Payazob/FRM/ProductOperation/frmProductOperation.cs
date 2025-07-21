using System;
using System.Windows.Forms;
using BLL.ProductOperation;
using BLL;

namespace Payazob.FRM.ProductOperation
{
    public partial class frmProductOperation : Form
    {
        public frmProductOperation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int iD = -1;
            iD = (int)this.dataGridView1["x_", e.RowIndex].Value;
            this.ShowDateGrid2(iD);

        }
        private DAL.ProductOperation.DataSet_ProductOperation.mProductOperationDataTable dt_MP;

        private void frmProductOperation_Load(object sender, EventArgs e)
        {
            this.ShowDateGrid1();

        }
        private void SaveDateGrid2()
        {
            base.Validate();
            this.dataGridView2.EndEdit();
            if (new Payazob.CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new csProductOperation().UdProductOperation(this.dt_MP), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void ShowDateGrid1()
        {
            this.dataGridView1.DataSource = new csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site3);
            this.bindingSource1.DataSource = this.dataGridView1.DataSource;
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                if (column.Name != "xName")
                {
                    column.Visible = false;
                }
            }
            this.dataGridView1.Columns["xName"].Width = 300;
            this.dataGridView1.Columns["xName"].HeaderText = "نام محصول";
        }

        private void ShowDateGrid2(int ID)
        {
            this.dataGridView2.DataSource = this.dt_MP = new csProductOperation().ProductOperation(ID);
            this.bindingSource1.DataSource = this.dataGridView2.DataSource;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.dt_MP.xPieces_Column.DefaultValue = ID;
            this.dataGridView2.Columns["x_"].Visible = false;
            this.dataGridView2.Columns["xPieces_"].Visible = false;
            this.dataGridView2.Columns["xPerID_"].Visible = false;
            this.dataGridView2.Columns["xOpName"].HeaderText = "نام OP";
            this.dataGridView2.Columns["xDiscription"].HeaderText = "شرح";
            this.dataGridView2.Columns["xIsEnd"].HeaderText = "فرایند نهایی می باشد؟";
            this.dataGridView2.Columns["xDiscription"].Width = 400;
        }
      

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDateGrid2();
        }




    }
}
