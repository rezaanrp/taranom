namespace PAYAIND.MTTR
{
    public  class csMTTR_R
    {
      public PAYADATA.interuptcomp.dsinteruptcomp.SlInterupTrublingChartDataTable 
          SlInterupTrublingChart(string xdevice_cod, string xidtruble, string fdate, string ldate, string type, string troubling)
      {
          PAYADATA.interuptcomp.dsinteruptcompTableAdapters.SlInterupTrublingChartTableAdapter adp =
              new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.SlInterupTrublingChartTableAdapter();
          return adp.GetData( xdevice_cod,  xidtruble,  fdate,  ldate,  type,  troubling);
      }
    }
}
