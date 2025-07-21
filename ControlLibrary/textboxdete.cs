using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace ControlLibrary
{
    public partial class textboxdete : UserControl
    { 
        
        public textboxdete()
    {
        
           
           
            InitializeComponent();
            accept = false;
        }
        public bool showbutton
        {
            get {return button1.Visible;}
            set { button1.Visible = value; }
        }
        public string Text
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }
        public bool accept
        {
            get;
            set;

        }
        
           
        
        private void textboxdete_Load(object sender, EventArgs e)
        {
         //   PAYAIND.csshamsidateandtime cs = new PAYAIND.csshamsidateandtime(); maskedTextBox1.Text = cs.calcshmsidate();
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private bool truedate(string date)
        {

            try
            {

                if (date.Length < 10)
                {
                    return false; 
                }

                int day = 0;
                int mon = 0;
                int year = 0;
                if (date.Substring(8, 1) != "_" && date.Substring(9, 1) != "_")
                    day = int.Parse(date.Substring(8, 2));
                if (date.Substring(5, 1) != "_" && date.Substring(6, 1) != "_")
                    mon = int.Parse(date.Substring(5, 2));
                if (date.Substring(0, 1) != "_" && date.Substring(1, 1) != "_" && date.Substring(2, 1) != "_" && date.Substring(3, 1) != "_")
                    year = int.Parse(date.Substring(0, 4));
                if (year < 1300 || year > 1500 || day > 31 || 1 > day || mon > 12 || mon < 1)
                {
                    return false;
                } if (mon > 6 && day == 31) return false;
                else
                {
                    return true;

                }
            }
            catch { return false; }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (truedate(maskedTextBox1.Text))
            {  maskedTextBox1.BackColor = Color.Aquamarine;accept= true;}
            else{ maskedTextBox1.BackColor = Color.Pink;accept= false;}
            
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
          //  if (!truedate(maskedTextBox1.Text)) e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = BLL.csshamsidate.shamsidate;
        }
    }
}
