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
    public partial class frmFoundryDetailsTotalMeltByZinter_Report : Form
    {
        public frmFoundryDetailsTotalMeltByZinter_Report()
        {
            InitializeComponent();
            BLL.csFoundry cs = new BLL.csFoundry();
        }
        DataTable dt_Foundry = new DataTable("Foundry");
        private void generateForm()
        {
            dataGridView1.DataSource = dt_Foundry;
            bindingSource1.DataSource = dataGridView1.DataSource;
            dataGridView1.Columns["BDate"].HeaderText = "تاریخ زینتر قبلی";
            dataGridView1.Columns["ADate"].HeaderText = "تاریخ زینتر بعدی";
            dataGridView1.Columns["TotalMaterial"].HeaderText = "مجموع ذوب";
            dataGridView1.Columns["NumberFurnace"].HeaderText = "شماره کوره";
            dataGridView1.Columns["AIsHalfZinter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["AIsHalfZinter"].HeaderText = "نوع زینتر";
            dataGridView1.Columns["BIsHalfZinter"].HeaderText = "نوع زینتر";


            bindingNavigator1.BindingSource = bindingSource1;

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csFoundry cs = new BLL.csFoundry();
            dt_Foundry = cs.SelectFoundryDetailsTotalMeltByZinter(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            generateForm();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_Foundry, "crsFoundryDetailsTotalMeltByZinter");
            r.ShowDialog();
            r.Dispose();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }


    }
}

