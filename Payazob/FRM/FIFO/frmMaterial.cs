using System;
using System.Windows.Forms;

namespace Payazob.FRM.FIFO
{
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();


            BLL.csMaterial csmt = new BLL.csMaterial();
            dt_P = csmt.SlMaterial("A",0);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("TYPMA");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "نوع";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGenType_";
            combobox_Type_.Name = "cmb_xType_";
            combobox_Type_.Width = 100;
           // combobox_Type_.DisplayIndex = 5;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Type_);


            cmb_filter.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("TYPMA");
            cmb_filter.DisplayMember = "xName";
            cmb_filter.ValueMember = "x_";
            cmb_filter.Name = "cmb_xType_";

            DataGridViewComboBoxColumn combobox_Module = new DataGridViewComboBoxColumn();
            combobox_Module.HeaderText = "واحد";
            combobox_Module.DataSource = csmt.SlModule();
            combobox_Module.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_Module.DisplayMember = "xModuleName";
            combobox_Module.ValueMember = "x_";
            combobox_Module.DataPropertyName = "xModule_";
            combobox_Module.Name = "cmb_xModule";
            combobox_Module.MaxDropDownItems = 30;
           // combobox_Module.DisplayIndex = 6;
            dataGridView1.Columns.Add(combobox_Module);



            Generate();
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            cmb_filter.SelectedIndex = -1;
            chk_cmb_filter = true;
        }


        DAL.DataSet_Material.SlMaterialDataTable dt_P;

        void Generate()
        {

            dataGridView1.Columns["xType"].Visible = false;
            dataGridView1.Columns["xModule_"].Visible = false;
            dataGridView1.Columns["Module"].Visible = false;
            //dataGridView1.Columns["MaterialName"].Visible = false;
            dataGridView1.Columns["xMaterialName"].HeaderText = "نام";
            dataGridView1.Columns["xConditionMaintenance"].HeaderText = "شرایط نگهداری";
            dataGridView1.Columns["xFeature"].HeaderText = "خصوصیات";
            dataGridView1.Columns["xAcceptCriteria"].HeaderText = "معیار پذیرش";
            dataGridView1.Columns["xControlTools"].HeaderText = "ابزار کنترل";
            dataGridView1.Columns["xSupplier"].HeaderText = "ویرایش کننده";
            dataGridView1.Columns["xSupplier"].DisplayIndex = 11;
            dataGridView1.Columns["xDateEdit"].HeaderText = "تاریخ ویرایش ";
            dataGridView1.Columns["xDateEdit"].DisplayIndex = 11;
            dataGridView1.Columns["xStandardINV"].HeaderText = "موجودی استاندارد";


            dataGridView1.Columns["xMaterialName"].Width = 300;
            dataGridView1.Columns["x_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["x_"].HeaderText = "سریال";
            dataGridView1.Columns["xGenType_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.csMaterial css = new BLL.csMaterial();
            if(new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show( css.UdMaterial(dt_P),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
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
                        (itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text) ||
                         itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ی', 'ي')) ||
                          itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ي', 'ی')) ||
                           itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ک', 'ك')) ||
                            itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ك', 'ک')))
                        )
                    {
                        item.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = item.Index > 1 ? item.Index - 2 : item.Index;
                        return;
                    }


                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1 && e.ColumnIndex > -1)
            //    if (dataGridView1["xMaterialName", e.RowIndex].Value != null)
            //        lbl_Comment.Text = dataGridView1["xMaterialName", e.RowIndex].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells["xMaterialName"].Value != null)
                    lbl_Comment.Text = dataGridView1.SelectedRows[0].Cells["xMaterialName"].Value.ToString();
            }
            else if (dataGridView1.SelectedCells.Count > 0)
            {
                if (dataGridView1.SelectedCells[0].Value != null && dataGridView1.SelectedCells[0].ColumnIndex != dataGridView1.Columns["cmb_xType_"].Index && dataGridView1.SelectedCells[0].ColumnIndex != dataGridView1.Columns["cmb_xModule"].Index)
                    lbl_Comment.Text = dataGridView1.SelectedCells[0].Value.ToString();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
             
                {
                    dataGridView1["xSupplier_", e.RowIndex].Value = BLL.authentication.x_;
                  //  dataGridView1["xDateEdit", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }

        }
        bool chk_cmb_filter = false;
        private void cmb_filter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chk_cmb_filter)
            {
                BLL.csMaterial csmt = new BLL.csMaterial();
                dt_P = csmt.SlMaterial("$", (int)cmb_filter.SelectedValue);
                bindingSource1.DataSource = dt_P;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;


                Generate();
                dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            }
        }

    }
}
