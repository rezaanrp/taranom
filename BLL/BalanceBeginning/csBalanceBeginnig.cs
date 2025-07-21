using System;

namespace BLL.BalanceBeginning
{
    public class csBalanceBeginnig
    {


       public DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurning.mBalanceBeginningPiecesCirculatingTurningDataTable SlmBalanceBeginningPiecesCirculatingTurningTableAdapter(string Date)
        {
            DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginningPiecesCirculatingTurningTableAdapter adp =
                 new DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginningPiecesCirculatingTurningTableAdapter();
            return adp.GetData(Date);
        }

       public string UdmBalanceBeginningPiecesCirculatingTurningTableAdapter(DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurning.mBalanceBeginningPiecesCirculatingTurningDataTable dt)
        {
            try
            {
                DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginningPiecesCirculatingTurningTableAdapter adp =
                     new DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginningPiecesCirculatingTurningTableAdapter();
                adp.Update(dt);
                
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }  
        public DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurning.mBalanceBeginingPiecesTurningDataTable SlBalanceBeginingPiecesTurning(string Date)
        {
            DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginingPiecesTurningTableAdapter adp =
                 new DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginingPiecesTurningTableAdapter();
            return adp.GetData(Date);
        }

        public string UdBalanceBeginingPiecesTurning(DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurning.mBalanceBeginingPiecesTurningDataTable dt)
        {
            try
            {
                DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginingPiecesTurningTableAdapter adp =
                     new DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurningTableAdapters.mBalanceBeginingPiecesTurningTableAdapter();
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
