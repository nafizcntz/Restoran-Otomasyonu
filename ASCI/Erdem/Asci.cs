using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

// yapılacaklar her bir richtextbox ve button un visibility'sini false yap

//virtual func

// masa numarası ekle

//masaların ekranına siparis geldiği zaman gif şeklinde sipariş geldi diye resim gözüksün ,
//sen ona tıkladığın zaman textbox açılıp gelen siparişi gör , button a tıkladğın zamanda tekrar masa resmi gözüksün
namespace ASCI
{
    public partial class formAsci : Form
    {
        public formAsci()
        {
            InitializeComponent();
        }
        veriCekme veriCekme = new veriCekme();        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            veriCekme.listView1 = listView1;

            veriCekme.picturebox[0] = pbGif1;
            veriCekme.picturebox[1] = pbGif2;
            veriCekme.picturebox[2] = pbGif3;
            veriCekme.picturebox[3] = pbGif4;
            veriCekme.picturebox[4] = pbGif5;
            veriCekme.picturebox[5] = pbGif6;
            veriCekme.picturebox[6] = pbGif7;
            veriCekme.picturebox[7] = pbGif8;
            veriCekme.picturebox[8] = pbGif9;
            veriCekme.picturebox[9] = pbGif10;
            veriCekme.picturebox[10] = pbGif11;
            veriCekme.picturebox[11] = pbGif12;
            veriCekme.picturebox[12] = pbGif13;
            veriCekme.picturebox[13] = pbGif14;
            veriCekme.picturebox[14] = pbGif15;
            veriCekme.picturebox[15] = pbGif16;
            veriCekme.picturebox[16] = pbGif17;
            veriCekme.picturebox[17] = pbGif18;
            veriCekme.picturebox[18] = pbGif19;
            veriCekme.picturebox[19] = pbGif20;
            veriCekme.picturebox[20] = pbGif21;

            veriCekme.richtextbox[0] = rtbSiparis1;
            veriCekme.richtextbox[1] = rtbSiparis2;
            veriCekme.richtextbox[2] = rtbSiparis3;
            veriCekme.richtextbox[3] = rtbSiparis4;
            veriCekme.richtextbox[4] = rtbSiparis5;
            veriCekme.richtextbox[5] = rtbSiparis6;
            veriCekme.richtextbox[6] = rtbSiparis7;
            veriCekme.richtextbox[7] = rtbSiparis8;
            veriCekme.richtextbox[8] = rtbSiparis9;
            veriCekme.richtextbox[9] = rtbSiparis10;
            veriCekme.richtextbox[10] = rtbSiparis11;
            veriCekme.richtextbox[11] = rtbSiparis12;
            veriCekme.richtextbox[12] = rtbSiparis13;
            veriCekme.richtextbox[13] = rtbSiparis14;
            veriCekme.richtextbox[14] = rtbSiparis15;
            veriCekme.richtextbox[15] = rtbSiparis16;
            veriCekme.richtextbox[16] = rtbSiparis17;
            veriCekme.richtextbox[17] = rtbSiparis18;
            veriCekme.richtextbox[18] = rtbSiparis19;
            veriCekme.richtextbox[19] = rtbSiparis20;
            veriCekme.richtextbox[20] = rtbSiparis21;

            veriCekme.listele();
            
            //  masayaVeriGonderme(1);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            veriCekme.listele();

            veriCekme.masayaVeriGonderme(0);
            veriCekme.masayaVeriGonderme(1);
            veriCekme.masayaVeriGonderme(2);
            veriCekme.masayaVeriGonderme(3);
            veriCekme.masayaVeriGonderme(4);
            veriCekme.masayaVeriGonderme(5);
            veriCekme.masayaVeriGonderme(6);
            veriCekme.masayaVeriGonderme(7);
            veriCekme.masayaVeriGonderme(8);
            veriCekme.masayaVeriGonderme(9);
            veriCekme.masayaVeriGonderme(10);
            veriCekme.masayaVeriGonderme(11);
            veriCekme.masayaVeriGonderme(12);
            veriCekme.masayaVeriGonderme(13);
            veriCekme.masayaVeriGonderme(14);
            veriCekme.masayaVeriGonderme(15);
            veriCekme.masayaVeriGonderme(16);
            veriCekme.masayaVeriGonderme(17);
            veriCekme.masayaVeriGonderme(18);
            veriCekme.masayaVeriGonderme(19);
            
