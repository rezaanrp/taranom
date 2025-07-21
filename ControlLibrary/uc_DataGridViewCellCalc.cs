using System;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_DataGridViewCellCalc : UserControl
    {
        public uc_DataGridViewCellCalc()
        {
            InitializeComponent();
        }

        private DataGridViewSelectedCellCollection myVar;

        public DataGridViewSelectedCellCollection DgvCell
        {
            get { return myVar; }
            set {
                myVar = value;
                if (myVar != null)
                {
                    float Min = 999999999999;
                    float Max = 0;
                    int Count = 0;
                    float Sm = 0;
                    foreach (DataGridViewCell item in myVar)
                    {
                        float temp = 0;
                        try
                        {
                            temp = float.Parse(item.Value.ToString());
                            if (temp < Min)
                                 Min = temp;
                            if(temp > Max)
                               Max = temp;
                            Count++;
                        }
                        catch (Exception)
                        {

                        }
                        Sm += temp;
                    }
                    lbl_Sum.Text = Sm.ToString();
                    lbl_Max.Text = Max.ToString();
                    lbl_Min.Text = Min.ToString();
                    lbl_Avg.Text = (Math.Round( Sm / Count , 1)).ToString();
                }
            }
        }

        private void lbl_Min_Click(object sender, EventArgs e)
        {

        }
        

    }
}
