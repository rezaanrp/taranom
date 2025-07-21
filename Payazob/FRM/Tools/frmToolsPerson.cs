using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Tools
{
    public partial class frmToolsPerson : Form
    {
        public frmToolsPerson()
        {
            InitializeComponent();
        }

        int User_ = -1;
        string PerID_;
        DAL.Tools.DataSet_Tools.SlToolsPersonDataTable dt_T;
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

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.Controls.Add(uc);
            frm.Size = uc.Size;
            frm.Height += 30;
            frm.Width += 30;
            frm.StartPosition = FormStartPosition.CenterParent;

            uc.Dock = DockStyle.Fill;
            frm.ShowDialog();

            lbl_Comment.Text = uc.ResultCustomValue;

            User_ = int.Parse(uc.ResultID);
            PerID_ = uc.ResultName;
            uc.Dispose();
            frm.Dispose();
            if (User_ == -1)
            {
                this.Close();
            }
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            LoadForm();
            ShowDataGridView();
        }

        void ShowDataGridView()
        {


            dt_T = new BLL.Tools.csTools().SlToolsPerson(User_);
            bindingSource1.DataSource = dt_T;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();


        }
        void Generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_T.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();

            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_T, "crsToolsPerson");
            r.ShowDialog();
            r.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
