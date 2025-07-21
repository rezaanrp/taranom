using System;

namespace BLL.Nonconforming
{
    public class csNonconforming
    {
       public DAL.NonConforming.DataSet_NonConforming.SlNonconformingDataTable SlNonconforming(string DateFrom,string DateTo)
       {
           DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingTableAdapter adp =
               new DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
       public string UdNonconforming(DAL.NonConforming.DataSet_NonConforming.SlNonconformingDataTable dt)
       {
           try
           {
               DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingTableAdapter adp =
                      new DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {

               return e.Message;
           }

       }

       public DAL.NonConforming.DataSet_NonConforming.SlNonconformingTypeDataTable SlNonconformingType()
       {
           DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingTypeTableAdapter adp =
               new DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingTypeTableAdapter();
           return adp.GetData();
       }

       public DAL.NonConforming.DataSet_NonConforming.SlNonconformingRpDataTable SlNonconformingTypeRp(string DateFrom, string DateTo,string Filter)
       {
           DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingRpTableAdapter adp =
               new DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingRpTableAdapter();
           return adp.GetData(Filter,DateFrom,DateTo);
       }

       public DAL.NonConforming.DataSet_NonConforming.SlNonconformingParentCountRpDataTable SlNonconformingParentCountRp(string DateFrom, string DateTo, int xPieces_)
       {
           DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingParentCountRpTableAdapter adp =
               new DAL.NonConforming.DataSet_NonConformingTableAdapters.SlNonconformingParentCountRpTableAdapter();
           return adp.GetData( DateFrom, DateTo,xPieces_);
       }
    }
}
