using System;
using System.Windows.Forms;

namespace Payazob.FRM.Poem
{
    public partial class frmPoem : Form
    {
        public frmPoem()
        {
            InitializeComponent();
            ShowData();
        }
        DAL.Poem.DataSet_Poem.SlPoemListDataTable dt_C;

        void SaveDataGridView1()
        {
            this.Validate();
            dataGridView1.EndEdit();
            CS.csMessage cm = new CS.csMessage();
            if (cm.ShowMessageSaveYesNo())
            {
                BLL.Poem.csPoem cs = new BLL.Poem.csPoem();

                    cs.UdPoem(dt_C);
                    ShowData();
            }


        }
        private void ShowData()
        {
            BLL.Poem.csPoem cs = new BLL.Poem.csPoem();

            dt_C = cs.SlPoemList();

            bindingSource1.DataSource = dt_C;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.Columns["xText"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView1();
        }
    }
}
