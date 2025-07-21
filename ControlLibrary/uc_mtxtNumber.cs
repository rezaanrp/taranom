using System;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_mtxtNumber : UserControl
    {
        public uc_mtxtNumber()
        {
            InitializeComponent();
            maskedTextBox1.Text = min.ToString();
           
        }

        //private Size u_size;

        //public Size uc_size
        //{
        //    get { 
                
        //        return this.Size; 
        //    }
        //    set {
        //        maskedTextBox1.Size = value;
        //        this.Size.Width = (value.Width + 7) ; 
        //    }
        //}
        

        private int min;
        
        
        public string uc_mask
        {
            get { return maskedTextBox1.Mask; }
            set { maskedTextBox1.Mask = value; }
        }
        
        public int mtxt_min
        {
            get { return min; }
            set { min = value; }
        }
        private int max;

        public int mtxt_max
        {
            get { return max; }
            set { max = value; }
        }
        public bool accept = false;
        public override string Text
        {
            get
            {
                return maskedTextBox1.Text;
            }
            set
            {
                maskedTextBox1.Text = value.ToString();
            }
        }
        private void maskedTextBox1_DragLeave(object sender, EventArgs e)
        {

            if (maskedTextBox1.Text == "" || int.Parse(maskedTextBox1.Text) < min || int.Parse(maskedTextBox1.Text) > max)
            {
                lbl_message.Text = "خطا";
                this.Focus();
                accept = false;
            }
            else
            {
                accept = true;
                lbl_message.Text = ""; 
            }

                
        }
    }
}
