using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentMaterialTestFN_Report : Form
    {
        public frmProcurmentMaterialTestFN_Report()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("xmaterial", txt_material.Text);
            cs.SetParam("xDateEnter", mtxt_dateEnter.Text);
            cs.SetParam("xDateTest", mtxt_test.Text);
            cs.SetParam("xRequestedItems", xRequestedItem.Text);
            cs.SetParam("ResultTest", ResultTest.Text);
            cs.SetParam("xComment", xComment.Text);
            cs.SetParam("xResult", xResult.Text);
            cs.SetParam("xNumberEnter", txt_EntranceNumber.Text);
            cs.SetParam("xApprove", txtBoxapproveby.Text);
            DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestReportDataTable dt = new DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestReportDataTable();
            dt.Rows.Add( dt.NewRow());
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt, "crsProcurmentMaterialTest_FN");
            r.ShowDialog();
            r.Dispose();
        }

        private void frmProcurmentMaterialTestFN_Report_Load(object sender, EventArgs e)
        {
            this.Size = new Size(672, 464);

        }
    }
}
