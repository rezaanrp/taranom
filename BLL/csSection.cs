using System.Data;

namespace BLL
{
    public class csSection
    {
        public DataTable SelectSection()
        {
            DAL.DataSet_SectionTableAdapters.mSectionTableAdapter adp =
                new DAL.DataSet_SectionTableAdapters.mSectionTableAdapter();
            return adp.GetData();
        }
    }
}
