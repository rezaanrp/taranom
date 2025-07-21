using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_GridView : UserControl
    {
        public uc_GridView()
        {
            InitializeComponent();

            bindingSource1.DataSource = dt_Object;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }
        public DataTable dt_Object = new DataTable("Object");
       
    }
}
