using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.ManagerReport
{
    public partial class frmManegerReport : Form
    {
        public frmManegerReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        void generate()
        {
            CS.csDic css = new CS.csDic();
           
            foreach (DataColumn dc in new DAL.inventory.DataSet_Inventory.SelectPiecesProductAndDetialAllDataTable().Columns)
            {
                dataGridView_Prd.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView_Prd.Columns["xLineNumber"].Visible = false;
            dataGridView_Prd.Columns["Shift"].HeaderText = "سرپرست شیفت";

            foreach (DataColumn dc in new DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeByDetial_ReportManDataTable().Columns)
            {
                dataGridView_dwn.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            foreach (DataColumn dc in new DAL.inventory.DataSet_Inventory.SlProductPiecesVsPlanDataTable().Columns)
            {
                dataGridView_PLPR.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

   
            foreach (DataColumn dc in new DAL.SalePlan.DataSet_SalePlan.SlSalePlan_ReportManDataTable().Columns)
            {
                dataGridView_Snd.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }


            foreach (DataColumn dc in new DAL.Procurement.DataSet_ProcurmentScarbTest.SlProcurmentScarbTestRpDataTable().Columns)
            {
                dataGridView_Scrab.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
          //  dataGridView_Scrab.Columns["xRent"].Visible = false;
            dataGridView_Scrab.Columns["xSupplier"].Visible = false;
            dataGridView_Scrab.Columns["xApprove"].Visible = false;
            dataGridView_Scrab.Columns["xTRApprove"].Visible = false;

            foreach (DataColumn dc in new DAL.ControlPrj.DataSet_ControlPrj.SlControlPrj_ReportManDataTable().Columns)
            {
                dataGridView_control.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            foreach (DataColumn dc in new DAL.NonConforming.DataSet_NonConforming.SlNonconformingDataTable().Columns)
            {
                dataGridView_NonCnf.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            foreach (DataColumn dc in new DAL.Sand.DataSet_SandDailyReport.SelectSandDailyReportDataTable().Columns)
            {
                dataGridView_sand.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

        }

        private void frmManegerReport_Load(object sender, EventArgs e)
        {
            BLL.csshamsidate csDate = new BLL.csshamsidate();

            dataGridView_Prd.DataSource = new BLL.csInventory().SelectPiecesProuductAndDetialAll(csDate.previousDay(1), BLL.csshamsidate.shamsidate);
            lbl_Tolid.Text = "مجموع تولید از ابتدای ماه" + "  " + new BLL.csInventory().QueryPiecesWeightTotal(BLL.csshamsidate.shamsidate.Substring(0, 8) + "01", BLL.csshamsidate.shamsidate);


            dataGridView_PLPR.DataSource = new BLL.csInventory().SlProductPiecesVsPlan(csDate.previousDay(2), BLL.csshamsidate.shamsidate);

            dataGridView_dwn.DataSource = new BLL.MoldingDownTime.MoldingDownTime().SlMoldingDownTimeByDetial_ReportMan(csDate.previousDay(1), BLL.csshamsidate.shamsidate, (int)CS.csEnum.Factory.Site1);

            dataGridView_Snd.DataSource = new BLL.SalePlan.csSalePlan().SlSalePlan_ReportMan(csDate.previousDay(1), BLL.csshamsidate.shamsidate);

            dataGridView_Scrab.DataSource = new BLL.Procurement.csProcurmentScarbTest().SlProcurmentScarbTestRp(csDate.previousDay(1), BLL.csshamsidate.shamsidate);

            dataGridView_NonCnf.DataSource = new BLL.Nonconforming.csNonconforming().SlNonconforming(csDate.previousDay(1), BLL.csshamsidate.shamsidate);

            dataGridView_sand.DataSource = new BLL.csSand().SelectSandDailyReport(csDate.previousDay(1), BLL.csshamsidate.shamsidate);

            dataGridView_control.DataSource = new BLL.ControlPrj.csControlPrj().SlControlPrj_ReportMan();


            generate();
        }

        private void ucStatusBar1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_Prd_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell =  (sender as DataGridView).SelectedCells;

        }

        private void btn_prj_Click(object sender, EventArgs e)
        {
            new FRM.ControlPrj.frmControlPrj("rep").ShowDialog();
        }

    }
}
