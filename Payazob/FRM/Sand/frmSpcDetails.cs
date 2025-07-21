using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Sand
{
    public partial class frmSpcDetails : Form
    {
        public frmSpcDetails()
        {
            InitializeComponent();
            ShowDataGridView();

        }
        DAL.GenCntValue.DataSet_GenCntValue.mGenCntValueDataTable dt_G;

        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_G.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xTopGroup"].Visible = false;
            dataGridView1.Columns["xGroup"].Visible = false;

            //dataGridView1.Columns["xGroupFarsi"].ReadOnly = true;
            //dataGridView1.Columns["xNameFarsi"].ReadOnly = true;
            dataGridView1.Columns["xName"].ReadOnly = true;
                

        }

        void ShowDataGridView()
        {

            BLL.Sand.scSPC cs = new BLL.Sand.scSPC();
            dt_G = cs.mGenCntValue("SANDSPC");
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = dt_G;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                BLL.Sand.scSPC cs = new BLL.Sand.scSPC();
                MessageBox.Show(cs.UdmGenCntValue(dt_G), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGridView();
            }
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            SaveDataGridView();
            ShowDataGridView();

        }
    }
}
