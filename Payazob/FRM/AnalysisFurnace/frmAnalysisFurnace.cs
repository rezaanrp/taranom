using System;
using System.Windows.Forms;

namespace Payazob.FRM.AnalysisFurnace
{
    public partial class frmAnalysisFurnace : Form
    {
        public frmAnalysisFurnace()
        {
            InitializeComponent();
            dt_A = new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();
        }
        DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable dt_A;
        void generate()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xPieces"].HeaderText = "نامه قطعه";
            dataGridView1.Columns["xPieces_"].Visible  = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xfe"].HeaderText = "fe";
            dataGridView1.Columns["xC"].HeaderText = "C";
            dataGridView1.Columns["xSi"].HeaderText = "Si";
            dataGridView1.Columns["xMn"].HeaderText = "Mn";
            dataGridView1.Columns["xP"].HeaderText = "P";
            dataGridView1.Columns["xS"].HeaderText = "S";
            dataGridView1.Columns["xCr"].HeaderText = "Cr";
            dataGridView1.Columns["xMo"].HeaderText = "Mo";
            dataGridView1.Columns["xNi"].HeaderText = "Ni";
            dataGridView1.Columns["xAl"].HeaderText = "Al";
            dataGridView1.Columns["xCo"].HeaderText = "Co";
            dataGridView1.Columns["xCu"].HeaderText = "Cu";
            dataGridView1.Columns["xMg"].HeaderText = "Mg";
            dataGridView1.Columns["xNb"].HeaderText = "Nb";
            dataGridView1.Columns["xTi"].HeaderText = "Ti";
            dataGridView1.Columns["xV"].HeaderText = "V";
            dataGridView1.Columns["xSn"].HeaderText = "Sn";
            dataGridView1.Columns["xB"].HeaderText = "B";
            dataGridView1.Columns["xZr"].HeaderText = "Zr";
            dataGridView1.Columns["xAs"].HeaderText = "As";
            dataGridView1.Columns["xCe"].HeaderText = "Ce";
            dataGridView1.Columns["xSupplier"].HeaderText = "تهیه کننده";
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FRM.AnalysisFurnace.frmAnalysisFurnaceImport frm = new FRM.AnalysisFurnace.frmAnalysisFurnaceImport();
            frm.ShowDialog();
            ShowData();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           if(new CS.csMessage().ShowMessageSaveYesNo())
           {
            // dt_A = new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable();
            BLL.AnalyzeFurnace.csAnalyzeFurnace cs = new BLL.AnalyzeFurnace.csAnalyzeFurnace();
            MessageBox.Show(  cs.UdAnalyzeFurnace(dt_A),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ShowData();
           }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }
        void ShowData()
        {
            BLL.AnalyzeFurnace.csAnalyzeFurnace cs = new BLL.AnalyzeFurnace.csAnalyzeFurnace();
            dt_A = cs.SlAnalyzeFurnaceDataTable(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
