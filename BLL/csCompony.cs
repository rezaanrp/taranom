using System;
using System.Data;
namespace BLL
{
    public  class csCompony
    {
       public DataTable SelectCompony()
       {
           DAL.DataSet_ComponyTableAdapters.SelectComponyTableAdapter adp =
               new DAL.DataSet_ComponyTableAdapters.SelectComponyTableAdapter();
           return adp.GetData();
       }
       public DataTable SelectCustomer()
       {
           DAL.DataSet_ComponyTableAdapters.SelectCustomerTableAdapter adp =
               new DAL.DataSet_ComponyTableAdapters.SelectCustomerTableAdapter();
           return adp.GetData();
       }
       public DataTable SelectSupplier()
       {
           DAL.DataSet_ComponyTableAdapters.SelectSupplierTableAdapter adp
               = new DAL.DataSet_ComponyTableAdapters.SelectSupplierTableAdapter();
           return adp.GetData();
       }

       public bool SyncCustomer()
       {
           try
           {
               DAL.DataSet_ComponyTableAdapters.QueriesTableAdapter adp
                   = new DAL.DataSet_ComponyTableAdapters.QueriesTableAdapter();
               adp.SyncCustomer();
               return true;
           }
           catch (Exception)
           {

               return false;
           }

       }


        #region Company

           public DAL.DataSet_Compony.SlCompanyByNameDataTable SlCompanyByName(string ComponyName)
           {
               DAL.DataSet_ComponyTableAdapters.SlCompanyByNameTableAdapter
                   adp = new DAL.DataSet_ComponyTableAdapters.SlCompanyByNameTableAdapter();

              return adp.GetData(ComponyName);
           }

           public bool UdCompanyByName( DAL.DataSet_Compony.SlCompanyByNameDataTable dt)
           {
               try
               {
                   DAL.DataSet_ComponyTableAdapters.SlCompanyByNameTableAdapter
                                     adp = new DAL.DataSet_ComponyTableAdapters.SlCompanyByNameTableAdapter();
                   adp.Update(dt);
                   return true;
               }
               catch (Exception)
               {
                   return false;
               }

           }
        #endregion

    }
}
