using System;
using System.Windows.Forms;

namespace Payazob.FRM.Tools
{
    public partial class frmToolsReturn : Form
    {
        public frmToolsReturn(CS.csEnum.TypeUser typeUser)
        {
            InitializeComponent();
            tyusr = typeUser;

            if (tyusr == CS.csEnum.TypeUser.Boos || tyusr == CS.csEnum.TypeUser.Manager)
            {
                rdb_ToWareHouse.Visible = false;
                rdb_ToPerson.Visible = false;
            }

            BLL.GenGroup.csGenGroup csmg = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_CDPRC_ = new DataGridViewComboBoxColumn();
            combobox_CDPRC_.DataSource = csmg.SlGenGroup("TOLSRTRNST");
            combobox_CDPRC_.DisplayMember = "xName";
            combobox_CDPRC_.HeaderText = "وضعیت";
            combobox_CDPRC_.ValueMember = "x_";
            combobox_CDPRC_.DataPropertyName = "xGenStatus_";
            combobox_CDPRC_.Name = "xGenStatus_";
            combobox_CDPRC_.Width = 100;
            combobox_CDPRC_.ReadOnly = true;
            combobox_CDPRC_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_CDPRC_);

            BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
            DataGridViewComboBoxColumn combobox_Per_ = new DataGridViewComboBoxColumn();
            combobox_Per_.DataSource = csp.mPersonInfoBySec(-1);
            combobox_Per_.DisplayMember = "Name";
            combobox_Per_.HeaderText = "";
            combobox_Per_.ValueMember = "x_";
            combobox_Per_.DataPropertyName = "xPerson_";
            combobox_Per_.Name = "xPerson_";
            combobox_Per_.Width = 150;
            combobox_Per_.MaxDropDownItems = 30;
            combobox_Per_.ReadOnly = true;

