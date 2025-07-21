using System;

namespace BLL.Reproduct
{
    public class csReproduct
    {
        public DAL.Reproduct.DataSet_Reproduct.mReproductCastingDataTable mReproductCasting(string DateFrom, string DateTo)
        {
            DAL.Reproduct.DataSet_ReproductTableAdapters.mReproductCastingTableAdapter adp =
                new DAL.Reproduct.DataSet_ReproductTableAdapters.mReproductCastingTableAdapter();
            return adp.GetData(DateFrom,  DateTo);
        }
        public string udReproductCasting(DAL.Reproduct.DataSet_Reproduct.mReproductCastingDataTable dt)
        {
            try
            {
                DAL.Reproduct.DataSet_ReproductTableAdapters.mReproductCastingTableAdapter adp =
                    new DAL.Reproduct.DataSet_ReproductTableAdapters.mReproductCastingTableAdapter();
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
