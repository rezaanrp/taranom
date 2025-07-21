using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmPlanning : Form
    {
        public frmPlanning()
        {
            InitializeComponent();

            BLL.csPlanning pl = new BLL.csPlanning();            
            dt_Planning = pl.SelectPlanningByDate(BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate);
            
            dataGridView1.DataSource = dt_Planning;
            bindingSource1.DataSource = dt_Planning;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            DataGridViewGen();


            DataGridViewComboBoxColumn cmbShift = new DataGridViewComboBoxColumn();
            cmbShift.DisplayIndex = 0;
            cmbShift.HeaderText = "شیفت";
            dataGridView1.Columns.Add(cmbShift);
            BLL.csShift shift = new BLL.csShift();
            cmbShift.DataSource = shift.mShiftDataTable();
            cmbShift.DisplayMember = "xShiftName";
            cmbShift.ValueMember = "x_";
            cmbShift.Name = "xShifts_";
            cmbShift.DataPropertyName = "xShift_";

            BLL.csPieces cp = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_piece = new DataGridViewComboBoxColumn();
            combobox_piece.DisplayIndex = 1;
            combobox_piece.HeaderText = "نام قطعه";
            dataGridView1.Columns.Add(combobox_piece);
            combobox_piece.DataSource = cp.mPiecesDataTable();
            combobox_piece.DisplayMember = "xName";
            combobox_piece.ValueMember = "x_";
            combobox_piece.Name = "xPieces_";
            combobox_piece.DataPropertyName = "xPiece_";

            BLL.csshamsidate csh = new BLL.csshamsidate();

            toolStripTextBoxDateFrom.Text =csh.previousDay(30);
            toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;


        }

        DAL.DataSet_Planning.SelectPlanningByDateDataTable dt_Planning;
       
        private void txt_piececount_TextChanged(object sender, EventArgs e)
        {
            decimal Weight = 0;
            int Kbythtotal = 1;
            if ((cmb_Pieces).SelectedItem != null)
            {
                if ((((System.Data.DataRowView)(((System.Windows.Forms.ComboBox)(cmb_Pieces)).SelectedItem)).Row)["xPieceweight"] != DBNull.Value )
                    Weight = decimal.Parse((((System.Data.DataRowView)(((System.Windows.Forms.ComboBox)(cmb_Pieces)).SelectedItem)).Row)["xPieceweight"].ToString());
                if ((((System.Data.DataRowView)(((System.Windows.Forms.ComboBox)(cmb_Pieces)).SelectedItem)).Row)["xKbythtotal"] != DBNull.Value)
                    Kbythtotal = int.Parse((((System.Data.DataRowView)(((System.Windows.Forms.ComboBox)(cmb_Pieces)).SelectedItem)).Row)["xKbythtotal"].ToString());
            }
            txt_weight.Text = (Weight * int.Parse(txt_piececount.Text)).ToString() + " " + "کیلوگرم" + " ";
            txt_templatecount.Text = (int.Parse(txt_piececount.Text) / (Kbythtotal)).ToString();
        }

        private void frmPlanning_Load(object sender, EventArgs e)
        {
            BLL.csPieces cp = new BLL.csPieces();

            cmb_Pieces.DataSource = cp.mPiecesDataTable();
            cmb_Pieces.DisplayMember = "xName";
            cmb_Pieces.ValueMember = "x_";
            cmb_Pieces.SelectedIndex = -1;

            BLL.csShift shift = new BLL.csShift();
            cmb_shift.DataSource = shift.mShiftDataTable();
            cmb_shift.DisplayMember = "xShiftName";
            cmb_shift.ValueMember = "x_";
            cmb_shift.SelectedIndex = -1;

            cmb_superviser.DataSource = cmb_shift.DataSource;

            cmb_superviser.ValueMember = "xShiftSuperviser";
            cmb_superviser.DisplayMember = "xShiftSuperviser";
            cmb_superviser.SelectedIndex = -1;
            txt_date.Text = BLL.csshamsidate.shamsidate;

            //BLL.csRegisteringGroup re = new BLL.csRegisteringGroup();
            //DataTable dt = re.SelectRegistringGroupAndName(-1, "برنامه ریزی");
            //chb_supplierby.Text = dt.Rows[0]["xSupplierby"].ToString();
            //if (dt.Rows[0]["xSupplierby_"].ToString() == BLL.authentication.x_.ToString())
            //    chb_supplierby.Enabled = true;

            //chb_approveby.Text = dt.Rows[0]["xApproveby"].ToString();
            //if (dt.Rows[0]["xApproveby_"].ToString() == BLL.authentication.x_.ToString())
            //    chb_approveby.Enabled = true;
            //chb_registerby.Text = dt.Rows[0]["xRegisterby"].ToString();
            //if (dt.Rows[0]["xRegisterby_"].ToString() == BLL.authentication.x_.ToString())
            //    chb_registerby.Enabled = true;


        }

        private void Generate()
        {

            BLL.csPlanning pl = new BLL.csPlanning();
            dt_Planning = pl.SelectPlanningByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);

            dataGridView1.DataSource = dt_Planning;
            bindingSource1.DataSource = dt_Planning;
            uc_bindingNavigator1.BindingSource = bindingSource1;

            dataGridView1.Columns["xPieces_"].DataPropertyName = "xPiece_";
            dataGridView1.Columns["xShifts_"].DataPropertyName = "xShift_";

        }

        private void DatagridviewColumnsName(string name,string value)
        {
            dataGridView1.Columns[name].HeaderText = value;
        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {


            Generate();

            DataGridViewGen();
        }

        private void DataGridViewGen()
        {
            DatagridviewColumnsName("xPiece_", "");
            DatagridviewColumnsName("xPieceCount", "تعداد قطعه");
            DatagridviewColumnsName("xShift_", "");
            DatagridviewColumnsName("xPlanningDate", "تاریخ برنامه");
            DatagridviewColumnsName("xDate", "تاریخ");
            DatagridviewColumnsName("xSupplier", "تهیه کننده");
            DatagridviewColumnsName("xApprove", "تایید کننده");
            DatagridviewColumnsName("xRegister", "تصویب کننده");
            DatagridviewColumnsName("xComment", "توضیحات");

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xPiece_"].Visible = false;
            dataGridView1.Columns["xShift_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["xRegister_"].Visible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            CS.csMessage csM = new CS.csMessage();
            if (csM.ShowMessageSaveYesNo())
            {
                BLL.csPlanning cs = new BLL.csPlanning();
                dataGridView1.Update();
                dataGridView1.EndEdit();
                this.Validate();
                if (cs.UpdatePlanning(dt_Planning))
                    MessageBox.Show("ارسال با موفقیت انجام شد");
                else
                    MessageBox.Show("خطا در ارسال");
            }
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            AddToDatatable();
        }

        private void AddToDatatable()
        {
            if (cmb_Pieces.SelectedIndex > -1 && cmb_shift.SelectedIndex > -1 
                && cmb_superviser.SelectedIndex > -1 && txt_piececount.Text != "")
            {
                DataRow dr = dt_Planning.NewRow();
                if (cmb_Pieces.SelectedValue != null)
                    dr["xPiece_"] = cmb_Pieces.SelectedValue;
                dr["xPieceCount"] = int.Parse(txt_piececount.Text);
                if (cmb_shift.SelectedValue != null)
                    dr["xShift_"] = cmb_shift.SelectedValue;
                dr["xPlanningDate"] = txt_date.Text;
                dr["xDate"] = BLL.csshamsidate.shamsidate;
                dr["xSupplier_"] = BLL.authentication.x_;
                if (BLL.authentication.x_ == BLL.authentication.xApproveby_)
                    dr["xApprove_"] = BLL.authentication.x_;
                if (BLL.authentication.x_ == BLL.authentication.xRegisterby_)
                    dr["xRegister_"] = BLL.authentication.x_;
                dr["xComment"] = txt_comment.Text;
                dr["xSupplier"] = BLL.authentication.NameAndFamily;
              
                dt_Planning.Rows.Add(dr);

                cmb_Pieces.Text = ""; cmb_shift.Text = "";
                cmb_superviser.Text = ""; txt_piececount.Text = "";
                cmb_Pieces.SelectedIndex = -1;
            }
            else
                MessageBox.Show("فیلد ها را به طور کامل وارد کنید");



        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void cmb_Pieces_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

 
    }
}
