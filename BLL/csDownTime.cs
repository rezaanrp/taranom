using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
  public  class csDownTime
    {
      public DataTable SelectDownTimeType()
      {
          DAL.DataSet_DowntimeTableAdapters.mDowntimeTypeTableAdapter adp =
              new DAL.DataSet_DowntimeTableAdapters.mDowntimeTypeTableAdapter();
          return adp.GetData();
      }
      public bool InsertDownTime(string xDate,int xSection_,string xStartTime,string xEndTime,int xDuration
          ,string xComment,int xShift_,int xDowntimeType_)
      {
          if (BLL.authentication.InsertData == false)
              return false;
          DAL.DataSet_DowntimeTableAdapters.mDowntimeTableAdapter adp = new
           DAL.DataSet_DowntimeTableAdapters.mDowntimeTableAdapter();
          adp.Insert(xDate, xSection_, xStartTime, xEndTime, xDuration, xComment, xShift_, xDowntimeType_);
          return true;
      }
      public DataTable SelectDownTimeByDateGDuration(string DateFrom, string DateTo)
      {
          DAL.DataSet_DowntimeTableAdapters.SelectDownTimeByDateGDurationTableAdapter adp =
              new DAL.DataSet_DowntimeTableAdapters.SelectDownTimeByDateGDurationTableAdapter();
          return adp.GetData(DateFrom,DateTo);
      }
      /// <summary>
      /// انتخاب زمان توقف با فیلتر تاریخ و فیلتر قسمت و نوع زمان توقف 
      /// </summary>
      /// <returns></returns>
      public DataTable SelectDownTimeByxDateByTypeBySectionTableAdapter(string DateFrom, string DateTo, int xDowntimeType_, int xSection_)
      {
          DAL.DataSet_DowntimeTableAdapters.SelectDownTimeByxDateByTypeBySectionTableAdapter adp =
              new DAL.DataSet_DowntimeTableAdapters.SelectDownTimeByxDateByTypeBySectionTableAdapter();
          return adp.GetData(DateFrom, DateTo,xDowntimeType_,xSection_);
      }

      public DataTable SelectDownTimeByDateGDurationHSection(string DateFrom, string DateTo, int xSection_)
      {
          DAL.DataSet_DowntimeTableAdapters.SelectDownTimeByDateGDurationHSectionTableAdapter adp =
              new DAL.DataSet_DowntimeTableAdapters.SelectDownTimeByDateGDurationHSectionTableAdapter();
          return adp.GetData(DateFrom, DateTo, xSection_);
      }

    }
}
