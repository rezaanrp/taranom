using System;
using System.Windows.Forms;

namespace Payazob
{
    static class Program
    {
        static System.Threading.Mutex _mutex = new System.Threading.Mutex(false, "payazob");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static int selectindexnamedevice = 0;
        public static int selectindexnodevice = 0;
        public static int selectindexnameset1 = 0;
        public static int selectindexnameset2 = 0;
        public static int selectindexnameobject = 0;
        public static int selectindexnamelocation = 0;
        public static int selectedindexset3 = 0;
        [STAThread]
        static void Main()
        {
            if (!_mutex.WaitOne(1000, false))
            {
                MessageBox.Show("نرم افزار هم اکنون در حال اجرا می باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // new TARANOM.FRM.WareHouseStock.frmCustomerCode().ShowDialog();
            new TARANOM.FRM.WareHouseStock.frmWareHouseStock().ShowDialog();


          //  new TARANOM.Form2().ShowDialog();
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();
            //if (frm.EnterSuccess)
            //{
            //     new TARANOM.FRM.WareHouseStock.frmWareHouseStock().ShowDialog();
            //   // Application.Run(new Main());
            //}
        }

    }
}
