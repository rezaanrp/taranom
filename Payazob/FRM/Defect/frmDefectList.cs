using System;
using System.Windows.Forms;

namespace Payazob.FRM.Defect
{
    public partial class frmDefectList : Form
    {
        public frmDefectList()
        {
            InitializeComponent();

            BLL.Defect.csDefect css = new BLL.Defect.csDefect();
            dt_D = css.mDefectList();
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void Generate()
        {
            dataGridView1.Columns["xDefectName"].Width = 300;
            dataGridView1.Columns["xDefectName"].HeaderText = "نام ضایع";
            dataGridView1.Columns["xDefectActive"].HeaderText = "فعال باشد؟";
            dataGridView1.Columns["x_"].Visible= false;
        }
        DAL.Defect.DataSet_DefectList.mDefectListDataTable dt_D;

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();

            BLL.Defect.csDefect css = new BLL.Defect.csDefect();

            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdDefectList(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dt_D = css.mDefectList();
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
      
    }
}
