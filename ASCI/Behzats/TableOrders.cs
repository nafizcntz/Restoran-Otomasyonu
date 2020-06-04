using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5;

namespace ASCI
{
    public partial class TableOrders : Form
    {

        int id;
        public TableOrders()
        {
            InitializeComponent();
        }

        public TableOrders(int Tableid)
        {
            id=Tableid;
            InitializeComponent();
           
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text ="Orders of Table "+id;
            dataGridView1.DataSource = Sql.select("Select * from yemekSepet WHERE masaNo="+id);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql.sqlcommand("UPDATE masaBilgi SET masaDurum=0 WHERE masaNo=" + id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
