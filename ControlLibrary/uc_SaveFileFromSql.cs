using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace ControlLibrary
{
    public partial class uc_SaveFileFromSql : UserControl
    {
        public uc_SaveFileFromSql()
        {
            InitializeComponent();
            DataGridViewButtonColumn btnAttach = new DataGridViewButtonColumn();
            btnAttach.Name = "btnSave";
            btnAttach.Text = "ذخیره";
            btnAttach.HeaderText = "ذخیره";
            btnAttach.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnAttach);
        }
        DataTable dt;
        public int x_;
        public void LoadData()
        {
            BLL.csCorrespondence cs = new BLL.csCorrespondence();
            dt = cs.SlCorrespondenceImage(x_);
            dataGridView1.DataSource = dt;
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        private void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xCorrespondence_"].Visible = false;
            dataGridView1.Columns["xFileName"].HeaderText = "نام فایل";
            dataGridView1.Columns["xFileName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (((System.Windows.Forms.DataGridView)(sender)).Columns[e.ColumnIndex].Name == "btnSave")
            {
                BLL.csCorrespondence cs = new BLL.csCorrespondence();
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter =
                     "pdf file|*.pdf";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    byte[] filebyte = null;
                    filebyte = cs.SlCorrespondenceImageFile((int)dataGridView1["x_", e.RowIndex].Value);
                    try
                    {
                        using (Stream fs = (Stream)sv.OpenFile())
                        {
                            fs.Write(filebyte, 0, filebyte.Length);
                            fs.Close();
                            //lblMsg.Content = "File successfully saved!";
                        }

                    }
                    catch (Exception ex)
                    {
                        //   this.tblError.Text = "Error calling service: " + ex.Message;
                    }
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
        }
         
    }
}
