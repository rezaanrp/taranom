namespace BLL.Section
{
    public class csSection
    {
       public DAL.Section.DataSet_Section.SlSectionDataTable SlSection()
       {
           DAL.Section.DataSet_SectionTableAdapters.SlSectionTableAdapter adp =
               new DAL.Section.DataSet_SectionTableAdapters.SlSectionTableAdapter();
           return adp.GetData();
       }
    }
}
