using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Payazob.FRM.AnalysisFurnace
{
    public partial class frmAnalysisFurnaceImport : Form
    {
        public frmAnalysisFurnaceImport()
        {
            InitializeComponent();
            dt_A = new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csPieces cp = new BLL.csPieces();


            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn();
            combobox_xPieces_.DisplayIndex = 3;
            combobox_xPieces_.HeaderText = "نام قطعه";
            combobox_xPieces_.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_xPieces_.DisplayMember = "xName";
            combobox_xPieces_.ValueMember = "x_";
            combobox_xPieces_.DataPropertyName = "xPieces_";
        //  combobox_xPieces_.Name = "xPieces233";
            combobox_xPieces_.Width = 150;
            combobox_xPieces_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xPieces_);

            generate();
        }
        DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable dt_A;
        void generate()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xPieces_"].HeaderText = "شماره قطعه";
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xSupplier"].Visible = false;
            dataGridView1.Columns["xPieces"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xfe"].HeaderText = "fe";
            dataGridView1.Columns["xC"].HeaderText = "C";
            dataGridView1.Columns["xSi"].HeaderText = "Si";
            dataGridView1.Columns["xMn"].HeaderText = "Mn";
            dataGridView1.Columns["xP"].HeaderText = "P";
            dataGridView1.Columns["xS"].HeaderText = "S";
            dataGridView1.Columns["xCr"].HeaderText = "Cr";
            dataGridView1.Columns["xMo"].HeaderText = "Mo";
            dataGridView1.Columns["xNi"].HeaderText = "Ni";
            dataGridView1.Columns["xAl"].HeaderText = "Al";
            dataGridView1.Columns["xCo"].HeaderText = "Co";
            dataGridView1.Columns["xCu"].HeaderText = "Cu";
            dataGridView1.Columns["xMg"].HeaderText = "Mg";
            dataGridView1.Columns["xNb"].HeaderText = "Nb";
            dataGridView1.Columns["xTi"].HeaderText = "Ti";
            dataGridView1.Columns["xV"].HeaderText = "V";
            dataGridView1.Columns["xSn"].HeaderText = "Sn";
            dataGridView1.Columns["xB"].HeaderText = "B";
            dataGridView1.Columns["xZr"].HeaderText = "Zr";
            dataGridView1.Columns["xAs"].HeaderText = "As";
            dataGridView1.Columns["xCe"].HeaderText = "Ce";
            dataGridView1.Columns["xSupplier"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["xSupplier"].ReadOnly = true;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;



            dataGridView1.Columns["xfe"].Width = 50;
            dataGridView1.Columns["xC"].Width = 50;
            dataGridView1.Columns["xSi"].Width = 50;
            dataGridView1.Columns["xMn"].Width = 50;
            dataGridView1.Columns["xP"].Width = 50;
            dataGridView1.Columns["xS"].Width = 50;
            dataGridView1.Columns["xCr"].Width = 50;
            dataGridView1.Columns["xMo"].Width = 50;
            dataGridView1.Columns["xNi"].Width = 50;
            dataGridView1.Columns["xAl"].Width = 50;
            dataGridView1.Columns["xCo"].Width = 50;
            dataGridView1.Columns["xCu"].Width = 50;
            dataGridView1.Columns["xMg"].Width = 50;
            dataGridView1.Columns["xNb"].Width = 50;
            dataGridView1.Columns["xTi"].Width = 50;
            dataGridView1.Columns["xV"].Width = 50;
            dataGridView1.Columns["xSn"].Width = 50;
            dataGridView1.Columns["xB"].Width = 50;
            dataGridView1.Columns["xZr"].Width = 50;
            dataGridView1.Columns["xAs"].Width = 50;
            dataGridView1.Columns["xCe"].Width = 50;



            dataGridView1.Columns["xfe"].Visible = false;
            dataGridView1.Columns["xC"].Visible = true;
            dataGridView1.Columns["xSi"].Visible = true;
            dataGridView1.Columns["xMn"].Visible = true;
            dataGridView1.Columns["xP"].Visible = false;
            dataGridView1.Columns["xS"].Visible = false;
            dataGridView1.Columns["xCr"].Visible = true;
            dataGridView1.Columns["xMo"].Visible = true;
            dataGridView1.Columns["xNi"].Visible = false;
            dataGridView1.Columns["xAl"].Visible = true;
            dataGridView1.Columns["xCo"].Visible = false;
            dataGridView1.Columns["xCu"].Visible = true;
            dataGridView1.Columns["xMg"].Visible = true;
            dataGridView1.Columns["xNb"].Visible = false;
            dataGridView1.Columns["xTi"].Visible = false;
            dataGridView1.Columns["xV"].Visible = false;
            dataGridView1.Columns["xSn"].Visible = true;
            dataGridView1.Columns["xB"].Visible = false;
            dataGridView1.Columns["xZr"].Visible = false;
            dataGridView1.Columns["xAs"].Visible = false;
            dataGridView1.Columns["xCe"].Visible = true;
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {

   Validation.VString vst = new Validation.VString();
   OpenFileDialog dlgOpen = new OpenFileDialog();
   dlgOpen.Filter =
      "pdf file|*.csv";
   dlgOpen.Title = "انتخاب فایل کوانتومتر";
   if (dlgOpen.ShowDialog() == DialogResult.OK)
   {
       //  filebyte = null;
       //  filebyte = System.IO.File.ReadAllBytes(dlgOpen.FileName);
       //  System.IO.FileInfo fi = new System.IO.FileInfo(dlgOpen.FileName);
       
       string CSVFilePathName = dlgOpen.FileName;
       uc_txtBox1.Text  = dlgOpen.FileName;
       string[] Lines = File.ReadAllLines(CSVFilePathName);
       string[] Fields;
       DataTable dt = new DataTable();
       BLL.AnalyzeFurnace.csAnalyzeFurnace cs = new BLL.AnalyzeFurnace.csAnalyzeFurnace();
       dt_A = new DAL.AnalyzeFurnace.DataSet_AnalyzeFurnace.SlAnalyzeFurnaceDataTable();
       DataRow Row;

       int pi = 0;
       for (int i = 1; i < Lines.GetLength(0); i++)
       {

     Fields = Lines[i].Split(new char[] { ',' });
     Row = dt_A.NewRow();
     pi = 0;
     if (!int.TryParse(Fields[6].Replace("\"", string.Empty), out pi))
     {
         string[] st = Fields[6].Replace("\"", string.Empty).Split('&');
         if (!int.TryParse(st[0],out pi))
             continue;
     }

     Row["xDate"] = vst.StandardDate( Fields[4]);
     if (pi < 1)
         continue;
      Row["xPieces_"] = pi;
      Row["xSupplier_"] = BLL.authentication.x_;
     // Row["xSupplier"] = BLL.authentication.x_;
      //if ( float.Parse(  Fields[26 ].Replace("\"", string.Empty)  )  < 80)
      //{
      //    Row["xPieces_"] = pi;

      //}
      Row["xfe" ] = Fields[26   ].Replace("\"", string.Empty);
      Row["xC"  ] = Fields[28  ].Replace("\"", string.Empty);;
      Row["xSi"  ] = Fields[30  ].Replace("\"", string.Empty);;
      Row["xMn" ] = Fields[32  ].Replace("\"", string.Empty);;
      Row["xP" ] = Fields[34  ].Replace("\"", string.Empty);;
      Row["xS"] = Fields[36  ].Replace("\"", string.Empty);;
      Row["xCr"] = Fields[38  ].Replace("\"", string.Empty);;
      Row["xMo" ] = Fields[40  ].Replace("\"", string.Empty);;
      Row["xNi"  ] = Fields[42  ].Replace("\"", string.Empty);;
      Row["xAl" ] = Fields[44  ].Replace("\"", string.Empty);;
      Row["xCo" ] = Fields[46  ].Replace("\"", string.Empty);;
      Row["xCu" ] = Fields[48  ].Replace("\"", string.Empty);;
      Row["xMg"] = Fields[50  ].Replace("\"", string.Empty);;
      Row["xNb" ] = Fields[52  ].Replace("\"", string.Empty);;
      Row["xTi" ] = Fields[54  ].Replace("\"", string.Empty);;
      Row["xV" ] = Fields[56  ].Replace("\"", string.Empty);;
      Row["xSn"  ] = Fields[58  ].Replace("\"", string.Empty);;
      Row["xB" ] = Fields[60  ].Replace("\"", string.Empty);;
      Row["xZr"] = Fields[62  ].Replace("\"", string.Empty);;
      Row["xAs"] = Fields[64  ].Replace("\"", string.Empty);;
      Row["xCe" ] = Fields[66  ].Replace("\"", string.Empty);;
      Row["xSupplier" ] = Fields[10 ].Replace("\"", string.Empty);;
      dt_A.Rows.Add(Row);
       }
       bindingSource1.DataSource = dt_A;
       dataGridView1.DataSource = bindingSource1;
       bindingNavigator1.BindingSource = bindingSource1;
       generate();
   }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            CS.csMessage csm = new CS.csMessage();
            if (csm.ShowMessageSaveYesNo())
            {
   MessageBox.Show(new BLL.AnalyzeFurnace.csAnalyzeFurnace().UdAnalyzeFurnace(dt_A));
   this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            switch (keyData)
            {
   case (System.Windows.Forms.Keys.Control | Keys.V):
       new CS.csExeclToDataGridView().PasteInData(ref dataGridView1,ref bindingSource1);

       break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string cln = dataGridView1.Columns[e.ColumnIndex].Name;

    if (cln == "xDate") 
   {

       FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
       fr.StartPosition = FormStartPosition.CenterParent;

       fr.ShowDialog();
       if (fr.accept)
           dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
       dataGridView1.ClearSelection();
       dataGridView1.CurrentCell = dataGridView1[1,e.RowIndex];
       //dataGridView1.CurrentCell = null;
       dataGridView1.Columns["xDate"].ReadOnly = true;
       dataGridView1[e.ColumnIndex +1 , e.RowIndex].Selected = true;

   }
        }
    }
}
