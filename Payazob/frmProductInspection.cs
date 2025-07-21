using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmProductInspection : Form
    {
        public frmProductInspection()
        {
            InitializeComponent();
            
        }

        private void frmProductInspection_Load(object sender, EventArgs e)
        {
            BLL.csPieces cp = new BLL.csPieces();

            uc_cmbAuto_Pieces.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            uc_cmbAuto_Pieces.DisplayMember = "xName";
            uc_cmbAuto_Pieces.ValueMember = "x_";
            uc_cmbAuto_Pieces.SelectedIndex = -1;

            BLL.csShift shift = new BLL.csShift();
            uc_cmbAuto_shift.DataSource = shift.mShiftDataTable();
            uc_cmbAuto_shift.DisplayMember = "xShiftName";
            uc_cmbAuto_shift.ValueMember = "x_";
            uc_cmbAuto_shift.SelectedIndex = -1;

            uc_cmbAuto_superviser.DataSource = uc_cmbAuto_shift.DataSource;

            uc_cmbAuto_superviser.ValueMember = "xShiftSuperviser";
            uc_cmbAuto_superviser.DisplayMember = "xShiftSuperviser";
            uc_cmbAuto_superviser.SelectedIndex = -1;
            mtxt_dateinspection.Text = BLL.csshamsidate.shamsidate;
            BLL.csDefect dfc = new BLL.csDefect();
            filldatagirdview(dfc.SelectDefectList());

            numericUpDown_Year.Value =int.Parse( BLL.csshamsidate.shamsidate.Substring(0,4));

        }
        private void filldatagirdview(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns.Add("dvg_DefectNumber", "مقدار ضایعات");
            this.dataGridView1.Columns["dvg_DefectNumber"].ValueType = typeof(int);
            this.dataGridView1.Columns["xDefectName"].ReadOnly = true;
            this.dataGridView1.Columns["xDefectName"].HeaderText = "نوع ضایعات";
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xDefectActive"].Visible = false;
        }
        private void RefreshForm()
        {

            foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                item.Text = "";
            }
            foreach (ControlLibrary.uc_cmbAuto item in groupBox2.Controls.OfType<ControlLibrary.uc_cmbAuto>())
            {
                item.SelectedIndex = -1;
            }
            lbl_defectNumber.Text = " مقدار ضایعات : " + " 0 ";

        }
       private bool fillRight()
        {

            foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (item.Text == "")
                {
                    MessageBox.Show("فیلد ها را به طور کامل پر کنید");
                    return false;
                }
            }

            foreach (ControlLibrary.uc_cmbAuto item in groupBox2.Controls.OfType<ControlLibrary.uc_cmbAuto>())
            {
                if( item.SelectedIndex < 0) return false;
            }
            if (sum > int.Parse(uc_txtControlNumbers.textWithoutcomma))
            {
                MessageBox.Show("مقدار ضایعات از مقدار کنترلی بیشتر است");
                return false;
            }
            if (int.Parse(uc_txt_DayOfYear.Text) > 367 || int.Parse(uc_txt_DayOfYear.Text) < 1)
            {
                uc_txt_DayOfYear.Text = "";
                return false;
            }
            return true;
        }

       private bool CheakInventory()
       {
           int inv = new BLL.csInventory().InventoryCheck( TARANOM.Properties.Settings.Default.WorkYear.Substring(0, 4) + "/01/01",
                                                            TARANOM.Properties.Settings.Default.WorkYear.Substring(0, 4) + "/12/30",
                                                            TARANOM.Properties.Settings.Default.WorkYear,
                                                            (int?)uc_cmbAuto_Pieces.SelectedValue);
           int sum = 0;
           int r = 0;
           foreach (DataGridViewRow row in this.dataGridView1.Rows)
           {
              r = 0;
               if (row.Cells["dvg_DefectNumber"].Value != null)
               {
                   if(int.TryParse(row.Cells["dvg_DefectNumber"].Value.ToString(),out r) )
                   {
                       sum += r;
                   }

               }

           }

           if (inv - sum >= 0)
               return true;
           else
               return false;
           
       }

        private void btn_send_Click(object sender, EventArgs e)
        {

            string t_d = uc_txt_DayOfYear.textWithoutcomma == null ? "0" : uc_txt_DayOfYear.textWithoutcomma;
            string xProductionDate = BLL.csshamsidate.ShamsiDateAndDayOfYear(numericUpDown_Year.Value, int.Parse(t_d));
            if (!new BLL.csshamsidate().CompareDate(BLL.csshamsidate.shamsidate, xProductionDate))
            {
                MessageBox.Show("تاریخ تولید بیشتر از تاریخ کنونی می باشد",
                   "خطا",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                return;
            }

            if (!CheakInventory())
            {
                    MessageBox.Show("مقدار موجودی در گردش منفی می شود",
		            "خطا",
		            MessageBoxButtons.OK,
		            MessageBoxIcon.Error,
		            MessageBoxDefaultButton.Button1);
                return;
            }




            this.Validate();
            dataGridView1.EndEdit();
            if(!fillRight())return;

            if (MessageBox.Show(" ایا می خواهید این اطلاعات  ارسال شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
             
            DataTable dt = new DataTable();
            dt.TableName = "MyTable";
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.Name, col.ValueType);
            }
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                if (gridRow.IsNewRow || gridRow.Cells["dvg_DefectNumber"].Value == null || int.Parse(gridRow.Cells["dvg_DefectNumber"].Value.ToString()) == 0)
                    continue;
                DataRow dtRow = dt.NewRow();
                for (int i1 = 0; i1 < dataGridView1.Columns.Count; i1++)
                {
                    dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
                }
                gridRow.Cells["dvg_DefectNumber"].Value = DBNull.Value;
                dt.Rows.Add(dtRow);
            }

            BLL.csDefect de = new BLL.csDefect();
            bool temp = true;
            if (!uc_RegisteringGroup1.approveEnabled)
                temp = uc_RegisteringGroup1.approve;
            de.InsertProductInspection((int)uc_cmbAuto_Pieces.SelectedValue, (int)numericUpDown_Year.Value, uc_txt_DayOfYear.textWithoutcomma == null ?"0":uc_txt_DayOfYear.textWithoutcomma, (int)uc_cmbAuto_shift.SelectedValue, int.Parse(uc_txtControlNumbers.textWithoutcomma == null ?"0":uc_txtControlNumbers.textWithoutcomma)
                    , BLL.csshamsidate.shamsidate, mtxt_dateinspection.Text, 2, true, temp, dt);

                RefreshForm();
                MessageBox.Show("ارسال با موفقیت انجام شد.");
            }
        }
        private int sum = 0;

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            sum = 0;
            csCheakTextbox ch = new csCheakTextbox();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells["dvg_DefectNumber"].Value == null)
                    continue;
                if (!ch.Isinteger(row.Cells["dvg_DefectNumber"].Value.ToString()))
                { row.Cells["dvg_DefectNumber"].Value = null; continue; }

                sum += int.Parse(row.Cells["dvg_DefectNumber"].Value.ToString());
            }

            lbl_defectNumber.Text = " مقدار ضایعات : " + sum.ToString();

            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null && dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() == "0")
                  dataGridView1[e.ColumnIndex, e.RowIndex].Value = null;

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }


    }
}
