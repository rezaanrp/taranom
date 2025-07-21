using System;

namespace BLL.AnalyzeFurnace
{
    public class csAnalyzeFurnace
    {
      public DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable SlAnalyzeFurnaceDataTable(string DateFrom,string DateTo)
      {
          DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceTableAdapter adp
              = new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceTableAdapter();
          return adp.GetData(DateFrom, DateTo);
      }
      public string UdAnalyzeFurnace(DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable dt)
      {
          try
          {
              DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceTableAdapter adp =
                  new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceTableAdapter();
              adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";
          }
          catch (Exception e)
          {

              return e.Message;
          }
      }
      public DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceRangeDataTable SlAnalyzeFurnaceRangeDataTable()
      {
          DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceRangeTableAdapter adp
              = new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceRangeTableAdapter();
          return adp.GetData();
      }
      public string UdAnalyzeFurnaceRange(DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceRangeDataTable dt)
      {
          try
          {
              DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceRangeTableAdapter adp =
                  new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceRangeTableAdapter();
              adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";

          }
          catch (Exception e)
          {

              return e.Message;
          }
      }
      public DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceSpcDataTable SlAnalyzeFurnaceSPC(string DateFrom, string DateTo,int Pieces)
      {
          DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceSpcTableAdapter adp
              = new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnaceTableAdapters.SlAnalyzeFurnaceSpcTableAdapter();
          return adp.GetData(DateFrom, DateTo, Pieces);

      }
    }
}
