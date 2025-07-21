using System;
using System.Windows.Forms;

namespace Payazob.FRM.ProductInspection
{
    public partial class frmScrabUsage : Form
    {
        public frmScrabUsage()
        {
            InitializeComponent();
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowDate();
        }
        void ShowDate()
        {
            BLL.ScrabUsage.ScrabUsage cs = new BLL.ScrabUsage.ScrabUsage();
            bindingSource1.DataSource = cs.SlScrabUsage(uc_Filter_Date1.DateFrom,
                                                        uc_Filter_Date1.DateTo,
                                                        double.Parse(uc_txtBoxWaset.Text == "" ? "0" : uc_txtBoxWaset.Text),
                                                        double.Parse(uc_txtBoxFerro.Text == "" ? "0" : uc_txtBoxFerro.Text), 
                                                        Payazob.Properties.Settings.Default.WorkYear);
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void Generate()
        {
            dataGridView1.Columns["BeginningOfPeriod"].HeaderText = "ابتدای دوره";
            dataGridView1.Columns["EndOfPeriod"].HeaderText = "مقدار وارده طی دوره";
            dataGridView1.Columns["DefectPercent"].HeaderText = "درصد ضایعات";
            dataGridView1.Columns["PiecesWeight"].HeaderText = "کیلوگرم محصول تولید شده";
            dataGridView1.Columns["GrossProduction"].HeaderText = "مقدار خالص قراضه مصرفی طی دوره";
            dataGridView1.Columns["PredictScrab"].HeaderText = "مقدار پیش بینی قراضه آخر دوره";

            dataGridView1.Columns["DefectPercent"].DefaultCellStyle.Format = "N2";
        }
    }
}
