using System;

namespace BLL.CorrectiveAction
{
    public  class csCorrectiveAction
    {

        public DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionByUserDataTable mCorrectiveActionByUser(string DateFrom, string DateTo, int xToUser_)
        {
            DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionByUserTableAdapter
                adp = new DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionByUserTableAdapter();
            return adp.GetData( xToUser_);
        }
        public string UdCorrectiveActionByUse(string xDescription, string xResult,bool xIsFinish,int x_ )
        {
            try
            {
                DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.QueriesTableAdapter
                    adp = new DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.QueriesTableAdapter();
                adp.UdCorrectiveActionByUser(xDescription,xResult,xIsFinish,x_);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionDataTable mCorrectiveAction(string DateFrom , string DateTo , int Fct)
        {
            DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionTableAdapter
                adp = new DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionTableAdapter();
            return adp.GetData(DateFrom,DateTo, Fct);
        }
        public string UdCorrectiveAction(DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionDataTable dt)
        {
            try
            {
                DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionTableAdapter
                    adp = new DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

        public DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionDetailsDataTable mCorrectiveActionDetails(int x_,int xParent_)
        {
            DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionDetailsTableAdapter
                adp = new DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionDetailsTableAdapter();
            return adp.GetData(x_, xParent_);
        }
        public string UdCorrectiveActionDetails(DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionDetailsDataTable dt)
        {
            try
            {
                DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionDetailsTableAdapter
                    adp = new DAL.CorrectiveAction.DataSet_CorrectiveActionTableAdapters.mCorrectiveActionDetailsTableAdapter();
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
