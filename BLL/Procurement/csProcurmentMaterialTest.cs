using System;

namespace BLL.Procurement
{
    public class csProcurmentMaterialTest
    {
        public DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestDataTable SlProcurmentMaterialTest(string DateFrom, string DateTo, string Section)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestTableAdapter adp =
                new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestTableAdapter();
            return adp.GetData(DateFrom, DateTo, Section);
        }
        public string UdProcurmentMaterialTest(DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestDataTable dt)
        {
            try
            {
                DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestTableAdapter adp =
                       new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

        public DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestAnalysisDataTable SlProcurmentMaterialTestAnalysis(int? xProcurmentMaterialTest_, bool IsBefore)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestAnalysisTableAdapter adp =
                new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestAnalysisTableAdapter();
            return adp.GetData(xProcurmentMaterialTest_,IsBefore);
        }


        public string UdProcurmentMaterialTestAnalysis(DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestAnalysisDataTable dt)
        {
            try
            {
                DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestAnalysisTableAdapter adp =
                       new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestAnalysisTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

        public System.Data.DataTable SlProcurmentMaterialTestReport(int x_)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestReportTableAdapter adp =
                new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestReportTableAdapter();
            return adp.GetData(x_);
        }
        public System.Data.DataTable SlProcurmentMaterialTestReportTR(int x_)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestReportTRTableAdapter adp =
                new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestReportTRTableAdapter();
            return adp.GetData(x_);
        }
        public System.Data.DataTable SlProcurmentMaterialTestRp(string DateFrom, string DateTo)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestRpTableAdapter adp =
                new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialTestRpTableAdapter();
            return adp.GetData( DateFrom,  DateTo);
        }
        public System.Data.DataTable SlProcurmentMaterialSuStu(string DateFrom, string DateTo)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialSuStuTableAdapter adp =
                new DAL.Procurement.DataSet_ProcurmentMaterialTestTableAdapters.SlProcurmentMaterialSuStuTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
       
    }
}
