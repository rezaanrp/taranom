using System;
using System.Data;

namespace BLL
{
    public class csSand
    {


        #region SandWeeklyTest

        public DataTable SandWeeklyTestByx_(int x_)
        {
            DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SlSandWeeklyTestByx_TableAdapter adp =
                new DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SlSandWeeklyTestByx_TableAdapter();
            return adp.GetData(x_);
        }

        #endregion


         #region SandDailyReport

                        #region SandDailyReportForm

                            public DataTable SelectSandDailyReportAndReportEquipment(string DateFrom, string DateTo)
                            {
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportAndReportEquipmentTableAdapter adp = new
                                    DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportAndReportEquipmentTableAdapter();
                                return adp.GetData(DateFrom, DateTo);
                            }
                            public DAL.Sand.DataSet_SandDailyReport.SelectSandDailyReportByDateDataTable SandDailyReport(string xDateFrom, string xDateTo)
                            {
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportByDateTableAdapter adp = new
                                 DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportByDateTableAdapter();
                                return adp.GetData(xDateFrom,xDateTo);
                            }
                            public bool UpdateSandDailyReport(DAL.Sand.DataSet_SandDailyReport.SelectSandDailyReportByDateDataTable dt,string xDate,int? xShift_,int? Machin)
                            {
                                if (xDate != "" && xShift_ != null)
                                {
                                    DAL.Sand.DataSet_SandDailyReportTableAdapters.SandDailyReportCheckRepetitionTableAdapter Qr =
                                        new DAL.Sand.DataSet_SandDailyReportTableAdapters.SandDailyReportCheckRepetitionTableAdapter();
                                    if (Qr.GetData(xDate, xShift_, Machin).Count > 0)
                                        return false;
                                }
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportByDateTableAdapter adp
                                    = new DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportByDateTableAdapter();
                                adp.Update(dt);
                                return true;

                            }
                        #endregion

                        #region SandDailyReportReport

                                                    

                         #endregion

                        #region MaterialUsage

                        #region MaterialUsagerForm

                            public DAL.Sand.DataSet_SandDailyReport.SelectSandMaterialUsageBySandDailyDataTable SelectSandMaterialUsageBySandDaily
                                (int xSandDailyReport_)
                            {
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandMaterialUsageBySandDailyTableAdapter adp = new
                                 DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandMaterialUsageBySandDailyTableAdapter();
                                return adp.GetData(xSandDailyReport_);
                            }
                            public bool UpdateSandMaterialUsage(DAL.Sand.DataSet_SandDailyReport.SelectSandMaterialUsageBySandDailyDataTable dt)
                            {
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandMaterialUsageBySandDailyTableAdapter adp = new
                                 DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandMaterialUsageBySandDailyTableAdapter();
                                adp.Update(dt);
                                return true;
                            }

                        #endregion
                        #region MaterialUsagerReport



                #endregion

            #endregion

                        #region SandDailyReportRange

                            public DAL.Sand.DataSet_SandDailyReport.SlSandDailyTestRangeDataTable SlSandDailyTestRange()
                            {
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestRangeTableAdapter adp = new
                                    DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestRangeTableAdapter();
                                return adp.GetData();
                            }
                            public string UdSandDailyTestRange(DAL.Sand.DataSet_SandDailyReport.SlSandDailyTestRangeDataTable dt)
                            {
                                try
                                {
                                    DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestRangeTableAdapter adp =
                                           new  DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestRangeTableAdapter();
                                    adp.Update(dt);
                                    return "عملیات ذخیره سازی با موفقیت انجام شد";

                                }
                                catch (Exception e)
                                {

                                    return e.Message;
                                }

                            }

                        #endregion

                        #region SandDailyReportTest

                        #region SandDailyReportTestForm

                            public DAL.Sand.DataSet_SandDailyReport.SelectSandDailyReportDetialBySandDailyDataTable
                                                                     SelectSandDailyReportDetialBySandDaily(int xSandDailyReport_)
                            {
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportDetialBySandDailyTableAdapter adp = new
                                    DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportDetialBySandDailyTableAdapter();
                                return adp.GetData(xSandDailyReport_);
                            }

