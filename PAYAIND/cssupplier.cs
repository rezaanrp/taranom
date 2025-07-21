namespace PAYAIND
{
    public class cssupplier
    {

        public bool saveupdatesupplier(PAYADATA.DataSetsupplier.msupplierDataTable dt)
        {
            try
            {
                PAYADATA.DataSetsupplierTableAdapters.msupplierTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.msupplierTableAdapter();
                db.Update(dt); return true;
            }
            catch { return false; }
        }

        public PAYADATA.DataSetsupplier.msupplierDataTable selectsupplier()
        {
           
            PAYADATA.DataSetsupplierTableAdapters.msupplierTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.msupplierTableAdapter();
            return db.GetData();


        }
        //*****************************
        public PAYADATA.DataSetsupplier.faktorDataTable selectfaktor()
        {
            PAYADATA.DataSetsupplierTableAdapters.faktorTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.faktorTableAdapter();
            return db.GetData();
        }

        public bool saveupdatefaktor(PAYADATA.DataSetsupplier.faktorDataTable dt)
        {
            try
            {
                PAYADATA.DataSetsupplierTableAdapters.faktorTableAdapter db = new  PAYADATA.DataSetsupplierTableAdapters.faktorTableAdapter();
                db.Update(dt); return true;
            }

            catch { return false; }

        }

        public PAYADATA.DataSetsupplier.detailsfaktorDataTable selectdetailsfaktor(int faktorid)
        {
            PAYADATA.DataSetsupplierTableAdapters.detailsfaktorTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.detailsfaktorTableAdapter();
            return db.GetData();
        }

        public bool saveupdatedetailsfaktor(PAYADATA.DataSetsupplier.detailsfaktorDataTable  dt)
        {
            try
            {
                PAYADATA.DataSetsupplierTableAdapters.detailsfaktorTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.detailsfaktorTableAdapter();
                db.Update(dt); return true;
            }

            catch { return false; }

        }
        //*****************************************
       
        public bool saveupdatecost(PAYADATA.DataSetsupplier.mcostesDataTable dt)
        {
            try
            {
                PAYADATA.DataSetsupplierTableAdapters.mcostesTableAdapter db= new PAYADATA.DataSetsupplierTableAdapters.mcostesTableAdapter();
                db.Update(dt); return true;
            }

            catch { return false; }

        }

        public PAYADATA.DataSetsupplier.mcostesDataTable selectcost()
        {


        PAYADATA.DataSetsupplierTableAdapters.mcostesTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.mcostesTableAdapter();
        return  db.GetData();

        }

        public PAYADATA.DataSetsupplier.mcosttypeDataTable selectcosttype()
      
        {
            PAYADATA.DataSetsupplierTableAdapters.mcosttypeTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.mcosttypeTableAdapter();
            return db.GetData();


        }


          public PAYADATA.DataSetsupplier.munittypeDataTable selectunittype()
      
        {

            PAYADATA.DataSetsupplierTableAdapters.munittypeTableAdapter db = new PAYADATA.DataSetsupplierTableAdapters.munittypeTableAdapter();
            return db.GetData();


        }


         
    }
}
