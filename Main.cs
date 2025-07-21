using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob
{
    public partial class Main : Form
    {
        public Main()
        {

            //this.Size = System.Windows.Forms.
            //this.Hide();
            //Payazob.frmLogin f = new frmLogin();
            //f.ShowDialog();
            //if (!f.EnterSuccess)
            //    return;

            InitializeComponent();

         //   f.Dispose();   
            this.Show();

            foreach (InputLanguage il in InputLanguage.InstalledInputLanguages)
            {
                if (il.Culture.EnglishName.ToLower().Contains("persian") || il.Culture.EnglishName.ToLower().Contains("iran") || il.Culture.EnglishName.ToLower().Contains("farsi"))
                {
                    InputLanguage.CurrentInputLanguage = il;
                }
            }

            Marquee();
            timer1.Start();


            //--------------------------------------------------------------------------
            menuActive(menuStrip1);



        }

     
        List<string> tsmi_List;

        private void menuActive(MenuStrip menus)
        {
            BLL.authentication obj = new BLL.authentication();
            DataTable  dt_oj = obj.SelectObjectListAllow();
            tsmi_List = new List<string>();
            foreach (DataRow item in dt_oj.Rows)
            {
                tsmi_List.Add(item["xObject_"].ToString());
            }
            foreach (ToolStripMenuItem menu in menus.Items)
            {
                activateItems(menu);
            }
            dt_oj.Dispose();
        }

        private void activateItems(ToolStripMenuItem item)
        {
           
            if (item == null)
                return;
            
            for (int i = 0; i < item.DropDown.Items.Count; i++)
            {
                ToolStripItem subItem = item.DropDown.Items[i];
                //for (int j = 0; j < tsmi_List.Count; j++)
                //{
                //    if (tsmi_List[j].ToString() == subItem.Name.Substring(5))
                //    {
                if (tsmi_List.Contains(subItem.Name.Substring(5)))
                {
                    subItem.Visible = true;
                    item.Visible = true;
                    tsmi_List.Remove(subItem.Name.Substring(5));
                   // break;
                }
                //    }
                //}
                if (item is ToolStripMenuItem)
                {
                    
                    activateItems(subItem as ToolStripMenuItem);
                }

            }
        }

        private void Marquee()
        {
            BLL.Marquee.csMarquee cs = new BLL.Marquee.csMarquee();
            lblMarquee.Text = cs.SlMarquee(); 
        }
        private void TsmiList()
        {
            List<ToolStripMenuItem> tsmi_List = new List<ToolStripMenuItem>();
             tsmi_List.Add(tsmi_AccessRights);
             //tsmi_List.Add(tsmi_file);
            // tsmi_List.Add(tsmi_system);
            // tsmi_List.Add(tsmi_QualityControl);
            // tsmi_List.Add(tsmi_PlanningUnit);
           //  tsmi_List.Add(tsmi_Garding);
            // tsmi_List.Add(tsmi_product);
             tsmi_List.Add(tsmi_CorrespondenceUnit);
            // tsmi_List.Add(tsmi_report);
             tsmi_List.Add(tsmi_ProductInspectionList);
             tsmi_List.Add(tsmi_NonConformingList);
             tsmi_List.Add(tsmi_Planning);
             tsmi_List.Add(tsmi_ProductionPlanning);
             tsmi_List.Add(tsmi_FoundryDetialsList);
             tsmi_List.Add(tsmi_SandDailyReportList);
             tsmi_List.Add(tsmi_SandWeeklyTestList);

             tsmi_List.Add(tsmi_ReturnCustomer);
             tsmi_List.Add(tsmi_Correspondence);
             tsmi_List.Add(tsmi_AccessRights);
             //خروجToolStripMenuItem1);
             tsmi_List.Add(tsmi_ProcurementGoodsOut);
        //     tsmi_List.Add(tsmi_ProcurmentEntryMaterial);
             tsmi_List.Add(tsmi_ProcurmentSalesProduct);
             tsmi_List.Add(tsmi_ProcurmentGuest);
             //tsmi_List.Add(tsmi_ReprotQulityControl);
            // tsmi_List.Add(tsmi_ProductInspection_Report1);
             //انتظاماتToolStripMenuItem);
             tsmi_List.Add(tsmi_ProcurementGoodsOut_Report);
             tsmi_List.Add(tsmi_ProcurmentEntryMaterial_Report);
             tsmi_List.Add(tsmi_ProcurmentSalesProduct_Report);
             tsmi_List.Add(tsmi_ProcurmentGuest_Report);
             tsmi_List.Add(tsmi_ProductInspectionDefect_Report);
             tsmi_List.Add(tsmi_ProductInspection_Report);
             tsmi_List.Add(tsmi_NonConforming_Report);
             //گزارشمواداوليهToolStripMenuItem);

             tsmi_List.Add(tsmi_MeltTestResult_Report1);
             //تولیدToolStripMenuItem);
             tsmi_List.Add(tsmi_DestructionReport);
            // tsmi_List.Add(tsmi_ChangePass);
             tsmi_List.Add(tsmi_FoundryDetailsTotalMeltByZint_Report);
             //گزارشاتماسهToolStripMenuItem);
             tsmi_List.Add(tsmi_SandDailyReport_Report);
             tsmi_List.Add(tsmi_SandMaterialUsage_Report);
             tsmi_List.Add(tsmi_SandMaterialAndDaily_Report);
             tsmi_List.Add(tsmi_SandMaterialUsageRangDate_Report);
             tsmi_List.Add(tsmi_SandWeeklyTestChart);
             tsmi_List.Add(tsmi_SendProduct);
             tsmi_List.Add(tsmi_PiecesProducs);
             //برنامهریزیToolStripMenuItem);
             //گزارشمجودیToolStripMenuItem);
             tsmi_List.Add(tsmi_Inventory);
             tsmi_List.Add(tsmi_InventoryTotal_Report);
             tsmi_List.Add(tsmi_Pieces);
             //tsmi_system.DropDownItems.Clear();
             for (int i = 0; i < tsmi_List.Count; i++)
             {
                tsmi_List[i].Visible =  BLL.authentication.objectallow(tsmi_List[i].Name.Substring(5));
             }
        }

        private void TsmiVisibleSet(ToolStripMenuItem t)
        {
            t.Visible = BLL.authentication.objectallow(t.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (((System.Windows.Forms.Control)(sender)).Name == "btn_planning")
            {
                if (splitContainer1.Panel2.Controls.Count > 0)
                    splitContainer1.Panel2.Controls.RemoveAt(0);                    
                ControlLibrary.ucSubmenu sb1 = new ControlLibrary.ucSubmenu();
                sb1.GenerateBtn("1");
                sb1.Location = new System.Drawing.Point(0, 0);
                sb1.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(sb1);

            }
            else if (((System.Windows.Forms.Control)(sender)).Name == "btn_report")
            {
                if (splitContainer1.Panel2.Controls.Count > 0)
                    splitContainer1.Panel2.Controls.RemoveAt(0);
                ControlLibrary.ucSubmenu sb1 = new ControlLibrary.ucSubmenu();
                sb1.GenerateBtn("2");
                sb1.Location = new System.Drawing.Point(0, 0);
                sb1.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(sb1);

            }
           
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tsmi_Click(object sender, EventArgs e)
        {
                  

            #region موقتی
            //if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProductionPlanning" && BLL.authentication.objectallow("ProductionPlanning"))
            //{
            //    Payazob.frmProductionPlanning f = new Payazob.frmProductionPlanning();
            //    f.ShowDialog();
            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_Downtime" && BLL.authentication.objectallow("Downtime"))
            //{
            //    Payazob.frmDowntime f = new Payazob.frmDowntime();
            //    f.ShowDialog();
            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_Foundry" && BLL.authentication.objectallow("Foundry"))
            //{
            //    Payazob.frmFoundry f = new Payazob.frmFoundry();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProductInspection" && BLL.authentication.objectallow("ProductInspection"))
            //{
            //    Payazob.frmProductInspection f = new Payazob.frmProductInspection();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_MeltTestResult" && BLL.authentication.objectallow("MeltTestResult"))
            //{
            //    Payazob.frmMeltTestResult f = new Payazob.frmMeltTestResult();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ReturnCustomer" && BLL.authentication.objectallow("ReturnCustomer"))
            //{
            //    Payazob.frmReturnCustomer f = new Payazob.frmReturnCustomer();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_Correspondence" && BLL.authentication.objectallow("Correspondence"))
            //{
            //    Payazob.frmCorrespondence f = new Payazob.frmCorrespondence();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_SandMaterialUsage" && BLL.authentication.objectallow("SandMaterialUsage"))
            //{
            //    Payazob.frmSandMaterialUsage f = new Payazob.frmSandMaterialUsage();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_SandDailyReport" && BLL.authentication.objectallow("SandDailyReport"))
            //{
            //    Payazob.frmSandDailyReport f = new Payazob.frmSandDailyReport();
            //    f.ShowDialog();
            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_SandWeeklyTest" && BLL.authentication.objectallow("SandWeeklyTest"))
            //{
            //    Payazob.frmSandWeeklyTest f = new Payazob.frmSandWeeklyTest();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_DestructionReport" && BLL.authentication.objectallow("DestructionReport"))
            //{
            //    Payazob.frmDestructionReport f = new Payazob.frmDestructionReport();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_QualityControlMeltReport" && BLL.authentication.objectallow("QualityControlMeltReport"))
            //{
            //    Payazob.frmQualityControlMeltReport f = new Payazob.frmQualityControlMeltReport();
            //    f.ShowDialog();
            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_NonConforming" && BLL.authentication.objectallow("NonConforming"))
            //{
            //    Payazob.frmNonConforming f = new Payazob.frmNonConforming();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurementGoodsOut" && BLL.authentication.objectallow("ProcurementGoodsOut"))
            //{
            //    Payazob.frmProcurementGoodsOut f = new Payazob.frmProcurementGoodsOut();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_Planning" && BLL.authentication.objectallow("Planning"))
            //{
            //    Payazob.frmPlanning f = new Payazob.frmPlanning();
            //    f.ShowDialog();

            //}

            ////////////////
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurmentEntryMaterial" && BLL.authentication.objectallow("ProcurmentEntryMaterial"))
            //{
            //    Payazob.frmProcurmentEntryMaterial f = new Payazob.frmProcurmentEntryMaterial();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurmentGuest" && BLL.authentication.objectallow("ProcurmentGuest"))
            //{
            //    Payazob.frmProcurmentGuest f = new Payazob.frmProcurmentGuest();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurmentSalesProduct" && BLL.authentication.objectallow("ProcurmentSalesProduct"))
            //{
            //    Payazob.frmProcurmentSalesProduct f = new Payazob.frmProcurmentSalesProduct();
            //    f.ShowDialog();

            //}
            ////else if (BLL.authentication.objectallow("ProcurmentSalesProduct") && ((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurmentSalesProducts")
            ////{
            ////    Payazob.frmPlanning f = new Payazob.frmPlanning();
            ////    f.ShowDialog();

            ////}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProductInspection_Report" && BLL.authentication.objectallow("ProductInspection_Report"))
            //{
            //    Payazob.frmProductInspection_Report f = new Payazob.frmProductInspection_Report();
            //    f.ShowDialog();

            //}


            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_MeltTestResult_Report" && BLL.authentication.objectallow("MeltTestResult_Report"))
            //{
            //    Payazob.frmMeltTestResult_Report f = new Payazob.frmMeltTestResult_Report();
            //    f.ShowDialog();

            //}


            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurementGoodsOut_Report" && BLL.authentication.objectallow("ProcurementGoodsOut_Report"))
            //{
            //    Payazob.frmProcurementGoodsOut_Report f = new Payazob.frmProcurementGoodsOut_Report();
            //    f.ShowDialog();

            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurmentEntryMaterial_Report" && BLL.authentication.objectallow("ProcurmentEntryMaterial_Report"))
            //{
            //    Payazob.frmProcurmentEntryMaterial_Report f = new Payazob.frmProcurmentEntryMaterial_Report();
            //    f.ShowDialog();

            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurmentSalesProduct_Report" && BLL.authentication.objectallow("ProcurmentSalesProduct_Report"))
            //{
            //    Payazob.frmProcurmentSalesProduct_Report f = new Payazob.frmProcurmentSalesProduct_Report();
            //    f.ShowDialog();

            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProcurmentGuest_Report" && BLL.authentication.objectallow("ProcurmentGuest_Report"))
            //{
            //    Payazob.frmProcurmentGuest_Report f = new Payazob.frmProcurmentGuest_Report();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_ProductInspectionDefect_Report" && BLL.authentication.objectallow("ProductInspectionDefect_Report"))
            //{
            //    Payazob.frmProductInspectionDefect_Report f = new Payazob.frmProductInspectionDefect_Report();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_MeltTestResult_Report1" && BLL.authentication.objectallow("MeltTestResult_Report1"))
            //{
            //    Payazob.frmMeltTestResult_Report1 f = new Payazob.frmMeltTestResult_Report1();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_MeltTestResultScrab" && BLL.authentication.objectallow("MeltTestResultScrab"))
            //{
            //    Payazob.frmMeltTestResultScrab f = new Payazob.frmMeltTestResultScrab();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_MeltTestResultScrab_Report1" && BLL.authentication.objectallow("MeltTestResultScrab_Report1"))
            //{
            //    Payazob.frmMeltTestResultScrab_Report1 f = new Payazob.frmMeltTestResultScrab_Report1();
            //    f.ShowDialog();

            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_NonConforming_Report" && BLL.authentication.objectallow("NonConforming_Report"))
            //{
            //    Payazob.frmNonConforming_Report f = new Payazob.frmNonConforming_Report();
            //    f.ShowDialog();

            //}

            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_DownTime_Report" && BLL.authentication.objectallow("DownTime_Report"))
            //{
            //    Payazob.frmDownTime_Report f = new Payazob.frmDownTime_Report();
            //    f.ShowDialog();

            //}
            //else if (((System.Windows.Forms.ToolStripMenuItem)(sender)).Name == "tsmi_SandMaterialUsage_report" && BLL.authentication.objectallow("SandMaterialUsage_Report"))
            //{
            //    Payazob.CS.SandMaterialUsage cs = new CS.SandMaterialUsage();
            //    cs.GN_SandMaterialUsage_Report();
            //    //Payazob.frmSandMaterialUsage_Report f = new Payazob.frmSandMaterialUsage_Report();
            //    //f.ShowDialog();

            //}  
            
            #endregion
            string st = ((System.Windows.Forms.ToolStripMenuItem)(sender)).Name.ToString();
            st = st.Substring(5);
            CS.csOpenForm op = new CS.csOpenForm();
            op.FindForm(st);
           
        }

        private void btn_Phone_Click(object sender, EventArgs e)
        {
            frmPhone frm = new frmPhone();
            frm.ShowDialog();
            frm.Dispose();

        }

        private void tsmi_ChangePass_Click(object sender, EventArgs e)
        {
            //509; 218
            Form frm = new Form();
            ControlLibrary.uc_ChangePassword ch = new ControlLibrary.uc_ChangePassword();
            ch.Dock = DockStyle.Fill;
            frm.Size = new Size(509, 250);
            frm.Controls.Add(ch);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private int xPos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            //timer1.Stop();
            //BLL.Schedule.csSchedule cs = new BLL.Schedule.csSchedule();
            //int x_ = int.Parse(Properties.Settings.Default.Schedule_);

            //if (cs.CheakSchedule(ref x_))
            //{
            //    if(cs.message != "")
            //         MessageBox.Show(cs.message);
            //    if (cs.CloseApp == true)
            //        Application.Exit();
            //    Properties.Settings.Default.Schedule_ = x_.ToString();
            //    Properties.Settings.Default.Save();
            //}
            //timer1.Start();
           // Tick++;

            if (this.Width <= xPos)
            {
                //repeat marquee
                this.lblMarquee.Location = new System.Drawing.Point(0, 4);
                xPos = 0;
            }
            else
            {
                this.lblMarquee.Location = new System.Drawing.Point(xPos, 4);
                xPos+=2;
            }
        }

        private void splitContainer3_Panel2_DoubleClick(object sender, EventArgs e)
        {
            Marquee();
        }



    }
}
