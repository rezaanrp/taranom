namespace PAYAIND
{
    public   class csworker
  {
      public PAYADATA.Dsworker.mworkerDataTable selectworker()
      {
          PAYADATA.DsworkerTableAdapters.mworkerTableAdapter db = new PAYADATA.DsworkerTableAdapters.mworkerTableAdapter();
          return db.GetData();
      }
      public PAYADATA.Dsworker.workergroupDataTable selectgroupworker()
      {
          PAYADATA.DsworkerTableAdapters.workergroupTableAdapter db = new PAYADATA.DsworkerTableAdapters.workergroupTableAdapter();
          return db.GetData();
      }
      public void save(PAYADATA.Dsworker.mworkerDataTable dt)
      {
          PAYADATA.DsworkerTableAdapters.mworkerTableAdapter db = new PAYADATA.DsworkerTableAdapters.mworkerTableAdapter();
          db.Update(dt);

      }
    }
}
