using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmProductInspection_Chart : Form
    {
        public frmProductInspection_Chart()
        {
            InitializeComponent();

            Dictionary<string, string> cmb_T = new Dictionary<string, string>();
            cmb_T.Add("1", "گزارش  به تفکیک عیوب (آمار تولید)");
            cmb_T.Add("2", "گزارش  به تفکیک عیوب (آمار ضایعات)");
            cmb_T.Add("3", "روند ضایعات قطعه");
            cmb_T.Add("5", "ضایعات به تفکیک قطعه");
            cmb_T.Add("6", "روند عیوب");
            cmb_T.Add("4", "پاراتو کلی عیوب");
            uc_cmbAuto_ChartType.DataSource = new BindingSource(cmb_T, null);
            uc_cmbAuto_ChartType.DisplayMember = "Value";
            uc_cmbAuto_ChartType.ValueMember = "Key";
            Nud_Year.Value = int.Parse(TARANOM.Properties.Settings.Default.WorkYear.Substring(0, 4));

        }
        DataTable dt_PcNbDefect;
        private void btn_Show_Click(object sender, EventArgs e)
        {
          
        }
        void Generate()
        {
            string value = ((KeyValuePair<string, string>)uc_cmbAuto_ChartType.SelectedItem).Key;
            if (value == "1")
            {
             
                dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه  ";
                dataGridView1.Columns["xDefectName"].HeaderText = "نوع عیب";
                dataGridView1.Columns["DefectPercent"].HeaderText = "درصد عیب";
                dataGridView1.Columns["DefectPercent"].DefaultCellStyle.Format = "#.##";
                dataGridView1.Columns["DefectNumber"].HeaderText = "تعداد عیب ";
                dataGridView1.Columns["PiecesProduct"].HeaderText = "تعداد تولید ";

                // dataGridView1.Columns["DefectPercent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;   
            }
           else if (value == "2")
            {

                dataGridView1.Columns["ControlledNumber"].HeaderText = "تعداد تولید";
                dataGridView1.Columns["SumDefect"].HeaderText = "مجموع ضایعات  ";
                dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه  ";
                dataGridView1.Columns["xDefectName"].HeaderText = "نوع عیب";
                dataGridView1.Columns["DefectPercent"].HeaderText = "درصد عیب";
                dataGridView1.Columns["DefectNumber"].HeaderText = "تعداد عیب ";
                dataGridView1.Columns["DefectPercent"].DefaultCellStyle.Format = "#.##";


             //   dataGridView1.Columns["DefectPercent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
           else if (value == "3")
            {
                dataGridView1.Columns["Piece"].HeaderText = "نام قطعه  ";
                dataGridView1.Columns["NameMonthProduct"].HeaderText = "ماه";
                dataGridView1.Columns["DefectPrecent"].HeaderText = "درصد ضایعات";
          //      dataGridView1.Columns["DefectPercent"].DefaultCellStyle.Format = "#.##";

                dataGridView1.Columns["MonthProduct"].Visible = false;
            //    dataGridView1.Columns["DefectPrecent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
           else if (value == "4")
            {
                dataGridView1.Columns["xDefectName"].HeaderText = "نوع عیب";
                dataGridView1.Columns["DefectNumber"].HeaderText = "درصد";
             //   dataGridView1.Columns["DefectNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (value == "5")
            {

                dataGridView1.Columns["ControlledNumber"].HeaderText = "تعداد تولید";
                dataGridView1.Columns["SumDefect"].HeaderText = "مجموع ضایعات  ";
                dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه  ";
                dataGridView1.Columns["xDefectName"].HeaderText = "نوع عیب";
                dataGridView1.Columns["DefectNumber"].HeaderText = "تعداد عیب ";

                dataGridView1.Columns["DefectPercent"].HeaderText = "درصد عیب";
                dataGridView1.Columns["DefectPercent"].DefaultCellStyle.Format = "#.##";

              //  dataGridView1.Columns["DefectPercent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else if (value == "6")
            {

                dataGridView1.Columns["ControlledNumber"].HeaderText = "تعداد تولید";
                dataGridView1.Columns["SumDefect"].HeaderText = "مجموع ضایعات  ";
                dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه  ";
                dataGridView1.Columns["xDefectName"].HeaderText = "نوع عیب";
                dataGridView1.Columns["DefectPercent"].HeaderText = "درصد عیب";
                dataGridView1.Columns["DefectPercent"].DefaultCellStyle.Format = "#.##";

                //  dataGridView1.Columns["DefectPercent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)uc_cmbAuto_ChartType.SelectedItem).Key;
            if (value == "1")
            {
                Report.SendReport csr = new Report.SendReport();
                frmReport r = new frmReport();
                csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
                csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
                csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                r.GetReport = csr.GetReport(dt_PcNbDefect, "crsPruductInspection_PcNbDefect");
                r.ShowDialog();
                r.Dispose();    
            }

            else if (value == "2")
            {
                Report.SendReport csr = new Report.SendReport();
                frmReport r = new frmReport();
                csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
                csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
                csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                r.GetReport = csr.GetReport(dt_PcNbDefect, "crsPruductInspection_DefectNbPc");
                r.ShowDialog();
                r.Dispose();
            }
            else if (value == "5")
            {
                Report.SendReport csr = new Report.SendReport();
                frmReport r = new frmReport();
                csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
                csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
                csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                r.GetReport = csr.GetReport(dt_PcNbDefect, "crsPruductInspection_PcDefectNb");
                r.ShowDialog();
                r.Dispose();
            }
            else if (value == "3")
            {
                Report.SendReport csr = new Report.SendReport();
                frmReport r = new frmReport();
                csr.SetParam("YearP", Nud_Year.Value.ToString());
                csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                r.GetReport = csr.GetReport(dt_PcNbDefect, "crsPruductInspectionByMonth");
                r.ShowDialog();
                r.Dispose();
            }
            else if (value == "4")
            {
                Report.SendReport csr = new Report.SendReport();
                frmReport r = new frmReport();
                csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
                csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
                csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                r.GetReport = csr.GetReport(dt_PcNbDefect, "crsPruductInspectionDefectDetialsGroup");
                r.ShowDialog();
                r.Dispose();
            }
        }
        private void uc_cmbAuto_ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)uc_cmbAuto_ChartType.SelectedItem).Key;

            if (value == "3")
            {
                uc_Filter_Date1.Visible = false;
            }
            else
                uc_Filter_Date1.Visible = true;
            ShowDataGridView();

        }



        void Chart_1()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                chart2.Titles[0].Text = "درصد عیب به تعداد کل قطعه تولید شده در بازه زمانی";
                DataRow[] dr = dt_PcNbDefect.Select("xDefectName = '" + dataGridView1.SelectedRows[0].Cells["xDefectName"].Value.ToString() + "'");
                DataTable dtt = dr.CopyToDataTable<DataRow>();
                dtt.TableName = "dt_PcNbDefect";
                chart2.DataSource = dtt;
                chart2.Series["Series1"].Color = Color.MediumVioletRed;
                chart2.Series["Series1"].LegendText = dataGridView1.SelectedRows[0].Cells["xDefectName"].Value.ToString();
                chart2.Series["Series1"].XValueMember = "Pieces";
                chart2.Series["Series1"].YValueMembers = "DefectPercent";
                chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart2.Series["Series1"].LabelFormat = "0.00" ;
            }
        }

        void Chart_2()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                chart2.Titles[0].Text = "درصد عیب به تعداد کل ضایعات قطعه در بازه زمانی";

                DataRow[] dr = dt_PcNbDefect.Select("xDefectName = '" + dataGridView1.SelectedRows[0].Cells["xDefectName"].Value.ToString() + "'");
                DataTable dtt = dr.CopyToDataTable<DataRow>();
                dtt.TableName = "dt_PcNbDefect";
                chart2.DataSource = dtt;
                chart2.Series["Series1"].Color = Color.DeepSkyBlue;
                chart2.Series["Series1"].LegendText = dataGridView1.SelectedRows[0].Cells["xDefectName"].Value.ToString();
                chart2.Series["Series1"].XValueMember = "Pieces";
                chart2.Series["Series1"].YValueMembers = "DefectPercent";
                chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }

        void Chart_3()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                chart2.Titles[0].Text = "";

                BLL.csDefect cs = new BLL.csDefect();
                DataRow[] dr = dt_PcNbDefect.Select("Piece = '" + dataGridView1.SelectedRows[0].Cells["Piece"].Value.ToString() + "'");
                DataTable dtt = dr.CopyToDataTable<DataRow>();
                dtt.TableName = "dt_PcNbDefect";
                chart2.DataSource = dtt;
                chart2.Series["Series1"].Color = Color.DarkOrange;
                chart2.Series["Series1"].LegendText = dataGridView1.SelectedRows[0].Cells["Piece"].Value.ToString();
                chart2.Series["Series1"].XValueMember = "NameMonthProduct";
                chart2.Series["Series1"].YValueMembers = "DefectPrecent";
                chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }

        void Chart_4()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                chart2.Titles[0].Text = "";

                chart2.DataSource = dt_PcNbDefect;
                chart2.Series["Series1"].Color = Color.LimeGreen;
                chart2.Series["Series1"].LegendText ="  ";
                chart2.Series["Series1"].XValueMember = "xDefectName";
                chart2.Series["Series1"].YValueMembers = "DefectNumber";
                chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart2.Series["Series1"].LabelFormat = "0.00##";
            }
        }

        void Chart_5()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                chart2.Titles[0].Text = "پاراتو عیوب قطعه در بازه زمانی";
                 
                DataRow[] dr = dt_PcNbDefect.Select("Pieces = '" + dataGridView1.SelectedRows[0].Cells["Pieces"].Value.ToString() + "'" , " DefectPercent desc ");
                DataTable dtt = dr.CopyToDataTable<DataRow>();
                dtt.TableName = "dt_PcNbDefect";
                chart2.DataSource = dtt;
                chart2.Series["Series1"].Color = Color.Yellow;
                chart2.Series["Series1"].LegendText = dataGridView1.SelectedRows[0].Cells["Pieces"].Value.ToString();
                chart2.Series["Series1"].XValueMember = "xDefectName";
                chart2.Series["Series1"].YValueMembers = "DefectPercent";
                chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }

        void ShowDataGridView()
        {
            string value = ((KeyValuePair<string, string>)uc_cmbAuto_ChartType.SelectedItem).Key;
            if (value == "1")
            {
                BLL.csDefect cs = new BLL.csDefect();
                dt_PcNbDefect = cs.SlPruductInspectionPcDefectPr(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                bindingSource1.DataSource = dt_PcNbDefect;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                Generate();
                Chart_1();
            }
            if (value == "2")
            {
                BLL.csDefect cs = new BLL.csDefect();
                dt_PcNbDefect = cs.SlPruductInspectionDefectPcPrDefect(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                bindingSource1.DataSource = dt_PcNbDefect;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                Generate();
                Chart_2();

            }
            else if (value == "3")
            {
                BLL.csDefect cs = new BLL.csDefect();
                dt_PcNbDefect = cs.SlPruductInspectionByMonth(Nud_Year.Value.ToString());
                bindingSource1.DataSource = dt_PcNbDefect;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                Generate();
                Chart_3();
            }
            else if (value == "4")
            {
                BLL.csDefect cs = new BLL.csDefect();
                dt_PcNbDefect = cs.SlPruductInspectionDefectDetialsGroup(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                bindingSource1.DataSource = dt_PcNbDefect;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                Generate();
            }
            else if (value == "5")
            {
                BLL.csDefect cs = new BLL.csDefect();
                dt_PcNbDefect = cs.SlPruductInspectionDefectPcPrDefect(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                bindingSource1.DataSource = dt_PcNbDefect;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                Generate();
                Chart_5();

            }
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
               string value = ((KeyValuePair<string, string>)uc_cmbAuto_ChartType.SelectedItem).Key;
               if (value == "1")
               {
                   Chart_1();
               }
               else if (value == "2")
               {
                   Chart_2();
               }
               else if (value == "3")
               {
                   Chart_3();
               }
               else if (value == "4")
               {
                   Chart_4();
               }
               else if (value == "5")
               {
                   Chart_5();
               }
          //  Chart_2();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }


    }
}
