using System;
using System.ComponentModel;

namespace ControlLibrary
{
    public partial class uc_btn : System.Windows.Forms.Button
    {
        public uc_btn()
        {
            InitializeComponent();
            MseLeaveColor = this.BackColor;
        }

        private System.Drawing.Color MseEnterColor ;

        public System.Drawing.Color MouseEnterColor
        {
            get { return MseEnterColor; }
            set { MseEnterColor = value; }
        }

        private System.Drawing.Color MseLeaveColor;

        public System.Drawing.Color MouseLeaveColor
        {
            get { return MseLeaveColor; }
            set { MseLeaveColor = value; }
        }
        
        public uc_btn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnMouseEnter(EventArgs e)
        {

            this.BackColor = MseEnterColor.IsEmpty ? System.Drawing.Color.Orange : MseEnterColor;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = MseLeaveColor;

            base.OnMouseLeave(e);
        }
    }
}
