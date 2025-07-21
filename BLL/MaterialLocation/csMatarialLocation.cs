namespace BLL.MaterialLocation
{
    public class csMatarialLocation
    {
       public DAL.MaterialLocation.DataSet_MaterialLocation.mMaterialLocationDataTable mMaterialLocation()
        {
            DAL.MaterialLocation.DataSet_MaterialLocationTableAdapters.mMaterialLocationTableAdapter adp =
                new DAL.MaterialLocation.DataSet_MaterialLocationTableAdapters.mMaterialLocationTableAdapter();
            return adp.GetData();
        }

        //public string UdModelPieces(DAL.Model.DataSet_Model.SlModelPiecesDataTable dt)
        //{

        //    try
        //    {
        //        DAL.Model.DataSet_ModelTableAdapters.SlModelPiecesTableAdapter adp =
        //            new DAL.Model.DataSet_ModelTableAdapters.SlModelPiecesTableAdapter();
        //        adp.Update(dt);
        //        return "عملیات ذخیره سازی با موفقیت انجام شد";
        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}
    }
}
