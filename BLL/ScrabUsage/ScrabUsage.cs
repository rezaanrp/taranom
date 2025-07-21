namespace BLL.ScrabUsage
{
    public class ScrabUsage
    {
      public DAL.ScarbUsage.DataSet_ScarbUsage.SlScrabUsageDataTable SlScrabUsage(string DateFrom, string DateTo,double? Waste,double? ferroalloy, string WorkYear)
      {
          DAL.ScarbUsage.DataSet_ScarbUsageTableAdapters.SlScrabUsageTableAdapter adp = new
           DAL.ScarbUsage.DataSet_ScarbUsageTableAdapters.SlScrabUsageTableAdapter();
          return adp.GetData(DateFrom, DateTo, Waste, ferroalloy,  WorkYear);
      }
    }
}
