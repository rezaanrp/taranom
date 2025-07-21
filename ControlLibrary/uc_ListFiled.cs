using System;
using System.Data;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_ListFiled : UserControl
    {
        public uc_ListFiled()
        {
            InitializeComponent();


        }
        public Delegate userFunctionPointer;
        //public DataTable dt  = new DataTable("List");
        public string ValueMemmbers = "";
        public string DisplayMemmbers = "";
        public void Generate(DataTable dt)
        {
            panel1.Controls.Clear();
            foreach (DataRow item in dt.Rows)
            {
                uc_lblFiled f = new uc_lblFiled();
                f.Text = item[DisplayMemmbers].ToString();
                f.Value =int.Parse( item[ValueMemmbers].ToString());
                f.Dock = System.Windows.Forms.DockStyle.Top;
                f.Location = new System.Drawing.Point(0, 0);
                f.Name = "uc_Field" + f.Value.ToString();
                f.Size = new System.Drawing.Size(220, 23);
                f.TabIndex = 0;
                f.Click += new EventHandler(f_Click);
                panel1.Controls.Add(f);

            }
        }
        public int ClickValue;
        public string ClickText;
        void f_Click(object sender, EventArgs e)
        {
            ClickValue = (sender as uc_lblFiled).Value;
            ClickText = (sender as uc_lblFiled).Text;
            userFunctionPointer.DynamicInvoke((sender as uc_lblFiled).Text);
        }

      
    }
}
