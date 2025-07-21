using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.BalanceBeginningPieces
{
    public partial class frmBalanceBeginningPieces : Form
    {
        public frmBalanceBeginningPieces()
        {
            InitializeComponent();
            BLL.csPieces cp = new BLL.csPieces();

            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn();
            combobox_xPieces_.DisplayIndex = 4;
            combobox_xPieces_.HeaderText = "نام قطعه";
            combobox_xPieces_.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_xPieces_.DisplayMember = "xName";
            combobox_xPieces_.ValueMember = "x_";
            combobox_xPieces_.Name = "xPieces_";
            combobox_xPieces_.Width = 200;
            combobox_xPieces_.MinimumWidth = 25;
            combobox_xPieces_.DataPropertyName = "xPieces_";
            combobox_xPieces_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_xPieces_.MaxDropDownItems = 20;

            dataGridView1.Columns.Add(combobox_xPieces_);


            dt_B = new BLL.BalanceBeginningPieces.csBalanceBeginningPieces().SlBalanceBeginningPieces(Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_B;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

            label1.Text = " موجودی ابتدای دوره قطعات سال " + Properties.Settings.Default.WorkYear.Substring(2, 2);
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_B.Columns)
            {
   dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dt_B.xDateColumn.DefaultValue = Properties.Settings.Default.WorkYear;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xBalanceBegin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        DAL.BalanceBeginningPieces.DataSet_BalanceBeginning.SlBalanceBeginningPiecesDataTable dt_B;
        private void btn_Show_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   BLL.BalanceBeginningPieces.csBalanceBeginningPieces cs = new BLL.BalanceBeginningPieces.csBalanceBeginningPieces();

   MessageBox.Show(cs.UdBalanceBeginningPieces(dt_B));

   dt_B = cs.SlBalanceBeginningPieces(Properties.Settings.Default.WorkYear);

   dt_B.xDateColumn.DefaultValue = Properties.Settings.Default.WorkYear;

   bindingSource1.DataSource = dt_B;
   dataGridView1.DataSource = bindingSource1;
   bindingNavigator1.BindingSource = bindingSource1;

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
   if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }
    }
}
