using ControlLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.TimeLineMachine
{
    public partial class frmTimeLineMachine : Form
    {

        public frmTimeLineMachine()
        {
            InitializeComponent();
        }

        private void frmTimeLineMachine_Load(object sender, EventArgs e)
        {
 
            ShowData(BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void ShowData(string DateFrom ,string DateTo)
        {

            BLL.csshamsidate shc = new BLL.csshamsidate();
            ControlLibrary.GanttChart ganttChart1;

            ganttChart1 = new GanttChart();
            ganttChart1.AllowChange = true;
            ganttChart1.Dock = DockStyle.Fill;
            ganttChart1.AllowManualEditBar = true;
            ganttChart1.FromDate = shc.PersianToGregorian(DateFrom, "00:00");
            ganttChart1.ToDate = shc.PersianToGregorian(DateFrom, "23:59");
            panel1.Controls.Add(ganttChart1);

            List<BarInformation> lst1 = new List<BarInformation>();
            List<BarInformation> lst2 = new List<BarInformation>();
            List<BarInformation> lst3 = new List<BarInformation>();

            DataTable dt_line1 = new BLL.TimeLine.csTimeLine().SLTimeLineMachineForChart(DateFrom, DateFrom, 51);
            DataTable dt_line2 = new BLL.TimeLine.csTimeLine().SLTimeLineMachineForChart(DateFrom, DateFrom, 52);
            DataTable dt_line3 = new BLL.TimeLine.csTimeLine().SLTimeLineMachineForChart(DateFrom, DateFrom, 53);

            foreach (DataRow item in dt_line1.Rows)
            {
                lst1.Add(new BarInformation("Line 1", shc.PersianToGregorian(item["xDateBegin"].ToString(), item["xTimeBegin"].ToString())
                , shc.PersianToGregorian(item["xDateEnd"].ToString(), item["xTimeEnd"].ToString()), Color.Aqua, Color.Khaki, 1));
            }

            foreach (DataRow item in dt_line2.Rows)
            {
                lst2.Add(new BarInformation("Line 2", shc.PersianToGregorian(item["xDateBegin"].ToString(), item["xTimeBegin"].ToString())
                , shc.PersianToGregorian(item["xDateEnd"].ToString(), item["xTimeEnd"].ToString()), Color.Aqua, Color.Khaki, 3));
            }
            foreach (DataRow item in dt_line3.Rows)
            {
                lst3.Add(new BarInformation("Disa ", shc.PersianToGregorian(item["xDateBegin"].ToString(), item["xTimeBegin"].ToString())
                , shc.PersianToGregorian(item["xDateEnd"].ToString(), item["xTimeEnd"].ToString()), Color.Aqua, Color.Khaki, 5));
            }

            foreach (BarInformation bar in lst1)
            {
                ganttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }

            foreach (BarInformation bar in lst2)
            {
                ganttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }
            foreach (BarInformation bar in lst3)
            {
                ganttChart1.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                panel1.Controls.Remove(item);
            }
            ShowData(uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateFrom);
        }
    }
}
