using System;
using System.Data;

namespace BLL
{
    public class csFoundry
    {

        #region FoundryMaterialUsage گزارش

        public DataTable SlFoundryMaterialUsage(string DateFrom, string DateTo, string Type_)
            {
                DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryMaterialUsageTableAdapter adp =
                    new DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryMaterialUsageTableAdapter();
                return adp.GetData(DateFrom, DateTo,Type_);
            }
                public DAL.Foundry.DataSet_Foundry.SlFoundryMaterialUsageCheckDataTable SlFoundryMaterialUsageCheck(string DateFrom, string DateTo)
            {
                DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryMaterialUsageCheckTableAdapter adp =
                    new DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryMaterialUsageCheckTableAdapter();
                return adp.GetData(DateFrom, DateTo);
            }
        

        #endregion

        #region FoundryZinter

        public DAL.Foundry.DataSet_Foundry.SlFoundryZinterDataTable SlFoundryZinter(string DateFrom, string DateTo)
        {
            DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryZinterTableAdapter  adp =
                new DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryZinterTableAdapter();
            return adp.GetData(DateFrom, DateTo);

        }
        public bool UdFoundryZinter(DAL.Foundry.DataSet_Foundry.SlFoundryZinterDataTable dt)
        {
            try
            {
                DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryZinterTableAdapter adp =
               new DAL.Foundry.DataSet_FoundryTableAdapters.SlFoundryZinterTableAdapter();
                adp.Update(dt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        #endregion

        #region Foundry

                #region Foundry
                    public DAL.Foundry.DataSet_Foundry.SelectFoundryDetailsByDateDataTable SelectFoundryDetial(string DateFrom,string DateTo)
                    {
                        DAL.Foundry.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter adp = 
                            new DAL.Foundry.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter();
                        return  adp.GetData(DateFrom, DateTo);
            
                    }
                    public bool UpdateFoundryDetial(DAL.Foundry.DataSet_Foundry.SelectFoundryDetailsByDateDataTable dt)
                    {
                        try
                        {
                            DAL.Foundry.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter adp =
                           new DAL.Foundry.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter();
                            adp.Update(dt);
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;   
                        }
           
                    }
                #endregion

                #region FoundryOfMaterial
                    public DAL.Foundry.DataSet_Foundry.SelectMaterialOfFoundryDataTable SelectMaterialOfFoundryByxFoundry_(int xFoundry_, byte xNumberFurnace)
                    {
                        DAL.Foundry.DataSet_FoundryTableAdapters.SelectMaterialOfFoundryTableAdapter adp =
                            new DAL.Foundry.DataSet_FoundryTableAdapters.SelectMaterialOfFoundryTableAdapter();
                        return adp.GetData(xFoundry_, xNumberFurnace);
                    }
                    public string UpdateMaterialOfFoundry(DAL.Foundry.DataSet_Foundry.SelectMaterialOfFoundryDataTable dt)
                    {
                        try
                        {
                            DAL.Foundry.DataSet_FoundryTableAdapters.SelectMaterialOfFoundryTableAdapter adp =
                                  new DAL.Foundry.DataSet_FoundryTableAdapters.SelectMaterialOfFoundryTableAdapter();
                            adp.Update(dt);
                            return "عملیات ذخیره سازی با موفقیت انجام شد";

                        }
                        catch (Exception e)
                        {

                            return e.Message;
                        }

                    }
                #endregion


        #endregion

        public int? InsertFoundryDetails(string xDate, int xShift_, string xComment, bool xZinter, string xStartTime, string xEndTime,
            int xPieces_, int xCastedMold, int xReceivedMelt, int xTotalMelt, int xFowardMelt, int xSlagWeight, byte xFurnace)
        {
            if (BLL.authentication.InsertData == false)
                return null;
            DAL.DataSet_FoundryTableAdapters.QueriesTableAdapter adp = new DAL.DataSet_FoundryTableAdapters.QueriesTableAdapter();
            int? x_ = 0;
            adp.InsertFoundryDetails(xDate, xShift_, xComment, xZinter, xStartTime, xEndTime, xPieces_, xCastedMold, xReceivedMelt, xTotalMelt, xFowardMelt, xSlagWeight, xFurnace, ref x_);
            return x_;

        }

        //public static DAL.DataSet_FoundryTableAdapters.TableAdapterManager TableAdapterM(DAL.DataSet_FoundryTableAdapters.TableAdapterManager adp)
        //{
        //    adp.Connection.ConnectionString = "Data Source=PAYA-01;Initial Catalog=Payazob;Integrated Security=True";
        //    return adp;
        //}
        public bool InsertFoundryOfMaterial(int xFoundry_, int xMaterial_, decimal xMaterialAmount)
        {
            if (BLL.authentication.InsertData == false)
                return false;
            DAL.DataSet_FoundryTableAdapters.mMaterialOfFoundryTableAdapter adp = new DAL.DataSet_FoundryTableAdapters.mMaterialOfFoundryTableAdapter();
            adp.Insert(xFoundry_, xMaterial_, xMaterialAmount);
            return true;
        }

        public DataTable SelectFoundryDetailsTotalMeltByZinter(string DateFrom, string DateTo)
        {
            DAL.Foundry.DataSet_FoundryTableAdapters.SelectFoundryDetailsTotalMeltByZinterTableAdapter adp =
                new DAL.Foundry.DataSet_FoundryTableAdapters.SelectFoundryDetailsTotalMeltByZinterTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        //public DAL.DataSet_Foundry.SelectFoundryDetailsByDateDataTable SelectFoundryDetailsByDate(string DateFrom, string DateTo)
        //{
        //    DAL.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter adp =
        //        new DAL.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter();
        //    return adp.GetData(DateFrom, DateTo);
        //}

//public bool UpdateFoundryDetailsByDate(DAL.DataSet_Foundry.SelectFoundryDetailsByDateDataTable dt)
//{
//    try
//    {
//        DAL.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter adp =
//              new DAL.DataSet_FoundryTableAdapters.SelectFoundryDetailsByDateTableAdapter();
//        adp.Update(dt);
//        return true;
//    }
//    catch (Exception)
//    {

//        return false;
//    }

//}




    }
}

