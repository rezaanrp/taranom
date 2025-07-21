using System;

namespace PAYAIND
{
    public  class csevent
   {
       PAYADATA.data_eventDataContext db = new PAYADATA.data_eventDataContext();
       public bool eventlogin(string xEventType, string xEventCode,
           string xDetails, string xUserId)
       {
          try
           {
               PAYAIND.csshamsidateandtime datesh = new PAYAIND.csshamsidateandtime();
               string Date = datesh.calcshmsidate();
               string time = "" +
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
               PAYADATA.Tableevent tb = new PAYADATA.Tableevent();
               tb.xdate= Date;
               tb.xtime= time ;
               tb.xevent= xEventType;
               tb.xipmashin= localIP;
               tb.xmashinname= Machinename;
               tb.xusername= xUserId;
               db.Tableevents.InsertOnSubmit(tb);
               db.SubmitChanges();              
               return true;
           }
          catch (Exception)
           {

               return false;
           }
       }
    }
}
