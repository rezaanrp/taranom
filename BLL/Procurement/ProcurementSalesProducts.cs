namespace BLL.Procurement
{
    public class ProcurementSalesProducts
    {
       public DAL.Procurement.DataSet_ProcurmentSalesProduct.SlProcurmentSalesProductTtPcByCuDataTable SlProcurmentSalesProductTtPcByCu(string xDateFrom, string xDateTo)
       {
           DAL.Procurement.DataSet_ProcurmentSalesProductTableAdapters.SlProcurmentSalesProductTtPcByCuTableAdapter adp
               = new DAL.Procurement.DataSet_ProcurmentSalesProductTableAdapters.SlProcurmentSalesProductTtPcByCuTableAdapter();
           return adp.GetData(xDateFrom, xDateTo);
       }
    }
}
