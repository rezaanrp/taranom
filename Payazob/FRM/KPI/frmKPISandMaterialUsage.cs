using System;
using System.Windows.Forms;

namespace Payazob.FRM.KPI
{
    public partial class frmKPISandMaterialUsage : Form
    {
        public frmKPISandMaterialUsage()
        {
            InitializeComponent();
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowDataGridViewDay();
        }

        DAL.KPI.DataSet_KPI.SlKPISandMaterialOnMeltDataTable dt_R;

        void Generate()
        {

        }

        void ShowDataGridViewDay()
        {
            BLL.KPI.csKPI cs = new BLL.KPI.csKPI();
            dt_R = cs.SlKPISandMaterialOnMelts(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            Generate();
        }



        private void toolStripButtonChart2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonChart1_Click(object sender, EventArgs e)
        {

        }
    }
}
