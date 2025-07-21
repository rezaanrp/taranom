using System;

namespace BLL.QualityControl
{
    public  class csProductInspectionMachining
    {
      
      public DAL.QualityControl.DataSet_PruductInspectionMachining_Report.SlProductInspectionMachiningDefectPrecentDataTable
                SlProductInspectionMachiningDefectPrecent(string Datefrom, string DateTo)
      {
          DAL.QualityControl.DataSet_PruductInspectionMachining_ReportTableAdapters.SlProductInspectionMachiningDefectPrecentTableAdapter adp =
               new DAL.QualityControl.DataSet_PruductInspectionMachining_ReportTableAdapters.SlProductInspectionMachiningDefectPrecentTableAdapter();
          return adp.GetData(Datefrom, DateTo);
      }
      public DAL.QualityControl.DataSet_PruductInspection.SlPruductInspectionMachiningCheckListDataTable
       SlPruductInspectionMachiningCheckList(string Datefrom, string DateTo)
      {
          DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SlPruductInspectionMachiningCheckListTableAdapter adp =
               new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SlPruductInspectionMachiningCheckListTableAdapter();
          return adp.GetData(Datefrom, DateTo);
      }


      public DAL.QualityControl.DataSet_PruductInspection.mProductInspectionMachiningDataTable 
          mProductInspectionMachining(string Datefrom,string DateTo)
        {
            DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningTableAdapter adp =
                 new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningTableAdapter();
            return adp.GetData(Datefrom,DateTo);
        }

      public string UdProductInspectionMachining(DAL.QualityControl.DataSet_PruductInspection.mProductInspectionMachiningDataTable dt)
        {
            try
            {
                DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningTableAdapter adp =
                     new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


      public DAL.QualityControl.DataSet_PruductInspection.mProductInspectionMachiningDetailsDataTable
        mProductInspectionMachiningDetails(int x_)
      {
          DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningDetailsTableAdapter adp =
               new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningDetailsTableAdapter();
          return adp.GetData(x_);
      }

      public string UdProductInspectionMachiningDetails(DAL.QualityControl.DataSet_PruductInspection.mProductInspectionMachiningDetailsDataTable dt)
      {
          try
          {
              DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningDetailsTableAdapter adp =
                   new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.mProductInspectionMachiningDetailsTableAdapter();
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
