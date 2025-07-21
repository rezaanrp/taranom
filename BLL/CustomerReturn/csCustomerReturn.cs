using System;
using System.Data;

namespace BLL.CustomerReturn
{
    public class csCustomerReturn
    {


       public DAL.CustomerReturn.DataSet_CustomerReturn.SlCustomerReturn_StatusDataTable SlCustomerReturn_Status(string DateFrom, string DateTo)
       {
           DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.SlCustomerReturn_StatusTableAdapter adp =
                new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.SlCustomerReturn_StatusTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
       public string GenCode(int? xCustomer, string xDateEnter)
       {
           DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.GenCodeTableAdapter adp =
                new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.GenCodeTableAdapter();
            DataRow dr = adp.GetData(xCustomer , xDateEnter)[0];

            return dr["count"].ToString() + "-" + dr["max"].ToString();
       }

       #region تصویر برگشت از مشتری

       public int CountStore(int x_)
        {
            DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter adp =
                 new DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter();
           return (int)adp.CountStore(x_);

        }
       
       public string DeleteQueryImage(int x_)
        {
            try
            {
                DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter adp =
     new DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter();
                 adp.DeleteQueryImage(x_);
                return "عملیات با موفقیت انجام شد";
            }
            catch (Exception)
            {
                return "خطا در حذف سند";
                
            }


        }
        public byte[] mCustomerReturnImage(int x_)
        {
            DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.mCustomerReturnImageTableAdapter adp =
                 new DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.mCustomerReturnImageTableAdapter();
            DAL.CustomerReturn.DataSet_CustomerReturnImage.mCustomerReturnImageDataTable dt = adp.GetData(x_);

            if (dt.Rows.Count > 0)
            {
                byte[] file = dt[0].xImage;
                return file;
            }
            else return null;

        }

       public string UdCustomerReturnImage(DAL.CustomerReturn.DataSet_CustomerReturnImage.mCustomerReturnImageDataTable dt)
        {
            try
            {
            DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.mCustomerReturnImageTableAdapter adp =
                 new DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.mCustomerReturnImageTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

       public string INCustomerReturnImage(byte[] xImage,int? xCustomerReturn_)
       {
           try
           {
               DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter adp =
                    new DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter();
               adp.InsertQuery(xImage,xCustomerReturn_);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {
               return e.Message;
           }
       }

       public string DlCustomerReturnImage(int? xCustomerReturn_)
       {
           try
           {
               DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter adp =
                    new DAL.CustomerReturn.DataSet_CustomerReturnImageTableAdapters.QueriesTableAdapter();
               adp.DeleteQuery(xCustomerReturn_);
               return "عملیات با موفقیت انجام شد";
           }
           catch (Exception e)
           {
               return e.Message;
           }
       }
       #endregion

       public DAL.CustomerReturn.DataSet_CustomerReturn.SlCustomerReturnScrapDataTable SlCustomerReturnScrap(int? x_, string Section_,int? Pieces)
        {
            DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.SlCustomerReturnScrapTableAdapter adp =
                 new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.SlCustomerReturnScrapTableAdapter();
            return adp.GetData(x_, Section_, Pieces);
        }

       public string UdCustomerReturnScrap(DAL.CustomerReturn.DataSet_CustomerReturn.SlCustomerReturnScrapDataTable dt/*,bool AddSendProduct*/)
        {
            try
            {
                DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.SlCustomerReturnScrapTableAdapter adp =
                     new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.SlCustomerReturnScrapTableAdapter();
                adp.Update(dt);


                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

       public DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnPiecesDataTable mCustomerReturnPieces(int x_)
        {
            DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnPiecesTableAdapter adp =
                 new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnPiecesTableAdapter();
            return adp.GetData(x_);
        }

       public string UdCustomerReturnPieces(DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnPiecesDataTable dt)
        {
            try
            {
                DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnPiecesTableAdapter adp =
                     new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnPiecesTableAdapter();
                adp.Update(dt);



                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

       public DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnDataTable mCustomerReturn(string DateFrom, string DateTo)
        {
            DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnTableAdapter adp =
                 new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnTableAdapter();
            return adp.GetData( DateFrom,  DateTo);
        }

       public string UdCustomerReturn(DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnDataTable dt)
        {
            try
            {
                DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnTableAdapter adp =
                     new DAL.CustomerReturn.DataSet_CustomerReturnTableAdapters.mCustomerReturnTableAdapter();
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