                            public bool UpdateSandDailyReportDetial(DAL.Sand.DataSet_SandDailyReport.SelectSandDailyReportDetialBySandDailyDataTable dt)
                            {
                                DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportDetialBySandDailyTableAdapter adp
                                    = new DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportDetialBySandDailyTableAdapter();
                                adp.Update(dt);
                                return true;
                            }

                        #endregion
                        #region SandDailyReportTestReport



                #endregion

            #endregion


        #endregion

         #region نمودار آزمایشات هفتگی
        /// <summary>
        /// نمودار های spsازمایشات هفتگی 
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
                            public DataTable SlSandWeeklyTestSpc(string dateFrom, string dateTo)
                            {
                                DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SlSandWeeklyTestSpcTableAdapter adp =
                                    new DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SlSandWeeklyTestSpcTableAdapter();
                                return adp.GetData(dateFrom, dateTo);
                            }
                                

                            #endregion

         #region نمودار آزمایشات روزانه
                                    /// <summary>
                                    /// نمودار های spsازمایشات روزانه 
                                    /// </summary>
                                    /// <param name="dateFrom"></param>
                                    /// <param name="dateTo"></param>
                                    /// <returns></returns>
                                    public DataTable SlSandDailyTestSpcTable(int? MchId, string dateFrom, string dateTo)
                                    {
                                        DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestSpcTableAdapter adp =
                                            new DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestSpcTableAdapter();
                                        return adp.GetData( dateFrom, dateTo ,MchId);
                                    }
                                    /// <summary>
                                    /// نمودار های ترکیب رطوبت و استحکام فشاری ازمایشات روزانه 
                                    /// </summary>
                                    /// <param name="dateFrom"></param>
                                    /// <param name="dateTo"></param>
                                    /// <returns></returns>
                                    public DataTable SlSandDailyTestSpcMoANDCs(string dateFrom, string dateTo)
                                    {
                                        DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestMoANDCsTableAdapter adp =
                                            new DAL.Sand.DataSet_SandDailyReportTableAdapters.SlSandDailyTestMoANDCsTableAdapter();
                                        return adp.GetData(dateFrom, dateTo);
                                    }


        #endregion

        #region نتایج آزمایش هفتگی ماسه

