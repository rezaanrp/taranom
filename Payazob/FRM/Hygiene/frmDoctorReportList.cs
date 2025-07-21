using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Hygiene
{
    public partial class frmDoctorReportList : Form
    {
        public frmDoctorReportList()
        {
            InitializeComponent();
            dt_A = new DAL.Hygiene.DataSet_Hygiene.mDoctorReportByPerson_DataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        int User_ = -1;
        void LoadForm()
        {
            Form frm = new Form();
            ControlLibrary.uc_SearchData uc = new ControlLibrary.uc_SearchData();
            uc.ColumnFilter = "PerName";
            uc.DataGridViewHeaderText("PerName", "نام و نام خانوادگی");
            uc.DataGridViewHeaderText("xPerID", "شماره پرسنلی");
            uc.DataGridViewClmHide("x_");
            uc.GenDataGridView(new BLL.Person.csPersonInfo().mPersonInfoSec(-1));
            uc.ResultCustom = "PerName";
            uc.ResultCustom1 = "xPerID";
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.Controls.Add(uc);
            frm.Size = uc.Size;
            frm.Height += 30;
            frm.Width += 30;
            frm.StartPosition = FormStartPosition.CenterParent;

            uc.Dock = DockStyle.Fill;
            frm.ShowDialog();

            lbl_Header.Text = uc.ResultCustomValue;

            User_ = int.Parse(uc.ResultID);
          //  PerID_ = uc.ResultCustomValue1;
            uc.Dispose();
            frm.Dispose();
            if (User_ == -1)
            {
                this.Close();
            }
        }
        DAL.Hygiene.DataSet_Hygiene.mDoctorReportByPerson_DataTable dt_A;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadForm();
            dt_A = new BLL.Hygiene.csHygiene().mDoctorReportByPerson_(User_);
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_A.Columns)
            {
                  if( dataGridView1.Columns[dc.ColumnName] != null )

                      dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new FRM.Hygiene.frmDoctorReport().ShowDialog();
        }
    }
}
