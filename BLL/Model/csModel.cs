using System;

namespace BLL.Model
{
    public class csModel
    {
       public DAL.Model.DataSet_Model.SlModelPiecesDataTable SlModelPieces()
       {
           DAL.Model.DataSet_ModelTableAdapters.SlModelPiecesTableAdapter adp =
               new DAL.Model.DataSet_ModelTableAdapters.SlModelPiecesTableAdapter();
           return adp.GetData();
       }

       public string UdModelPieces(DAL.Model.DataSet_Model.SlModelPiecesDataTable dt)
       {

           try
           {
               DAL.Model.DataSet_ModelTableAdapters.SlModelPiecesTableAdapter adp =
                   new DAL.Model.DataSet_ModelTableAdapters.SlModelPiecesTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {

               return e.Message;
           }
       }

       public DAL.Model.DataSet_Model.SlModelDataTable SlModel( int Pieces_)
        {
            DAL.Model.DataSet_ModelTableAdapters.SlModelTableAdapter adp =
                new  DAL.Model.DataSet_ModelTableAdapters.SlModelTableAdapter();
            return adp.GetData(Pieces_);
        }

       public string UdModel(DAL.Model.DataSet_Model.SlModelDataTable dt)
        {

            try
            {
                DAL.Model.DataSet_ModelTableAdapters.SlModelTableAdapter adp =
                    new DAL.Model.DataSet_ModelTableAdapters.SlModelTableAdapter(); 
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
