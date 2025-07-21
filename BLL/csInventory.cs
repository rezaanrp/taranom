using System.Data;

namespace BLL
{
    public class csInventory
   {


       public DAL.inventory.DataSet_Inventory.SlProductPiecesVsPlanDataTable SlProductPiecesVsPlan(string DateFrom, string DateTo)
       {
           DAL.inventory.DataSet_InventoryTableAdapters.SlProductPiecesVsPlanTableAdapter adp
               = new DAL.inventory.DataSet_InventoryTableAdapters.SlProductPiecesVsPlanTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }

       public string QueryPiecesWeightTotal(string DateFrom, string DateTo)
            {
                DAL.inventory.DataSet_InventoryTableAdapters.QueriesTableAdapter adp
                    = new DAL.inventory.DataSet_InventoryTableAdapters.QueriesTableAdapter();
           decimal? de = adp.QueryPiecesWeightTotal(DateFrom, DateTo);
                return  de != null  ? de.ToString() : "";
            }

        #region موجودی انبار در تاریخ
       /// <summary>
       ///  موجودی انبار در تاریخ
       /// </summary>
       /// <param name="Datefrom"></param>
       /// <param name="DateTo"></param>
       /// <param name="WorkYear"></param>
       /// <returns></returns>
           public DataTable SlStockPieces(string Datefrom, string DateTo, string WorkYear)
           {
               DAL.inventory.DataSet_InventoryTableAdapters.SlStockPiecesTableAdapter 
                   adp = new DAL.inventory.DataSet_InventoryTableAdapters.SlStockPiecesTableAdapter();
               return adp.GetData(Datefrom, DateTo, WorkYear);
           }
       #endregion

        #region PiecesProuductTime

       public DAL.inventory.DataSet_Inventory.SlPiecesProuductTimeDataTable SlPiecesProuductTime(string DateFrom, string DateTo)
       {
           DAL.inventory.DataSet_InventoryTableAdapters.SlPiecesProuductTimeTableAdapter adp
               = new DAL.inventory.DataSet_InventoryTableAdapters.SlPiecesProuductTimeTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }

       #endregion

        #region MOLDINGSPEED

