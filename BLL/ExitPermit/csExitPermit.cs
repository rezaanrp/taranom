using System;

namespace BLL.ExitPermit
{
    public class csExitPermit
    {
       public DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitDataTable SlExitPermit(string DateFrom, string DateTo,int xSupplier_, int x_)
       {
           DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitTableAdapter adp =
               new DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitTableAdapter();
           return adp.GetData(DateFrom, DateTo,xSupplier_,x_);
       }
       public string UdExitPermit(DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitDataTable dt)
       {
           try
           {
               DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitTableAdapter adp =
                      new DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";

           }
           catch (Exception e)
           {

               return e.Message;
           }

       }

       //-----------------------------------
       public DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitBackDataTable SlExitPermitBack(int? xExitPermit_)
       {
           DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitBackTableAdapter adp =
               new DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitBackTableAdapter();
           return adp.GetData(xExitPermit_);
       }
       public string UdExitPermitBack(DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitBackDataTable dt)
       {
           try
           {
               DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitBackTableAdapter adp =
                      new DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitBackTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";

           }
           catch (Exception e)
           {

               return e.Message;
           }

       }
       public DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitRpDataTable SlExitPermitRp(string DateFrom, string DateTo)
       {
           DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitRpTableAdapter adp =
               new DAL.ExitPermit.DataSet_ExitPermitTableAdapters.SlExitPermitRpTableAdapter();
           return adp.GetData( DateFrom,  DateTo);
       }
       
    }
}
