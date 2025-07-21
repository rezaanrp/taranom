using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmAccessRights : Form
    {
        public frmAccessRights()
        {
            InitializeComponent();
            BLL.User cs= new BLL.User();
            uc_CmbAutoByFilter1.uc_cmbAuto1.DataSource = cs.SelectUserPorfile();
            uc_CmbAutoByFilter1.uc_cmbAuto1.DisplayMember = "Family";
            uc_CmbAutoByFilter1.uc_cmbAuto1.ValueMember = "x_";
            uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;

            uc_CmbAutoByFilter1.ParamName = new string[] { "Family", "xUserName", "SectionName" };
            uc_CmbAutoByFilter1.ParamValue = new string[] { "نام", "نام کاربری", "نام قسمت" };
            uc_CmbAutoByFilter1.ParamHide = new string[] { "x_", "xSection_" };

            DataGridViewCheckBoxColumn cl = new DataGridViewCheckBoxColumn();
            cl.Name = "Access";
            cl.HeaderText = "دسترسی";
            dataGridView1.Columns.Add(cl);
            cl.Visible = false;

        }
       
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedValue == null)
                return;
            BLL.authentication cs = new BLL.authentication();
            if (rdb_Group.Checked)
            {
                xuser = null;
                xgroup = (int?)uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedValue;
                dataGridView1.DataSource = cs.SelectObjectUserCanAccessOrNot(xuser,xgroup);
            }
            else
            {
                xgroup = null;
                xuser = (int?)uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedValue;
                dataGridView1.DataSource = cs.SlObjectUserAccess(xuser);
            }

            


            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["Access"].Value = item.Cells["IsAllow"].Value;
            }

            dataGridView1.Columns["Access"].DisplayIndex = 3;
            dataGridView1.Columns["xObjectname"].HeaderText = "نام انگلیسی";
            dataGridView1.Columns["xObjectFarsiName"].HeaderText = "نام فارسی";
            dataGridView1.Columns["TypeObj"].HeaderText = "نوع فرم";

            

            dataGridView1.Columns["Access"].Visible = true;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["IsAllow"].Visible = false;

        }

        private void rdb_User_CheckedChanged(object sender, EventArgs e)
        {
            BLL.User cs = new BLL.User();


            if (rdb_Group.Checked)
            {
                uc_CmbAutoByFilter1.uc_cmbAuto1.DataSource = cs.SelectGroup();
                uc_CmbAutoByFilter1.uc_cmbAuto1.DisplayMember = "xGroupName";
                uc_CmbAutoByFilter1.uc_cmbAuto1.ValueMember = "x_";
                uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;

                uc_CmbAutoByFilter1.ParamName = new string[] { "xGroupName" };
                uc_CmbAutoByFilter1.ParamValue = new string[] { "نام گروه" };
                uc_CmbAutoByFilter1.ParamHide = new string[] { "x_" };
                xuser = null;
            }
            else
            {
                uc_CmbAutoByFilter1.uc_cmbAuto1.DataSource = cs.SelectUserPorfile();
                uc_CmbAutoByFilter1.uc_cmbAuto1.DisplayMember = "Family";
                uc_CmbAutoByFilter1.uc_cmbAuto1.ValueMember = "x_";
                uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedIndex = -1;

                uc_CmbAutoByFilter1.ParamName = new string[] { "Family", "xUserName", "SectionName" };
                uc_CmbAutoByFilter1.ParamValue = new string[] { "نام", "نام کاربری", "نام قسمت" };
                uc_CmbAutoByFilter1.ParamHide = new string[] { "x_", "xSection_" };
                xgroup = null;
            }

        }
        int? xuser;
        int? xgroup;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            CS.csMessage csm = new CS.csMessage();
            if (csm.ShowMessageSaveYesNo())
            {
                if (rdb_Group.Checked)
                {
                    xuser = null;
                    xgroup = (int?)uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedValue;
                }
                else
                {
                    xgroup = null;
                    xuser = (int?)uc_CmbAutoByFilter1.uc_cmbAuto1.SelectedValue;
                }
                BLL.authentication cs = new BLL.authentication();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((bool)item.Cells["Access"].Value ^ (bool)item.Cells["IsAllow"].Value)
                    {
                        if ((bool)item.Cells["Access"].Value)
                        {
                            cs.InsertAuthentication(xuser, xgroup, (int)item.Cells["x_"].Value);
                        }
                        else
                        {
                            cs.DeleteAuthentication(xuser, xgroup, (int)item.Cells["x_"].Value);
                        }
                    }
                }
                //this.Close();
            }
        }

        private void uc_txtBoxSearch_TextChanged(object sender, EventArgs e)
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
                        (itemCell.FormattedValue.ToString().Contains(uc_txtBoxSearch.Text) ||
                         itemCell.FormattedValue.ToString().Contains(uc_txtBoxSearch.Text.Replace('ی', 'ي')) ||
                          itemCell.FormattedValue.ToString().Contains(uc_txtBoxSearch.Text.Replace('ي', 'ی')) ||
                           itemCell.FormattedValue.ToString().Contains(uc_txtBoxSearch.Text.Replace('ک', 'ك')) ||
                            itemCell.FormattedValue.ToString().Contains(uc_txtBoxSearch.Text.Replace('ك', 'ک')))
                        )
                    {
                        item.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = item.Index > 1 ? item.Index - 2 : item.Index;
                        return;
                    }


                }
            }
        }
    }
}
