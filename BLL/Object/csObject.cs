using System;
using System.Data;

namespace BLL.Object
{
    public class csObject
    {

       public DAL.Object.DataSet_Object.mObjectListDataTable mObjectList()
       {
           DAL.Object.DataSet_ObjectTableAdapters.mObjectListTableAdapter adp =
               new DAL.Object.DataSet_ObjectTableAdapters.mObjectListTableAdapter();
           return adp.GetData();
       }

       public string UdmObjectList(DAL.Object.DataSet_Object.mObjectListDataTable dt)
       {
           try
           {
               DAL.Object.DataSet_ObjectTableAdapters.mObjectListTableAdapter adp =
                   new DAL.Object.DataSet_ObjectTableAdapters.mObjectListTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {

               return e.Message;
           }

       }

       public DAL.Object.DataSet_Object.mObjectTreeAccessDataTable SlObjectTreeAccess(int xUser_,int xGroup_)
       {
           DAL.Object.DataSet_ObjectTableAdapters.mObjectTreeAccessTableAdapter adp =
               new DAL.Object.DataSet_ObjectTableAdapters.mObjectTreeAccessTableAdapter();
           return adp.GetData(xUser_,xGroup_);      
       }

       public DAL.Object.DataSet_Object.mObjectDataTable SlObject()
       {
           DAL.Object.DataSet_ObjectTableAdapters.mObjectTableAdapter adp = 
               new DAL.Object.DataSet_ObjectTableAdapters.mObjectTableAdapter();
           return adp.GetData();
       }
       public DataRow SlObjectNameById(int x_)
       {
           DAL.Object.DataSet_ObjectTableAdapters.mObjectByIDTableAdapter adp =
               new DAL.Object.DataSet_ObjectTableAdapters.mObjectByIDTableAdapter();
             DataTable dt = adp.GetData( x_);
             if (dt.Rows.Count > 0)
             {
                 return dt.Rows[0];
             }
             else
                 return null;

       }
       public DAL.Object.DataSet_Object.mObjectTreeDataTable SlObjectTree()
       {
           DAL.Object.DataSet_ObjectTableAdapters.mObjectTreeTableAdapter adp =
               new DAL.Object.DataSet_ObjectTableAdapters.mObjectTreeTableAdapter();
           return adp.GetData();
       }
       public bool UdObjectTree( DAL.Object.DataSet_Object.mObjectTreeDataTable dt)
       {
          
           DAL.Object.DataSet_ObjectTableAdapters.mObjectTreeTableAdapter adp =
               new DAL.Object.DataSet_ObjectTableAdapters.mObjectTreeTableAdapter();
            adp.DeleteALL();
            adp.Update(dt);
            new DAL.Object.DataSet_ObjectTableAdapters.DlObjectTreeDuplicateTableAdapter().GetData();
            return true;
       }
    }
}
