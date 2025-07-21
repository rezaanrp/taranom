namespace BLL.KPI
{
    public class csKPI
    {

        
        public DAL.KPI.DataSet_Stock.SlKPIStockPiecesFlowMachinigDataTable SlKPIStockPiecesFlowMachinig(string DateWork)
        {
            DAL.KPI.DataSet_StockTableAdapters.SlKPIStockPiecesFlowMachinigTableAdapter adp =
                new DAL.KPI.DataSet_StockTableAdapters.SlKPIStockPiecesFlowMachinigTableAdapter();
            return adp.GetData(DateWork);
        }
        public DAL.KPI.DataSet_Stock.SlKPIWareHousePiecesMachiningDataTable SlKPIWareHousePiecesMachining(string DateWork)
        {
            DAL.KPI.DataSet_StockTableAdapters.SlKPIWareHousePiecesMachiningTableAdapter adp =
                new DAL.KPI.DataSet_StockTableAdapters.SlKPIWareHousePiecesMachiningTableAdapter();
            return adp.GetData(DateWork);
        }
        public DAL.KPI.DataSet_Stock.SlKPIStockPiecesFlowDataTable SlKPIStockPiecesFlow(string DateWork)
        {
            DAL.KPI.DataSet_StockTableAdapters.SlKPIStockPiecesFlowTableAdapter adp =
                new DAL.KPI.DataSet_StockTableAdapters.SlKPIStockPiecesFlowTableAdapter();
            return adp.GetData(DateWork);
        }
        public DAL.KPI.DataSet_Stock.SlKPIWareHousePiecesDataTable SlKPIWareHousePieces(string DateWork)
        {
            DAL.KPI.DataSet_StockTableAdapters.SlKPIWareHousePiecesTableAdapter adp =
                new DAL.KPI.DataSet_StockTableAdapters.SlKPIWareHousePiecesTableAdapter();
            return adp.GetData(DateWork);
        }
        public DAL.KPI.DataSet_Stock.SlKPIInventoryPiecesDataTable SlKPIInventoryPieces(string DateWork)
        {
            DAL.KPI.DataSet_StockTableAdapters.SlKPIInventoryPiecesTableAdapter adp =
                new DAL.KPI.DataSet_StockTableAdapters.SlKPIInventoryPiecesTableAdapter();
            return adp.GetData(DateWork);
        }
        public DAL.KPI.DataSet_KPI.SlKPISandMaterialOnMeltDataTable SlKPISandMaterialOnMelts(string DateFrom, string DateTo)
        {
            DAL.KPI.DataSet_KPITableAdapters.SlKPISandMaterialOnMeltTableAdapter adp =
                new DAL.KPI.DataSet_KPITableAdapters.SlKPISandMaterialOnMeltTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

    }
}
