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
    public partial class frmPiecesProuductAndDetialAll_Report : Form
    {
        public frmPiecesProuductAndDetialAll_Report()
        {
            InitializeComponent();
        }
        DataTable dt_P;
        void Generate()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["TotalPieceweight"].HeaderText = "کیلوگرم وزن قطعه";
            dataGridView1.Columns["Shift"].HeaderText = "شیفت";
            dataGridView1.Columns["xLineNumber"].HeaderText = "شماره خط";

            dataGridView1.Columns["xLineNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Pieces"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csInventory cs = new BLL.csInventory();
            dt_P = cs.SelectPiecesProuductAndDetialAll(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            dataGridView1.DataSource = dt_P;
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
            r.GetReport = cs.GetReport(dt_P, "crsPiecesProuductAndDetialAll");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
