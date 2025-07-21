using System;

namespace BLL.ControlPrj
{
    public class csControlPrj
    {



       public DAL.ControlPrj.DataSet_ControlPrj.SlControlPrj_ReportManDataTable SlControlPrj_ReportMan()
        {
            DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrj_ReportManTableAdapter adp
                 = new DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrj_ReportManTableAdapter();
            return adp.GetData();
        }
       public DAL.ControlPrj.DataSet_ControlPrj.SlControlPrjDataTable SlControlPrj(int xUser_ ,string DateFrom ,string DateTo)
        {
            DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjTableAdapter adp
                 = new DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjTableAdapter();
            return adp.GetData(xUser_ ,DateFrom, DateTo);
        }

       public string UdControlPrj(DAL.ControlPrj.DataSet_ControlPrj.SlControlPrjDataTable dt)
       {
           try
           {
               DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjTableAdapter adp
                    = new DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {

               return e.Message;
           }

       }


       public DAL.ControlPrj.DataSet_ControlPrj.SlControlPrjDetailsDataTable SlControlPrjDetails(int x_)
       {
           DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjDetailsTableAdapter adp
                = new DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjDetailsTableAdapter();
           return adp.GetData(x_);
       }

       public string UdControlPrjDetails(DAL.ControlPrj.DataSet_ControlPrj.SlControlPrjDetailsDataTable dt)
       {
           try
           {
               DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjDetailsTableAdapter adp
                    = new DAL.ControlPrj.DataSet_ControlPrjTableAdapters.SlControlPrjDetailsTableAdapter();
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
