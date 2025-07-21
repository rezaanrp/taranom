using System.Windows.Forms;

namespace Payazob.MyControl
{
    public partial class CustomToolTip : UserControl
    {
        public CustomToolTip()
        {
            InitializeComponent();
        }

        public string PopUpComment
        {
            get { return label1.Text; }

            set { label1.Text = value; }
        }
        
    }
}
