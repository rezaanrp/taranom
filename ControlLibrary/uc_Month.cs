using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_Month : UserControl
    {
        public uc_Month()
        {
            InitializeComponent();
        }
        public int Mo = -1;
        public int Ye = -1;
        public Delegate userFunctionPointer;
        public Delegate PoPupMsg;
        public Delegate ChangeMonth;
        public bool PupapActive = false;
        public bool ClickActive = false;
        public bool ChangeMonthActive = false;

        ControlLibrary.CustomToolTip customToolTip;
        ControlLibrary.PopUp.Popup pupup;

        public void GenColor(string[] DayNumber, Color cl)
        {
            foreach (string item in DayNumber)
            {
                if (item == "")
                    continue;
                if (this.panel1.Controls["btn_" + item] != null)
                {
                    (this.panel1.Controls["btn_" + item] as uc_btn).MouseLeaveColor = cl;
                    (this.panel1.Controls["btn_" + item] as uc_btn).BackColor = cl;
                }
            }

        }

        public void GenBtn()
        {

            if (Mo < 0)
                return;

            lbl_mon.Text = MoNuToTxt(Mo);
            panel2.Location = new Point(this.Size.Width / 2 - 80, lbl_mon.Location.Y);
            if (panel1.Controls.Count > 30)
                return;
            BLL.csshamsidate cs = new BLL.csshamsidate();

            int Dofw;
            if (Mo < 10)
                Dofw = cs.ShamsiDayeOfWeek(Ye.ToString() + "/0" + Mo + "/01");
            else
                Dofw = cs.ShamsiDayeOfWeek(Ye.ToString() + "/" + Mo + "/01");

            Dofw = (Dofw + 6) % 7;

            //     this.Size = new Size(50 * 7 + 3, 47 * 6 +2);

            for (int j = 0, r = 0; j < 35; j++)
            {
                ControlLibrary.uc_btn bt = new ControlLibrary.uc_btn();
                bt.Name = "btn_" + (j - Dofw + 1).ToString();
                if ((Mo < 7 && j >= Dofw && r < 31) || (Mo > 6 && Mo < 12 && j >= Dofw && r < 30) || (Mo == 12 && j >= Dofw && r < 30 && (Ye + 1) % 4 == 0) || (Mo == 12 && j >= Dofw && r < 29 && (Ye + 1) % 4 != 0))
                {

                    r++;
                    bt.Text = (j - Dofw + 1).ToString();
                }
                else if ((Dofw == 5 && j < 1 && Mo < 7))
                {
                    bt.Name = "btn_31";
                    bt.Text = "31";
                }
                else if ((Dofw == 6 && j < 1 && Mo > 6 && Mo <12))
                {
                    bt.Name = "btn_30";
                    bt.Text = "30";
                }
                else if ((Dofw == 6 && j < 2 && Mo < 7) || (Dofw == 6 && j < 1 && Mo > 6 && (Ye + 1) % 4 != 0))
                {
                    bt.Name ="btn_" + (j + 30).ToString();
                    bt.Text = (j + 30).ToString();
                }
                //else if()
                //{

                //}
                else
                    bt.Visible = false;
                bt.Size = new System.Drawing.Size((this.panel1.Width) / 7, (this.panel1.Height - 2) / 6);
                bt.UseVisualStyleBackColor = true;
                bt.BackColor = Color.GhostWhite;
                // bt.MouseLeaveColor = Color.GhostWhite; ;
                bt.Click += new EventHandler(bt_Click);
                bt.MouseHover += new EventHandler(bt_MouseHover);
                bt.MouseLeave += new EventHandler(bt_MouseLeave);

                panel1.Controls.Add(bt);
            }
            btn_order();
            pupup = new ControlLibrary.PopUp.Popup(customToolTip = new ControlLibrary.CustomToolTip());
            pupup.AutoClose = false;
            pupup.FocusOnOpen = false;
            pupup.ShowingAnimation = pupup.HidingAnimation = ControlLibrary.PopUp.PopupAnimations.LeftToRight | ControlLibrary.PopUp.PopupAnimations.Slide; ;
            if (int.Parse(BLL.csshamsidate.shamsidate.Substring(0, 4)) == 
                Ye && int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2)) == Mo)
            {
                foreach (Button item in panel1.Controls.OfType<Button>())
                {
                    if (item.Name == "btn_" + int.Parse(BLL.csshamsidate.shamsidate.Substring(8)).ToString())
                    {
                        item.ForeColor = Color.Purple;
                        item.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    }
                }
            }
        }
        public int ClickValue;
        public string ClickText;
        void bt_Click(object sender, EventArgs e)
        {
            if (ClickActive == true)
            {
                string d = (sender as Button).Text.Length < 2 ? "0" + (sender as Button).Text : (sender as Button).Text;
                string m = Mo > 9 ? Mo.ToString() : "0" + Mo.ToString();
                string y = Ye.ToString();
                userFunctionPointer.DynamicInvoke(y + "/" + m + "/" + d);
            }
        }
        void btn_order()
        {
            int y = 1;
            int lc = 0;
            int k = -1;
            foreach (Label item in panel1.Controls.OfType<Label>())
            {
                item.Size = new System.Drawing.Size((this.panel1.Width) / 7, (this.panel1.Height - 2) / 6);
                item.Location = new Point(lc, y);
                lc += item.Size.Width;

            }
            lc = 0;

            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                k++;
                if (k % 7 > 0)
                {
                    item.Location = new Point(lc, y);
                }
                else
                {
                    lc = 0;
                    y += item.Size.Height;
                    item.Location = new Point(lc, y);
                }
                lc += item.Size.Width;
            }
        }
        private string MoNuToTxt(int MonNU)
        {
            string Mon = "";
            switch (MonNU)
            {
                case 1:
                    Mon = "فروردین";
                    break;
                case 2:
                    Mon = "اردیبهشت";
                    break;
                case 3:
                    Mon = "خرداد";
                    break;
                case 4:
                    Mon = "تیر";
                    break;
                case 5:
                    Mon = "مرداد";
                    break;
                case 6:
                    Mon = "شهریور";
                    break;
                case 7:
                    Mon = "مهر";
                    break;
                case 8:
                    Mon = "آبان";
                    break;
                case 9:
                    Mon = "آذر";
                    break;
                case 10:
                    Mon = "دی";
                    break;
                case 11:
                    Mon = "بهمن";
                    break;
                case 12:
                    Mon = "اسفند";
                    break;

                default:
                    Mon = "خطا";
                    break;
            }
            return Mon;
        }

        void bt_MouseLeave(object sender, EventArgs e)
        {
            pupup.Close();
           /// (sender as Button).BackColor = Color.White;
        }

        void bt_MouseHover(object sender, EventArgs e)
        {
            if (PupapActive == true)
            {
                string d = (sender as Button).Text.Length < 2 ? "0" + (sender as Button).Text : (sender as Button).Text;
                string m = Mo > 9 ? Mo.ToString() : "0" + Mo.ToString();
                string y = Ye.ToString();
                PoPupMsg.DynamicInvoke((Control)sender, y + "/" + m + "/" + d);
            }
            //customToolTip.PopUpComment = ((Control)sender).Text;
            //pupup.Show((Control)sender);
        }
        public void ShowPopUp(Control Se, string Comment)
        {
            customToolTip.PopUpComment = Comment;
            pupup.Show(Se);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Mo == 1)
            { Mo = 12; Ye--; }
            else
                Mo--;

            panel1.Controls.OfType<Button>().ToList().ForEach(t => panel1.Controls.Remove(t));
            GenBtn();
            if (ChangeMonthActive)
                ChangeMonth.DynamicInvoke();
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            if (Mo == 12)
            { Mo = 1; Ye++; }
            else
                Mo++;
            panel1.Controls.OfType<Button>().ToList().ForEach(t => panel1.Controls.Remove(t));
            GenBtn();
            if (ChangeMonthActive)
                ChangeMonth.DynamicInvoke();
        }



    }
}
