using System.Data;

namespace BLL
{
    public class csElement
    {
        public DataTable SelectElement()
        {
            DAL.DataSet_ElementTableAdapters.mElementTableAdapter adp = new DAL.DataSet_ElementTableAdapters.mElementTableAdapter();
            return adp.GetData();
        }
    }
}
