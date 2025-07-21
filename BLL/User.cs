using System.Data;
namespace BLL
{
    public class User
    {
        public static DataTable userselect(int x_,string xUsername,string xName,string xFamily,string xTel,string xEmail,int xGroup_)
        {
            
            DAL.DataSet_LoginTableAdapters.SelectbyCustomFeildTableAdapter adp
                = new DAL.DataSet_LoginTableAdapters.SelectbyCustomFeildTableAdapter();

            return adp.GetData(x_, xUsername, xName, xFamily, xTel, xEmail, xGroup_);
        }
        public DataTable selectname()
        {
            DAL.DataSet_LoginTableAdapters.mSelectNameFamilyTableAdapter adp = new
            DAL.DataSet_LoginTableAdapters.mSelectNameFamilyTableAdapter();
            return adp.GetData();
        }
        //public bool con()
        //{
        //    DAL.Class1.ChangeConnectionString("Salam");
        //    return true;
        //}

        public DataTable SelectUserPorfile()
        {
            DAL.DataSet_LoginTableAdapters.SelectUserProfileTableAdapter adp = new
            DAL.DataSet_LoginTableAdapters.SelectUserProfileTableAdapter();
            return adp.GetData();
        }
        public DataTable SelectGroup()
        {
            DAL.DataSet_LoginTableAdapters.mGroupTableAdapter adp = new
            DAL.DataSet_LoginTableAdapters.mGroupTableAdapter();
            return adp.GetData();
        }



    }
}
