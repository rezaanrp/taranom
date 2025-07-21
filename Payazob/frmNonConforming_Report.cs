using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmNonConforming_Report : Form
    {
        public frmNonConforming_Report()
        {
            InitializeComponent();
            position = uc_cmbAutoPieces.Location.Y;
            BLL.csPieces cp = new BLL.csPieces();

            uc_cmbAutoPieces.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            uc_cmbAutoPieces.DisplayMember = "xName";
            uc_cmbAutoPieces.ValueMember = "x_";
            uc_cmbAutoPieces.SelectedIndex = -1;


            DataGridViewButtonColumn buttonColumn =
             new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "نمایش جزئیات";
            buttonColumn.Text = "بيشتر";
            buttonColumn.Visible= false;
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, buttonColumn);

            DataGridViewButtonColumn buttonColumn1 =
             new DataGridViewButtonColumn();
            buttonColumn1.Name = "print";
            buttonColumn1.HeaderText = "گزارش";
            buttonColumn1.Text = "چاپ";
            buttonColumn1.Visible = false;
            buttonColumn1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(1, buttonColumn1);

        }
        DataTable dt_PS = new DataTable("NoConforming");
        private int position;
        private Stack<ControlLibrary.uc_cmbAuto> stack = new Stack<ControlLibrary.uc_cmbAuto>();



        private void generateForm()
        {

            //int xPieces_, string xSubstance, int xQuarantineNumber, string xTime, string xDate, string xFormNo, 
            //string xNonconformTitleDate, string xNonconformTitle, string xTakenActionDate, string xTakenAction, 
            //string xActionApprovalDate, string xActionApproval, string xResultDate, string xResult


            BLL.csQualityControl cs = new BLL.csQualityControl();

            string[] st = new string[stack.Count + 1];
            st[0] = uc_cmbAutoPieces.Text;
            int count = stack.Count;
            for (int i = 1; i < count + 1; i++)
            {
                ControlLibrary.uc_cmbAuto uc = stack.Pop();
                st[i] = uc.Text;
                panel1.Controls.Remove(uc);
                position -= uc_cmbAutoPieces.Size.Height;
            }
            //RefreshForm();

         //   dt_PS.Clear();
         //   dt_PS = cs.SelectQualityControlNonconformingByDate(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, st);

            bindingSource1.DataSource = dt_PS;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            //int xPieces_, string xSubstance, int xQuarantineNumber, string xTime, string xDate, string xFormNo, 
            //string xNonconformTitleDate, string xNonconformTitle, string xTakenActionDate, string xTakenAction, 
            //string xActionApprovalDate, string xActionApproval, string xResultDate, string xResult

            dataGridView1.Columns["xSubstance"].HeaderText = "جنس مواد";
            dataGridView1.Columns["xQuarantineNumber"].HeaderText = "شماره قرنطينه";
            dataGridView1.Columns["xDate"].HeaderText = "تاريخ";
            dataGridView1.Columns["xPieces"].HeaderText = "نوع محصول";
            dataGridView1.Columns["xFormNo"].HeaderText = "شماره فرم";
            dataGridView1.Columns["xTime"].HeaderText = "ساعت";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xNonconformTitleDate"].Visible = false;
            dataGridView1.Columns["xNonconformTitle"].Visible = false;
            dataGridView1.Columns["xTakenActionDate"].Visible = false;
            dataGridView1.Columns["xTakenAction"].Visible = false;
            dataGridView1.Columns["xActionApprovalDate"].Visible = false;
            dataGridView1.Columns["xActionApproval"].Visible = false;
            dataGridView1.Columns["xResultDate"].Visible = false;
            dataGridView1.Columns["xResult"].Visible = false;
            dataGridView1.Columns["Details"].Visible = true;
            dataGridView1.Columns["Details"].DisplayIndex = 10;
            dataGridView1.Columns["print"].Visible = true;
            dataGridView1.Columns["print"].DisplayIndex = 11;

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            generateForm();
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddCustomr_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                ControlLibrary.uc_cmbAuto u = stack.Peek();
                position = uc_cmbAutoPieces.Size.Height + u.Location.Y;
            }
            else
                position = uc_cmbAutoPieces.Size.Height + uc_cmbAutoPieces.Location.Y;

            ControlLibrary.uc_cmbAuto cmb_Goods = new ControlLibrary.uc_cmbAuto();
            cmb_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmb_Goods.FormattingEnabled = true;
            cmb_Goods.LimitToList = true;
            cmb_Goods.Location = new System.Drawing.Point(uc_cmbAutoPieces.Location.X, position);
            cmb_Goods.Name = "cmb_Goods";
            cmb_Goods.Size = new System.Drawing.Size(112, 21);

            this.panel1.Controls.Add(cmb_Goods);

            BLL.csPieces cp = new BLL.csPieces();

            cmb_Goods.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            cmb_Goods.DisplayMember = "xName";
            cmb_Goods.ValueMember = "x_";
            cmb_Goods.SelectedIndex = -1;
            cmb_Goods.Focus();
            stack.Push(cmb_Goods);
        }

        private void btn_DelCustomer_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                panel1.Controls.Remove(stack.Pop());
                position -= uc_cmbAutoPieces.Size.Height;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((System.Windows.Forms.DataGridView)(sender)).Columns[e.ColumnIndex].Name == "Details")
            {
                ControlLibrary.uc_Details ug = new ControlLibrary.uc_Details();
                ug.Dock = DockStyle.Top;
                ug.lbl_Subject.Text = "عنوان مغايرت";
                ug.label1.Text = dataGridView1["xNonconformTitleDate", e.RowIndex].Value.ToString();
                ug.lbl_Comment.Text = dataGridView1["xNonconformTitle", e.RowIndex].Value.ToString();

                ControlLibrary.uc_Details ug1 = new ControlLibrary.uc_Details();
                ug1.Dock = DockStyle.Top;
                ug1.lbl_Subject.Text = "اقدامات انجام گرفته";
                ug1.label1.Text = dataGridView1["xTakenActionDate", e.RowIndex].Value.ToString();
                ug1.lbl_Comment.Text = dataGridView1["xTakenAction", e.RowIndex].Value.ToString();

                ControlLibrary.uc_Details ug2 = new ControlLibrary.uc_Details();
                ug2.Dock = DockStyle.Top;
                ug2.lbl_Subject.Text = "تاييده اقدام";
                ug2.label1.Text = dataGridView1["xActionApprovalDate", e.RowIndex].Value.ToString();
                ug2.lbl_Comment.Text = dataGridView1["xActionApproval", e.RowIndex].Value.ToString();

                ControlLibrary.uc_Details ug3 = new ControlLibrary.uc_Details();
                ug3.Dock = DockStyle.Top;
                ug3.lbl_Subject.Text = "نتيجه اقدام انجام شده";
                ug3.label1.Text = dataGridView1["xResultDate", e.RowIndex].Value.ToString();
                ug3.lbl_Comment.Text = dataGridView1["xResult", e.RowIndex].Value.ToString();

                
                Form dl = new Form();
                dl.Font = new System.Drawing.Font("Tahoma", 8.25F);
                dl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dl.Size = new System.Drawing.Size(600, 500);
                dl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                dl.Controls.Add(ug);
                dl.Controls.Add(ug1);
                dl.Controls.Add(ug2);
                dl.Controls.Add(ug3);
                dl.ShowDialog();
            }
            if (((System.Windows.Forms.DataGridView)(sender)).Columns[e.ColumnIndex].Name == "print")
            {
                //crsNonConforming cr = new crsNonConforming();
                DataRow[] dr = dt_PS.Select("x_ = " + dataGridView1["x_", e.RowIndex].Value.ToString());
                DataTable dt = dr.CopyToDataTable();
                //cr.SetDataSource(dt);
                //cr.SetParameterValue("DateNow", BLL.csshamsidate.shamsidate);
                //frmReport rp = new frmReport();
                //rp.GetReport = cr;
                //rp.ShowDialog(); 


                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(dt, "crsNonConforming");
                r.ShowDialog();
                r.Dispose();


            }
        }


    }
}













