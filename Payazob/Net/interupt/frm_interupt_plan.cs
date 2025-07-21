using System;
using System.Drawing;
using System.Windows.Forms;


namespace PAYAZOBNET.form.interupt
{

    public partial class frm_interupt_plan : Form
    {
        PAYAIND.fillcombo css = new PAYAIND.fillcombo();
        PAYADATA.Datasetcurrent.mcurrenDataTable datacurrent = new PAYADATA.Datasetcurrent.mcurrenDataTable();
        PAYAIND.cscurrent csc = new PAYAIND.cscurrent();
        PAYAIND.csdisposal_object csdo = new PAYAIND.csdisposal_object();
        
       
        
        public frm_interupt_plan()
        {
            InitializeComponent();
        }
        PAYAIND.csshamsidateandtime csh = new PAYAIND.csshamsidateandtime();

        private bool editable = false;
        private void frm_interupt_plan_Load(object sender, EventArgs e)
        {
            
            //allowuser cs = new allowuser();
            //  if (cs.allowuserforobject("interuptplan", true))
            //  {
            //      editable = true;
            //  }
            //  else editable = false;
            uc_Filter_Date1.DateTo=csh.calcshmsidate();
            //**************************************************
            int day = int.Parse(csh.calcshmsidate().Substring(8, 2));
            //**************************************************
           uc_Filter_Date1.Text= csh.previousDay(day-1);          
       //    toolStripBtnshow_Click(null, null);
           Show_data();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            interupt.frmaddinterupt_plan f = new frmaddinterupt_plan();
            f.ShowDialog();
            Show_data();
            dataGridView1_RowEnter(null, null);
        }
        
        PAYADATA.interuptplan.dsinteruptplan.Select_interuptplanDataTable dt = new PAYADATA.interuptplan.dsinteruptplan.Select_interuptplanDataTable();

        PAYADATA.interuptcomp.dsinteruptcomp.mobject_disposalDataTable datatableobject;
      
        private void currentmsgrid()
        {

            /*  foreach (DataGridViewRow r in dataGridViewcurrent.Rows)
              {
                  // r.Cells["xcurrentmsgid"].Value = csc.selectcurrentmsgbycod(csc.sellectcodeforcurrentmsg((int)r.Cells["xidcurrentrenge"].Value, (float)r.Cells["xcurrentR"].Value, (float)r.Cells["xcurrentS"].Value, (float)r.Cells["xcurrentT"].Value));
                
                  r.Cells["currentmsg"].Value = csc.selectcurrentmsgbycod(r.Cells["xcurrentmsg"].Value.ToString());
                  r.Cells["xmotorname"].Value = css.fillcombonamedeviceset(csc.sellectcodedeviccurrentreng((int)r.Cells["xidcurrentrenge"].Value));
                  string sss = r.Cells["xcurrentmsg"].Value.ToString();
                  setcolorcurrendatgrid(sss.Substring(0, 1), "xcurrentR",r);
                  setcolorcurrendatgrid(sss.Substring(1, 1), "xcurrentS",r);
                  setcolorcurrendatgrid(sss.Substring(2, 1), "xcurrentT",r);

              }*/

            foreach (DataGridViewRow r in dataGridViewcurrent.Rows)
            {    
                //r.Cells["xcurrentmsgid"].Value = csc.selectcurrentmsgbycod(csc.sellectcodeforcurrentmsg((int)r.Cells["xidcurrentrenge"].Value, (float)r.Cells["xcurrentR"].Value, (float)r.Cells["xcurrentS"].Value, (float)r.Cells["xcurrentT"].Value));
                r.Cells["xcurrentmsg"].Value = csc.sellectcodeforcurrentmsg((int)r.Cells["xidcurrentrenge"].Value, (float)r.Cells["xcurrentR"].Value, (float)r.Cells["xcurrentS"].Value, (float)r.Cells["xcurrentT"].Value);
                r.Cells["currentmsg"].Value = csc.selectcurrentmsgbycod(r.Cells["xcurrentmsg"].Value.ToString());
                r.Cells["xmotorname"].Value   =csc.devicenameforcurrent(csc.sellectcodedeviccurrentreng((int)r.Cells["xidcurrentrenge"].Value).Trim());
                setcolorcurrendatgrid(csc.sellectcodeforcurrentmsg((int)r.Cells["xidcurrentrenge"].Value, (float)r.Cells["xcurrentR"].Value, (float)r.Cells["xcurrentS"].Value, (float)r.Cells["xcurrentT"].Value).Substring(0, 1), "xcurrentR", r);
                string sss = csc.sellectcodeforcurrentmsg((int)r.Cells["xidcurrentrenge"].Value, (float)r.Cells["xcurrentR"].Value, (float)r.Cells["xcurrentS"].Value, (float)r.Cells["xcurrentT"].Value);
                setcolorcurrendatgrid(sss.Substring(0, 1), "xcurrentR", r);
                setcolorcurrendatgrid(sss.Substring(1, 1), "xcurrentS", r);
                setcolorcurrendatgrid(sss.Substring(2, 1), "xcurrentT", r);

            }

            /*foreach (DataGridViewRow r in dataGridViewcurrent.Rows)
               {
                   int currentidtype = csc.selectcurrenttypeid((int)r.Cells["xidcurrentrenge"].Value);
                
                   if (currentidtype == 1)
                   { 
                      // MessageBox.Show(csc.selectcurrenttypeid((int)r.Cells["xidcurrentrenge"].Value).ToString()+currentidtype.ToString());
                       r.Cells["currentT"].Style.ForeColor = Color.Black;
                       r.Cells["currentT"].ReadOnly = true;
                       r.Cells["currentR"].ReadOnly = true;
                       r.Cells["currentS"].ReadOnly = true;
                 
                   }
    

               }*/
        }

