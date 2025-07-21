using System;
using System.Data;

namespace BLL.MuscleProduct
{
    public class csMuscleProduct
    {
        public DAL.DataSet_Piece.SlMuscleByMachine_DataTable SlMuscleByMachine_(int xMachine_)
        {
            DAL.DataSet_PieceTableAdapters.SlMuscleByMachine_TableAdapter adp =
                new DAL.DataSet_PieceTableAdapters.SlMuscleByMachine_TableAdapter();
            return adp.GetData(xMachine_);
        }
        public DAL.DataSet_Piece.SlMuscleDataTable SlMuscle()
        {
            DAL.DataSet_PieceTableAdapters.SlMuscleTableAdapter adp =
                new DAL.DataSet_PieceTableAdapters.SlMuscleTableAdapter();
            return adp.GetData();
        }

        public string UdMuscle(DAL.DataSet_Piece.SlMuscleDataTable dt)
        {

            try
            {
                DAL.DataSet_PieceTableAdapters.SlMuscleTableAdapter adp =
                    new DAL.DataSet_PieceTableAdapters.SlMuscleTableAdapter(); adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public DAL.MuscleProduct.DataSet_MuscleINV.SlMusclePlanDataTable SlMusclePlan(string DateFrom,string DateTo,string WorkYear)
      {
          DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMusclePlanTableAdapter adp =
              new DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMusclePlanTableAdapter();
          return adp.GetData(DateFrom,DateTo,WorkYear);
      }

      public DAL.MuscleProduct.DataSet_MuscleINV.mPiecesDataTable SlMinStockMuscle()
      {
          DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.mPiecesTableAdapter adp =
              new DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.mPiecesTableAdapter();
          return adp.GetData();
      }

      public string UdMinStockMuscle(DAL.MuscleProduct.DataSet_MuscleINV.mPiecesDataTable dt)
      {

          try
          {
              DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.mPiecesTableAdapter adp =
                  new DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.mPiecesTableAdapter();
              adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";

          }
          catch (Exception e)
          {

              return e.Message;
          }
      }


      public bool SlMucsleInvCheak(string WorkYear, int Pieces,int? CountPieces)
      {
          DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMucsleInvCheakTableAdapter adp =
               new DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMucsleInvCheakTableAdapter();
          DataRow dr = adp.GetData(WorkYear, Pieces).Rows.Count > 0 ? adp.GetData(WorkYear, Pieces)[0]: null;
          
          if (dr == null)
              return false;
          int? CrntP = (int?)dr["PiecesNumber"];
          if (CountPieces <= CrntP)
          {
              return true;
          }
          else
              return false;
      }


      public DAL.MuscleProduct.DataSet_MuscleSend.SlMucsleSendReportDataTable SlMucsleSendReport(string DateFrom, string DateTo)
        {
            DAL.MuscleProduct.DataSet_MuscleSendTableAdapters.SlMucsleSendReportTableAdapter adp =
                 new DAL.MuscleProduct.DataSet_MuscleSendTableAdapters.SlMucsleSendReportTableAdapter();
            return adp.GetData( DateFrom, DateTo);
        }

      public DAL.MuscleProduct.DataSet_MuscleProduct.SlMuscleProductDataTable SlMuscleProduct(string DateFrom, string DateTo)
        {
            DAL.MuscleProduct.DataSet_MuscleProductTableAdapters.SlMuscleProductTableAdapter adp =
                 new DAL.MuscleProduct.DataSet_MuscleProductTableAdapters.SlMuscleProductTableAdapter();
            return adp.GetData( DateFrom, DateTo);
        }

      public string UdMuscleProduct(DAL.MuscleProduct.DataSet_MuscleProduct.SlMuscleProductDataTable dt)
        {
            try
            {
                DAL.MuscleProduct.DataSet_MuscleProductTableAdapters.SlMuscleProductTableAdapter adp =
                  new DAL.MuscleProduct.DataSet_MuscleProductTableAdapters.SlMuscleProductTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }  
      ///---------------------------
      ///
      public DAL.MuscleProduct.DataSet_MuscleSend.SlMuscleSendDataTable SlMuscleSend(string DateFrom, string DateTo,string Se)
        {
            DAL.MuscleProduct.DataSet_MuscleSendTableAdapters.SlMuscleSendTableAdapter adp =
                 new DAL.MuscleProduct.DataSet_MuscleSendTableAdapters.SlMuscleSendTableAdapter();
            return adp.GetData(DateFrom, DateTo, Se);
        }

      public string UdMuscleSend(DAL.MuscleProduct.DataSet_MuscleSend.SlMuscleSendDataTable dt)
        {
            try
            {
                DAL.MuscleProduct.DataSet_MuscleSendTableAdapters.SlMuscleSendTableAdapter adp =
                     new DAL.MuscleProduct.DataSet_MuscleSendTableAdapters.SlMuscleSendTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }


      public DAL.MuscleProduct.DataSet_BalanceBeginningMuscle.mBalanceBeginningMuscleDataTable SlBalanceBeginningMuscle(string DateFrom)
      {
          DAL.MuscleProduct.DataSet_BalanceBeginningMuscleTableAdapters.mBalanceBeginningMuscleTableAdapter adp =
               new DAL.MuscleProduct.DataSet_BalanceBeginningMuscleTableAdapters.mBalanceBeginningMuscleTableAdapter();
          return adp.GetData(DateFrom);
      }

      public string UdBalanceBeginningMuscle(DAL.MuscleProduct.DataSet_BalanceBeginningMuscle.mBalanceBeginningMuscleDataTable dt)
      {
          try
          {
              DAL.MuscleProduct.DataSet_BalanceBeginningMuscleTableAdapters.mBalanceBeginningMuscleTableAdapter adp =
                   new DAL.MuscleProduct.DataSet_BalanceBeginningMuscleTableAdapters.mBalanceBeginningMuscleTableAdapter();
              adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";

          }
          catch (Exception e)
          {

              return e.Message;
          }

      }

      public DAL.MuscleProduct.DataSet_MuscleINV.SlMucsleInvDataTable SlMucsleInv(string DateFrom, string DateTo, int Pieces)
      {
          DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMucsleInvTableAdapter adp =
               new DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMucsleInvTableAdapter();
          return adp.GetData( DateFrom,  DateTo,  Pieces);
      }

      public DAL.MuscleProduct.DataSet_MuscleINV.SlMuscleInvByPiecesDataTable SlMuscleInvByPieces(string DateFrom, string DateTo, int Pieces)
      {
          DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMuscleInvByPiecesTableAdapter adp =
               new DAL.MuscleProduct.DataSet_MuscleINVTableAdapters.SlMuscleInvByPiecesTableAdapter();
          return adp.GetData(DateFrom, DateTo, Pieces);
      }

    }
}