        public DAL.Sand.DataSet_SandWeeklyTest.SelectSandWeeklyTestSummaryByDateDataTable SelectSandWeeklyTestSummaryByDate(string DateFrom, string DateTo)
        {
            DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SelectSandWeeklyTestSummaryByDateTableAdapter adp =
                new DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SelectSandWeeklyTestSummaryByDateTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public string UpdateSandWeeklyTestSummaryByDate(DAL.Sand.DataSet_SandWeeklyTest.SelectSandWeeklyTestSummaryByDateDataTable dt)
        {
            try
            {
                DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SelectSandWeeklyTestSummaryByDateTableAdapter adp =
                    new DAL.Sand.DataSet_SandWeeklyTestTableAdapters.SelectSandWeeklyTestSummaryByDateTableAdapter();
                 adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public DAL.Sand.DataSet_SandWeeklyTest.mSandWeeklyTestRow SelectSandWeeklyTestByX_(int x_)
        {
            DAL.Sand.DataSet_SandWeeklyTestTableAdapters.mSandWeeklyTestTableAdapter adp =
                new DAL.Sand.DataSet_SandWeeklyTestTableAdapters.mSandWeeklyTestTableAdapter();
            DAL.Sand.DataSet_SandWeeklyTest.mSandWeeklyTestDataTable dt_S = adp.GetData(x_);
            if (dt_S.Rows.Count > 0)
                return dt_S[0];
            else
                return null;
        }

        public bool UpdateSandWeeklyTest(int x_,string xDate,decimal? xDiameterBefore11,decimal? xDiameterBefore10 ,decimal? xDiameterBefore9,decimal? 
                         xDiameterBefore8,decimal? xDiameterBefore7,decimal? xDiameterBefore6,decimal? 
                         xDiameterBefore5,decimal? xDiameterBefore4,decimal? xDiameterBefore3,decimal? 
                         xDiameterBefore2,decimal? xDiameterBefore1,decimal? xDiameterAfter11,decimal? xDiameterAfter10,decimal? 
                         xDiameterAfter9,decimal? xDiameterAfter8,decimal? xDiameterAfter7,decimal? xDiameterAfter6,decimal? 
                         xDiameterAfter5,decimal? xDiameterAfter4,decimal? xDiameterAfter3,decimal? xDiameterAfter2,decimal? 
                         xDiameterAfter1,decimal? xAfsBefore,decimal? xAfsAfter,decimal? xVolatilePercent,decimal? 
                         xBurningPercent,decimal? xGlayPercent,decimal? xActiveBentnitePercent,decimal? xPermeability,
                         string xComment, int xGenGroup_)
        {
            try
            {

                int? xApprove_ = null;
                if (BLL.authentication.x_ == BLL.authentication.xApproveby_)
                    xApprove_ = BLL.authentication.x_;
                DAL.Sand.DataSet_SandWeeklyTestTableAdapters.mSandWeeklyTestTableAdapter adp =
                        new DAL.Sand.DataSet_SandWeeklyTestTableAdapters.mSandWeeklyTestTableAdapter();
                adp.UpdateSandWeeklyTest(xDate, xDiameterBefore11, xDiameterBefore10, xDiameterBefore9,
                             xDiameterBefore8, xDiameterBefore7, xDiameterBefore6,
                             xDiameterBefore5, xDiameterBefore4, xDiameterBefore3,
                             xDiameterBefore2, xDiameterBefore1, xDiameterAfter11, xDiameterAfter10,
                             xDiameterAfter9, xDiameterAfter8, xDiameterAfter7, xDiameterAfter6,
                             xDiameterAfter5, xDiameterAfter4, xDiameterAfter3, xDiameterAfter2,
                             xDiameterAfter1, xAfsBefore, xAfsAfter, xVolatilePercent,
                             xBurningPercent, xGlayPercent, xActiveBentnitePercent, xPermeability,
                             xApprove_, xComment, x_, xGenGroup_);
                return true;

            }
            catch (Exception)
            {
               
                return false;
            }
        }
        #endregion


        #region گزارش آزمایشگاه و مصرف خط ماسه

        public DataTable SelectSandMaterialAndDaily(int? xPieces_, string DateFrom, string DateTo)
        {
            DAL.DataSet_SandTableAdapters.SelectSandMaterialAndDailyTableAdapter adp
                = new DAL.DataSet_SandTableAdapters.SelectSandMaterialAndDailyTableAdapter();
            return adp.GetData(xPieces_, DateFrom, DateTo);
        }
        
        #endregion


        #region Report SandMaterialUsage

        public DataTable SelectSandMaterialUsageSumAVGByDate(string DateFrom, string DateTo)
        {
            DAL.DataSet_SandTableAdapters.SelectSandMaterialUsageSumAVGByDateTableAdapter adp
                = new DAL.DataSet_SandTableAdapters.SelectSandMaterialUsageSumAVGByDateTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

     //   public DataTable SelectSandMaterialUsageRangeDate(string xDateFrom, string xDateTo, int xPieces_)
     //   {
     //       DAL.DataSet_SandTableAdapters.SelectSandMaterialUsageRangeDateTableAdapter adp
     //           = new DAL.DataSet_SandTableAdapters.SelectSandMaterialUsageRangeDateTableAdapter();
     //       return adp.GetData(xPieces_,xDateFrom,xDateTo);
     //   }
     //   #endregion


     //   public bool SandMaterialUsage(int shift_, string xDate, int xPieces_, int xBantonit, int xSandNew,
     //int xCoalDust, int xWater, int xBatchCount, int xSandReturn, int xOther, string xOtherName
     //    , string xReportMechanical, string xReportElectric, string xReportOther, string xComment)
     //   {
     //       DAL.DataSet_SandTableAdapters.mSandMaterialUsageTableAdapter adp =
     //           new DAL.DataSet_SandTableAdapters.mSandMaterialUsageTableAdapter();
     //       adp.Insert(shift_, xDate, xPieces_, xBantonit, xSandNew, xCoalDust, xWater, xBatchCount, xSandReturn, xOther, xOtherName
     //           , xReportMechanical, xReportElectric, xReportOther, xComment);
     //       return true;
     //   }


     //   #region report SandDailyReport

        public DataTable SelectSandDailyReport(string xDateFrom, string xDateTo)
        {
            DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportTableAdapter adp
                = new DAL.Sand.DataSet_SandDailyReportTableAdapters.SelectSandDailyReportTableAdapter();
            return adp.GetData(xDateFrom, xDateTo);
        }

        #endregion




        public DataTable SelectChartData(string dateFrom, string dateTo)
        {
            DAL.DataSet_SandTableAdapters.SelectSandReportByDateTableAdapter adp
                = new DAL.DataSet_SandTableAdapters.SelectSandReportByDateTableAdapter();

            return adp.GetData(dateFrom, dateTo);

        }
        public DataTable ControlParameter(string ParamName)
        {
            DAL.DataSet_SandTableAdapters.mControlChartTableAdapter adp = new DAL.DataSet_SandTableAdapters.mControlChartTableAdapter();
            return adp.GetData(ParamName);
        }
        public DataTable SandControlParameter()
        {
            DAL.DataSet_SandTableAdapters.mSandControlChartTableAdapter adp = new DAL.DataSet_SandTableAdapters.mSandControlChartTableAdapter();
            return adp.GetData();
        }
        public DataTable SelectSandSieveValue()
        {
            DAL.DataSet_SandTableAdapters.mSandSieveValueTableAdapter adp = new
             DAL.DataSet_SandTableAdapters.mSandSieveValueTableAdapter();
            return adp.GetData();
        }
        public bool InsertSandWeeklyTest(string xDate,
                         decimal xDiameterBefore11,
                         decimal xDiameterBefore10,
                         decimal xDiameterBefore9,
                         decimal xDiameterBefore8,
                         decimal xDiameterBefore7,
                         decimal xDiameterBefore6,
                         decimal xDiameterBefore5,
                         decimal xDiameterBefore4,
                         decimal xDiameterBefore3,
                         decimal xDiameterBefore2,
                         decimal xDiameterBefore1,
                         decimal xDiameterAfter11,
                         decimal xDiameterAfter10,
                         decimal xDiameterAfter9,
                         decimal xDiameterAfter8,
                         decimal xDiameterAfter7,
                         decimal xDiameterAfter6,
                         decimal xDiameterAfter5,
                         decimal xDiameterAfter4,
                         decimal xDiameterAfter3,
                         decimal xDiameterAfter2,
                         decimal xDiameterAfter1,
                         decimal xAfsBefore,
                         decimal xAfsAfter,
                         decimal xVolatilePercent,
                         decimal xBurningPercent,
                         decimal xGlayPercent,
                         decimal xActiveBentnitePercent,
                         decimal xPermeability,
                         int xApprove_,
                         bool xApproved,
                         string xComment,int xGenGroup_)
        {
            DAL.DataSet_SandTableAdapters.mSandWeeklyTestTableAdapter adp
             = new DAL.DataSet_SandTableAdapters.mSandWeeklyTestTableAdapter();
            int? Apr = null;
            if (BLL.authentication.xApproveby_ == BLL.authentication.x_)
            {
                Apr = BLL.authentication.xApproveby_;
            }
            adp.Insert(xDate, xDiameterBefore11, xDiameterBefore10, xDiameterBefore9, xDiameterBefore8, xDiameterBefore7, xDiameterBefore6, xDiameterBefore5, xDiameterBefore4,
                          xDiameterBefore3, xDiameterBefore2, xDiameterBefore1, xDiameterAfter11, xDiameterAfter10, xDiameterAfter9, xDiameterAfter8, xDiameterAfter7, xDiameterAfter6,
                          xDiameterAfter5, xDiameterAfter4, xDiameterAfter3, xDiameterAfter2, xDiameterAfter1, xAfsBefore, xAfsAfter, xVolatilePercent, xBurningPercent, xGlayPercent,
                          xActiveBentnitePercent, xPermeability, Apr, BLL.authentication.x_, xComment, xGenGroup_);

            return true;
        }
    }
}
