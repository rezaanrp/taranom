using System;
using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_DataGridViewBtn : UserControl
    {
        public uc_DataGridViewBtn()
        {
            InitializeComponent();
        }

        public string[] ParamName;
        public string[] ParamValue;
        public string[] ParamHide;
        public string ColumnsFilter_;
        public string ResultValue = "";
        public string ResultDisplay = "";
        /// <summary>
        /// DatagridView ROW INDEX
        /// </summary>
        public int RI = -1;
        /// <summary>
        /// DatagridView Columns Index
        /// </summary>
        public int CI = -1;
        public DataTable Ds;
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            ControlLibrary.uc_SearchData uc = new ControlLibrary.uc_SearchData();

            uc.ColumnFilter = ColumnsFilter_;
            if (ParamName.Length == ParamValue.Length)
                for (int i = 0; i < ParamName.Length; i++)
                {
                    uc.DataGridViewHeaderText(ParamName[i], ParamValue[i]);

                }
            for (int i = 0; i < ParamHide.Length; i++)
            {
                uc.DataGridViewClmHide(ParamHide[i]);
            }

            uc.GenDataGridView(Ds);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.Controls.Add(uc);
            frm.Size = uc.Size;
            frm.Height += 30;
            frm.Width += 30;
            frm.StartPosition = FormStartPosition.CenterParent;

            //frm.SetDesktopLocation(this.Location.X - frm.Width, this.Location.Y + 10);
            uc.Dock = DockStyle.Fill;
            frm.ShowDialog();

            ResultDisplay = uc.ResultName;
            ResultValue = uc.ResultID;
            uc.Dispose();
            frm.Dispose();
            userFunctionPointer.DynamicInvoke(ResultDisplay,ResultValue);
        }
        public Delegate userFunctionPointer;


    }
}
