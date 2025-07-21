using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.SendMessage
{
    public partial class frmMessageReciver : Form
    {
        public frmMessageReciver()
        {
            InitializeComponent();
            BLL.User cs = new BLL.User();
            dataGridView1.DataSource = cs.SelectUserPorfile();
            Generate();
            this.ActiveControl = uc_txtBox1;

        }
        void Generate()
        {
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xUserName"].Visible = false;
            this.dataGridView1.Columns["xSection_"].Visible = false;
            this.dataGridView1.Columns["SectionName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["Family"].HeaderText = "نام";
            this.dataGridView1.Columns["Family"].Width = 150;
            this.dataGridView1.Columns["SectionName"].HeaderText = "نام واحد";

        }
       public  List<int> itm;
       public string listName = "";
        private void btn_ok_Click(object sender, EventArgs e)
        {
            itm = new List<int>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool?)item.Cells["xCheakBox"].Value == true)
                {
                    itm.Add((int)item.Cells["x_"].Value);
                    listName += " <" + item.Cells["Family"].Value +"> ";
                }
            }
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uc_txtBox1_TextChanged(object sender, EventArgs e)
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
                        (itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text) ||
                         itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ی', 'ي')) ||
                          itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ي', 'ی')) ||
                           itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ک', 'ك')) ||
                            itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ك', 'ک')))
                        )
                    {
                        item.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = item.Index > 1 ? item.Index - 2 : item.Index;
                        return;
                    }


                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xCheakBox")
            {
                if ((bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value)
                {
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Purple;
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

        }
    }
}
