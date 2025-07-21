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
    public partial class frmPiecesProuductAndDetial_Report : Form
    {
        public frmPiecesProuductAndDetial_Report()
        {
            InitializeComponent();
        }
        DataTable dt_P;
        void Generate()
        {
            dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه";
            dataGridView1.Columns["NumberPieces"].HeaderText = "تعداد تولید";
            dataGridView1.Columns["TotalPieceweight"].HeaderText = "کیلوگرم وزن قطعه";

            dataGridView1.Columns["Mold"].HeaderText = "تعداد قالب";

            dataGridView1.Columns["TotalPieceweight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Pieces"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["NumberPieces"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csInventory cs = new BLL.csInventory();
            dt_P = cs.SelectPiecesProuductAndDetial(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, Properties.Settings.Default.WorkYear);
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
            r.GetReport = cs.GetReport(dt_P, "crsPiecesProuductAndDetial");
            r.ShowDialog();
            r.Dispose();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }
    }
}
