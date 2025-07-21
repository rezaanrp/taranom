using System.Data;

namespace BLL.ManagerReport
{

    public  class csManagerReport
    {
      public DAL.ManagerReport.DataSet_PiecesProuductForManager_R.SlPiecesProuductForManager_RDataTable SlPiecesProuductForManager_R(string Datefrom, string DateTo)
      {
          DAL.ManagerReport.DataSet_PiecesProuductForManager_RTableAdapters.SlPiecesProuductForManager_RTableAdapter adp =
              new DAL.ManagerReport.DataSet_PiecesProuductForManager_RTableAdapters.SlPiecesProuductForManager_RTableAdapter();

          return adp.GetData(Datefrom, DateTo);
      }
      public DAL.ManagerReport.DataSet_ManagerReport.SlInventoryPiecesForManager_S3_tradingDataTable SlInventoryPiecesForManager_S3_trading(string Datefrom, string DateTo, string WorkYear)
      {
          DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlInventoryPiecesForManager_S3_tradingTableAdapter adp =
              new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlInventoryPiecesForManager_S3_tradingTableAdapter();

          return adp.GetData(Datefrom, DateTo, WorkYear);
      }
      public DAL.ManagerReport.DataSet_ManagerReport.SlInventoryPiecesForManager_S3DataTable SlInventoryPiecesForManager_S3(string Datefrom, string DateTo, string WorkYear)
      {
          DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlInventoryPiecesForManager_S3TableAdapter adp =
              new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlInventoryPiecesForManager_S3TableAdapter();

          return adp.GetData(Datefrom, DateTo, WorkYear);
      }
      public DAL.ManagerReport.DataSet_InventoryPiecesForManager.SlInventoryPiecesForManager_S1DataTable SlInventoryPiecesForManager_S1(string Datefrom, string DateTo, string WorkYear)
      {
          DAL.ManagerReport.DataSet_InventoryPiecesForManagerTableAdapters.SlInventoryPiecesForManager_S1TableAdapter adp =
              new DAL.ManagerReport.DataSet_InventoryPiecesForManagerTableAdapters.SlInventoryPiecesForManager_S1TableAdapter();

          return adp.GetData(Datefrom, DateTo, WorkYear);
      }
      public DAL.ManagerReport.DataSet_ManagerReport.SlSandDailyReport_RChartDataTable SlSandDailyReport_RChart(string Datefrom , string DateTo)
      {
          DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlSandDailyReport_RChartTableAdapter adp =
              new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlSandDailyReport_RChartTableAdapter();

          return adp.GetData(Datefrom , DateTo);
      }



      public DataTable SlMeltWeightByMonth(string WorkYear)
      {
            return new BLL.Connection.csConnection().SqlDataTabeReturn("SlMeltWeightByMonth", "@WorkYear", WorkYear);

        }

        public DAL.ManagerReport.DataSet_ManagerReport.SlPruductPiecesByMonthDataTable SlPruductPiecesByMonth(string WorkYear)
      {
          DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlPruductPiecesByMonthTableAdapter adp =
              new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlPruductPiecesByMonthTableAdapter();

          return adp.GetData(WorkYear);
      }


      public DataTable SlInventoryAllMaterial(string WorkYear)
      {
            //DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlInventoryAllMaterialTableAdapter adp =
            //    new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlInventoryAllMaterialTableAdapter();

            //return adp.GetData(WorkYear);

            return new BLL.Connection.csConnection().SqlDataTabeReturn("SlInventoryAllMaterial", "@WorkYear", WorkYear);
        }
      public DAL.ManagerReport.DataSet_ManagerReport.SlStandardInvDataTable SlStandardInv()
      {
          DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlStandardInvTableAdapter adp =
              new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlStandardInvTableAdapter();

          return adp.GetData();
      }
      public DataTable SlInventoryForManager(string WorkYear)
      {
            return new BLL.Connection.csConnection().SqlDataTabeReturn("SlInventoryForManager", "@WorkYear", WorkYear);

            //string con = new DAL.csConnection().GetConeectionPaya;

            //using (SqlConnection sqlcon = new SqlConnection(con))
            //{
            //    using (SqlCommand cmd = new SqlCommand("SlInventoryForManager", sqlcon))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Add(new SqlParameter("@WorkYear", WorkYear));
            //        cmd.CommandTimeout = 200;

            //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            //        {
            //            DataTable dt = new DataTable();

            //            da.Fill(dt);
            //            return dt;
            //        }
            //    }
            //}
        }

      public DAL.ManagerReport.DataSet_ManagerReport.SlDefectForManagerDataTable SlDefectForManager(string WorkYear)
      {
          DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlDefectForManagerTableAdapter adp =
              new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlDefectForManagerTableAdapter();

          return adp.GetData(WorkYear);
      }
      public DAL.ManagerReport.DataSet_ManagerReport.SlStockPiecesGrpDataTable SlStockPiecesGrp(string WorkYear)
      {
            DAL.csConnectionTest t = new DAL.csConnectionTest();

            if (!t.testConnection())
            {
                return new DAL.ManagerReport.DataSet_ManagerReport.SlStockPiecesGrpDataTable();
            }
            DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlStockPiecesGrpTableAdapter adp =
              new DAL.ManagerReport.DataSet_ManagerReportTableAdapters.SlStockPiecesGrpTableAdapter();

          return adp.GetData(WorkYear);
      }
    }
}
