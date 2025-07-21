namespace BLL.Inventory
{
    public  class csInventoryTurning

    {
        public DAL.inventory.DataSet_InventoryMachining.SlPiecesProductMachiningOnFinalOpDataTable SlPiecesProductMachiningOnFinalOp(string DateFrom, string DateTo)
        {
            DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlPiecesProductMachiningOnFinalOpTableAdapter adp
                = new DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlPiecesProductMachiningOnFinalOpTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.inventory.DataSet_InventoryMachining.SlStockPiecesMachiningDataTable SlStockPiecesMachining(string DateFrom, string DateTo, string WorkYear)
      {
          DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlStockPiecesMachiningTableAdapter adp
              = new DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlStockPiecesMachiningTableAdapter();
          return adp.GetData(DateFrom, DateTo, WorkYear);
      }
      public DAL.inventory.DataSet_InventoryMachining.SlPiecesProductMachiningDataTable SlPiecesProductMachining(string DateFrom, string DateTo)
      {
          DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlPiecesProductMachiningTableAdapter adp
              = new DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlPiecesProductMachiningTableAdapter();
         return adp.GetData(DateFrom,DateTo);
      }
      public DAL.inventory.DataSet_InventoryTurning.SlInventoryMaterial_S3DataTable SlInventoryMaterial_S3(string DateFrom ,string DateTo)
      {
          DAL.inventory.DataSet_InventoryTurningTableAdapters.SlInventoryMaterial_S3TableAdapter adp
              = new DAL.inventory.DataSet_InventoryTurningTableAdapters.SlInventoryMaterial_S3TableAdapter();
         return adp.GetData(DateFrom,DateTo);
      }
      public DAL.inventory.DataSet_InventoryMachining.SlInventoryMaterialTurningDataTable SlInventoryMaterialTurning(string DateFrom, string DateTo, string Date)
      {
          DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlInventoryMaterialTurningTableAdapter adp
              = new DAL.inventory.DataSet_InventoryMachiningTableAdapters.SlInventoryMaterialTurningTableAdapter();
         return adp.GetData(DateFrom,DateTo,Date);
      }
      
    }
}
