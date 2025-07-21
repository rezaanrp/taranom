using System.Collections.Generic;

namespace BLL
{
    public class csReturnCustomer
    {
      public bool InsertCustomerReturn(int xCustomer_,int xPieces_,string xDateReturn,int xCount,string xDateProduct,
          string xResultReturn,string xCommnet,string xDescriptionAgreemental,bool xSupplier
               , bool xApprove, int xRegistringGroup_, List<byte[]> BMPList)
      {
           int? xc_ = 0;
           int? xI_ = 0;
          DAL.DataSet_ReturnCustomerTableAdapters.mReturnCostumerTableAdapter adp = new
           DAL.DataSet_ReturnCustomerTableAdapters.mReturnCostumerTableAdapter();
          adp.InsertReturnCustomer(xCustomer_, xPieces_, xDateReturn, xCount, xDateProduct,xResultReturn, xCommnet, xDescriptionAgreemental, xSupplier
              , xApprove, xRegistringGroup_,ref xc_);
          foreach (var item in BMPList)
          {
              DAL.DataSet_ImageTableAdapters.mImageAdrTableAdapter adpi = new DAL.DataSet_ImageTableAdapters.mImageAdrTableAdapter();
              adpi.InsertImageAddress(item, BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate, ref xI_);

              DAL.DataSet_ReturnCustomerTableAdapters.mReturnCustomerImageTableAdapter adpci =
              new DAL.DataSet_ReturnCustomerTableAdapters.mReturnCustomerImageTableAdapter();
              adpci.Insert(xI_, xc_);
          }
          return true;


      }
    }
}
