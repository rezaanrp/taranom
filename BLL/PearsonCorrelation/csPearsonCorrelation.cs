using System.Data;

namespace BLL.PearsonCorrelation
{
    public class csPearsonCorrelation
    {
        public DataTable SlPearsonCorrelationSandAndDefect(string DateFrom, string DateTo, int DefectList_,int DayNumber)
        {
            return new BLL.Connection.csConnection().SqlDataTabeReturn("SlPearsonCorrelationSandAndDefect", "DateFrom", DateFrom
                                                                                                               , "DateTo", DateTo
                                                                                                               , "DefectList_", DefectList_
                                                                                                               , "DayNumber", DayNumber
                                                                                                               );

        }
        public DataTable SlPearsonCorrelationSandForChart(string DateFrom, string DateTo, int DefectList_,int DayNumber)
        {
            return new BLL.Connection.csConnection().SqlDataTabeReturn("SlPearsonCorrelationSandForChart", "DateFrom", DateFrom
                                                                                                               , "DateTo", DateTo
                                                                                                               , "DefectList_", DefectList_
                                                                                                               , "DayNumber", DayNumber
                                                                                                               );

        }
        public DataTable SlPearsonCorrelationDefectForChart(string DateFrom, string DateTo, int DefectList_, int DayNumber)
        {
            return new BLL.Connection.csConnection().SqlDataTabeReturn("SlPearsonCorrelationDefectForChart", "DateFrom", DateFrom
                                                                                                               , "DateTo", DateTo
                                                                                                               , "DefectList_", DefectList_
                                                                                                               , "DayNumber", DayNumber
                                                                                                               );

        }
        
    }
}
