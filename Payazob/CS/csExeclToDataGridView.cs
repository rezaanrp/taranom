using System;
using System.Windows.Forms;

namespace Payazob.CS
{
    public class csExeclToDataGridView
    {
       public void PasteInData(ref DataGridView dgv, ref BindingSource bds)
        {
            char[] rowSplitter = { '\n', '\r' };  // Cr and Lf.
            char columnSplitter = '\t';         // Tab.

            IDataObject dataInClipboard = Clipboard.GetDataObject();

            string stringInClipboard =
   dataInClipboard.GetData(DataFormats.Text).ToString();

            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter,
   StringSplitOptions.RemoveEmptyEntries);

            int r = dgv.SelectedCells[0].RowIndex;
            int c = dgv.SelectedCells[0].ColumnIndex;

            if (dgv.Rows.Count < (r + rowsInClipboard.Length))
            {   // dgv.Rows.Add(r + rowsInClipboard.Length - dgv.Rows.Count);
   int cdvg = r + rowsInClipboard.Length - dgv.Rows.Count;
   for (int i = 0; i < cdvg; i++)
           bds.AddNew();
            }
            dgv.DataSource = bds;
            // Loop through lines:

            int iRow = 0;
            while (iRow < rowsInClipboard.Length)
            {
   // Split up rows to get individual cells:

   string[] valuesInRow =
       rowsInClipboard[iRow].Split(columnSplitter);

   // Cycle through cells.
   // Assign cell value only if within columns of grid:

   int jCol = 0;
   while (jCol < valuesInRow.Length)
   {
       if ((dgv.ColumnCount - 1) >= (c + jCol))
           dgv.Rows[r + iRow].Cells[c + jCol].Value =
           valuesInRow[jCol];

       jCol += 1;
   } // end while

   iRow += 1;
            } // end while
        } // PasteInData
    }
}
