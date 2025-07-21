using System;
using System.Windows.Forms;



namespace PAYAIND
{
    public class csexporttoexcell
    {


        public void exportexcel(DataGridView dgv)
        
        {
          
          
            if (dgv.Rows.Count > 0)
           
            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

                XcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {

                    XcelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {

                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        try
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                        catch { }
                    }
                }

                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }

        }
    }
}
