using System.Windows.Forms;
using System.ComponentModel;

namespace ControlLibrary
{
    public class uc_cmbAuto : System.Windows.Forms.ComboBox
    {
        public event System.ComponentModel.CancelEventHandler NotInList;

        private bool _limitToList = true;
        private bool _inEditMode = false;

       
        public uc_cmbAuto()
            : base()
        {
            this.DropDownWidth = 180;
        }


        [Category("Behavior")]
        public bool LimitToList
        {
            get { return _limitToList; }
            set { _limitToList = value; }
        }

        public bool ISInTheList()
        {
                return this.SelectedIndex > -1;
        }
        protected virtual void OnNotInList(System.ComponentModel.CancelEventArgs e)
        {
            if (NotInList != null)
            {
                NotInList(this, e);
            }
        }   
        
        protected override void OnTextChanged(System.EventArgs e)
        {
            if (_inEditMode)
            {
                string input = Text;
                int index = FindString(input);
                if (Text != "")
                {
                    if (index >= 0)
                    {
                        _inEditMode = false;
                        SelectedIndex = index;
                        _inEditMode = true;
                        Select(input.Length, Text.Length);
                    }
                }
                else
                    SelectedIndex = -1;
                

            }

            base.OnTextChanged(e);
        }

        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            if (this.LimitToList)
            {
                int pos = this.FindStringExact(this.Text);

                if (pos == -1)
                {
                    OnNotInList(e);
                }
                else
                {
                    this.SelectedIndex = pos;
                }
            }

            base.OnValidating(e);
        }

        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            _inEditMode = (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete);
            base.OnKeyDown(e);
        }
       
    }
}