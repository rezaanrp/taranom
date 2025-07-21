using System.Data;

namespace BLL.Marquee
{
    public class csMarquee
    {
       public string SlMarquee()
       {
           DAL.Marquee.DataSet_MarqueeTableAdapters.SlRptForMarqueeTableAdapter adp =
               new DAL.Marquee.DataSet_MarqueeTableAdapters.SlRptForMarqueeTableAdapter();
            DataTable dt =  adp.GetData(BLL.authentication.x_);
            return dt.Rows[0]["Rpt"].ToString();
       }
    }
}
