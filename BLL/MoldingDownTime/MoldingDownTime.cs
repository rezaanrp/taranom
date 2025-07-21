using System;
using System.Data;

namespace BLL.MoldingDownTime
{
    public class MoldingDownTime
    {

        public DataTable SlMoldingDownTimeByDetails(string DateFrom, string DateTo, int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeByDetailsTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeByDetailsTableAdapter();

            return adp.GetData(DateFrom, DateTo, xGenFact_);
        }
        public DataTable SlMoldingDownTimeByMachine(string DateFrom, string DateTo, int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeByMachineTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeByMachineTableAdapter();

            return adp.GetData(DateFrom, DateTo, xGenFact_);
        }


        public DataTable SlMoldingDownTimeSumNodeByMonth(string WorkYear, int NodeID, int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeSumNodeByMonthTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeSumNodeByMonthTableAdapter();

            return adp.GetData(WorkYear, NodeID, xGenFact_);
        }

        public DataTable SlMoldingDownTimeSumTopNode(int DownTimeType, string DateFrom, string DateTo, int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeSumTopNodeTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeSumTopNodeTableAdapter();

            return adp.GetData(DateFrom, DateTo, DownTimeType, xGenFact_);
        }

        public DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeByDetial_ReportManDataTable SlMoldingDownTimeByDetial_ReportMan(string DateFrom, string DateTo, int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeByDetial_ReportManTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeByDetial_ReportManTableAdapter();
            return adp.GetData(DateFrom, DateTo, xGenFact_);
        }

        #region گزارش توقفات با جزئیات
        /// <summary>
        /// 1392/12/04
        /// </summary>
        /// <param name="DateFrom"></param>
        /// <param name="DateTo"></param>
        /// <returns></returns>
        public DataTable SlMoldingDownTimeByDetial(string DateFrom, string DateTo, int Genfact)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeByDetialTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTime_RTableAdapters.SlMoldingDownTimeByDetialTableAdapter();
            return adp.GetData(DateFrom, DateTo, Genfact);

        }

        #endregion

        #region MoldingDowntimeObject

        public DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDownTimeObjectDataTable SelectMoldingDownTimeObject()
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDownTimeObjectTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDownTimeObjectTableAdapter();
            return adp.GetData();
        }
        public bool UdMoldingDownTimeObject(DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDownTimeObjectDataTable dt)
        {
            try
            {
                DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDownTimeObjectTableAdapter adp =
                    new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDownTimeObjectTableAdapter();
                adp.Update(dt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        #endregion

        #region MoldingDowntimeType
        public DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDowntimeTypeAllLeafDataTable SelectMoldingDownTimeTypeAllLeaf(int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDowntimeTypeAllLeafTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDowntimeTypeAllLeafTableAdapter();
            return adp.GetData(xGenFact_);
        }
        public DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDowntimeTypeDataTable SelectMoldingDownTimeType(int xGenFact_,bool ShowDeactive)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDowntimeTypeTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDowntimeTypeTableAdapter();
            return adp.GetData(xGenFact_, ShowDeactive);
        }

        public bool UdMoldingDownTimeType(DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDowntimeTypeDataTable dt)
        {
            try
            {
                DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDowntimeTypeTableAdapter adp =
                    new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.mMoldingDowntimeTypeTableAdapter();
                adp.Update(dt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        #endregion

        #region MoldingDowntime

        public DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDataTable SelectMoldingDownTime(string DateFrom, string DateTo, int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeTableAdapter();
            return adp.GetData(DateFrom, DateTo, xGenFact_);
        }
        public bool UdMoldingDownTime(DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDataTable dt)
        {
            try
            {
                DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeTableAdapter adp =
                    new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeTableAdapter();
                adp.Update(dt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        #endregion

        #region MoldingDowntimeDetials

        public DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDetailsDataTable SelectMoldingDownTimeDetials(int MoldingDownTime)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeDetailsTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeDetailsTableAdapter();
            return adp.GetData(MoldingDownTime);
        }
        public bool UdMoldingDownTimeDetials(DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDetailsDataTable dt)
        {
            try
            {
                DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeDetailsTableAdapter adp =
                    new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeDetailsTableAdapter();
                adp.Update(dt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        #endregion

        #region SlMoldingDownTimeTtTiGr

        public DataTable SlMoldingDownTimeTtTiGr(ref int? Ava, string DownTimeType, string DateFrom, string DateTo, int xGenFact_)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeTtTiGrTableAdapter adp =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.SlMoldingDownTimeTtTiGrTableAdapter();
            Ava = (int?)adp.SlMoldingDownTimeAvaTi(DateFrom, DateTo, xGenFact_);
            return adp.GetData(DownTimeType, DateFrom, DateTo, xGenFact_);
        }

        #endregion

        #region SlTotalAvailableTime

        public int? SlMoldingDownTimeTotalAvailableTime(string DateFrom, string DateTo, ref int? Line1, ref int? Line2)
        {
            DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.QueriesTableAdapter qr =
                new DAL.MoldingDownTime.DataSet_MoldingDownTimeTableAdapters.QueriesTableAdapter();
            Line1 = (int?)qr.SlMoldingDownTimeTotalAvailableTimeLine1(DateFrom, DateTo);
            Line2 = (int?)qr.SlMoldingDownTimeTotalAvailableTimeLine2(DateFrom, DateTo);

            return Line1 + Line2;


        }


        #endregion

    }
}
