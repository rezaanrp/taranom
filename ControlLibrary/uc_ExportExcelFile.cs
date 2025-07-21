using System;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ControlLibrary
{
    public class uc_ExportExcelFile : ProgressBar
    {

        private DataGridView dataGridView1;

        public DataGridView Fildvg
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }


        public void RunExcel()
        {
            this.Maximum = dataGridView1.Rows.Count;
            this.Step = 1;
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new
                  Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook excelBook =
                  excelApp.Workbooks.Add(XlSheetType.xlWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet =
                  (Worksheet)(excelBook.Worksheets[1]);
                //   excelApp.Visible = true;
                excelWorksheet.DisplayRightToLeft = true;

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excelWorksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    this.PerformStep();
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelWorksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                //int i = 1;
                //string st = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                //foreach (DataGridViewColumn item in dataGridView1.Columns)
                //{
                //    if (item.Visible == false)
                //        continue;
                //    Range rng1;
                //    if (i < 27)
                //        rng1 = excelWorksheet.get_Range(st[i - 1] + "1", st[i - 1] + "1");
                //    else
                //        rng1 = excelWorksheet.get_Range("A" + st[i - 27] + "1", "A" + st[i - 27] + "1");
                //    rng1.Value2 = item.HeaderText;
                //    rng1.Font.Bold = true;
                //    i++;
                //}
                //i = 1;
                //foreach (DataGridViewRow r in dataGridView1.Rows)
                //{
                //    this.PerformStep();
                //    int j = 1;
                //    foreach (DataGridViewColumn item in dataGridView1.Columns)
                //    {
                //        if (item.Visible == false)
                //            continue;
                //        Range r1;
                //        r1 = excelWorksheet.get_Range("A1", "A1");
                //        if (j < 27)
                //            r1 = excelWorksheet.get_Range(st[j - 1] + (i + 1).ToString(), st[j - 1] + (i + 1).ToString());
                //        else
                //            r1 = excelWorksheet.get_Range("A" + st[j - 27] + (i + 1).ToString(), "A" + st[j - 27] + (i + 1).ToString());
                //        if (dataGridView1[item.Index, r.Index].Value == null || dataGridView1[item.Index, r.Index].Value == DBNull.Value)
                //            r1.Value2 = "#";
                //        else
                //            r1.Value2 = dataGridView1[item.Index, r.Index].FormattedValue;
                //        j++;
                //    }
                //    i++;
                //}
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }

}
