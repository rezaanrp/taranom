using System;
using System.Windows.Forms;

namespace Payazob.FRM.Sand
{
    public partial class frmSandWeeklyRange : Form
    {
        public frmSandWeeklyRange()
        {
            InitializeComponent();



            //dt_N = new BLL.csSand().SlSandDailyTestRange();
            //bindingSource1.DataSource = dt_N;
            //dataGridView1.DataSource = bindingSource1;
            //bindingNavigator1.BindingSource = bindingSource1;

            //Generate();
        
        }
        //DAL.Sand.DataSet_SandDailyReport.SlSandDailyTestRangeDataTable dt_N;



        private void btn_Show_Click(object sender, EventArgs e)
        {


        }
        void Generate()
        {
            //CS.csDic css = new CS.csDic();

            //foreach (DataColumn dc in dt_N.Columns)
            //{
            //    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            //}

            //dt_N.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            //dt_N.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            //dataGridView1.Columns["x_"].Visible = false;
            //dataGridView1.Columns["xSupplier_"].Visible = false;

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //if (new CS.csMessage().ShowMessageSaveYesNo())
            //{
            //    this.dataGridView1.EndEdit();
            //    this.Validate();
            //    BLL.csSand cs = new BLL.csSand();
            //    MessageBox.Show(cs.UdSandDailyTestRange(dt_N));
            //    dt_N = cs.SlSandDailyTestRange();
            //    bindingSource1.DataSource = dt_N;
            //    dataGridView1.DataSource = bindingSource1;
            //    bindingNavigator1.BindingSource = bindingSource1;
            //    Generate();
            //}
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

//            foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
//            {
//                if(item.DataBindings.Count > 0)
//                item.DataBindings.RemoveAt(0);
//            }
//            foreach (ControlLibrary.uc_txtBox item in groupBox2.Controls.OfType<ControlLibrary.uc_txtBox>())
//            {
//                if (item.DataBindings.Count > 0)
//                    item.DataBindings.RemoveAt(0);
//            }
//            foreach (ControlLibrary.uc_txtBox item in groupBox3.Controls.OfType<ControlLibrary.uc_txtBox>())
//            {
//                if (item.DataBindings.Count > 0)
//                    item.DataBindings.RemoveAt(0);
//            }
//            foreach (ControlLibrary.uc_txtBox item in groupBox4.Controls.OfType<ControlLibrary.uc_txtBox>())
//            {
//                if (item.DataBindings.Count > 0)
//                    item.DataBindings.RemoveAt(0);
//            }

//            if (uc_TextBoxDate1.DataBindings.Count > 0)
//                uc_TextBoxDate1.DataBindings.RemoveAt(0);
//            //else
//            //    return;
//                //bindingSource2.DataSource = dataGridView1.SelectedRows[0];
//                //  textBox1.DataBindings.Add("Text", dt_N, "xDate");
//            uc_TextBoxDate1.DataBindings.Add(new Binding("Text", dataGridView1["xDate", e.RowIndex], "Value"));

////---------------------------------------------
//                uc_txtBox_xCompactibilityCl.DataBindings.Add(new Binding("Text", dataGridView1["xCompactibilityCl", e.RowIndex], "Value"));
//                uc_txtBox_xCompactibilityLcl.DataBindings.Add(new Binding("Text", dataGridView1["xCompactibilityLcl", e.RowIndex], "Value"));
//                uc_txtBox_xCompactibilityLsl.DataBindings.Add(new Binding("Text", dataGridView1["xCompactibilityLsl", e.RowIndex], "Value"));

//                uc_txtBox_xCompactibilitySl.DataBindings.Add(new Binding("Text", dataGridView1["xCompactibilitySl", e.RowIndex], "Value"));
//                uc_txtBox_xCompactibilityUcl.DataBindings.Add(new Binding("Text", dataGridView1["xCompactibilityUcl", e.RowIndex], "Value"));
//                uc_txtBox_xCompactibilityUsl.DataBindings.Add(new Binding("Text", dataGridView1["xCompactibilityUsl", e.RowIndex], "Value"));


////-------------------------------------------
//                uc_txtBox_xCompresiveStrengthCl.DataBindings.Add(new Binding("Text", dataGridView1["xCompresiveStrengthCl", e.RowIndex], "Value"));
//                uc_txtBox_xCompresiveStrengthLcl.DataBindings.Add(new Binding("Text", dataGridView1["xCompresiveStrengthLcl", e.RowIndex], "Value"));
//                uc_txtBox_xCompresiveStrengthLsl.DataBindings.Add(new Binding("Text", dataGridView1["xCompresiveStrengthLsl", e.RowIndex], "Value"));

//                uc_txtBox_xCompresiveStrengthSl.DataBindings.Add(new Binding("Text", dataGridView1["xCompresiveStrengthSl", e.RowIndex], "Value"));
//                uc_txtBox_xCompresiveStrengthUcl.DataBindings.Add(new Binding("Text", dataGridView1["xCompresiveStrengthUcl", e.RowIndex], "Value"));
//                uc_txtBox_xCompresiveStrengthUsl.DataBindings.Add(new Binding("Text", dataGridView1["xCompresiveStrengthUsl", e.RowIndex], "Value"));


////-------------------------------------------
//                uc_txtBox_xMoisturePercentCl.DataBindings.Add(new Binding("Text", dataGridView1["xMoisturePercentCl", e.RowIndex], "Value"));
//                uc_txtBox_xMoisturePercentLcl.DataBindings.Add(new Binding("Text", dataGridView1["xMoisturePercentLcl", e.RowIndex], "Value"));
//                uc_txtBox_xMoisturePercentLsl.DataBindings.Add(new Binding("Text", dataGridView1["xMoisturePercentLsl", e.RowIndex], "Value"));

//                uc_txtBox_xMoisturePercentSl.DataBindings.Add(new Binding("Text", dataGridView1["xMoisturePercentSl", e.RowIndex], "Value"));
//                uc_txtBox_xMoisturePercentUcl.DataBindings.Add(new Binding("Text", dataGridView1["xMoisturePercentUcl", e.RowIndex], "Value"));
//                uc_txtBox_xMoisturePercentUsl.DataBindings.Add(new Binding("Text", dataGridView1["xMoisturePercentUsl", e.RowIndex], "Value"));

////-------------------------------------------
//                uc_txtBox_xPermeabilityLcl.DataBindings.Add(new Binding("Text", dataGridView1["xPermeabilityLcl", e.RowIndex], "Value"));
//                uc_txtBox_xPermeabilityLsl.DataBindings.Add(new Binding("Text", dataGridView1["xPermeabilityLsl", e.RowIndex], "Value"));
//                uc_txtBox_xPermeabilitySl.DataBindings.Add(new Binding("Text", dataGridView1["xPermeabilitySl", e.RowIndex], "Value"));

//                uc_txtBox_xPermeabilityUcl.DataBindings.Add(new Binding("Text", dataGridView1["xPermeabilityUcl", e.RowIndex], "Value"));
//                uc_txtBox_xPermeabilityUsl.DataBindings.Add(new Binding("Text", dataGridView1["xPermeabilityUsl", e.RowIndex], "Value"));
//                uc_txtBox8_xPermeabilityCl.DataBindings.Add(new Binding("Text", dataGridView1["xPermeabilityCl", e.RowIndex], "Value"));

        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    {
            //        if (dataGridView1.Columns[i].Name == "x_" || dataGridView1.Columns[i].Name == "xSupplier_")
            //            continue;
            //        dataGridView1[i, dataGridView1.Rows.Count - 1].Value = dataGridView1[i, 0].Value;
                     
            //    }
                    
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }




    }
}
