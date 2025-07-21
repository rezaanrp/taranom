using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class CustomToolTip : UserControl
    {
        public CustomToolTip()
        {
            InitializeComponent();
        }

        public string PopUpComment
        {
            get { 
                return label1.Text;

                  }

            set { 
                
                label1.Text = value;
               
            }
        }
        
    }
}
