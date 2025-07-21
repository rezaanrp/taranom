using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmCorrespondence : Form
    {
        public frmCorrespondence()
        {
            InitializeComponent();

            fillform();

        }
        void fillform()
        {
            //BLL.csCorrespondence co = new BLL.csCorrespondence();
            //uc_cmbSerialNumber.DataSource = co.SelectCorrespondenceInputNotResponce();
            //uc_cmbSerialNumber.DisplayMember = "xSerialNumber";
            //uc_cmbSerialNumber.ValueMember = "x_";
            //uc_cmbSerialNumber.SelectedIndex = -1;

            //BLL.csCompony com = new BLL.csCompony();
            //uc_cmbCompony.DataSource = com.SelectCompony();
            //uc_cmbCompony.DisplayMember = "xComponyName";
            //uc_cmbCompony.ValueMember = "x_";
            //uc_cmbCompony.SelectedIndex = -1;

            //uc_componyOutput.DataSource = com.SelectCompony();
            //uc_componyOutput.DisplayMember = "xComponyName";
            //uc_componyOutput.ValueMember = "x_";
            //uc_componyOutput.SelectedIndex = -1;

            //uc_cmb_SerialNumberRefrence.DataSource = co.SelectCorrespondenceOutputNotResponce();
            //uc_cmb_SerialNumberRefrence.DisplayMember = "xSerialNumber";
            //uc_cmb_SerialNumberRefrence.ValueMember = "x_";
            //uc_cmb_SerialNumberRefrence.SelectedIndex = -1;

            //BLL.User us = new BLL.User();
            //uc_cmb_user.DataSource = us.selectname();
            //uc_cmb_user.DisplayMember = "name";
            //uc_cmb_user.ValueMember = "x_";
            //uc_cmb_user.SelectedIndex = -1;
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog dlgOpen = new OpenFileDialog();

                dlgOpen.Filter =

                   "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";

                dlgOpen.Title = "انتخاب تصوير";

                if (dlgOpen.ShowDialog() == DialogResult.OK)

                    pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                lst_image.Items.Add(dlgOpen.FileName);

            }

            catch (SystemException ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            while (lst_image.SelectedItems.Count > 0)
            {
                lst_image.Items.Remove(lst_image.SelectedItem);
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void ClearTextBoxes()
        {
            //Action<Control.ControlCollection> func = null;

            //func = (controls) =>
            //{
            //    foreach (Control control in controls)
            //        if (control is TextBox)
            //            (control as TextBox).Clear();
            //        else
            //            func(control.Controls);
            //};

            //func(Controls);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //List<byte[]> bt = new List<byte[]>();
            //foreach (var item in lst_image.Items)
            //{
            //    bt.Add(imageToByteArray(Image.FromFile(item.ToString())));
            //}
            
            //if (tabControl1.SelectedTab.Name == "tbInput")
            //{
            //    int responce = (uc_cmb_SerialNumberRefrence.SelectedValue == null ? -1 : (int)uc_cmb_SerialNumberRefrence.SelectedValue);

            //    int Compony = (uc_cmbCompony.SelectedValue == null ? -1 : (int)uc_cmbCompony.SelectedValue);
            //    BLL.csCorrespondence cr = new BLL.csCorrespondence();
            //    cr.InsertCorrespondenceInput(uc_mtxtDate.Text, Compony, uc_txtSubject.Text, uc_txtTo.Text, uc_txtComment.Text,
            //        uc_txtSerialNumber.Text, bt, responce);
            //    MessageBox.Show("ارسال با موفقیت انجام شد");
            //}
            //if (tabControl1.SelectedTab.Name == "tbOutput")
            //{

            //    int responce = (uc_cmbSerialNumber.SelectedValue == null ? -1 : (int)uc_cmbSerialNumber.SelectedValue);

            //    int user = (uc_cmb_user.SelectedValue == null ? -1 : (int)uc_cmb_user.SelectedValue);
            //    int Compony = (uc_componyOutput.SelectedValue == null ? -1 : (int)uc_componyOutput.SelectedValue);

            //    BLL.csCorrespondence cr = new BLL.csCorrespondence();
            //    cr.InsertCorrespondenceOutput(uc_mtxtDateOutput.Text, user, Compony,
            //        uc_txtSubjectOutput.Text, uc_txtToOutput.Text, uc_txtComment.Text, uc_SerialNumberOutput.Text, bt, responce);
            //    MessageBox.Show("ارسال با موفقیت انجام شد");
                
            //}
            //ClearTextBoxes();

            //fillform();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            FlowLayoutPanel panel = new FlowLayoutPanel();
            Form form = new Form();
            form.Size = pictureBox1.Image.Size;
            panel.Dock = DockStyle.Fill;
            form.Controls.Add(panel);
            PictureBox pb = new PictureBox();
            pb.Image = pictureBox1.Image;
            pb.Size = pictureBox1.Image.Size;
            panel.Controls.Add(pb);
            //this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            form.ShowDialog();
        }



        
    }
}
