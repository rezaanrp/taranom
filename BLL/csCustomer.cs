using System.Data;
namespace BLL
{
    public  class csCustomer
    {
      public DataTable SelectCustomer()
      {
          DAL.DataSet_ComponyTableAdapters.SelectCustomerTableAdapter adp =
              new DAL.DataSet_ComponyTableAdapters.SelectCustomerTableAdapter();
          return adp.GetData();
      }

    }
}
