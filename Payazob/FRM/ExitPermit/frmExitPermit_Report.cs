using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.ExitPermit
{
    public partial class frmExitPermit_Report : Form
    {
        public frmExitPermit_Report()
        {
            InitializeComponent();
            dt_D = new DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitRpDataTable();
          
        }
        DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitRpDataTable dt_D;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
            dt_D = cs.SlExitPermitRp(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void Generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["Section"].HeaderText = "نام قسمت";
            dataGridView1.Columns["ModuleName"].HeaderText = "واحد";

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["xConfirmBack"].Value == DBNull.Value || (bool)item.Cells["xConfirmBack"].Value == false)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_D, "crsExitPermit");
            r.ShowDialog();
            r.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
