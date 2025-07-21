using System;

namespace BLL.Procurement
{
    public class csProcurmentMaterialToMachining
    {
       public DAL.Procurement.DataSet_ProcurmentMaterialToMachining.SlProcurmentMaterialToMachiningDataTable mProcurmentMaterialToMachining(string DateFrom, string DateTo)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialToMachiningTableAdapters.SlProcurmentMaterialToMachiningTableAdapter adp
                = new DAL.Procurement.DataSet_ProcurmentMaterialToMachiningTableAdapters.SlProcurmentMaterialToMachiningTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
       public string UdProcurmentMaterialToMachining(DAL.Procurement.DataSet_ProcurmentMaterialToMachining.SlProcurmentMaterialToMachiningDataTable dt)
        {
            try
            {
                DAL.Procurement.DataSet_ProcurmentMaterialToMachiningTableAdapters.SlProcurmentMaterialToMachiningTableAdapter adp
                    = new DAL.Procurement.DataSet_ProcurmentMaterialToMachiningTableAdapters.SlProcurmentMaterialToMachiningTableAdapter();
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
