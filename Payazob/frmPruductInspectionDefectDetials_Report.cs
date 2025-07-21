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
    public partial class frmPruductInspectionDefectDetials_Report : Form
    {
        public frmPruductInspectionDefectDetials_Report()
        {
            InitializeComponent();
        }
        DAL.QualityControl.DataSet_PruductInspection.SelectPruductInspectionDefectDetialsDataTable dt_D;

        void Generate()
        {
            dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه  ";
            dataGridView1.Columns["xDefectName"].HeaderText = "نوع ضایع";

            dataGridView1.Columns["DefectNumber"].HeaderText = "تعداد ضایعات";

            dataGridView1.Columns["DefectNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csDefect cs = new BLL.csDefect();
            dt_D = cs.SelectPruductInspectionDefectDetials(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
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
            r.GetReport = cs.GetReport(dt_D, "crsPruductInspectionDefectDetials");
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
