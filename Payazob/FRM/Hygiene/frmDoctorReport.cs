using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Payazob.FRM.Hygiene
{
    public partial class frmDoctorReport : Form
    {
        public frmDoctorReport()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            getExcelFile();
            generate();
        }


        DAL.Hygiene.DataSet_Hygiene.mDoctorReportDataTable dt_A;

        void generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_A.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
        }

        public  void getExcelFile()
        {
            BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
           OpenFileDialog dlgOpen = new OpenFileDialog();
           dt_A = new DAL.Hygiene.DataSet_Hygiene.mDoctorReportDataTable();
                dlgOpen.Filter =
                   "Excel file|*.xlsx";
                dlgOpen.Title = "انتخاب فایل ";
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    //Create COM Objects. Create a COM object for everything that is referenced
                    string CSVFilePathName = dlgOpen.FileName;
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(CSVFilePathName);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;
                    DataRow Row;
                    
                    //iterate over the rows and columns and print to the console as it appears in the file
                    //excel is not zero based!!
                    for (int i = 2; i <= rowCount; i++)
                    {
                            ////new line
                            //if (j == 1)
                            //    Console.Write("\r\n");

                            ////write the value to the console
                            //if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                            //    Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                                Row = dt_A.NewRow();
                                int? pe = csp.mPersonInfoGetX_ById(xlRange.Cells[i, 1].Value2.ToString());
                                if(pe == null)
                                {
                                    MessageBox.Show("شماره پرسنلی در برنامه کامل وارد نشده");
                                }
                                Row["xPerInfo_" ] =  pe;
                                Row["xDate" ] = BLL.csshamsidate.shamsidate;
                                Row["xWeight" ] = int.Parse(xlRange.Cells[i, 2].Value2.ToString());
                                Row["xBloodPressure"] =int.Parse( xlRange.Cells[i, 3].Value2.ToString() );
                                Row["xEyeDis"] = xlRange.Cells[i, 4].Value2.ToString();
                                Row["xSkinAndHair"] = xlRange.Cells[i, 5].Value2.ToString();
                                Row["xEar"] = xlRange.Cells[i, 6].Value2.ToString();
                                Row["xHeadAndNeck"] = xlRange.Cells[i, 7].Value2.ToString();
                                Row["xLung"] = xlRange.Cells[i, 8].Value2.ToString();
                                Row["xCardiovascular"] = xlRange.Cells[i, 9].Value2.ToString();
                                Row["xAbdomenAndPelvis"] = xlRange.Cells[i, 10].Value2.ToString();
                                Row["xKidney"] = xlRange.Cells[i, 11].Value2.ToString();
                                Row["xMusculoskeletal"] = xlRange.Cells[i, 12].Value2.ToString();
                                Row["xNervousSystem"] = xlRange.Cells[i, 13].Value2.ToString();
                                Row["xPsychiatry"] = xlRange.Cells[i, 14].Value2.ToString();
                                Row["xOther"] = xlRange.Cells[i, 15].Value2.ToString();
                                Row["xREye"] =int.Parse( xlRange.Cells[i, 16].Value2.ToString() );
                                Row["xLEye"] =int.Parse( xlRange.Cells[i, 17].Value2.ToString() );
                                Row["xRAudiometry"] =int.Parse( xlRange.Cells[i, 18].Value2.ToString() );
                                Row["xLAudiometry"] =int.Parse( xlRange.Cells[i, 19].Value2.ToString() );
                                Row["xSpirometry"] = xlRange.Cells[i, 20].Value2.ToString();
                                Row["xFinal"] = xlRange.Cells[i, 21].Value2.ToString();
                                dt_A.Rows.Add(Row);



                    }
                    bindingSource1.DataSource = dt_A;
                    dataGridView1.DataSource = bindingSource1;
                    bindingNavigator1.BindingSource = bindingSource1;
                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //rule of thumb for releasing com objects:
                    //  never use two dots, all COM objects must be referenced and released individually
                    //  ex: [somthing].[something].[something] is bad

                    //release com objects to fully kill excel process from running in the background
                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorksheet);

                    //close and release
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);

                    //quit and release
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            CS.csMessage csm = new CS.csMessage();
            if (csm.ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Hygiene.csHygiene().UdDoctorReport(dt_A));
                this.Close();
            }
        }
    }
}