       public DAL.inventory.DataSet_Inventory.SlMoldingSpeedDataTable SlMoldingSpeed(string DateFrom, string DateTo)
        {
            DAL.inventory.DataSet_InventoryTableAdapters.SlMoldingSpeedTableAdapter adp
                = new DAL.inventory.DataSet_InventoryTableAdapters.SlMoldingSpeedTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        #endregion
       
        #region InventoryCheck
       public int InventoryCheck(string DateFrom, string DateTo, string WorkYear, int? Pieces_)
       {
           DAL.inventory.DataSet_InventoryTableAdapters.SlInventoryCheckTableAdapter adp
               = new DAL.inventory.DataSet_InventoryTableAdapters.SlInventoryCheckTableAdapter();
            DataTable dt = adp.GetData(DateFrom, DateTo, WorkYear, Pieces_);
          
            if (dt.Rows.Count > 0)
            {
                return (int)dt.Rows[0]["Inventory"];
            }
           else
            return 0;
       }   


        #endregion

        #region PiecesProductDetails

       public DAL.inventory.DataSet_Inventory.SelectPiecesProductDetialsMachiningDataTable SelectPiecesProuductDetailsMachining(int PiecesProuduct_)
       {
           DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsMachiningTableAdapter adp
               = new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsMachiningTableAdapter();
           return adp.GetData(PiecesProuduct_);
       }
       public int UpdatePiecesProductDetailsMachining(DAL.inventory.DataSet_Inventory.SelectPiecesProductDetialsMachiningDataTable dt)
       {
           DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsMachiningTableAdapter adp =
               new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsMachiningTableAdapter();
           adp.Update(dt);
           return 1;
       }
           public DAL.inventory.DataSet_Inventory.SelectPiecesProductDetialsDataTable SelectPiecesProuductDetails(int PiecesProuduct_)
            {
                DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsTableAdapter adp
                    = new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsTableAdapter();
                return adp.GetData(PiecesProuduct_);
            }
           public int UpdatePiecesProductDetails(DAL.inventory.DataSet_Inventory.SelectPiecesProductDetialsDataTable dt)
            {
                DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsTableAdapter adp =
                    new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductDetialsTableAdapter();
               adp.Update(dt);
               return 1;
            }
        #endregion

        #region PiecesProduct
           public DAL.inventory.DataSet_Inventory.SelectPiecesProuductMachiningDataTable SelectPiecesProuductMachining(string DateFrom, string DateTo)
           {
               DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductMachiningTableAdapter adp
                   = new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductMachiningTableAdapter();
               return adp.GetData(DateFrom, DateTo);
           }
           public int UpdatePiecesProductMachining(DAL.inventory.DataSet_Inventory.SelectPiecesProuductMachiningDataTable dt)
           {
               DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductMachiningTableAdapter adp =
                   new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductMachiningTableAdapter();
               return adp.Update(dt);
           }

           public DAL.inventory.DataSet_Inventory.SelectPiecesProuductDataTable SelectPiecesProuduct(string DateFrom, string DateTo)
            {
                DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductTableAdapter adp
                    = new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductTableAdapter();
                return adp.GetData(DateFrom, DateTo);
            }
            public int UpdatePiecesProduct(DAL.inventory.DataSet_Inventory.SelectPiecesProuductDataTable dt)
            {
                DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductTableAdapter adp =
                    new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProuductTableAdapter();
                return adp.Update(dt);
            }


            public DataTable SelectPiecesProductAndDetialMachining(string DateFrom, string DateTo, string WorkYear)
            {
                DAL.inventory.DataSet_InventoryMachiningTableAdapters.SelectPiecesProductAndDetialMachiningTableAdapter adp
                    = new DAL.inventory.DataSet_InventoryMachiningTableAdapters.SelectPiecesProductAndDetialMachiningTableAdapter();
                return adp.GetData(DateFrom, DateTo, WorkYear);
            }
       /// <summary>
       /// BARAYE INKE MOSHAKHS KONAM DAR TARIKH FOLAN CHEGHADR GHETE TOOLID KARDIM
       /// </summary>
       /// <param name="DateFrom"></param>
       /// <param name="DateTo"></param>
       /// <returns>NAME GHETE VA MEGHDARE TOOLID AN </returns>
            public DataTable SelectPiecesProuductAndDetial(string DateFrom, string DateTo, string WorkYear)
            {
                DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductAndDetialTableAdapter adp
                    = new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductAndDetialTableAdapter();
                return adp.GetData(DateFrom, DateTo, WorkYear);
            }

            /// <summary>
            /// BARAYE INKE MOSHAKHS KONAM DAR TARIKH FOLAN CHEGHADR GHETE TOOLID KARDIM BA JOZEYAT BISHTAR
            /// </summary>
            /// <param name="DateFrom"></param>
            /// <param name="DateTo"></param>
            /// <returns>NAME GHETE VA MEGHDARE TOOLID AN </returns>
            public DataTable SelectPiecesProuductAndDetialAll(string DateFrom, string DateTo)
            {
                DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductAndDetialAllTableAdapter adp
                    = new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductAndDetialAllTableAdapter();
                return adp.GetData(DateFrom, DateTo);
            }

        public DataTable SlPiecesProductByShift(string DateFrom, string DateTo, string WorkYear)
        {
            DAL.inventory.DataSet_InventoryTableAdapters.SlPiecesProductByShiftTableAdapter adp
                = new DAL.inventory.DataSet_InventoryTableAdapters.SlPiecesProductByShiftTableAdapter();
            return adp.GetData(DateFrom, DateTo, WorkYear);
        }
        #endregion

        #region SendProduct

        public DAL.inventory.DataSet_Inventory.SelectSendProductDataTable SelectSendProduct(string DateFrom, string DateTo)
        {
            DAL.inventory.DataSet_InventoryTableAdapters.SelectSendProductTableAdapter adp
                = new DAL.inventory.DataSet_InventoryTableAdapters.SelectSendProductTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public int UpdateSendProduct(DAL.inventory.DataSet_Inventory.SelectSendProductDataTable dt)
        {
            DAL.inventory.DataSet_InventoryTableAdapters.SelectSendProductTableAdapter adp =
                new DAL.inventory.DataSet_InventoryTableAdapters.SelectSendProductTableAdapter();
            return adp.Update(dt);
        }


        #endregion

        #region برای گردش موجودی در کارخانه


            //public DAL.inventory.DataSet_Inventory.SelectInventoryDataTable SelectInventory(string DateFrom,string DateTo,int? Pieces_)
            //{
            //    DAL.inventory.DataSet_InventoryTableAdapters.SelectInventoryTableAdapter adp 
            //        = new DAL.inventory.DataSet_InventoryTableAdapters.SelectInventoryTableAdapter();
            //    return adp.GetData(DateFrom,DateTo,Pieces_);
            //}
            public DataTable SelectInventoryGroupByPieces(string DateFrom, string DateTo, string WorkYear)
            {
                //DAL.inventory.DataSet_InventoryTableAdapters.SelectInventoryGroupByPiecesTableAdapter adp
                //    = new DAL.inventory.DataSet_InventoryTableAdapters.SelectInventoryGroupByPiecesTableAdapter();
                //return adp.GetData(DateFrom, DateTo, WorkYear);

            return new BLL.Connection.csConnection().SqlDataTabeReturn("SelectInventoryGroupByPieces",
                                                                            "@DateFrom", DateFrom,
                                                                            "@DateTo", DateTo,
                                                                            "@WorkYear", WorkYear);

        }

        #endregion
    }
}
