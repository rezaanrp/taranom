using System;
namespace BLL.BalanceBeginningPieces
{
    public class csBalanceBeginningPieces
    {
       public DAL.BalanceBeginningPieces.DataSet_BalanceBeginning.SlBalanceBeginningPiecesDataTable SlBalanceBeginningPieces(string Date)
        {
            DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.SlBalanceBeginningPiecesTableAdapter adp =
                 new DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.SlBalanceBeginningPiecesTableAdapter();
            return adp.GetData(Date);
        }

       public string UdBalanceBeginningPieces(DAL.BalanceBeginningPieces.DataSet_BalanceBeginning.SlBalanceBeginningPiecesDataTable dt)
        {
            try
            {
                DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.SlBalanceBeginningPiecesTableAdapter adp =
                     new DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.SlBalanceBeginningPiecesTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

       public DAL.BalanceBeginningPieces.DataSet_BalanceBeginning.mBalanceBeginningPiecesCirculatingDataTable mBalanceBeginningPiecesCirculating(string Date)
       {
           DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.mBalanceBeginningPiecesCirculatingTableAdapter adp =
                new DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.mBalanceBeginningPiecesCirculatingTableAdapter();
           return adp.GetData(Date);
       }

       public string UdBalanceBeginningPiecesCirculating(DAL.BalanceBeginningPieces.DataSet_BalanceBeginning.mBalanceBeginningPiecesCirculatingDataTable dt)
       {
           try
           {
               DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.mBalanceBeginningPiecesCirculatingTableAdapter adp =
                    new DAL.BalanceBeginningPieces.DataSet_BalanceBeginningTableAdapters.mBalanceBeginningPiecesCirculatingTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";

           }
           catch (Exception e)
           {

               return e.Message;
           }

       }  
    }
}
