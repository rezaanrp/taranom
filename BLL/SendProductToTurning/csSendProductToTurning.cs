using System;

namespace BLL.SendProductToTurning
{
    public  class csSendProductToTurning
    {
      public DAL.SendProductToTurning.DataSet_SendProductToTurning.SlSendProductToTurning_RDataTable SlSendProductToTurning_R(string DateFrom, string DateTo)
      {
          DAL.SendProductToTurning.DataSet_SendProductToTurningTableAdapters.SlSendProductToTurning_RTableAdapter adp
              = new DAL.SendProductToTurning.DataSet_SendProductToTurningTableAdapters.SlSendProductToTurning_RTableAdapter();
          return adp.GetData(DateFrom, DateTo);

      }
        public DAL.SendProductToTurning.DataSet_SendProductToTurning.mSendProductToTurningDataTable mSendProductToTurning(string DateFrom, string DateTo)
        {
            DAL.SendProductToTurning.DataSet_SendProductToTurningTableAdapters.mSendProductToTurningTableAdapter adp
                = new DAL.SendProductToTurning.DataSet_SendProductToTurningTableAdapters.mSendProductToTurningTableAdapter();
            return adp.GetData(DateFrom, DateTo);

        }

        public string UdSendProductToTurning(DAL.SendProductToTurning.DataSet_SendProductToTurning.mSendProductToTurningDataTable dt)
        {
            try
            {
                DAL.SendProductToTurning.DataSet_SendProductToTurningTableAdapters.mSendProductToTurningTableAdapter adp
                    = new DAL.SendProductToTurning.DataSet_SendProductToTurningTableAdapters.mSendProductToTurningTableAdapter();
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
