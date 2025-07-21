using System;
using System.Windows.Forms;

namespace Payazob.FRM.RequestItService
{
    public partial class frmRequestItService : Form
    {
        public frmRequestItService(string Se)
        {
            InitializeComponent();

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = csm.SlGenGroup("ITPRB");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "نوع درخواست";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xTypeProblem_";
            combobox_Type_.Name = "cmb_TypeProblem";
            combobox_Type_.Width = 150;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Type_);


            DataGridViewComboBoxColumn combobox_Status_ = new DataGridViewComboBoxColumn();
            combobox_Status_.DataSource = csm.SlGenGroup("ITSTU");
            combobox_Status_.DisplayMember = "xName";
            combobox_Status_.HeaderText = "وضعیت در خواست";
            combobox_Status_.ValueMember = "x_";
            combobox_Status_.DataPropertyName = "xStatusProblem_";
            combobox_Status_.Name = "cmb_Status";
            combobox_Status_.Width = 150;
            combobox_Status_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Status_);

            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 4;
            combobox_xSupplier_.HeaderText = "درخواست کننده";
            combobox_xSupplier_.DataSource = new BLL.authentication().NameOfUser();
            combobox_xSupplier_.DisplayMember = "NameAndFamily";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xUser_";
            combobox_xSupplier_.Name = "cmb_xUser_";
            combobox_xSupplier_.Width = 150;
            combobox_xSupplier_.ReadOnly = true;
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xSupplier_);


            dt_R = new DAL.RequestITService.DataSet_RequestItService.mRequestItServiceDataTable();
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xUser_Column.DefaultValue = BLL.authentication.x_;
            Sec = Se;
            Generate(Sec);


        }
        string Sec;
        DAL.RequestITService.DataSet_RequestItService.mRequestItServiceDataTable dt_R;

        void Generate(string section)
        {
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            if (section == "User")
            {
                dataGridView1.Columns["xSolution"].ReadOnly = true;
                dataGridView1.Columns["xDateSolution"].ReadOnly = true;
                dataGridView1.Columns["cmb_Status"].ReadOnly = true;
                dataGridView1.Columns["xApprove"].Visible = false;
                dataGridView1.AllowUserToDeleteRows = false;
                
            }
            dataGridView1.Columns["xDate"].ReadOnly = true;

            dataGridView1.Columns["xDescribeProblem"].HeaderText = "شرح درخواست";
            dataGridView1.Columns["xSolution"].HeaderText = "شرح اقدامات";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ درخواست";
            dataGridView1.Columns["xApprove"].HeaderText = "تایید اتمام";
            dataGridView1.Columns["cmb_xUser_"].HeaderText = "نام کاربر";


            dataGridView1.Columns["xDescribeProblem"].Width = 500;
            dataGridView1.Columns["xSolution"].Width =500;
            dataGridView1.Columns["xDateSolution"].HeaderText = "تاریخ اتمام ";

            dataGridView1.Columns["xDate"].Visible = true;
            dataGridView1.Columns["x_"].Visible = false;
            //dataGridView1.Columns["xUser_"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            

        }

        void ShowDataGridView()
        {
            int x_ = -1;
            if (Sec == "User")
                x_ = BLL.authentication.x_;
            BLL.RequestItService.csRequestItService cs = new BLL.RequestItService.csRequestItService();
            dt_R = cs.RequestItService(uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateTo,x_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            dt_R.xApproveColumn.DefaultValue = false;
            dt_R.xUser_Column.DefaultValue = BLL.authentication.x_;
            Generate(Sec);
        }

        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                 BLL.RequestItService.csRequestItService cs = new BLL.RequestItService.csRequestItService();

                
               MessageBox.Show(  cs.UdRequestITService(dt_R) ,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ShowDataGridView();
                Generate(Sec);

                if (BLL.authentication.x_ != 51)
                    new BLL.Message.csMessage().SendMessage(BLL.authentication.x_, "درخواست خدمات IT", "شما یک دردرخواست در مورد خدمات IT دارید", BLL.csshamsidate.shamsidate, 51,false);


               // new BLL.Message.csMessage().SendMessage(5, "درخواست خدمات IT", "شما یک دردرخواست در مورد خدمات IT دارید", BLL.csshamsidate.shamsidate, BLL.authentication.x_);
            }
        }

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xApprove")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xDateSolution", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xDateSolution", e.RowIndex].Value = DBNull.Value;

                }

            }
        }

       
    }
}
