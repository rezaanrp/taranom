using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.DeliveryWareHouse
{
    public partial class frmDeliveryWareHouse : Form
    {
        public frmDeliveryWareHouse(CS.csEnum.Factory FCT)
        {
            InitializeComponent();
            fct_ = FCT;
            dt_D = new DAL.DeliveryWareHose.DataSet_DeliveryWareHouse.SlDeliveryWareHouseDataTable();
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xDateDeliveryColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xGenFactory_Column.DefaultValue = fct_;


            BLL.GenGroup.csGenGroup csmg = new BLL.GenGroup.csGenGroup();

            DataGridViewComboBoxColumn combobox_TRP_ = new DataGridViewComboBoxColumn();
            combobox_TRP_.DataSource = csmg.SlGenGroup("SDElYWH");
            combobox_TRP_.DisplayMember = "xName";
            combobox_TRP_.HeaderText = "وضعیت قطعه ";
            combobox_TRP_.ValueMember = "x_";
            combobox_TRP_.DataPropertyName = "xStatus_";
            combobox_TRP_.Name = "cmb_xStatus_";
            combobox_TRP_.Width = 100;
            combobox_TRP_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_TRP_);


            uc_DataGridViewBtn1.ColumnsFilter_ = "NameAndFamily";
            uc_DataGridViewBtn1.Ds = new BLL.authentication().NameOfUser();

            uc_DataGridViewBtn1.ParamName = new string[] { "NameAndFamily" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام پرسنل" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_" };

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;

            Generate();
        }
        CS.csEnum.Factory fct_;

        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xSendTo_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
               // dataGridView1["xSendTo", uc_DataGridViewBtn1.RI].Value = Display;
            }
        }


        DAL.DeliveryWareHose.DataSet_DeliveryWareHouse.SlDeliveryWareHouseDataTable dt_D;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            BLL.DeliveryWareHouse.csDeliveryWareHouse cs = new BLL.DeliveryWareHouse.csDeliveryWareHouse();
            dt_D = cs.SlDeliveryWareHouse(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo,(int)fct_);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xDateDeliveryColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xGenFactory_Column.DefaultValue = fct_;
            
        }
        void SaveData()
        {
            this.Validate();
            dataGridView1.EndEdit();

            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.DeliveryWareHouse.csDeliveryWareHouse cs = new BLL.DeliveryWareHouse.csDeliveryWareHouse();
                MessageBox.Show(cs.UdDeliveryWareHouse(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                Generate();
                // new BLL.Message.csMessage().SendMessage(5, "درخواست خدمات IT", "شما یک دردرخواست در مورد خدمات IT دارید", BLL.csshamsidate.shamsidate, BLL.authentication.x_);
            }
        }
        void Generate()
        {
            //dataGridView1.Columns["xDateDelivery"].HeaderText = "";
            dataGridView1.Columns["xCompanyName"].HeaderText = "نام شرکت";
            dataGridView1.Columns["xSpecifications"].HeaderText = "خلاصه قطعه";
            dataGridView1.Columns["xStatus_"].HeaderText = "وضعیت";
            dataGridView1.Columns["xTime"].HeaderText = "زمان درج";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ درج";
            dataGridView1.Columns["xSendTo_"].HeaderText = "کد گیرنده ";
            dataGridView1.Columns["xSendTo"].HeaderText = " نام گیرنده ";
            dataGridView1.Columns["xVisit"].Visible = false;
            dataGridView1.Columns["xSupplier"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xComment"].Width = 250;
            dataGridView1.Columns["DateRead"].HeaderText = "تاریخ خواندن پیام";

            dataGridView1.Columns["xStatus_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            //dataGridView1.Columns["xTime"].Visible = false;
            //dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xDate"].ReadOnly = true;
            dataGridView1.Columns["xTime"].ReadOnly = true;
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xSendTo_")
            {
                uc_DataGridViewBtn1.Visible = true;
                var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y);
                uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                uc_DataGridViewBtn1.RI = e.RowIndex;
                uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }

            else
                uc_DataGridViewBtn1.Visible = false;
        }


        private void frmDeliveryWareHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(dataGridView1.IsCurrentCellInEditMode)
                 if( dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
                 else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')                     
                        dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;  

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));

        }



    }
}
