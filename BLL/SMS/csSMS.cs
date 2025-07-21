using System.Collections.Generic;

namespace BLL.SMS
{
    public class csSMS
    {
        public string SendSms(Dictionary<string,string> sms)
        {
            DAL.GenGroup.DataSet_GenGroupTableAdapters.SlGenGroupTableAdapter adp =
                 new DAL.GenGroup.DataSet_GenGroupTableAdapters.SlGenGroupTableAdapter();
                 ServiceReference1.ServiceSoapClient ss = new ServiceReference1.ServiceSoapClient();
                 string username = adp.GetData("SMSUSER")[0]["xName"].ToString();
                 string password = adp.GetData("SMSPASS")[0]["xName"].ToString();
                 string panelno = adp.GetData("SMSFROM")[0]["xName"].ToString();

                 foreach (var item in sms)
                 {
                     ss.SendSMS(username, password, item.Value, item.Key, panelno);
                 }
                 return  "";
        }
    }
}
