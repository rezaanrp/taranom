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
    public partial class frmSandDailyReport : Form
    {
        private DataTable SandDetails = new DataTable("Sand");
        public frmSandDailyReport()
        {
            InitializeComponent();

            SandDetails.Columns.Add("SamplingTime", typeof(string));
            SandDetails.Columns.Add("MoisturePercent", typeof(decimal));
            SandDetails.Columns.Add("Permeability", typeof(int));
            SandDetails.Columns.Add("Comperssive", typeof(decimal));
            SandDetails.Columns.Add("Compactibility", typeof(int));
            bindingSource1.DataSource = SandDetails;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["SamplingTime"].HeaderText = "زمان نمونه گیری";
            dataGridView1.Columns["MoisturePercent"].HeaderText = "درصد رطوبت";
            dataGridView1.Columns["Permeability"].HeaderText = "عبور گاز";
            dataGridView1.Columns["Comperssive"].HeaderText = "استحکام فشاری";
            dataGridView1.Columns["Compactibility"].HeaderText = "تراکم پذیری";
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csPieces cp = new BLL.csPieces();

            uc_combobox_piece.DataSource = cp.mPiecesDataTable();
            uc_combobox_piece.DisplayMember = "xName";
            uc_combobox_piece.ValueMember = "x_";
            uc_combobox_piece.SelectedIndex = -1;

            BLL.csShift shift = new BLL.csShift();
            uc_cmbShift.DataSource = shift.mShiftDataTable();
            uc_cmbShift.DisplayMember = "xShiftName";
            uc_cmbShift.ValueMember = "x_";
            uc_cmbShift.SelectedIndex = -1;


            uc_cmbSuperviser.DataSource = uc_cmbShift.DataSource;

            uc_cmbSuperviser.ValueMember = "xSandOperator";
            uc_cmbSuperviser.DisplayMember = "xSandOperator";
            uc_cmbSuperviser.SelectedIndex = -1;

            uc_mtxtDate1.Text = BLL.csshamsidate.shamsidate;
        }
        private bool Fillingright()
        {
            bool flag = true;
            csCheakTextbox ch = new csCheakTextbox();

            foreach (ControlLibrary.uc_combobox cmb in splitContainer1.Panel1.Controls.OfType<ControlLibrary.uc_combobox>())
            {

                if (cmb.SelectedIndex < 0)
                {
                    flag = false;
                }
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (item.Cells[i].ValueType != typeof(string) && item.Cells[i].Value != null)
                    {

                        flag = flag & ch.IsNumber(item.Cells[i].Value.ToString());
                    }
                }

            }
            return flag;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            //if (!Fillingright())
            //{ MessageBox.Show("اطلاعات ورودی  صحیح نمی باشد."); return; }
            //BLL.csSand ins = new BLL.csSand();
            //bool flag = ins.InsertSandDailyReport((int)uc_combobox_piece.SelectedValue, (int)uc_cmbShift.SelectedValue,
            //     uc_mtxtDate1.Text, uc_txtComment.Text, SandDetails);
            //if (flag) { MessageBox.Show("ارسال با موفقیت انجام شد."); }
            //else { MessageBox.Show("ارسال ناموفق"); }
            //SandDetails.Clear();
            //uc_txtComment.Text = "";
        }
        
        private void btn_Chart_Click(object sender, EventArgs e)
        {
            frmSendReport frm = new frmSendReport();
            frm.ShowDialog();
        }

 

    }
}
