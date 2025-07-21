using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form.interupt
{
    public partial class frm_interupt_comp : Form
    {
        PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
        PAYAIND.csdisposal_object csdo = new PAYAIND.csdisposal_object();
        PAYADATA.disposal_object.dsdisposl_object.viewdisposal_objectDataTable datatableobject = new PAYADATA.disposal_object.dsdisposl_object.viewdisposal_objectDataTable();


        public frm_interupt_comp()
        {

            InitializeComponent();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            interupt.frm_edit_interupt_comp frm = new frm_edit_interupt_comp();
            frm.ShowDialog();
            frm.Dispose();
            btn_show_Click(null, null);
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            // bindingSource1.DataSource= 
            dataGridView1.DataSource = dt = cs.fill_interupt(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
        }
        private void headerdata()
        {
            //dataGridView1.Columns["x_id"].HeaderText = "کد توقف";
            //dataGridView1.Columns["xdevice_cod"].HeaderText = "کد وسیله";
            //dataGridView1.Columns["xidfirstoperator"].HeaderText = "اپراتور تحویل دهنده";
            //dataGridView1.Columns["xdate_start_interupt"].HeaderText = "تاریخ وقوع خرابی";
            //dataGridView1.Columns["xtime_start_interupt"].HeaderText = "زمان وقوع خرابی";
            //dataGridView1.Columns["xelat_interupt"].HeaderText = "شرح علت خرابی";
            //dataGridView1.Columns["xtime_start_repair"].HeaderText = "زمان شروع تعمیرات";
            //dataGridView1.Columns["x_activity"].HeaderText = "شرح فعالیتهای انجام شده";
            //dataGridView1.Columns["xdate_end_repair"].HeaderText = "تاریخ اتمام تعمیرات";
            //dataGridView1.Columns["xtime_end_repair"].HeaderText = "زمان اتمام تعمیرات";

            //dataGridView1.Columns["xidsecond_operator"].HeaderText = "اپراتور تحویل گیرنده";
            //dataGridView1.Columns["xdate_start_repair"].HeaderText = "تاریخ شروع تعمیرات";
            //dataGridView1.Columns["xtime_deliver_tonet"].HeaderText = "زمان تحویل به نت";
            //dataGridView1.Columns["xdate_deliver_tonet"].HeaderText = "تاریخ تحویل به نت";
            //dataGridView1.Columns["xdate_delivertopro"].HeaderText = "تاریخ تحویل به تولید";
            //dataGridView1.Columns["xtime_delivertopro"].HeaderText = "زمان تحویل به تولید";
            //dataGridView1.Columns["xtime_repairing"].HeaderText = "مدت زمان تعمیرات";
            //dataGridView1.Columns["xtime_interupt"].HeaderText = "مدت زمان توقف دستگاه";
            //dataGridView1.Columns["xtime_between_in_re"].HeaderText = "فاصله زمانی بین وقوع خرابی تا شروع تعمیرات";
            ////dataGridView1.Columns["xcause_demur"].HeaderText = "علت تاخیر در تعمیرات";





        }
        private void headerclient()
        {
            try
            {

                dataGridrepairer.Columns["xid_interupt"].HeaderText = "شماره توقف";
                dataGridrepairer.Columns["xid_interupt"].Visible = false;
                dataGridrepairer.Columns["xname_repairer"].HeaderText = "نام سرویس کار";
                dataGridrepairer.Columns["xhours"].HeaderText = "ساعت کارکرد ";
                dataGridrepairer.Columns["xid"].HeaderText = "ردیف ";
                dataGridrepairer.Columns["xid"].Visible = false;
            }
            catch { }
            try
            {
              /*  dataGrid_objects.Columns["xid_interupt"].HeaderText = "شماره توقف";
                dataGrid_objects.Columns["xid_interupt"].Visible = false;
                dataGrid_objects.Columns["xname"].HeaderText = "نام قطعه مصرف شده";
                dataGrid_objects.Columns["xcount"].HeaderText = " تعداد قطعه مصرف شده";
                dataGrid_objects.Columns["xnameset1"].HeaderText = "نام مجموعه اصلی";
                dataGrid_objects.Columns["xnameset2"].HeaderText = "نام مجموعه فرعی";
                dataGrid_objects.Columns["xnameset3"].HeaderText = "نام مجموعه فرعی دوم";
                dataGrid_objects.Columns["xid"].HeaderText = "ردیف";
                dataGrid_objects.Columns["xid"].Visible = false;
                dataGrid_objects.Columns["xtype"].HeaderText = "نوع";
                dataGrid_objects.Columns["xtype"].Visible = false;
                dataGrid_objects.Columns["x_cod_objects_disposal"].HeaderText = "کد قطعه مصرفی";*/
                dataGrid_objects.Columns["xnamedevice"].HeaderText = "نام دستگاه";
                dataGrid_objects.Columns["xnamedevice"].Visible = false;
                dataGrid_objects.Columns["xnumber"].HeaderText = "شماره دستگاه";
                dataGrid_objects.Columns["xnumber"].Visible = false;
                dataGrid_objects.Columns["xname"].HeaderText = "نام قطعه مصرف شده";
                dataGrid_objects.Columns["xnameset1"].HeaderText = "نام مجموعه اصلی";
                dataGrid_objects.Columns["xnameset2"].HeaderText = "نام مجموعه فرعی";
                dataGrid_objects.Columns["xnameset3"].HeaderText = "نام مجموعه فرعی دوم";
                dataGrid_objects.Columns["xid"].HeaderText = "ردیف";
                dataGrid_objects.Columns["xid"].Visible = false;
                dataGrid_objects.Columns["x_cod_objects_disposal"].HeaderText = "کد قطعه مصرفی";
                dataGrid_objects.Columns["xcount"].HeaderText = "تعداد قطعه مصرفی";
                dataGrid_objects.Columns["xtype"].HeaderText = "نوع";
                dataGrid_objects.Columns["xtype"].Visible = false;
                dataGrid_objects.Columns["xid_interupt"].HeaderText = "شماره توقف";
                dataGrid_objects.Columns["xid_interupt"].Visible = false;
                dataGrid_objects.Columns["xdate_plan"].Visible = false;

            }
            catch { }
        }
        bool editable;
        private void frm_interupt_comp_Load(object sender, EventArgs e)
        {
            //allowuser cs = new allowuser();
            //if (cs.allowuserforobject("interuptcomp", true))
            //{
               editable = true;
            //}
            //else editable = false;

           
            dataGridView1.AutoGenerateColumns = true;
            //btn_show_Click(null, null);
            headerdata();

        }
        public string coddevice;
        private void filterobject()
        {
            try
            {
                coddevice = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString();
                //combobject.DataSource = cs.filterobject(dataGridView1.CurrentRow.Cells[1].Value.ToString(), txtfiltername.Text);
                //combobject.DisplayMember = "xname";
                //combocodobject.DataSource = combobject.DataSource;// cs.filterobject(dataGridView1.CurrentRow.Cells[1].Value.ToString(), txtfiltername.Text);
                //combocodobject.DisplayMember = "xcod";   
            }
            catch { }
        }
 
        public static int cod_interupt = 0;


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cod_interupt = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["x_id"].Value);
                coddevice = dataGridView1.Rows[e.RowIndex].Cells["xdevice_cod"].Value.ToString();

            }
            catch { }
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void txtfiltername_TextChanged(object sender, EventArgs e)
        {
            filterobject();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            if ((combobject.Text == "") || (txtcount.Text == "")) { FarsiMessageBox.FMessageBox.Show("لطفا اطلاعات را کامل کنید"); return; }

            csdo.insertobjectmasrafi(dataGridView1.CurrentRow.Cells[0].Value.ToString(), combocodobject.Text, txtcount.Text, "comp");
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void combobject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                combocodobject.SelectedIndex = combobject.SelectedIndex; ;
            }
            catch { }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            if ((combonameservice.Text == "") || (txtnafarsaat.Text == "")) { FarsiMessageBox.FMessageBox.Show("لطفا اطلاعات را کامل کنید"); return; }
            cs.insertservickaran(dataGridView1.CurrentRow.Cells["x_id"].Value.ToString(), combonameservice.Text, txtnafarsaat.Text, "comp");
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            DialogResult key = new DialogResult();

            key = FarsiMessageBox.FMessageBox.Show("آیا مطمئنید که می خواهید این توقف را حذف کنید؟؟", "حذف شود؟", FarsiMessageBox.FMessageBoxButtons.YesNo, FarsiMessageBox.FMessageBoxIcons.Question);

            // key = MessageBox.Show("آیا مطمئنید که می خواهید این توقف را حذف کنید؟؟", "", MessageBoxButtons.YesNo);
            if (key == DialogResult.Yes)
            {
                //  f = new frmmessagebox("این کار برگشت ناپذیر است ،مطمئنید؟", "", MessageBoxButtons.YesNo);
                key = FarsiMessageBox.FMessageBox.Show("این کار برگشت ناپذیر است ،مطمئنید؟", "حذف شود؟", FarsiMessageBox.FMessageBoxButtons.YesNo, FarsiMessageBox.FMessageBoxIcons.Question);

                if (key == DialogResult.Yes)

                    try
                    {
                        string daterequest = dataGridView1.CurrentRow.Cells["xdate_request"].Value.ToString();
                        string timerequest = dataGridView1.CurrentRow.Cells["xtime_request"].Value.ToString();
                        PAYAIND.csactioncenter csaction = new PAYAIND.csactioncenter(BLL.authentication.userid);
                        cs.deleteinterupt(dataGridView1.CurrentRow.Cells["x_id"].Value.ToString());
                        csaction.eventrequestrenovationsolved(timerequest, daterequest);
                        btn_show_Click(null, null);
                    }
                    catch { }
            }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
            DialogResult key = new DialogResult();
            key = FarsiMessageBox.FMessageBox.Show("آیا مطمئنید که می خواهید این قطعه را حذف کنید؟؟", "", FarsiMessageBox.FMessageBoxButtons.YesNo);
            if (key == DialogResult.Yes)
                try
                {
                   
                    csdo.delet_object_disposal((int)dataGrid_objects.CurrentRow.Cells["xid"].Value);
                    bindingSource2.RemoveCurrent();
                  //  cs.saveobjectdispos(datatableobject);

                }
                catch { }
        }

        private void bindingNavigatorDeleteItem2_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            DialogResult key = new DialogResult();
            key = FarsiMessageBox.FMessageBox.Show("آیا مطمئنید که می خواهید این سرویس کار را حذف کنید؟؟", "", FarsiMessageBox.FMessageBoxButtons.YesNo, FarsiMessageBox.FMessageBoxIcons.Question);
            if (key == DialogResult.Yes)
            {
                cs.deletservice(dataGridrepairer.CurrentRow.Cells["xid"].Value.ToString(), "comp");
                tabControl1_SelectedIndexChanged(null, null);
            }

        }
        //private void bb()
        //{
        //    DataTable dt = new DataTable();
        //    foreach (DataRow r in dataGridView1.Rows)
        //    dt.Rows.Add(r);

        //}
        PAYADATA.interuptcomp.dsinteruptcomp.interupt_compDataTable dt;

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            {
                bindingSource1.EndEdit();
                dataGridView1.EndEdit();
            }
            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
             if (cs.updateinteruptcomptable(dt)) MessageBox.Show("با موفقیت ذخیره شد");
             else MessageBox.Show("عملیات ناموفق بود");

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
            form.interupt.frm_edit_interupt_comp f = new frm_edit_interupt_comp();
            f.edit = true;
            DataGridViewRow r = dataGridView1.CurrentRow;
            f.combo_operator_name_first.SelectedValue = r.Cells["xidfirstoperator"].Value;
            f.combo_operator_name_last.SelectedValue = r.Cells["xidsecond_operator"].Value;
            f.combo_device_name.SelectedValue = r.Cells["xdevice_cod"].Value.ToString().Substring(0,3) +"      ";
            f.combo_device_no.Text = r.Cells["xdevice_cod"].Value.ToString().Trim().Substring(4, 2);
            f.combo_device_no.Enabled = false;
            f.id = r.Cells["x_id"].Value.ToString();
            f.txtdate1.Text = returntruedate(r.Cells["xdate_start_interupt"].Value.ToString());
            f.txtdatedelivertonet.Text = returntruedate(r.Cells["xdate_deliver_tonet"].Value.ToString());
            f.txtdatedelivertopro.Text = returntruedate(r.Cells["xdate_delivertopro"].Value.ToString());
            f.txtdateendrepair.Text = returntruedate(r.Cells["xdate_end_repair"].Value.ToString());
            f.txtdatestartrepair.Text = returntruedate(r.Cells["xdate_start_repair"].Value.ToString());
            f.txth1.Text = returntruetime(r.Cells["xtime_start_interupt"].Value.ToString());
            /////
            f.idrequester = (int)r.Cells["xiduserrequest"].Value;
            f.daterequest = r.Cells["xdate_request"].Value.ToString();
            f.timerequest = r.Cells["xtime_request"].Value.ToString();
            ///////////
            f.txthdelivertopro.Text = returntruetime(r.Cells["xtime_delivertopro"].Value.ToString());
            f.txthendrepair.Text = returntruetime(r.Cells["xtime_end_repair"].Value.ToString());
            f.txthstartrepair.Text = returntruetime(r.Cells["xtime_start_repair"].Value.ToString());
            f.txthdelivertonet.Text = returntruetime(r.Cells["xtime_deliver_tonet"].Value.ToString());
            f.txtactivity.Text = (r.Cells["x_activity"].Value.ToString());
            f.txtelat.Text = (r.Cells["xelat_interupt"].Value.ToString());
            f.txttimeinterupt.Text = (r.Cells["xtime_interupt"].Value.ToString());
            f.dataGridView2.DataSource = cs.selecttrubleofrequestrenovation(Convert.ToInt32(r.Cells["x_id"].Value));
            try
            {
                f.radioButton1.Checked = (bool)r.Cells["xmecanical"].Value;
                f.radioButton2.Checked = !f.radioButton1.Checked;
            }
            catch
            {
                f.radioButton1.Checked = true;
                f.radioButton2.Checked = false;
            }


            //for (int i = 0; i < f.checkedListBox1.Items.Count; i++)
            //{
            //    string s = r.Cells["xcause_demur"].Value.ToString();
            //    if (s.Contains(f.checkedListBox1.Items[i].ToString()))
            //        f.checkedListBox1.SetItemChecked(i, true);
            //}
            f.ShowDialog();
            btn_show_Click(null, null);
        }
        private string returntruetime(string time)
        {
            PAYAIND.csshamsidateandtime css = new PAYAIND.csshamsidateandtime();
            try
            {
                Validation.time cs = new Validation.time();
                if (cs.validtime(time)) return time;

            }

            catch
            {
                return css.calctime();
            }
            return css.calctime();

        }
        private string returntruedate(string date)
        {
            PAYAIND.csshamsidateandtime cc = new PAYAIND.csshamsidateandtime();
            try
            {
                DateTime dd = new DateTime();
                dd = Convert.ToDateTime(date);
                string yy = dd.Year.ToString();
                string m = dd.Month.ToString().Length > 1 ? dd.Month.ToString() : "0" + dd.Month.ToString();
                string d = dd.Day.ToString().Length > 1 ? dd.Day.ToString() : "0" + dd.Day.ToString();
                return yy + "/" + m + "/" + d;
            }
            catch { return cc.calcshmsidate(); }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           // form.coding.frm_objectfordisposal f = new coding.frm_objectfordisposal();
           // f.combo_device_name.SelectedValue = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString().Substring(0, 3) + "      ";
           // f.combo_device_no.Text = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString().Trim().Substring(4, 2);
           // f.ShowDialog();
           // if (f.cod != "") { combobject.Text = f.name; combocodobject.Text = f.cod; } 



           ///* coddevice = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString();
           // form.frmfilterallobject f = new frmfilterallobject();
           // f.coddevice = coddevice;
           // f.ShowDialog();
           // if (f.cod != "")
           // {
           //     combobject.Text = f.name; combocodobject.Text = f.cod;
           // }
           // */
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == objects_tab)
            {

                datatableobject = csdo.fill_objectbycod(cod_interupt, "comp");
                bindingSource2.DataSource = datatableobject;
                dataGrid_objects.DataSource = bindingSource2;
                dataGrid_objects.AutoGenerateColumns = true;
                filterobject();
                bindingNavigator2.BindingSource = bindingSource2;
            }
            else
            {
                bindingSource3.DataSource = cs.fill_repairer_inteuptcomp(cod_interupt);
                dataGridrepairer.DataSource = bindingSource3;
                bindingNavigator3.BindingSource = bindingSource3;
                combonameservice.DataSource = cs.fillcomborepairer();
                combonameservice.DisplayMember = "xname";
                combonameservice.ValueMember = "xid";
            }
            headerclient();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt = cs.fill_interupt(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

        }
    }
}