using System;

namespace BLL.ProductOperation
{
    public  class csProductOperation
    {
      
     public DAL.ProductOperation.DataSet_ProductOperation.ProductOperationOpNameDataTable
           ProductOperationOpName(int? xPieces_)
      {
          DAL.ProductOperation.DataSet_ProductOperationTableAdapters.ProductOperationOpNameTableAdapter adp
               = new DAL.ProductOperation.DataSet_ProductOperationTableAdapters.ProductOperationOpNameTableAdapter();
          return adp.GetData(xPieces_);
      }

     public DAL.ProductOperation.DataSet_ProductOperation.mProductOperationDataTable
           ProductOperation(int xPieces_)
      {
          DAL.ProductOperation.DataSet_ProductOperationTableAdapters.mProductOperationTableAdapter adp
               = new DAL.ProductOperation.DataSet_ProductOperationTableAdapters.mProductOperationTableAdapter();
          return adp.GetData(xPieces_);
      }

      public string UdProductOperation(DAL.ProductOperation.DataSet_ProductOperation.mProductOperationDataTable dt)
      {
          try
          {
              DAL.ProductOperation.DataSet_ProductOperationTableAdapters.mProductOperationTableAdapter adp
                   = new DAL.ProductOperation.DataSet_ProductOperationTableAdapters.mProductOperationTableAdapter();
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
