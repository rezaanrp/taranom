using System;

namespace BLL.NesPrcSPC
{
    public class csNesPrcSpc
    {
       public DAL.NesPrcSPC.DataSet_NesPrcSpc.mNesPrcSpcDataTable SlNesPrcSpc()
       {
           DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcTableAdapter adp =
               new DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcTableAdapter();
           return adp.GetData();
       }
       public string UdNesPrcSpc(DAL.NesPrcSPC.DataSet_NesPrcSpc.mNesPrcSpcDataTable dt)
       {
           try
           {
               DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcTableAdapter adp =
                   new DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {

               return e.Message;
           }

       }

       public DAL.NesPrcSPC.DataSet_NesPrcSpc.mNesPrcSpcDetialsDataTable SlNesPrcSpcDetail(int? xNesPrcSpc_,string DateFrom,string DateTo)
       {
           DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcDetialsTableAdapter adp =
               new DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcDetialsTableAdapter();
           return adp.GetData(xNesPrcSpc_);
       }
       public string UdNesPrcSpcDetail(DAL.NesPrcSPC.DataSet_NesPrcSpc.mNesPrcSpcDetialsDataTable dt)
       {
           try
           {
               DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcDetialsTableAdapter adp =
                   new DAL.NesPrcSPC.DataSet_NesPrcSpcTableAdapters.mNesPrcSpcDetialsTableAdapter();
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
