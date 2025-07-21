using System;
using System.ComponentModel;

namespace ControlLibrary
{
    public partial class uc_lblFiled : System.Windows.Forms.Label
    {
        public uc_lblFiled()
        {
            InitializeComponent();
            this.MouseEnter += new EventHandler(uc_lblFiled_MouseEnter);
            this.MouseLeave += new EventHandler(uc_lblFiled_MouseLeave);
        }
        public int Value;

        void uc_lblFiled_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        void uc_lblFiled_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Orange;
        }
       
        public uc_lblFiled(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
