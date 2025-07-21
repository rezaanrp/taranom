using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentScrabTestFn_Report : Form
    {
        public frmProcurmentScrabTestFn_Report()
        {
            InitializeComponent();
        }
        DAL.Procurement.DataSet_ProcurmentScarbTest.SlProcurmentScarbTestDataTable dt_P;

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.Procurement.csProcurmentScarbTest cs = new BLL.Procurement.csProcurmentScarbTest();
            dt_P = cs.SlProcurmentScarbTest(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, "OT");

            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            Generate();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BLL.Procurement.csProcurmentScarbTest css = new BLL.Procurement.csProcurmentScarbTest();
                DataTable dt = css.SlProcurmentScarbTestReport((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                Report.SendReport cs = new Report.SendReport();
                //cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
                //cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
                //cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(dt, "crsProcurmentScarbTestFn");
                r.ShowDialog();
                r.Dispose();
            }

        }
        void Generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
