using System;
using System.Data;

namespace BLL.GenGroup
{
    public  class csGenGroup
    {
      public DataTable SlGenGroup(string xType)
      {
          DAL.GenGroup.DataSet_GenGroupTableAdapters.SlGenGroupTableAdapter adp =
              new DAL.GenGroup.DataSet_GenGroupTableAdapters.SlGenGroupTableAdapter();
          return adp.GetData(xType);
      }

      public DAL.GenGroup.DataSet_GenGroup.mGenGroupDataTable mGenGroup(string xType)
      {
          DAL.GenGroup.DataSet_GenGroupTableAdapters.mGenGroupTableAdapter adp =
              new DAL.GenGroup.DataSet_GenGroupTableAdapters.mGenGroupTableAdapter();
          return adp.GetData(xType);
      }
      public string UdGenGroup(DAL.GenGroup.DataSet_GenGroup.mGenGroupDataTable dt)
      {
          try
          {
              DAL.GenGroup.DataSet_GenGroupTableAdapters.mGenGroupTableAdapter adp =
                  new DAL.GenGroup.DataSet_GenGroupTableAdapters.mGenGroupTableAdapter();
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
