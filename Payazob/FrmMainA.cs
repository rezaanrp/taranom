using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Payazob
{
    public partial class FrmMainA : Form
    {
        public FrmMainA()
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

          //  menuActive(menuStrip1);
            FrmPopUp();
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            uc_Poem1.FillLbl();
            Generate();
        }


        DAL.Object.DataSet_Object.mObjectTreeAccessDataTable dt_D;

        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();

        void Generate()
        {
            treeView1.Nodes.Clear();
            //TreeNode trn = new TreeNode("");
            // trn.Tag = "-2";
            BLL.Object.csObject cs = new BLL.Object.csObject();

            dt_D = cs.SlObjectTreeAccess(BLL.authentication.x_, BLL.authentication.xGroup_);
            DataRow[] drR = dt_D.Select("xParent_ IS NULL");
            foreach (DataRow item in drR)
            {
                TreeNode tr = new TreeNode(item["xName"].ToString());
                tr.Tag = item["xObject_"].ToString();
                treeView1.Nodes.Add(tr);
                Stack_tree.Push(tr);
            }
            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                drR = dt_D.Select("xParent_ = " + S_tr.Tag);
                foreach (DataRow item in drR)
                {
                    TreeNode tr = new TreeNode(item["xName"].ToString()) { Name = "i" + item["xObject_"].ToString() };
                    tr.Tag = item["xObject_"].ToString();
                    S_tr.Nodes.Add(tr);
                    Stack_tree.Push(tr);
                }
            }
            treeView1.ExpandAll();
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            BLL.Object.csObject cs = new BLL.Object.csObject();
            DataRow dr = cs.SlObjectNameById(int.Parse(e.Node.Tag.ToString()));
            new CS.csOpenForm().FindForm(dr["xObjectname"].ToString(), dr["xObjectFarsiName"].ToString());
            //cs.SlObjectNameById( int.Parse(e.Node.Tag.ToString() ));
        }



        FRM.SendMessage.frmPopUp frmP = new FRM.SendMessage.frmPopUp();
        private void Marquee()
        {
            BLL.Marquee.csMarquee cs = new BLL.Marquee.csMarquee();
            lblMarquee.Text = cs.SlMarquee();

        }

        void FrmPopUp()
        {
            //try
            //{
            //    string st = new BLL.Message.csMessage().SlMessagePopUp();
            //    if (st != "")
            //    {
            //        notifyIcon1.ShowBalloonTip(1000, "پیام", st, ToolTipIcon.Info);
            //        btn_MailBox.BackColor = Color.Orange;
            //    }
            //    else
            //        btn_MailBox.BackColor = Color.Azure;
            //}
            //catch (Exception)
            //{

            //}

        }

        List<string> tsmi_List;

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
            Properties.Settings.Default.LsfEn = st = st.Substring(5);
            Properties.Settings.Default.LsfFa = ((System.Windows.Forms.ToolStripItem)(sender)).Text;
            Properties.Settings.Default.Save();
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
        private int xPos = 0;
        private int xPopTime = 0;

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
                xPos += 2;
            }

            xPopTime++;
            if (xPopTime > 1000)

            { FrmPopUp(); xPopTime = 0; }
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
        frmLogin frm = new frmLogin();
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
                    op.FindForm(Properties.Settings.Default.LsfEn, Properties.Settings.Default.LsfFa);
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void uc_Poem1_Resize(object sender, EventArgs e)
        {

        }
    }
}
