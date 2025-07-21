using System;
using System.Data;

namespace BLL
{
    public class csRegisteringGroup
    {
        public DataTable SelectRegistringGroupAndName(int x_, string xNameGroup)
        {
            DAL.DataSet_RegistringGroupTableAdapters.SelectRegisteringGroupandNameUserTableAdapter adp =
                new DAL.DataSet_RegistringGroupTableAdapters.SelectRegisteringGroupandNameUserTableAdapter();
            return adp.GetData(x_, xNameGroup);
        }
        //public DataTable SelectRegistringGroup(int x_)
        //{
        //    DAL.DataSet_RegistringGroupTableAdapters.SelectRegistringGroupByXTableAdapter adp =
        //        new DAL.DataSet_RegistringGroupTableAdapters.SelectRegistringGroupByXTableAdapter();
        //    return adp.GetData(ObjectName);
        //}
        public int RegistringGroupx_(string ObjectName, out int xSupplierby_, out int xApproveby_, out int xRegisterby_)
        {
            DAL.DataSet_RegistringGroupTableAdapters.SelectRegistringGroupByNameTableAdapter adpRe =
                             new DAL.DataSet_RegistringGroupTableAdapters.SelectRegistringGroupByNameTableAdapter();
            DataTable dtr = adpRe.GetData(ObjectName);
            if (dtr.Rows.Count > 0 && dtr.Rows[0]["xRegistringGroup_"] != null)
            {
                xSupplierby_ = dtr.Rows[0]["xSupplierby_"] == DBNull.Value ? -1 : (int)dtr.Rows[0]["xSupplierby_"];
                xApproveby_ = dtr.Rows[0]["xApproveby_"] == DBNull.Value ? -1 : (int)dtr.Rows[0]["xApproveby_"];
                xRegisterby_ = dtr.Rows[0]["xRegisterby_"] == DBNull.Value ? -1 : (int)dtr.Rows[0]["xRegisterby_"];
                return (int)dtr.Rows[0]["xRegistringGroup_"];
            }
            else
            {
                xSupplierby_ = -1;
                xApproveby_ = -1;
                xRegisterby_ = -1;
                return -1;
            }
        }
    }
}
