using System;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class ucStatusBar : UserControl
    {
        public ucStatusBar()
        {
            InitializeComponent();
            tss_Sum.Visible = false;
            tss_Max.Visible = false;
            tssl_Min.Visible = false;
            tssl_Avg.Visible = false;
            tssl_MinV.Visible = false;
            tssl_AvgV.Visible = false;
            tss_MaxV.Visible = false;
            tss_SumV.Visible = false;
        }

        private void ucStatusBar_Load(object sender, EventArgs e)
        {
            BLL.csshamsidate roz = new BLL.csshamsidate();
            tStSL_ShamciDate.Text = "روز شمار: " + roz.DayOfYearShamsi() + "  " + " تاریخ: " + BLL.csshamsidate.shamsidate;
        }
        private DataGridViewSelectedCellCollection myVar;

        public DataGridViewSelectedCellCollection DgvCell
        {
            get { return myVar; }
            set
            {
                myVar = value;
                if (myVar != null)
                {
                    tss_vi();
                    float Min = 999999999999;
                    float Max = 0;
                    int Count = 0;
                    float Sm = 0;
                    foreach (DataGridViewCell item in myVar)
                    {
                        float temp = 0;
                        try
                        {
                            if (float.TryParse(item.Value.ToString(), out temp))
                            {
                                if (temp < Min)
                                    Min = temp;
                                if (temp > Max)
                                    Max = temp;
                                Count++;
                            }
                        }
                        catch (Exception)
                        {

                        }
                        Sm += temp;
                    }
                    tss_SumV.Text = Sm.ToString();
                    tss_MaxV.Text = Max.ToString();
                    tssl_MinV.Text = Min.ToString();
                    tss_CountV.Text = Count.ToString();
                    int i = 0;
                    if(tssl_MinV.Text.IndexOf(".") < 0)
                        i = 1;
                    else
                        i = tssl_MinV.Text.Substring(tssl_MinV.Text.IndexOf(".")).Length - 1 ;
                    tssl_AvgV.Text = (Math.Round(Sm / Count, i)).ToString();
                }
            }
        }

        void tss_vi()
        {
            tss_Sum.Visible = true;
            tss_Max.Visible = true;
            tssl_Min.Visible = true;
            tssl_Avg.Visible = true;
            tssl_MinV.Visible = true;
            tssl_AvgV.Visible = true;
            tss_MaxV.Visible = true;
            tss_SumV.Visible = true;
            tss_CountV.Visible = true;
            tss_Count.Visible = true;
        }


  
    }
}
