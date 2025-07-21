using System;
using System.Data;

namespace BLL
{
    public class csMaterial
    {
      public  enum MaterilaType1
       {
           masrafi = 58, ghoraze = 59 ,mavadekore = 60,lavazememeni = 61, abzar = 203
       }

      public DataTable mMaterialForLocation()
      {
          DAL.DataSet_MaterialTableAdapters.mMaterialForLocationTableAdapter adp
               = new DAL.DataSet_MaterialTableAdapters.mMaterialForLocationTableAdapter();
          return adp.GetData();
      }


       public bool SyncMaterial()
       {
           try
           {
               DAL.DataSet_MaterialTableAdapters.QueriesTableAdapter adp
                   = new DAL.DataSet_MaterialTableAdapters.QueriesTableAdapter();
               adp.SyncMaterial();
               return true;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public bool SyncScarb()
       {
           try
           {
               DAL.DataSet_MaterialTableAdapters.QueriesTableAdapter adp
                   = new DAL.DataSet_MaterialTableAdapters.QueriesTableAdapter();
               adp.SyncScarb();
               return true;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public DataTable SelectMeltName(int GenType1,int GenType2,bool All)
       {
           DAL.DataSet_MaterialTableAdapters.SelectMaterialTypeTableAdapter adp =
               new DAL.DataSet_MaterialTableAdapters.SelectMaterialTypeTableAdapter();

           return adp.GetData( GenType1, GenType2, All);
       }
       public DataTable SlectMatreilAndScarb()
       {
           DAL.DataSet_MaterialTableAdapters.SlMaterialAndScarbTableAdapter adp =
               new DAL.DataSet_MaterialTableAdapters.SlMaterialAndScarbTableAdapter();

           return adp.GetData();
       }

       /// <summary>
       /// اگر A ارسال شود تما رکورد ها لرسال می شود
       /// </summary>
       /// <param name="Ch"></param>
       /// <returns></returns>
       public DAL.DataSet_Material.SlMaterialDataTable SlMaterial(string Ch,int MaterilaType)
       {

           DAL.DataSet_MaterialTableAdapters.SlMaterialTableAdapter  adp =
               new DAL.DataSet_MaterialTableAdapters.SlMaterialTableAdapter();
           return adp.GetData(Ch, MaterilaType);
       }


       
       public string UdMaterial(DAL.DataSet_Material.SlMaterialDataTable dt)
       {
           try
           {
               DAL.DataSet_MaterialTableAdapters.SlMaterialTableAdapter adp =
                   new DAL.DataSet_MaterialTableAdapters.SlMaterialTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";

           }
           catch (Exception e)
           {

               return e.Message;
           }

       }

       /// <summary>
       ///واحد مواد اولیه
       /// </summary>
       /// <param name="Ch"></param>
       /// <returns></returns>
       public DAL.DataSet_Material.SlModuleDataTable SlModule()
       {

           DAL.DataSet_MaterialTableAdapters.SlModuleTableAdapter adp =
               new DAL.DataSet_MaterialTableAdapters.SlModuleTableAdapter();
           return adp.GetData();
       }


    }
}
