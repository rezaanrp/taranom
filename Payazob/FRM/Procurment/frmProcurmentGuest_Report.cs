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
    public partial class frmProcurmentGuest_Report : Form
    {
        public frmProcurmentGuest_Report()
        {
            InitializeComponent();
            dt_PG.Columns.Add("xDate", typeof(string));
            dt_PG.Columns.Add("xName", typeof(string));
            dt_PG.Columns.Add("xFamily", typeof(string));
            dt_PG.Columns.Add("xEnter", typeof(string));
            dt_PG.Columns.Add("xExit", typeof(string));
            dt_PG.Columns.Add("xComment", typeof(string));
            dt_PG.Columns["xDate"].DefaultValue = BLL.csshamsidate.shamsidate;
            generateForm();
        }
        private DataTable dt_PG = new DataTable("ProcurmentGuest");
        private void generateForm()
        {
            //"xDate","xSupplier_","xName","xFamily","xEnter","xExit

            dataGridView1.DataSource = dt_PG;
            bindingSource1.DataSource = dataGridView1.DataSource;
            this.dataGridView1.Columns["xEnter"].DefaultCellStyle.Format = "y";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xName"].HeaderText = "نام";
            dataGridView1.Columns["xFamily"].HeaderText = "فامیل";
            dataGridView1.Columns["xEnter"].HeaderText = "زمان ورود";
            dataGridView1.Columns["xExit"].HeaderText = "زمان خروج";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csProcurement cs = new BLL.csProcurement();

            if (dt_PG != null)
            {
                dt_PG.Clear();
                dt_PG = cs.SelectProcumentGuest(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
                dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            bindingSource1.DataSource = dt_PG;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //crsProcurmentGuest cr = new crsProcurmentGuest();
            //cr.SetDataSource(dt_PG);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();


            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_PG, "crsProcurmentGuest");
            r.ShowDialog();
            r.Dispose();

        }
    }
}
