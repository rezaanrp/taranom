using System;
using System.Net.NetworkInformation;
using System.Net;

namespace DAL
{
    public class csConnectionTest
    {

       public bool testConnection()
       {
           try
           {
               var conn = new System.Data.OleDb.OleDbConnection("Provider=SQLOLEDB;" + global::DAL.Properties.Settings.Default.PayazobConnectionString);

               Ping x = new Ping();
               PingReply reply = x.Send(IPAddress.Parse(conn.DataSource.Split(',')[0]), 2000);

               if (reply.Status == IPStatus.Success)
                   return true;
               else
                   return false;
           }
           catch (Exception)
           {

               return false;
           }

       }


   
    }
}
