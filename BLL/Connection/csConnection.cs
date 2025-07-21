using System.Data;
using System.Data.SqlClient;

namespace BLL.Connection
{
    public  class csConnection
    {
      public  DataTable SqlDataTabeReturn(string Sp, string ParamName,string ParamValue)
        {
            string con = new DAL.csConnection().GetConeectionPaya;

            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(Sp, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter(ParamName, ParamValue));
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
        public DataTable SqlDataTabeReturn(string Sp, string ParamName1, string ParamValue1, 
            string ParamName2, string ParamValue2,
            string ParamName3, string ParamValue3)
        {
            string con = new DAL.csConnection().GetConeectionPaya;

            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand( Sp, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter(ParamName1, ParamValue1));
                    cmd.Parameters.Add(new SqlParameter(ParamName2, ParamValue2));
                    cmd.Parameters.Add(new SqlParameter(ParamName3, ParamValue3));
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
        public DataTable SqlDataTabeReturn(string Sp, string ParamName1, string ParamValue1,
    string ParamName2, string ParamValue2,
    string ParamName3, int ParamValue3)
        {
            string con = new DAL.csConnection().GetConeectionPaya;

            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(Sp, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter(ParamName1, ParamValue1));
                    cmd.Parameters.Add(new SqlParameter(ParamName2, ParamValue2));
                    cmd.Parameters.Add(new SqlParameter(ParamName3, ParamValue3));
                    cmd.CommandTimeout = 5000;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable SqlDataTabeReturn(string Sp, string ParamName1, string ParamValue1,
string ParamName2, string ParamValue2,
string ParamName3, int ParamValue3,
string ParamName4, int ParamValue4
            )
        {
            string con = new DAL.csConnection().GetConeectionPaya;

            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(Sp, sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter(ParamName1, ParamValue1));
                    cmd.Parameters.Add(new SqlParameter(ParamName2, ParamValue2));
                    cmd.Parameters.Add(new SqlParameter(ParamName3, ParamValue3));
                    cmd.Parameters.Add(new SqlParameter(ParamName4, ParamValue4));
                    cmd.CommandTimeout = 5000;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

    }
}
