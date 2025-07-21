using System;

namespace PAYAIND.ObjectTable
{
    public  class ObjectTable
    {
       public PAYADATA.ObjectDevice.DataSet_ObjectDevice.mObjectTableDataTable objecttable()
       {
           PAYADATA.ObjectDevice.DataSet_ObjectDeviceTableAdapters.mObjectTableTableAdapter adp
                = new PAYADATA.ObjectDevice.DataSet_ObjectDeviceTableAdapters.mObjectTableTableAdapter();
           return adp.GetData();
       }

       public string Udobjecttable(PAYADATA.ObjectDevice.DataSet_ObjectDevice.mObjectTableDataTable dt)
       {
           try
           {
               PAYADATA.ObjectDevice.DataSet_ObjectDeviceTableAdapters.mObjectTableTableAdapter adp
                    = new PAYADATA.ObjectDevice.DataSet_ObjectDeviceTableAdapters.mObjectTableTableAdapter(); 
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
