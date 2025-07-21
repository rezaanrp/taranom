using System;

namespace BLL.ShotBlasting
{
    public  class csShotBlasting
    {
        public int fnStockShotBlastingPiecesInv(int xPieces_, string WorkYear, string DateTo)
        {
            DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.QueriesTableAdapter adp
                = new DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.QueriesTableAdapter();
            return (int)adp.fnStockShotBlastingPiecesInv(xPieces_ , WorkYear, DateTo );

        }
        public DAL.ShotBlasting.DataSet_ShotBlasting.SlStockAfterShotBlastingPiecesDataTable SlStockAfterShotBlastingPieces(string DateFrom, string DateTo, string WorkYear)
        {
            DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.SlStockAfterShotBlastingPiecesTableAdapter adp
                = new DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.SlStockAfterShotBlastingPiecesTableAdapter();
            return adp.GetData(DateFrom, DateTo, WorkYear);

        }
        public DAL.ShotBlasting.DataSet_ShotBlasting.SlStockShotBlastingPiecesDataTable SlStockShotBlastingPieces(string DateFrom, string DateTo, string WorkYear)
        {
            DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.SlStockShotBlastingPiecesTableAdapter adp
                = new DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.SlStockShotBlastingPiecesTableAdapter();
            return adp.GetData(DateFrom, DateTo, WorkYear);

        }
        public DAL.ShotBlasting.DataSet_ShotBlasting.mShotBlastingInspectionDataTable mShotBlastingInspection(string DateFrom, string DateTo)
        {
            DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingInspectionTableAdapter adp
                = new DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingInspectionTableAdapter();
            return adp.GetData(DateFrom, DateTo);

        }

        public string UdShotBlastingInspection(DAL.ShotBlasting.DataSet_ShotBlasting.mShotBlastingInspectionDataTable dt)
        {
            try
            {
                DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingInspectionTableAdapter adp
                                = new DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingInspectionTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

        public DAL.ShotBlasting.DataSet_ShotBlasting.mShotBlastingPiceseDataTable mShotBlastingPicese(string DateFrom, string DateTo)
        {
            DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingPiceseTableAdapter adp
                = new DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingPiceseTableAdapter();
            return adp.GetData(DateFrom, DateTo);

        }

        public string UdShotBlastingPicese(DAL.ShotBlasting.DataSet_ShotBlasting.mShotBlastingPiceseDataTable dt)
        {
            try
            {
                DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingPiceseTableAdapter adp
                    = new DAL.ShotBlasting.DataSet_ShotBlastingTableAdapters.mShotBlastingPiceseTableAdapter();
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
