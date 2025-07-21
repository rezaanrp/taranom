using System.Data;
namespace BLL
{
    public class csProcurement
    {
        /// <summary>
        /// اجناس خارج شده
        /// </summary>
        /// <returns></returns>

        #region GoodsOUT

        public bool UpdateProcurementGoodsOut(DAL.DataSet_Procurement.SelectProcurementGoodsOutByDateDataTable dt)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurementGoodsOutByDateTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurementGoodsOutByDateTableAdapter();
            adp.Update(dt);
            return true;
        }
        
        public DataTable SelectProcurementGoodsNameOut()
        {
            DAL.DataSet_ProcurementTableAdapters.mProcurementGoodsTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.mProcurementGoodsTableAdapter();
            return adp.GetData();
        }

        public DataTable SelectProcurementPersonNameGoodsOut()
        {
            DAL.DataSet_ProcurementTableAdapters.mProcurementPersonNameGoodsOutTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.mProcurementPersonNameGoodsOutTableAdapter();
            return adp.GetData();
        }
        public DataTable SelectProcurementLicensorsNameGoodsOut()
        {
            DAL.DataSet_ProcurementTableAdapters.mProcurementLicensorsNameGoodsOutTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.mProcurementLicensorsNameGoodsOutTableAdapter();
            return adp.GetData();
        }

