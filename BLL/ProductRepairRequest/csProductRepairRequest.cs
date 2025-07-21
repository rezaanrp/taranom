using System;

namespace BLL.ProductRepairRequest
{
    public  class csProductRepairRequest
    {
      public DAL.ProductRepairRequest.DataSet_ProductRepairRequest.SlProductRepairRequestDataTable SlProductRepairRequest(string xDateFrom,string xDateTo,int xSupplier_,int x_)
      {
          DAL.ProductRepairRequest.DataSet_ProductRepairRequestTableAdapters.SlProductRepairRequestTableAdapter adp
              = new DAL.ProductRepairRequest.DataSet_ProductRepairRequestTableAdapters.SlProductRepairRequestTableAdapter();
          return adp.GetData(xDateFrom,xDateTo,xSupplier_,x_);
      }
      public string UdProductRepairRequest(DAL.ProductRepairRequest.DataSet_ProductRepairRequest.SlProductRepairRequestDataTable dt)
      {
          try
          {
              DAL.ProductRepairRequest.DataSet_ProductRepairRequestTableAdapters.SlProductRepairRequestTableAdapter adp
                  = new DAL.ProductRepairRequest.DataSet_ProductRepairRequestTableAdapters.SlProductRepairRequestTableAdapter();
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
