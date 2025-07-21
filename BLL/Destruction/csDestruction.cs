using System;

namespace BLL.Destruction
{
    public  class csDestruction
    {
      public DAL.DestructionReport.DataSet_DestructionMaterialTurning.mDestructionMaterialTurningDataTable mDestructionMaterialTurning(string DateFrom, string DateTo)
        {
            DAL.DestructionReport.DataSet_DestructionMaterialTurningTableAdapters.mDestructionMaterialTurningTableAdapter adp =
                new DAL.DestructionReport.DataSet_DestructionMaterialTurningTableAdapters.mDestructionMaterialTurningTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
      public string UdDestructionMaterialTurning(DAL.DestructionReport.DataSet_DestructionMaterialTurning.mDestructionMaterialTurningDataTable dt)
        {
            try
            {
                DAL.DestructionReport.DataSet_DestructionMaterialTurningTableAdapters.mDestructionMaterialTurningTableAdapter adp =
                    new DAL.DestructionReport.DataSet_DestructionMaterialTurningTableAdapters.mDestructionMaterialTurningTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
      public DAL.DestructionReport.DataSet_DestructionPiecesTurning.mDestructionPiecesTurningDataTable mDestructionPiecesTurning(string DateFrom, string DateTo)
      {
          DAL.DestructionReport.DataSet_DestructionPiecesTurningTableAdapters.mDestructionPiecesTurningTableAdapter adp =
              new DAL.DestructionReport.DataSet_DestructionPiecesTurningTableAdapters.mDestructionPiecesTurningTableAdapter();
          return adp.GetData(DateFrom, DateTo);
      }
      public string UdDestructionPiecesTurning(DAL.DestructionReport.DataSet_DestructionPiecesTurning.mDestructionPiecesTurningDataTable dt)
      {
          try
          {
              DAL.DestructionReport.DataSet_DestructionPiecesTurningTableAdapters.mDestructionPiecesTurningTableAdapter adp =
                  new DAL.DestructionReport.DataSet_DestructionPiecesTurningTableAdapters.mDestructionPiecesTurningTableAdapter();
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
