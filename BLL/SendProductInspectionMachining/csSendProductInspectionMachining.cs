using System;

namespace BLL.SendProductInspectionMachining
{
    public  class csSendProductInspectionMachining
    {
      public DAL.SendProductInspectionMachining.DataSet_SendProductInspectionMachining.mSendProductInspectionMachiningDataTable mSendProductInspectionMachining(string xDateFrom, string xDateTo)
        {
            DAL.SendProductInspectionMachining.DataSet_SendProductInspectionMachiningTableAdapters.mSendProductInspectionMachiningTableAdapter adp
                 = new DAL.SendProductInspectionMachining.DataSet_SendProductInspectionMachiningTableAdapters.mSendProductInspectionMachiningTableAdapter();
            return adp.GetData(xDateFrom, xDateTo);
        }
      public string UdSendProductInspectionMachining(DAL.SendProductInspectionMachining.DataSet_SendProductInspectionMachining.mSendProductInspectionMachiningDataTable dt)
        {
            try
            {
                DAL.SendProductInspectionMachining.DataSet_SendProductInspectionMachiningTableAdapters.mSendProductInspectionMachiningTableAdapter adp
                     = new DAL.SendProductInspectionMachining.DataSet_SendProductInspectionMachiningTableAdapters.mSendProductInspectionMachiningTableAdapter();
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
