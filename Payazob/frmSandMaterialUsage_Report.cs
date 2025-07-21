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
    public partial class frmSandMaterialUsage_Report : Form
    {
        public frmSandMaterialUsage_Report()
        {
            InitializeComponent();
        }
        DataTable dt_Sn = new DataTable("Sand");

        private void btn_Show_Click(object sender, EventArgs e)
        {
            generateForm();
        }

        private void generateForm()
        {
            BLL.csSand cs = new BLL.csSand();
            dt_Sn.Clear();

            dt_Sn = cs.SelectSandMaterialUsageSumAVGByDate(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);

            bindingSource1.DataSource = dt_Sn;
            dataGridView1.DataSource = bindingSource1;

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
            //crsSandMaterialUsage cr = new crsSandMaterialUsage();
            //cr.SetDataSource(dt_Sn);
            //cr.SetParameterValue("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            //cr.SetParameterValue("DateTo", uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            //cr.SetParameterValue("DateNow", BLL.csshamsidate.shamsidate);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();

            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_Sn, "crsSandMaterialUsage");
            r.ShowDialog();
            r.Dispose();

           
        }
    }
}
