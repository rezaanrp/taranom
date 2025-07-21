using System;

namespace BLL.OverTime
{
    public class csOverTime
    {

        public DAL.OverTime.DataSet_OverTime.SlOverTime_RDataTable SlOverTime_R(string DateFrom, string DateTo, int Section_)
        {
            DAL.OverTime.DataSet_OverTimeTableAdapters.SlOverTime_RTableAdapter 
                adp = new DAL.OverTime.DataSet_OverTimeTableAdapters.SlOverTime_RTableAdapter();
            return adp.GetData(DateFrom, DateTo, Section_);
        }

        public DAL.OverTime.DataSet_OverTime.IOInfoByDateDataTable SlIOInfoByDate(string DateFrom, string DateTo)
        {
            DAL.OverTime.DataSet_OverTimeTableAdapters.IOInfoByDateTableAdapter adp = new
             DAL.OverTime.DataSet_OverTimeTableAdapters.IOInfoByDateTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        /// <summary>
        /// این تابع به صورت موقت جهت نمایش مغایرت ساخته شده
        /// </summary>
        /// <param name="DateFrom"></param>
        /// <param name="DateTo"></param>
        /// <param name="PerID">اگر کوچکتر از صفر باشد شرط در نظر گرفته نمی شود</param>
        /// <returns></returns>
        public DAL.OverTime.DataSet_OverTime.SlOverTimeDataTable SlOverTime(string DateFrom, string DateTo, int PerID,string Sec,int SecPer)
        {
            DAL.OverTime.DataSet_OverTimeTableAdapters.SlOverTimeTableAdapter adp = new
             DAL.OverTime.DataSet_OverTimeTableAdapters.SlOverTimeTableAdapter();
            return adp.GetData(DateFrom, DateTo, PerID, Sec, SecPer);
        }

        public DAL.OverTime.DataSet_OverTime.mOverTimeScuCkhDataTable OverTimeScuCkh( string Date)
        {
            DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeScuCkhTableAdapter adp = new
             DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeScuCkhTableAdapter();
            return adp.GetData(Date);
        }

        public DAL.Person.DataSet_PersonIO.IOInfoDataTable OverTimeIO(string PERNO,string DateFrom,string DateTo)
        {
            DAL.Person.DataSet_PersonIOTableAdapters.IOInfoTableAdapter adp = new
             DAL.Person.DataSet_PersonIOTableAdapters.IOInfoTableAdapter();
             return adp.GetData(PERNO,DateFrom,DateTo);
        }

        public DAL.OverTime.DataSet_OverTime.mOverTimeDataTable OverTime(int? xPerCode,string DateFrom,string DateTo)
        {
            DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeTableAdapter adp = new
             DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeTableAdapter();
            return adp.GetData(xPerCode,DateFrom,DateTo);
        }
        public string UdOverTime(DAL.OverTime.DataSet_OverTime.mOverTimeDataTable dt)
        {
            try
            {
                DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeTableAdapter adp = new
                 DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeTableAdapter();
                adp.Update(dt);

                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public string UdOverTimeReg(DAL.OverTime.DataSet_OverTime.mOverTimeDataTable dt)
        {
            try
            {
                DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeTableAdapter adp = new
                 DAL.OverTime.DataSet_OverTimeTableAdapters.mOverTimeTableAdapter();
                //adp.Update(dt);

                foreach (DAL.OverTime.DataSet_OverTime.mOverTimeRow item in dt.Rows)
                {
                    adp.Insert(
                      item.xDate,
                      item.xPerCode,
                      item.xBeginTimeOver1,
                      item.xEndTimeOver1,
                      item.xBeginTimeOver2,
                      item.xEndTimeOver2,
                      item.xReason,
                      item.xSupplier_,
                      item.xSupplier,
                      null,
                      item.xManager,
                      null,
                      item.xApprove

                        );

                }

                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
