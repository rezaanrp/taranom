using System;
using System.ComponentModel;
using System.Drawing;


namespace ControlLibrary
{
    public partial class uc_txtBox : System.Windows.Forms.TextBox
    {
        public uc_txtBox()
        {
            InitializeComponent();
            this.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Anchor = System.Windows.Forms.AnchorStyles.Top;


        }

        public string textWithcomma { get ; set; }
        public string textWithoutcomma { get; set; }

        private string skipComma(string str)
        {
            string[] ss = null;
            string strnew = "";
            if (str == "")
            {
                strnew = "0";
            }
            else
            {
                ss = str.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    strnew += ss[i];
                }
            }
            return strnew;
        }

        public override string Text
        {
            get
            {
                if (txtIsNumber)
                {
                    if (base.Text == "" || base.Text == null)
                            return "0";
                }


                return base.Text;
            }
            set
            {
                     base.Text = value;
            }
        }

        public uc_txtBox(IContainer container)
        {
            container.Add(this);

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
            this.BackColor = Color.LightYellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsInteger == true)
            {
                if (this.Text == "")
                {
                    this.Text = "0";
                    textWithcomma = "0"; //this property maintain the content of textbox with comma
                    textWithoutcomma = "0";  //this property maintain the content of textbox without comma
                }
                else
                {
                    if (this.Text != "")
                    {
                        double d = Convert.ToDouble(skipComma(this.Text));
                        this.Text = d.ToString("#,#",
                          System.Globalization.CultureInfo.InvariantCulture);
                        textWithcomma = this.Text;//property maintain content of textbox with comma
                        textWithoutcomma = skipComma(this.Text);

                        //property maintain content of textbox without comma
                    }
                }
                this.Select(this.Text.Length, 0);
            }
        }

        
        
        public void empty()
        {
            this.Text = "";
        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

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


        private void uc_TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (txtIsTime)
            {
                this.MaxLength = 5;
                if (this.Text.Length == 4)
                {
                    if (this.Text.IndexOf(':') != 2)
                    {
                        this.Text = "";
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
                    && (sender as System.Windows.Forms.TextBox).Text.IndexOf(':') > -1)
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
                        && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
                    {
                        e.Handled = true;
                    }
                }
                return;
            }
        }

    }
}
