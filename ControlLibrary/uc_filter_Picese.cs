using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_filter_Picese : UserControl
    {
        public uc_filter_Picese()
        {
            InitializeComponent();
            uc_cmbAuto.DataSource = DataSource;
            uc_cmbAuto.ValueMember = ValueMember;
            uc_cmbAuto.DisplayMember = DisplayMember;
            uc_cmbAuto.SelectedIndex = SelectedIndex;
        }
        private int position;
        public int SelectedIndex
        {
            get { return uc_cmbAuto.SelectedIndex; }
            set { uc_cmbAuto.SelectedIndex = value; }
        }

        public string DisplayMember
        {
            get { return uc_cmbAuto.DisplayMember; }
            set { uc_cmbAuto.DisplayMember = value; }
        }
        public string ValueMember
        {
            get { return uc_cmbAuto.ValueMember; }
            set { uc_cmbAuto.ValueMember = value; }
        }
        public DataTable DataSource
        {
            get {
                return (DataTable)uc_cmbAuto.DataSource;
                }
            set {
                dtb = value;
                uc_cmbAuto.DataSource = value; 
                }
        }

        public string[] uc_value
        {
            get
            {
                string[] st = new string[stack.Count + 1];
                st[0] = uc_cmbAuto.Text;
                int count = stack.Count;
                for (int i = 1; i < count + 1; i++)
                {
                    ControlLibrary.uc_cmbAuto uc = stack.Pop();
                    st[i] = uc.Text;
                    panel1.Controls.Remove(uc);
                    position -= uc_cmbAuto.Size.Height;
                }
                return st;
            }
        }



        private DataTable dtb;
        private Stack<ControlLibrary.uc_cmbAuto> stack = new Stack<ControlLibrary.uc_cmbAuto>();

        private void btn_and_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                ControlLibrary.uc_cmbAuto u = stack.Peek();
                position = uc_cmbAuto.Size.Height + u.Location.Y;
            }
            else
                position = uc_cmbAuto.Size.Height + uc_cmbAuto.Location.Y;

            ControlLibrary.uc_cmbAuto cmb_Goods = new ControlLibrary.uc_cmbAuto();
            cmb_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmb_Goods.FormattingEnabled = true;
            cmb_Goods.LimitToList = true;
            cmb_Goods.Location = new System.Drawing.Point(uc_cmbAuto.Location.X, position);
            cmb_Goods.Name = "cmb_Goods";
            cmb_Goods.Size = new System.Drawing.Size(112, 21);

            this.panel1.Controls.Add(cmb_Goods);

            DataTable dt =  dtb.Copy();
            cmb_Goods.DataSource = dt;
            cmb_Goods.ValueMember = ValueMember;
            cmb_Goods.DisplayMember = DisplayMember;
            cmb_Goods.SelectedIndex = -1;

            cmb_Goods.Focus();
            stack.Push(cmb_Goods);

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                panel1.Controls.Remove(stack.Pop());
                position -= uc_cmbAuto.Size.Height;
            }
        }
    }

}
