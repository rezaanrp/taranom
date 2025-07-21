using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frmedit_object : Form
    {
        
       
       
        public frmedit_object()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        

        private void btnsave_Click(object sender, EventArgs e)
        {
            if ((ustextbox1.Text == "") || (ustextbox2.Text == "")) { MessageBox.Show("اطلاعات را تکمیل کنید"); return; }
            if ((comboname.Text == "") || (comboBox2.Text == "")) { MessageBox.Show("اطلاعات را تکمیل کنید"); return; }
            PAYAIND.csedit insertsource = new PAYAIND.csedit();
            string cod = ustextbox1.Text +combocod.Text+ "-" + comboBox2.Text; 
            char[] c= new char[1];
            c=comboBox2.Text.Substring(0,1).ToCharArray();
            char kind= c[0];
            if (insertsource.exitobject(comboname.Text + " " + ustextbox2.Text, textBox1.Text)) { MessageBox.Show("این قطعه از قبل وجود دارد"); return; }
            insertsource.insert_object(cod, comboname.Text+" "+ ustextbox2.Text, textBox1.Text,checkBox1.Checked);
            fillgrid();
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            ustextbox1.Text = source.returnmaxcodobject(combocod.Text);
        }
        public void fillgrid()
        {
            PAYAIND.fill_datagride fill = new PAYAIND.fill_datagride();
            bindingSource1.DataSource = fill.fillobject();
           
            bindingNavigator1.BindingSource = bindingSource1;
        }
        private void frmedit_object_Load(object sender, EventArgs e)
        {
            clear();
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();            
            fillgrid();            
           // dataGridView1.Columns[5].Visible = false;
         //   dataGridView1.Columns[4].Visible = false;
            comboname.DataSource = source.fillcombonameminobject(comboBox2.Text);
            combocod.DataSource = comboname.DataSource;
            comboname.DisplayMember = "xname";
            combocod.DisplayMember = "xcod";   
            
        }
        private void clear()
    {
        ustextbox2.Text = "";        
        textBox1.Text = ""; 

    }

        
       

        private void btndelete_Click(object sender, EventArgs e)
        {
            PAYAIND.fill_datagride fill = new PAYAIND.fill_datagride();
            string cod; PAYAIND.csedit insertsource = new PAYAIND.csedit();
            string name;
            try
            {
   cod = dataGridView1.CurrentRow.Cells["xid"].Value.ToString();
   name = dataGridView1.CurrentRow.Cells["xname"].Value.ToString();
   DialogResult key = MessageBox.Show("  آیا مطمئنید که می خواهید قطعه       " + name + " حذف شود ", "حذف؟", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
   if (key == DialogResult.Yes)
   {
       bindingSource1.RemoveCurrent();
       insertsource.deletefromobjectteble1(cod);   
   }      
            }
            catch { }
        } 

        private void btnobject_Click(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            form.frmedit_cod_objects f = new frmedit_cod_objects();
            f.ShowDialog();
            comboname.DataSource = source.fillcombonameminobject(comboBox2.Text);
            combocod.DataSource = comboname.DataSource;
            comboname.DisplayMember = "xname";
            combocod.DisplayMember = "xcod";
        }

        private void comboname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
   PAYAIND.fillcombo source = new PAYAIND.fillcombo();
   combocod.SelectedIndex = comboname.SelectedIndex;
   ustextbox1.Text = source.returnmaxcodobject(combocod.Text);
            }
            catch { }
        }

        private void combocod_SelectedIndexChanged(object sender, EventArgs e)
        {try
        {            
            comboname.SelectedIndex = combocod.SelectedIndex;
            }
        catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            comboname.DataSource = source.fillcombonameminobject(comboBox2.Text);
            combocod.DataSource = comboname.DataSource;
            comboname.DisplayMember = "xname";
            combocod.DisplayMember = "xcod";
            comboname_SelectedIndexChanged(null, null);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            bindingSource1.EndEdit();
            PAYAIND.csedit insertsource = new PAYAIND.csedit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
   //try
   {
       string cod = row.Cells["xid"].Value.ToString();
       string name = row.Cells["xname"].Value.ToString();
       string tozih = row.Cells["xdetails"].Value.ToString();
       bool isbuilding =(bool)row.Cells["xisBuilding"].Value;
       insertsource.updateobjecttable(cod, name, tozih, isbuilding);
   }
   //catch { MessageBox.Show(""); }
 
            }
            MessageBox.Show("ذخیره شد");
        }

    }
}
