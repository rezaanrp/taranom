using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Sand
{
    public partial class frmSpc : Form
    {
        public frmSpc(string DateFrom,string DateTo,string SandChart,string Title,string FuncName,int GenLine,CS.csEnum.TypeLineMachine LnM)
        {
            InitializeComponent();
            LnM_ = LnM;
            BLL.Sand.scSPC cs = new BLL.Sand.scSPC();

            if (FuncName == "SlSandDailyTest_RChar_SPC")
            {
                dt_D = cs.SlSandDailyTest_RChar_SPC(DateFrom, DateTo, (int)LnM_);
            }

            if (FuncName == "SlSandWeeklyTest_RChar_SPC")
            {
                dt_D = cs.SlSandWeeklyTest_RChar_SPC(DateFrom, DateTo, GenLine);
            }

            if (dt_D.Rows.Count < 0)
                this.Close();

            GenChart_T_R("xBar" + SandChart, "UCL_XBAR" + SandChart, "LCL_XBAR" + SandChart, Title);
            GenChart_T_L("xBar" + SandChart, "UCL_XBAR" + SandChart, "LCL_XBAR" + SandChart);
            GenChart_B_R("xRBAR" + SandChart, "UCL_RBAR" + SandChart, "LCL_XBAR" + SandChart ,"R CHART");
            string USL_ = cs.QRSandSPC("USL", "" + SandChart, "SANDSPC");
            string LSL_ = cs.QRSandSPC("LSL", "" + SandChart, "SANDSPC");
            float UCL = (float)dt_D.Rows[0]["UCL_XBAR" + SandChart];
            float LCL= (float)dt_D.Rows[0]["LCL_XBAR" + SandChart];
            float RBAR =  (float)dt_D.Rows[0]["RBAR" + SandChart];
            float XBARBAR = (float)dt_D.Rows[0]["BARBAR" + SandChart];
            GenB_L(USL_, LSL_, UCL,  LCL,  RBAR , XBARBAR );


        }
        CS.csEnum.TypeLineMachine LnM_;
       DataTable dt_D;

        void GenChart_T_R(string S1,string S2 ,string S3,string Titl)
        {

            chart_T_R.DataSource = dt_D.Select(S1 + " > 0", " xDate ASC , x_ ASC ");
            chart_T_R.Series["Series1"].XValueMember = "xDate";
            chart_T_R.Series["Series1"].YValueMembers =S1;

            chart_T_R.Series["Series2"].XValueMember = "xDate";
            chart_T_R.Series["Series2"].YValueMembers = S2;
            chart_T_R.Series["Series2"].LegendText = "UCL";


            chart_T_R.Series["Series3"].XValueMember = "xDate";
            chart_T_R.Series["Series3"].YValueMembers = S3;
            chart_T_R.Series["Series3"].LegendText = "LCL";
            chart_T_R.Titles[0].Text = Titl;


        }

        void GenChart_T_L(string S1, string     S2, string S3)
        {

            chart_T_L.DataSource = dt_D.Select(S1 + " > 0", " xDate ASC , x_ ASC  "); 
            chart_T_L.Series["Series1"].XValueMember = "xDate";
            chart_T_L.Series["Series1"].YValueMembers = S1;

            chart_T_L.Series["Series2"].XValueMember = "xDate";
            chart_T_L.Series["Series2"].YValueMembers = S2;
            chart_T_L.Series["Series2"].LegendText = "UCL";


            chart_T_L.Series["Series3"].XValueMember = "xDate";
            chart_T_L.Series["Series3"].YValueMembers = S3;
            chart_T_L.Series["Series3"].LegendText = "LCL";
        }

        void GenChart_B_R(string S1, string S2, string S3,string Tile)
        {


            chart_B_R.DataSource = dt_D.Select(S1 + " IS NOT NULL ", " xDate ASC  , x_ ASC  "); 
            chart_B_R.Series["Series1"].XValueMember = "xDate";
            chart_B_R.Series["Series1"].YValueMembers = S1;

            chart_B_R.Series["Series2"].XValueMember = "xDate";
            chart_B_R.Series["Series2"].YValueMembers = S2;
            chart_B_R.Series["Series2"].LegendText = "UCL";


            //chart_B_R.Series["Series3"].XValueMember = "xDate";
            //chart_B_R.Series["Series3"].YValueMembers =S3;
            //chart_B_R.Series["Series3"].LegendText = "LCL";

            chart_B_R.Titles[0].Text = Tile;
        }

        void GenB_L(string USL,string LSL ,float UCL, float LCL, float RBAR ,float XBARBAR )
        {
            if(dt_D.Rows.Count < 1)
                return;
            txt_UCL.Text = System.Math.Round(UCL, 2).ToString();
            txt_LCL.Text = System.Math.Round(LCL, 2).ToString();
            txt_Sigma.Text = (System.Math.Round((RBAR /1.128), 4)).ToString();

            txt_USL.Text = USL;
            txt_LSL.Text = LSL;

            txt_CP.Text = (System.Math.Round((float.Parse(USL) - float.Parse(LSL)) / (6 * (RBAR / 1.128)), 3)).ToString();

        //    MessageBox.Show((RBAR / 5.20).ToString());
          //  MessageBox.Show(XBARBAR.ToString());
            txt_CPL.Text = (
                             System.Math.Round(
                             (XBARBAR - float.Parse(LSL)) /
                             (  ( RBAR / 1.128 )    * 3) 
                             ,3)
                            ).ToString();

            txt_CPU.Text = (
                   System.Math.Round(
                            (float.Parse(USL) - XBARBAR) /
                             ((RBAR / 1.128) * 3)
                                , 3)
                            ).ToString();

          //  textBox1.Text ="###"+ XBARBAR.ToString() + "###" + RBAR.ToString() + "###"
           //     + ((RBAR / 3.686)).ToString();


            if (  (float.Parse(txt_CPU.Text) - float.Parse(txt_CPL.Text) ) > 0)
                txt_CPK.Text = txt_CPL.Text;
            else
                txt_CPK.Text = txt_CPU.Text;
            


        }

        private void frmSpc_Load(object sender, EventArgs e)
        {

        }
    }
}
