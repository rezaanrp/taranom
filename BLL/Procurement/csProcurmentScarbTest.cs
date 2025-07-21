using System;

namespace BLL.Procurement
{
    public class csProcurmentScarbTest
    {

      /// <summary>
      /// جهت استفاده در فرم گزار ش قراضه برای واحد مالی
      /// </summary>
      /// <param name="xMaterial_"></param>
      /// <returns></returns>
      public DAL.Procurement.DataSet_ProcurmentScarbTest.mProcurmentScarbTest_FNDataTable mProcurmentScarbTest_FN(int xMaterial_)
      {
          DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.mProcurmentScarbTest_FNTableAdapter adp =
              new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.mProcurmentScarbTest_FNTableAdapter();
          return adp.GetData(xMaterial_);
      }
      public DAL.Procurement.DataSet_ProcurmentScarbTest.SlProcurmentScarbTestDataTable SlProcurmentScarbTest(string DateFrom,string DateTo,string Section)
      {
          DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestTableAdapter adp =
              new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestTableAdapter();
          return adp.GetData(DateFrom, DateTo, Section);
      }
      public string UdProcurmentScarbTest(DAL.Procurement.DataSet_ProcurmentScarbTest.SlProcurmentScarbTestDataTable dt)
      {
          try
          {
              DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestTableAdapter adp =
                     new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestTableAdapter();
              adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";

          }
          catch (Exception e)
          {

              return e.Message;
          }

      }

      public DAL.Procurement.DataSet_ProcurmentScarbTest.SlProcurmentScarbTestAnalysisDataTable SlProcurmentScarbTestAnalysis(int? xProcurmentScarbTest_)
      {
          DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestAnalysisTableAdapter adp =
              new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestAnalysisTableAdapter();
          return adp.GetData(xProcurmentScarbTest_);
      }


      public string UdProcurmentScarbTestAnalysis(DAL.Procurement.DataSet_ProcurmentScarbTest.SlProcurmentScarbTestAnalysisDataTable dt)
      {
          try
          {
              DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestAnalysisTableAdapter adp =
                     new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestAnalysisTableAdapter();
              adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";

          }
          catch (Exception e)
          {

              return e.Message;
          }

      }

      public System.Data.DataTable SlProcurmentScarbTestReport(int x_)
      {
          DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestReportTableAdapter adp =
              new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestReportTableAdapter();
          return adp.GetData(x_);
      }

      public System.Data.DataTable SlProcurmentScarbTestRp(string DateFrom, string DateTo)
      {
          DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestRpTableAdapter adp =
              new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScarbTestRpTableAdapter();
          return adp.GetData(DateFrom,DateTo);
      }

      public System.Data.DataTable SlProcurmentScrabSuStu(string DateFrom, string DateTo)
      {
          DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScrabSuStuTableAdapter adp =
              new DAL.Procurement.DataSet_ProcurmentScarbTestTableAdapters.SlProcurmentScrabSuStuTableAdapter();
          return adp.GetData(DateFrom, DateTo);
      }
       
    }
}
