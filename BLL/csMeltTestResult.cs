using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace BLL
{
  public  class csMeltTestResult
  {





      public bool InsertMeltTestResult(int xScrabName_,string xDateEnter,string xDateResult,string xDateTest,string xVisualCharacteristic,
          short xVisualScore,
            short  xExperimentalScore,short xMaximumScore,byte xAccept,byte xGradeProduct,bool xSupplier,
          bool? xApprove,int xSupplierCompany_,int xRegistringGroup_,int xUsage,int xUsageMeltingAmount,decimal xAbsorptionPercent,bool xIsScrab  ,DataTable dt,DataTable dt2 )
      {
          int? xApprove_ = null;
          if (xApprove == true)
              xApprove_ = BLL.authentication.x_;
          int? x_ = 0;
          DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.mCharacteristicMaterialPurchaseTableAdapter adp
              = new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.mCharacteristicMaterialPurchaseTableAdapter();
          adp.InsertCharacteristicMaterialPurchase( xScrabName_,xDateEnter,xDateResult,xDateTest,xVisualCharacteristic,xVisualScore,
              xExperimentalScore, xMaximumScore, xAccept, xGradeProduct, xSupplier, xApprove, xSupplierCompany_, null, xUsage, xUsageMeltingAmount, xAbsorptionPercent, xIsScrab, xApprove_, BLL.authentication.x_, ref x_);
          DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.mAnalysisMaterialTableAdapter adpanalysis =
              new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.mAnalysisMaterialTableAdapter();
          foreach (DataRow dr in dt.Rows)
          {

              adpanalysis.Insert( int.Parse(dr["x_"].ToString()), int.Parse(dr["ElementNumber"].ToString()) ,x_,true);
          }
          foreach (DataRow dr in dt2.Rows)
          {

              adpanalysis.Insert(int.Parse(dr["x_"].ToString()), int.Parse(dr["ElementNumber"].ToString()), x_,false);
          }
          return true;
      }

        #region گزارش
      public DataTable SelectMeltTestResultByDate(string DateFrom, string DateTo,bool xSupplier,bool xApprove,bool ShowAll)
      {
          DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultByDateTableAdapter
              adp = new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultByDateTableAdapter();
          return adp.GetData(DateFrom, DateTo,xSupplier,xApprove,ShowAll);
      }


      public DataTable SelectMeltTestResultByDate(string DateFrom, string DateTo, string[] filterlist, bool xSupplier, bool xApprove, bool ShowAll)
      {
          DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultByDateTableAdapter
              adp = new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultByDateTableAdapter();
          DataTable dt = adp.GetData(DateFrom, DateTo, true, true, true);
          string st = "";
            foreach (string item in filterlist)
            {
                st += " xSupplierCompany = '" + item + "' Or";
            }
           st = st.Remove(st.Length - 3);
           DataRow[] dr = dt.Select(st);
           if (dr.Length > 0)
           {
               DataTable dt1 = dr.CopyToDataTable();
               return dt1;
           }
           else
           {
               dt.Rows.Clear();
               return dt;
           }
      }


      public DataTable SelectMeltTestRSelectAnalysisMaterialByCharacteristicMaterialPurchaseByAfterAddTableAdapteresult(int xCharacteristicMaterialPurchase_)
      {
          DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectAnalysisMaterialByCharacteristicMaterialPurchaseTableAdapter
              adp = new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectAnalysisMaterialByCharacteristicMaterialPurchaseTableAdapter();
          return adp.GetData(xCharacteristicMaterialPurchase_);
      }



      public bool UpdateCharacteristicScarbPurchaseApprove(bool?[] approve ,int[] x_)
      {
          if (BLL.authentication.x_ == BLL.authentication.xApproveby_)
          {
              DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.UpdateCharacteristicScarbPurchase adp
                 = new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.UpdateCharacteristicScarbPurchase();
              for (int i = 0; i < x_.Length; i++)
              {
                  adp.UpdateCharacteristicMaterialPurchaseApprove(approve[i], BLL.authentication.x_, x_[i]);
              }
              return true;
          }

          else
          return false;
      }
/// <summary>
/// قراضه
/// </summary>
/// <param name="DateFrom"></param>
/// <param name="DateTo"></param>
/// <param name="xSupplier"></param>
/// <param name="xApprove"></param>
/// <param name="ShowAll"></param>
/// <returns></returns>
      public DataTable SelectMeltTestResultScrabByDate(string DateFrom, string DateTo, bool xSupplier, bool xApprove, bool ShowAll)
      {
          DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultScrabByDateTableAdapter
              adp = new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultScrabByDateTableAdapter();
          return adp.GetData(DateFrom, DateTo, xSupplier, xApprove, ShowAll);
      }

      public DataTable SelectMeltTestResultScrabByDate(string DateFrom, string DateTo, string[] filterlist, bool xSupplier, bool xApprove, bool ShowAll)
      {
          DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultScrabByDateTableAdapter
              adp = new DAL.CharacterusticMaterial.DataSet_MeltAdditiveTestResultTableAdapters.SelectMeltAdditiveTestResultScrabByDateTableAdapter();
          DataTable dt = adp.GetData(DateFrom, DateTo, true, true, true);
          string st = "";
          foreach (string item in filterlist)
          {
              st += " xSupplierCompany = '" + item + "' Or";
          }
          st = st.Remove(st.Length - 3);
          DataRow[] dr = dt.Select(st);
          if (dr.Length > 0)
          {
              DataTable dt1 = dr.CopyToDataTable();
              return dt1;
          }
          else
          {
              dt.Rows.Clear();
              return dt;
          }
      }

        #endregion


    }
}
