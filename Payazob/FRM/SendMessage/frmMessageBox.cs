using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Payazob.FRM.SendMessage
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
            CreateEmotions();

        }
        bool ReciveBoxClick = false;
        DAL.Message.DataSet_Message.SlMessageDataTable dt_M;
        private Stack<int> stackParamx_Min = new Stack<int>();

        string str_srch = "$$";
        string str_srchT = "$$";

        private void button2_Click(object sender, EventArgs e)
        {
            btn_reply.Visible = true;
            ShowRec(true,true);
           // str_srch = "$$";
            //tstb_Search.Text = "";

        }
        void ShowRec(bool isNext,bool isFirst)
        {
            if (isFirst)
                for (int i = 0; i < stackParamx_Min.Count; i++)
                {
                    stackParamx_Min.Pop();
                }
            BLL.Message.csMessage cs = new BLL.Message.csMessage();
            int x_Min = -1;
            if (dt_M != null && dt_M.Rows.Count > 0 && !isFirst && isNext)
            {
                x_Min = int.Parse(dt_M.Select(" x_ = MIN(x_)")[0]["x_"].ToString());

                stackParamx_Min.Push(int.Parse(dt_M.Select(" x_ = MAX(x_)")[0]["x_"].ToString()));
                dt_M = cs.SlMessage(-1, BLL.authentication.x_, x_Min, str_srch, str_srchT);
            }
            else if (!isFirst && !isNext && stackParamx_Min.Count > 0)
            {
                dt_M = cs.SlMessage(-1, BLL.authentication.x_, stackParamx_Min.Pop(), str_srch, str_srchT);
            }

            else dt_M = cs.SlMessage(-1, BLL.authentication.x_, -1, str_srch, str_srchT);

            if (dt_M.Count > 0)
                toolStripButton5.Enabled = true;
            else
                toolStripButton5.Enabled = false;


            if (stackParamx_Min.Count > 0)
                toolStripButton2.Enabled = true;
            else
                toolStripButton2.Enabled = false;

           

            dataGridView1.DataSource = dt_M;
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;

            Generate();
            ReciveBoxClick = true;

            dataGridView1.Columns["SenderName"].Visible = true;
            dataGridView1.Columns["ReciverName"].Visible = false;
            dataGridView1.Columns["xElan"].Visible = false;
        }
        void ShowSend(bool isNext, bool isFirst)
        {
            btn_reply.Visible = false;

            if (isFirst)
                for (int i = 0; i < stackParamx_Min.Count; i++)
                {
                    stackParamx_Min.Pop();
                }
            BLL.Message.csMessage cs = new BLL.Message.csMessage();
            int x_Min = -1;
            if (dt_M != null && dt_M.Rows.Count > 0 && !isFirst && isNext)
            {
                x_Min = int.Parse(dt_M.Select(" x_ = MIN(x_)")[0]["x_"].ToString());
               
                    stackParamx_Min.Push(int.Parse(dt_M.Select(" x_ = MAX(x_)")[0]["x_"].ToString()));
                    dt_M = cs.SlMessage(BLL.authentication.x_, -1, x_Min, str_srch, str_srchT);
            }
            else if (dt_M != null && dt_M.Rows.Count > 0 && !isFirst && !isNext && stackParamx_Min.Count > 0)
            {
                dt_M = cs.SlMessage(BLL.authentication.x_, -1, stackParamx_Min.Pop(), str_srch, str_srchT);
            }

            else dt_M = cs.SlMessage(BLL.authentication.x_, -1, -1, str_srch, str_srchT);


            if (dt_M.Count > 0)
                toolStripButton5.Enabled = true;
            else
                toolStripButton5.Enabled = false;


            if (stackParamx_Min.Count > 0)
                toolStripButton2.Enabled = true;
            else
                toolStripButton2.Enabled = false;

            dataGridView1.DataSource = dt_M;
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.Columns["SenderName"].Visible = false;
            Generate();
            ReciveBoxClick = false;
            dataGridView1.Columns["ReciverName"].Visible = true;
            dataGridView1.Columns["xElan"].Visible = false;

        }
        private void btn_NewMessage_Click(object sender, EventArgs e)
        {
            FRM.SendMessage.frmNewMessage frm = new frmNewMessage(false,false,"",-1,"","","","");
            frm.ShowDialog();
            ShowRec(true,true);
            btn_inbox.Focus();
        }
        void Generate()
        {

            dataGridView1.Columns["xSubject"].HeaderText = "موضوع";
            dataGridView1.Columns["SenderName"].HeaderText = "فرستنده";
            dataGridView1.Columns["ReciverName"].HeaderText = "دریافت کننده";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";

          //  dataGridView1.Columns["xContext"].HeaderText = "";

            dataGridView1.Columns["ReciverName"].Visible = false;
            dataGridView1.Columns["SenderName"].Visible = false;

            
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xUser_"].Visible = false;
            dataGridView1.Columns["xContext"].Visible = false;
            dataGridView1.Columns["xDo"].Visible = false;
            dataGridView1.Columns["xSendTo_"].Visible = false;
            dataGridView1.Columns["xDateExpire"].Visible = false;
            dataGridView1.Columns["xDateRead"].Visible = false;
            dataGridView1.Columns["xType"].Visible = false;
            dataGridView1.Columns["xLetterId"].Visible = false;
            dataGridView1.Columns["xReplyFrom"].Visible = false;
            dataGridView1.Columns["replyContext"].Visible = false;
            dataGridView1.Columns["xCurrentTime"].Visible = false;
            dataGridView1.Columns["xMessageFrom"].Visible = false;
        //    dataGridView1.Columns["Column1"].DisplayIndex = 12;
            
            dataGridView1.Columns["xSubject"].Width = 250;
            dataGridView1.Columns["xSubject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["xDateRead"].Value.ToString().Contains( "E"))
                {
                    item.DefaultCellStyle.BackColor = Color.Orange;
                }
            }

        }
        private void btn_OutBox_Click(object sender, EventArgs e)
        {
            ShowSend(true,true);
           // str_srch = "$$";
           // tstb_Search.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("موضوع: ندارد");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("مجتمع پایاذوب کاوه با خلق ارزشهايی همچون خلاقيت، کارآفرينی، تعهد به مشتری گرايی و تلاش برای دستيابی به بالاترين سطح کارائی، تامين کننده قطعات چدنی در صنعت خودرو بوده است. اکنون در انديشه جهانی شدن، با حفظ اقتدار و رهبری بازار، ورود به صنعت خودرو سازی جهان خودرو در جهت تامين قطعات چدنی ريخته گری و ارائه راحل هايی کارآمد برای بالا بردن سطح کيفيت قطعات در ايران و جهان می باشد.");

            richTextBox1.Text += sb.ToString();
         //   textBox_Content.AppendText ( "موضوع: ندارد" + "\n\n\n" + "lkkjhskjh");
            //textBox_Content.Text += "مجتمع پایاذوب کاوه با خلق ارزشهايی همچون خلاقيت، کارآفرينی، تعهد به مشتری گرايی و تلاش برای دستيابی به بالاترين سطح کارائی، تامين کننده قطعات چدنی در صنعت خودرو بوده است. اکنون در انديشه جهانی شدن، با حفظ اقتدار و رهبری بازار، ورود به صنعت خودرو سازی جهان خودرو در جهت تامين قطعات چدنی ريخته گری و ارائه راحل هايی کارآمد برای بالا بردن سطح کيفيت قطعات در ايران و جهان می باشد." + "\n";
        }
        void SaveDataGridView()
        {
            new BLL.Message.csMessage().UdMessage(dt_M);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            BLL.Message.csMessage cs = new BLL.Message.csMessage();

            StringBuilder sb = new StringBuilder();
            if (dataGridView1["replyContext", e.RowIndex].Value.ToString() != "")
            {
                sb.AppendLine(dataGridView1["replyContext", e.RowIndex].Value.ToString() + "");
                sb.AppendLine("");
                sb.AppendLine("-------------------------------------------");
                sb.AppendLine("");
            }
            sb.AppendLine(dataGridView1["xContext", e.RowIndex].Value.ToString() + "");
            richTextBox1.Text = sb.ToString();

          //  uc_txtBoxExpireDate.Text = (string)dataGridView1["xDateExpire", e.RowIndex].Value;
            uc_txtBoxSubject.Text = (string)dataGridView1["xSubject", e.RowIndex].Value;
            uc_txtBoxSender.Text = (string)dataGridView1["SenderName", e.RowIndex].Value;
            uc_txtBoxReciver.Text = (string)dataGridView1["ReciverName", e.RowIndex].Value;
            this.toolTip1.SetToolTip(this.uc_txtBoxReciver, dataGridView1["xMessageFrom", e.RowIndex].Value.ToString());

            uc_txtBoxSendDate.Text = (string)dataGridView1["xDate", e.RowIndex].Value;
            uc_txtBox_Time.Text = (string)dataGridView1["xCurrentTime", e.RowIndex].Value;
        //    uc_txtBoxType.Text = dataGridView1["xType", e.RowIndex].Value.ToString().Contains("E") ? "اضطراری" : "عادی";
            // بهد از عوض شدن سیستم دریاف کننده این قسمت در صورت اینکه مشکلی نداشته باشد حذف شود
            // uc_txtBoxReciver.Text = cs.SlMessageFrom(dataGridView1["xLetterId", e.RowIndex].Value.ToString());
            uc_txtBoxReciver.Text = dataGridView1["xMessageFrom", e.RowIndex].Value.ToString();

            if (ReciveBoxClick)
            {
                dataGridView1["xDateRead", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                this.Validate();
                dataGridView1.EndEdit();
                cs.UdMessage(dt_M);
            }
            replyfrom = dataGridView1["xLetterId", e.RowIndex].Value.ToString(); ;
            ReplyUser_ = (int)dataGridView1["xUser_", e.RowIndex].Value;
            AddEmotions();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        string replyfrom;
        int ReplyUser_ = -1;
        private void btn_reply_Click(object sender, EventArgs e)
        {
            FRM.SendMessage.frmNewMessage frm = new frmNewMessage(true,false,replyfrom,ReplyUser_,"<"+uc_txtBoxSender.Text+">","<"+uc_txtBoxSubject.Text+">","","");
            frm.ShowDialog();
            ShowRec(true,true);
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(ReciveBoxClick)
                  dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (btn_reply.Visible)
                ShowRec(true,false);
            else
                ShowSend(true,false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (btn_reply.Visible)
                ShowRec(false,false);
            else
                ShowSend(false, false);
        }

        Hashtable emotions;
        void CreateEmotions()
        {
            emotions = new Hashtable(6);
            emotions.Add(":-)", TARANOM.Properties.Resources.labkhand);
            emotions.Add(":)", TARANOM.Properties.Resources.khande);
            emotions.Add(";-)", TARANOM.Properties.Resources.cheshmak);
            emotions.Add("X(", TARANOM.Properties.Resources.asabani);
            emotions.Add("B-)", TARANOM.Properties.Resources.abadan);
            emotions.Add("#-o", TARANOM.Properties.Resources.akh);
            emotions.Add("LIKE", TARANOM.Properties.Resources.like);
            emotions.Add(":((", TARANOM.Properties.Resources.cry);
            emotions.Add(":-(", TARANOM.Properties.Resources.narahat);
            
        }

        void AddEmotions()
        {
            foreach (string emote in emotions.Keys)
            {
                while (richTextBox1.Text.Contains(emote))
                {
                    int ind = richTextBox1.Text.IndexOf(emote);
                    richTextBox1.Select(ind, emote.Length);
                    Clipboard.SetImage((Image)emotions[emote]);
                    richTextBox1.Paste();
                }
            }
        }

        private void btn_Elan_Click(object sender, EventArgs e)
        {
            FRM.SendMessage.frmMessageElan frm = new frmMessageElan();
            frm.ShowDialog();
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            FRM.SendMessage.frmNewMessage frm = new frmNewMessage(false,true,"", -1, "", "<" + uc_txtBoxSubject.Text + ">" + " از طرف " +uc_txtBoxSender.Text ,richTextBox1.Text,richTextBox1.Rtf);
            frm.ShowDialog();
            ShowRec(true, true);
        }

        private void tstb_Search_TextChanged(object sender, EventArgs e)
        {
            str_srch = tstb_Search.Text;
            str_srchT = tstb_Search.Text;
            if (tstb_Search.Text.Length == 0 || tstb_Search.Text == " " || tstb_Search.Text == "  ")
            {
                str_srch = "$$";
                str_srchT = "$$";
            }
        }


        private void toolStripButton_Search_Click_1(object sender, EventArgs e)
        {

        }


        private void tst_Context_Click(object sender, EventArgs e)
        {
            str_srchT = "$$";

            btn_reply.Visible = true;
            ShowRec(true, true);

        }

        private void tst_title_Click(object sender, EventArgs e)
        {
            str_srch = "$$";

            btn_reply.Visible = true;
            ShowRec(true, true);
        }





    }
}