        public DataTable SelectMudole()
        {
            DAL.DataSet_ProcurementTableAdapters.mModuleTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.mModuleTableAdapter();
            return adp.GetData();
        }
        public bool fillProcurmentGoodsOut(DAL.DataSet_Procurement.mProcurementGoodsOutDataTable dt)
        {
            DAL.DataSet_ProcurementTableAdapters.mProcurementGoodsOutTableAdapter adp =
                new DAL.DataSet_ProcurementTableAdapters.mProcurementGoodsOutTableAdapter();
            adp.Fill(dt);
            return true;
        }
        /// <summary>
        /// درج اطلاعات اجناس خارج شده
        /// </summary>
        /// <param name="dt"> </param>
        /// <returns>  </returns>
        public bool InsertProcurmentGoodsOut(DataTable dt)
        {
            if (BLL.authentication.InsertData == false)
                return false;

            DAL.DataSet_ProcurementTableAdapters.mProcurementGoodsOutTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.mProcurementGoodsOutTableAdapter();
            foreach (DataRow item in dt.Rows)
            {
                adp.Insert(BLL.authentication.x_, (string)item["xShift"], (string)item["xDate"], (string)item["xGoods"], (decimal)item["xCount"],
                    (int)item["xModule_"], (string)item["xPersonNameGoodsOut"], (string)item["xCarNumber"], (string)item["xLicensorsName"], (string)item["xLicenseNumber"], (string)item["xComment"]);
            }
            return true;
        }
        public DAL.DataSet_Procurement.SelectProcurementGoodsOutByDateDataTable SelectProcurmentGoodsOutByDate(string xDateFrom, string xDateTo)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurementGoodsOutByDateTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurementGoodsOutByDateTableAdapter();
            return adp.GetData(xDateFrom, xDateTo);

        }

        public DataTable SelectProcurmentGoodsOutByDate(string xDateFrom, string xDateTo, string xGoods)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurementGoodsOutByDateAndXGoodsTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurementGoodsOutByDateAndXGoodsTableAdapter();
            return adp.GetData(xDateFrom, xDateTo,xGoods);
        }
        #endregion

        #region مواد اولیه ورودی
        




        public DataTable SelectMaterial()
        {
            DAL.DataSet_MaterialTableAdapters.mMaterialTableAdapter adp = new DAL.DataSet_MaterialTableAdapters.mMaterialTableAdapter();
            DataTable dt = adp.GetData();
            return dt;
        }

        public bool InsertProcurmentEnteryMaterial(DAL.DataSet_Procurement.SelectProcurmentEnteryMaterialDataTable dt)
        {

            if (!BLL.authentication.InsertData)
                return false;
            //DAL.DataSet_ProcurementTableAdapters.QueriesTableAdapter adp = 
            //    new DAL.DataSet_ProcurementTableAdapters.QueriesTableAdapter();

            //foreach (DataRow item in dt.Rows)
            //{
            //    adp.InsertProcurmentEnteryMaterial((string)item["xDate"], BLL.authentication.x_, (string)item["xShift"], 
            //        (int)item["xMaterialType_"],(int)item["xSupplier_"],(string)item["xDriverName"], (string)item["xDriverTel"], 
            //        (decimal)item["xWeightBeginning"],(int)item["xModule_"], (decimal)item["xWeightDestination"], (int)item["xRent"], 
            //        (string)item["xComment"]);
            //}

            DAL.DataSet_ProcurementTableAdapters.SelectProcurmentEnteryMaterialTableAdapter adp = 
                new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentEnteryMaterialTableAdapter();
            adp.Update(dt);
            return true;
        }

        public DataTable SelectProcurmentEnteryMaterialByDateAndMaterial(string xDateFrom, string xDateTo,string[] filterlist)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurmentEnteryMaterialByDateAndMaterialTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentEnteryMaterialByDateAndMaterialTableAdapter();
            DataTable dt = adp.GetData(xDateFrom, xDateTo);
            if ( !(filterlist.Length == 1 && filterlist[0] == "" ))
            {
                string st = "";
                foreach (string item in filterlist)
                {
                    st += " xMaterialType = '" + item + "' Or";
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
            else
            {
                return adp.GetData(xDateFrom, xDateTo);
            }

        }

        
        public DAL.DataSet_Procurement.SelectProcurmentEnteryMaterialDataTable SelectProcurmentEnteryMaterial(string xDateFrom, string xDateTo)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurmentEnteryMaterialTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentEnteryMaterialTableAdapter();
            //DataTable dt = adp.GetData(xDateFrom, xDateTo);
            return adp.GetData(xDateFrom, xDateTo);
        }

        #endregion

        #region فروش محصول


        public bool InsertProcurmentSalesProduct(DAL.DataSet_Procurement.SelectProcurmentSalesProductByDate1DataTable dt)
        {
            if (!BLL.authentication.InsertData)
                return false;
            //try
            //{
                DAL.DataSet_ProcurementTableAdapters.SelectProcurmentSalesProductByDate1TableAdapter adp =
                      new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentSalesProductByDate1TableAdapter();

                adp.Update(dt);
                return true;

            //}
            //catch (Exception)
            //{
            //    return false;
            //}
            //foreach (DataRow item in dt.Rows)
            //{
            //    adp.InsertProcurmentSalesProduct(BLL.authentication.x_, (string)item["xShift"], (string)item["xDate"], (string)item["xDarftNumber"], (int)item["xPieces_"], (string)item["xPackingType"],
            //        (int)item["xCount"], (int)item["xWeight"], (string)item["xDriverName"], (string)item["xDriverTel"], (string)item["xlicenseCar"], (int)item["xCustomer_"], false,
            //        (string)item["xComment"]);
            //}
        }


        public DAL.DataSet_Procurement.SelectProcurmentSalesProductByDate1DataTable SelectProcurmentSalesProductByDate(string xDateFrom, string xDateTo)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurmentSalesProductByDate1TableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentSalesProductByDate1TableAdapter();
            return adp.GetData(xDateFrom, xDateTo);
        }

        public DataTable SelectProcurmentSalesProductByDateAndPieces(string xDateFrom, string xDateTo, string[] filterlistGoods,string[] filterlistCustomer)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurmentSalesProductByDate1TableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentSalesProductByDate1TableAdapter();
            DataTable dt = adp.GetData(xDateFrom, xDateTo);

            string st = "";
            
            foreach (string item in filterlistGoods)
            {
                if (item != null)
                st += " xPieces = '" + item + "' Or";
            }
            if (st.Length > 0)
            {
                st = st.Remove(st.Length - 3);
                st += " AND (";
            }
            foreach (string item in filterlistCustomer)
            {
                if(item !=null)
                st += " xCustomer = '" + item + "' Or";
            }
            if (st == "")
                return dt;

            st = st.Remove(st.Length - 3);
            st += ")";

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

        public int MaxDraftNumbers()
        {
            DAL.DataSet_ProcurementTableAdapters.QueriesTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.QueriesTableAdapter();
            string st = (string)adp.ScalarQueryProcurmentMaxDraftNumber();
            if (st == null) return 0;
           return int.Parse(st);
        }

        #endregion

        #region میهمان
        //public bool insertProcumentGuest(DataTable dt)
        //{
        //    if (!BLL.authentication.InsertData)
        //        return false;
        //    DAL.DataSet_ProcurementTableAdapters.QueriesTableAdapter adp =
        //        new DAL.DataSet_ProcurementTableAdapters.QueriesTableAdapter();

        //    foreach (DataRow item in dt.Rows)
        //    {
        //        if (item["xComment"] == DBNull.Value)
        //            adp.InsertProcurmentGuest((string)item["xDate"], BLL.authentication.x_, (string)item["xName"], (string)item["xFamily"],
        //                (string)item["xEnter"], (string)item["xExit"], null);
        //        else
        //            adp.InsertProcurmentGuest((string)item["xDate"], BLL.authentication.x_, (string)item["xName"], (string)item["xFamily"],
        //           (string)item["xEnter"], (string)item["xExit"], (string)item["xComment"]);
        //    }
        //    return true;
        //}
        public DAL.DataSet_Procurement.SelectProcurmentGuestDataTable SelectProcumentGuest(string xDateFrom, string xDateTo)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurmentGuestTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentGuestTableAdapter();
            return adp.GetData(xDateFrom, xDateTo);
        }

        public bool UpdateProcumentGuest(DAL.DataSet_Procurement.SelectProcurmentGuestDataTable dt)
        {
            DAL.DataSet_ProcurementTableAdapters.SelectProcurmentGuestTableAdapter adp
                = new DAL.DataSet_ProcurementTableAdapters.SelectProcurmentGuestTableAdapter();
            adp.Update(dt);
            return true;
        }

        #endregion

    }
}
