using System;

namespace BLL.FIFO
{
    public class csInvMaterial
    {
       public DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialInputDataTable SlInvMaterialInput(string DateFrom, string DateTo)
        {

            DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialInputTableAdapter adp = 
                new DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialInputTableAdapter();
            //System.Data.SqlClient.SqlConnection cc = new System.Data.SqlClient.SqlConnection();
            //adp.Connection.Close();
            //adp.Connection = cc;
            //adp.Connection.Open();   
            //  chn(adp);
            return adp.GetData(DateFrom,DateTo); ;
        }

       
       public string UdInvMaterialInput(DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialInputDataTable dt)
        {
            try
            {
                DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialInputTableAdapter adp =
                      new DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialInputTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }


       public DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialMinusDataTable SlInvMaterialMinus(int? xInvMaterialInput_)
       {

           DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialMinusTableAdapter adp =
               new DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialMinusTableAdapter();
           return adp.GetData(xInvMaterialInput_);
       }


       public string UdInvMaterialMinus(DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialMinusDataTable dt)
       {
           try
           {
               DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialMinusTableAdapter adp =
                     new DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialMinusTableAdapter();
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
