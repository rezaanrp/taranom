using System;
using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_RegisteringGroup : UserControl
    {
        public uc_RegisteringGroup()
        {
            InitializeComponent();
        }
        public string GroupAndName { get; set; }
        public bool supplier { get { return chb_supplierby.Checked; } set { chb_supplierby.Checked = value; } }
        public bool approve { get { return chb_approveby.Checked; } set { chb_approveby.Checked = value; } }
        public bool register { get { return chb_registerby.Checked; } set { chb_registerby.Checked = value; } }
        public bool supplierEnabled { get { return chb_supplierby.Enabled; } set { chb_supplierby.Enabled = value; } }
        public bool approveEnabled { get { return chb_approveby.Enabled; } set { chb_approveby.Enabled = value; } }
        public bool registerEnabled { get { return chb_registerby.Enabled; } set { chb_registerby.Enabled = value; } }
        public bool checkedchange = false;

        public void CheckCheakboxEnableDisable()
        {
            BLL.csRegisteringGroup re = new BLL.csRegisteringGroup();
            DataTable dt = re.SelectRegistringGroupAndName(-1, GroupAndName);
            chb_supplierby.Text = dt.Rows[0]["xSupplierby"].ToString();
            if (dt.Rows[0]["xSupplierby_"].ToString() == BLL.authentication.x_.ToString())
                chb_supplierby.Enabled = true;
             if (dt.Rows[0]["xSupplierby_"].ToString() == "")
            { chb_supplierby.Visible = false; }


            chb_approveby.Text = dt.Rows[0]["xApproveby"].ToString();
            if (dt.Rows[0]["xApproveby_"].ToString() == BLL.authentication.x_.ToString())
                chb_approveby.Enabled = true;
             if (dt.Rows[0]["xApproveby_"].ToString() == "")
            { chb_approveby.Visible = false; }


            chb_registerby.Text = dt.Rows[0]["xRegisterby"].ToString();
            if (dt.Rows[0]["xRegisterby_"].ToString() == BLL.authentication.x_.ToString())
                chb_registerby.Enabled = true;
             if (dt.Rows[0]["xRegisterby_"].ToString() == "")
            { chb_registerby.Visible = false; }
        }
        private void uc_RegisteringGroup_Load(object sender, EventArgs e)
        {
            CheckCheakboxEnableDisable();
        }

        private void chb_supplierby_CheckedChanged(object sender, EventArgs e)
        {
            checkedchange = true;
        }
    }
}
