using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandDailyReportAndRptEqu_Report : Form
    {
        public frmSandDailyReportAndRptEqu_Report()
        {
            InitializeComponent();
        }
        void Generate()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["ShiftName"].HeaderText = "شیفت";
            dataGridView1.Columns["Supplier"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["xReportOther"].HeaderText = "گزارشات دیگر";
            dataGridView1.Columns["xReportMechanical"].HeaderText = "گزارش مکانیکی";
            dataGridView1.Columns["xReportElectric"].HeaderText = "گزارش برقی";
            dataGridView1.Columns["xComment"].HeaderText = " توضیحات";

            dataGridView1.Columns["xDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["ShiftName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["Supplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["xReportOther"].Width = 200;
            dataGridView1.Columns["xReportMechanical"].Width = 200;
            dataGridView1.Columns["xReportElectric"].Width = 200;
            dataGridView1.Columns["xComment"].Width = 200;
        }
        DataTable dt_S;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csSand cs = new BLL.csSand();
            dt_S = cs.SelectSandDailyReportAndReportEquipment(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            dataGridView1.DataSource = dt_S;
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_S, "crsSandDailyReportAndRptEqu");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
