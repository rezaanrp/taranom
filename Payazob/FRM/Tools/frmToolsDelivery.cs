using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Tools
{
    public partial class frmToolsDelivery : Form
    {
        CS.csEnum.TypeUser typUsr = CS.csEnum.TypeUser.User;
        public frmToolsDelivery(CS.csEnum.TypeUser typ)
        {
            InitializeComponent();
            typUsr = typ;
            BLL.GenGroup.csGenGroup csmg = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_CDPRC_ = new DataGridViewComboBoxColumn();
            combobox_CDPRC_.DataSource = csmg.SlGenGroup("TOLSRTRNST");
            combobox_CDPRC_.DisplayMember = "xName";
            combobox_CDPRC_.HeaderText = "وضعیت";
            combobox_CDPRC_.ValueMember = "x_";
            combobox_CDPRC_.DataPropertyName = "xGenStatus_";
            combobox_CDPRC_.Name = "xGenStatus_";
            combobox_CDPRC_.Width = 100;
            combobox_CDPRC_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_CDPRC_);


            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "اسم ابزار";
            combobox_xMaterialType_.DataSource = new BLL.csMaterial().SlMaterial("#",(int)CS.csEnum.MaterilaType.abzar);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            combobox_xMaterialType_.Name = "xMaterial_";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xMaterialType_);


            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 4;
            combobox_xSupplier_.HeaderText = "تحویل گیرنده";
            combobox_xSupplier_.DataSource =  new BLL.Person.csPersonInfo().mPersonInfoSec(-1);
            combobox_xSupplier_.DisplayMember = "PerName";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xPerson_";
            combobox_xSupplier_.Name = "xPerson_";
            combobox_xSupplier_.Width = 150;
            combobox_xSupplier_.ReadOnly = true;
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xSupplier_);



            ShowDataGridView();

            dataGridView1.AllowUserToAddRows = false;
            toolStripButton_Add.Enabled = false;
        }
        int User_ = -1;
        string PerID_;
        DAL.Tools.DataSet_Tools.SlToolsDeliveryODataTable dt_T;
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

            dataGridView1.AllowUserToAddRows = true;
            toolStripButton_Add.Enabled = true;
            dt_T = new BLL.Tools.csTools().ToolsDelivery(User_);
            bindingSource1.DataSource = dt_T;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_T.xPerson_Column.DefaultValue = User_;
            dt_T.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_T.xGenStatus_Column.DefaultValue = 118;
            Generate();

            
        }
        void Generate()
        {

            if (dataGridView1.Columns.Count < 1)
                return;
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            //dataGridView1.Columns["xMaterial_"].HeaderText = "";
           // dataGridView1.Columns["xPerson_"].Visible = false;
            dataGridView1.Columns["xDeliveryConfirm"].HeaderText = "تاییدیه تحوبل";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xSupplier_"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["DeliveryConfirmName"].HeaderText = "تایید کننده";
            

            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xDeliveryConfirm_"].Visible = false;

            dataGridView1.Columns["xGenStatus_"].ReadOnly = true;
            dataGridView1.Columns["xDeliveryConfirm"].ReadOnly = true;
          //  dataGridView1.Columns["xDeliveryConfirm_"].ReadOnly = true;
          //  dataGridView1.Columns["xDeliveryConfirm_"].Visible = false;

            dataGridView1.Columns["x_"].Visible = false;

            if (typUsr == CS.csEnum.TypeUser.Manager)
            {
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    item.ReadOnly = true;
                }
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                toolStripButton_Delete.Enabled = false;
                toolStripButton_Add.Enabled = false;
                dataGridView1.Columns["xDeliveryConfirm"].ReadOnly = false;
            }

            if (typUsr == CS.csEnum.TypeUser.User)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["xDeliveryConfirm"].Value != DBNull.Value 
                        && (bool?)item.Cells["xDeliveryConfirm"].Value == true)
                    {
                        item.ReadOnly = true;
                    }
                }

            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.Tools.csTools cs = new BLL.Tools.csTools();
            MessageBox.Show(cs.UdToolsDelivery(dt_T));
            ShowDataGridView();

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new BLL.Tools.csTools().SlToolsDelivery( User_);

            foreach (DataGridViewRow item1 in dataGridView1.Rows)
            {
                if (dataGridView1.SelectedRows.Count < 1)
                    break;

                if (!item1.Selected)
                {

                    foreach (DataRow item2 in dt.Rows)
                    {
                        if ((int?)item1.Cells["x_"].Value == (int?)item2["x_"])
                        {
                            item2.Delete();
                            break;
                        }
                    }
                }
                dt.AcceptChanges();
            }


            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt, "crsToolsDelivery");
            r.ShowDialog();
            r.Dispose();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDeliveryConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xDeliveryConfirm_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                {
                    dataGridView1["xDeliveryConfirm_", e.RowIndex].Value = DBNull.Value;
                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

    }
}
