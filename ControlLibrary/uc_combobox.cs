using System.Drawing;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_combobox : UserControl
    {
        public uc_combobox()
        {
            InitializeComponent();
            base.Size = comboBox1.Size;
        }

        public Size  ucSize
        {
            get { return base.Size; }
            set { comboBox1.Size = base.Size = value; }
        }

        public object SelectedValue
        {
            get { return comboBox1.SelectedValue; }
            set { comboBox1.SelectedValue =value; }
        }
        public int SelectedIndex
        {
            get { return (int)comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }
        public string SelectedText
        {
            get { return comboBox1.SelectedText; }
            set { comboBox1.SelectedText = value; }
        }
        //public string Text
        //{
        //    get { return comboBox1.Text; }
        //    set { comboBox1.Text = value; }
        //}
        public string DisplayMember
        {
            get { return comboBox1.DisplayMember; }
            set { comboBox1.DisplayMember = value; }
        }
        public string ValueMember
        {
            get { return comboBox1.ValueMember; }
            set { comboBox1.ValueMember = value; }
        }
        public object DataSource
        {
            get { return comboBox1.DataSource; }
            set { comboBox1.DataSource = value; }
        }
    }
}
