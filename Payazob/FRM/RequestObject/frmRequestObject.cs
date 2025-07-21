using System;
using System.Windows.Forms;

namespace Payazob.FRM.RequestObject
{
    public partial class frmRequestObject : Form
    {
        public frmRequestObject(string Section)
        {
            
            InitializeComponent();
            Sec = Section;

            if (Sec == "NET")
            {

            }
            else if (Sec == "WR")
            {

            }

            dt_R = new DAL.RequestObject.DataSet_RequestObject.SlRequestObjectDataTable();
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            Generate();



            //-----------------------------------
        }


        string Sec = "";
        DAL.RequestObject.DataSet_RequestObject.SlRequestObjectDataTable dt_R;

        void ShowDate()
        {
            dt_R = new BLL.RequestObject.csRequestObject().mRequestObject(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            Generate();



        }
        void Generate()
        {
            dataGridView1.Columns["xObject_"].HeaderText = "کد قطعه";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ ثبت";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xLocation"].HeaderText = "کد مکان";
            dataGridView1.Columns["xSupplier_"].HeaderText = "نام ثبت کننده";
            dataGridView1.Columns["xWareHouse"].HeaderText = "تحویل قطعه";
            dataGridView1.Columns["xWareHouse_"].HeaderText = "نام انبار دار";
            dataGridView1.Columns["xDateWareHouse"].HeaderText = "تاریخ تحویل";
            dataGridView1.Columns["xNet_"].HeaderText = "نام تایید کننده";
            dataGridView1.Columns["xNet"].HeaderText = "تایید قطعه";
            dataGridView1.Columns["xSerialSG"].HeaderText = "کد در همکاران سیستم";
            dataGridView1.Columns["ObjectName"].HeaderText = "نام قطعه";

            dataGridView1.Columns["xCount"].DisplayIndex = 1;

            dataGridView1.Columns["xObject_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xWareHouse_"].Visible = false;
            dataGridView1.Columns["xNet_"].Visible = false;


            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.ReadOnly = true;
            }

            if (Sec == "USR")
            {
             //   dataGridView1.Columns["xObject_"].ReadOnly = false;
                dataGridView1.Columns["xCount"].ReadOnly = false;
             //   dataGridView1.Columns["xLocation"].ReadOnly = false;

                dataGridView1.Columns["x_"].Visible = false;
               // dataGridView1.Columns["xObject_"].Visible = false;

            }
            else if (Sec == "NET")
            {
           //     dataGridView1.Columns["xObject_"].ReadOnly = false;
                dataGridView1.Columns["xCount"].ReadOnly = true;
                dataGridView1.Columns["xLocation"].ReadOnly = true;
                dataGridView1.Columns["xNet_"].ReadOnly = true;
                dataGridView1.Columns["xNet"].ReadOnly = false;
                dataGridView1.Columns["xWareHouse"].ReadOnly = false;
                dataGridView1.Columns["btn_CodeLocation"].Visible = false;
                

                dataGridView1.Columns["x_"].Visible = false;


            }
            else if (Sec == "WR")
            {
                dataGridView1.Columns["xWareHouse"].ReadOnly = false;
                dataGridView1.Columns["btn_CodeLocation"].Visible = false;
                dataGridView1.Columns["x_"].Visible = false;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["xNet"].Value != DBNull.Value && (bool?)item.Cells["xNet"].Value == true)
                    {
                        item.Cells["xWareHouse"].ReadOnly = true;
                    }
                    else
                        item.Cells["xWareHouse"].ReadOnly = false;

                }
            }

        }
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowDate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            MessageBox.Show(new BLL.RequestObject.csRequestObject().UdRequestObject(dt_R));
            ShowDate();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        
        }

        private void btn_CodeLocation_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1   && dataGridView1.Columns[e.ColumnIndex].Name == "btn_CodeLocation")
            {

                //PAYAZOBNET.form.frmcodingobjects f = new PAYAZOBNET.form.frmcodingobjects();
                Payazob.FRM.MaterialLocation.frmMaterialLocation f = new Payazob.FRM.MaterialLocation.frmMaterialLocation();
                f.ShowDialog();
                if (f._CodeLocation != "" && f._ObjectCode != -1)
                {
                    dataGridView1["xLocation", e.RowIndex].Value = f._CodeLocation;
                    dataGridView1["xObject_", e.RowIndex].Value = f._ObjectCode;
                    dataGridView1["ObjectName", e.RowIndex].Value = f._ObjectName;
                    dataGridView1["xSerialSG", e.RowIndex].Value = f._ObjectSGCode;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xWareHouse"].Index)
                if ((bool)dataGridView1["xWareHouse", e.RowIndex].Value == true)
                {
                    dataGridView1["xWareHouse_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xDateWareHouse", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xWareHouse_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xDateWareHouse", e.RowIndex].Value = DBNull.Value; 
                }
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xNet"].Index)
                if ((bool)dataGridView1["xNet", e.RowIndex].Value == true)
                {
                    dataGridView1["xNet_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xNet_", e.RowIndex].Value = DBNull.Value;


        }
    }
}
