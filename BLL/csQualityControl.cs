using System.Data;
namespace BLL
{
    public class csQualityControl
    {

        #region روند ضایعات در سال به صورت کلی
            public DAL.QualityControl.DataSet_PruductInspection.SlPruductInspectionByMonthTotalDataTable SlPruductInspectionByMonthTotal(string year)
            {
                DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SlPruductInspectionByMonthTotalTableAdapter adp =
                     new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SlPruductInspectionByMonthTotalTableAdapter();
                return adp.GetData(year);
            }
        #endregion

        #region روند ضایعات

        public DAL.DataSet_QualityControl.SlPruductInspectionflowDataTable SlPruductInspectionflow(string DateFrom, string DateTo)
        {
            DAL.DataSet_QualityControlTableAdapters.SlPruductInspectionflowTableAdapter adp =
                 new DAL.DataSet_QualityControlTableAdapters.SlPruductInspectionflowTableAdapter();
            return adp.GetData( DateFrom,  DateTo);
        }


        #endregion

        #region  تخریب قطعه
        public bool InsertDestructionReport(DataTable dt)
        {
            DAL.DataSet_QualityControlTableAdapters.mDestructionReportTableAdapter adp =
                new DAL.DataSet_QualityControlTableAdapters.mDestructionReportTableAdapter();


            foreach (DataRow item in dt.Rows)
            {
                bool flag;
                if ((string)item["xResult"] == "سالم")
                    flag = true;
                else
                    flag = false;

                if ((string)item["xResult"] != "سایر")
                {
                    flag = (string)item["xResult"] == "سالم" ? true : false;
                    adp.Insert(BLL.csshamsidate.shamsidate,
                     (int?)item["xShift_"],
                     BLL.csshamsidate.ShamsiDateAndDayOfYear((decimal)item["Year"], (decimal)item["DateOfYear"]),
                     (int?)item["xPiceces_"],
                     (int?)item["xCount"],
                     (string)item["xGrindingPlace"],
                     (decimal?)item["xDepth"],
                     flag,
                     (string)item["xComment"],
                    BLL.authentication.x_);
                }

                else
                {
                    adp.Insert(BLL.csshamsidate.shamsidate,
                    (int)item["xShift_"],
                    BLL.csshamsidate.ShamsiDateAndDayOfYear((decimal)item["Year"], (decimal)item["DateOfYear"]),
                    (int)item["xPiceces_"],
                    (int)item["xCount"],
                    (string)item["xGrindingPlace"],
                    (decimal)item["xDepth"],
                     null,
                    (string)item["xComment"],
                    BLL.authentication.x_);
                }
            }

            return true;
        }

        public bool UpdateDestructionReport(DAL.DataSet_QualityControl.SelectDestructionReportByDateDataTable dt)
        {
            DAL.DataSet_QualityControlTableAdapters.SelectDestructionReportByDateTableAdapter adp =
                new DAL.DataSet_QualityControlTableAdapters.SelectDestructionReportByDateTableAdapter();
            adp.Update(dt);
            return true;
        }

        public DAL.DataSet_QualityControl.SelectDestructionReportByDateDataTable SelectDestructionReportByDate(string DateFrom,string DateTo)
        {
            DAL.DataSet_QualityControlTableAdapters.SelectDestructionReportByDateTableAdapter adp =
                new DAL.DataSet_QualityControlTableAdapters.SelectDestructionReportByDateTableAdapter();

            return adp.GetData(DateFrom, DateTo);
        }
        #endregion

        #region گزارش مواد مذاب کوره

        public bool InsertMeltReport(DataTable dt)
        {
            DAL.DataSet_QualityControlTableAdapters.mQualityControlMeltReportTableAdapter adp
                = new DAL.DataSet_QualityControlTableAdapters.mQualityControlMeltReportTableAdapter();
            
            foreach (DataRow item in dt.Rows)
            {

                adp.Insert(BLL.csshamsidate.shamsidate, (string)item["xTime"], (int?)item["xPiceces_"], (int?)item["xShift_"], byte.Parse(item["xFernesNumber"].ToString()), BLL.csshamsidate.ShamsiDateAndDayOfYear((decimal)item["Year"], (decimal)item["xDayNumber"]), (string)item["xStandard"], (string)item["xLadel"],
                        BLL.authentication.x_, (decimal)item["Fe"], (decimal)item["C"], (decimal)item["Si"], (decimal)item["Mn"], (decimal)item["P"], (decimal)item["S"], (decimal)item["Cr"],
                        (decimal)item["Mo"], (decimal)item["Ni"], (decimal)item["Al"], (decimal)item["Co"], (decimal)item["Cu"], (decimal)item["Mg"], (decimal)item["Nb"], (decimal)item["Ti"], (decimal)item["V"], (decimal)item["Sn"], (decimal)item["B"], (decimal)item["Zr"], (decimal)item["As"], (decimal)item["Ce"]);
            }

            return true;
        }

        public DataTable SelectMeltReportByDate(string DateFrom,string DateTo)
        {
            DAL.DataSet_QualityControlTableAdapters.mQualityControlMeltReportByDateTableAdapter adp
                = new DAL.DataSet_QualityControlTableAdapters.mQualityControlMeltReportByDateTableAdapter();
            DataTable dt = adp.GetData(DateFrom, DateTo);
            return dt;
        }
        #endregion

  

    }
}
