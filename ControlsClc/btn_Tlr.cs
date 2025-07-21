using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ControlsClc
{
    public partial class btn_Tlr : Telerik.WinControls.UI.RadButton
    {
        public btn_Tlr()
        {
            InitializeComponent();
        }

        public btn_Tlr(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
