using System;

namespace BLL.BalanceBeginningMaterial
{
    public class csBalanceBeginningMaterial
    {
       public DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterial.mBalanceBeginningMaterialTuringDataTable mBalanceBeginningMaterialTuring(string Date)
        {
            DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.mBalanceBeginningMaterialTuringTableAdapter adp =
                 new DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.mBalanceBeginningMaterialTuringTableAdapter();
            return adp.GetData(Date);
        }

        public string UdmBalanceBeginningMaterialTuring(DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterial.mBalanceBeginningMaterialTuringDataTable dt)
        {
            try
            {
                DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.mBalanceBeginningMaterialTuringTableAdapter adp =
                     new DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.mBalanceBeginningMaterialTuringTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }  
       public DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterial.SlBalanceBeginningMaterialDataTable SlBalanceBeginningMaterial(string Date)
        {
            DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.SlBalanceBeginningMaterialTableAdapter adp =
                 new DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.SlBalanceBeginningMaterialTableAdapter();
            return adp.GetData(Date);
        }

       public string UdBalanceBeginningMaterial(DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterial.SlBalanceBeginningMaterialDataTable dt)
        {
            try
            {
                DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.SlBalanceBeginningMaterialTableAdapter adp =
                     new DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterialTableAdapters.SlBalanceBeginningMaterialTableAdapter();
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
