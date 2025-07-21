using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_Filter_Date : UserControl
    {
        public uc_Filter_Date()
        {
            InitializeComponent();
            //uc_txtDateTo.Text = "";
            //dateTimePicker_From.DateValue = new BLL.csshamsidate().previousDay(7
            dateTimePicker_To.DateValue = BLL.csshamsidate.shamsidate;
            if (BLL.csshamsidate.shamsidate.Substring(5, 2).Contains("01"))
                dateTimePicker_From.DateValue = BLL.csshamsidate.shamsidate.Substring(0, 4) + "/01/01";
            else
                dateTimePicker_From.DateValue = BLL.csshamsidate.shamsidate.Substring(0, 8) + "1";
            

        }
        protected override void OnSizeChanged(EventArgs e)
        {
            this.Size = new Size(340, this.Size.Height);
            base.OnSizeChanged(e);
        }

        public string DateTo
        {
            get 
            { 
                string sD;
                string sM;
                sM = int.Parse( dateTimePicker_To.DateValue.Split('/')[1] ) <10 ? "0" + int.Parse( dateTimePicker_To.DateValue.Split('/')[1] ).ToString(): int.Parse(dateTimePicker_To.DateValue.Split('/')[1]).ToString();
                sD = int.Parse(dateTimePicker_To.DateValue.Split('/')[2]) <10 ? "0" + int.Parse( dateTimePicker_To.DateValue.Split('/')[2] ).ToString():int.Parse( dateTimePicker_To.DateValue.Split('/')[2]).ToString();
                return dateTimePicker_To.DateValue.Split('/')[0] + "/" + sM  + "/"+ sD; 
            }
            set
            {
                dateTimePicker_To.DateValue = value;

            }
        }
        public string DateFrom
        {
            get
            {
                string sD;
                string sM;
                sM = int.Parse(dateTimePicker_From.DateValue.Split('/')[1]) < 10? "0" +int.Parse( dateTimePicker_From.DateValue.Split('/')[1] ).ToString(): int.Parse(dateTimePicker_From.DateValue.Split('/')[1]).ToString();
                sD = int.Parse(dateTimePicker_From.DateValue.Split('/')[2]) <10? "0" +int.Parse( dateTimePicker_From.DateValue.Split('/')[2] ).ToString():int.Parse( dateTimePicker_From.DateValue.Split('/')[2]).ToString();
                return dateTimePicker_From.DateValue.Split('/')[0] + "/" + sM + "/" + sD;
            }
            set
            {
                dateTimePicker_From.DateValue = value;

            }
        }

       
        /// <summary>
        /// برای فرم های ای که تاریخ بازه ای ندارد
        /// </summary>
        public bool DateToVisible
        {
            get { return dateTimePicker_To.Visible; }
            set {
                dateTimePicker_To.Visible = value;
                if (!value)
                    lbl_TA.Visible = false;
                else
                    lbl_TA.Visible = true;

            }
        }
        
        private void uc_txtDateFrom_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void uc_txtDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Down)
            //{
            //    BLL.csshamsidate cs = new BLL.csshamsidate();
            //    (sender as uc_TextBoxDate).Text = cs.previousDay((sender as uc_TextBoxDate).Text, 1, BLL.csshamsidate.Ravand.down);               
            //}
            //else if (e.KeyCode == Keys.Up)
            //{
            //    BLL.csshamsidate cs = new BLL.csshamsidate();
            //    (sender as uc_TextBoxDate).Text = cs.previousDay((sender as uc_TextBoxDate).Text, 1, BLL.csshamsidate.Ravand.up);
            //}
        }


        
    }
}
