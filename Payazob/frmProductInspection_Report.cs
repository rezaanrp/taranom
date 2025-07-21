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
    public partial class frmProductInspection_Report : Form
    {
        public frmProductInspection_Report()
        {
            InitializeComponent();
        }
        DataTable dt_In = new DataTable("Ins");

        private void frmProductInspection_Report_Load(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            //crsProductInspection cr = new crsProductInspection();
            //BLL.csDefect cs = new BLL.csDefect();
            //cr.SetDataSource(cs.SelectDefectByDate(uc_txtDateFrom.Text,uc_txtDateTo.Text));
            //crystalReportViewer1.ReportSource = cr;
            generateForm();

        }

        private void generateForm()
        {
            BLL.csDefect cs = new BLL.csDefect();
            dt_In.Clear();

            dt_In = cs.SelectDefectByDate(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);

            bindingSource1.DataSource = dt_In;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["xProductionDate"].HeaderText = "تاریخ تولید";
            dataGridView1.Columns["ShiftName"].HeaderText = "نام شیفت";
            dataGridView1.Columns["Piece"].HeaderText = "نام قطعه";
            dataGridView1.Columns["DefectNumber"].HeaderText = "تعداد ضایعات";
            dataGridView1.Columns["ControlledNumber"].HeaderText = "تعداد کنترل شده";
            dataGridView1.Columns["DefectPrecent"].HeaderText = "درصد ضایعات";
            dataGridView1.Columns["DefectPrecent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
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
            BLL.csDefect cs = new BLL.csDefect();
            Report.SendReport csr = new Report.SendReport();
            csr.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            csr.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            csr.SetParam("DateNow", uc_Filter_Date1.uc_txtDateTo.Text);
            frmReport r = new frmReport();
            r.GetReport = csr.GetReport(dt_In, "crsProductInspection");
            r.ShowDialog();
            r.Dispose();


        }
    }
}
