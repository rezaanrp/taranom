using System;

namespace BLL.Procurement
{
    public  class csProcurmentMaterialTurning
    {
      public DAL.Procurement.DataSet_ProcurmentMaterialTurning.mProcurmentMaterialTurningDataTable mProcurmentMaterialTurning(string DateFrom, string DateTo)
        {
            DAL.Procurement.DataSet_ProcurmentMaterialTurningTableAdapters.mProcurmentMaterialTurningTableAdapter adp =
                new DAL.Procurement.DataSet_ProcurmentMaterialTurningTableAdapters.mProcurmentMaterialTurningTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
      public string UdProcurmentMaterialTurning(DAL.Procurement.DataSet_ProcurmentMaterialTurning.mProcurmentMaterialTurningDataTable dt)
        {
            try
            {
                DAL.Procurement.DataSet_ProcurmentMaterialTurningTableAdapters.mProcurmentMaterialTurningTableAdapter adp =
                    new DAL.Procurement.DataSet_ProcurmentMaterialTurningTableAdapters.mProcurmentMaterialTurningTableAdapter();
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
