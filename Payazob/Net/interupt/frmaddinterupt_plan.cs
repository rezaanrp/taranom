using System;
using System.Drawing;
using System.Windows.Forms;

namespace PAYAZOBNET.form.interupt
{
    public partial class frmaddinterupt_plan : Form
    {
        int idserviceprigram;
        public bool edit = false;
        public frmaddinterupt_plan()
        {
            InitializeComponent();
            PAYAIND.cs_interupt_comp s = new PAYAIND.cs_interupt_comp();
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_device_name.DataSource = source.fillcombonamedevicebycod();
            combo_device_name.DisplayMember = "xnamedevice";
           try
            {
                combo_device_name.ValueMember = "xcoddevice";
                combo_device_name.SelectedIndex = -1;
  
            }
            catch {  }

           combo_operator_name_first.DataSource = s.operator_name();
           combosecondoperator.DataSource = s.operator_name();
           combo_operator_name_first.DisplayMember = "xname";
           combo_operator_name_first.ValueMember = "xid";
           combosecondoperator.DisplayMember = "xname";
           combosecondoperator.ValueMember = "xid";
            combo_operator_name_first.DataSource = s.operator_name();
            combosecondoperator.DataSource = s.operator_name();
            PAYAIND.cs_interupt_comp cs1 = new PAYAIND.cs_interupt_comp();          
            dataGridView1.DataSource = cs1.datasourcecheckbox();
        }

        private void txth1_Leave(object sender, EventArgs e)
        {
            Validation.time cs = new Validation.time();
            PAYAIND.csshamsidateandtime cc = new PAYAIND.csshamsidateandtime();
            try
            {
                txtleave((System.Windows.Forms.TextBox)(sender));
                 }
            catch { }
            txttime.Text = cc.distansebetweendayandtime(txtdatestart.Text, txtdateend.Text, txth1.Text, txthend.Text).ToString(); 
           
        }
        
        public void txtleave(TextBox sender)
        {
            Validation.time cs = new Validation.time();
            sender.Text = cs.returnexpandtime(sender.Text);
          //  if (!cs.validtime(sender.Text))
            {
             //   sender.Text = "";
              //  sender.BackColor = Color.Red;
            }
           
        }

        private void txtdateplan_Leave(object sender, EventArgs e)
        {
            PAYAIND.csshamsidateandtime cs = new PAYAIND.csshamsidateandtime();

            if  (cs.bigerdatetime( txtdatestart.Text, txtdateplan.Text ))
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
            if (((System.Windows.Forms.Control)(sender)==txtdateplan)||((System.Windows.Forms.Control)(sender)==txtdatestart))
            if (cs.bigerdatetime(txtdateplan.Text, txtdatestart.Text))
                MessageBox.Show("تاریخ سرویس قبل از برنامه زمانبندی است؟");
            if ((System.Windows.Forms.Control)(sender)==txtdateend)
            //if (cs.bigerdatetime(txtdatestart.Text, txtdateend.Text))
               // MessageBox.Show("تاریخ اتمام سرویس باید قبل از شروع سرویس باشد");
            txth1_Leave(null, null);
               
        }

        private void frmaddinterupt_plan_Load(object sender, EventArgs e)
        {
            PAYAIND.csinterupt_plan cs = new PAYAIND.csinterupt_plan();
            foreach (DataGridViewRow rr in dataGridView1.Rows)
            {
                //      if (cs.selectdemuerofinterupt(Convert.ToInt32(id), (int)rr.Cells["xid"].Value))
                { rr.Cells["select"].Value = "1"; }
            }
           
            if (!edit)
                initaliz();
            else combo_device_name.Enabled = false;
           // try
            {
               
            }
          //  catch { }
        txtdateplan_Leave(null, null);
        }
        private void initaliz()
        {
            
            PAYAIND.csshamsidateandtime cs = new PAYAIND.csshamsidateandtime();
            ////////////////////////////////////////////////////////////////////دستور زیر در آینده باید تعویض گردد
           // txtdateplan.Text = cs.calcshmsidate();
            txtdateend.Text = cs.calcshmsidate();
            txtdatestart.Text = txtdateend.Text;
            txth1.Text = cs.calctime();
            txthend.Text = cs.calctime();         

        }
        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
            try
            {
                combo_device_no.DisplayMember = "xnumber";
                combo_device_no.ValueMember = "xnumber";
            }
            catch { }
            //if (!edit)
            //    combo_device_no.SelectedIndex = 0;
        }
        public string id;
        public int idprogram;

