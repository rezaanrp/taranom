using System;
using System.Data;
namespace BLL.SalePlan
{
    public class csSalePlan
    {

      public string[] SlSalePlanNotConfirm(string Ye,string Month_)
      {
          DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanNotConfirmTableAdapter adp =
               new DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanNotConfirmTableAdapter();
          DataTable dt = adp.GetData(Ye + "/" + Month_ + "/01", Ye + "/" + Month_ + "/31");
           int Cnt = dt.Rows.Count;
           string[] st = new string[dt.Rows.Count];
           for (int i = 0; i < Cnt; i++)
           {
               st[i] = int.Parse(dt.Rows[i]["xDate"].ToString().Substring(8, 2)).ToString();
           }
           return st;
      }
      public DAL.SalePlan.DataSet_SalePlan.SlSalePlan_ReportManDataTable SlSalePlan_ReportMan(string DateFrom, string DateTo)
      {
          DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlan_ReportManTableAdapter adp =
               new DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlan_ReportManTableAdapter();
          return adp.GetData(DateFrom, DateTo);
      }


      public DAL.SalePlan.DataSet_SalePlan.SlSalePlanNessaryTimeDataTable SlSalePlanNessaryTimeTableAdapter(string DateFrom, string DateTo)
      {
          DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanNessaryTimeTableAdapter adp =
               new DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanNessaryTimeTableAdapter();
          return adp.GetData(DateFrom, DateTo);
      }


      public DAL.SalePlan.DataSet_SalePlan.SlSalePlanDataTable SlSalePlan(string DateFrom, string DateTo,string Se)
      {
          DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanTableAdapter adp =
               new DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanTableAdapter();
          return adp.GetData( DateFrom, DateTo, Se);
      }

      public string UdSalePlan(DAL.SalePlan.DataSet_SalePlan.SlSalePlanDataTable dt)
      {
          try
          {
              DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanTableAdapter adp =
                   new DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanTableAdapter();
              adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";

          }
          catch (Exception e)
          {

              return e.Message;
          }

      }
      public string SlSalePlanPopUp(string DateFrom, string DateTo)
      {
          string txt = "";
          DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanPopUpTextTableAdapter adp =
               new DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanPopUpTextTableAdapter();
              DataTable dt = adp.GetData(DateFrom, DateTo);
              foreach (DataRow item in dt.Rows)
              {
                 txt += item.ItemArray[0].ToString() + "\r\n";
              }
              return txt;
      }

      public DataTable SlSalePlanSummarize(string DateFrom, string DateTo,string WorkYear)
      {
          DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanSummarizeTableAdapter adp =
               new DAL.SalePlan.DataSet_SalePlanTableAdapters.SlSalePlanSummarizeTableAdapter();
          return adp.GetData(DateFrom, DateTo,WorkYear);

      }

    }
}
