using System;
using System.Data;
namespace BLL
{
    public class csCorrespondence
    {
        public DAL.DataSet_Correspondence.SlCorrespondenceDataTable SlCorrespondence(string DateFrom, string DateTo)
        {
            DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceTableAdapter adp =
                new DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public bool UdCorrespondence( DAL.DataSet_Correspondence.SlCorrespondenceDataTable dt)
        {
            DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceTableAdapter adp =
                new DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceTableAdapter();
             adp.Update(dt);
             return true;
        }

        public bool DelCorrespondenceImage(int x_)
        {
            DAL.DataSet_CorrespondenceTableAdapters.QueriesTableAdapter adp =
                new DAL.DataSet_CorrespondenceTableAdapters.QueriesTableAdapter();
            adp.DlCorrespondenceImage(x_);
            return true;
        }


        public bool InCorrespondenceImage(byte[] Image, int? Correspondence,string FileName)
        {
            try
            {
                DAL.DataSet_CorrespondenceTableAdapters.QueriesTableAdapter adp =
                             new DAL.DataSet_CorrespondenceTableAdapters.QueriesTableAdapter();
                adp.InCorrespondenceImage(Image, Correspondence,FileName);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool UdCorrespondenceImage(DAL.DataSet_Correspondence.SlCorrespondenceImageDataTable dt)
        {
            try
            {

                DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceImageTableAdapter adp =
                             new DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceImageTableAdapter();
                adp.Update(dt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public DataTable SlCorrespondenceImage(int? Correspondence)
        {
    
                DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceImageTableAdapter adp =
                             new DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceImageTableAdapter();
                return adp.GetData(Correspondence);
        }

        public byte[] SlCorrespondenceImageFile(int? x_)
        {

            DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceImageFileTableAdapter adp =
                         new DAL.DataSet_CorrespondenceTableAdapters.SlCorrespondenceImageFileTableAdapter();
            DataRow dr = adp.GetData(x_)[0];
            return (byte[])dr["xImage"];

        }

        //public DataTable SelectCorrespondenceInputNotResponce()
        //{
        //    DAL.DataSet_CorrespondenceTableAdapters.SelectCorrespondenceInputNotResponseTableAdapter adp =
        //        new DAL.DataSet_CorrespondenceTableAdapters.SelectCorrespondenceInputNotResponseTableAdapter();
        //    return adp.GetData();
        //}

        //public DataTable SelectCorrespondenceOutputNotResponce()
        //{
        //    DAL.DataSet_CorrespondenceTableAdapters.SelectCorrespondenceOutputNotResponceTableAdapter adp =
        //        new DAL.DataSet_CorrespondenceTableAdapters.SelectCorrespondenceOutputNotResponceTableAdapter();
        //    return adp.GetData();
        //}



        //public bool InsertCorrespondenceInput(string xInputDate,int?  xCustomer_,string xSubject,string xTo,string xComment,
        //    string xSerialNumber, List<byte[]> BMPList,int x_Responce)
        //{
        //    int? xI_ = 0;
        //    DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceInputTableAdapter adpI =
        //        new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceInputTableAdapter();
        //    int? xCustomer = xCustomer_ == -1 ? null : xCustomer_;
        //    adpI.InsertCorrespondenceInput(xInputDate, xCustomer, xSubject, xTo, xComment, xSerialNumber, ref xI_);
        //    int? xC_ = 0;

        //    foreach (var item in BMPList)
        //    {
        //        DAL.DataSet_ImageTableAdapters.mImageAdrTableAdapter adpi = new DAL.DataSet_ImageTableAdapters.mImageAdrTableAdapter();
        //        adpi.InsertImageAddress(item, BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate, ref xC_);

        //        DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceInputImageTableAdapter adpim =
        //            new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceInputImageTableAdapter();
        //        adpim.Insert(xC_, xI_);

        //    }
        //    if (x_Responce > 0)
        //    {
        //        DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter adpfi =
        //            new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter();
        //        adpfi.UpdateCorrespondenceInput(xI_, x_Responce);
        //    }
        //    else
        //    {
        //        DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter adpfi =
        //            new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter();
        //        adpfi.Insert(xI_,null);
        //    }
        //    return true;
        //}



        //public bool InsertCorrespondenceOutput(string xOutputDate, int? xUser_, int? xCompony_, string xSubject,
        //    string xTo, string xComment, string xSerialNumber, List<byte[]> BMPList, int x_Responce)
        //{
        //    int? xI_ = 0;

        //    int? xCompony = xCompony_ == -1 ? null : xCompony_;
        //    int? xUser = xUser_ == -1 ? null : xUser_;


        //    DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceOutputTableAdapter adpI =
        //        new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceOutputTableAdapter();
        //    adpI.InsertCorrespondenceOutput(xOutputDate,xUser, xCompony, xTo, xComment, xSerialNumber, xSubject ,ref xI_);
        //    int? xC_ = 0;

        //    foreach (var item in BMPList)
        //    {
        //        DAL.DataSet_ImageTableAdapters.mImageAdrTableAdapter adpi = new DAL.DataSet_ImageTableAdapters.mImageAdrTableAdapter();
        //        adpi.InsertImageAddress(item, BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate, ref xC_);

        //        DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceInputImageTableAdapter adpim =
        //            new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceInputImageTableAdapter();
        //        adpim.Insert(xC_, xI_);

        //    }
        //    if (x_Responce > 0)
        //    {
        //        DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter adpfi =
        //              new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter();
        //        adpfi.UpdateCorrespondenceOutput(xI_, x_Responce);
        //    }
        //    else
        //    {
        //        DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter adpfi =
        //            new DAL.DataSet_CorrespondenceTableAdapters.mCorrespondenceTableAdapter();
        //        adpfi.Insert(null,xI_ );
        //    }
        //    return true;
        //}
    }
}
