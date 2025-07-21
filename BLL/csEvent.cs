using System;

namespace BLL
{
    public class csEvent
    {
       public bool eventlogin(string xEventType,string xEventCode,string xMessage,
           string xDetails,string xUserId)
       {
           try
           {

               BLL.csshamsidate date = new BLL.csshamsidate();
               BLL.csshamsidate.shamsidate = date.CalcShamsidate();
              // date.previousDay(7);

               string Date = BLL.csshamsidate.shamsidate;
               string time =   " -- " +
                   DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
               string Machinename = System.Environment.MachineName;
               System.Net.IPHostEntry host;
               string localIP = "?";
               host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
               foreach (System.Net.IPAddress ip in host.AddressList)
               {
                   if (ip.AddressFamily.ToString() == "InterNetwork")
                   {
                       localIP = ip.ToString();
                   }
               }
               if (xUserId != "51"  )
               {
                   DAL.DataSet_EventTableAdapters.mUsereventTableAdapter adp = new DAL.DataSet_EventTableAdapters.mUsereventTableAdapter();
                   adp.Insert(Date + time, xEventType, xEventCode, xMessage, Machinename, xDetails, localIP, xUserId);
                   int mo = int.Parse(Date.Substring(5, 2));
                   string month = mo == 1 ? "12" : (mo - 2) > 9 ? (mo - 2).ToString() : "0" + (mo - 2).ToString();


                   adp.DeleteUserevent(Date.Substring(0, 5) + month + Date.Substring(7, 3) + " -- 00:00:00");
               }
               return true;
           }
           catch (Exception)
           {

               return false;
           }

       }
    }
}
