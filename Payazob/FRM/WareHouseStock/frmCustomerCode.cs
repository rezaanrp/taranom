using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TARANOM.FRM.WareHouseStock
{
    public partial class frmCustomerCode : Form
    {
        public frmCustomerCode()
        {
            InitializeComponent();
            dt_final = new DataTable();

            dt_final.Columns.Add("NameS", typeof(string));
            dt_final.Columns.Add("CodeS", typeof(string));
            dt_final.Columns.Add("NameH", typeof(string));
            dt_final.Columns.Add("CodeH", typeof(string));
        }
        DataTable dt_Holo;
        DataTable dt_Sabz;
        DataTable dt_final;
        DataTable ImportFile(DataGridView dvg)
        {
            string txt;
            DataTable dt = new DataTable();
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            //  fdlg.InitialDirectory = @"c:\";
            // fdlg.FileName = txt;
            fdlg.Filter = "Excel Sheet(*.xlsx)|*.xlsx;;|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txt = fdlg.FileName;
                dt = GetDataTableExcel(txt, "Sheet1");
                dvg.DataSource = dt.DefaultView;
                Application.DoEvents();
            }



            return dt;
        }

        public static DataTable GetDataTableExcel(string strFileName, string Table)
        {
            String name = Table;
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            strFileName +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
            OleDbConnection con = new OleDbConnection(constr);

            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();
            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            con.Close();
            return data;
        }

        private void ToolStripButton_ImportExcel_Click(object sender, EventArgs e)
        {
            dt_Sabz = ImportFile(dataGridView_HOLO);
            if (dt_Sabz.Rows.Count < 1)
                return;
            bindingSource1.DataSource = dataGridView_HOLO.DataSource;
            bindingNavigator_Product.BindingSource = bindingSource1;
            //dt_Product.Columns.Add("Id", typeof(int));
            //dt_Product.Columns.Add("CountRecord", typeof(int));
            //dt_Product.Columns.Add("xMaxDate", typeof(string));
            //dt_Product.Columns.Add("xProfit", typeof(double));
            //dt_Product.Columns[ixPCd].ColumnName = "xCode";
            //dt_Product.Columns[ixPDate].ColumnName = "xDate";
        }

        private void ToolStripButton_ImportCustomer_Click(object sender, EventArgs e)
        {
            dt_Holo = ImportFile(dataGridView_SABZ);
            bindingSource2.DataSource = dataGridView_SABZ.DataSource;
            bindingNavigator_Customer.BindingSource = bindingSource2;

        }

        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = dt_Holo.Rows.Count;
            progressBar1.Step = 1;
            progressBar1.Visible = true;
            progressBar1.Value = 1;
            int i = 0;
            foreach (DataRow itemH in dt_Holo.Rows)
            {
                progressBar1.PerformStep();
                bool flag = false;
               // string stH = itemH[1].ToString().Replace(" ", String.Empty).Replace("$", String.Empty).Replace('ی', 'ي').Replace('ک', 'ك');
                string stH = Regex.Replace(itemH[1].ToString(), @"[\d-]", string.Empty).Replace(" ","").Replace('ی', 'ي').Replace('ک', 'ك').Replace('آ','ا');
                foreach (DataRow itemS in dt_Sabz.Rows)
                {
                   
                    if (stH == Regex.Replace(itemS[1].ToString(), @"[\d-]", string.Empty).Replace(" ", "").Replace('ی', 'ي').Replace('ک', 'ك').Replace('آ', 'ا'))
                    {
                        i++;
                        DataRow _ravi2 = dt_final.NewRow();
                        _ravi2["NameS"] = itemS[1].ToString();
                        _ravi2["CodeS"] = itemS[0].ToString();
                        _ravi2["NameH"] = itemH[1].ToString();
                        _ravi2["CodeH"] = itemH[0].ToString();
                        //   _ravi2["Inv"] = 0;
                        dt_final.Rows.Add(_ravi2);
                        flag = true;
                        break;
                    }

                }
                if (!flag)
                {
                    DataRow _ravi2 = dt_final.NewRow();
                    _ravi2["NameH"] = itemH[1].ToString();
                    _ravi2["CodeH"] = itemH[0].ToString();
                    _ravi2["NameS"] = "$";
                    _ravi2["CodeS"] = "$";
                    //   _ravi2["Inv"] = 0;
                    dt_final.Rows.Add(_ravi2);
                }
            }
            MessageBox.Show(i.ToString());
            dataGridView1.DataSource = dt_final;
        }
    }
}
