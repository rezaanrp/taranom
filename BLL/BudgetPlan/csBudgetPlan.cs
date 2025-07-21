using System;

namespace BLL.BudgetPlan
{
    public  class csBudgetPlan
    {
      public DAL.BudgetPlan.DataSet_BudgetPlan.SlBudgetPlan_SalesPerformance_BySaleTypeDataTable SlBudgetPlan_SalesPerformance_BySaleType(string xYear, string xMonth, int FCT)
        {
            DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlan_SalesPerformance_BySaleTypeTableAdapter adp =
                new DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlan_SalesPerformance_BySaleTypeTableAdapter();
            return adp.GetData(xYear, xMonth,FCT);
        }


      public DAL.BudgetPlan.DataSet_BudgetPlan.SlBudgetPlan_SalesPerformance_RDataTable SlBudgetPlan_SalesPerformance_R(string xYear, string xMonth, int FCT)
        {
            DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlan_SalesPerformance_RTableAdapter adp =
                new DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlan_SalesPerformance_RTableAdapter();
            return adp.GetData(xYear, xMonth,FCT);
        }

      public DAL.BudgetPlan.DataSet_BudgetPlan.SlBudgetPlanDataTable SlBudgetPlan(string xYear,string xMonth,int FCT)
        {
            DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlanTableAdapter adp =
                new DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlanTableAdapter();
            return adp.GetData(xYear, xMonth,FCT);
        }

      public string UdBudgetPlan(DAL.BudgetPlan.DataSet_BudgetPlan.SlBudgetPlanDataTable dt)
        {
            try
            {
                DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlanTableAdapter adp =
                    new DAL.BudgetPlan.DataSet_BudgetPlanTableAdapters.SlBudgetPlanTableAdapter();
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
