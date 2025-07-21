using System;
using System.Data;

namespace BLL.SalePlan
{
    public class csSalePlanTurning
    {
       public DAL.SalePlan.DataSet_SalePlanTurning.SlSalePlanTurningForManagerDataTable SlSalePlanTurningForManager(string DateFrom, string DateTo)
        {
            DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningForManagerTableAdapter adp =
                 new DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningForManagerTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
       public DAL.SalePlan.DataSet_SalePlanTurning.SlSalePlanTurningStockDataTable SlSalePlanTurningStock(string WorkYear, string DateTo)
        {
            DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningStockTableAdapter adp =
                 new DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningStockTableAdapter();
            return adp.GetData(DateTo, WorkYear);
        }
        public DAL.SalePlan.DataSet_SalePlanTurning.SlSalePlanTurningDataTable SlSalePlan(string DateFrom, string DateTo, string Se)
        {
            DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningTableAdapter adp =
                 new DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningTableAdapter();
            return adp.GetData(DateFrom, DateTo, Se);
        }

        public string UdSalePlan(DAL.SalePlan.DataSet_SalePlanTurning.SlSalePlanTurningDataTable dt)
        {
            try
            {
                DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningTableAdapter adp =
                     new DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningTableAdapter(); 
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
            DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningPopUpTextTableAdapter adp =
                 new DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningPopUpTextTableAdapter();
            DataTable dt = adp.GetData(DateFrom, DateTo);
            foreach (DataRow item in dt.Rows)
            {
                txt += item.ItemArray[0].ToString() + "\r\n";
            }
            return txt;
        }
        public DataTable SlSalePlanTurningSummarize(string DateFrom, string DateTo, string WorkYear)
         {
              DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningSummarizeTableAdapter adp =
                   new DAL.SalePlan.DataSet_SalePlanTurningTableAdapters.SlSalePlanTurningSummarizeTableAdapter();
              return adp.GetData(DateFrom, DateTo,WorkYear);

         }
       

    }
}
