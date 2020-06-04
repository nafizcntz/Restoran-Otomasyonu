using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASCI;

namespace WindowsFormsApp5
{
    public partial class UserControlOrder : UserControl
    {
        public Color Forecolor { get; internal set; }

        public UserControlOrder()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableButton5_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int freeTable = 12;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=1", 0) == 1) { tableButton1.BackColor = Color.Red; freeTable--; }
            else tableButton1.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=2", 0) == 1) { tableButton2.BackColor = Color.Red; freeTable--; }
            else tableButton2.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=3", 0) == 1) { tableButton3.BackColor = Color.Red; freeTable--; }
            else tableButton3.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=4", 0) == 1) { tableButton4.BackColor = Color.Red; freeTable--; }
            else tableButton4.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=5", 0) == 1) { tableButton5.BackColor = Color.Red; freeTable--; }
            else tableButton5.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=6", 0) == 1) { tableButton6.BackColor = Color.Red; freeTable--; }
            else tableButton6.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=7", 0) == 1) { tableButton7.BackColor = Color.Red; freeTable--; }
            else tableButton7.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=8", 0) == 1) { tableButton8.BackColor = Color.Red; freeTable--; }
            else tableButton8.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=9", 0) == 1) { tableButton9.BackColor = Color.Red; freeTable--; }
            else tableButton9.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=10", 0) == 1) { tableButton10.BackColor = Color.Red; freeTable--; }
            else tableButton10.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=11", 0) == 1) { tableButton11.BackColor = Color.Red; freeTable--; }
            else tableButton11.BackColor = Color.Transparent;
            if (Sql.read("Select masaDurum from masaBilgi WHERE masaNo=12", 0) == 1) { tableButton12.BackColor = Color.Red; freeTable--; }
            else tableButton12.BackColor = Color.Transparent;
            label16.Text = freeTable.ToString();
        }
    }
}
