using System;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_PanelBox : UserControl
    {
        public uc_PanelBox()
        {
            InitializeComponent();

        }

        public Control PanelContainer
        {
            set {splitContainer1.Panel1.Controls.Add(value); }
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
//            this.Hide();
            this.ParentForm.DialogResult = DialogResult.OK;

        }

    }
}
