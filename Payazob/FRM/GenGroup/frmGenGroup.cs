using System;
using System.Windows.Forms;

namespace Payazob.FRM.GenGroup
{
    public partial class frmGenGroup : Form
    {
        public frmGenGroup(string Type_,bool ins ,bool upd,bool del,bool clName,bool clValue)
        {
            InitializeComponent();
            typ = Type_;

            bindingNavigatorAddNewItem.Enabled = dataGridView1.AllowUserToAddRows = ins;
            saveToolStripButton.Enabled = upd; dataGridView1.ReadOnly = !upd;
            bindingNavigatorDeleteItem.Enabled =  dataGridView1.AllowUserToDeleteRows = del;

            BLL.GenGroup.csGenGroup cs = new BLL.GenGroup.csGenGroup();
            dt_M = cs.mGenGroup(typ);
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_M.xTypeColumn.DefaultValue = typ;
            Generate(clName, clValue);
            clN = clName;
            clV = clValue;
        }
        DAL.GenGroup.DataSet_GenGroup.mGenGroupDataTable dt_M;
        string typ = "";
        bool clN = false; bool clV = false;
        void Generate(bool NameVisible ,bool ValueVisible)
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xType"].Visible = false;
            dataGridView1.Columns["xName"].HeaderText = "اسم";
            dataGridView1.Columns["xValue"].HeaderText = "مقدار";
            //dataGridView1.Columns["xValue"].Visible = "مقدار";
            //dataGridView1.Columns["xValue"].Visible = ValueVisible;
            dataGridView1.Columns["xName"].Visible = NameVisible;
            if (!ValueVisible)
                dataGridView1.Columns["xName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            else
            {
                dataGridView1.Columns["xName"].Width  = 250;
                dataGridView1.Columns["xValue"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.GenGroup.csGenGroup cs = new BLL.GenGroup.csGenGroup();

            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(cs.UdGenGroup(dt_M), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
