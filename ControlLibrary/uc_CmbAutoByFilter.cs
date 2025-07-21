using System;
using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_CmbAutoByFilter : UserControl
    {
        public uc_CmbAutoByFilter()
        {
            InitializeComponent();
        }
        public string[] ParamName;
        public string[] ParamValue;
        public string[] ParamHide;

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            ControlLibrary.uc_SearchData uc = new ControlLibrary.uc_SearchData();
            uc.ColumnFilter = uc_cmbAuto1.DisplayMember;

            if(ParamName.Length == ParamValue.Length)
                for (int i = 0; i < ParamName.Length; i++)
                {
                    uc.DataGridViewHeaderText(ParamName[i], ParamValue[i]);
                
                }
            for (int i = 0; i < ParamHide.Length; i++)
            {
                uc.DataGridViewClmHide(ParamHide[i]);
            }

            uc.GenDataGridView((DataTable)uc_cmbAuto1.DataSource);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.Controls.Add(uc); 
            frm.Size = uc.Size;
            frm.Height += 30;
            frm.Width += 30;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MaximizeBox = false;
            //frm. = false;

            frm.SetDesktopLocation(Cursor.Position.X - 230, Cursor.Position.Y+10);
            uc.Dock = DockStyle.Fill;
             frm.ShowDialog();

           // frm.ShowDialog();
            uc_cmbAuto1.Text = uc.ResultName;
            uc.Dispose();
            frm.Dispose();
        }

    }
}
