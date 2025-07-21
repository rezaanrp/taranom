namespace PAYAIND
{
    public   class csservicefordevice
  {
      public bool saveservice(string itemno,string devicecod,string name,bool mount)
      {
          PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter();
          db.Insert(itemno, devicecod, name, mount);         
          return true;
      }
      public PAYADATA.dataserservicefordevice.mservic_deviceDataTable selectservice(string devicecod, bool mount)
      {
          PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter();
          return db.GetDataBydevice(mount, devicecod);
      }
      public PAYADATA.dataserservicefordevice.mserviceresultDataTable selectresult()
      {
          PAYADATA.dataserservicefordeviceTableAdapters.mserviceresultTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceresultTableAdapter();
          return db.GetData();
      }
      public bool deleteservicebycod(int i)
      {
          PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter();
          db.Deletefromservicebyid(i);
          return true;
      }
      public bool updateservic(PAYADATA.dataserservicefordevice.mservic_deviceDataTable table)
      {
          PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mservic_deviceTableAdapter();
          db.Update(table);
          return true;
      }
    }
}
