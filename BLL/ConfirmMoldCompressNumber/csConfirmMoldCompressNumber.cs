using System;

namespace BLL.ConfirmMoldCompressNumber
{
    public  class csConfirmMoldCompressNumber
    {
        public DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumber.mConfirmMoldCompressNumberDataTable mConfirmMoldCompressNumber(string DateFrom, string DateTo)
        {
            DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumberTableAdapters.mConfirmMoldCompressNumberTableAdapter
                adp = new DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumberTableAdapters.mConfirmMoldCompressNumberTableAdapter();
            return adp.GetData(DateFrom,DateTo);
        }
        public string UdConfirmMoldCompressNumber(DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumber.mConfirmMoldCompressNumberDataTable dt)
        {
            try
            {
                DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumberTableAdapters.mConfirmMoldCompressNumberTableAdapter
                    adp = new DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumberTableAdapters.mConfirmMoldCompressNumberTableAdapter();
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
