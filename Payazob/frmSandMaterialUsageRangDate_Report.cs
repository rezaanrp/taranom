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
    public partial class frmSandMaterialUsageRangDate_Report : Form
    {
        public frmSandMaterialUsageRangDate_Report()
        {
            InitializeComponent();
            BLL.csPieces cp = new BLL.csPieces();

            uc_cmbAutoPieces.DataSource = cp.mPiecesDataTable();
            uc_cmbAutoPieces.DisplayMember = "xName";
            uc_cmbAutoPieces.ValueMember = "x_";
            uc_cmbAutoPieces.SelectedIndex = -1;
        }
        DataTable dt_Sn = new DataTable("Sand");
        private void generateForm()
        {

            /*StartDate,
                        EndDate,
                        Bantonit,
                        SandNew,
                        CoalDust,
                        Water,
                        SandReturn,
                        BatchCount,
                        AVGBantonit,
                        AVGSandNew,
                        AVGCoalDust,
                        AVGWater,
                        AVGSandReturn*/
            BLL.csSand cs = new BLL.csSand();
            dt_Sn.Clear();

            dt_Sn = cs.SelectSandMaterialUsageRangeDate(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, (int)uc_cmbAutoPieces.SelectedValue);

            bindingSource1.DataSource = dt_Sn;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["StartDate"].HeaderText = "تاریخ ابتدای دوره";
            dataGridView1.Columns["EndDate"].HeaderText = "تاریخ انتهای دوره";

            dataGridView1.Columns["Bantonit"].HeaderText = "بنتونیت";
            dataGridView1.Columns["SandNew"].HeaderText = "ماسه نو";
            dataGridView1.Columns["CoalDust"].HeaderText = "گرد زغال";
            dataGridView1.Columns["Water"].HeaderText = "آب";
            dataGridView1.Columns["SandReturn"].HeaderText = "ماسه برگشتی";
            dataGridView1.Columns["BatchCount"].HeaderText = " تعداد بچ ساخته شده";
            dataGridView1.Columns["AVGBantonit"].HeaderText = " بنتونیت به ازای هر بچ";
            dataGridView1.Columns["AVGSandNew"].HeaderText = "  ماسه نو به ازای هر بچ";
            dataGridView1.Columns["AVGCoalDust"].HeaderText = " گرد زغال به ازای هر بچ";
            dataGridView1.Columns["AVGWater"].HeaderText = " آب به ازای هر بچ";
            dataGridView1.Columns["AVGSandReturn"].HeaderText = " ماسه برگشتی به ازای هر بچ ";
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //crsSandMaterialUsageRangDate cr = new crsSandMaterialUsageRangDate();
            //cr.SetDataSource(dt_Sn);
            //cr.SetParameterValue("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            //cr.SetParameterValue("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            //cr.SetParameterValue("DateNow", BLL.csshamsidate.shamsidate);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();


            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_Sn, "crsSandMaterialUsageRangDate");
            r.ShowDialog();
            r.Dispose();

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            generateForm();

        }

    }
}
