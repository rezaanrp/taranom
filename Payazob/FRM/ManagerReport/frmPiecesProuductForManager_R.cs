using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.ManagerReport
{
    public partial class frmPiecesProuductForManager_R : Form
    {
        public frmPiecesProuductForManager_R()
        {
            InitializeComponent();

            
            uc_CmbAutoByFilter1.uc_cmbAuto1.DataSource = dt_S;
            uc_CmbAutoByFilter1.uc_cmbAuto1.DisplayMember = filter1;
            uc_CmbAutoByFilter1.uc_cmbAuto1.ValueMember = filter1;
            uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;

            uc_CmbAutoByFilter1.ParamName = new string[] { filter1 };
            uc_CmbAutoByFilter1.ParamValue = new string[] { filterName1 };
          //  uc_CmbAutoByFilter1.ParamHide = new string[] { "x_" };



            uc_CmbAutoByFilter2.uc_cmbAuto1.DataSource = dt_S;
            uc_CmbAutoByFilter2.uc_cmbAuto1.DisplayMember =filter2;
            uc_CmbAutoByFilter2.uc_cmbAuto1.ValueMember = filter2;
            uc_CmbAutoByFilter2.uc_cmbAuto1.SelectedIndex = -1;

            uc_CmbAutoByFilter2.ParamName = new string[] { filter2 };
            uc_CmbAutoByFilter2.ParamValue = new string[] { filterName2 };
         //   uc_CmbAutoByFilter2.ParamHide = new string[] { "x_" };



            uc_CmbAutoByFilterPices.uc_cmbAuto1.DataSource = dt_S;
            uc_CmbAutoByFilterPices.uc_cmbAuto1.DisplayMember = filter3;
            uc_CmbAutoByFilterPices.uc_cmbAuto1.ValueMember = filter3;
            uc_CmbAutoByFilterPices.uc_cmbAuto1.SelectedIndex = -1;

            uc_CmbAutoByFilterPices.ParamName = new string[] { filter3 };
            uc_CmbAutoByFilterPices.ParamValue = new string[] { filterName3 };
           // uc_CmbAutoByFilterPices.ParamHide = new string[] { "x_" };


        }
        string filter1 = "MachineName";
        string filter2 = "OperatorName";
        string filter3 = "Pieces";
        string filterName1 = "نام دستگاه";
        string filterName2 = "نام اپراتور";
        string filterName3 = "نام قطعه";
        private DataTable dt_S;
        void generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_S.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
        }

        void ShowData()
        {
            dt_S = new BLL.ManagerReport.csManagerReport().SlPiecesProuductForManager_R(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();

            uc_CmbAutoByFilter1.uc_cmbAuto1.DataSource = dt_S.DefaultView.ToTable(true, filter1);
            uc_CmbAutoByFilter2.uc_cmbAuto1.DataSource = dt_S.DefaultView.ToTable(true, filter2);
            uc_CmbAutoByFilterPices.uc_cmbAuto1.DataSource = dt_S.DefaultView.ToTable(true, filter3);

            uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;
            uc_CmbAutoByFilter2.uc_cmbAuto1.SelectedIndex = -1;
            uc_CmbAutoByFilterPices.uc_cmbAuto1.SelectedIndex = -1;




        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {

            ShowData();
         
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


           
            if (uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex > -1)
            {
                if (expression == "")
                    Condition = "";
                else
                {
                    if (radioButton_and.Checked)
                        Condition = " AND ";
                    else
                    {
                        Condition = " OR  ";

                    }
                }
                expression += Condition + " ( ";
                expression += filter1+ " = " + "\'" + uc_CmbAutoByFilter1.uc_cmbAuto1.Text + "\'" + ")     ";
            }

            if (uc_CmbAutoByFilter2.uc_cmbAuto1.SelectedIndex > -1)
            {
                if (expression == "")
                    Condition = "";
                else
                {
                    if (radioButton_and.Checked)
                        Condition = " AND ";
                    else
                    {
                        Condition = " OR  ";

                    }
                }
                expression += Condition + " ( ";
                expression += filter2 + " = " + "\'" + uc_CmbAutoByFilter2.uc_cmbAuto1.Text + "\'" + ")     ";
            }


            if (uc_CmbAutoByFilterPices.uc_cmbAuto1.SelectedIndex > -1)
            {
                if (expression == "")
                    Condition = "";
                else
                {
                    if (radioButton_and.Checked)
                        Condition = " AND ";
                    else
                    {
                        Condition = " OR  ";

                    }
                }
                expression += Condition + " ( ";
                expression += filter3 + " = " + "\'" + uc_CmbAutoByFilterPices.uc_cmbAuto1.Text + "\'" + ")     ";
            }





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

                uc_CmbAutoByFilter1.uc_cmbAuto1.DataSource = dt1.DefaultView.ToTable(true, filter1);
                uc_CmbAutoByFilter2.uc_cmbAuto1.DataSource = dt1.DefaultView.ToTable(true, filter2);
                uc_CmbAutoByFilterPices.uc_cmbAuto1.DataSource = dt1.DefaultView.ToTable(true, filter3);

                uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;
                uc_CmbAutoByFilter2.uc_cmbAuto1.SelectedIndex = -1;
                uc_CmbAutoByFilterPices.uc_cmbAuto1.SelectedIndex = -1;

                generate();
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
