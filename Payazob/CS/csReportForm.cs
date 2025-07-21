namespace Payazob.CS
{
    public class csReportForm
    {
        public System.Data.DataTable OpenForm(string st)
        {
            System.Data.DataTable dt;
            switch (st)
            {
  
                case "SalePlan":
                    dt = new System.Data.DataTable();
                    break;
                default:
                    dt = new System.Data.DataTable();
                    break;
            }
            return dt;
        }
        public string DateFrom;
        public string DateTo;

    }
}
