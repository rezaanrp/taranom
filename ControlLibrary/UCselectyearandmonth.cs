using System;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class UCselectyearandmonth : UserControl
    {
        public UCselectyearandmonth()
        {

            InitializeComponent();
          

            

        }
        public bool fillinformation
        {
            get;
            set;
        }

        private void UCselectyearandmonth_Load(object sender, EventArgs e)
        {
            if (fillinformation)
            {
                //PAYAIND.csshamsidateandtime cs = new PAYAIND.csshamsidateandtime();
                comboBoxEx2.SelectedIndex = int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2));
                numericUpDown1.Value = int.Parse( BLL.csshamsidate.shamsidate.Substring(0, 4));
              //  MessageBox.Show(comboBoxEx2.SelectedIndex.ToString()+"       " + numericUpDown1.Value.ToString());
            }
        }
        public string textforview
        {
            set { label3.Text = value; }
            get { return label3.Text; }

        }
        public int year
        {
            get {return Convert.ToInt32( numericUpDown1.Value); }
            set { numericUpDown1.Value =year; }
        }
        public int month
        {
            get { return comboBoxEx2.SelectedIndex + 1; }
            set
            {
                comboBoxEx2.SelectedIndex = month - 1;
            }
        }
        public string selecteddate
        {
            get
            {int a =comboBoxEx2.SelectedIndex + 1;
                if (a > 9)
                {
                    return(numericUpDown1.Value.ToString()+"/"+a.ToString());
                }
                else return (numericUpDown1.Value.ToString() + "/0" + a.ToString());
            }
            set
            {

                year = int.Parse(value.Substring(0, 4));
                comboBoxEx2.SelectedIndex = int.Parse(value.Substring(5, 2))-1;
            

            }
        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

       
    }
}
