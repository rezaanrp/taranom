using System;
using System.Linq;
using System.Windows.Forms;

namespace Payazob.FRM.AnalysisFurnace
{
    public partial class frmAnalyzeFurnaceRange : Form
    {
        public frmAnalyzeFurnaceRange()
        {
            InitializeComponent();
            dt_N = new BLL.AnalyzeFurnace.csAnalyzeFurnace().SlAnalyzeFurnaceRangeDataTable();
            bindingSource1.DataSource = dt_N;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn();
            combobox_PiecesLine1_.HeaderText = "نام قطعه";
            combobox_PiecesLine1_.DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_PiecesLine1_.DisplayMember = "xName";
            combobox_PiecesLine1_.ValueMember = "x_";
            combobox_PiecesLine1_.DataPropertyName = "xPicese_";
            combobox_PiecesLine1_.Name = "cmb_xPicese_";
            combobox_PiecesLine1_.Visible = true;
            dataGridView1.Columns.Add(combobox_PiecesLine1_);

            Generate();
        }
        void Generate()
        {
            //cmb_xPicese_
            dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه";
            dataGridView1.Columns["xPicese_"].Visible = false;
            dataGridView1.Columns["Pieces"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["cmb_xPicese_"].DisplayIndex = 1;

        }
        DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceRangeDataTable dt_N;
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   this.dataGridView1.EndEdit();
   this.Validate();
   BLL.AnalyzeFurnace.csAnalyzeFurnace cs = new BLL.AnalyzeFurnace.csAnalyzeFurnace();
   MessageBox.Show(cs.UdAnalyzeFurnaceRange(dt_N));
   dt_N = cs.SlAnalyzeFurnaceRangeDataTable();
   bindingSource1.DataSource = dt_N;
   dataGridView1.DataSource = bindingSource1;
   bindingNavigator1.BindingSource = bindingSource1;
   //Generate();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
   if (item.DataBindings.Count > 0)
       item.DataBindings.RemoveAt(0);
            }
            foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
   if (item.DataBindings.Count > 0)
       item.DataBindings.RemoveAt(0);
            }
            foreach (ControlLibrary.uc_txtBox item in groupBox3.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
   if (item.DataBindings.Count > 0)
       item.DataBindings.RemoveAt(0);
            }
            foreach (ControlLibrary.uc_txtBox item in groupBox4.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
   if (item.DataBindings.Count > 0)
       item.DataBindings.RemoveAt(0);
            }
            foreach (ControlLibrary.uc_txtBox item in groupBox5.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
   if (item.DataBindings.Count > 0)
       item.DataBindings.RemoveAt(0);
            } foreach (ControlLibrary.uc_txtBox item in groupBox6.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
   if (item.DataBindings.Count > 0)
       item.DataBindings.RemoveAt(0);
            }
            if (uc_TextBoxDate1.DataBindings.Count > 0)
   uc_TextBoxDate1.DataBindings.RemoveAt(0);

            uc_TextBoxDate1.DataBindings.Add(new Binding("Text", dataGridView1["xDate", e.RowIndex], "Value"));

            uc_txtBox_xAlMax.DataBindings.Add(new Binding("Text", dataGridView1["xAlMax", e.RowIndex], "Value"));
            uc_txtBox_xAlMin.DataBindings.Add(new Binding("Text", dataGridView1["xAlMin", e.RowIndex], "Value"));
            uc_txtBox_xCeMax.DataBindings.Add(new Binding("Text", dataGridView1["xCeMax", e.RowIndex], "Value"));
            uc_txtBox_xCeMin.DataBindings.Add(new Binding("Text", dataGridView1["xCeMin", e.RowIndex], "Value"));
            uc_txtBox_xcMax.DataBindings.Add(new Binding("Text", dataGridView1["xcMax", e.RowIndex], "Value"));
            uc_txtBox_xcMin.DataBindings.Add(new Binding("Text", dataGridView1["xcMin", e.RowIndex], "Value"));
            uc_txtBox_xCuMax.DataBindings.Add(new Binding("Text", dataGridView1["xCuMax", e.RowIndex], "Value"));
            uc_txtBox_xCuMin.DataBindings.Add(new Binding("Text", dataGridView1["xCuMin", e.RowIndex], "Value"));
            uc_txtBox_xMnMax.DataBindings.Add(new Binding("Text", dataGridView1["xMnMax", e.RowIndex], "Value"));
            uc_txtBox_xMnMin.DataBindings.Add(new Binding("Text", dataGridView1["xMnMin", e.RowIndex], "Value"));
            uc_txtBox_xSiMax.DataBindings.Add(new Binding("Text", dataGridView1["xSiMax", e.RowIndex], "Value"));
            uc_txtBox_xSiMin.DataBindings.Add(new Binding("Text", dataGridView1["xSiMin", e.RowIndex], "Value"));
        }

 
    }
}
