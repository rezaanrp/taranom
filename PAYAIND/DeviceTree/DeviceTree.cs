namespace PAYAIND.DeviceTree
{
    public class DeviceTree
    {
       public PAYADATA.coding.DataSet_ObjectTree.SlDeviceTreeDataTable SlDeviceTreeData()
       {
           PAYADATA.coding.DataSet_ObjectTreeTableAdapters.SlDeviceTreeTableAdapter adp =
                new PAYADATA.coding.DataSet_ObjectTreeTableAdapters.SlDeviceTreeTableAdapter();
               return adp.GetData(); 
       }

    }
}
