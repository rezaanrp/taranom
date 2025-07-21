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
    public partial class frmSandDailyReport_Report : Form
    {
        private DataTable dt_Sand = new DataTable("Sand");

        public frmSandDailyReport_Report()
        {
            InitializeComponent();

            //string xPieces, string ShiftName, string xDate, string xComment, string xSamplingTime, 
            //decimal xMoisturePercent, int xPermeability, decimal xCompresiveStrength, int xCompactibility

            //dt_Sand.Columns.Add("xPieces", typeof(string));
            //dt_Sand.Columns.Add("ShiftName", typeof(decimal));
            //dt_Sand.Columns.Add("xDate", typeof(string));
            //dt_Sand.Columns.Add("xSamplingTime", typeof(string));
            //dt_Sand.Columns.Add("xMoisturePercent", typeof(decimal));
            //dt_Sand.Columns.Add("xPermeability", typeof(int));
            //dt_Sand.Columns.Add("xCompresiveStrength", typeof(decimal));
            //dt_Sand.Columns.Add("xCompactibility", typeof(int));
            //dt_Sand.Columns.Add("xComment", typeof(string));



     
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csSand cs = new BLL.csSand();
            dt_Sand.Clear();
            dt_Sand = cs.SelectSandDailyReport(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            bindingSource1.DataSource = dt_Sand;
            dataGridView1.DataSource = bindingSource1;
            //dataGridView1.Columns["xApprove"].Visible = false;

            dataGridView1.Columns["xPiecesLine1"].HeaderText = "نام قطعه خط یک";
            dataGridView1.Columns["xPiecesLine2"].HeaderText = "نام قطعه خط دو";
            dataGridView1.Columns["ShiftName"].HeaderText = "نام شیفت";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xSamplingTime"].HeaderText = "زمان نمونه گیری";
            dataGridView1.Columns["xMoisturePercent"].HeaderText = "درصد رطوبت";
            dataGridView1.Columns["xPermeability"].HeaderText = "عبور گاز";
            dataGridView1.Columns["xCompresiveStrength"].HeaderText = "استحکام فشاری";
            dataGridView1.Columns["xCompactibility"].HeaderText = "تراکم پذیری";
            dataGridView1.Columns["Supplier"].HeaderText = "تهیه کننده";

        }

       
        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_Sand, "crsSandDailyReport");
            r.ShowDialog();
            r.Dispose();
           
        }


    }
}
