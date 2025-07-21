using System;
using System.Windows.Forms;
using BLL;

namespace Payazob
{
    public partial class frmPieces : Form
    {
        public frmPieces(bool editable, CS.csEnum.GenFactoryGroupPieces GenFactoryGroup)
        {

            InitializeComponent();

            GrpFact = (int)GenFactoryGroup;
            string GrpPieces = "PCS";
            if (GenFactoryGroup == CS.csEnum.GenFactoryGroupPieces.Site3)
                GrpPieces = "PCSM";
        
            BLL.GenGroup.csGenGroup group = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                DataSource = group.SlGenGroup("GRE"),
                DisplayMember = "xName",
                HeaderText = "نوع ریختگری",
                ValueMember = "x_",
                DataPropertyName = "xType_",
                Name = "cmb_Type",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                DataSource = group.SlGenGroup("OPLEVEL"),
                DisplayMember = "xName",
                HeaderText = "طبقه عملیات",
                ValueMember = "x_",
                DataPropertyName = "xGenOperationLevel_",
                Name = "cmb_xGenOperationLevel_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column2);
            DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn
            {
                DataSource = group.SlGenGroup("FILTERP"),
                DisplayMember = "xName",
                HeaderText = "فیلتر",
                ValueMember = "x_",
                DataPropertyName = "xGenFilter_",
                Name = "cmb_FILTERP_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column3);
            DataGridViewComboBoxColumn column4 = new DataGridViewComboBoxColumn
            {

                DataSource = group.SlGenGroup(GrpPieces),
                HeaderText = "طبقه بندی ",
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGrp_",
                Name = "cmb_GRP",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column4);
            DataGridViewComboBoxColumn column5 = new DataGridViewComboBoxColumn
            {
                DataSource = group.SlGenGroup("STU"),
                HeaderText = "وضعیت ",
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenStatus_",
                Name = "cmb_STU",
                Width = 60,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column5);
            DataGridViewComboBoxColumn column6 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام قطعه مرتبط",
                DataSource = new BLL.csMaterial().SelectMeltName(160, -1, false),
                DisplayMember = "xMaterialName",
                DataPropertyName = "xRelatedPiece_",
                ValueMember = "x_",
                Name = "combobox_Pieces1_",
                Visible = false,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column6);
            DataGridViewComboBoxColumn column7 = new DataGridViewComboBoxColumn
            {
                DataSource = group.SlGenGroup("MSC"),
                HeaderText = "نوع ماهیچه ",
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xMuscleType_",
                Name = "cmb_MSC",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column7);

            DataGridViewComboBoxColumn column8 = new DataGridViewComboBoxColumn
            {
                DataSource = group.SlGenGroup("PIECPRME"),
                HeaderText = "روش تولید ",
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenProductionMethod_",
                Name = "xGenProductionMethod_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column8);
            this.ShowDate("");
            this.EditFormGen(editable);


        }
        private void ShowDate(string St)
        {
            this.dt_P = new csPieces().SelectPiecesByName(St, this.GrpFact);
            this.dataGridView1.DataSource = this.dt_P;
            this.bindingSource1.DataSource = this.dt_P;
            this.uc_bindingNavigator1.BindingSource = this.bindingSource1;
            this.dt_P.xGenGroupByFactory_Column.DefaultValue = this.GrpFact;
            if (this.GrpFact == 0x98)
            {
                this.Generate();
            }
            if (this.GrpFact == 0x99)
            {
                this.GenerateMachining();
            }
        }


        int GrpFact;

        private void GenerateMachining()
        {
            this.dataGridView1.Columns["xName"].DisplayIndex = 0;
            this.dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            this.dataGridView1.Columns["xName"].Width = 200;
            this.dataGridView1.Columns["xStandard"].HeaderText = "استاندارد";
            this.dataGridView1.Columns["xPieceweight"].HeaderText = "وزن قطعه";
            this.dataGridView1.Columns["xTechnicalname"].HeaderText = "کد فنی";
            this.dataGridView1.Columns["xKbythtotal"].HeaderText = "تعداد کویته";
            this.dataGridView1.Columns["xSolutionweight"].HeaderText = "وزن راهگاه";
            this.dataGridView1.Columns["Efficiency"].HeaderText = "بازده";
            this.dataGridView1.Columns["MeltingWeight"].HeaderText = "وزن ذوب هر قالب";
            this.dataGridView1.Columns["xSpeedMolding"].HeaderText = "سرعت قالب گیری ";
            this.dataGridView1.Columns["xMuscleName"].HeaderText = "نام ماهیچه";
            this.dataGridView1.Columns["xMuscleWeight"].HeaderText = "وزن ماهیچه";
            this.dataGridView1.Columns["xConsumption"].HeaderText = "مورد مصرف";
            this.dataGridView1.Columns["xNumberPerUnit"].HeaderText = "ضریب مصرف";
            this.dataGridView1.Columns["xCode"].HeaderText = "کد محصول";
            this.dataGridView1.Columns["xLastModifiedWeight"].HeaderText = "وزن قبلی";
            this.dataGridView1.Columns["xLastModifiedDate"].HeaderText = "تاریخ آخرین ویرایش";
            this.dataGridView1.Columns["xMusclekhoury"].HeaderText = "ماهیچه خوری";
            this.dataGridView1.Columns["xTurning"].HeaderText = "ماشین کاری";
            this.dataGridView1.Columns["xHaveModel"].HeaderText = "صفحه مدل اختصاصی دارد";
            this.dataGridView1.Columns["xCustomerConfirm"].HeaderText = "تاییدیه مشتری دارد";
            this.dataGridView1.Columns["xCountInBox"].HeaderText = "تعداد در کارتون";
            this.dataGridView1.Columns["xCountInCarton"].HeaderText = "تعداد در جعبه";
            this.dataGridView1.Columns["xSGCode"].HeaderText = "کد همکاران";
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xMarkettype"].Visible = false;
            this.dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            this.dataGridView1.Columns["xName"].Width = 200;
            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.Visible = false;
            }
            this.dataGridView1.Columns["xPieceweight"].Visible = true;
            this.dataGridView1.Columns["xName"].Visible = true;
            this.dataGridView1.Columns["xCountInBox"].Visible = true;
            this.dataGridView1.Columns["xCountInCarton"].Visible = true;
            this.dataGridView1.Columns["combobox_Pieces1_"].Visible = true;
            this.dataGridView1.Columns["cmb_xGenOperationLevel_"].Visible = true;
            this.dataGridView1.Columns["cmb_xGenOperationLevel_"].Visible = true;
            this.dataGridView1.Columns["cmb_GRP"].Visible = true;
            this.dataGridView1.Columns["xTechnicalname"].Visible = true;
        }


