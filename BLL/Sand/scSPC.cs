using System;
namespace BLL.Sand
{
    public  class scSPC
    {
      public DAL.Sand.DataSet_SPC.SlSandWeeklyTest_RChar_SPCDataTable SlSandWeeklyTest_RChar_SPC(string DateFrom, string DateTo, int GenType)
      {
          DAL.Sand.DataSet_SPCTableAdapters.SlSandWeeklyTest_RChar_SPCTableAdapter adp
              = new DAL.Sand.DataSet_SPCTableAdapters.SlSandWeeklyTest_RChar_SPCTableAdapter();
          return adp.GetData(DateFrom, DateTo, GenType);
      }
      public DAL.Sand.DataSet_SPC.SlSandDailyTest_RChar_SPCDataTable SlSandDailyTest_RChar_SPC(string DateFrom ,string DateTo,int Machine_)
      {
          DAL.Sand.DataSet_SPCTableAdapters.SlSandDailyTest_RChar_SPCTableAdapter adp
              = new DAL.Sand.DataSet_SPCTableAdapters.SlSandDailyTest_RChar_SPCTableAdapter();
          return adp.GetData(DateFrom, DateTo, Machine_);
      }

      public string QRSandSPC(string xName, string xGroup, string xTopGroup)
      {
          DAL.GenCntValue.DataSet_GenCntValueTableAdapters.QueriesTableAdapter adp
              = new DAL.GenCntValue.DataSet_GenCntValueTableAdapters.QueriesTableAdapter();
          return adp.QRSandSPC( xName,  xGroup , xTopGroup);
      }

      public DAL.GenCntValue.DataSet_GenCntValue.mGenCntValueDataTable mGenCntValue(string xTopGroup)
      {
          DAL.GenCntValue.DataSet_GenCntValueTableAdapters.mGenCntValueTableAdapter adp =
               new DAL.GenCntValue.DataSet_GenCntValueTableAdapters.mGenCntValueTableAdapter();
          return adp.GetData(xTopGroup);
      }

      public string UdmGenCntValue(DAL.GenCntValue.DataSet_GenCntValue.mGenCntValueDataTable dt)
      {
          try
          {
              DAL.GenCntValue.DataSet_GenCntValueTableAdapters.mGenCntValueTableAdapter adp =
                   new DAL.GenCntValue.DataSet_GenCntValueTableAdapters.mGenCntValueTableAdapter();
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
