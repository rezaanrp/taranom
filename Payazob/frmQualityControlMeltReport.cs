using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmQualityControlMeltReport : Form
    {
        private DataTable dt_Melt = new DataTable("MeltReport");

        public frmQualityControlMeltReport()
        {
            InitializeComponent();
            generateForm();
        }
        private bool show = false;
        private void generateForm()
        {
            dt_Melt.Columns.Add("xTime", typeof(string));
            dt_Melt.Columns.Add("xStandard", typeof(string));
            dt_Melt.Columns.Add("xLadel", typeof(string));
            dt_Melt.Columns.Add("xDayNumber", typeof(decimal));
            dt_Melt.Columns.Add("Year", typeof(decimal));
            dt_Melt.Columns.Add("Fe", typeof(decimal));
            dt_Melt.Columns.Add("C", typeof(decimal));
            dt_Melt.Columns.Add("Si", typeof(decimal));
            dt_Melt.Columns.Add("Mn", typeof(decimal));
            dt_Melt.Columns.Add("P", typeof(decimal));
            dt_Melt.Columns.Add("S", typeof(decimal));
            dt_Melt.Columns.Add("Cr", typeof(decimal));
            dt_Melt.Columns.Add("Mo", typeof(decimal));
            dt_Melt.Columns.Add("Ni", typeof(decimal));
            dt_Melt.Columns.Add("Al", typeof(decimal));
            dt_Melt.Columns.Add("Co", typeof(decimal));
            dt_Melt.Columns.Add("Cu", typeof(decimal));
            dt_Melt.Columns.Add("Mg", typeof(decimal));
            dt_Melt.Columns.Add("Nb", typeof(decimal));
            dt_Melt.Columns.Add("Ti", typeof(decimal));
            dt_Melt.Columns.Add("V", typeof(decimal));
            dt_Melt.Columns.Add("Sn", typeof(decimal));
            dt_Melt.Columns.Add("B", typeof(decimal));
            dt_Melt.Columns.Add("Zr", typeof(decimal));
            dt_Melt.Columns.Add("As", typeof(decimal));
            dt_Melt.Columns.Add("Ce", typeof(decimal));
            bindingSource1.DataSource = dt_Melt;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["xTime"].HeaderText = "زمان";
            dataGridView1.Columns["Year"].HeaderText = "سال روز شمار";
            dataGridView1.Columns["xDayNumber"].HeaderText = "روز شمار";
            dataGridView1.Columns["xStandard"].HeaderText = "استاندارد";
            dataGridView1.Columns["xLadel"].HeaderText = "شماره پاتیل";


            DataGridViewComboBoxColumn xFernesNumber = new DataGridViewComboBoxColumn();
            xFernesNumber.HeaderText = "شماره کوره";
            xFernesNumber.DisplayIndex = 2;
            xFernesNumber.Items.Add("1");
            xFernesNumber.Items.Add("2");
            xFernesNumber.Items.Add("3");
            xFernesNumber.Items.Add("4");
            xFernesNumber.Name = "xFernesNumber";
            xFernesNumber.ValueType = typeof(string);
            dataGridView1.Columns.Add(xFernesNumber);

            BLL.csPieces cp = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_piece = new DataGridViewComboBoxColumn();
            combobox_piece.DisplayIndex = 1;
            combobox_piece.HeaderText = "نام قطعه";
            dataGridView1.Columns.Add(combobox_piece);
            combobox_piece.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_piece.DisplayMember = "xName";
            combobox_piece.ValueMember = "x_";
            combobox_piece.Name = "xPiceces_";
            combobox_piece.ValueType = typeof(int);

            DataGridViewComboBoxColumn cmbShift = new DataGridViewComboBoxColumn();
            cmbShift.DisplayIndex = 0;
            cmbShift.HeaderText = "شیفت";
            dataGridView1.Columns.Add(cmbShift);
            BLL.csShift shift = new BLL.csShift();
            cmbShift.DataSource = shift.mShiftDataTable();
            cmbShift.DisplayMember = "xShiftName";
            cmbShift.ValueMember = "x_";
            cmbShift.Name = "xShift_";
            cmbShift.ValueType = typeof(int);

            bindingNavigator1.BindingSource = bindingSource1;
            toolStripTextBoxDateFrom.Text = BLL.csshamsidate.shamsidate;
            toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (show)
                return;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!item.IsNewRow)
                    foreach (DataGridViewCell t in item.Cells)
                    {
                        if (t is DataGridViewComboBoxCell)
                            if (t.Value == null)
                            {
                                MessageBox.Show("اطلاعات ورودی صحیح نمی باشد");
                                return;
                            }
                    }
            }
            BLL.csQualityControl cs = new BLL.csQualityControl();


            DataTable dt = new DataTable();
            dt.TableName = "MyTable";
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.Name, col.ValueType);
            }
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                if (gridRow.IsNewRow)
                    continue;
                DataRow dtRow = dt.NewRow();
                for (int i1 = 0; i1 < dataGridView1.Columns.Count; i1++)
                {
                    if (gridRow.Cells[i1].ValueType == typeof(int) || gridRow.Cells[i1].ValueType == typeof(decimal))
                        dtRow[i1] = (gridRow.Cells[i1].Value == DBNull.Value ? 0 : gridRow.Cells[i1].Value);
                    else if (gridRow.Cells[i1].ValueType == typeof(string))
                        dtRow[i1] = (gridRow.Cells[i1].Value == DBNull.Value ? "" : gridRow.Cells[i1].Value);
                    else
                        dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);

                }

                dt.Rows.Add(dtRow);
            }
            cs.InsertMeltReport(dt);
            dt_Melt.Clear();
            MessageBox.Show("ارسال با موفقیت انجام شد.");

        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {
            show = true;
            dataGridView1.Columns.Clear();
            BLL.csQualityControl cs1 = new BLL.csQualityControl();
            DataTable dt = cs1.SelectMeltReportByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;


        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            show = false;
            dataGridView1.Columns.Clear();
            dt_Melt.Columns.Clear();
            generateForm();
        }


    }
}
