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
    public partial class frmSandMaterialUsage : Form
    {
        public frmSandMaterialUsage()
        {
            InitializeComponent();
            uc_txtOtherNumber.Text = "0";
            BLL.csPieces cp = new BLL.csPieces();

            uc_cmbAuto_piece.DataSource = cp.mPiecesDataTable();
            uc_cmbAuto_piece.DisplayMember = "xName";
            uc_cmbAuto_piece.ValueMember = "x_";
            uc_cmbAuto_piece.SelectedIndex = -1;

            BLL.csShift shift = new BLL.csShift();
            uc_cmbAuto_Shift.DataSource = shift.mShiftDataTable();
            uc_cmbAuto_Shift.DisplayMember = "xShiftName";
            uc_cmbAuto_Shift.ValueMember = "x_";
            uc_cmbAuto_Shift.SelectedIndex = -1;

            uc_cmbAuto_Superviser.DataSource = uc_cmbAuto_Shift.DataSource;
            uc_cmbAuto_Superviser.ValueMember = "xShiftSuperviser";
            uc_cmbAuto_Superviser.DisplayMember = "xShiftSuperviser";
            uc_cmbAuto_Superviser.SelectedIndex = -1;
        }


        private void uc_TextBox1_Load(object sender, EventArgs e)
        {

        }
        void visibleObject()
        {
            uc_txtOther.Visible = !uc_txtOther.Visible;
            uc_txtOtherNumber.Visible = !uc_txtOtherNumber.Visible;
        }
        private void btn_Other_Click(object sender, EventArgs e)
        {
            visibleObject();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is UC.uc_TextBox)
                        (control as UC.uc_TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private bool Fillingright()
        {
            bool flag = true;
            Validation.Vuc_cmbAuto cm = new Validation.Vuc_cmbAuto();
            flag = cm.NotNullContent(panel1);
            return flag;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            foreach (UC.uc_TextBox item in grp_usagematerial.Controls.OfType<UC.uc_TextBox>())
            {
                if (item.Text == "")
                    item.Text = "0";
            }
            if (uc_txtBatchCount.Text == "")
            {
                uc_txtBatchCount.Text = "0";
            }
            if (!Fillingright())
            {
                MessageBox.Show("اطلاعات ورودی صحیح نیست");
                return;
            }
            if (MessageBox.Show(" ایا می خواهید این اطلاعات  ارسال شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BLL.csSand insert = new BLL.csSand();
                insert.SandMaterialUsage((int)uc_cmbAuto_Shift.SelectedValue, uc_mtxtDate1.Text, (int)uc_cmbAuto_piece.SelectedValue,
                    int.Parse(uc_txtbentonit.Text), int.Parse(uc_NewSand.Text), int.Parse(uc_txtCoalDust.Text), int.Parse(uc_txtWater.Text),
                    int.Parse(uc_txtBatchCount.Text), int.Parse(uc_txtSandReturn.Text), int.Parse(uc_txtOtherNumber.Text),
                          uc_txtOther.Text, uc_txtMechanical.Text, uc_txtElectric.Text, uc_txtReportOther.Text, uc_txtComment.Text);
                ClearTextBoxes();

                MessageBox.Show("ارسال با موفقیت انجام شد.");
            }
        }

        private void uc_txtBatchCount_Leave(object sender, EventArgs e)
        {

        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            foreach (UC.uc_TextBox item in grp_usagematerial.Controls.OfType<UC.uc_TextBox>())
            {
                if (item.Text == "")
                    item.Text = "0";
            }
            if (uc_txtBatchCount.Text == "" )
            {
                uc_txtBatchCount.Text = "0";
            }
            uc_txtSumBetonit.Text = (int.Parse(uc_txtBatchCount.Text) * int.Parse(uc_txtbentonit.Text)).ToString();
            uc_txtSumCoalDust.Text = (int.Parse(uc_txtBatchCount.Text) * int.Parse(uc_txtCoalDust.Text)).ToString();
            uc_txtSumSandNew.Text = (int.Parse(uc_txtBatchCount.Text) * int.Parse(uc_NewSand.Text)).ToString();
            uc_txtSumWater.Text = (int.Parse(uc_txtBatchCount.Text) * int.Parse(uc_txtWater.Text)).ToString();
            uc_txtSumOther.Text = (int.Parse(uc_txtBatchCount.Text) * int.Parse(uc_txtOtherNumber.Text)).ToString();
            uc_txtSumSandReturn.Text = (int.Parse(uc_txtBatchCount.Text) * int.Parse(uc_txtSandReturn.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
