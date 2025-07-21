using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Pieces
{
    public partial class frmPiecesList : Form
    {
        public frmPiecesList(CS.csEnum.Factory FCT)
        {
            InitializeComponent();
            fct_ = FCT;
        }
        DataTable dt_P;
        CS.csEnum.Factory fct_;
        private void frmPiecesList_Load(object sender, EventArgs e)
        {
            ShowDataGridView();
        }
        void ShowDataGridView()
        {
            BLL.csPieces cs = new BLL.csPieces();
            dt_P = cs.SlPiecesList("",TARANOM.Properties.Settings.Default.WorkYear);
            dataGridView1.DataSource = dt_P;
            bindingSource1.DataSource = dt_P;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void Generate()
        {
            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["xPieceweight"].HeaderText = "وزن قطعه";
            dataGridView1.Columns["xKbythtotal"].HeaderText = "تعداد کویته";
            dataGridView1.Columns["xSolutionweight"].HeaderText = "وزن راهگاه";
            dataGridView1.Columns["Efficiency"].HeaderText = "بازده";
            dataGridView1.Columns["MeltingWeight"].HeaderText = "وزن ذوب هر قالب";
            dataGridView1.Columns["xSpeedMolding"].HeaderText = "سرعت قالب گیری ";
            dataGridView1.Columns["xConsumption"].HeaderText = "مورد مصرف";
            dataGridView1.Columns["xNumberPerUnit"].HeaderText = "ضریب مصرف";
            dataGridView1.Columns["xCode"].HeaderText = "کد محصول";
            dataGridView1.Columns["xLastModifiedWeight"].HeaderText = "وزن قبلی";
            dataGridView1.Columns["xLastModifiedDate"].HeaderText = "تاریخ آخرین ویرایش";
            dataGridView1.Columns["xType"].HeaderText = "نوع";
            dataGridView1.Columns["WeightInMold"].HeaderText = "وزن قطعه در قالب";
          //  dataGridView1.Columns["SpeedMoldingCalc"].Visible = false;
            dataGridView1.Columns["DefectPercent"].HeaderText = "درصد ضایعات";
            dataGridView1.Columns["x_"].HeaderText = "کد در سیستم";
            dataGridView1.Columns["xMuscleName"].HeaderText = "نام ماهیچه";
            dataGridView1.Columns["xMuscleWeight"].HeaderText = "وزن ماهیچه";
            dataGridView1.Columns["xMusclekhoury"].HeaderText = "ماهیچه خوری؟";
            dataGridView1.Columns["xMuscleType_"].HeaderText = "نوع ماهیچه";
            dataGridView1.Columns["xGenProductionMethod_"].HeaderText = "روش تولید";
            




        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
                if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
                    label1.Text = dataGridView1["xName", e.RowIndex].Value.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();

            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(new BLL.csPieces().SelectPiecesByName(toolStripTextBoxName.Text,(int)fct_), "crsPieces");
            r.ShowDialog();
            r.Dispose();
        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxName_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Selected = false;
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                foreach (DataGridViewCell itemCell in item.Cells)
                {

                    if (
                        itemCell.Visible == true && itemCell.Value != DBNull.Value && itemCell.Value != null &&
                        (itemCell.FormattedValue.ToString().Contains(toolStripTextBoxName.Text) ||
                         itemCell.FormattedValue.ToString().Contains(toolStripTextBoxName.Text.Replace('ی', 'ي')) ||
                          itemCell.FormattedValue.ToString().Contains(toolStripTextBoxName.Text.Replace('ي', 'ی')) ||
                           itemCell.FormattedValue.ToString().Contains(toolStripTextBoxName.Text.Replace('ک', 'ك')) ||
                            itemCell.FormattedValue.ToString().Contains(toolStripTextBoxName.Text.Replace('ك', 'ک')))
                        )
                    {
                        item.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = item.Index > 1 ? item.Index - 2 : item.Index;
                        return;
                    }


                }
            }
        }
 
    }
}
