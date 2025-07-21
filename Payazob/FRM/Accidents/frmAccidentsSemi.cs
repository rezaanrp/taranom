using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Accidents
{
    public partial class frmAccidentsSemi : Form
    {
        public frmAccidentsSemi()
        {
            InitializeComponent();
            dt_A = new DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsSemiDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

        }


        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsSemiDataTable dt_A;
        void ShowData()
        {
            BLL.AccidentsMinor.Accidents cs = new BLL.AccidentsMinor.Accidents();
            dt_A = cs.AccidentsSemi();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            Generate();
        }
        void SaveData()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   this.Validate();
   dataGridView1.EndEdit();
   MessageBox.Show(new BLL.AccidentsMinor.Accidents().UdAccidentsSemi(dt_A));
   ShowData();
            }
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_A.Columns)
            {
   dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xDescriptionOfEvent"].Width = 400;
            dataGridView1.Columns["xCorrectiveAction"].Width = 400;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

  

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void frmAccidentsMinor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
   if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
   else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;
        }
    }
}
