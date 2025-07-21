using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmCorrespondenceList : Form
    {
        public frmCorrespondenceList()
        {
            InitializeComponent();
            DataGridViewButtonColumn btnAttach = new DataGridViewButtonColumn();
            btnAttach.Name = "btnAttach";
            btnAttach.Text = "Attach";
            btnAttach.HeaderText = "پیوست";
            btnAttach.Visible = false;
            btnAttach.UseColumnTextForButtonValue = true; 
            dataGridView1.Columns.Add(btnAttach);
            
            uc_Filter_Date1.DateFrom = "1391/01/01";
            uc_Filter_Date1.DateTo = "1393/01/01";
            DataGridViewButtonColumn btnSave = new DataGridViewButtonColumn();
            btnSave.Name = "btnSave";
            btnSave.Text = "ذخیره";
            btnSave.HeaderText = "ذخیره";
            btnSave.Visible = false;
            btnSave.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnSave);


            BLL.csCompony cs_Supplier = new BLL.csCompony();
            DataGridViewComboBoxColumn combobox_Supplier_ = new DataGridViewComboBoxColumn();
            combobox_Supplier_.HeaderText = "نام تامین کننده";
            combobox_Supplier_.DataSource = cs_Supplier.SelectCustomer();
            combobox_Supplier_.DisplayMember = "xComponyName";
            combobox_Supplier_.ValueMember = "x_";
            combobox_Supplier_.DataPropertyName = "xCompony_";
            combobox_Supplier_.Name = "xCompony_";
            combobox_Supplier_.Visible = false;
            dataGridView1.Columns.Add(combobox_Supplier_);
        }
        DAL.DataSet_Correspondence.SlCorrespondenceDataTable dt_Cr;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDatagridView();
        }

        private void ShowDatagridView()
        {
            BLL.csCorrespondence cs = new BLL.csCorrespondence();
            dt_Cr = cs.SlCorrespondence(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
           // dt_Cr.Columns["xSupplier_"].DefaultValue = BLL.authentication.x_;
            dataGridView1.DataSource = dt_Cr;
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator_D.BindingSource = bindingSource1;
            Generate();

        }
        public void SaveFile()
        {

            try
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                dlgOpen.Filter =
                   "pdf file|*.pdf";
                dlgOpen.Title = "انتخاب تصوير";
                if (dlgOpen.ShowDialog() == DialogResult.OK)

                {
                    byte[] filebyte = null;
                    filebyte = System.IO.File.ReadAllBytes(dlgOpen.FileName);
                }
               
            }

            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void Generate()
        {
            this.dataGridView1.Columns["xRefrence"].HeaderText = "عطف به نامه";
            this.dataGridView1.Columns["xSerialNumber"].HeaderText = "شماره نامه";
            this.dataGridView1.Columns["xInputDate"].HeaderText = "تاریخ";
            this.dataGridView1.Columns["xLetterDate"].HeaderText = "تاریخ نامه";
            this.dataGridView1.Columns["xCompony_"].HeaderText = "شرکت";
            this.dataGridView1.Columns["xSubject"].HeaderText = "موضوع";
            this.dataGridView1.Columns["xTo"].HeaderText = "به ";
            this.dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            this.dataGridView1.Columns["xSupplier_"].HeaderText = "";
            this.dataGridView1.Columns["xGroup_"].HeaderText = "";

            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xSupplier_"].Visible = false;
            this.dataGridView1.Columns["xGroup_"].Visible = false;

            this.dataGridView1.Columns["xCompony_"].Visible = true;
            this.dataGridView1.Columns["btnAttach"].Visible = true;
            this.dataGridView1.Columns["btnSave"].Visible = true;

            this.dataGridView1.Columns["xCompony_"].DisplayIndex = 5;
            this.dataGridView1.Columns["btnAttach"].DisplayIndex = 10;
            this.dataGridView1.Columns["btnSave"].DisplayIndex = 11;



        }

        private void toolStripButton_D_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView1.EndEdit();
            BLL.csCorrespondence cs = new BLL.csCorrespondence();
            cs.UdCorrespondence(dt_Cr);
            ShowDatagridView();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (((System.Windows.Forms.DataGridView)(sender)).Columns[e.ColumnIndex].Name == "btnAttach")
            {
                ControlLibrary.uc_LoadFile uc = new ControlLibrary.uc_LoadFile();
                Form dl = new Form();
                uc.Idendity_ = (int)dataGridView1["x_", e.RowIndex].Value; 
                dl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow ;
                dl.Font = new System.Drawing.Font("Tahoma", 8.25F);
                dl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dl.Size = new System.Drawing.Size(uc.Size.Width + 20 , uc.Size.Height + 40);
                dl.Controls.Add(uc);
                dl.ShowDialog();
            }


            if (((System.Windows.Forms.DataGridView)(sender)).Columns[e.ColumnIndex].Name == "btnSave")
            {
                ControlLibrary.uc_SaveFileFromSql uc = new ControlLibrary.uc_SaveFileFromSql();
                uc.x_ = (int)dataGridView1["x_", e.RowIndex].Value;
                uc.LoadData();
                Form dl = new Form();
                dl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                dl.Font = new System.Drawing.Font("Tahoma", 8.25F);
                dl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dl.Size = new System.Drawing.Size(uc.Size.Width + 20, uc.Size.Height + 40);
                dl.Controls.Add(uc);
                dl.ShowDialog();
            }

        }
    }
}
