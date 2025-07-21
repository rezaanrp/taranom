using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_SearchData : UserControl
    {
        public uc_SearchData()
        {
            InitializeComponent();
        }
        DataTable dt_Filter = new DataTable();
        DataTable dt_FilterM = new DataTable();
        public string ColumnFilter = "";
        public string ResultName = "";
        public string ResultID = "-1";

        public string ResultCustom = "";
        public string ResultCustomValue = "";

        public string ResultCustom1 = "";
        public string ResultCustomValue1 = "";

        public void GenDataGridView(DataTable dt)
        {
            dt_Filter = dt;
            if (dt_FilterM.Columns.Count < 1)
            {
                dt_FilterM = dt_Filter;
            }
            dataGridView1.DataSource = dt_Filter;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.Visible = false;
            }
            while (stackParamName.Count > 0)
            {
               string sttt = stackParamName.Pop();
               dataGridView1.Columns[sttt].HeaderText = stackParamValue.Pop();
               dataGridView1.Columns[sttt].Visible = true;
            }
            while (stackParamHide.Count > 0)
            {
                dataGridView1.Columns[stackParamHide.Pop()].Visible = false;
            }

        }
        private Stack<string> stackParamName = new Stack<string>();
        private Stack<string> stackParamValue = new Stack<string>();
        private Stack<string> stackParamHide = new Stack<string>();
        private void btn_filter_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                DataGridViewHeaderText(item.Name,item.HeaderText);
            }
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                if(item.Visible == false)
                     DataGridViewClmHide(item.Name);
            }
            if (dt_Filter.Select(ColumnFilter + " like  '%" + uc_txtBox_Filter.Text + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ی', 'ي') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ي', 'ی') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ک', 'ك') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ك', 'ک') + "%'").Length > 0)
                GenDataGridView(dt_Filter.Select(ColumnFilter + " like  '%" + uc_txtBox_Filter.Text + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ی', 'ي') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ي', 'ی') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ک', 'ك') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ك', 'ک') + "%'").CopyToDataTable());
            else
            {
                DataTable dt = dt_Filter.Copy();
                dt.Clear();
                GenDataGridView(dt);
            }

        }

        public void DataGridViewHeaderText(string Name,string Value)
        {
            stackParamName.Push(Name);
            stackParamValue.Push(Value);
        }
        public void DataGridViewClmHide(string Name)
        {
            stackParamHide.Push(Name);
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                ResultName = dataGridView1[ColumnFilter, e.RowIndex].Value.ToString();
                ResultID = dataGridView1["x_", e.RowIndex].Value.ToString();
                if (dataGridView1.Columns.Contains(ResultCustom))
                {
                    ResultCustomValue = dataGridView1[ResultCustom, e.RowIndex].Value.ToString();
                }
                if (dataGridView1.Columns.Contains(ResultCustom1))
                {
                    ResultCustomValue1 = dataGridView1[ResultCustom1, e.RowIndex].Value.ToString();
                }
                this.ParentForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                DataGridViewHeaderText(item.Name, item.HeaderText);
            }
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                if (item.Visible == false)
                    DataGridViewClmHide(item.Name);
            }
            GenDataGridView(dt_FilterM);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ResultName = dataGridView1[ColumnFilter,dataGridView1.SelectedCells[0].RowIndex].Value.ToString();
            ResultID = dataGridView1["x_", dataGridView1.SelectedCells[0].RowIndex].Value.ToString();

            if (dataGridView1.Columns.Contains(ResultCustom))
            {
                ResultCustomValue = dataGridView1[ResultCustom, dataGridView1.SelectedCells[0].RowIndex].Value.ToString();
            }
            if (dataGridView1.Columns.Contains(ResultCustom1))
            {
                ResultCustomValue1 = dataGridView1[ResultCustom1, dataGridView1.SelectedCells[0].RowIndex].Value.ToString();
            }
            this.ParentForm.Close();
        }

        private void uc_txtBox_Filter_TextChanged(object sender, EventArgs e)
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
                        (itemCell.FormattedValue.ToString().Contains(uc_txtBox_Filter.Text) ||
                         itemCell.FormattedValue.ToString().Contains(uc_txtBox_Filter.Text.Replace('ی', 'ي')) ||
                          itemCell.FormattedValue.ToString().Contains(uc_txtBox_Filter.Text.Replace('ي', 'ی')) ||
                           itemCell.FormattedValue.ToString().Contains(uc_txtBox_Filter.Text.Replace('ک', 'ك')) ||
                            itemCell.FormattedValue.ToString().Contains(uc_txtBox_Filter.Text.Replace('ك', 'ک')))
                        )
                    {
                        item.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = item.Index > 1 ? item.Index - 2 : item.Index;
                        return;
                    }


                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case (System.Windows.Forms.Keys.Enter):
                    btn_ok.PerformClick();
                    break;


            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
