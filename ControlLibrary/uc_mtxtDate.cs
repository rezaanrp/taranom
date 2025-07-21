using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_mtxtDate : UserControl
    {
        public uc_mtxtDate()
        {
            InitializeComponent();
            Size sd = new Size(this.Width, mtxt_dateinspection.Size.Height);
            this.Size =sd;
        }

        public bool IsNumber(string text)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
        public bool Isinteger(string text)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");
            return regex.IsMatch(text);
        }
        public bool accept = false;
        public override string Text
        {
            get
            {
                return mtxt_dateinspection.Text;
            }
            set
            {
                mtxt_dateinspection.Text = value;
            }
        }
       
        private void mtxt_dateinspection_Leave(object sender, EventArgs e)
        {
            accept = false;

            if (mtxt_dateinspection.Text.Length < 10)
            {
                MessageBox.Show("تاریخ ورودی صحیح نمی باشد.");
                return;
            }
            string date = mtxt_dateinspection.Text;
            int day = int.Parse(date.Substring(8, 2));
            int mon = int.Parse(date.Substring(5, 2));
            int year = int.Parse(date.Substring(0, 4));
            if (year < 1300 || year > 1500 || day > 31 || 1 > day || mon > 12 || mon < 1)
            {
                MessageBox.Show("تاریخ ورودی صحیح نمی باشد.");
            }
            else
                accept = true;
        }

        public string Text_label
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        
        private void uc_mtxtDate_Load(object sender, EventArgs e)
        {
        }
    }
}
