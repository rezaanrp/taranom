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
    public partial class frmProcurmentGuest : Form
    {
        public frmProcurmentGuest()
        {
            InitializeComponent();
            BLL.csProcurement cs = new BLL.csProcurement();
            dt_PG = cs.SelectProcumentGuest(date, date);
            generateForm();
        }
        private string date = BLL.csshamsidate.shamsidate;

        private DAL.DataSet_Procurement.SelectProcurmentGuestDataTable dt_PG;

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
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            bindingNavigator1.BindingSource = bindingSource1;
            toolStripTextBoxDateFrom.Text = date;
            toolStripTextBoxDateTo.Text = date;
            dt_PG.Columns["xDate"].DefaultValue = date;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهیند این اطلاعات تغییر کند", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BLL.csProcurement pr = new BLL.csProcurement();
                pr.UpdateProcumentGuest(dt_PG);
                MessageBox.Show("ارسال با موفقیت انجام شد.");
            }
        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {
            BLL.csProcurement cs = new BLL.csProcurement();
            dt_PG.Clear();

            BLL.csshamsidate dateshamsi = new BLL.csshamsidate();
            string previousWeek = dateshamsi.previousDay(7);

            if (dateshamsi.CompareDate(toolStripTextBoxDateFrom.Text, previousWeek))
                dt_PG = cs.SelectProcumentGuest(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            else
                dt_PG = cs.SelectProcumentGuest(previousWeek, toolStripTextBoxDateTo.Text);

            bindingSource1.DataSource = dt_PG;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["x_"].Visible= false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dt_PG.Columns["xDate"].DefaultValue = date;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            //show = false;
            //dataGridView1.Columns.Clear();
            //dt_PG.Rows.Clear();
            //generateForm();
            //dataGridView1.Columns["x_"].Visible = false;
            //dataGridView1.Columns["xSupplier_"].Visible = false;

        }
        
        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
            //    return;
            //string st = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();


            //if (dataGridView1.Columns["xEnter"].Index == e.ColumnIndex || dataGridView1.Columns["xExit"].Index == e.ColumnIndex)
            //{
            //    System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(@"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$");
            //    if (st.Length != 5 || !re.IsMatch(st))
            //        dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
            //}
            //if (dataGridView1.Columns["xDate"].Index == e.ColumnIndex)
            //{
            //    System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex(@"((?<!\d+)([1-9][0-9][0-9][0-9]))/([1-9]|[0][1-9]|[1][0-2])/([1-9]|[1-2][0-9]|[0][1-9]|[3][0-1](?!\d+))");
            //       if (st.Length != 10|| !re.IsMatch(st) )
            //           dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
            //}
 
        }

        
        

    }

}
