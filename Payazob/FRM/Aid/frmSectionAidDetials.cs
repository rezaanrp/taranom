using System;
using System.Windows.Forms;

namespace Payazob.FRM.Aid
{
    public partial class frmSectionAidDetials : Form
    {
        public frmSectionAidDetials()
        {
            InitializeComponent();

            BLL.csMaterial csm = new BLL.csMaterial();
            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = csm.SlMaterial("$",(int) CS.csEnum.MaterilaType.lavazememeni);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            combobox_xMaterialType_.Name = "cmb_Material";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.MaxDropDownItems = 30;
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView2.Columns.Add(combobox_xMaterialType_);

            BLL.GenGroup.csGenGroup csg = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = csg.SlGenGroup("SEC");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "واحد";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGenGroup_";
            combobox_Type_.Name = "cmb_SectionAid";
            combobox_Type_.Width = 150;
            combobox_Type_.MaxDropDownItems = 30;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Type_);


            BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
            DataGridViewComboBoxColumn combobox_Per_ = new DataGridViewComboBoxColumn();
            combobox_Per_.DataSource = csp.mPersonInfoBySec(-1);
            combobox_Per_.DisplayMember = "Name";
            combobox_Per_.HeaderText = "نام و نام خانوادگی";
            combobox_Per_.ValueMember = "x_";
            combobox_Per_.DataPropertyName = "xPerson_";
            combobox_Per_.Name = "cmb_Person";
            combobox_Per_.Width = 150;
            combobox_Per_.MaxDropDownItems = 30;

            combobox_Per_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView3.Columns.Add(combobox_Per_);


        }
        DAL.Aid.DataSet_Aid.mSectionAidDataTable dt_A;
        DAL.Aid.DataSet_Aid.mSectionAidMaterialDataTable dt_A_M;
        DAL.Aid.DataSet_Aid.mSectionAidPersonDataTable dt_A_P;
        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xName"].HeaderText = " قسمت";
            dataGridView1.Columns["xName"].Width = 300;
        }
        void Generate_M()
        {
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSectionAid_"].Visible = false;
            dataGridView2.Columns["xPeriod"].HeaderText = " مدت استفاده- روز";
            dataGridView2.Columns["xPeriod"].Width = 200;
        }
        void Generate_P()
        {
            dataGridView3.Columns["x_"].Visible = false;
            dataGridView3.Columns["xSectionAid_"].Visible = false;
            //dataGridView2.Columns["xPeriod"].HeaderText = " مدت استفاده- روز";
            //dataGridView2.Columns["xPeriod"].Width = 200;
        }
        void Show_Data()
        {
            BLL.Aid.csAid cs = new BLL.Aid.csAid();
            dt_A = cs.SectionAid();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

        }

        private void frmSectionAidDetials_Load(object sender, EventArgs e)
        {
            Show_Data();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   MessageBox.Show(new BLL.Aid.csAid().UdSectionAid(dt_A));
   Show_Data();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BLL.Aid.csAid cs = new BLL.Aid.csAid();

            dt_A_M = cs.SectionAidMaterial((int?)dataGridView1["x_", e.RowIndex].Value);
            bindingSource2.DataSource = dt_A_M;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            dt_A_M.xSectionAid_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;
            Generate_M();


            dt_A_P = cs.SectionAidPerson((int?)dataGridView1["x_", e.RowIndex].Value);
            bindingSource3.DataSource = dt_A_P;
            dataGridView3.DataSource = bindingSource3;
            bindingNavigator3.BindingSource = bindingSource3;
            dt_A_P.xSectionAid_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;


            Generate_P();


        }

        private void SavetoolStripButton_m_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   MessageBox.Show(new BLL.Aid.csAid().UdSectionAidMaterial(dt_A_M));
   Show_Data();
            }
        }

        private void toolStripButton_SaveA_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView3.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   MessageBox.Show(new BLL.Aid.csAid().UdSectionAidPerson(dt_A_P));
   Show_Data();
            }
        }

        private void dataGridView3_Enter(object sender, EventArgs e)
        {
          
            BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
            int? sec_ = -1; 
            if(dataGridView1.SelectedRows.Count  > 0  )
            sec_ = (int?)dataGridView1.SelectedRows[0].Cells["cmb_SectionAid"].Value;
            (dataGridView3.Columns["cmb_Person"] as DataGridViewComboBoxColumn).DataSource = csp.mPersonInfoBySec(sec_);
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
            (dataGridView3.Columns["cmb_Person"] as DataGridViewComboBoxColumn).DataSource = csp.mPersonInfoBySec(-1);
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            if(e.Exception.Message.Contains("DataGridViewComboBoxCell") )
            {
       MessageBox.Show("اطلاعات پرسنل با واحد هماهنگی ندارد لطفا اصلاح شود");
   BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
       int? sec_ = -1;
   if (dataGridView1.SelectedRows.Count > 0)
       sec_ = (int?)dataGridView1.SelectedRows[0].Cells["cmb_SectionAid"].Value;
     (dataGridView3.Columns["cmb_Person"] as DataGridViewComboBoxColumn).DataSource = csp.mPersonInfoBySec(-1);
            }

          // this.Close();
            //bindingSource3.DataSource = dt_A_P = null;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            BLL.Aid.csAid cs = new BLL.Aid.csAid();
            //DAL.Aid.DataSet_Aid.SlSectionAidSearchDataTable dt = cs.SlSectionAidSearch(50);
            //string st = "";
            //foreach (DataRow item in dt.Rows)
            //{
            //    st += item["xName"].ToString() + "        " + item["xMaterial"].ToString() + "\n";
            //}
            //MessageBox.Show(st);


            FRM.Aid.frmSectionAidSearch frm = new frmSectionAidSearch();
            frm.SetParam("mSectionAidx_", false);
            frm.SetParam("SectionAidPersonx_", false);
            frm.SetParam("SectionAidMaterialx_", false);
            frm.MyDatatable = cs.SlSectionAidSearch(User_);

            frm.ShowDialog();
        }
        int User_ = -1;
        private void btn_Person_Click(object sender, EventArgs e)
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

            txt_PerName.Text = uc.ResultCustomValue;

            User_ = int.Parse(uc.ResultID);
            uc.Dispose();
            frm.Dispose();
            if (User_ == -1)
            {
   this.Close();
            }
        }
    }
}
