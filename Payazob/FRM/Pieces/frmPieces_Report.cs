using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.Pieces
{
    public partial class frmPieces_Report : Form
    {
        public frmPieces_Report(string st)
        {
            InitializeComponent();
            dt_call = st;
        }
        private string dt_call;
        private DataTable dt_G;


        public bool FilterDate
        {
            get { return uc_Filter_Date1.Visible; }
            set { uc_Filter_Date1.Visible = value; }
        }
        

        void Generate()
        {

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            CS.csReportForm cs = new CS.csReportForm();
            cs.DateFrom = uc_Filter_Date1.uc_txtDateFrom.Text;
            cs.DateTo = uc_Filter_Date1.uc_txtDateTo.Text;
            dt_G = cs.OpenForm(dt_call);
            dataGridView1.DataSource = dt_G;
            bindingSource1.DataSource = dt_G;
            bindingNavigator1.BindingSource = bindingSource1;
        }
    }
}
