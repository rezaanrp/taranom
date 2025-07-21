using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Blance
{
    public partial class frmBalance : Form
    {
        public frmBalance(DataTable dt_BGV)
        {
            dt_G = dt_BGV;
            InitializeComponent();
            bindingSource1.DataSource = dt_G;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

            label1.Text = " موجودی ابتدای دوره قطعات سال " + Properties.Settings.Default.WorkYear.Substring(2, 2);
        }
        DataTable dt_G;
        public void GenComboBoxToDataGridView( DataTable dt,int  DisplayIndex_ ,string  HeaderText_ ,string  DataSource_ ,string  DisplayMember_ ,
         string  ValueMember_ ,string  Name_,int  Width_,int  MinimumWidth_,string  DataPropertyName_ )
        {
            DataGridViewComboBoxColumn combobox_ = new DataGridViewComboBoxColumn();
            combobox_.DisplayIndex = DisplayIndex_;
            combobox_.HeaderText = HeaderText_;
            combobox_.DataSource = dt;
            combobox_.DisplayMember = DisplayMember_;
            combobox_.ValueMember = ValueMember_;
            combobox_.Name = Name_;
            combobox_.Width = Width_;
            combobox_.MinimumWidth = MinimumWidth_;
            combobox_.DataPropertyName = DataPropertyName_;
            combobox_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_.MaxDropDownItems = 20;

            dataGridView1.Columns.Add(combobox_);

        }
        void Generate()
        {
            bindingSource1.DataSource = dt_G;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }
        //public System.Data.DataTable SaveData(string st)
        //{
        //    //System.Data.DataTable dt;
        //    //switch (st)
        //    //{
        //    //    case "BalanceBeginingPiecesTurning":
        //    //        new BLL.BalanceBeginning.csBalanceBeginnig().UdBalanceBeginingPiecesTurning(dt_G);
        //    //      break;
        //    //    default:
        //    //        dt = new System.Data.DataTable();
        //    //      break;
        //    //}
        //    //return dt;
        //}
        public string DateFrom;
        public string DateTo;
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.EndEdit();
            //this.Validate();
            //if (new CS.csMessage().ShowMessageSaveYesNo())
            //{

            //    MessageBox.Show("");

            //    dt_G = cs.SlBalanceBeginningPieces(Properties.Settings.Default.WorkYear);

            //  //  dt_G.xDateColumn.DefaultValue = Properties.Settings.Default.WorkYear;

            //    bindingSource1.DataSource = dt_G;
            //    dataGridView1.DataSource = bindingSource1;
            //    bindingNavigator1.BindingSource = bindingSource1;

            //}
        }
    }
}
