namespace BLL.Inventory
{
    public  class csInventoryScrab
    {
      public DAL.inventory.DataSet_InventoryScrab.SlInventoryScrabDataTable SlInventoryScrab( string DateFrom,string DateTo,string Date)
      {
          DAL.inventory.DataSet_InventoryScrabTableAdapters.SlInventoryScrabTableAdapter adp =
               new DAL.inventory.DataSet_InventoryScrabTableAdapters.SlInventoryScrabTableAdapter();
          return adp.GetData(DateFrom, DateTo,Date);
      }

    }
}
