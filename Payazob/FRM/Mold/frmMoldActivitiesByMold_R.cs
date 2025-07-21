using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.Mold
{
    public partial class frmMoldActivitiesByMold_R : Form
    {
        public frmMoldActivitiesByMold_R(int MoldListCode)
        {
            InitializeComponent();
            ShowData(MoldListCode);
            GenerationDGV();
        }

       
        DAL.Mold.DataSet_Mold.SlMoldActivitiesByMold_RDataTable dt_A;
        void ShowData(int MoldListCode_)
        {
            dt_A = new BLL.Mold.csMold().SlMoldActivitiesByMold_R(MoldListCode_);
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            GenerationDGV();
        }
        void GenerationDGV()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_A.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
        }
    }

}
