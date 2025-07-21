using System;

namespace BLL.WorkHour
{
    public class csWorkHour
    {
       public DAL.WorkHour.DataSet_WorkHour.SlWorkHourDataTable SlWorkHour(string DateFrom, string DateTo)
        {
            DAL.WorkHour.DataSet_WorkHourTableAdapters.SlWorkHourTableAdapter adp =
                new DAL.WorkHour.DataSet_WorkHourTableAdapters.SlWorkHourTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

       public string UdWorkHour(DAL.WorkHour.DataSet_WorkHour.SlWorkHourDataTable dt)
        {
            try
            {
                DAL.WorkHour.DataSet_WorkHourTableAdapters.SlWorkHourTableAdapter adp =
                    new DAL.WorkHour.DataSet_WorkHourTableAdapters.SlWorkHourTableAdapter();
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
