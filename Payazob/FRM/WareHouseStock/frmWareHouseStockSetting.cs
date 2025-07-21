using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TARANOM.FRM.WareHouseStock
{
    public partial class frmWareHouseStockSetting : Form
    {

        public string v_DateFrom = "$";
        public string v_DateTo = "$";
        public double  v_Profit = -1;
        public int  v_FCT = 1;
        public frmWareHouseStockSetting()
        {
            InitializeComponent();
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            Validation.VDate vv = new Validation.VDate();
            if (double.Parse(uc_txtBox_Profit.Text) > 0
                 && vv.ValidationDate(mtxt_datefrom.Text)
                 && vv.ValidationDate(mtxt_dateto.Text)
                 )
            {
                v_DateFrom = mtxt_datefrom.Text;
                v_DateTo = mtxt_dateto.Text;
                v_Profit = double.Parse(uc_txtBox_Profit.Text);
                v_FCT = int.Parse(uc_txtBox_FCT.textWithoutcomma); ;
                this.Close();
            }
            else
            {

                MessageBox.Show("تنظیمات را به درستی ثبت کنید..");
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
