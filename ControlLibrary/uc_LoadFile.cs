using System;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_LoadFile : UserControl
    {
        public uc_LoadFile()
        {
            InitializeComponent();
        }
        public int Idendity_;
        public byte[] filebyte;
         
        private void btn_Select_Click(object sender, EventArgs e)
        {
            try
                {
                    OpenFileDialog dlgOpen = new OpenFileDialog();
                    dlgOpen.Filter =
                       "pdf file|*.pdf";
                    dlgOpen.Title = "انتخاب تصوير";
                    if (dlgOpen.ShowDialog() == DialogResult.OK)
                    {
         //               filebyte = null;
         //               filebyte = System.IO.File.ReadAllBytes(dlgOpen.FileName);
         //               System.IO.FileInfo fi = new System.IO.FileInfo(dlgOpen.FileName);
                     lst_image.Items.Add(dlgOpen.FileName);
                    }
                }

            catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            /*
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
             */
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            while (lst_image.SelectedItems.Count > 0)
            {
                lst_image.Items.Remove(lst_image.SelectedItem);
            }
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            BLL.csCorrespondence cs = new BLL.csCorrespondence();
            for (int i = 0; i < lst_image.Items.Count; i++)
            {
                filebyte = null;
                filebyte = System.IO.File.ReadAllBytes(lst_image.Items[i].ToString());
                System.IO.FileInfo fi = new System.IO.FileInfo(lst_image.Items[i].ToString());
                cs.InCorrespondenceImage(filebyte, Idendity_, fi.Name); 
            }

            this.ParentForm.Close();
        }
    }
}
