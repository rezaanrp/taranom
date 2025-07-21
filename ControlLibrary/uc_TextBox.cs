using System;
using System.Drawing;
using System.Windows.Forms;

namespace UC
{
    public partial class uc_TextBox : UserControl
    {
        public uc_TextBox()
        {
            InitializeComponent();

        }
        private bool txtIsNumber = false;

        public bool IsNumber
        {
            get { return txtIsNumber; }
            set { txtIsNumber = value; }
        }

        private bool txtIsInteger = false;

        public bool IsInteger
        {
            get { return txtIsInteger; }
            set { txtIsInteger = value; }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            textBox1.Text = "";
        }
        public override string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public bool multitextbox
        {
            get { return textBox1.Multiline; }
            set
            {
                textBox1.Multiline = value;
            }
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;

        }
        private bool txtIsTime = false;

        public bool IsTime
        {
            get 
                {
                 return txtIsTime; 
                }
            set 
                { 
                 txtIsTime = value;
                }
        }
        
        
        private void uc_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtIsTime)
            {
                textBox1.MaxLength = 5;
                if (textBox1.Text.Length == 4)
                {
                    if (textBox1.Text.IndexOf(':') != 2)
                    {
                        textBox1.Text = "";
                        e.Handled = true;
                    }
                }
                if (!char.IsControl(e.KeyChar)
                                && !char.IsDigit(e.KeyChar)
                                    && e.KeyChar != ':')
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if (e.KeyChar == ':'
                    && (sender as TextBox).Text.IndexOf(':') > -1)
                {
                    e.Handled = true;
                }
                return;
            }
            
            if (txtIsNumber)
            {
                if (txtIsInteger)
                {
                    if (!char.IsControl(e.KeyChar)
                                && !char.IsDigit(e.KeyChar)
                                    )
                    {
                        e.Handled = true;
                    }

                }
                else
                {
                    if (!char.IsControl(e.KeyChar)
                                && !char.IsDigit(e.KeyChar)
                                    && e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }

                    // only allow one decimal point
                    if (e.KeyChar == '.'
                        && (sender as TextBox).Text.IndexOf('.') > -1)
                    {
                        e.Handled = true;
                    }
                }
                return;
            }
        }
    }
}












