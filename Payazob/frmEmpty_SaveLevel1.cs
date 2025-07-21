using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmEmpty_SaveLevel1 : Form
    {
        public frmEmpty_SaveLevel1(string FormName,bool _Add,bool _Edit,bool _Del, CS.csEnum.Factory FCT)
        {
            InitializeComponent();

            fct_ = (int)FCT;
            frmName = FormName;

            dataGridView1.AllowUserToAddRows = _Add;
            bindingNavigatorAddNewItem.Enabled = _Add;

            dataGridView1.AllowUserToDeleteRows = _Del;
            bindingNavigatorDeleteItem.Enabled = _Del;

            dataGridView1.ReadOnly = !_Edit;
            saveToolStripButton.Enabled = _Edit;
            
        }
        int fct_;
        private Stack<string> stackVisibleParamName = new Stack<string>();
        private Stack<bool> stackVisibleParamValue = new Stack<bool>();
        private Stack<bool> stackReadOnlyParamValue = new Stack<bool>();
        private Stack<int> stackWidthParamValue = new Stack<int>();

        public void SetParam(string Name, bool Visible_Value, bool ReadOnly_Value, int weight_Value)
        {
            stackVisibleParamName.Push(Name);
            stackVisibleParamValue.Push(Visible_Value);
            stackReadOnlyParamValue.Push(ReadOnly_Value);
            stackWidthParamValue.Push(weight_Value);
        }

        private string frmName;
        DAL.DataSet_Shift.mShiftDataTable dt_Shift;
        DAL.Object.DataSet_Object.mObjectListDataTable dt_Object;

        private bool Show_Form(string Name)
        {
            switch (Name)
            {


                case "RegShift":
                     BLL.csShift cs = new BLL.csShift();
                     dt_Shift = cs.mShift();
                     bindingSource1.DataSource = dt_Shift;
                     dataGridView1.DataSource = bindingSource1;
                     bindingNavigator1.BindingSource = bindingSource1;
                     Generate(dt_Shift);
                break;
                case "ObjectListEditName":
                        dt_Object = new BLL.Object.csObject().mObjectList();        
                        bindingSource1.DataSource = dt_Object;
                        dataGridView1.DataSource = bindingSource1;
                        bindingNavigator1.BindingSource = bindingSource1;
                        Generate(dt_Object);
                break;

            }
            return true;
        }

        void Generate(DataTable dt)
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            while (stackVisibleParamName.Count > 0)
            {
                string ColumnName = stackVisibleParamName.Pop();
                dataGridView1.Columns[ColumnName].Visible = stackVisibleParamValue.Pop();
                dataGridView1.Columns[ColumnName].ReadOnly = stackReadOnlyParamValue.Pop();
                dataGridView1.Columns[ColumnName].Width = stackWidthParamValue.Pop();
            }
        }

        private bool Save_adp(string Name)
        {
            this.Validate();
            dataGridView1.EndEdit();
            switch (Name)
            {

                case "RegShift":
                    BLL.csShift cs = new BLL.csShift();
                    MessageBox.Show(cs.UdShift(dt_Shift), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Show_Form("RegShift");
                break;
                case "ObjectListEditName":
                
                MessageBox.Show( new BLL.Object.csObject().UdmObjectList(dt_Object), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show_Form("ObjectListEditName");
                break;
            }
            return true;
        }
        private void frmEmpty_SaveLevel1_Load(object sender, EventArgs e)
        {
            Show_Form(frmName);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Save_adp(frmName);
        }
    }
}
