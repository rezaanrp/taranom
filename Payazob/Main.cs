using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Payazob
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();

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

            FrmPopUp();
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            uc_Poem1.FillLbl();
            Generate();
            VisibleRightPanel();

            //////////----------------------

            if (BLL.authentication.objectallow("frmManager"))
            {
                InvChart();
            }

            /////////------------------

            foreach (TreeNode item in treeView1.Nodes)
            {
                lsrt.Add(item.Tag.ToString());
            }

            this.ActiveControl = textBox1;

            CheakWorkYear();

            ledBulbCheck();

            ledBulb_1.Blink(200);
            ledBulb_2.Blink(200);
            ledBulb_3.Blink(200);

            
        }
        void ledBulbCheck()
        {
            bool tag_1 = new BLL.TimeLine.csTimeLine().SlTimeLineMachineLastStatus(BLL.csshamsidate.shamsidate, 51);
            bool tag_2 = new BLL.TimeLine.csTimeLine().SlTimeLineMachineLastStatus(BLL.csshamsidate.shamsidate, 52);
            bool tag_3 = new BLL.TimeLine.csTimeLine().SlTimeLineMachineLastStatus(BLL.csshamsidate.shamsidate, 53);
            if (tag_1)
            {
                ledBulb_1.Color = Color.Green;
                ledBulb_1.DarkDarkColor = Color.Green;
                ledBulb_1.DarkColor = Color.Green;

            }
            else
            {
                ledBulb_1.Color = Color.Red;
             //   ledBulb_1.DarkDarkColor = Color.Red;
                ledBulb_1.DarkColor = Color.Red;
            }
            if (tag_2)
            {
                ledBulb_2.Color = Color.Green;
                ledBulb_2.DarkDarkColor = Color.Green;
                ledBulb_2.DarkColor = Color.Green;

            }
            else
            {
                ledBulb_2.Color = Color.Red;
                ledBulb_2.DarkColor = Color.Red;
               // ledBulb_2.DarkDarkColor = Color.Red;
            }

            if (tag_3)
            {
                ledBulb_3.Color = Color.Green;
                ledBulb_3.DarkColor = Color.Green;
                ledBulb_3.DarkDarkColor = Color.Green;
            }
            else
            {
                ledBulb_3.Color = Color.Red;
                //  ledBulb_3.DarkDarkColor = Color.Red;
                ledBulb_3.DarkColor = Color.Red;
            }
        }
        void InvChart()
        {
            if (uc_Poem1.Visible == true)
            {
                MyControl.Chart.uc_ChartInvCollect cnt = new MyControl.Chart.uc_ChartInvCollect();
                cnt.Name = "ChartInvCollect";
                cnt.Dock = DockStyle.Fill;
                splitContainer4.Panel2.Controls.Add(cnt);
                uc_Poem1.Visible = false;

                pnl_logo.Visible = false;

            }
            else
            {
                foreach (Control item in splitContainer4.Panel2.Controls.OfType<Control>())
                {
                    if (item.Name == "ChartInvCollect")
                        splitContainer4.Panel2.Controls.Remove(item);
                }
                uc_Poem1.Visible = true;
                pnl_logo.Visible = true;
            }
        }



        DAL.Object.DataSet_Object.mObjectTreeAccessDataTable dt_D;

        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();
        Stack<TreeNode> Stack_Del = new Stack<TreeNode>();
        FRM.SendMessage.frmPopUp frmP = new FRM.SendMessage.frmPopUp();
        List<string> tsmi_List;
        private int xPos = 0;
        private int xPopTime = 0;
        frmLogin frm = new frmLogin();
        void CheakWorkYear()
        {
            if (TARANOM.Properties.Settings.Default.WorkYear.Substring(0, 4) != BLL.csshamsidate.shamsidate.Substring(0, 4))
            {
                MessageBox.Show("سال کاری  " + " " + TARANOM.Properties.Settings.Default.WorkYear.Substring(0, 4) + " " + "تنظیم شده ");
            }

        }
        void Generate()
        {
            treeView1.Nodes.Clear();
            //TreeNode trn = new TreeNode("");
            // trn.Tag = "-2";
            BLL.Object.csObject cs = new BLL.Object.csObject();

            dt_D = cs.SlObjectTreeAccess(BLL.authentication.x_, BLL.authentication.xGroup_);
            DataRow[] drR = dt_D.Select("xParent_ IS NULL");
            List<TreeNode> list_trn = new List<TreeNode>();
            foreach (DataRow item in drR)
            {
                TreeNode tr = new TreeNode(" "  + item["xName"].ToString() + "               ");
                tr.Tag = item["xObject_"].ToString();
                tr.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                list_trn.Add(tr);
                Stack_tree.Push(tr);
            }
///////////////////////////////////////////////////////////////////////////////////////////////////////////
            //string[] Ary_order = TARANOM.Properties.Settings.Default.TreeviewOrder.Split('#');
            //foreach (string item in Ary_order)
            //{
            //    foreach (TreeNode trn in list_trn)
            //    {
            //        if (trn.Tag.ToString() == item)
            //        {
            //            treeView1.Nodes.Add(trn);
            //            list_trn.Remove(trn);
            //            break;
            //        }
            //    }
            //}
                foreach (TreeNode trn in list_trn)
                {
                    treeView1.Nodes.Add(trn);
                }
///////////////////////////////////////////////////////////////////////////////////////////////////////////

            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                if (int.Parse(S_tr.Tag.ToString()) > 0)
                {
                    S_tr.ForeColor = Color.Yellow;
                    S_tr.NodeFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                }
                drR = dt_D.Select("xParent_ = " + S_tr.Tag);
                foreach (DataRow item in drR)
                {
                    TreeNode tr = new TreeNode(item["xName"].ToString()) { Name = "i" + item["xObject_"].ToString() };
                    tr.Tag = item["xObject_"].ToString();
                    S_tr.Nodes.Add(tr);
                    Stack_tree.Push(tr);
                }
            }
            //حذف درخت هایی که نود ندارد
            gentree();
           //treeView1.ExpandAll();
        }

        void gentree()
        {
            //از پایین با بالا حذف می کند
            foreach (TreeNode n in treeView1.Nodes)
            {
               if (!remtree(n))
                   Stack_Del.Push(n);  

            }
            while (Stack_Del.Count > 0)
            {
                Stack_Del.Pop().Remove();
            }
        }
        private bool remtree(TreeNode treeNode)
        {
            bool te = false;
            if (treeNode != null && int.Parse( treeNode.Tag.ToString()) > 0)
                return true;
            else if (treeNode == null)
            {
                return false;
            }

            else
            {
                foreach (TreeNode tn in treeNode.Nodes)
                {
                    if (remtree(tn) == false && tn !=null)
                    {
                        Stack_Del.Push(tn);  
                    }
                    else
                        te = true;
                }
                return te;
            }

        }
        private void Marquee()
        {
            BLL.Marquee.csMarquee cs = new BLL.Marquee.csMarquee();
            lblMarquee.Text = cs.SlMarquee();
        }

        void FrmPopUp()
        {
            try
            {
                string st = new BLL.Message.csMessage().SlMessagePopUp();
                if (st != "")
                {
                    notifyIcon1.ShowBalloonTip(1000, "پیام", st, ToolTipIcon.Info);
                    btn_MailBox.BackColor = Color.GreenYellow;
                }
                else
                    btn_MailBox.BackColor = Color.Azure;
                    
            }
            catch (Exception)
            {
                
            }

        }


        private void menuActive(MenuStrip menus)
        {
            BLL.authentication obj = new BLL.authentication();
            DataTable dt_oj = obj.SelectObjectListAllow();
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

                if (tsmi_List.Contains(subItem.Name.Substring(5)))
                {
                    subItem.Visible = true;
                    item.Visible = true;
                    tsmi_List.Remove(subItem.Name.Substring(5));
                }
                if (item is ToolStripMenuItem)
                {

                    activateItems(subItem as ToolStripMenuItem);
                }

            }
        }

        private void TsmiVisibleSet(ToolStripMenuItem t)
        {
            t.Visible = BLL.authentication.objectallow(t.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {


           
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void tsmi_Click(object sender, EventArgs e)
        {
            string st = ((System.Windows.Forms.ToolStripMenuItem)(sender)).Name.ToString();
            TARANOM.Properties.Settings.Default.LsfEn = st = st.Substring(5);
            TARANOM.Properties.Settings.Default.LsfFa = ((System.Windows.Forms.ToolStripItem)(sender)).Text;
            TARANOM.Properties.Settings.Default.Save();
            CS.csOpenForm op = new CS.csOpenForm();
            op.FindForm(st, ((System.Windows.Forms.ToolStripItem)(sender)).Text);
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width <= xPos)
            {
                this.lblMarquee.Location = new System.Drawing.Point(0, 4);
                xPos = 0;
            }
            else
            {
                this.lblMarquee.Location = new System.Drawing.Point(xPos, 4);
                xPos+=2;
            }
            
            xPopTime++;
            if (xPopTime > 1000)

            {

                FrmPopUp(); xPopTime = 0;

                if(pnl_LedSite1.Visible == true)
                 ledBulbCheck();

            }

        }

        private void splitContainer3_Panel2_DoubleClick(object sender, EventArgs e)
        {
            Marquee();
        }

        private void tsmi_WorkYear_Click(object sender, EventArgs e)
        {
            frmWorkYear frm = new frmWorkYear();
            frm.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            PointF[] points = {	  new Point(20, 90),
                                  new Point(410, 90),
                                  new Point(410, 200),
                                  new Point(80, 200),
                                  new Point(20, 90)};



            Pen pen = new Pen(Color.FromArgb(100, 160, 116), 2);
            //  SolidBrush brush1 = new SolidBrush(Color.FromArgb(0, 60, 116));

            LinearGradientBrush brush0 = new LinearGradientBrush(new Rectangle(0, 0, 500, splitContainer1.Panel2.Height - uc_Poem1.Height), Color.FromArgb(0, 206, 180), Color.FromArgb(23, 64, 109), 90.0f);

            e.Graphics.FillRectangle(brush0, 0, 0, 1500, 1600);
          //  e.Graphics.DrawLines(pen, points);
        }

        private void btn_MailBox_Click(object sender, EventArgs e)
        {
            FRM.SendMessage.frmMessageBox frm = new FRM.SendMessage.frmMessageBox();
            frm.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "", "جهت مشاهده برنامه بر روی این ایکون کلیک کنید", ToolTipIcon.Info);

            }
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {

            if (!this.Visible && ((System.Windows.Forms.MouseEventArgs)(e)).Button == System.Windows.Forms.MouseButtons.Left)
            {
                
                frm.ShowDialog();

                if (frm.EnterSuccess)
                {
                    WindowState = FormWindowState.Maximized;
                    this.Show();
                }
                //notifyIcon1.co
            }
        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.F10):
                    CS.csOpenForm op = new CS.csOpenForm();
                    op.FindForm(TARANOM.Properties.Settings.Default.LsfEn, TARANOM.Properties.Settings.Default.LsfFa);
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void uc_Poem1_Resize(object sender, EventArgs e)
        {
            PointF[] points = {	  new Point(20, 90),
                                  new Point(410, 90),
                                  new Point(410, 200),
                                  new Point(80, 200),
                                  new Point(20, 90)};



            Pen pen = new Pen(Color.FromArgb(100, 160, 116), 2);
            //  SolidBrush brush1 = new SolidBrush(Color.FromArgb(0, 60, 116));

            LinearGradientBrush brush0 = new LinearGradientBrush(new Rectangle(0, 0, 500, splitContainer1.Panel2.Height - uc_Poem1.Height), Color.FromArgb(0, 206, 180), Color.FromArgb(23, 64, 109), 90.0f);

           splitContainer1.Panel2.CreateGraphics().FillRectangle(brush0, 0, 0, 1500, 1600);
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        List<string> lsrt = new List<string>();
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (int.Parse(e.Node.Tag.ToString()) > 0)
            {
                TreeNode tn = e.Node;
                string tt = "";
                while (tn.Parent != null)
                {
                    tn = tn.Parent;
                }
                lsrt.Remove(tn.Tag.ToString());
                lsrt.Reverse();
                lsrt.Add(tn.Tag.ToString());
                lsrt.Reverse();
                foreach (string item in lsrt)
                {
                        tt += item + "#";
                }
                  tt =  tt.Remove(tt.Length - 1);

                TARANOM.Properties.Settings.Default.TreeviewOrder = tt;
                TARANOM.Properties.Settings.Default.Save();

                BLL.Object.csObject cs = new BLL.Object.csObject();


                int id_tag = 0;

                if (treeView1.SelectedNode.Tag != null)
                    id_tag = int.Parse(treeView1.SelectedNode.Tag.ToString());
                DataRow dr = cs.SlObjectNameById(id_tag);

                if (dr != null)
                {
                    TARANOM.Properties.Settings.Default.LsfEn = dr["xObjectname"].ToString();
                    TARANOM.Properties.Settings.Default.LsfFa = dr["xObjectFarsiName"].ToString();
                    TARANOM.Properties.Settings.Default.Save();
                    new CS.csOpenForm().FindForm(dr["xObjectname"].ToString(), dr["xObjectFarsiName"].ToString());
                }               
            }

        }

        private void tsmi_UserCustomaiz_Click(object sender, EventArgs e)
        {
            new CS.csOpenForm().FindForm("Ed0itObjectGroup", "ویرایش پنل کاربران");

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            InvChart();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            CS.csOpenForm op = new CS.csOpenForm();
            op.FindForm(TARANOM.Properties.Settings.Default.LsfEn, TARANOM.Properties.Settings.Default.LsfFa);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form frm = new Form();
            ControlLibrary.uc_ChangePassword ch = new ControlLibrary.uc_ChangePassword();
            ch.Dock = DockStyle.Fill;
            frm.Size = new Size(509, 250);
            frm.Controls.Add(ch);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        void VisibleRightPanel()
        {
            foreach (Control item in splitContainer1.Panel1.Controls.OfType<Control>())
            {

                string st = item.Name.Substring(4);
                TARANOM.Properties.Settings.Default.LsfEn = st;
                 //  TARANOM.Properties.Settings.Default.LsfFa = ((System.Windows.Forms.ToolStripItem)(sender)).Text;
                TARANOM.Properties.Settings.Default.Save();
                if (st == "exit" || st == "MailBox" || st == "return" || st == "ChangePass" || st == "workYear")
                {
                    item.Visible = true;

                }
               else if (BLL.authentication.objectallow(st) )
                {
                    item.Visible = true;
                }

            }
        }



        private void btna_AccessRights_Click(object sender, EventArgs e)
        {
            //new Payazob.frmAccessRights().ShowDialog();
            new Payazob.FRM.AccessRights.frmAccessRightTree().ShowDialog();
            
        }

        private void treeView1_MouseHover(object sender, EventArgs e)
        {
           // splitContainer1.Panel1Collapsed = false;

        }

        private void treeView1_MouseLeave(object sender, EventArgs e)
        {
          //  splitContainer1.Panel1Collapsed = true;

        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {
            PointF[] points = {	  new Point(20, 90),
                                  new Point(410, 90),
                                  new Point(410, 200),
                                  new Point(80, 200),
                                  new Point(20, 90)};



            Pen pen = new Pen(Color.FromArgb(255, 128, 0), 2);
            //  SolidBrush brush1 = new SolidBrush(Color.FromArgb(0, 60, 116));

            LinearGradientBrush brush0 = new LinearGradientBrush(new Rectangle(0, 0, 6000, splitContainer1.Panel2.Height), Color.FromArgb(250, 128, 0), Color.FromArgb(242, 233, 0), 180.2f);

          //  splitContainer4.Panel2.CreateGraphics().FillRectangle(brush0, 0, 0, 1500, 1600);
        }

        private void btn_EditObjectGroup_Click(object sender, EventArgs e)
        {
          //  new Payazob.FRM.EditObjectGroup.frmEditObjectGroup().ShowDialog();

        }
        




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
            CS.csSearchTreeView tr = new CS.csSearchTreeView();
            tr.CallRecursiveTreeView(treeView1, textBox1.Text);
            if (textBox1.Text == "" || tr.tr.Count < 1)
            {
                return;
            }
            foreach (TreeNode item in tr.tr)
            {
                TreeNode tn = item;
                while (tn != null)
                {
                    tn.Expand();
                    tn = tn.Parent;

                }
            }
        }

        private void btn_workYear_Click(object sender, EventArgs e)
        {
            frmWorkYear frm = new frmWorkYear();
            frm.ShowDialog();
        }
        bool expandtreeview = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (expandtreeview)
            {
                treeView1.ExpandAll();
                expandtreeview = false;
            }
            else
            {
                treeView1.CollapseAll();
                expandtreeview = true;

            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void btn_ReportMan_Click(object sender, EventArgs e)
        {
            //new FRM.ManagerReport.frmManagerReportAllSite().ShowDialog(); ;

        }

        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            //if (!e.Node.IsExpanded)
            //    e.Node.Expand();
            //else
            //    e.Node.Collapse();
        }

        private void ledBulb3_Click(object sender, EventArgs e)
        {

        }
    }
}
