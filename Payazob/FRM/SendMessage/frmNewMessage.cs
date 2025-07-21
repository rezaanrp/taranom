using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Payazob.FRM.SendMessage
{
    public partial class frmNewMessage : Form
    {
        public frmNewMessage(bool IsReply,bool Isforward, string ReplyFrom,int ReplyUser_,string ReplyName,string MessageSubject,string textMessage,string richtxtbox_rtf)
        {
            InitializeComponent();
            dt_m = new DAL.Message.DataSet_Message.SlMessageDataTable();


            DataTable dt = new DataTable();
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            DataRow dr = dt.NewRow();
            dr["State"] = "عادی";
            dr["Value"] = "O";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();

            dr1["State"] = "اضطراری";
            dr1["Value"] = "E";
            dt.Rows.Add(dr1);

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "Value";
            comboBox1.DisplayMember = "State";

            uc_txtBoxDate.Text = BLL.csshamsidate.shamsidate;
            uc_TextBoxDate1.Text = new BLL.csshamsidate().previousDay(-30);
            IsRe = IsReply;
            IsFr = Isforward;
            RepFrm = ReplyFrom;
            msgbox = textMessage;
            if (ReplyUser_ != -1)
            {
                rec = new List<int>();
                rec.Add(ReplyUser_);
                uc_txtBox_reciver.Text = ReplyName;
                uc_txtBox_Subject.Text = "پاسخ به " + MessageSubject;
            }
            if (IsFr)
            {
                uc_txtBox_Context.Text = msgbox;
                uc_txtBox_Context.Rtf = richtxtbox_rtf;
                uc_txtBox_Subject.Text = MessageSubject;
            }

        }
        bool IsRe;
        bool IsFr;
        string RepFrm;
        string msgbox;
        DAL.Message.DataSet_Message.SlMessageDataTable dt_m;
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (uc_txtBox_reciver.Text == "")
                return;
            string stl = BLL.authentication.x_.ToString() + DateTime.Now.Year +DateTime.Now.DayOfYear + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
         //   dt_mt.AddSlMessageToRow(5,
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("خطا", "مقدار فوریت مشخص شود", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return; }
               
            foreach (int item in rec)
            {

                dt_m.AddSlMessageRow(BLL.csshamsidate.shamsidate, BLL.authentication.x_, "", uc_txtBox_Subject.Text, "", uc_txtBox_Context.Text, uc_TextBoxDate1.Text, item, "", "E", false, comboBox1.SelectedValue.ToString(), stl, RepFrm, "", uc_txtBox_reciver.Text, chb_Elan.Checked);

            }
            MessageBox.Show(new BLL.Message.csMessage().UdMessage(dt_m));
            this.Close();
            
        }
        List<int> rec;
        private void btn_AddReciver_Click(object sender, EventArgs e)
        {
            if (IsRe == false)
            {
                FRM.SendMessage.frmMessageReciver frm = new frmMessageReciver();

                frm.ShowDialog();
                rec = frm.itm;
                uc_txtBox_reciver.Text = frm.listName;
            }

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            foreach (Button item in panel1.Controls.OfType<Button>())
            {
                item.Visible = true;
            }
        }

        private void btn_abadan_Click(object sender, EventArgs e)
        {
            string st = (sender as Button).Name;
            switch (st)
            {
                case "btn_abadan":
                    uc_txtBox_Context.Text += "B-)";
               
            break;
                case "btn_akh":
            uc_txtBox_Context.Text += "#-o";

            break;
                case "btn_asabani":
            uc_txtBox_Context.Text += "X(";

            break;
                case "btn_cheshmak":
            uc_txtBox_Context.Text += ";-)";

            break;
                case "btn_cry":
            uc_txtBox_Context.Text += ":((";

            break;
                case "btn_khande":
            uc_txtBox_Context.Text += ":)";

            break;
                case "btn_labkhand":
            uc_txtBox_Context.Text += ":-)";

            break;
                case "btn_like":
            uc_txtBox_Context.Text += "LIKE";

            break;
                case "btn_narahat":
            uc_txtBox_Context.Text += ":-(";

            break;
            }

        }
    }
}
