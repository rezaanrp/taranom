using System;
using System.Linq;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmPhoneNew : Form
    {
        public frmPhoneNew()
        {
            InitializeComponent();

        }

        public bool NewData = false;
        public bool UpdateData = false;
        public bool DeleteData = false;
        public string xName = "", xFamily = "", xPost = "", xComponyName = "", xWebSite = "", xEmail = "", xFax = "", xTel = "", xMob = "", xAddress = "";
        public int x_ = -1;
        
        private void frmPhoneNew_Load(object sender, EventArgs e)
        {
            Generate();
        }

        void Generate()
        {
             if (UpdateData || DeleteData)
            {
                uc_txtBoxName.Text = xName;
                uc_txtBoxFamily.Text = xFamily;
                uc_txtBoxPost.Text = xPost;
                uc_txtBoxCompony.Text = xComponyName;
                uc_txtBoxWebSite.Text = xWebSite;
                uc_txtBoxEmail.Text = xEmail;
                uc_txtBoxAddress.Text = xAddress;
                lbl_fax.Text = xFax;
                for (int i = 0; i < xFax.Split(',').Length; i++)
                {
                    Fax[i] = xFax.Split(',')[i];
                    
                }
                IndexFax = xFax.Split(',').Length;
                lbl_tel.Text = xTel;

                for (int i = 0; i < xTel.Split(',').Length; i++)
                     Tel[i] = xTel.Split(',')[i];

                IndexTel = xTel.Split(',').Length;
                lbl_Mob.Text = xMob;

                for (int i = 0; i < xTel.Split(',').Length; i++)
                         Mob[i] = xMob.Split(',')[i];

                IndexMob = xMob.Split(',').Length;

                BLL.csPhone cs = new BLL.csPhone();
                dataGridView1.DataSource = cs.SelectPhoneGroupName(x_);
                dataGridView1.Columns["xGroupName"].HeaderText = "نام گروه دسترسی";
                dataGridView1.Columns["DetialsGroup"].Visible = false;
                dataGridView1.Columns["x_"].Visible = false;
                DataGridViewCheckBoxColumn chb_ok = new DataGridViewCheckBoxColumn();
                chb_ok.DisplayIndex = 2;
                chb_ok.HeaderText = "تایید";
                chb_ok.Name = "chb_ok";
                dataGridView1.Columns.Add(chb_ok);
                chb_ok.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells["chb_ok"].Value =  item.Cells["DetialsGroup"].Value;
                }
            }
            else
            {
                BLL.csPhone cs = new BLL.csPhone();
                dataGridView1.DataSource = cs.SelectPhoneGroupName();
                dataGridView1.Columns["xGroupName"].HeaderText = "نام گروه دسترسی";
                dataGridView1.Columns["x_"].Visible = false;


                DataGridViewCheckBoxColumn chb_ok = new DataGridViewCheckBoxColumn();
                chb_ok.DisplayIndex = 2;
                chb_ok.HeaderText = "تایید";
                chb_ok.Name = "chb_ok";
                dataGridView1.Columns.Add(chb_ok);
                chb_ok.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        void Refreshform()
        {
            foreach (ControlLibrary.uc_txtBox item in panel1.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                item.Text = "";
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["chb_ok"].Value = false;
            }
            foreach (Label item in panel1.Controls.OfType<Label>())
            {
                item.Text = "";
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
           

                int i = 0;
                int[] gr = new int[dataGridView1.Rows.Count];
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["chb_ok"].Value != DBNull.Value)
                        if ((bool)item.Cells["chb_ok"].Value)
                        {
                            gr[i++] = (int)item.Cells["x_"].Value;
                        }
                }
                BLL.csPhone cs = new BLL.csPhone();
                if (NewData)
                {
                    if (MessageBox.Show(" ایا می خواهید این اطلاعات ذخیره شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (cs.InsertPhoneDetials(uc_txtBoxName.Text, uc_txtBoxFamily.Text, uc_txtBoxPost.Text, uc_txtBoxCompony.Text
                            , uc_txtBoxWebSite.Text, uc_txtBoxEmail.Text, lbl_fax.Text, lbl_tel.Text, lbl_Mob.Text, uc_txtBoxAddress.Text, gr))
                        {
                            MessageBox.Show("ارسال با موفقیت انجام شد.");
                            Refreshform();

                        }
                        else
                            MessageBox.Show("خطا");
                    }
                }
                else if (UpdateData)
                {
                    if (MessageBox.Show(" ایا می خواهید این اطلاعات تغییر داده شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (cs.UpdatePhoneDetials(uc_txtBoxName.Text, uc_txtBoxFamily.Text, uc_txtBoxPost.Text, uc_txtBoxCompony.Text
                             , uc_txtBoxWebSite.Text, uc_txtBoxEmail.Text, lbl_fax.Text, lbl_tel.Text, lbl_Mob.Text, uc_txtBoxAddress.Text, x_, gr))
                        { this.Close(); }
                        else
                        {
                            MessageBox.Show("خطا");
                        }
                    }
                }
                else if (DeleteData)
                {
                    if (MessageBox.Show(" ایا می خواهید این اطلاعات حذف شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       if( cs.DeletePhoneDetials(x_))
                        this.Close();
                       MessageBox.Show("خطا");
                        
                    }
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string[] Tel = new string[7];
        int IndexTel = 0;
        string[] Fax = new string[7];
        int IndexFax = 0;
        string[] Mob = new string[7];
        int IndexMob = 0;
        private void btn_AddTel_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btn_AddTel" && IndexTel < 6) 
            {
                lbl_tel.Text = "";
                Tel[IndexTel++] = uc_txtBoxTel.Text;
                for (int i = 0; i < IndexTel; i++)
                {
                    lbl_tel.Text += Tel[i] + " , ";
                }  
            }
            else if ((sender as Button).Name == "btn_AddFax" && IndexFax < 6)
            {
                lbl_fax.Text = "";
                Fax[IndexFax++] = uc_txtBoxFax.Text;
                for (int i = 0; i < IndexFax; i++)
                {
                    lbl_fax.Text += Fax[i] + " , ";
                }  
            }
            else if ((sender as Button).Name == "btn_AddMob" && IndexMob < 6)
            {
                lbl_Mob.Text = "";
                Mob[IndexMob++] = uc_txtBoxMob.Text;
                for (int i = 0; i < IndexMob; i++)
                {
                    lbl_Mob.Text += Mob[i] + " , ";
                }  
            }

        }
        private void btn_delTel_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btn_delTel" && IndexTel >0)
            {
                lbl_tel.Text = "";
                Tel[IndexTel--] = "";

                for (int i = 0; i < IndexTel; i++)
                {
                    lbl_tel.Text += Tel[i] + " , ";
                }
            }
            else if ((sender as Button).Name == "btn_delFax" && IndexFax >0)
            {
                lbl_fax.Text = "";
                Fax[IndexFax--] = "";
                for (int i = 0; i < IndexFax; i++)
                {
                    lbl_fax.Text += Fax[i] + " , ";
                }
            }
            else if ((sender as Button).Name == "btn_delMob" && IndexMob > 0)
            {
                lbl_Mob.Text = "";
                Mob[IndexMob--] = "";
                for (int i = 0; i < IndexMob; i++)
                {
                    lbl_Mob.Text += Mob[i] + " , ";
                }
            }
        }


    }
}
