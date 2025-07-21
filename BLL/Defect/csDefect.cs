using System;

namespace BLL.Defect
{
    public class csDefect
    {

       public DAL.Defect.DataSet_DefectList.mDefectListCauseMachiningDataTable mDefectListCauseMachining(int? xDefectListTypeMachining_)
        {
            DAL.Defect.DataSet_DefectListTableAdapters.mDefectListCauseMachiningTableAdapter
            adp = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListCauseMachiningTableAdapter();
            return adp.GetData(xDefectListTypeMachining_);

        }
       public string UdDefectListCauseMachining(DAL.Defect.DataSet_DefectList.mDefectListCauseMachiningDataTable dt)
        {
            try
            {
                DAL.Defect.DataSet_DefectListTableAdapters.mDefectListCauseMachiningTableAdapter
                adp = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListCauseMachiningTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }


       public DAL.Defect.DataSet_DefectList.mDefectListTypeMachiningDataTable mDefectListTypeMachining()
        {
            DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTypeMachiningTableAdapter
            adp = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTypeMachiningTableAdapter();
            return adp.GetData();

        }
       public string UdDefectListTypeMachining(DAL.Defect.DataSet_DefectList.mDefectListTypeMachiningDataTable dt)
        {
            try
            {
                DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTypeMachiningTableAdapter
                adp = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTypeMachiningTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }


       public DAL.Defect.DataSet_DefectList.mDefectListMachiningDataTable mDefectListMachining(int? xPieces_)
        {
            DAL.Defect.DataSet_DefectListTableAdapters.mDefectListMachiningTableAdapter
            adp = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListMachiningTableAdapter();
            return adp.GetData(xPieces_);

        }
       public string UdDefectListMachining(DAL.Defect.DataSet_DefectList.mDefectListMachiningDataTable dt)
        {


            try
            {
                DAL.Defect.DataSet_DefectListTableAdapters.mDefectListMachiningTableAdapter
                adp = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListMachiningTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

       public DAL.Defect.DataSet_DefectList.mDefectListDataTable mDefectList()
       {
           DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTableAdapter
           adp   = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTableAdapter();
           return adp.GetData();

       }
       public string UdDefectList(DAL.Defect.DataSet_DefectList.mDefectListDataTable dt) 
       {


           try
           {
               DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTableAdapter
               adp = new DAL.Defect.DataSet_DefectListTableAdapters.mDefectListTableAdapter();
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
