namespace BLL.Module
{
    public class Module
    {
       public System.Data.DataTable SelectMudole()
       {
           DAL.DataSet_ProcurementTableAdapters.mModuleTableAdapter adp
               = new DAL.DataSet_ProcurementTableAdapters.mModuleTableAdapter();
           return adp.GetData();
       }
    }
}
