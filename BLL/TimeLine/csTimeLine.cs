using System.Data;

namespace BLL.TimeLine
{
    public class csTimeLine
    {
        public bool InTimeLineMachine(string xTime,string xDate,bool  xLastStatus,int xMachine_)
        {
            DAL.TimeLine.DataSet_TimeLineMachineTableAdapters.QueriesTableAdapter Qr = new DAL.TimeLine.DataSet_TimeLineMachineTableAdapters.QueriesTableAdapter();
            Qr.InTimeLineMachine(xTime, xDate, xLastStatus, xMachine_);
            return true;
        }

        public DataTable SLTimeLineMachineForChart(string DateFrom,string DateTo,int Machine)
        {
            DAL.TimeLine.DataSet_TimeLineMachineTableAdapters.SlTimeLineMachineForChartTableAdapter adp = new DAL.TimeLine.DataSet_TimeLineMachineTableAdapters.SlTimeLineMachineForChartTableAdapter();
           return adp.GetData(DateFrom,DateTo,Machine);
        }
        public bool SlTimeLineMachineLastStatus(string Date, int Machine)
        {
            try
            {
                DAL.TimeLine.DataSet_TimeLineMachineTableAdapters.SlTimeLineMachineLastStatusTableAdapter adp = 
                    new DAL.TimeLine.DataSet_TimeLineMachineTableAdapters.SlTimeLineMachineLastStatusTableAdapter();
                DAL.TimeLine.DataSet_TimeLineMachine.SlTimeLineMachineLastStatusDataTable dt = adp.GetData(Date, Machine);

                if (dt.Rows.Count > 0)
                    return dt[0].xLastStatus;
                else
                    return false;

            }
            catch (System.Exception)
            {

                    return false;

            }

        }
    }
}
