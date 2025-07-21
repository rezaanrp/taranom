using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmEmpty_Report : Form
    {
        public frmEmpty_Report(string st,string ReportName)
        {
            InitializeComponent();
            dt_call = st;
            ReportNa = ReportName;
            
        }
        private string dt_call;
        private string ReportNa;

        private DataTable dt_G;

        public bool FilterDate
        {
            get { return uc_Filter_Date1.Visible; }
            set { uc_Filter_Date1.Visible = value; }
        }
        /// <summary>
        /// برای فرم هایی که تاریخ بازه ای ندارد 
        /// </summary>
        public bool FilterDateTo_Visible
        {
            get { return uc_Filter_Date1.DateToVisible; }
            set { uc_Filter_Date1.DateToVisible = value; }
        }

        private Stack<string> stackVisibleParamName = new Stack<string>();
        private Stack<bool> stackVisibleParamValue = new Stack<bool>();

        private Stack<string> stackColorParamName = new Stack<string>();
        private Stack<Color> stackColorParamValue = new Stack<Color>();

        public void SetParam(string Name, bool Value)
        {
            stackVisibleParamName.Push(Name);
            stackVisibleParamValue.Push(Value);
        }
        public void SetParamColor(string Name, Color Value)
        {
            stackColorParamName.Push(Name);
            stackColorParamValue.Push(Value);
        }

        public bool ReportHaveDateDetails = true;

        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_G.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            while (stackVisibleParamName.Count > 0)
            {
               dataGridView1.Columns[stackVisibleParamName.Pop()].Visible = stackVisibleParamValue.Pop();
            }

            while (stackColorParamName.Count > 0)
            {
                dataGridView1.Columns[stackColorParamName.Pop()].DefaultCellStyle.BackColor = stackColorParamValue.Pop();
            }

            CS.csDataGridView csdgv = new CS.csDataGridView();
            csdgv.ColumnsCommaAllDecimal(ref dataGridView1);
        }

        public bool dataGridViewAutoSizeEndColumnMode;
        public bool dataGridViewAutoSizeFillColumnMode;

        public DataGridViewAutoSizeColumnsMode SizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        private void btn_Show_Click(object sender, EventArgs e)
        {

        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
          
            Report.SendReport cs = new Report.SendReport();
            if (ReportHaveDateDetails)
            {
                cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
                cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
                cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            }
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_G, ReportNa);
            r.ShowDialog();
            r.Dispose();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            string stdd = uc_Filter_Date1.DateTo;

            CS.csReportForm cs = new CS.csReportForm();
            cs.DateFrom = uc_Filter_Date1.DateFrom;
            cs.DateTo = uc_Filter_Date1.DateTo;
            dt_G = cs.OpenForm(dt_call);
            dataGridView1.DataSource = dt_G;
            bindingSource1.DataSource = dt_G;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
            if (dataGridViewAutoSizeEndColumnMode)
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridViewAutoSizeFillColumnMode)
                dataGridView1.AutoSizeColumnsMode = SizeColumnsMode;
        }
        Stack<int> dvg_ind = new Stack<int>();

        private void uc_txtBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void uc_txtBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
            else
            {
                dvg_ind.Clear();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Selected = false;
                }


                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell itemCell in item.Cells)
                    {

                        if (
                            itemCell.Visible == true && itemCell.Value != DBNull.Value && itemCell.Value != null &&
                            (itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text) ||
                             itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ی', 'ي')) ||
                              itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ي', 'ی')) ||
                               itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ک', 'ك')) ||
                                itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ك', 'ک')))
                            )
                        {

                            dvg_ind.Push(item.Index);
                            break;
                            //return;
                        }


                    }
                }
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
        }




    }
}
