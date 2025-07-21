using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Aid
{
    public partial class frmSectionAidSearch : Form
    {
        public frmSectionAidSearch()
        {
            InitializeComponent();

        }
        private Stack<string> stackVisibleParamName = new Stack<string>();
        private Stack<bool> stackVisibleParamValue = new Stack<bool>();
        public void SetParam(string Name, bool Value)
        {
            stackVisibleParamName.Push(Name);
            stackVisibleParamValue.Push(Value);
        }
        public DataTable MyDatatable
        {
            get { return dt_A; }

            set {

           dt_A = value;
           bindingSource1.DataSource = dt_A;
           dataGridView1.DataSource = bindingSource1;

           CS.csDic css = new CS.csDic();

           foreach (DataColumn dc in dt_A.Columns)
           {
  dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
           }
           while (stackVisibleParamName.Count > 0)
           {
  dataGridView1.Columns[stackVisibleParamName.Pop()].Visible = stackVisibleParamValue.Pop();
           }

  }
        }
        
       public DataTable dt_A;
    }
}
