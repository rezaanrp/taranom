using System;
using System.ComponentModel;

namespace ControlLibrary
{
    public partial class uc_TextBoxDate : System.Windows.Forms.MaskedTextBox
    {
        public uc_TextBoxDate()
        {
            InitializeComponent();
           // this.Leave += new EventHandler(uc_TextBoxDate_Leave);
            this.Mask = "0000/00/00";
            this.Text = "0000/00/00";
            this.Size = new System.Drawing.Size(120, 20);
            this.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;

        }

        public uc_TextBoxDate(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
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

        private bool acceptDate;

        public bool accept
        {
            get
            {
                uc_TextBoxDate_Accept();
                if (!acceptDate)
                    this.Text = "";
                return acceptDate;

            }
            set
            {

                acceptDate = value;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {

            if (this.Text.Length < 10)
            {
                this.BackColor = System.Drawing.Color.OrangeRed;
            }
            string date = this.Text;
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
                this.BackColor = System.Drawing.Color.Pink;
            }
            else
            {
                this.BackColor = System.Drawing.Color.LightGreen;
            }
            base.OnTextChanged(e);
        }
        private void uc_TextBoxDate_Accept()
        {
            acceptDate = false;

            if (this.Text.Length < 10)
            {
                return;
            }
            string date = this.Text;
            int day = int.Parse(date.Substring(8, 2));
            int mon = int.Parse(date.Substring(5, 2));
            int year = int.Parse(date.Substring(0, 4));
            if (year < 1300 || year > 1500 || day > 31 || 1 > day || mon > 12 || mon < 1)
            {
                acceptDate = false;
            }
            else
                acceptDate = true;
        }



    }
}
