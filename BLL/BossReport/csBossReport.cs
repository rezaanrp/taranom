namespace BLL.BossReport
{
    public  class csBossReport
    {
      public DAL.BossReprot.DataSet_BossReprot.SlProductPieces_Boss_RDataTable SlProductPieces_Boss_R(string DateFrom,string DateTo)
      {
          DAL.BossReprot.DataSet_BossReprotTableAdapters.SlProductPieces_Boss_RTableAdapter adp
               = new DAL.BossReprot.DataSet_BossReprotTableAdapters.SlProductPieces_Boss_RTableAdapter();
          return adp.GetData(DateFrom, DateTo);

      }
    }
}
