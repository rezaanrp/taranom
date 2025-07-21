using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ControlLibrary
{
    public partial class ucSubmenu : UserControl
    {
        public ucSubmenu()
        {
            InitializeComponent();


        }


        Payazob.MyControl.CustomToolTip customToolTip;
        ControlLibrary.PopUp.Popup pupup;

        void btn_order()
        {
            int y = 20;
            int lc = 0;
            int lt = 0;
            foreach (GroupBox grpb in panel1.Controls)
            {
               lc = 0;
               y = 20;
                grpb.Location = new Point(0, lt);
                grpb.Size = new Size(panel1.Width - 20 , 0);

                foreach (Button item in grpb.Controls)
                {
                    if (lc < (grpb.DisplayRectangle.Width - item.Size.Width))
                    {
                        item.Location = new Point(lc, y);
                    }
                    else
                    {
                        lc = 1;
                        y += item.Size.Height;
                        item.Location = new Point(lc, y);
                    }
                    lc += item.Size.Width;
                }

                foreach (Button item in grpb.Controls)
                {
                    item.Location = new Point(item.Location.X + 10, item.Location.Y);
                }
                grpb.Size = new Size(panel1.Width - 20, y + 60);
                lt += grpb.Size.Height;

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string st =((System.Windows.Forms.Control)(sender)).Name.ToString();
            st = st.Substring(4);
            Payazob.CS.csOpenForm op = new Payazob.CS.csOpenForm();
            TARANOM.Properties.Settings.Default.LsfEn = st;
            TARANOM.Properties.Settings.Default.LsfFa = ((System.Windows.Forms.Control)(sender)).Text.ToString();
            op.FindForm(st, ((System.Windows.Forms.Control)(sender)).Text.ToString());
            TARANOM.Properties.Settings.Default.Save();
           
        }

    
        public void GenerateBtn(string TypeBtn)
        {


            BLL.authentication obj = new BLL.authentication();
            DataTable dt = obj.SelectObjectListAllow();
            

            DataView view = new DataView(dt);
            DataTable distinctValues = view.ToTable(true, "igroup");
            Color[] clr = new Color[7];
            clr[0] = Color.DeepSkyBlue;
            clr[1] = Color.Coral;
            clr[2] = Color.MediumTurquoise;
            clr[3] = Color.Plum;
            clr[4] = Color.LightSlateGray;
            clr[5] = Color.SteelBlue;
            clr[6] = Color.SkyBlue;
            int inx = 1;
            foreach (DataRow drg in distinctValues.Rows)
            {
                
                DataRow[] dr = dt.Select("xType_ = " + TypeBtn + " AND igroup = " + drg["igroup"].ToString());
                if (dr.Length < 1)
                    continue;

                GroupBox groupBox1 = new GroupBox(); ;
                groupBox1.Location = new System.Drawing.Point(12, 12);
                groupBox1.Size = new System.Drawing.Size(571, 135);
                groupBox1.TabIndex = 1;
                groupBox1.TabStop = false;

                groupBox1.BackColor = clr[(inx % 7 )];
                inx++;
                groupBox1.Text = dr[0].ItemArray[4].ToString();
                groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);

                groupBox1.Padding = new System.Windows.Forms.Padding(9);
                groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

                this.panel1.Controls.Add(groupBox1);

                foreach (DataRow item in dr)
                {
                    ControlLibrary.uc_btn bt = new ControlLibrary.uc_btn();
                    bt.Name = "btn_" + item["xObject_"].ToString();
                    bt.Text = item["ObjectFarsiName"].ToString();
                    bt.Size = new System.Drawing.Size(125, 47);
                    bt.UseVisualStyleBackColor = true;
                    bt.BackColor = Color.WhiteSmoke;
                    bt.Click += new EventHandler(btn_Click);
                    bt.MouseHover += new EventHandler(bt_MouseHover);
                    bt.MouseLeave += new EventHandler(bt_MouseLeave);
                    bt.FlatStyle = FlatStyle.Flat;
                    bt.Font = new System.Drawing.Font("Tahoma", 9f);
                    groupBox1.Controls.Add(bt);

                }
                btn_order();
                pupup = new ControlLibrary.PopUp.Popup(customToolTip = new Payazob.MyControl.CustomToolTip());
                pupup.AutoClose = false;
                pupup.FocusOnOpen = false;
                pupup.ShowingAnimation = pupup.HidingAnimation = ControlLibrary.PopUp.PopupAnimations.None | ControlLibrary.PopUp.PopupAnimations.Slide; ;

            }

        }

        void bt_MouseLeave(object sender, EventArgs e)
        {
            pupup.Close();
            //this.ParentForm.SendToBack();
        }

        void bt_MouseHover(object sender, EventArgs e)
        {
            customToolTip.PopUpComment = ((Control)sender).Text;
            pupup.Show((Control)sender);
        }
        private void ucSubmenu_SizeChanged(object sender, EventArgs e)
        {
            btn_order();

        }

        private void ucSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PointF[] points = {	  new Point(20, 90),
                                  new Point(410, 90),
                                  new Point(410, 200),
                                  new Point(80, 200),
                                  new Point(20, 90)};



            Pen pen = new Pen(Color.FromArgb(100, 160, 116), 2);

            LinearGradientBrush brush0 = new LinearGradientBrush(new Rectangle(0, 0, 500, panel1.Height), Color.FromArgb(0, 206, 180), Color.FromArgb(23, 64, 109), 90.0f);

            e.Graphics.FillRectangle(brush0, 0, 0, 1500, 1600);
        }



    }
}
