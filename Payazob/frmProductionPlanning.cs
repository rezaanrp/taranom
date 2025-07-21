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
    public partial class frmProductionPlanning : Form
    {
        public frmProductionPlanning()
        {
            InitializeComponent();
        }
        void filldatagridview(DataTable dt)
        {
            
            dataGridView1.DataSource = dt;
            dt.Columns["xSupplier"].ColumnName = "تهیه کننده";
            dt.Columns["xApprove"].ColumnName = "تایید کننده";
            dt.Columns["xRegister"].ColumnName = "تصویب کننده";
            dt.Columns["PieceName"].ColumnName = "نام قطعه";
            dt.Columns["xPieceCount"].ColumnName = "تعداد قطعه";
            dt.Columns["shiftName"].ColumnName = "نام شیفت";
            dt.Columns["xPlanningDate"].ColumnName = "تاریخ برنامه";

        }

        private void frmProductionPlanning_Load(object sender, EventArgs e)
        {
            BLL.csPieces cp = new BLL.csPieces();

            cmb_Pieces.DataSource = cp.mPiecesDataTable();
            cmb_Pieces.DisplayMember = "xName";
            cmb_Pieces.ValueMember = "x_";

            BLL.csShift shift = new BLL.csShift();
            cmb_shift.DataSource = shift.mShiftDataTable();
            cmb_shift.DisplayMember = "xShiftName";
            cmb_shift.ValueMember = "x_";

            cmb_superviser.DataSource = cmb_shift.DataSource;

            cmb_superviser.ValueMember = "xShiftSuperviser";
            cmb_superviser.DisplayMember = "xShiftSuperviser";

            BLL.csPlanning pl = new BLL.csPlanning();
            filldatagridview(pl.SelectmPlanningAndName(mtxt_datefrom.Text,mtxt_dateto.Text,checkBox1.Checked));
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xPiece_"].Visible = false;
            dataGridView1.Columns["xShift_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xRegistringGroup_"].Visible = false;
            dataGridView1.Columns["xSupplierby"].Visible = false;
            dataGridView1.Columns["xApproveby"].Visible = false;
            dataGridView1.Columns["xRegisterby"].Visible = false;
            dataGridView1.Columns["xComment"].Visible = false;
            dataGridView1.Columns["PieceKbythtotal"].Visible = false;
            dataGridView1.Columns["Pieceweight"].Visible = false;
            dataGridView1.Columns["PieceSolutionweight"].Visible = false;
            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            BLL.csPlanning pl = new BLL.csPlanning();
            filldatagridview(pl.SelectmPlanningAndName(mtxt_datefrom.Text, mtxt_dateto.Text, checkBox1.Checked));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uc_RegisteringGroup1.CheckCheakboxEnableDisable();
            int PieceCount = int.Parse(dataGridView1["تعداد قطعه", e.RowIndex].Value.ToString());
            int Pieceweight = PieceCount * int.Parse(dataGridView1["Pieceweight", e.RowIndex].Value.ToString());
            txt_comment.Text = dataGridView1["xComment", e.RowIndex].Value.ToString();
            txt_date.Text = dataGridView1["تاریخ برنامه", e.RowIndex].Value.ToString();
            cmb_Pieces.Text = dataGridView1["نام قطعه", e.RowIndex].Value.ToString();
            txt_piececount.Text = PieceCount.ToString();
            txt_Pieceweight.Text = Pieceweight.ToString() + " کیلوگرم ";
            cmb_shift.SelectedValue = dataGridView1["xShift_", e.RowIndex].Value.ToString();
            txt_Solutionweight.Text = (int.Parse(dataGridView1["PieceSolutionweight", e.RowIndex].Value.ToString()) * Pieceweight).ToString();
            txt_templatecount.Text =( PieceCount / int.Parse( dataGridView1["PieceKbythtotal", e.RowIndex].Value.ToString())).ToString();
            uc_RegisteringGroup1.supplier = (bool)dataGridView1["تهیه کننده", e.RowIndex].Value;
            uc_RegisteringGroup1.approve = (bool)dataGridView1["تایید کننده", e.RowIndex].Value;
            uc_RegisteringGroup1.register = (bool)dataGridView1["تصویب کننده", e.RowIndex].Value;
            if ((bool)dataGridView1["تهیه کننده", e.RowIndex].Value)
                uc_RegisteringGroup1.supplierEnabled = false;
            if ((bool)dataGridView1["تایید کننده", e.RowIndex].Value)
                uc_RegisteringGroup1.approveEnabled =  false;
            if ((bool)dataGridView1["تصویب کننده", e.RowIndex].Value)
                uc_RegisteringGroup1.registerEnabled =  false;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //if (BLL.authentication.UpdateData == false)
            //    return;


            //BLL.csPlanning pl = new BLL.csPlanning();
            //if (dataGridView1.SelectedRows.Count < 1)
            //    return;

            //DialogResult dialogResult;

            //if (uc_RegisteringGroup1.supplierEnabled == true)
            //{
            //    dialogResult = MessageBox.Show("آیا می خوایید این برنامه تولید تغییر داده شود؟", "اخطار", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        pl.updateplanning((int)dataGridView1.SelectedRows[0].Cells["x_"].Value, (int)cmb_Pieces.SelectedValue, int.Parse(txt_piececount.Text)
            //            , (int)cmb_shift.SelectedValue, txt_date.Text, txt_comment.Text);
            //        pl.UpdatePlanningRegisteringGroup((int)dataGridView1.SelectedRows[0].Cells["x_"].Value,
            //                uc_RegisteringGroup1.supplier, uc_RegisteringGroup1.approve, uc_RegisteringGroup1.register);
            //        btn_show_Click(null, null);
            //    }
            //        return;
            //}
            //if (uc_RegisteringGroup1.checkedchange == false)
            //    return;
            //dialogResult = MessageBox.Show("آیا می خواهید این برنامه تولید تایید شود؟", "اخطار", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //   pl.UpdatePlanningRegisteringGroup((int)dataGridView1.SelectedRows[0].Cells["x_"].Value,
            //   uc_RegisteringGroup1.supplier, uc_RegisteringGroup1.approve, uc_RegisteringGroup1.register);
            //}
        }

    }
}
