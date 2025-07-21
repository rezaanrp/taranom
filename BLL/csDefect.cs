using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class csDefect
    {
        #region Chart
        public DataTable SlPruductInspectionDefectPcPrDefectTotal_M(string DateFrom, string DateTo)
        {
            DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectPcPrDefectTotal_MTableAdapter adp
                = new DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectPcPrDefectTotal_MTableAdapter();
            return adp.GetData(DateFrom,DateTo);

        }
        public DataTable SlPruductInspectionDefectPcPrDefect_M(string DateFrom, string DateTo,int Pieces)
        {
            DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectPcPrDefect_MTableAdapter adp
                = new DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectPcPrDefect_MTableAdapter();
            return adp.GetData(DateFrom,DateTo,  Pieces);

        }
        public DataTable SlPruductInspectionDefectDetialsGroup_M(string DateFrom, string DateTo)
       {
           DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectDetialsGroup_MTableAdapter adp
               = new DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectDetialsGroup_MTableAdapter();
           return adp.GetData(DateTo, DateFrom);

       }
       public DataTable SlPruductInspectionByMonth(string Year)
       {
           DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionByMonthTableAdapter adp
               = new DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionByMonthTableAdapter();
           return adp.GetData(Year);

       }
       public DataTable SlPruductInspectionDefectDetialsGroup(string DateFrom, string DateTo)
       {
           //DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectDetialsGroupTableAdapter adp
           //    = new DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectDetialsGroupTableAdapter();
           //return adp.GetData(DateTo, DateFrom);

            string con = new DAL.csConnection().GetConeectionPaya;

            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlPruductInspectionDefectDetialsGroup", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        }

       public DataTable SlPruductInspectionPcDefectPr(string DateFrom, string DateTo)
       {
           //DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionPcDefectPrTableAdapter adp
           //    = new DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionPcDefectPrTableAdapter();
           //return adp.GetData(DateTo, DateFrom);


            string con = new DAL.csConnection().GetConeectionPaya;

            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlPruductInspectionPcDefectPr", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        }
       public DataTable SlPruductInspectionDefectPcPrDefect(string DateFrom, string DateTo)
       {
           //DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectPcPrDefectTableAdapter adp
           //    = new DAL.QualityControl.DataSet_PruductInspection_ChartTableAdapters.SlPruductInspectionDefectPcPrDefectTableAdapter();
           //return adp.GetData(DateTo, DateFrom);

            string con = new DAL.csConnection().GetConeectionPaya;

            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlPruductInspectionDefectPcPrDefect", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        }
        #endregion

       public DAL.QualityControl.DataSet_PruductInspection.SlPruductInspectionCompareDataTable SlPruductInspectionCompare(string DateFrom, string DateTo)
       {
           DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SlPruductInspectionCompareTableAdapter adp =
               new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SlPruductInspectionCompareTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
      
       

       /// <summary>
       /// گزارش ضایعات با گروه بندی قطعات و نوع ضایعات
       /// </summary>
       /// <param name="DateTo"></param>
       /// <param name="DateFrom"></param>
       /// <returns></returns>
       public DAL.QualityControl.DataSet_PruductInspection.SelectPruductInspectionDefectDetialsDataTable SelectPruductInspectionDefectDetials(string DateFrom, string DateTo)
       {
           DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SelectPruductInspectionDefectDetialsTableAdapter adp =
               new DAL.QualityControl.DataSet_PruductInspectionTableAdapters.SelectPruductInspectionDefectDetialsTableAdapter();
           return adp.GetData(DateTo, DateFrom);
       }

       /// <summary>
        /// en class baraye form PruductInspection tarahi shoode
       /// </summary>
       /// <param name="DateFrom">tarikh mabda</param>
       /// <param name="DateTo">tarikh enteha</param>
       /// <returns></returns>
       public DAL.DataSet_Defect.SelectPruductInspectionByDateDataTable SelectPruductInspectionByDate(string DateFrom, string DateTo)
       {
           DAL.DataSet_DefectTableAdapters.SelectPruductInspectionByDateTableAdapter adp
               = new DAL.DataSet_DefectTableAdapters.SelectPruductInspectionByDateTableAdapter();
          return adp.GetData(DateFrom, DateTo);

       }

       public bool UpdatePruductInspection(DAL.DataSet_Defect.SelectPruductInspectionByDateDataTable dt)
       {
           DAL.DataSet_DefectTableAdapters.SelectPruductInspectionByDateTableAdapter adp
               = new DAL.DataSet_DefectTableAdapters.SelectPruductInspectionByDateTableAdapter();
           adp.Update(dt);
            return true;
       }


       public DAL.DataSet_Defect.SelectDefectNameAndCountByProductInspection_DataTable SelectDefectNameAndCountByProductInspection_(int x_)
       {
           DAL.DataSet_DefectTableAdapters.SelectDefectNameAndCountByProductInspection_TableAdapter
            adp   = new DAL.DataSet_DefectTableAdapters.SelectDefectNameAndCountByProductInspection_TableAdapter();
           return adp.GetData(x_);

       }

       public bool UpdateDefectNameAndCount(DAL.DataSet_Defect.SelectDefectNameAndCountByProductInspection_DataTable dt)
       {
           DAL.DataSet_DefectTableAdapters.SelectDefectNameAndCountByProductInspection_TableAdapter
                       adp = new DAL.DataSet_DefectTableAdapters.SelectDefectNameAndCountByProductInspection_TableAdapter();
           adp.Update(dt);
           return true;
       }



       public DataTable SelectDefectList()
       {
           DAL.DataSet_DefectTableAdapters.mDefectListTableAdapter adp = new DAL.DataSet_DefectTableAdapters.mDefectListTableAdapter();
           return adp.GetData();
       }
       public int? InsertProductInspection(int xPiece_,int year, string xProductionDate,int xShift_, int xControlledNumber, string xDate
           ,string xDateInspect,int xRegistringGroup_,bool xSupplier,bool xApprove ,DataTable dt)
       {
           if (BLL.authentication.InsertData == false)
               return 0;

           xProductionDate = csshamsidate.ShamsiDateAndDayOfYear(year, int.Parse(xProductionDate));
           int? x_ = 0;
           DAL.DataSet_DefectTableAdapters.QueriesTableAdapter adp = 
               new DAL.DataSet_DefectTableAdapters.QueriesTableAdapter();
           adp.InsertProductInspection(xPiece_,xProductionDate,xShift_,xControlledNumber,xDate,xDateInspect,null,xSupplier,xApprove,BLL.authentication.x_,ref x_);
           DAL.DataSet_DefectTableAdapters.mDefectNameAndCountTableAdapter adpDefectList = new DAL.DataSet_DefectTableAdapters.mDefectNameAndCountTableAdapter();
           foreach (DataRow dr in dt.Rows)
           {
               adpDefectList.Insert(x_, int.Parse(dr["x_"].ToString()), int.Parse(dr["dvg_DefectNumber"].ToString()));
           }

           return x_;
       }
       public DataTable SelectDefectByDate(string DateFrom,string DateTo)
       {
           DAL.DataSet_DefectTableAdapters.SelectDefectByDateTableAdapter adp
               = new DAL.DataSet_DefectTableAdapters.SelectDefectByDateTableAdapter();
           return adp.GetData(DateFrom,DateTo);

       }

        public DataTable SelectDefectByDateGroupPieces(string DateFrom, string DateTo)
       {
            //DAL.Defect.DataSet_ProductInspection.SelectDefectByDateGroupPiecesDataTable dt
            //    = new DAL.Defect.DataSet_ProductInspection.SelectDefectByDateGroupPiecesDataTable();
            //DAL.Defect.DataSet_ProductInspectionTableAdapters.SelectDefectByDateGroupPiecesTableAdapter adp
            //    = new DAL.Defect.DataSet_ProductInspectionTableAdapters.SelectDefectByDateGroupPiecesTableAdapter();

            //adp.Fill(dt, DateFrom, DateTo);
            //return dt;
            string con = new DAL.csConnection().GetConeectionPaya;
               
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("selectdefectbydategrouppieces", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        }



       //private void FillInDataGrid(string SQLstring)
       //{
       //   // string cn =  ConfigurationManager.ConnectionStrings["Scratchpad"].ConnectionString; //hier wordt de databasestring opgehaald
       //   // DataSet ds = new DataSet();
       //    DAL.DataSet_Defect ds = new DAL.DataSet_Defect();
       //    // dispose objects that implement IDisposable
           
       //    using (SqlConnection myConnection = new SqlConnection(cn))
       //    {
       //        SqlDataAdapter dataadapter = new SqlDataAdapter(SQLstring, myConnection);

       //        // set the CommandTimeout
       //        dataadapter.SelectCommand.CommandTimeout = 60;  // seconds

       //        myConnection.Open();
       //        dataadapter.Fill(ds, "SelectDefectByDateGroupPieces");
       //    }
       //}
    }
}
