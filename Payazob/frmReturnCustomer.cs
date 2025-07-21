using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmReturnCustomer : Form
    {
        public frmReturnCustomer()
        {
            InitializeComponent();
        }

        private void frmReturnCustomer_Load(object sender, EventArgs e)
        {
            BLL.csCustomer cu = new BLL.csCustomer();
            uc_combobox_Customer.DataSource = cu.SelectCustomer();
            uc_combobox_Customer.DisplayMember = "xComponyname";
            uc_combobox_Customer.ValueMember = "x_";
            uc_combobox_Customer.SelectedIndex = -1;

            BLL.csPieces cp = new BLL.csPieces();

            uc_combobox_piece.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            uc_combobox_piece.DisplayMember = "xName";
            uc_combobox_piece.ValueMember = "x_";
            uc_combobox_piece.SelectedIndex = -1;

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

        private void lst_image_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(lst_image.SelectedItem.ToString());

            }
            catch (Exception)
            {
                
            }
            
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!uc_mtxtDate1.accept || uc_mtxtNumbercount.Text == "" || uc_mtxtNumberDayOfYear.Text == "" || uc_combobox_Customer.SelectedIndex < 0 || uc_combobox_piece.SelectedIndex < 0)
            {
                MessageBox.Show("خطا در ورود اطلاعات");
                return;
            }
                List<byte[]> bt = new List<byte[]>();
            foreach (var item in lst_image.Items)
            {
                bt.Add( imageToByteArray(Image.FromFile(item.ToString())) );
            }
            BLL.csReturnCustomer r = new BLL.csReturnCustomer();

            r.InsertCustomerReturn((int)uc_combobox_Customer.SelectedValue, (int)uc_combobox_piece.SelectedValue,
                uc_mtxtDate1.Text, int.Parse(uc_mtxtNumbercount.Text), uc_mtxtNumberDayOfYear.Text, txt_ResultReturn.Text, txt_Comment.Text, txt_DescriptionAgreemental.Text
                , uc_RegisteringGroup1.supplier, uc_RegisteringGroup1.approve, 3, bt);

            
           
        }


    }
}
