using System.Windows.Forms;

namespace Payazob.CS
{
    public class csDataGridView
    {
        public void ColumnsCommaAllDecimal(ref System.Windows.Forms.DataGridView dgv)
        {
            foreach (DataGridViewColumn item in dgv.Columns)
            {
                if (((System.Reflection.MemberInfo)(item.ValueType)).Name == "Decimal" || ((System.Reflection.MemberInfo)(item.ValueType)).Name == "Double")
                {
                    item.DefaultCellStyle.Format = "N2";
                }
                if (((System.Reflection.MemberInfo)(item.ValueType)).Name == "Int32" && (item.Name.ToUpper().Contains("COUNT") || item.Name.ToUpper().Contains("Number")))
                {
                    item.DefaultCellStyle.Format = "N0";
                }
                if (item.Name == "xBalanceBegin" ||
                     item.Name == "BeforPiecesProducts" ||
                     item.Name == "BeforSendNumber" ||
                     item.Name == "BeforDefectNumber" ||
                     item.Name == "AfterPiecesProducts" ||
                     item.Name == "AfterSendNumber" ||
                     item.Name == "AfterDefectNumber" ||
                     item.Name == "inventory" ||
                     item.Name == "NumberPieces" ||
                     item.Name == "xDuration"

                     )
                {
                    item.DefaultCellStyle.Format = "N0";
                }



            }

        }
    }
}
