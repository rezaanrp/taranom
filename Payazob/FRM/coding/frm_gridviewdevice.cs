using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAYAZOBNET.form.coding
{
    public partial class frm_gridviewdevice : Form
    {

        PAYAIND.fill_datagride fg = new PAYAIND.fill_datagride();
        
        public frm_gridviewdevice()
        {
            InitializeComponent();
        }

        private void frm_gridviewdevice_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = fg.fill_datagrid_device_name();

        }


        private void cancel_Click(object sender, EventArgs e)

        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {

        PAYAIND.csmtbf bs = new PAYAIND.csmtbf();
        form.indicator.frmmtbm f = new indicator.frmmtbm();

       /* for (int i = 0; i <= dataGridViewX1.Rows.Count-1; i++)

            try
            {
                if (dataGridViewX1.Rows[i].Cells["xnamedevice"].Value.ToString() == "شات بلاست")
                    MessageBox.Show(dataGridViewX1.Rows[i].Cells["xnumber"].Value.ToString());
               // this.Close();
            }
            catch
            { }
            */
        

     //  foreach (DataGridViewRow r in dataGridViewX1.Rows)
    //  {

        //   if ((r.Cells["select"].Value =="1"))

              // foreach (DataGridViewRow rw  in f.dataGridViewX2) 
           /* for (int j = 0; j <= dataGridViewX1.Rows.Count-1; j++)
                   if ((dataGridViewX1.Rows[j].Cells["select"].Value =="1"))
                        for(int i=0;i<=f.dataGridViewX2.Rows.Count-1;i++)
                               {

                                     MessageBox.Show(f.dataGridViewX2.Rows.Count.ToString());
                                        // if (f.dataGridViewX2.Rows[i].Cells["xnamedevice"].Value == dataGridViewX1.Rows[j].Cells["xnamedevice"].Value)
                                       // if (f.dataGridViewX2.Rows[i].Cells["xnamedevice"].Value == r.Cells["xnamedevice"].Value)
                                      // && f.dataGridViewX2.Rows[i].Cells["xnumber"].Value == r.Cells["xnumber"].Value)
             */                 // MessageBox.Show(f.dataGridViewX2.Rows[i].Cells["MTTR"].Value.ToString())
                            
    
        
        }
          
           





    }
}
