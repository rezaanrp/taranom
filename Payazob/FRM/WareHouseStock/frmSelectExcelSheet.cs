using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TARANOM.FRM.WareHouseStock
{
    public partial class frmSelectExcelSheet : Form
    {
        public  frmSelectExcelSheet(List<string> StrTable)
        {
            InitializeComponent();
            Tables = StrTable;
            
        }
        public frmSelectExcelSheet(DataTable dt)
        {
            InitializeComponent();
            dtTable = dt;
            DataTables = true;
        }
        DataTable dtTable = new DataTable();
        string tableName = string.Empty;
        List<string> Tables;
        bool DataTables = false;
        public string SelectedTable = "$";
        private void FrmSelectExcelSheet_Load(object sender, EventArgs e)
        {
            if (!DataTables)
            {
                if (Tables != null)
                {
                    foreach (string item in Tables)
                    {
                        ListViewItem lv = new ListViewItem();
                        lv.Text = item.ToString();
                       // lv.Tag = Tables.fi;
                        lstViewTables.Items.Add(lv);
                    }

                    //for (int tables = 0; tables < Tables.Length; tables++)
                    //{
                    //    try
                    //    {
                    //        ListViewItem lv = new ListViewItem();
                    //        lv.Text = Tables[tables].ToString();
                    //        lv.Tag = tables;
                    //        lstViewTables.Items.Add(lv);
                    //    }
                    //    catch (Exception ex)
                    //    { }
                    //}
                }
            }
            else
            {
                if (dtTable.Rows.Count > 0)
                {
                    for (int tables = 0; tables < dtTable.Rows.Count; tables++)
                    {
                            ListViewItem lv = new ListViewItem();
                            lv.Text = dtTable.Rows[tables][0].ToString();
                            lv.Tag = dtTable.Rows[tables][0];
                            lstViewTables.Items.Add(lv);
                    }
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (lstViewTables.Items.Count > 0)
            {
                if (tableName != string.Empty)
                {
                    SelectedTable = tableName;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Select a Table");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void LstViewTables_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            tableName = e.Item.Text;

        }
    }
}
