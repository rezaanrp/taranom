using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandWeeklyTest : Form
    {
        public frmSandWeeklyTest()
        {
            InitializeComponent();

            DataGridViewRow r1 = new DataGridViewRow();
            r1.CreateCells(dataGridView_Sieve);
            r1.Cells[0].Value = " وزن ماسه روی هر الک قبل از شستشو";
            dataGridView_Sieve.Rows.Add(r1);

            DataGridViewRow r2 = new DataGridViewRow();
            r2.CreateCells(dataGridView_Sieve);
            r2.Cells[0].Value = "وزن ماسه روی هر الک بعد از شستشو";
            dataGridView_Sieve.Rows.Add(r2);

            foreach (DataGridViewColumn da in dataGridView_Sieve.Columns)
            {
                if (da.Name == "dgv_text")
                    continue;
                da.ValueType = typeof(decimal);
            }


            BLL.GenGroup.csGenGroup csg = new BLL.GenGroup.csGenGroup();

            uc_cmbAutoGenGroup.DataSource = csg.SlGenGroup("SNDW");
            uc_cmbAutoGenGroup.DisplayMember = "xName";
            uc_cmbAutoGenGroup.ValueMember = "x_";
            uc_cmbAutoGenGroup.SelectedIndex = -1;
            
        }

        private int x_;

        public int Getx_
        {
            get { return x_; }
            set { x_ = value; }
        }

        private void CalDGV()
        {
            decimal Sum = 0;
            foreach (DataGridViewCell  item in dataGridView_Sieve.Rows[0].Cells)
            {
                if (item != null)
                    Sum = (decimal)item.Value;
            }
        }

        private void CalcDataGridView_Sieve()
        {

            dataGridView_Sieve.EndEdit();

            if (dataGridView_Sieve.Rows.Count > 2)
            {
                dataGridView_Sieve.Rows.RemoveAt(2);
                dataGridView_Sieve.Rows.RemoveAt(2);
            }

            csCheakTextbox chk = new csCheakTextbox();
            float SumBefore = 0;
            float SumAfter = 0;
            dataGridView_Sieve.Rows[0].Cells["dgv_Total"].Value = 0;
            foreach (DataGridViewCell item in dataGridView_Sieve.Rows[0].Cells)
            {
                if (item.Value != null && chk.IsNumber(item.Value.ToString()) && item.ColumnIndex != 12)
                {
                    SumBefore += float.Parse(item.Value.ToString());
                }
                else
                {
                    if (item.ColumnIndex != 0 )
                    {
                        item.Value = 0;

                    }
                }

            }

            dataGridView_Sieve.Rows[0].Cells["dgv_Total"].Value = SumBefore.ToString();
            dataGridView_Sieve.Rows[1].Cells["dgv_Total"].Value = "0";

            foreach (DataGridViewCell item in dataGridView_Sieve.Rows[1].Cells)
            {
                if (item.Value != null && chk.IsNumber(item.Value.ToString()))
                {
                    SumAfter += float.Parse(item.Value.ToString());
                }
                else
                {
                    if (item.ColumnIndex != 0)
                    {
                        item.Value = "0";

                    }
                }
            }
            dataGridView_Sieve.Rows[1].Cells["dgv_Total"].Value = SumAfter.ToString();


            DataGridViewRow r1 = new DataGridViewRow();

            r1.CreateCells(dataGridView_Sieve);
            r1.Cells[0].Value = "درصد ماسه روی هر الک قبل از شستشو";
            r1.ReadOnly = true;
            r1.DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView_Sieve.Rows.Add(r1);
            for (int i = 1; i < dataGridView_Sieve.ColumnCount - 1; i++)
            {
                if (SumBefore == 0)
                {
                    dataGridView_Sieve.Rows[2].Cells[i].Value = 0;

                }
                else
                {
                    dataGridView_Sieve.Rows[2].Cells[i].Value = Math.Round((float.Parse(dataGridView_Sieve.Rows[0].Cells[i].Value.ToString()) / SumBefore) * 100, 3).ToString();

                }
            }



            DataGridViewRow r2 = new DataGridViewRow();
            r2.CreateCells(dataGridView_Sieve);
            r2.Cells[0].Value = "درصد ماسه روی هر الک بعد از شستشو";
            r2.ReadOnly = true;
            r2.DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView_Sieve.Rows.Add(r2);

            for (int i = 1; i < dataGridView_Sieve.ColumnCount - 1; i++)
            {
                if (SumAfter == 0)
                    dataGridView_Sieve.Rows[3].Cells[i].Value = 0;
                else
                    dataGridView_Sieve.Rows[3].Cells[i].Value = Math.Round(((float.Parse(dataGridView_Sieve.Rows[1].Cells[i].Value.ToString()) / SumAfter) * 100), 3).ToString();

            }

        }

        private void dataGridView_Sieve_Leave(object sender, EventArgs e)
        {
            CalcDataGridView_Sieve();


        }

        private void filldatagirdView_ASTM()
        {
            dataGridView_ASTM.Rows.Clear();
            DataGridViewRow r1 = new DataGridViewRow();
            r1.CreateCells(dataGridView_ASTM);
            r1.Cells[0].Value = " ضریب غربال قبل از شستشو";

            BLL.csSand cs = new BLL.csSand();

            DataTable dt = cs.SelectSandSieveValue();

            float sumafter = 0;
            float sumbefor = 0;

            for (int i = 1; i < 12; i++)
            {

                r1.Cells[i].Value = (float.Parse(dt.Rows[0]["xAstm" + i.ToString()].ToString()) * float.Parse(dataGridView_Sieve[i,2].Value.ToString())).ToString();
                sumbefor += float.Parse( r1.Cells[i].Value.ToString() );
            }
            uc_txtafsBefore.Text = (Math.Round( sumbefor / 100,2) ).ToString();
            dataGridView_ASTM.Rows.Add(r1);


            DataGridViewRow r2 = new DataGridViewRow();
            r2.CreateCells(dataGridView_ASTM);
            r2.Cells[0].Value = " ضریب غربال بعد از شستشو";

            for (int i = 1; i < 12; i++)
            {

                r2.Cells[i].Value = (float.Parse(dt.Rows[0]["xAstm" + i.ToString()].ToString()) * float.Parse(dataGridView_Sieve[i,3 ].Value.ToString())).ToString();
                sumafter += float.Parse(r2.Cells[i].Value.ToString());
               

            }
            uc_txtafsafter.Text = (Math.Round( sumafter / 100,2)).ToString();

            dataGridView_ASTM.Rows.Add(r2);

        }

        private void dataGridView_ASTM_Enter(object sender, EventArgs e)
        {
            
            filldatagirdView_ASTM();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            uc_MsChart1.Clear();
            uc_MsChart1.SetLabel("1.4");
            uc_MsChart1.SetLabel("1");
            uc_MsChart1.SetLabel("0.71");
            uc_MsChart1.SetLabel("0.5");
            uc_MsChart1.SetLabel("0.0355");
            uc_MsChart1.SetLabel("0.25");
            uc_MsChart1.SetLabel("0.18");
            uc_MsChart1.SetLabel("0.125");
            uc_MsChart1.SetLabel("0.09");
            uc_MsChart1.SetLabel("0.063");
            uc_MsChart1.SetLabel("سینی");


            //for (int i = 11; i > 0; i--)
            //{
            //    uc_MsChart1.SetValue(float.Parse(dataGridView_Sieve.Rows[2].Cells[i].Value.ToString()));
            //}
            //uc_MsChart1.genchart();
            //for (int i = 11; i > 0; i--)
            //{
            //    uc_MsChart1.SetValue(float.Parse(dataGridView_Sieve.Rows[3].Cells[i].Value.ToString()));
            //}
            for (int i = 1; i < 12; i++)
            {
                uc_MsChart1.SetValue(float.Parse(dataGridView_Sieve.Rows[2].Cells[i].Value.ToString()));
            }
            uc_MsChart1.title = "قبل از شستشو";
            uc_MsChart1.genchart(0);
            for (int i = 1; i < 12; i++)
            {
                uc_MsChart1.SetValue(float.Parse(dataGridView_Sieve.Rows[3].Cells[i].Value.ToString()));
            }
            uc_MsChart1.title = "بعد از شستشو";

            uc_MsChart1.genchart(1);


        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (uc_cmbAutoGenGroup.SelectedIndex < 0)
            {
                MessageBox.Show("نوع خط را مشخص کنید");
                return;
            }
            if(!uc_mtxtDate1.accept)
            {
                MessageBox.Show("تاریخ صحیح نمی باشد");
                return;
            }
            csCheakTextbox cs = new csCheakTextbox();
            decimal[] dgvs = new decimal[11];
            decimal[] dgva = new decimal[11];
            for (int i = 1; i < 12; i++)
            {
                if ( dataGridView_Sieve.Rows[0].Cells[i].Value != null && cs.IsNumber( dataGridView_Sieve.Rows[0].Cells[i].Value.ToString() ))
                {
                    dgvs[i -1] = decimal.Parse(dataGridView_Sieve.Rows[0].Cells[i].Value.ToString());
                }
                else
                {
                    dgvs[i -1] = 0;
                    dataGridView_Sieve.Rows[0].Cells[i].Value = 0;
                }
                if (dataGridView_Sieve.Rows[1].Cells[i].Value != null && cs.IsNumber(dataGridView_Sieve.Rows[1].Cells[i].Value.ToString()))
                {
                    dgva[i-1] = decimal.Parse(dataGridView_Sieve.Rows[1].Cells[i].Value.ToString());
                }
                else
                {
                    dgva[i-1] = 0;
                    dataGridView_Sieve.Rows[1].Cells[i].Value = 0;

                }

            }
            
            
            BLL.csSand css = new BLL.csSand();
            if (x_ < 0)
            {
                
                css.InsertSandWeeklyTest(uc_mtxtDate1.Text, dgvs[0], dgvs[1], dgvs[2], dgvs[3], dgvs[4], dgvs[5], dgvs[6], dgvs[7], dgvs[8], dgvs[9], dgvs[10],
                    dgva[0], dgva[1], dgva[2], dgva[3], dgva[4], dgva[5], dgva[6], dgva[7], dgva[8], dgva[9], dgva[10], decimal.Parse(uc_txtafsBefore.Text),
                    decimal.Parse(uc_txtafsafter.Text), decimal.Parse(uc_txtvolatile.Text), decimal.Parse(uc_txtburning.Text), decimal.Parse(uc_txtglay.Text),
                              decimal.Parse(uc_txtbentnite.Text), decimal.Parse(uc_txtpermeability.Text), BLL.authentication.x_, true, uc_txtComment.Text,(int)uc_cmbAutoGenGroup.SelectedValue);
                MessageBox.Show("ارسال با موفقیت انجام شد.");                
            }
            else
            {
                css.UpdateSandWeeklyTest(x_, uc_mtxtDate1.Text, dgvs[0], dgvs[1], dgvs[2], dgvs[3], dgvs[4], dgvs[5], dgvs[6], dgvs[7], dgvs[8], dgvs[9], dgvs[10],
                    dgva[0], dgva[1], dgva[2], dgva[3], dgva[4], dgva[5], dgva[6], dgva[7], dgva[8], dgva[9], dgva[10], decimal.Parse(uc_txtafsBefore.Text),
                    decimal.Parse(uc_txtafsafter.Text), decimal.Parse(uc_txtvolatile.Text), decimal.Parse(uc_txtburning.Text), decimal.Parse(uc_txtglay.Text),
                              decimal.Parse(uc_txtbentnite.Text), decimal.Parse(uc_txtpermeability.Text), uc_txtComment.Text, (int)uc_cmbAutoGenGroup.SelectedValue);
                MessageBox.Show("ارسال با موفقیت انجام شد.");
                this.Close();
            }
            
        }

        private void uc_Chart1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filldatagirdView_ASTM();
        }

        DAL.Sand.DataSet_SandWeeklyTest.mSandWeeklyTestRow dr_W;

        private void FillForm()
        {
            if (x_ > 0)
            {
                BLL.csSand cs = new BLL.csSand();
                dr_W = cs.SelectSandWeeklyTestByX_(x_);
                
                for (int i = 1; i < 12; i++)
                {
                    dataGridView_Sieve[i, 0].Value = dr_W[i + 1];
                }
                for (int i = 1; i < 12; i++)
                {
                    dataGridView_Sieve[i, 1].Value = dr_W[i + 12];
                }
                uc_mtxtDate1.Text = dr_W["xDate"].ToString();
                uc_txtafsafter.Text = dr_W["xAfsAfter"].ToString();
                uc_txtafsBefore.Text = dr_W["xAfsBefore"].ToString();
                uc_txtbentnite.Text = dr_W["xActiveBentnitePercent"].ToString();
                uc_txtburning.Text = dr_W["xBurningPercent"].ToString();
                uc_txtComment.Text = dr_W["xComment"].ToString();
                uc_txtglay.Text = dr_W["xGlayPercent"].ToString();
                uc_txtpermeability.Text = dr_W["xPermeability"].ToString();
                uc_txtvolatile.Text = dr_W["xVolatilePercent"].ToString();

                uc_cmbAutoGenGroup.SelectedValue = dr_W["xGenGroup_"];
                CalcDataGridView_Sieve();
                filldatagirdView_ASTM();
                button1_Click(null, null);
            }
        }

        private void frmSandWeeklyTest_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void dataGridView_Sieve_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView_ASTM.SelectedCells;

        }

    }
}
