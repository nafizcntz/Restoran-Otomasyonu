using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ASCI
{
    public partial class UserControlOnline : UserControl
    {

        public UserControlOnline()
        {
            InitializeComponent();
            
        }
        List<Customer2> cst = new List<Customer2>();
        int total = new int();

        private void UserControl2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string query = "Select * FROM Online_Foods WHERE FoodType=\"main\"";
            string query2 = "Select * FROM Online_Foods WHERE FoodType=\"snack\"";
            string query3 = "Select * FROM Online_Foods WHERE FoodType=\"dessert\"";
            string query4 = "Select * FROM Online_Foods WHERE FoodType=\"drink\"";
            ((ListBox)checkedListBox1).DataSource = Sql.select(query);
            ((ListBox)checkedListBox1).DisplayMember = "FoodName";
            ((ListBox)checkedListBox1).ValueMember = "Price";


            ((ListBox)checkedListBox2).DataSource = Sql.select(query2);
            ((ListBox)checkedListBox2).DisplayMember = "FoodName";
            ((ListBox)checkedListBox2).ValueMember = "Price";

            ((ListBox)checkedListBox3).DataSource = Sql.select(query3);
            ((ListBox)checkedListBox3).DisplayMember = "FoodName";
            ((ListBox)checkedListBox3).ValueMember = "Price";

            ((ListBox)checkedListBox4).DataSource = Sql.select(query4);
            ((ListBox)checkedListBox4).DisplayMember = "FoodName";
            ((ListBox)checkedListBox4).ValueMember = "Price";



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonPrevious5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            dataGridView1.Width = 403;
            dataGridView1.Height = 176;
            dataGridView1.Left = 138;
            dataGridView1.Top = 408;
        }

        private void buttonNext4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            dataGridView1.Width = 362;
            dataGridView1.Height = 439;
            dataGridView1.Left = 81;
            dataGridView1.Top = 125;
            textBox7.Text = total.ToString();
            textBox5.Text = (total * 0.18).ToString();
            textBox4.Text = (total * 1.18).ToString();

        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void buttonPrevious4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }


        private void buttonNext3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void buttonPrevious3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void buttonPrevious2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void buttonPrevious1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void buttonNext0_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Customer2 customer = new Customer2(/*textBox1.Text,textBox2.Text,textBox3.Text,textBox6.Text*/);
            customer.Namee = textBox1.Text;
            customer.Surname = textBox2.Text;
            customer.Number = textBox3.Text;
            customer.Address = textBox6.Text;
            List<Customer2> cst = new List<Customer2>();
            cst.Add(customer);
            dataGridView1.DataSource = cst;
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                string foodname = castedItem["FoodName"].ToString();
                int price = int.Parse(castedItem["Price"].ToString());
                total += price;
                
                
                panel1.Visible = true;
                Customer2 customer = new Customer2(/*textBox1.Text,textBox2.Text,textBox3.Text,textBox6.Text*/);
                customer.addorder(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, foodname, price);
                cst.Add(customer);
            }
            
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            
            foreach (object itemChecked in checkedListBox2.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                string foodname = castedItem["Foodname"].ToString();
                int price = int.Parse(castedItem["Price"].ToString());
                total += price;

                panel1.Visible = true;
                Customer2 customer = new Customer2(/*textBox1.Text,textBox2.Text,textBox3.Text,textBox6.Text*/);
                customer.addorder(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, foodname, price);
                cst.Add(customer);

            }
            
        }

        private void buttonAdd3_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox3.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                string foodname = castedItem["Foodname"].ToString();
                int price = int.Parse(castedItem["Price"].ToString());
                total += price;

                panel1.Visible = true;
                Customer2 customer = new Customer2(/*textBox1.Text,textBox2.Text,textBox3.Text,textBox6.Text*/);
                customer.addorder(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, foodname, price);
                cst.Add(customer);

            }
        }

        private void buttonAdd4_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox4.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                string foodname = castedItem["Foodname"].ToString();
                int price = int.Parse(castedItem["Price"].ToString());
                total += price;

                panel1.Visible = true;
                Customer2 customer = new Customer2(/*textBox1.Text,textBox2.Text,textBox3.Text,textBox6.Text*/);
                customer.addorder(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, foodname,price);
                
                cst.Add(customer);

            }
            dataGridView1.DataSource = cst;
            
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            Sql.dataFromGridView(dataGridView1);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