         //   masayaVeriGonderme(1);            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pbGif1.Visible = false;
            panel1.Visible = false;
            rtbSiparis1.Visible = true;
            btSiparisTamam1.Visible = true;
        }
        private void pbGif2_Click(object sender, EventArgs e)
        {
            pbGif2.Visible = false;
            panel2.Visible = false;
            rtbSiparis2.Visible = true;
            btSiparisTamam2.Visible = true;
        }

        private void pbGif3_Click(object sender, EventArgs e)
        {
            pbGif3.Visible = false;
            panel3.Visible = false;
            rtbSiparis3.Visible = true;
            btSiparisTamam3.Visible = true;
        }
        private void pbGif4_Click(object sender, EventArgs e)
        {
            pbGif4.Visible = false;
            panel4.Visible = false;
            rtbSiparis4.Visible = true;
            btSiparisTamam4.Visible = true;
        }

        private void pbGif5_Click(object sender, EventArgs e)
        {
            pbGif5.Visible = false;
            panel5.Visible = false;
            rtbSiparis5.Visible = true;
            btSiparisTamam5.Visible = true;
        }

        private void pbGif6_Click(object sender, EventArgs e)
        {
            pbGif6.Visible = false;
            panel6.Visible = false;
            rtbSiparis6.Visible = true;
            btSiparisTamam6.Visible = true;
        }

        private void pbGif7_Click(object sender, EventArgs e)
        {
            pbGif7.Visible = false;
            panel7.Visible = false;
            rtbSiparis7.Visible = true;
            btSiparisTamam7.Visible = true;
        }

        private void pbGif8_Click(object sender, EventArgs e)
        {
            pbGif8.Visible = false;
            panel8.Visible = false;
            rtbSiparis8.Visible = true;
            btSiparisTamam8.Visible = true;
        }

        private void pbGif9_Click(object sender, EventArgs e)
        {
            pbGif9.Visible = false;
            panel9.Visible = false;
            rtbSiparis9.Visible = true;
            btSiparisTamam9.Visible = true;
        }

        private void pbGif10_Click(object sender, EventArgs e)
        {
            pbGif10.Visible = false;
            panel10.Visible = false;
            rtbSiparis10.Visible = true;
            btSiparisTamam10.Visible = true;
        }

        private void pbGif11_Click(object sender, EventArgs e)
        {
            pbGif11.Visible = false;
            panel11.Visible = false;
            rtbSiparis11.Visible = true;
            btSiparisTamam11.Visible = true;
        }

        private void pbGif12_Click(object sender, EventArgs e)
        {
            pbGif12.Visible = false;
            panel12.Visible = false;
            rtbSiparis12.Visible = true;
            btSiparisTamam12.Visible = true;
        }

        private void pbGif13_Click(object sender, EventArgs e)
        {
            pbGif13.Visible = false;
            panel13.Visible = false;
            rtbSiparis13.Visible = true;
            btSiparisTamam13.Visible = true;
        }

        private void pbGif14_Click(object sender, EventArgs e)
        {
            pbGif14.Visible = false;
            panel14.Visible = false;
            rtbSiparis14.Visible = true;
            btSiparisTamam14.Visible = true;
        }
        private void pbGif15_Click(object sender, EventArgs e)
        {
            pbGif15.Visible = false;
            panel15.Visible = false;
            rtbSiparis15.Visible = true;
            btSiparisTamam15.Visible = true;
        }

        private void pbGif16_Click(object sender, EventArgs e)
        {
            pbGif16.Visible = false;
            panel16.Visible = false;
            rtbSiparis16.Visible = true;
            btSiparisTamam16.Visible = true;
        }

        private void pbGif17_Click(object sender, EventArgs e)
        {
            pbGif17.Visible = false;
            panel17.Visible = false;
            rtbSiparis17.Visible = true;
            btSiparisTamam17.Visible = true;
        }

