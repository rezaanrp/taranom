using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TARANOM.MyControl
{
   public class CstProgressBar: ProgressBar
    {
        public DataGridView dvg
        {
            get { return dvg; }
            set
            {
                dvg = value; 
            }
        }
       
    }

}
