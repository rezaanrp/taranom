using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_Poem : UserControl
    {
        public uc_Poem()
        {
            InitializeComponent();
            FillLbl();
        }
        public void FillLbl()
        {
            try
            {
                //DataTable dt = new BLL.Poem.csPoem().SlPoem();
                //if (dt.Rows.Count > 0)
                //{
                //    string st = dt.Rows[0].ItemArray[1].ToString();
                //    lbl_Poem.Text = st.Replace("\\n", "\t\n");
                //    this.Size = new Size(300, st.Split('n').Length * 30 + 50);
                //}
            }
            catch (Exception)
            {
                
            }

        }

        private void lbl_Poem_DoubleClick(object sender, EventArgs e)
        {
            //lbl_Poem.Text = (new BLL.Poem.csPoem().SlPoem() as DataTable).Rows[0].ItemArray[1].ToString();
            FillLbl();
        }
    }
}