        private void pbGif18_Click(object sender, EventArgs e)
        {
            pbGif18.Visible = false;
            panel18.Visible = false;
            rtbSiparis18.Visible = true;
            btSiparisTamam18.Visible = true;
        }

        private void pbGif19_Click(object sender, EventArgs e)
        {
            pbGif19.Visible = false;
            panel19.Visible = false;
            rtbSiparis19.Visible = true;
            btSiparisTamam19.Visible = true;
        }
        private void pbGif20_Click(object sender, EventArgs e)
        {
            pbGif20.Visible = false;
            panel20.Visible = false;
            rtbSiparis20.Visible = true;
            btSiparisTamam20.Visible = true;
        }
        private void pbGif21_Click(object sender, EventArgs e)
        {
            pbGif21.Visible = false;
            panel21.Visible = false;
            rtbSiparis21.Visible = true;
            btSiparisTamam21.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btSiparisTamam1.Visible = false;
            rtbSiparis1.Visible = false;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            btSiparisTamam2.Visible = false;
            rtbSiparis2.Visible = false;
        }
        private void btSiparisTamam3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            btSiparisTamam3.Visible = false;
            rtbSiparis3.Visible = false;
        }

        private void btSiparisTamam4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            btSiparisTamam4.Visible = false;
            rtbSiparis4.Visible = false;
        }

        private void btSiparisTamam5_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            btSiparisTamam5.Visible = false;
            rtbSiparis5.Visible = false;
        }

        private void btSiparisTamam6_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            btSiparisTamam6.Visible = false;
            rtbSiparis6.Visible = false;

        }

        private void btSiparisTamam7_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            btSiparisTamam7.Visible = false;
            rtbSiparis7.Visible = false;
        }

        private void btSiparisTamam8_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            btSiparisTamam8.Visible = false;
            rtbSiparis8.Visible = false;
        }

        private void btSiparisTamam9_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            btSiparisTamam9.Visible = false;
            rtbSiparis9.Visible = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            btSiparisTamam10.Visible = false;
            rtbSiparis10.Visible = false;
        }

        private void btSiparisTamam11_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            btSiparisTamam11.Visible = false;
            rtbSiparis11.Visible = false;
        }

        private void btSiparisTamam12_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
            btSiparisTamam12.Visible = false;
            rtbSiparis12.Visible = false;
        }

        private void btSiparisTamam13_Click(object sender, EventArgs e)
        {
            panel13.Visible = true;
            btSiparisTamam13.Visible = false;
            rtbSiparis13.Visible = false;
        }

        private void btSiparisTamam14_Click(object sender, EventArgs e)
        {
            panel14.Visible = true;
            btSiparisTamam14.Visible = false;
            rtbSiparis14.Visible = false;
        }

        private void btSiparisTamam15_Click(object sender, EventArgs e)
        {
            panel15.Visible = true;
            btSiparisTamam15.Visible = false;
            rtbSiparis15.Visible = false;
        }

        private void btSiparisTamam16_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            btSiparisTamam16.Visible = false;
            rtbSiparis16.Visible = false;
        }

        private void btSiparisTamam17_Click(object sender, EventArgs e)
        {
            panel17.Visible = true;
            btSiparisTamam17.Visible = false;
            rtbSiparis17.Visible = false;
        }

        private void btSiparisTamam18_Click(object sender, EventArgs e)
        {
            panel18.Visible = true;
            btSiparisTamam18.Visible = false;
            rtbSiparis18.Visible = false;
        }

        private void btSiparisTamam19_Click(object sender, EventArgs e)
        {
            panel19.Visible = true;
            btSiparisTamam19.Visible = false;
            rtbSiparis19.Visible = false;
        }

        private void btSiparisTamam20_Click(object sender, EventArgs e)
        {
            panel20.Visible = true;
            btSiparisTamam20.Visible = false;
            rtbSiparis20.Visible = false;
        }
        private void btSiparisTamam21_Click(object sender, EventArgs e)
        {
            panel21.Visible = true;
            btSiparisTamam21.Visible = false;
            rtbSiparis21.Visible = false;
        }


        private void pbGif20_ClientSizeChanged(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_DoubleClick(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        private void label21_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void richTextBox21_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

         
    }
}
