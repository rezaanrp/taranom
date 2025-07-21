using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Sand
{
    public partial class frmSandDailyTestMoANDCs_Report : Form
    {
        public frmSandDailyTestMoANDCs_Report()
        {
            InitializeComponent();
        }
         DataTable dt_MC;

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csSand cs = new BLL.csSand();
            dt_MC = cs.SlSandDailyTestSpcMoANDCs(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = dt_MC;
            bindingSource1.DataSource = dt_MC;
            bindingNavigator1.BindingSource = bindingSource1;
            //Generate();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Report.SendReport cs = new Report.SendReport();
         //   cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
         //   cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
         //   cs.SetParam("DateNow1", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_MC, "crsSandDailyTestMoANDCs");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
