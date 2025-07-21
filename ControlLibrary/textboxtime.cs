using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class textboxtime : UserControl
    {
        public textboxtime()
        {
            InitializeComponent();
        }
        public bool showbutton
        {
            get { return button1.Visible; }
            set { button1.Visible = value; }
        }
        public string Text
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }
        public string Time
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }

        }
        public bool accept;

        private void textboxtime_Load(object sender, EventArgs e)
        {
           //PAYAIND.csshamsidateandtime cs = new PAYAIND.csshamsidateandtime();
          //  maskedTextBox1.Text = cs.calctime();
        }

        private bool trutime(string time)
        {
            try
            {
                int h = Convert.ToInt32(time.Substring(0, 2));
                int m = Convert.ToInt32(time.Substring(3, 2));
                if ((h >= 0 && h <= 23) && (m >= 0 && m <= 59)) return true;
                return false;
            }
            catch { return false; }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (trutime(maskedTextBox1.Text)) { maskedTextBox1.BackColor = Color.Aquamarine; accept = true; }
            else { maskedTextBox1.BackColor = Color.Pink; accept = false; }
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
           // if (!trutime(maskedTextBox1.Text)) e.Cancel = true;
        }
        public string calctime()
        {
            string time;
            DateTime t = DateTime.Now;
            string h = (t.Hour > 9) ? t.Hour.ToString() : "0" + t.Hour.ToString();
            string m = (t.Minute > 9) ? t.Minute.ToString() : "0" + t.Minute.ToString();
            time = h + ":" + m;
            return time;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text = calctime();
        }
        
           
    }
}
