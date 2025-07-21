using System;

namespace BLL.RegEntExit
{
    public  class csRegEntExit
    {
      public DAL.RegEntExit.DataSet_RegEntExit.SlRegEntExitSearchDataTable SlRegEntExitSearch(string DateFrom, string DateTo, string Sch)
      {
          DAL.RegEntExit.DataSet_RegEntExitTableAdapters.SlRegEntExitSearchTableAdapter adp =
               new DAL.RegEntExit.DataSet_RegEntExitTableAdapters.SlRegEntExitSearchTableAdapter();
          return adp.GetData(DateFrom, DateTo, Sch);
      }

      public DAL.RegEntExit.DataSet_RegEntExit.mReEntExitTypeDetailDataTable mReEntExitTypeDetail(int x_)
        {
            DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mReEntExitTypeDetailTableAdapter adp =
                 new DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mReEntExitTypeDetailTableAdapter();
            return adp.GetData(x_);
        }

      public string UdmReEntExitTypeDetail(DAL.RegEntExit.DataSet_RegEntExit.mReEntExitTypeDetailDataTable dt)
        {
            try
            {
                DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mReEntExitTypeDetailTableAdapter adp =
                     new DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mReEntExitTypeDetailTableAdapter();
                adp.Update(dt);



                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }



        public DAL.RegEntExit.DataSet_RegEntExit.mRegEntExitTypeDataTable mRegEntExitType()
        {
            DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTypeTableAdapter adp =
                 new DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTypeTableAdapter();
            return adp.GetData();
        }

        public string UdmRegEntExitType(DAL.RegEntExit.DataSet_RegEntExit.mRegEntExitTypeDataTable dt)
        {
            try
            {
                DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTypeTableAdapter adp =
                     new DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTypeTableAdapter();
                adp.Update(dt);



                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.RegEntExit.DataSet_RegEntExit.mRegEntExitDataTable mRegEntExit(int xRegEntExitTypeDetail_, string DateFrom, string DateTo)
        {
            DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTableAdapter adp =
                 new DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTableAdapter();
            return adp.GetData(xRegEntExitTypeDetail_,DateFrom,DateTo);
        }

        public string UdmRegEntExit(DAL.RegEntExit.DataSet_RegEntExit.mRegEntExitDataTable dt)
        {
            try
            {
                DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTableAdapter adp =
                     new DAL.RegEntExit.DataSet_RegEntExitTableAdapters.mRegEntExitTableAdapter();
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
