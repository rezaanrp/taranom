using System.Windows.Forms;

namespace Payazob
{
    public partial class frmProductInspectionView : Form
    {
        public frmProductInspectionView()
        {
            InitializeComponent();

            BLL.csDefect cs = new BLL.csDefect();



            dt_I = cs.SelectPruductInspectionByDate("1", "99999999999999999");
            //dt_D = cs.SelectMaterialOfFoundryByxFoundry_(-1);

            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;

        }

        DAL.DataSet_Defect.SelectPruductInspectionByDateDataTable dt_I;

    }
}
