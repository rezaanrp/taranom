using System;
using System.Data;
namespace BLL.PerFoodStatus
{
    public class csPerFoodStatus
    {
       public DAL.WinKart.DataSet_PerFoodStatus.SlPerFoodStatusListDataTable SlPerFoodStatusList(string DateFrom, string DateTo)
       {
           DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusListTableAdapter adp =
               new DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusListTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
       public DAL.WinKart.DataSet_PerFoodStatus.SlPerFoodStatusForTicketDataTable SlPerFoodStatusTickets(string DateFrom, string DateTo)
       {
           DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusForTicketTableAdapter adp =
               new DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusForTicketTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
       public DAL.WinKart.DataSet_Winkart.SlPerFoodCenterPriceDataTable SlPerFoodCenterPrice(string DateFrom, string DateTo)
       {
           DAL.WinKart.DataSet_WinkartTableAdapters.SlPerFoodCenterPriceTableAdapter adp =
               new DAL.WinKart.DataSet_WinkartTableAdapters.SlPerFoodCenterPriceTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
       public DAL.WinKart.DataSet_PerFoodStatus.SlPerFoodStatusDataTable SlPerFoodStatus(string DateFrom, string DateTo)
        {
            DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusTableAdapter adp =
                new DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
       public  DataTable SlPerson()
       {

           DAL.WinKart.DataSet_PerInfoTableAdapters.PersonTableAdapter adp =
               new DAL.WinKart.DataSet_PerInfoTableAdapters.PersonTableAdapter();
           DAL.WinKart.DataSet_PerInfo.PersonDataTable dt =
               new DAL.WinKart.DataSet_PerInfo.PersonDataTable();
           adp.Fill(dt);
           return dt;
       }
       public DataTable SlIOInfo()
       {
           DAL.WinKart.DataSet_PerInfoTableAdapters.IOInfoTableAdapter adp =
               new DAL.WinKart.DataSet_PerInfoTableAdapters.IOInfoTableAdapter();
           DAL.WinKart.DataSet_PerInfo.IOInfoDataTable dt =
               new DAL.WinKart.DataSet_PerInfo.IOInfoDataTable();
           adp.Fill(dt,  BLL.csshamsidate.shamsidate.Substring(5));
           return dt;
         //  return adp.GetData("12/21");
       }
       public string UdPerFoodStatus(DAL.WinKart.DataSet_PerFoodStatus.SlPerFoodStatusDataTable dt)
        {
            try
            {
                DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusTableAdapter adp =
                       new DAL.WinKart.DataSet_PerFoodStatusTableAdapters.SlPerFoodStatusTableAdapter();
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
