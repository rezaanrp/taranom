using System;
using System.Windows.Forms;

namespace Payazob.FRM.Tools
{
    public partial class frmTools : Form
    {
        public frmTools(CS.csEnum.MaterilaType materilaType)
        {
            InitializeComponent();
            mt_ = materilaType;

            BLL.csMaterial csmt = new BLL.csMaterial();
            dt_P = csmt.SlMaterial("#",(int) mt_);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            //DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            //combobox_Type_.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("TYPMA");
            //combobox_Type_.DisplayMember = "xName";
            //combobox_Type_.HeaderText = "نوع";
            //combobox_Type_.ValueMember = "x_";
            //combobox_Type_.DataPropertyName = "xGenType_";
            //combobox_Type_.Name = "cmb_xType_";
            //combobox_Type_.Width = 100;
            //// combobox_Type_.DisplayIndex = 5;
            //combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            //dataGridView1.Columns.Add(combobox_Type_);



            DataGridViewComboBoxColumn combobox_Module = new DataGridViewComboBoxColumn();
            combobox_Module.HeaderText = "واحد";
            combobox_Module.DataSource = csmt.SlModule();
            combobox_Module.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_Module.DisplayMember = "xModuleName";
            combobox_Module.ValueMember = "x_";
            combobox_Module.DataPropertyName = "xModule_";
            combobox_Module.Name = "cmb_xModule";
            combobox_Module.MaxDropDownItems = 30;
             combobox_Module.DisplayIndex = 4;
            dataGridView1.Columns.Add(combobox_Module);



            Generate();
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xGenType_Column.DefaultValue = mt_;
        }
        DAL.DataSet_Material.SlMaterialDataTable dt_P;
        CS.csEnum.MaterilaType mt_;
        private void frmTools_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.csMaterial css = new BLL.csMaterial();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdMaterial(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csMaterial csmt = new BLL.csMaterial();
            dt_P = csmt.SlMaterial("#",(int) mt_);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            Generate();
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xGenType_Column.DefaultValue = mt_;
        }
        void Generate()
        {

            dataGridView1.Columns["xType"].Visible = false;
            dataGridView1.Columns["xModule_"].Visible = false;
            dataGridView1.Columns["Module"].Visible = false;
            //dataGridView1.Columns["MaterialName"].Visible = false;
            dataGridView1.Columns["xMaterialName"].HeaderText = "نام";
            dataGridView1.Columns["xConditionMaintenance"].Visible = false;
         dataGridView1.Columns["xFeature"].Visible =false;
         dataGridView1.Columns["xAcceptCriteria"].Visible = false;
            dataGridView1.Columns["xControlTools"].Visible = false;
            dataGridView1.Columns["xSupplier"].HeaderText = "ویرایش کننده";
            dataGridView1.Columns["xSupplier"].DisplayIndex = 11;
            dataGridView1.Columns["xDateEdit"].HeaderText = "تاریخ ویرایش ";
            dataGridView1.Columns["xDateEdit"].DisplayIndex = 11;
            dataGridView1.Columns["xStandardINV"].Visible  = false;
            dataGridView1.Columns["xSerial"].HeaderText = "کد در همکاران";
            dataGridView1.Columns["xSerial"].DisplayIndex = 5;


            dataGridView1.Columns["xMaterialName"].Width = 300;
            dataGridView1.Columns["x_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["x_"].HeaderText = "سریال";
            dataGridView1.Columns["xGenType_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int Ri = dataGridView1.SelectedCells[0].RowIndex;
                if (dataGridView1.Rows[Ri].Cells["xMaterialName"].Value != null)
                    lbl_Comment.Text = dataGridView1.Rows[Ri].Cells["xMaterialName"].Value.ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

    }
}
