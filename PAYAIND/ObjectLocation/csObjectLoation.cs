using System;

namespace PAYAIND.ObjectLocation
{
    public class csObjectLoation
    {
       public PAYADATA.ObjectLocation.DataSet_ObjectLocation.SlObjectLocationDataTable mObjectLocation(string Lctin)
       {
           PAYADATA.ObjectLocation.DataSet_ObjectLocationTableAdapters.SlObjectLocationTableAdapter adp
               = new PAYADATA.ObjectLocation.DataSet_ObjectLocationTableAdapters.SlObjectLocationTableAdapter();
           return adp.GetData(Lctin);
       }
       public string UdObjectLocation(PAYADATA.ObjectLocation.DataSet_ObjectLocation.SlObjectLocationDataTable dt)
       {
           try
           {
               PAYADATA.ObjectLocation.DataSet_ObjectLocationTableAdapters.SlObjectLocationTableAdapter adp
                   = new PAYADATA.ObjectLocation.DataSet_ObjectLocationTableAdapters.SlObjectLocationTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {
               return e.Message;
           }

       }

       public string InObjectLocation(int xCount, string xCodeParent, int xObjectTable_, bool xNeedExtra, string xComment)
       {
           try
           {
               PAYADATA.ObjectLocation.DataSet_ObjectLocationTableAdapters.mObjectLocationTableAdapter adp
                   = new PAYADATA.ObjectLocation.DataSet_ObjectLocationTableAdapters.mObjectLocationTableAdapter();
               adp.Insert(xCount, xCodeParent, xObjectTable_, xNeedExtra, xComment);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {
               return e.Message;
           }

       }


    }
}