        private void EditFormGen(bool e_)
        {
            saveToolStripButton.Visible = e_;
            bindingNavigatorAddNewItem.Visible = e_;
            dataGridView1.ReadOnly = !e_;
        }

        DAL.DataSet_Piece.SelectPiecesByNameDataTable dt_P;
        void Generate()
        {
            this.dataGridView1.Columns["xName"].DisplayIndex = 0;
            this.dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            this.dataGridView1.Columns["xName"].Width = 200;
            this.dataGridView1.Columns["xStandard"].HeaderText = "استاندارد";
            this.dataGridView1.Columns["xPieceweight"].HeaderText = "وزن قطعه";
            this.dataGridView1.Columns["xTechnicalname"].HeaderText = "کد فنی";
            this.dataGridView1.Columns["xKbythtotal"].HeaderText = "تعداد کویته";
            this.dataGridView1.Columns["xSolutionweight"].HeaderText = "وزن راهگاه";
            this.dataGridView1.Columns["Efficiency"].HeaderText = "بازده";
            this.dataGridView1.Columns["MeltingWeight"].HeaderText = "وزن ذوب هر قالب";
            this.dataGridView1.Columns["xSpeedMolding"].HeaderText = "سرعت قالب گیری ";
            this.dataGridView1.Columns["xMuscleName"].HeaderText = "نام ماهیچه";
            this.dataGridView1.Columns["xMuscleWeight"].HeaderText = "وزن ماهیچه";
            this.dataGridView1.Columns["xConsumption"].HeaderText = "مورد مصرف";
            this.dataGridView1.Columns["xNumberPerUnit"].HeaderText = "ضریب مصرف";
            this.dataGridView1.Columns["xCode"].HeaderText = "کد محصول";
            this.dataGridView1.Columns["xLastModifiedWeight"].HeaderText = "وزن قبلی";
            this.dataGridView1.Columns["xLastModifiedDate"].HeaderText = "تاریخ آخرین ویرایش";
            this.dataGridView1.Columns["xMarkettype"].Visible = false;
            this.dataGridView1.Columns["xMusclekhoury"].HeaderText = "ماهیچه خوری";
            this.dataGridView1.Columns["xTurning"].HeaderText = "ماشین کاری";
            this.dataGridView1.Columns["xHaveModel"].HeaderText = "صفحه مدل اختصاصی دارد";
            this.dataGridView1.Columns["xCustomerConfirm"].HeaderText = "تاییدیه مشتری دارد";
            this.dataGridView1.Columns["xSGCode"].HeaderText = "کد همکاران";

            this.dataGridView1.Columns["xGenProductionMethod_"].HeaderText = "روش تولید ";

            

            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xCountInBox"].Visible = false;
            this.dataGridView1.Columns["xCountInCarton"].Visible = false;
            this.dataGridView1.Columns["xGenGroupByFactory_"].Visible = false;
            this.dataGridView1.Columns["cmb_xGenOperationLevel_"].Visible = false;


           
        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            this.ShowDate(this.toolStripTextBoxName.Text);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            CS.csMessage csM = new CS.csMessage();
            if(csM.ShowMessageSaveYesNo())
            {
                BLL.csPieces cs = new BLL.csPieces();
                if (cs.UpdatePiecesByName(dt_P))
                {
                    this.ShowDate("");

                    MessageBox.Show("ارسال با موفقیت انجام شد");

                }
                else
                    MessageBox.Show("عدم ارسال");
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            

             Report.SendReport cs = new Report.SendReport();

           cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_P, "crsPieces");
            r.ShowDialog();
            r.Dispose();
        }

        private void frmPieces_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["cmb_Type"].DisplayIndex = 3;
            dataGridView1.Columns["cmb_GRP"].DisplayIndex = 3;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
                if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
                    label1.Text = dataGridView1["xName", e.RowIndex].Value.ToString();
        }
    }
}
