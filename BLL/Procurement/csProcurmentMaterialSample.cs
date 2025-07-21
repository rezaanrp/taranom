using System;

namespace BLL.Procurement
{
    public  class csProcurmentMaterialSample
    {
      public DAL.Procurement.DataSet_ProcurmentMaterialSampleReceipt.SlProcurmentMaterialSampleReceiptDataTable SlProcurmentMaterialSampleReceipt(int x_)
      {
          DAL.Procurement.DataSet_ProcurmentMaterialSampleReceiptTableAdapters.SlProcurmentMaterialSampleReceiptTableAdapter adp
              = new DAL.Procurement.DataSet_ProcurmentMaterialSampleReceiptTableAdapters.SlProcurmentMaterialSampleReceiptTableAdapter();
          return adp.GetData(x_);
      }
        public DAL.Procurement.DataSet_ProcurmentMaterialSample.SlProcurmentMaterialSampleDataTable SLProcurmentMaterialSample(string DateFrom,string DateTo,string Section)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialSampleTableAdapters.SlProcurmentMaterialSampleTableAdapter adp
                = new DAL.Procurement.DataSet_ProcurmentMaterialSampleTableAdapters.SlProcurmentMaterialSampleTableAdapter();
          return  adp.GetData(DateFrom, DateTo, Section);
        }
        public string UdProcurmentMaterialSample(DAL.Procurement.DataSet_ProcurmentMaterialSample.SlProcurmentMaterialSampleDataTable dt)
        {
            try
            {
                DAL.Procurement.DataSet_ProcurmentMaterialSampleTableAdapters.SlProcurmentMaterialSampleTableAdapter adp
                    = new DAL.Procurement.DataSet_ProcurmentMaterialSampleTableAdapters.SlProcurmentMaterialSampleTableAdapter();
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
