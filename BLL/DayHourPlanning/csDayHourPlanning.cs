using System;

namespace BLL.DayHourPlanning
{
    public class csDayHourPlanning
    {
       public DAL.DayHourPlanning.DataSet_DayHourPlannig.SlDayHourPlanningDataTable SlDayHourPlanning(string DateFrom, string DateTo)
       {
           DAL.DayHourPlanning.DataSet_DayHourPlannigTableAdapters.SlDayHourPlanningTableAdapter adp =
               new DAL.DayHourPlanning.DataSet_DayHourPlannigTableAdapters.SlDayHourPlanningTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
       public string UdDayHourPlanning( DAL.DayHourPlanning.DataSet_DayHourPlannig.SlDayHourPlanningDataTable dt)
       {
           try
           {
           DAL.DayHourPlanning.DataSet_DayHourPlannigTableAdapters.SlDayHourPlanningTableAdapter adp =
               new DAL.DayHourPlanning.DataSet_DayHourPlannigTableAdapters.SlDayHourPlanningTableAdapter();
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
