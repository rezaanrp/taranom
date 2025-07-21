using System.Data;

namespace Payazob.CS
{
    public  class csGenDataTable
    {

        public void GenDataTable(DataTable dt, string DataTableName)
        {
            DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurning.mBalanceBeginingPiecesTurningDataTable dt_A  = 
   new DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurning.mBalanceBeginingPiecesTurningDataTable();
            foreach (DataTable item in dt.Rows)
            {
   for (int i = 0; i < item.Columns.Count; i++)
   {
      
   }     
   
            }
           
            //switch (DataTableName)
            //{
            //    "":

            //    default:
            //}
        }
    }
}
