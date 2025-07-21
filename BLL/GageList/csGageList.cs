using System;

namespace BLL.GageList
{
    public  class csGageList
    {
        
        public DAL.GageList.DataSet_Gagelist.SlGageListCalibrationAlarmDataTable SlGageListCalibrationAlarm()
        {
            DAL.GageList.DataSet_GagelistTableAdapters.SlGageListCalibrationAlarmTableAdapter adp =
                new DAL.GageList.DataSet_GagelistTableAdapters.SlGageListCalibrationAlarmTableAdapter();
            return adp.GetData();
        }
        public DAL.GageList.DataSet_Gagelist.mGagelistDataTable mGagelist(int xGenFactory_)
        {
            DAL.GageList.DataSet_GagelistTableAdapters.mGagelistTableAdapter adp =
                new DAL.GageList.DataSet_GagelistTableAdapters.mGagelistTableAdapter();
            return adp.GetData(xGenFactory_);
        }
        public string UdGagelist(DAL.GageList.DataSet_Gagelist.mGagelistDataTable dt)
        {
            try
            {
                DAL.GageList.DataSet_GagelistTableAdapters.mGagelistTableAdapter adp =
                    new DAL.GageList.DataSet_GagelistTableAdapters.mGagelistTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.GageList.DataSet_Gagelist.mGageListCalibrationDataTable mGageListCalibration(int? x_)
        {
            DAL.GageList.DataSet_GagelistTableAdapters.mGageListCalibrationTableAdapter adp =
                 new DAL.GageList.DataSet_GagelistTableAdapters.mGageListCalibrationTableAdapter();
            return adp.GetData(x_);
        }

        public string UdGageListCalibration(DAL.GageList.DataSet_Gagelist.mGageListCalibrationDataTable dt)
        {
            try
            {
                DAL.GageList.DataSet_GagelistTableAdapters.mGageListCalibrationTableAdapter adp =
                     new DAL.GageList.DataSet_GagelistTableAdapters.mGageListCalibrationTableAdapter();
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
