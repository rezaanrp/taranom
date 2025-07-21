using System.ComponentModel;

namespace ControlLibrary
{
    public partial class uc_bindingNavigator : System.Windows.Forms.BindingNavigator
    {
        public uc_bindingNavigator()
        {
            InitializeComponent();

        }

        public uc_bindingNavigator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
