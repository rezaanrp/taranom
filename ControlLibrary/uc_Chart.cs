using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_Chart : UserControl
    {
        public uc_Chart()
        {
            InitializeComponent();

        }


        public Bitmap UcPic
        {
            get { return (Bitmap)pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public Bitmap DrawString(float[] chart, float max, float min, float avg,Bitmap btm)
        {
            System.Drawing.Graphics obj;
            obj = Graphics.FromImage(btm);

            Pen df = new Pen(Color.Black);
            df.Width = 3;

            if (chart.Length < 1)
            {
                return btm;
            }

            float maxnumber = max;
            float minnumber = min;

            foreach (float item in chart)
            {
                if (maxnumber < item)
                    maxnumber = item;

                if (minnumber > item)
                    minnumber = item;
            }

            minnumber -= 10;
            maxnumber += 10;
            int rangex = (int)(btm.Width / chart.Length);
            float rangey = maxnumber - minnumber;

            float va = (float)((btm.Height) / (rangey));
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            obj.DrawString(max.ToString(), new Font("Arial", 7), drawBrush, 0, (btm.Height) - (max - minnumber) * va);
            obj.DrawString(min.ToString(), new Font("Arial", 7), drawBrush, 0, (btm.Height) - (min - minnumber) * va);
            obj.DrawString(avg.ToString(), new Font("Arial", 7), drawBrush, 0, (btm.Height) - (avg - minnumber) * va);



            for (int i = 0; i < chart.Length; i++)
            {
                obj.DrawString(chart[i].ToString(), new Font("Arial", 8, FontStyle.Bold), drawBrush, i * rangex + 5, (btm.Height - (chart[i] - minnumber) * va) - 5);

            }
            return btm;
        }

        public Bitmap DrawChart(float[] chart, float max, float min, float avg)
        {

            System.Drawing.Graphics obj;
            Bitmap btm = new Bitmap(this.Width, this.Height);
            obj = Graphics.FromImage(btm);
            obj.Clear(Color.Gainsboro);

            Pen df = new Pen(Color.Black);
            df.Width = 3;

            if (chart.Length < 1)
            {
                return btm;
            }
          
            float maxnumber = max;
            float minnumber = min;

            foreach (float item in chart)
            {
                if (maxnumber < item)
                    maxnumber = item;

                if (minnumber > item)
                    minnumber = item;
            }

            minnumber -= 10;
            maxnumber += 10;
            int rangex = (int)(btm.Width / chart.Length);
            float rangey = maxnumber - minnumber;

            float va = (float)((btm.Height) / (rangey));

            obj.DrawLine(new Pen(Color.Silver, 2), 0, (btm.Height) - (max - minnumber) * va, (float)btm.Width, (btm.Height) - (max - minnumber) * va);
            obj.DrawLine(new Pen(Color.Silver, 2), 0, (btm.Height) - (min - minnumber) * va, (float)btm.Width, (btm.Height) - (min - minnumber) * va);
            obj.DrawLine(new Pen(Color.Green, 2), 0, (btm.Height) - (avg - minnumber) * va, (float)btm.Width, (btm.Height) - (avg - minnumber) * va);

            PointF[] p = new PointF[chart.Length];

            for (int i = 0; i < chart.Length; i++)
            {
                p[i].Y = btm.Height - (chart[i] - minnumber) * va;
                p[i].X = i * rangex;
            }

            obj.DrawLines(df, p);

            for (int i = 0; i < p.Length; i++)
            {
                obj.DrawRectangle(new Pen(Color.White, 3), p[i].X, p[i].Y, 2, 2);
            }
            return btm;
        }

        public Bitmap DrawcolumnChart(float[] chart, float max, float min, float avg,Bitmap btm ,int x)
        {

            System.Drawing.Graphics obj;
            obj = Graphics.FromImage(btm);
            //obj.Clear(Color.Gainsboro);

            Pen df = new Pen(Color.Black);
            df.Width = 3;

            if (chart.Length < 1)
            {
                return btm;
            }

            float maxnumber = max;
            float minnumber = min;

            foreach (float item in chart)
            {
                if (maxnumber < item)
                    maxnumber = item;

                if (minnumber > item)
                    minnumber = item;
            }

            minnumber -= 10;
            maxnumber += 10;
            int rangex = (int)(btm.Width / chart.Length);
            float rangey = maxnumber - minnumber;

            float va = (float)((btm.Height) / (rangey));

            

            PointF[] p = new PointF[chart.Length];

            for (int i = 0; i < chart.Length; i++)
            {
                p[i].Y = btm.Height - (chart[i] - minnumber) * va;
                p[i].X = (float)(i + 0.5) * rangex;
            }
            for (int i = 0; i < chart.Length; i++)
            {
                obj.DrawRectangle(new Pen(Color.FromArgb(110 + x,19 * x,123 + x), 4), p[i].X + x, p[i].Y, 3, btm.Height);
                DrawString(chart[i].ToString(), p[i].X, p[i].Y - 10, ref btm);
            }

          //  obj.DrawLines(df, p);


            for (int i = 0; i < p.Length; i++)
            {
                obj.DrawRectangle(new Pen(Color.Black, 3), p[i].X + x, p[i].Y, 2, 2);
            }
            return btm;
        }
        public void DrawTitle(string st, ref Bitmap btm,int FontSize)
        {
            System.Drawing.Graphics obj;
            obj = Graphics.FromImage(btm);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat();
            
            obj.DrawString(st, new Font("Arial", FontSize), drawBrush, 0 + 5,0 + 5, sf);

        }
        public void DrawString(string st, float x, float y,ref Bitmap btm)
        {
            //System.Nullable<btm>
            System.Drawing.Graphics obj;
            obj = Graphics.FromImage(btm);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat();
            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            obj.DrawString(st, new Font("Arial", 10), drawBrush, x, y, sf);

        }

        // Method that takes an iterable input (possibly an array) and returns all even numbers.

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            Form form = new Form();
            Size s = new Size(800, 600);
            form.Size = s;
            panel.Dock = DockStyle.Fill;
            form.Controls.Add(panel);
            PictureBox pb = new PictureBox();
            pb.Image = pictureBox1.Image;
            pb.Size =form.Size;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            panel.Controls.Add(pb);
            form.ShowDialog();
        }

    }
}
