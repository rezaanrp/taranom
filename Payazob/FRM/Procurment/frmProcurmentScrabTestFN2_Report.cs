using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentScrabTestFN2_Report : Form
    {
        public frmProcurmentScrabTestFN2_Report()
        {
            InitializeComponent();

            BLL.csMaterial csm = new BLL.csMaterial();

            uc_cmbAuto_Material.DataSource = csm.SelectMeltName(59,-1,false);
            uc_cmbAuto_Material.DisplayMember = "xMaterialName";
            uc_cmbAuto_Material.ValueMember = "x_";
            uc_cmbAuto_Material.SelectedIndex = -1;

           
            uc_cmbAutoComment.DataSource = new BLL.Procurement.csProcurmentScarbTest().mProcurmentScarbTest_FN(-1);
            uc_cmbAutoComment.DisplayMember = "xComment";
            uc_cmbAutoComment.ValueMember = "xComment";
            uc_cmbAutoComment.SelectedIndex = -1;
            chk_cmb_filter = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Procurement.csProcurmentScarbTest css = new BLL.Procurement.csProcurmentScarbTest();
            DataTable dt = new DAL.Procurement.DataSet_ProcurmentScarbTest.SlProcurmentScarbTestReportDataTable();
            DataRow dr = dt.NewRow();
            
            dr["xDateEnter"] = mtxt_dateEnter.Text;
            dr["xDateTest"] = mtxt_test.Text;
            dr["Material"] = uc_cmbAuto_Material.Text;
            dr["xVisualScore"] = txtBoxvisualscore.Text;
            dr["xExperimentalScore"] =int.Parse( txtBoxexperimentalscore.Text);
            dr["xGradeProduct"] = txtBoxdaraje.Text;
            dr["StateScarb"] = "قبول";
            dr["xComment"] = uc_cmbAutoComment.Text;
            dr["xApprove"] = txtBoxapproveby.Text;
            dt.Rows.Add(dr);
            Report.SendReport cs = new Report.SendReport();
            //cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            //cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            //cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt, "crsProcurmentScarbTestFN3");
            r.ShowDialog();
            r.Dispose();
        }

        private void frmProcurmentScrabTestFN2_Report_Load(object sender, EventArgs e)
        {
            this.Size = new Size(673, 371);

        }
        bool chk_cmb_filter = false;
        private void uc_cmbAuto_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_cmb_filter) 
           {
                uc_cmbAutoComment.DataSource = new BLL.Procurement.csProcurmentScarbTest().mProcurmentScarbTest_FN((int)uc_cmbAuto_Material.SelectedValue);
                uc_cmbAutoComment.DisplayMember = "xComment";
                uc_cmbAutoComment.ValueMember = "xComment";
                uc_cmbAutoComment.SelectedIndex = -1;
           }
        }
    }
}