        private void setcolorcurrendatgrid(string strswitch, string column, DataGridViewRow r)
        {

            switch (strswitch)
            {



                case "1":
                    r.Cells[column].Style.SelectionForeColor = Color.Black;
                    // r.Cells["column"].Style.SelectionBackColor = Color.Red;
                    r.Cells[column].Style.BackColor = Color.LimeGreen;
                    r.Cells[column].Style.ForeColor = Color.Black;
                    break;

                case "2":
                    r.Cells[column].Style.SelectionForeColor = Color.Black;
                    //r.Cells[column].Style.SelectionBackColor = Color.Red;
                    r.Cells[column].Style.BackColor = Color.FromArgb(0x00, 0x66, 0xFF);
                    r.Cells[column].Style.ForeColor = Color.Black;
                    //r.Cells[column].ReadOnly = true;

                    break;

                case "3":

                    r.Cells[column].Style.SelectionForeColor = Color.Black;
                    // r.Cells[column].Style.SelectionBackColor = Color.Red;
                    r.Cells[column].Style.BackColor = Color.Red;
                    r.Cells[column].Style.ForeColor = Color.Black;
                    break;
                default:
                    break;
            }
        }



        private void headerclient()
        {
            try
            {
//*****************************************************************************************
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
                
           //******************************************************************************************
               
               // dataGrid_objects.Columns["xcount"].HeaderText = " تعداد قطعه مصرف شده";
               /* dataGrid_objects.Columns["xname"].HeaderText = "نام قطعه مصرف شده";
                dataGrid_objects.Columns["xcount"].HeaderText = " تعداد قطعه مصرف شده";
                dataGrid_objects.Columns["xnameset1"].HeaderText = "نام مجموعه اصلی";
                dataGrid_objects.Columns["xnameset2"].HeaderText = "نام مجموعه فرعی";
                dataGrid_objects.Columns["xnameset3"].HeaderText = "نام مجموعه فرعی دوم";
                dataGrid_objects.Columns["xid"].HeaderText = "ردیف";
                dataGrid_objects.Columns["xid"].Visible = false;
                dataGrid_objects.Columns["xtype"].HeaderText = "نوع";
                dataGrid_objects.Columns["x_cod_objects_disposal"].HeaderText = "کد قطعه مصرفی";
                dataGrid_objects.Columns["xtype"].Visible = false;*/
            }
            catch { }
            try
            {
                dataGridrepairer.Columns["xid_interupt"].HeaderText = "شماره توقف";
                dataGridrepairer.Columns["xid_interupt"].Visible = false;
                dataGridrepairer.Columns["xname_repairer"].HeaderText = "نام سرویس کار";
                dataGridrepairer.Columns["xhours"].HeaderText = "ساعت کارکرد ";
                dataGridrepairer.Columns["xid"].HeaderText = " ردیف";
                dataGridrepairer.Columns["xid"].Visible = false;
            }
            catch { }
        }
        public string coddevice;
        private void filterobject()
        {
            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
           
           try
           {
               coddevice = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString();            
                //combobject.DataSource = cs.filterobject(dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString(), txtfiltername.Text);
                //combobject.DisplayMember = "xname";
                //combocodobject.DataSource = combobject.DataSource;// cs.filterobject(dataGridView1.CurrentRow.Cells[1].Value.ToString(), txtfiltername.Text);
                //combocodobject.DisplayMember = "xcod";
            }
           catch {}
        }
        public static int cod_interupt = 0;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cod_interupt = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["xid_"].Value);
                coddevice = dataGridView1.Rows[e.RowIndex].Cells["xdevice_cod"].Value.ToString();

            }
            catch { }
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void saveToolStripButton1_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            dataGridView1.EndEdit();
            PAYAIND.csinterupt_plan cs = new PAYAIND.csinterupt_plan();         
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            form.interupt.frmaddinterupt_plan f = new frmaddinterupt_plan();
            f.edit = true;            
            DataGridViewRow r = dataGridView1.CurrentRow;
            f.combo_operator_name_first.Text = r.Cells["xname_operator_deliveryof"].Value.ToString();
            f.txtdateend.Text =returntruedate( r.Cells["xdate_endinterupt"].Value.ToString());
            f.txtdateplan.Text = returntruedate(r.Cells["xdate_plan"].Value.ToString()) ;
            f.txtdatestart.Text =returntruedate( r.Cells["xdatestart_interupt"].Value.ToString()) ;
            f.txtexplainactivity.Text = r.Cells["xexplain_activity"].Value.ToString();
            f.txtexplainhavoc.Text = r.Cells["xexplain_havoc"].Value.ToString();
            f.txth1.Text = r.Cells["xtime_startinterupt"].Value.ToString();
            f.txthend.Text = r.Cells["xtime_endinterupt"].Value.ToString();
            f.combosecondoperator.Text = r.Cells["xname_operator_transferee"].Value.ToString();
         f.combo_device_name.SelectedValue = r.Cells["xdevice_cod"].Value.ToString().Substring(0,3) +"      ";      
            f.combo_device_no.Text = r.Cells["xdevice_cod"].Value.ToString().Substring(4, 2);
            f.id= r.Cells["xid_"].Value.ToString();
            //for (int i = 0; i < f.checkedListBox1.Items.Count; i++)
            //{string s= r.Cells["xcause_delay_in_service"].Value.ToString();
            //if (s.Contains(f.checkedListBox1.Items[i].ToString()))
            //    f.checkedListBox1.SetItemChecked(i, true);
            //}
            f.button1.Enabled = false;
            f.ShowDialog();
           // toolStripBtnshow_Click(null, null);
            Show_data();
            dataGridView1_RowEnter(null, null);
        }
        private string returntruedate(string date)
        {
            DateTime dd = new DateTime();
            dd = Convert.ToDateTime(date);
            string yy= dd.Year.ToString();
            string m= dd.Month.ToString().Length>1? dd.Month.ToString():"0"+dd.Month.ToString();
            string d = dd.Day.ToString().Length > 1 ? dd.Day.ToString() : "0" + dd.Day.ToString();
            return yy + "/" + m + "/" + d;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            PAYAIND.csinterupt_plan cc= new PAYAIND.csinterupt_plan();
        DialogResult key = FarsiMessageBox.FMessageBox.Show("این ردیف حذف شود", "حذف؟؟", FarsiMessageBox.FMessageBoxButtons.YesNo);
            if (key == DialogResult.Yes)
            {
                try
                {
                    cc.delete(dataGridView1.CurrentRow.Cells["xid_"].Value.ToString());
                    bindingSource1.RemoveCurrent();
                }
               catch
                {
                }
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
           // PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
            if ((combobject.Text == "") || (txtcount.Text == "")) { FarsiMessageBox.FMessageBox.Show("لطفا اطلاعات را کامل کنید"); return; }
            csdo.insertobjectmasrafi(dataGridView1.CurrentRow.Cells[0].Value.ToString(), combocodobject.Text, txtcount.Text,"plan");
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
            if ((combonameservice.Text == "") || (txtnafarsaat.Text == "")) { FarsiMessageBox.FMessageBox.Show("لطفا اطلاعات را کامل کنید"); return; }
            cs.insertservickaran(dataGridView1.CurrentRow.Cells["xid_"].Value.ToString(), combonameservice.Text, txtnafarsaat.Text, "plan");
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
           // PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
        
            DialogResult key = new DialogResult();
            key = FarsiMessageBox.FMessageBox.Show("آیا مطمئنید که می خواهید این قطعه را حذف کنید؟؟", "", FarsiMessageBox.FMessageBoxButtons.YesNo);
            if (key == DialogResult.Yes)
                try
                {
                    csdo.delet_object_disposal((int)dataGrid_objects.CurrentRow.Cells["xid"].Value);
                    bindingSource2.RemoveCurrent();
                   // cs.saveobjectdispos(datatableobject);  
                }
                catch { }
        }

        private void bindingNavigatorDeleteItem2_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
            DialogResult key = new DialogResult();
            key = FarsiMessageBox.FMessageBox.Show("آیا مطمئنید که می خواهید این سرویس کار را حذف کنید؟؟", "", FarsiMessageBox.FMessageBoxButtons.YesNo);
            if (key == DialogResult.Yes)
            {
                cs.deletservice(dataGridrepairer.CurrentRow.Cells["xid"].Value.ToString(), "plan");
                tabControl1_SelectedIndexChanged(null, null);
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            dataGridView2.EndEdit();
            PAYAIND.csinterupt_plan cs = new PAYAIND.csinterupt_plan();
            bool ch;
            string ex;
            int id;
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
               // try
                {
                    id = Convert.ToInt32(r.Cells["xid"].Value);
                    try
                    {
                        ex = r.Cells["explain"].Value.ToString();
                    }
                    catch { ex = ""; }
                    ch = Convert.ToBoolean(r.Cells["do_"].Value);
                    cs.updateservicforinterupt(id, ch, ex);
                }
             //   catch
                {}
            }
        }

        private void txtfiltername_TextChanged(object sender, EventArgs e)
        {
            filterobject();
        }

        private void printToolStripButton1_Click(object sender, EventArgs e)
        {
           // Report.SendReport c = new Report.SendReport();
           ////// frmreportviewer f = new frmreportviewer();
           // Stimulsoft.Report.StiReport stir = new Stimulsoft.Report.StiReport();
           //  stir.Load(System.IO.Directory.GetCurrentDirectory() + "\\RPT\\reportservice.mrt");
           // PAYADATA.interuptplan.Dsinteruptplanforprint ds = new PAYADATA.interuptplan.Dsinteruptplanforprint();
           // tabControl1.SelectedTab = service ;
           // tabControl1_SelectedIndexChanged(null, null);
           // DataGridViewRow r = dataGridView1.CurrentRow;
           // string startdate=returntruedate( r.Cells["xdatestart_interupt"].Value.ToString());
           // string enddate=returntruedate( r.Cells["xdate_endinterupt"].Value.ToString());
           // string starttime=( r.Cells["xtime_startinterupt"].Value.ToString());
           // string endtime= r.Cells["xtime_endinterupt"].Value.ToString();
           // string devicename= r.Cells["xnamedevice"].Value.ToString();
           // string deviceno= r.Cells["xnumber"].Value.ToString();
           // string interupttime= r.Cells["xtime_interupt"].Value.ToString();
           // string explainh = r.Cells["xexplain_havoc"].Value.ToString()+"     ";
           // string explaina =  r.Cells["xexplain_activity"].Value.ToString();
           // string  time= r.Cells["xtime_interupt"].Value.ToString();
           // object[] a = new object[9];
           // a[0] = startdate; a[1] = devicename +"  "+ deviceno; a[2] = startdate; a[3] = starttime; a[4] = enddate; a[5] = endtime; a[6] = explainh; a[7] = explaina; a[8] = time;

           //// ds.interupt.Rows.Add(startdate, devicename + deviceno, startdate, starttime, enddate, endtime, explainh, explaina, time);
           // ds.interupt.Rows.Add(a);  
           // string do_;  
           // string notdo;
           // string state;
           // string explain, itemno, itemname;
           // foreach (DataGridViewRow rr in dataGridView2.Rows)
           // {
           //     try
           //     {
           //         explain = rr.Cells["explain"].Value.ToString();
           //     }
           //     catch {explain=""; }
           //     itemname = rr.Cells["name"].Value.ToString();
           //     itemno=rr.Cells["xitemno"].Value.ToString();
           //     try
           //     {
           //         if (Convert.ToBoolean( rr.Cells["do_"].Value) == true)
           //         {
           //             do_ = "انجام شد";
           //             state = do_;
           //             notdo = "";
           //         }
           //         else { notdo = "انجام نشد"; do_ = "";
           //         state=notdo;}
           //         try
           //         {
           //             ds.service.Rows.Add(itemno, do_, explain, notdo);
           //             ds.service1.Rows.Add(itemno, itemname, state, explain);
           //         }
           //         catch { }
                   
           //     }
           //  catch { }
           // }
           // int i=1;
           // tabControl1.SelectedTab = repairer_tab;
           // tabControl1_SelectedIndexChanged(null, null);
           
           // for (i = 1; i <= 6 ; i++)
           // {
           //     try
           //     {
           //         stir.Dictionary.Variables.Add("service" + i.ToString(), dataGridrepairer.Rows[i - 1].Cells["xname_repairer"].Value.ToString());
           //         //c.SetParam("service" + i.ToString(), dataGridrepairer.Rows[i - 1].Cells["xname_repairer"].Value.ToString());
           //     }
           //     catch { 
           //        // c.SetParam("service" + i.ToString(), "");
           //     stir.Dictionary.Variables.Add("service" + i.ToString(), "");
           //     }
           // }
           // if ((bool)dataGridView1.CurrentRow.Cells["xmountly"].Value)
           // { stir.Dictionary.Variables.Add("servicetype", "ماهیانه"); }
           // else { stir.Dictionary.Variables.Add("servicetype" , "سالیانه"); }
           ////stir.Dictionary.BusinessObjects.Clear();
           // stir.RegBusinessObject("interuptplan", "interuptplan", ds.interupt);
           // stir.RegBusinessObject("serice", "service", ds.service1);
           // stir.Show();
           //// f.rpt = c.GetReport(ds, "crreportservicemountly");
           //// f.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //form.coding.frm_objectfordisposal f = new coding.frm_objectfordisposal();
            //f.combo_device_name.SelectedValue = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString().Substring(0, 3) + "      ";
            //f.combo_device_no.Text = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString().Trim().Substring(4, 2);
            //f.ShowDialog();
            //if (f.cod != "") { combobject.Text = f.name; combocodobject.Text = f.cod; } 
            
        
           
            //**********************************
            /*form.frmfilterallobject f = new frmfilterallobject();
            coddevice = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString();
            f.coddevice = coddevice;
            f.ShowDialog();
            if (f.cod != "") { combobject.Text = f.name; combocodobject.Text  = f.cod; }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void savecurrent_Click(object sender, EventArgs e)
        {

            if (!editable) { MessageBox.Show("شما دسترسی لازم برای تغییرات را ندارید!"); return; }
            Validate();
            currentmsgrid();

            if (csc.saveupdatecurrnt(datacurrent))
                FarsiMessageBox.FMessageBox.Show("ذخیره شد", "تراکنش موفق");
            else
                FarsiMessageBox.FMessageBox.Show("", "تراکنش  نا موفق");
            int i = (int)dataGridView1.CurrentRow.Cells["xid_"].Value;
           
        }

        private void bindingNavigator5_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGrid_objects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         /* if (e.ColumnIndex >= 0)
                if (e.RowIndex >= 0)
                    if (dataGrid_objects.Columns[e.ColumnIndex].Name == "xnameset1")
                    {

                        form.interupt.Frm_selectset f = new  Frm_selectset();
                        f.cod_of_device = dataGridView1.CurrentRow.Cells["xdevice_cod"].Value.ToString();
                        int x = Cursor.Position.X - f.Width + 20;
                        f.Location = new Point(x, Cursor.Position.Y);
                        f.ShowDialog();
                        if (f.name != null)
                            dataGrid_objects.CurrentRow.Cells[2].Value = f.name;
                        // dataGridView1.CurrentRow.Cells["xcod"].Value = f.cod;
                        f.Dispose();*/
                 
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
            BindingSource bs = new BindingSource();
            if (tabControl1.SelectedTab == objects_tab)
            {
                //  datatableobject = cs.fill_object(cod_interupt,"plan");
                // PAYADATA.interuptcomp.dsinteruptcomp.viewdisposal_objectDataTable  datatableobject;
                PAYADATA.disposal_object.dsdisposl_object.viewdisposal_objectDataTable datatableobject;
                datatableobject = csdo.fill_objectbycod(cod_interupt, "plan");
                bindingSource2.DataSource = datatableobject;
                dataGrid_objects.DataSource = bindingSource2;
                dataGrid_objects.AutoGenerateColumns = true;
                filterobject();

            }

            else if (tabControl1.SelectedTab == repairer_tab)
            {
                bs.DataSource = cs.fill_repairer(cod_interupt);
                dataGridrepairer.DataSource = bs;
                bindingNavigator3.BindingSource = bs;
                combonameservice.DataSource = cs.fillcomborepairer();
                combonameservice.DisplayMember = "xname";
                combonameservice.ValueMember = "xid";
            }

            else if (tabControl1.SelectedTab == current_tab)
            {

                datacurrent = csc.selectcurrentbychecklistid(cod_interupt, false);
                bindingSourcecurrnt.DataSource = datacurrent;
                dataGridViewcurrent.DataSource = datacurrent;
                currentmsgrid();


            }

            else
            {
                PAYAIND.csinterupt_plan css = new PAYAIND.csinterupt_plan();
                bs.DataSource = css.selectserviceforinterupt(cod_interupt);
                // DataGridViewCheckBoxColumn b= new DataGridViewCheckBoxColumn();
                dataGridView2.DataSource = bs;
                //  dataGridView2.Columns["do_"].ValueType= typeof(DataGridViewCheckBoxColumn);                    
                bindingNavigator4.BindingSource = bs;
            }
            headerclient();
        }
        void Show_data()
        {
            PAYAIND.csinterupt_plan cs = new PAYAIND.csinterupt_plan();
            dt = cs.interuptplan(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
        }
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            Show_data();
        }

        
    }
}
 