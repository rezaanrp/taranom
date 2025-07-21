using System.Data;
namespace BLL.Schedule
{
    public class csSchedule
    {
       public System.Data.DataTable SlSchedule(string DateNow)
       {
           DAL.Schedule.DataSet_ScheduleTableAdapters.SlScheduleTableAdapter adp = new DAL.Schedule.DataSet_ScheduleTableAdapters.SlScheduleTableAdapter();
           return adp.GetData(DateNow);
       }
       public bool InSchedule(string xDateExpire,string xIp,string xNetBiosName,string xMessage,
            bool? xTurnOff,bool? xRestart,bool? xClose,int? xUser_)
        {
            DAL.Schedule.DataSet_ScheduleTableAdapters.QueriesTableAdapter adp
                = new DAL.Schedule.DataSet_ScheduleTableAdapters.QueriesTableAdapter();
            adp.InSchedule(xDateExpire, xIp, xNetBiosName, xMessage, xTurnOff, xRestart, xClose, xUser_);
            return true;
        }
       public bool DlSchedule(string xDateExpire,int x_)
       {
           DAL.Schedule.DataSet_ScheduleTableAdapters.QueriesTableAdapter adp
               = new DAL.Schedule.DataSet_ScheduleTableAdapters.QueriesTableAdapter();
           adp.DlSchedule(xDateExpire,x_);
           return true;
       }
       public string message = "";
       public bool CloseApp = false;
       public bool CheakSchedule(ref int x_)
       {
          
            DataTable dt = SlSchedule(csshamsidate.shamsidate);
            int cnt = dt.Rows.Count;
            if (cnt > 0 && x_ != (int)dt.Rows[cnt - 1]["x_"])
            {
                message = dt.Rows[cnt - 1]["xMessage"].ToString();
                CloseApp = (bool)dt.Rows[cnt - 1]["xClose"];
                x_ = (int)dt.Rows[cnt - 1]["x_"];

                BLL.csEvent cc = new csEvent();
                cc.eventlogin("Schedule", "", "", "", BLL.authentication.userid);
                return true;
            }
            return false;
       }


    }
}
