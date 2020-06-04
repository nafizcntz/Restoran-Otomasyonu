using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        

        private void buttonGiro_Click(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl11.Visible = false;
            
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl11.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            userControl21.Visible = false;
            userControl11.Visible = true;
            
            
        }

        private void buttonOnline_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControl11.Visible = false;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
