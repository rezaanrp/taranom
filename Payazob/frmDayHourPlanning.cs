using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmDayHourPlanning : Form
    {
        public frmDayHourPlanning()
        {
            InitializeComponent();
            uc_Month1.Mo =int.Parse( BLL.csshamsidate.shamsidate.Substring(5,2) );
            uc_Month1.Ye = int.Parse(BLL.csshamsidate.shamsidate.Substring(0, 4));
            uc_Month1.GenBtn();

            DataTable dts = new BLL.DayHourPlanning.csDayHourPlanning().SlDayHourPlanning(uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo : uc_Month1.Mo.ToString()) + "/" + "01", uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo.ToString() : uc_Month1.Mo.ToString()) + "/" + "31");
            string sta = "";
            foreach (DataRow drs in dts.Rows)
            {
                sta += "*" + int.Parse(drs["xDate"].ToString().Substring(8, 2)).ToString(); ;
            }

            uc_Month1.GenColor(sta.Split('*'), Color.HotPink);




            dt_D = new DAL.DayHourPlanning.DataSet_DayHourPlannig.SlDayHourPlanningDataTable();
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;


            DataTable dt = new DataTable();
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            DataRow dr = dt.NewRow();
            dr["State"] = "شب";
            dr["Value"] = "N";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["State"] = "روز";
            dr1["Value"] = "M";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["State"] = "عصر";
            dr2["Value"] = "A";
            dt.Rows.Add(dr2);

            DataGridViewComboBoxColumn combobox_State = new DataGridViewComboBoxColumn();
            combobox_State.HeaderText = "شیفت";
            combobox_State.DataSource = dt;
            combobox_State.DisplayMember = "State";
            combobox_State.ValueMember = "Value";
            combobox_State.DataPropertyName = "xDay";
            combobox_State.Name = "cmb_State";
            combobox_State.Visible = true;
            combobox_State.DisplayIndex = 2;
            dataGridView1.Columns.Add(combobox_State);

            Generate();


            uc_Month1.ChangeMonthActive = true;
            formFunctionPointerchmon += new functioncallchmon(chmon);
            uc_Month1.ChangeMonth = formFunctionPointerchmon;

            //------------------------------------------------------

            uc_Month1.ClickActive = true;
            formFunctionPointerClick += new functioncallClick(uc_Mounth_Click);
            uc_Month1.userFunctionPointer = formFunctionPointerClick;

        }

        public delegate void functioncallchmon();

        private event functioncallchmon formFunctionPointerchmon;

        private void chmon()
        {
            DataTable dts = new BLL.DayHourPlanning.csDayHourPlanning().SlDayHourPlanning(uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo : uc_Month1.Mo.ToString()) + "/" + "01", uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo : uc_Month1.Mo.ToString()) + "/" + "31");
            dts = dts.DefaultView.ToTable(true, "xDate");
            string sta = "";
            foreach (DataRow drs in dts.Rows)
            {
                sta += "*" + int.Parse(drs["xDate"].ToString().Substring(8, 2)).ToString(); ;
            }

            uc_Month1.GenColor(sta.Split('*'), Color.HotPink);
        }

        public delegate void functioncallClick(string Date);
        
        private event functioncallClick formFunctionPointerClick;

        private void uc_Mounth_Click(string Date)
        {
            ShowDataGridView(Date, Date);
        }

        DAL.DayHourPlanning.DataSet_DayHourPlannig.SlDayHourPlanningDataTable dt_D;

        void ShowDataGridView(string DateFrom,string DateTo)
        {
            BLL.DayHourPlanning.csDayHourPlanning cs = new BLL.DayHourPlanning.csDayHourPlanning();
            dt_D = cs.SlDayHourPlanning(DateFrom,DateTo);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
        }

        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
          //  dataGridView1.Columns["xHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDay"].Visible = false;
            dataGridView1.Columns["xComment"].Width = 300;
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            BLL.DayHourPlanning.csDayHourPlanning cs = new BLL.DayHourPlanning.csDayHourPlanning();
            MessageBox.Show(cs.UdDayHourPlanning(dt_D));
            bindingSource1.DataSource = dt_D = cs.SlDayHourPlanning(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        /// <summary>
        /// برای تکرار سطر های ابتدایی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<DataGridViewCell> xDate = new List<DataGridViewCell>();
            List<DataGridViewCell> xDay = new List<DataGridViewCell>();
            List<DataGridViewCell> xHour = new List<DataGridViewCell>();
            List<DataGridViewCell> xLineCount = new List<DataGridViewCell>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!item.IsNewRow)
                {
                    xDate.Add(item.Cells["xDate"]);
                    xDay.Add(item.Cells["xDay"]);
                    xHour.Add(item.Cells["xHour"]);
                    xLineCount.Add(item.Cells["xLineNumber"]);
                }
            }

            int md = uc_Month1.Mo > 6 ? 31 : 32;
            md = uc_Month1.Mo == 12 ? 30 : md;
            for (int i = xDate.Count > 0 ?int.Parse( xDate[0] != null ?(int.Parse( xDate[0].Value.ToString().Substring(8,2)) + 1).ToString() : "1" ) : 1; i < md; i++)
            {

                for (int j = 0; j < xDate.Count; j++)
                {
                    DataRow dr = dt_D.NewRow();
                    dr["xDate"] = TARANOM.Properties.Settings.Default.WorkYear.Substring(0,4) + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo : uc_Month1.Mo.ToString()) + "/" + (i < 10 ? "0" + i : i.ToString());
                    dr["xDay"] = xDay[j].Value;
                    dr["xHour"] = xHour[j].Value;
                    dr["xLineNumber"] = xLineCount[j].Value;
                    dt_D.Rows.Add(dr);
                }

            }

            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_D, "crsDayHourPlannig");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
