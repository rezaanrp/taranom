using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.ManagerReport
{
    public partial class frmSalePlanForManager : Form
    {
        public frmSalePlanForManager()
        {
            InitializeComponent();

            BLL.csCustomer cs = new BLL.csCustomer();
            uc_CmbAutoByFilter1.uc_cmbAuto1.DataSource = cs.SelectCustomer();
            uc_CmbAutoByFilter1.uc_cmbAuto1.DisplayMember = "xComponyName";
            uc_CmbAutoByFilter1.uc_cmbAuto1.ValueMember = "x_";
            uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;

            uc_CmbAutoByFilter1.ParamName = new string[] { "xComponyName" };
            uc_CmbAutoByFilter1.ParamValue = new string[] { "نام شرکت" };
            uc_CmbAutoByFilter1.ParamHide = new string[] { "x_" };

            BLL.csPieces cp = new BLL.csPieces();

            uc_CmbAutoByFilterPices.uc_cmbAuto1.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site3);
            uc_CmbAutoByFilterPices.uc_cmbAuto1.DisplayMember = "xName";
            uc_CmbAutoByFilterPices.uc_cmbAuto1.ValueMember = "x_";
            uc_CmbAutoByFilterPices.uc_cmbAuto1.SelectedIndex = -1;

            uc_CmbAutoByFilterPices.ParamName = new string[] { "xName" };
            uc_CmbAutoByFilterPices.ParamValue = new string[] { "نام قطعه" };
            uc_CmbAutoByFilterPices.ParamHide = new string[] { "x_" };


        }
        private DataTable dt_S;
        void generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_S.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            dataGridView1.Columns["xDate"].Width = 70;
            dataGridView1.Columns["xPieces_"].Width = 200;
            dataGridView1.Columns["xCustomer_"].Width = 200;
            dataGridView1.Columns["xSaleType"].Width = 50;

        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            dt_S = new BLL.SalePlan.csSalePlanTurning().SlSalePlanTurningForManager(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();

            cmb_xSaleType.SelectedIndex = -1;
            uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;
            uc_CmbAutoByFilterPices.uc_cmbAuto1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sortOrder = "CompanyName ASC";
            string expression = "";
            string Condition = "";
            if (radioButton_and.Checked)
                Condition = " AND ";
            else
            {
                Condition = " OR  ";

            }
   

            //foreach (DataGridViewRow item1 in dataGridView1.Rows)
            //{
            //    foreach (DataGridViewCell itemCell in item1.Cells)
            //    {
            //        if (itemCell.Selected)
            //        {
            //          //  MessageBox.Show(itemCell.Value.ToString());
            //            columns.Add(itemCell.OwningColumn.Name + " = " + "\'" + itemCell.Value.ToString() + "\'");
            //        }
            //    }
                
            //}


            if (cmb_xSaleType.SelectedIndex > -1)
            {
                expression = "( ";
                expression += "xSaleType = " + "\'" + cmb_xSaleType.Text + "\'" + ")     ";
            }
            if (uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex > -1)
            {
                if (expression == "")
                    Condition = "";
                expression += Condition + " ( ";
                expression += "xCustomer_ = " + "\'" + uc_CmbAutoByFilter1.uc_cmbAuto1.Text + "\'" + ")     ";
            }

            if (uc_CmbAutoByFilterPices.uc_cmbAuto1.SelectedIndex > -1)
            {
                if (expression == "")
                    Condition = "";
                expression += Condition + " ( ";
                expression += "xPieces_ = " + "\'" + uc_CmbAutoByFilterPices.uc_cmbAuto1.Text + "\'" + ")     ";
            }

            //foreach (string item in columns)
            //{
            //    expression += item + Condition;
            //}


        //    expression=  expression.Remove(expression.Length - 5);

            if (expression != "" && dt_S != null)
            {

                DataRow[] dr = dt_S.Select(expression);
                DataTable dt1;
                if (dr.Length > 0)
                    dt1 = dr.CopyToDataTable();
                else
                    dt1 = new DataTable();


                bindingSource1.DataSource = dt1;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new ControlLibrary.uc_ExportExcelFile { Fildvg = dataGridView1 }.RunExcel();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }

    }
}
