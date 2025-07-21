using System;

namespace BLL.Mold
{
    public class csMold
    {
        public DAL.Mold.DataSet_Mold.mMoldRecordActionsDataTable mMoldRecordActions(int xMold_)
        {
            DAL.Mold.DataSet_MoldTableAdapters.mMoldRecordActionsTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.mMoldRecordActionsTableAdapter();
            return adp.GetData(xMold_);
        }
        public string UdMoldRecordActions(DAL.Mold.DataSet_Mold.mMoldRecordActionsDataTable dt)
        {

            try
            {
                DAL.Mold.DataSet_MoldTableAdapters.mMoldRecordActionsTableAdapter adp =
                    new DAL.Mold.DataSet_MoldTableAdapters.mMoldRecordActionsTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
        public DAL.Mold.DataSet_Mold.SlMoldActivitiesByMold_RDataTable SlMoldActivitiesByMold_R(int xMold_)
        {
            DAL.Mold.DataSet_MoldTableAdapters.SlMoldActivitiesByMold_RTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.SlMoldActivitiesByMold_RTableAdapter();
            return adp.GetData(xMold_);
        }
        public DAL.Mold.DataSet_Mold.SlMoldListByPieces_RDataTable SlMoldListByPieces_R(int xPieces_)
        {
            DAL.Mold.DataSet_MoldTableAdapters.SlMoldListByPieces_RTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.SlMoldListByPieces_RTableAdapter();
            return adp.GetData(xPieces_);
        }
        public DAL.Mold.DataSet_Mold.SlMoldActivitiesDataTable SlMoldActivities(string DateFrom,string DateTo)
        {
            DAL.Mold.DataSet_MoldTableAdapters.SlMoldActivitiesTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.SlMoldActivitiesTableAdapter();
            return adp.GetData(DateFrom,DateTo);
        }

        public string UdMoldActivities(DAL.Mold.DataSet_Mold.SlMoldActivitiesDataTable dt)
        {

            try
            {
                DAL.Mold.DataSet_MoldTableAdapters.SlMoldActivitiesTableAdapter adp =
                    new DAL.Mold.DataSet_MoldTableAdapters.SlMoldActivitiesTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public DAL.Mold.DataSet_Mold.SlMoldList_RDataTable SlMoldList_R()
        {
            DAL.Mold.DataSet_MoldTableAdapters.SlMoldList_RTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.SlMoldList_RTableAdapter();
            return adp.GetData();
        }


        public DAL.Mold.DataSet_Mold.SlMoldCountGrByMoldCodeDataTable SlMoldCountGrByMoldCode(string DateFrom, string DateTo)
        {
            DAL.Mold.DataSet_MoldTableAdapters.SlMoldCountGrByMoldCodeTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.SlMoldCountGrByMoldCodeTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.Mold.DataSet_Mold.SlMoldCountDataTable mMoldCount(string DateFrom,string DateTo)
        {
            DAL.Mold.DataSet_MoldTableAdapters.SlMoldCountTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.SlMoldCountTableAdapter();
            return adp.GetData( DateFrom, DateTo);
        }




        public string UdMoldCount(DAL.Mold.DataSet_Mold.SlMoldCountDataTable dt)
        {

            try
            {
                DAL.Mold.DataSet_MoldTableAdapters.SlMoldCountTableAdapter adp =
                                new DAL.Mold.DataSet_MoldTableAdapters.SlMoldCountTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public DAL.Mold.DataSet_Mold.MoldComboDataTable MoldCombo(int? xPieces_)
        {
            DAL.Mold.DataSet_MoldTableAdapters.MoldComboTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.MoldComboTableAdapter();
            return adp.GetData(xPieces_);
        }



        public DAL.Mold.DataSet_Mold.mMoldListDataTable mMoldList(int Pieces_)
        {
            DAL.Mold.DataSet_MoldTableAdapters.mMoldListTableAdapter adp =
                new DAL.Mold.DataSet_MoldTableAdapters.mMoldListTableAdapter();
            return adp.GetData(Pieces_);
        }

        public string UdMoldList(DAL.Mold.DataSet_Mold.mMoldListDataTable dt)
        {

            try
            {
                DAL.Mold.DataSet_MoldTableAdapters.mMoldListTableAdapter adp =
                    new DAL.Mold.DataSet_MoldTableAdapters.mMoldListTableAdapter();
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
