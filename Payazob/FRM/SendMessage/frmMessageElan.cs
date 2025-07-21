using System;
using System.Windows.Forms;

namespace Payazob.FRM.SendMessage
{
    public partial class frmMessageElan : Form
    {
        public frmMessageElan()
        {
            InitializeComponent();
        }
        public object GetReport;

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            //Report.SendReport cs = new Report.SendReport();
            //cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            //dt_E = new BLL.Message.csMessage().SlMessageElan(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, BLL.authentication.x_);

            //crystalReportViewer1.ReportSource = cs.GetReport(dt_E, "crsMessageElan"); ;

        }
        DAL.Message.DataSet_Message.SlMessageElanDataTable dt_E;
        void ShowElan()
        {
            //Report.SendReport cs = new Report.SendReport();

            //crystalReportViewer1.ReportSource = GetReport;


        }
    }
}