        private void buttonX1_Click(object sender, EventArgs e)
        {
            combo_operator_name_first.Text = "";
            combosecondoperator.Text = "";
            txth1_Leave(null, null);


            foreach (Control c in this.Controls)
            {


                if (c.BackColor == Color.Red) { MessageBox.Show("لطفا کلیه مقادیر را چک کنید"); return; }


            }
            PAYAIND.csshamsidateandtime cc= new PAYAIND.csshamsidateandtime();
            PAYAIND.csinterupt_plan db = new PAYAIND.csinterupt_plan();
            PAYAIND.fillcombo cod = new PAYAIND.fillcombo();
            if (cc.distansebetweendayandtime(txtdatestart.Text, txtdateend.Text, txth1.Text, txthend.Text)<3)
            {

               MessageBox.Show("مدت زمان سرویس دستگاه صحیح نیست");
                return;
            }

            if (groupBox1.Visible)
            {
                bool flag = false;

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["select"].Value == "1")
                        flag = true;

                }
                if (!flag) { MessageBox.Show("علت تاخیر در تعمیرات را انتخاب کنید"); return; }
            }
            int index = 0;
           
         // try
            {
                PAYAIND.csserviceprogram ccc = new PAYAIND.csserviceprogram();
                bool m = ccc.returntypeservic(txtdateplan.Text, combo_device_name.SelectedValue.ToString(), combo_device_no.Text);
                string coddevice;
                coddevice = cod.cod_of_deviceforinterupt(combo_device_name.Text, combo_device_no.Text);
                if (combo_device_no.Text == "")
                    coddevice = cod.cod_of_deviceforinterupt(combo_device_name.Text, "01");
                 
                if (!edit)
                {
                    index = db.insertintointeruptplan(idserviceprigram,txtdateplan.Text, txtdatestart.Text, txth1.Text, txtdateend.Text, txthend.Text, coddevice, combo_operator_name_first.Text, combosecondoperator.Text, txtexplainhavoc.Text, txtexplainactivity.Text, txttime.Text, groupBox1.Visible,m);
                   
                    servic(index);
                }
                else
                {
                    

                    idprogram = ccc.returnidservic(txtdateplan.Text, combo_device_name.SelectedValue.ToString() , combo_device_no.Text);
                    db.updateinteruptplan(idprogram, id, txtdateplan.Text, txtdatestart.Text, txth1.Text, txtdateend.Text, txthend.Text, coddevice, combo_operator_name_first.Text, combosecondoperator.Text, txtexplainhavoc.Text, txtexplainactivity.Text, txttime.Text, groupBox1.Visible,m);
                } db.deletalldemuerofinterupt(Convert.ToInt32(id));
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["select"].Value == "1")
                    {
                        db.insertdemuerforinterupt((int)r.Cells["xid"].Value, Convert.ToInt32(id));
                    }
                }
                MessageBox.Show("اطلاعات ذخیره شد");//,"",FarsiMessageBox.FMessageBoxIcons.Information,4000); 
                Close();
            }
        //  catch { MessageBox.Show("در ذخیره اطلاعات مشکلی بوجود آمد ،لطفا مقادیر ورودی را چک کنید"); }
           

           

        }
        public void servic(int index)
        {PAYAIND.csinterupt_plan cs= new PAYAIND.csinterupt_plan();
       PAYAIND.csserviceprogram ccc = new PAYAIND.csserviceprogram();
                bool m = ccc.returntypeservic(txtdateplan.Text, combo_device_name.SelectedValue.ToString() , combo_device_no.Text);
            dataGridView222.DataSource = cs.fillservic(combo_device_name.SelectedValue.ToString(),m);
            for (int i = 0; i < dataGridView222.Rows.Count; i++)
            {
                cs.insertservicforinterupt(Convert.ToInt32(dataGridView222.Rows[i].Cells["xid"].Value), index);              

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.service.frmselectserviceforinterupt f = new service.frmselectserviceforinterupt();
            if (f.ShowDialog() == DialogResult.OK)
            {
                combo_device_name.SelectedValue = f.dataGridView1.CurrentRow.Cells["xdevicecod"].Value;
                combo_device_name_SelectedIndexChanged(null, null);
                combo_device_no.Text = f.dataGridView1.CurrentRow.Cells["xdevicenumber"].Value.ToString();
                txtdateplan.Text = f.dataGridView1.CurrentRow.Cells["xdate"].Value.ToString();
                txtdatestart.Text=txtdateplan.Text;
                txtdateend.Text = txtdateplan.Text;
                txth1.Text = f.dataGridView1.CurrentRow.Cells["xtimestart"].Value.ToString();
                txthend.Text = f.dataGridView1.CurrentRow.Cells["xtimeend"].Value.ToString();
                idserviceprigram =(int) f.dataGridView1.CurrentRow.Cells["xid"].Value; 
            }

        }

        private void txth1_Enter(object sender, EventArgs e)
        {
            ((System.Windows.Forms.TextBox)(sender)).BackColor = Color.White;
        }

        private void uStatusBar1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAYAIND.fillcombo c = new PAYAIND.fillcombo();
            PAYAIND.csserviceprogram cs = new PAYAIND.csserviceprogram();
           txtexplainhavoc.Text= cs.returnexplainforservice(c.cod_of_device(combo_device_name.Text), combo_device_no.Text, txtdateplan.Text);
        }

      
    }
}
