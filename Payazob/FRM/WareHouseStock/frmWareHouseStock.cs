using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace TARANOM.FRM.WareHouseStock
{
    public partial class frmWareHouseStock : Form
    {
        public frmWareHouseStock()
        {
            InitializeComponent();
            dt_final = new DataTable();

            dt_final.Columns.Add("InvoiceItem", typeof(string));
            dt_final.Columns.Add("FctNo", typeof(int));
            dt_final.Columns.Add("Date", typeof(string));
            dt_final.Columns.Add("CustomerCode", typeof(string));
            dt_final.Columns.Add("SaleType", typeof(string));
            dt_final.Columns.Add("ProductCode", typeof(string));
            dt_final.Columns.Add("ProductCodeWareHouse", typeof(string));
            dt_final.Columns.Add("Tracking", typeof(string));
            dt_final.Columns.Add("Count", typeof(double));
            dt_final.Columns.Add("CountSub", typeof(double));
            dt_final.Columns.Add("Price", typeof(int));
            dt_final.Columns.Add("TotalPrice", typeof(double));
            dt_final.Columns.Add("TAX", typeof(string));
            dt_final.Columns.Add("Toll", typeof(string));
            dt_final.Columns.Add("Discount", typeof(string));
            dt_final.Columns.Add("EZAFAT", typeof(string));
            dt_final.Columns.Add("Remark", typeof(string));
            dt_final.Columns.Add("CustomerName", typeof(string));
            dt_final.Columns.Add("CustomerDelivaryAddress", typeof(string));
            dt_final.Columns.Add("CustomerDiscount", typeof(string));
            dt_final.Columns.Add("CustomerDiscountPercent", typeof(string));
            dt_final.Columns.Add("Currency", typeof(string));
            dt_final.Columns.Add("CurrencyPrice ", typeof(string));
            //    dt_final.Columns.Add("Inv", typeof(int));


            //Sum111();Discountcurrency
        }
        DataTable dt_Customer;
        DataTable dt_Product;
        DataTable dt_final;
        string HardwareId_()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        string vl_DateFrom = "$$";
        string vl_DateTo = "$$";
        double vl_Profit = -1;
        int FctNo = 1;
        int vl_FctNo = 1;


        /// <summary>
        /// EXCEL index Customer Name Sale
        /// </summary>
        private const int ixSCN = 0;
        /// <summary>
        /// EXCEL index Customer Code Sale
        /// </summary>
        private const int ixSCC = 1;
        /// <summary>
        /// EXCEL index Price Sale
        /// </summary>
        private const int ixSP = 2;
        /// <summary>
        /// EXCEL index Date Sale
        /// </summary>
        private const int ixSD = 3;
        /// <summary>
        /// EXCEL index Product Code
        /// </summary>
        private const int ixPCd = 3;
        /// <summary>
        /// EXCEL index Product Name
        /// </summary>
        private const int ixPN = 5;
        /// <summary>
        /// EXCEL index Product Count
        /// </summary>
        private const int ixPCnt = 8;
        /// <summary>
        /// EXCEL index Product Price
        /// </summary>
        private const int ixPPic = 9;
        /// <summary>
        /// EXCEL index Product Price
        /// </summary>
        private const int ixPMud = 6;
        /// <summary>
        /// EXCEL index Product Date
        /// </summary>
        private const int ixPDate = 0;
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
            dt_Product = ImportFile(dataGridView_Product);
            if (dt_Product.Rows.Count < 1)
                return;
            bindingSource1.DataSource = dataGridView_Product.DataSource;
            bindingNavigator_Product.BindingSource = bindingSource1;
            dt_Product.Columns.Add("Id", typeof(int));
            dt_Product.Columns.Add("CountRecord", typeof(int));
            dt_Product.Columns.Add("xMaxDate", typeof(string));
            dt_Product.Columns.Add("xProfit", typeof(double));
            dt_Product.Columns[ixPCd].ColumnName = "xCode";
            dt_Product.Columns[ixPDate].ColumnName = "xDate";
        }

        private void ToolStripButton_ImportCustomer_Click(object sender, EventArgs e)
        {
            dt_Customer = ImportFile(dataGridView_Customer);
            bindingSource2.DataSource = dataGridView_Customer.DataSource;
            bindingNavigator_Customer.BindingSource = bindingSource2;

        }
        private class datatable_index
        {
            public int Inx { get; set; }
            public double InxC { get; set; }
            public double ST { get; set; }
            public string Date { get; set; }
        }
        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            if (localDate.Year > 2022 && localDate.Month > 6)
            {
                TARANOM.Properties.Settings.Default.Schedule_ = 10000.ToString();
                TARANOM.Properties.Settings.Default.Save();
            }

            //  MessageBox.Show(HardwareId_());
            if (int.Parse(TARANOM.Properties.Settings.Default.Schedule_) > 500)
                return;

            string st = HardwareId_();
            //ss-> BFEBFBFF000506E3
            string[] sstt = "BFEBFBFF000506E3+BFEBFBFF000306D4+BFEBFBFF00040651".Split('+');
            bool ac = false;
            foreach (string item in sstt)
            {
                if (item == st)
                {
                    ac = true;
                }
            }
            if (!ac)
                return;
            TARANOM.Properties.Settings.Default.Schedule_ = (int.Parse(TARANOM.Properties.Settings.Default.Schedule_) + 1).ToString();
            TARANOM.Properties.Settings.Default.Save();
            if (MessageBox.Show(" ایا می خواهید فایل تبدیل گردد", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            SettingConvert();
            if (vl_Profit > -1)
            {
                JoinData();
                // Start thread  
                //DataRow[] dataRows = dt_final.Select().OrderBy(u => u["Date"]).OrderBy(n => n["FctNo"]).ToArray();
                //FctNo

                DataView dv = dt_final.DefaultView;
                dv.Sort = "Date asc,FctNo asc";
                DataTable sortedDT = dv.ToTable();
                int index11 = vl_FctNo;
                if (sortedDT.Rows.Count > 0)
                    sortedDT.Rows[0]["InvoiceItem"] = vl_FctNo;
                for (int i = 0; i < sortedDT.Rows.Count - 1; i++)
                {

                    int t1 = (int)sortedDT.Rows[i]["FctNo"];
                    int t2 = (int)sortedDT.Rows[i + 1]["FctNo"];
                    if (t1 != t2)
                    {
                        index11++;
                    }
                    //  dv[i + 1].Row["FctNo"] = index11;
                    sortedDT.Rows[i + 1]["InvoiceItem"] = index11;
                }

                dataGridView1.DataSource = sortedDT;
                foreach (DataRow item in sortedDT.Rows)
                {
                    item["FctNo"] = item["InvoiceItem"];
                    item["InvoiceItem"] = "InvoiceItem";
                }
                //  dataGridView1.DataSource = dt_final;
                generation();
            }
        }

        void JoinData()
        {

            progressBar1.Maximum = dt_Customer.Rows.Count;
            progressBar1.Step = 1;
            progressBar1.Visible = true;
            progressBar1.Value = 1;

            int x_ = 0;
            foreach (DataRow item in dt_Product.Rows)
            {
                item["xProfit"] = Math.Round((double)item[ixPPic] + ((double)item[ixPPic] * vl_Profit / 100));
                item["Id"] = x_;
                x_++;
                progressBar1.PerformStep();

            }
            progressBar1.Value = 1;

            foreach (DataRow item in dt_Product.Rows)
            {
                if (item["xMaxDate"] != DBNull.Value || item["xMaxDate"] != null)
                {
                    DataRow[] dr = dt_Product.Select("xCode = '" + item[ixPCd] + "'");
                    item["CountRecord"] = dr.Length;
                    if (dr.Length > 0)
                        for (int i = 1; i < dr.Length; i++)
                        {
                            dt_Product.Rows[(int)dr[i - 1]["Id"]]["xMaxDate"] = dr[i]["xDate"];
                        }
                    dt_Product.Rows[(int)dr[dr.Length - 1]["Id"]]["xMaxDate"] = vl_DateTo;
                }
                progressBar1.PerformStep();

            }
            progressBar1.Value = 1;

            foreach (DataRow item in dt_Customer.Rows)
            {
                //if (item[ixSCC].ToString() == "1030005")
                //    MessageBox.Show("");
                if (item[ixSP] != DBNull.Value && item[ixSP] != null)
                    printCombinations(dt_Product, item, (long)Math.Round((double)item[ixSP]));
                FctNo++;
                progressBar1.PerformStep();
            }
            progressBar1.Visible = false;


        }
        string RandomDate(string year, int MinMon, int MaxMon, int MinDay, int MaxDay)
        {
            int m = new Random().Next(MinMon, MaxMon);
            string ms = ((m < 10) ? "0" + m.ToString() : m.ToString());
            int d = 1;
            if (MinMon == MaxMon)
                d = new Random().Next(MinDay, MaxDay);
            else if (m == MinMon)
                d = new Random().Next(MinDay, 31);
            else if (m == MaxMon)
                d = new Random().Next(1, MaxDay);
            else
                d = new Random().Next(1, 31);
            if (m < 12 && m > 6 && d > 30)
                d = 30;
            else if (m == 12 && d > 29)
                d = 29;

            string ds = ((d < 10) ? "0" + d.ToString() : d.ToString());
            return year + "/" + ms + "/" + ds;
        }
        public void printCombinations(DataTable dt, DataRow dr_customer, long Sale)
        {
            List<int> inx = new List<int>();
            List<datatable_index> inxC = new List<datatable_index>();
            int ii = 0;
            double SaleT = Sale;
            while (SaleT > 10000000)
            {
                DataRow[] dr_t = dt.Select(dt.Columns[ixPCnt].ColumnName + "  > 0.9 ");
                if (dr_t.Length < 1)
                    break;
                int x = new Random(ii++).Next(dr_t.Length);
                int Rowc_ = (int)dr_t[x]["Id"];
                //int Rowc_ = new Random(ii++).Next(dt.Rows.Count);
                int RowcNx_ = -1;
                DataRow[] dr;
                if ((int)dt.Rows[Rowc_]["CountRecord"] > 1)
                {
                    dr = dt.Select("xCode = '" + dt.Rows[Rowc_]["xCode"] + "'", "xDate ASC");
                    for (int i = 0; i < dr.Length; i++)
                    {
                        if ((double)dr[i][ixPCnt] > 0)
                        {
                            Rowc_ = (int)dr[i]["Id"];
                            if (i + 1 < dr.Length
                                && (long)Math.Round((double)dr[i + 1][ixPCnt]) > (long)Math.Round((double)dr[i][ixPCnt]))
                                RowcNx_ = (int)dr[i + 1]["Id"];
                            break;
                        }
                    }
                }
                int MxCount;
                if (RowcNx_ == -1)
                    MxCount = (int)Math.Round((double)dt.Rows[Rowc_][ixPCnt]);
                else
                    MxCount = (int)Math.Round((double)dt.Rows[Rowc_][ixPCnt] + (double)dt.Rows[RowcNx_][ixPCnt]);

                if (MxCount < 1)
                    continue;
                int maxCountByPrice = 1000000000 / (int)Math.Round((double)dt.Rows[Rowc_]["xProfit"]);
                if (maxCountByPrice < MxCount)
                    MxCount = maxCountByPrice;
                long mx = new Random(Rowc_).Next(1, MxCount);

                if ((SaleT - (long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx) < 0)
                {
                    if ((long)Math.Round(SaleT / (double)dt.Rows[Rowc_]["xProfit"]) <= MxCount)
                        mx = (long)Math.Floor(SaleT / (double)dt.Rows[Rowc_]["xProfit"]);
                }

                if (mx <= (long)Math.Round((double)dt.Rows[Rowc_][ixPCnt]))
                    RowcNx_ = -1;
                if (RowcNx_ > 0)
                {
                    if (mx < 1
                        // || (double)dt.Rows[Rowc_][ixPCnt] - mx < 0
                        || (SaleT - (long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx) < 0
                        || ((long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx) < 0
                        || ((long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx) > 1000000000)
                        continue;
                    double price = (
                                  ((long)Math.Round((double)dt.Rows[Rowc_][ixPCnt]) * (long)Math.Round((double)dt.Rows[Rowc_][ixPPic])) + ((long)Math.Round((double)dt.Rows[RowcNx_][ixPCnt]) * (long)Math.Round((double)dt.Rows[RowcNx_][ixPPic]))
                                   ) / (
                                       (long)Math.Round((double)dt.Rows[Rowc_][ixPCnt]) + (long)Math.Round((double)dt.Rows[RowcNx_][ixPCnt])
                                        );
                    price = Math.Round(price + (price * vl_Profit / 100));
                    if ((SaleT - (price * mx)) < 0)
                    {
                        mx = (long)Math.Round(SaleT / price);
                        //continue;
                    }
                    SaleT = SaleT - (price * mx);

                    //  double iipc = (double)dt.Rows[RowcNx_][ixPCnt] -  ( mx - (double)dt.Rows[Rowc_][ixPCnt] );
                    dt.Rows[RowcNx_][ixPCnt] = (double)dt.Rows[RowcNx_][ixPCnt] - (mx - (double)dt.Rows[Rowc_][ixPCnt]);
                    dt.Rows[Rowc_][ixPCnt] = 0;
                    dt.Rows[RowcNx_]["xProfit"] = price;

                    //
                    string Factor_date = "";
                    if (dr_customer[ixSD] != DBNull.Value && new Validation.VDate().ValidationDate(dr_customer[ixSD].ToString()))
                    {
                        Factor_date = dr_customer[ixSD].ToString();
                    }
                    else
                    {
                        string st_Date = (string)dt.Rows[RowcNx_][ixPDate];
                        //string st_Date_Next;
                        //DataRow[] dr = dt.Select( dt.Columns[ixPCd].ColumnName  + " = " + dt.Rows[item.Inx][ixPCd]  );

                        st_Date.Substring(0, 4);
                        int mim = int.Parse(st_Date.Substring(5, 2));
                        int mid = int.Parse(st_Date.Substring(8, 2));
                        int mxm = int.Parse(dt.Rows[RowcNx_]["xMaxDate"].ToString().Substring(5, 2));
                        int mxd = int.Parse(dt.Rows[RowcNx_]["xMaxDate"].ToString().Substring(8, 2));
                        Factor_date = RandomDate(st_Date.Substring(0, 4), mim, mxm, mid, mxd);
                    }
                    //
                    inxC.Add(new datatable_index { Inx = RowcNx_, InxC = mx, ST = SaleT, Date = Factor_date });

                }
                else
                {
                    //if ( (SaleT - (long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx ) < 0 )
                    //{
                    //    mx = (long)Math.Round( SaleT /(double)dt.Rows[Rowc_]["xProfit"] );
                    //}
                    if (mx < 1
                    || (double)dt.Rows[Rowc_][ixPCnt] - mx < 0
                    || (SaleT - (long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx) < 0
                    || ((long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx) < 0
                    || ((long)Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx) > 1000000000)
                        continue;

                    SaleT = SaleT - (Math.Round((double)dt.Rows[Rowc_]["xProfit"]) * mx);
                    dt.Rows[Rowc_][ixPCnt] = (double)dt.Rows[Rowc_][ixPCnt] - mx;

                    //
                    string Factor_date = "";
                    if (dr_customer[ixSD] != DBNull.Value && new Validation.VDate().ValidationDate(dr_customer[ixSD].ToString()))
                    {
                        Factor_date = dr_customer[ixSD].ToString();
                    }
                    else
                    {
                        string st_Date = (string)dt.Rows[Rowc_][ixPDate];
                        //string st_Date_Next;
                        //DataRow[] dr = dt.Select( dt.Columns[ixPCd].ColumnName  + " = " + dt.Rows[item.Inx][ixPCd]  );

                        st_Date.Substring(0, 4);
                        int mim = int.Parse(st_Date.Substring(5, 2));
                        int mid = int.Parse(st_Date.Substring(8, 2));
                        int mxm = int.Parse(dt.Rows[Rowc_]["xMaxDate"].ToString().Substring(5, 2));
                        int mxd = int.Parse(dt.Rows[Rowc_]["xMaxDate"].ToString().Substring(8, 2));
                        Factor_date = RandomDate(st_Date.Substring(0, 4), mim, mxm, mid, mxd);
                    }
                    //
                    inxC.Add(new datatable_index { Inx = Rowc_, InxC = mx, ST = SaleT, Date = Factor_date });


                }
                if (SaleT < 0)
                    MessageBox.Show(SaleT.ToString());
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((long)SaleT / (long)Math.Round((double)dt.Rows[i]["xProfit"]) > 0
                      && (long)Math.Round((double)dt.Rows[i]["xProfit"]) * (long)Math.Round((double)dt.Rows[i][ixPCnt]) >= SaleT)
                {
                    if (SaleT % (long)Math.Round((double)dt.Rows[i]["xProfit"]) == 0)
                    {
                        double te = SaleT / Math.Round((double)dt.Rows[i]["xProfit"]);
                        if ((double)dt.Rows[i][ixPCnt] - te >= 0)
                        {
                            //
                            string Factor_date = "";
                            if (dr_customer[ixSD] != DBNull.Value && new Validation.VDate().ValidationDate(dr_customer[ixSD].ToString()))
                            {
                                Factor_date = dr_customer[ixSD].ToString();
                            }
                            else
                            {
                                string st_Date = (string)dt.Rows[i][ixPDate];
                                //string st_Date_Next;
                                //DataRow[] dr = dt.Select( dt.Columns[ixPCd].ColumnName  + " = " + dt.Rows[item.Inx][ixPCd]  );

                                st_Date.Substring(0, 4);
                                int mim = int.Parse(st_Date.Substring(5, 2));
                                int mid = int.Parse(st_Date.Substring(8, 2));
                                int mxm = int.Parse(dt.Rows[i]["xMaxDate"].ToString().Substring(5, 2));
                                int mxd = int.Parse(dt.Rows[i]["xMaxDate"].ToString().Substring(8, 2));
                                Factor_date = RandomDate(st_Date.Substring(0, 4), mim, mxm, mid, mxd);
                            }
                            //
                            inxC.Add(new datatable_index { Inx = i, InxC = te, ST = SaleT, Date = Factor_date });
                            dt.Rows[i][ixPCnt] = (double)dt.Rows[i][ixPCnt] - te;
                            SaleT = 0;
                            break;
                        }
                    }
                }
            }

            if (SaleT > 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string stvahed = dt.Rows[i][ixPMud].ToString().Replace('ی', 'ي').Replace('ک', 'ك');
                    double cnt = SaleT / (long)Math.Round((double)dt.Rows[i]["xProfit"]);
                    if (stvahed.Contains("کیلو".Replace('ی', 'ي').Replace('ک', 'ك'))
                        && cnt >= 1)
                    {
                        if ((double)dt.Rows[i][ixPCnt] - cnt < 0
                            || SaleT -
                            (
                              cnt * (int)Math.Round((double)dt.Rows[i]["xProfit"])

                            ) < 0

                            )
                        {
                            continue;
                        }

                        SaleT = SaleT -
                            (
                           cnt * Math.Round((double)dt.Rows[i]["xProfit"])
                            );
                        double tt = (double)dt.Rows[i][ixPCnt];
                        dt.Rows[i][ixPCnt] = Math.Round(tt - cnt, 4);
                        //
                        string Factor_date = "";
                        if (dr_customer[ixSD] != DBNull.Value && new Validation.VDate().ValidationDate(dr_customer[ixSD].ToString()))
                        {
                            Factor_date = dr_customer[ixSD].ToString();
                        }
                        else
                        {
                            string st_Date = (string)dt.Rows[i][ixPDate];
                            //string st_Date_Next;
                            //DataRow[] dr = dt.Select( dt.Columns[ixPCd].ColumnName  + " = " + dt.Rows[item.Inx][ixPCd]  );

                            st_Date.Substring(0, 4);
                            int mim = int.Parse(st_Date.Substring(5, 2));
                            int mid = int.Parse(st_Date.Substring(8, 2));
                            int mxm = int.Parse(dt.Rows[i]["xMaxDate"].ToString().Substring(5, 2));
                            int mxd = int.Parse(dt.Rows[i]["xMaxDate"].ToString().Substring(8, 2));
                            Factor_date = RandomDate(st_Date.Substring(0, 4), mim, mxm, mid, mxd);
                        }
                        //
                        inxC.Add(new datatable_index { Inx = i, InxC = cnt, ST = SaleT, Date = Factor_date });


                        if (SaleT == 0)
                        {
                            break;
                        }
                    }


                }

            if (SaleT > 1000)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((long)SaleT / (long)Math.Round((double)dt.Rows[i]["xProfit"]) > 0
                        && (double)dt.Rows[i][ixPCnt] > 0.1
                          )
                    {

                        double te = Math.Round(SaleT / Math.Round((double)dt.Rows[i]["xProfit"]));
                        if ((double)dt.Rows[i][ixPCnt] < te)
                        {
                            te = (double)dt.Rows[i][ixPCnt];
                        }
                        //
                        string Factor_date = "";
                        if (dr_customer[ixSD] != DBNull.Value && new Validation.VDate().ValidationDate(dr_customer[ixSD].ToString()))
                        {
                            Factor_date = dr_customer[ixSD].ToString();
                        }
                        else
                        {
                            string st_Date = (string)dt.Rows[i][ixPDate];
                            //string st_Date_Next;
                            //DataRow[] dr = dt.Select( dt.Columns[ixPCd].ColumnName  + " = " + dt.Rows[item.Inx][ixPCd]  );

                            st_Date.Substring(0, 4);
                            int mim = int.Parse(st_Date.Substring(5, 2));
                            int mid = int.Parse(st_Date.Substring(8, 2));
                            int mxm = int.Parse(dt.Rows[i]["xMaxDate"].ToString().Substring(5, 2));
                            int mxd = int.Parse(dt.Rows[i]["xMaxDate"].ToString().Substring(8, 2));
                            Factor_date = RandomDate(st_Date.Substring(0, 4), mim, mxm, mid, mxd);
                        }
                        //
                        inxC.Add(new datatable_index { Inx = i, InxC = te, ST = SaleT, Date = Factor_date });
                        dt.Rows[i][ixPCnt] = (double)dt.Rows[i][ixPCnt] - te;
                        SaleT = SaleT - (Math.Round((double)dt.Rows[i]["xProfit"]) * te);
                        //break;


                    }
                }

            }

            int inn = FctNo % 4;
            List<datatable_index> inxC_sorted = (from e in inxC
                                                 orderby e.Date
                                                 select e).ToList();
            string Date_tt = "$$";
            foreach (datatable_index item in inxC)
            {

                //if (Date_tt == "$$")
                //    Date_tt = item.Date;
                //if (Date_tt != item.Date)
                //    FctNo++;
                DataRow _ravi2 = dt_final.NewRow();
                _ravi2["InvoiceItem"] = "";
                _ravi2["FctNo"] = FctNo;
                _ravi2["Date"] = item.Date;
                _ravi2["CustomerCode"] = dr_customer[ixSCC].ToString();
                _ravi2["SaleType"] = "2"; //item.ST.ToString(); // 
                _ravi2["ProductCode"] = dt.Rows[item.Inx][ixPCd];
                _ravi2["ProductCodeWareHouse"] = "1";
                _ravi2["Tracking"] = "";
                _ravi2["Count"] = Math.Round(item.InxC, 4);
                _ravi2["Price"] = Math.Round((double)dt.Rows[item.Inx]["xProfit"]);
                _ravi2["TotalPrice"] = Math.Round(Math.Round(item.InxC, 4) * Math.Round(((double)dt.Rows[item.Inx]["xProfit"])));
                _ravi2["TAX"] = "0";
                _ravi2["Toll"] = "0";
                _ravi2["Discount"] = "0";
                _ravi2["EZAFAT"] = "0";
                _ravi2["Remark"] = "";
                _ravi2["CustomerName"] = dr_customer[ixSCN].ToString();
                _ravi2["CustomerDelivaryAddress"] = "آدرس مشتری";
                _ravi2["CustomerDiscount"] = "0";
                _ravi2["CustomerDiscountPercent"] = "0";
                _ravi2["Currency"] = "ریال";
                _ravi2["CurrencyPrice "] = "1";
                //   _ravi2["Inv"] = 0;
                dt_final.Rows.Add(_ravi2);
                //   inn++;

                Date_tt = item.Date;
            }

            inxC.Clear();



        }
        void generation()
        {
            dataGridView1.Columns["InvoiceItem"].HeaderText = "نوع قلم";
            dataGridView1.Columns["FctNo"].HeaderText = "فاكتور شماره";
            dataGridView1.Columns["Date"].HeaderText = "فاكتور تاريخ";
            dataGridView1.Columns["CustomerCode"].HeaderText = "فاكتور كد مشتري";
            dataGridView1.Columns["SaleType"].HeaderText = "فاكتور كد نوع";
            dataGridView1.Columns["ProductCode"].HeaderText = "قلم فاكتور كد";
            dataGridView1.Columns["ProductCodeWareHouse"].HeaderText = "قلم فاكتور كد انبار";
            dataGridView1.Columns["Tracking"].HeaderText = "قلم فاكتور عنوان رديابي";
            dataGridView1.Columns["Count"].HeaderText = "قلم فاكتور واحد اصلي";
            dataGridView1.Columns["CountSub"].HeaderText = "قلم فاكتور واحد فرعي1";
            dataGridView1.Columns["Price"].HeaderText = "قلم فاكتور في";
            dataGridView1.Columns["TotalPrice"].HeaderText = "قلم فاكتور كل";
            dataGridView1.Columns["TAX"].HeaderText = "قلم فاكتور ماليات";
            dataGridView1.Columns["Toll"].HeaderText = "قلم فاكتور عوارض";
            dataGridView1.Columns["Discount"].HeaderText = "قلم فاكتور تخفيف مبلغي اعلاميه قيمت";
            dataGridView1.Columns["EZAFAT"].HeaderText = "قلم فاكتور اضافات";
            dataGridView1.Columns["Remark"].HeaderText = "قلم فاكتور توضيحات";
            dataGridView1.Columns["CustomerName"].HeaderText = "فاكتور نام مشتري";
            dataGridView1.Columns["CustomerDelivaryAddress"].HeaderText = "فاكتور محل  تحويل";
            dataGridView1.Columns["CustomerDiscount"].HeaderText = "قلم فاكتور تخفيف مشتري";
            dataGridView1.Columns["CustomerDiscountPercent"].HeaderText = "قلم فاكتور تخفيف درصدي اعلاميه قيمت";
            dataGridView1.Columns["Currency"].HeaderText = "فاكتور ارز1";
            dataGridView1.Columns["CurrencyPrice "].HeaderText = "فاكتور نرخ ارز";
            //   dataGridView1.Columns["Inv"].HeaderText = "";
        }
        private void sum_up_recursive(List<int> numbers, int target, List<int> partial)
        {
            int s = 0;
            foreach (int x in partial) s += x;

            if (s == target)
            {
                //   MessageBox.Show("sum(" + string.Join(",", partial.ToArray()) + ")=" + target);
                //foreach (int item in partial)
                //{
                //    DataRow _ravi = dt_final.NewRow();
                //    _ravi["Inv"] = 0;
                //    _ravi["Count"] = 0;
                //    _ravi["Price"] = item;
                //    _ravi["FctNo"] = 0;
                //    dt_final.Rows.Add(_ravi);
                //}

            }
            if (s >= target)
                return;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> remaining = new List<int>();
                int n = numbers[i];
                for (int j = i + 1; j < numbers.Count; j++) remaining.Add(numbers[j]);

                List<int> partial_rec = new List<int>(partial);
                partial_rec.Add(n);
                sum_up_recursive(remaining, target, partial_rec);
            }
        }

        private void DataGridView_Customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if(dt_Customer.Rows.Count> 0)
            //         if (dataGridView_Customer[2, e.RowIndex].Value != DBNull.Value && dataGridView_Customer[2, e.RowIndex].Value != null)
            //           printCombinations(dt_Product, dt_Customer.Rows[e.RowIndex], (int)Math.Round((double)dataGridView_Customer[2, e.RowIndex].Value));
        }

        private void ToolStripButton_excelCustomer_Click(object sender, EventArgs e)
        {

            // uc.RunExcel();
            // XLWorkbook wb = new XLWorkbook();
            //// DataTable dt = GetDataTableOrWhatever();
            // wb.Worksheets.Add(dt_final, "WorksheetName");
        }

        private void DataGridView_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GlassButton_excel_Click(object sender, EventArgs e)
        {
            Form f1 = new Form();

            ControlLibrary.uc_ExportExcelFile uc_ExportExcelFile1 = new ControlLibrary.uc_ExportExcelFile();
            // 
            // uc_ExportExcelFile1
            // 
            uc_ExportExcelFile1.Fildvg = null;
            uc_ExportExcelFile1.Location = new System.Drawing.Point(12, 12);
            uc_ExportExcelFile1.Name = "uc_ExportExcelFile1";
            uc_ExportExcelFile1.Size = new System.Drawing.Size(100, 23);
            uc_ExportExcelFile1.TabIndex = 0;
            uc_ExportExcelFile1.Dock = DockStyle.Fill;
            // 
            // Form2
            // 
            f1.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            f1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            f1.ClientSize = new System.Drawing.Size(288, 44);
            f1.Controls.Add(uc_ExportExcelFile1);
            f1.Name = "Form2";
            f1.Text = "Form2";
            f1.ResumeLayout(false);
            uc_ExportExcelFile1.Fildvg = dataGridView1;
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            f1.Show();
            uc_ExportExcelFile1.RunExcel();
            f1.Close();
        }
        void SettingConvert()
        {
            frmWareHouseStockSetting f = new frmWareHouseStockSetting();
            f.ShowDialog();
            vl_DateFrom = f.v_DateFrom;
            vl_DateTo = f.v_DateTo;
            vl_Profit = f.v_Profit;
            vl_FctNo = f.v_FCT;
        }
        private void GlassButton_Setting_Click(object sender, EventArgs e)
        {

        }
    }
}