            combobox_Per_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView2.Columns.Add(combobox_Per_);

            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "اسم ابزار";
            combobox_xMaterialType_.DataSource = new BLL.csMaterial().SlMaterial("#", (int)CS.csEnum.MaterilaType.abzar);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            combobox_xMaterialType_.Name = "xMaterial_";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xMaterialType_);

        }
        int User_ = -1;
        string PerID_;
        CS.csEnum.TypeUser tyusr = CS.csEnum.TypeUser.User;
        int xToolsDelivery_ = -1;
        DAL.Tools.DataSet_Tools.SlToolsDeliveryODataTable dt_T;
        DAL.Tools.DataSet_Tools.SlToolsReturnDataTable dt_R;

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

           // lbl_Comment.Text = uc.ResultCustomValue;

            User_ = int.Parse(uc.ResultID);
            PerID_ = uc.ResultName;
            uc.Dispose();
            frm.Dispose();
            if (User_ == -1)
            {
                this.Close();
            }
        }

        int LoadFormSearchUser()
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

            // lbl_Comment.Text = uc.ResultCustomValue;

           return int.Parse(uc.ResultID);
           
        }

        void ShowDataGridView()
        {

            dt_T = new BLL.Tools.csTools().ToolsDelivery(User_);
            bindingSource1.DataSource = dt_T;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            //dt_T.xPerson_Column.DefaultValue = User_;
            //dt_T.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            GenerateD();
        }

        void GenerateD()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xPerson_"].Visible = false;
            dataGridView1.Columns["xDeliveryConfirm"].HeaderText = "تاییدیه تحوبل";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xSupplier_"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["DeliveryConfirmName"].HeaderText = "تایید کننده";


            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xDeliveryConfirm_"].Visible = false;



            dataGridView1.Columns["x_"].Visible = false;

        }

        void ShowDataGridViewR(int x_)
        {
            int gn_ = -1;

            if (rdb_Retiring.Checked == true)
                gn_ = 113;
            else if (rdb_ToPerson.Checked == true)
                gn_ = 114;
            else if (rdb_ToWareHouse.Checked == true)
                gn_ = 115;
            else if (rdb_Other.Checked == true)
                gn_ = 116;
            else
                return;

            dt_R = new BLL.Tools.csTools().ToolsReturn(x_,gn_);
            bindingSource2.DataSource = dt_R;
            dataGridView2.DataSource = bindingSource2;
            uc_bindingNavigator2.BindingSource = bindingSource2;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xToolsDelivery_Column.DefaultValue = x_;
            dt_R.xGenGroup_Column.DefaultValue = gn_;
            GenerateR(gn_);

        }

        void GenerateR(int gn)
        {
            dataGridView2.Columns["xDate"].HeaderText = "تاریخ"; 
            dataGridView2.Columns["xReturnDate"].HeaderText = "تاریخ برگشت";
            dataGridView2.Columns["xCount"].HeaderText = "تعداد"; 
            dataGridView2.Columns["xToolsDelivery_"].HeaderText = ""; 
            dataGridView2.Columns["xMan"].HeaderText = "تایید مدیر"; 
            dataGridView2.Columns["xPerson_"].HeaderText = "تحویل گیرنده"; 
            dataGridView2.Columns["xWareHouse"].HeaderText = "تایید انبار"; 
            dataGridView2.Columns["xBoss"].HeaderText = "تایید مدیر کارخانه"; 
            dataGridView2.Columns["xSupplier_"].HeaderText = "ثبت کننده"; 
            dataGridView2.Columns["xComment"].HeaderText = "توضیحات";

            dataGridView2.Columns["x_"].Visible = false;

            dataGridView2.Columns["xGenGroup_"].Visible = false;
            dataGridView2.Columns["xDate"].Visible = false;
            dataGridView2.Columns["xReturnDate"].Visible = false;
            dataGridView2.Columns["xCount"].Visible = false;
            dataGridView2.Columns["xToolsDelivery_"].Visible = false;
            dataGridView2.Columns["xMan"].Visible = false;
            dataGridView2.Columns["xMan_"].Visible = false;
            dataGridView2.Columns["xPerson_"].Visible = false;
            dataGridView2.Columns["xWareHouse"].Visible = false;
            dataGridView2.Columns["xBoss"].Visible = false;
            dataGridView2.Columns["xBoss_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xComment"].Visible = false;


            /// اسقاط
            if (gn == 113)
            {
                if (tyusr == CS.csEnum.TypeUser.Warehose)
                {
                    dataGridView2.Columns["xDate"].Visible = true;
                    dataGridView2.Columns["xReturnDate"].Visible = true;
                    dataGridView2.Columns["xCount"].Visible = true;
                    //  dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].Visible = true;
                    //  dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].Visible = true;
                    //  dataGridView2.Columns["xBoss"].Visible = true;
                    //  dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].Visible = true;

                    dataGridView2.Columns["xDate"].ReadOnly = true;
                    dataGridView2.Columns["xReturnDate"].ReadOnly = false;
                    dataGridView2.Columns["xCount"].ReadOnly = true;
                    //  dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].ReadOnly = true;
                    //  dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].ReadOnly = false;
                    //  dataGridView2.Columns["xBoss"].Visible = true;
                    //  dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].ReadOnly = true;
                }
                else if (tyusr == CS.csEnum.TypeUser.Manager)
                {
                    dataGridView2.Columns["xDate"].Visible = true;
                    dataGridView2.Columns["xReturnDate"].Visible = true;
                    dataGridView2.Columns["xCount"].Visible = true;
                    //  dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].Visible = true;
                    //  dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].Visible = true;
                    //  dataGridView2.Columns["xBoss"].Visible = true;
                    //  dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].Visible = true;

                    dataGridView2.Columns["xDate"].ReadOnly = false;
                    dataGridView2.Columns["xReturnDate"].ReadOnly = true;
                    dataGridView2.Columns["xCount"].ReadOnly = false;
                    //  dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].ReadOnly = false;
                    //  dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].ReadOnly = true;
                    //  dataGridView2.Columns["xBoss"].Visible = true;
                    //  dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].ReadOnly = false;
                }

            }
            ///تحویل به فرد
            else if (gn == 114)
            {
                dataGridView2.Columns["xDate"].Visible = true;
                dataGridView2.Columns["xReturnDate"].Visible = true;
                dataGridView2.Columns["xCount"].Visible = true;
                dataGridView2.Columns["xToolsDelivery_"].Visible = true;
             //   dataGridView2.Columns["xMan"].Visible = true;
                dataGridView2.Columns["xPerson_"].Visible = true;
                dataGridView2.Columns["xWareHouse"].Visible = true;
            //    dataGridView2.Columns["xBoss"].Visible = true;
            //    dataGridView2.Columns["xSupplier_"].Visible = true;
                dataGridView2.Columns["xComment"].Visible = true;
            }
            ///تحویل به انبار
            else if (gn == 115)
            {
                dataGridView2.Columns["xDate"].Visible = true;
                dataGridView2.Columns["xReturnDate"].Visible = true;
                dataGridView2.Columns["xCount"].Visible = true;
              //  dataGridView2.Columns["xToolsDelivery_"].Visible = true;
             //   dataGridView2.Columns["xMan"].Visible = true;
              //  dataGridView2.Columns["xPerson_"].Visible = true;
                dataGridView2.Columns["xWareHouse"].Visible = true;
              //  dataGridView2.Columns["xBoss"].Visible = true;
            //    dataGridView2.Columns["xSupplier_"].Visible = true;
                dataGridView2.Columns["xComment"].Visible = true;
            }
            ///سایر
            else if (gn == 116)
            {
                if (tyusr == CS.csEnum.TypeUser.Manager)
                {
                    dataGridView2.Columns["xDate"].Visible = true;
                    dataGridView2.Columns["xReturnDate"].Visible = true;
                    dataGridView2.Columns["xCount"].Visible = true;
                    //      dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].Visible = true;
                    dataGridView2.Columns["xMan_"].Visible = false;
                    //     dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].Visible = true;
                    dataGridView2.Columns["xBoss"].Visible = true;
                    dataGridView2.Columns["xBoss_"].Visible = false;
                    //     dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].Visible = true;


                    dataGridView2.Columns["xDate"].ReadOnly = false;
                    dataGridView2.Columns["xReturnDate"].ReadOnly = true;
                    dataGridView2.Columns["xCount"].ReadOnly = false;
                    //      dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].ReadOnly = false;
                    dataGridView2.Columns["xMan_"].ReadOnly = true;
                    //     dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].ReadOnly = true;
                    dataGridView2.Columns["xBoss"].ReadOnly = true;
                    dataGridView2.Columns["xBoss_"].ReadOnly = true;
                    //     dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].ReadOnly = true;


                }
                else if (tyusr == CS.csEnum.TypeUser.Boos)
                {
                    dataGridView2.Columns["xDate"].Visible = true;
                    dataGridView2.Columns["xReturnDate"].Visible = true;
                    dataGridView2.Columns["xCount"].Visible = true;
                    //      dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].Visible = true;
                    dataGridView2.Columns["xMan_"].Visible = false;
                    //     dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].Visible = true;
                    dataGridView2.Columns["xBoss"].Visible = true;
                    dataGridView2.Columns["xBoss_"].Visible = false;
                    //     dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].Visible = true;


                    dataGridView2.Columns["xDate"].ReadOnly = true;
                    dataGridView2.Columns["xReturnDate"].ReadOnly = true;
                    dataGridView2.Columns["xCount"].ReadOnly = true;
                    //      dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].ReadOnly = true;
                    dataGridView2.Columns["xMan_"].ReadOnly = true;
                    //     dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].ReadOnly = true;
                    dataGridView2.Columns["xBoss"].ReadOnly = true;
                    dataGridView2.Columns["xBoss_"].ReadOnly = false;
                    //     dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].ReadOnly = true;
                }
                else if (tyusr == CS.csEnum.TypeUser.Warehose)
                {
                    dataGridView2.Columns["xDate"].Visible = true;
                    dataGridView2.Columns["xReturnDate"].Visible = true;
                    dataGridView2.Columns["xCount"].Visible = true;
                    //      dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].Visible = true;
                    dataGridView2.Columns["xMan_"].Visible = false;
                    //     dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].Visible = true;
                    dataGridView2.Columns["xBoss"].Visible = true;
                    dataGridView2.Columns["xBoss_"].Visible = false;
                    //     dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].Visible = true;


                    dataGridView2.Columns["xDate"].ReadOnly = true;
                    dataGridView2.Columns["xReturnDate"].ReadOnly = true;
                    dataGridView2.Columns["xCount"].ReadOnly = true;
                    //      dataGridView2.Columns["xToolsDelivery_"].Visible = true;
                    dataGridView2.Columns["xMan"].ReadOnly = true;
                    dataGridView2.Columns["xMan_"].ReadOnly = true;
                    //     dataGridView2.Columns["xPerson_"].Visible = true;
                    dataGridView2.Columns["xWareHouse"].ReadOnly = false;
                    dataGridView2.Columns["xBoss"].ReadOnly = true;
                    dataGridView2.Columns["xBoss_"].ReadOnly = true;
                    //     dataGridView2.Columns["xSupplier_"].Visible = true;
                    dataGridView2.Columns["xComment"].ReadOnly = true;
                }
                     
            }

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadForm();
            ShowDataGridView();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                xToolsDelivery_ = (int)dataGridView1["x_", e.RowIndex].Value;

                ShowDataGridViewR((int)dataGridView1["x_", e.RowIndex].Value);
            }
        }

        private void SavetoolStripButtonR_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            dataGridView2.EndEdit();
            
            BLL.Tools.csTools cs = new BLL.Tools.csTools();
            MessageBox.Show(cs.UdToolsReturn(dt_R));
            //MessageBox.Show(cs.InsertToolsDelivery(BLL.csshamsidate.shamsidate,-1,-1,-1,true,"انتقالی",BLL.authentication.x_));

           
            //ShowDataGridViewR();
        }

        private void rdb_Retiring_CheckedChanged(object sender, EventArgs e)
        {
            if (xToolsDelivery_ > 0)
            {
                ShowDataGridViewR(xToolsDelivery_);
            }
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns["xPerson_"].Index == e.ColumnIndex)
            {
                int x_ = LoadFormSearchUser();
                dataGridView2[e.ColumnIndex, e.RowIndex].Value = x_;
            }
            
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView2.Columns[e.ColumnIndex].Name == "xBoss")
            {
                if ((bool)dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView2["xBoss_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                {
                    dataGridView2["xBoss_", e.RowIndex].Value = DBNull.Value;
                }

            }
            else if (dataGridView2.Columns[e.ColumnIndex].Name == "xMan")
            {
                if ((bool)dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView2["xMan_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                {
                    dataGridView2["xMan_", e.RowIndex].Value = DBNull.Value;
                }

            }
        }

      
    }
}
