using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Payazob.FRM.SectionAid
{
    public partial class frmSectionAid : Form
    {
        public frmSectionAid()
        {
            InitializeComponent();
            
        }
        AwModelData.Aid.PayazobEntities1 contex;
        private void btn_Show_Click(object sender, EventArgs e)
        {

        }

        private void frmSectionAid_Load(object sender, EventArgs e)
        {
            contex = new AwModelData.Aid.PayazobEntities1();
            var query = contex.mSectionAids;
            mSectionAidBindingSource.DataSource = query.ToList();
            dvgCmbGenGroup.DataSource = from c in contex.mGenGroups where c.xType == "SEC" select c;
            dvgCmbGenGroup.DisplayMember = "xName";
            dvgCmbGenGroup.ValueMember = "x_";
        }

        private void mSectionAidBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            mSectionAidDataGridView.EndEdit();
            contex.SaveChanges();
        }
    }
}
