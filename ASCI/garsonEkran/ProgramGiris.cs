using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ASCI
{
    public partial class ProgramGiris : MetroFramework.Forms.MetroForm
    {
        girisSunucu sunucu ;
        musteriEkranGiris musteriEkranGiris;
        MasaSecimEkran masaSecimEkran ;
        int hataliGiris = 0, block = 0;


        public ProgramGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sunucu = new girisSunucu();
            statusControl();
            timer1.Start();
            textBox2.Focus();
        }

        public void statusControl()
        {
            sunucu.controlBlock();
            block = sunucu.isBlock;
            hataliGiris = sunucu.errorCount;

            if (block == 1)
            {
                baslikTxt.Text = "PROGRAM DONDURULDU";
                panel3.BackColor = Color.Red;
                baslikTxt.Location = new Point(18, 8);
                textBox1.Enabled = false; textBox2.Enabled = false;
                button1.Enabled = false;
                label4.Visible = false;
            }
            else if (block == 0)
            {
                baslikTxt.Text = "GİRİŞ EKRANI";
                panel3.BackColor = Color.Black;
                baslikTxt.Location = new Point(81, 8);
                textBox1.Enabled = true; textBox2.Enabled = true;
                button1.Enabled = true;
                label4.Visible = true;
            }
            if (hataliGiris != 0)
            {
                label4.Visible = true;
                label4.Text = hataliGiris + " DEFA HATALI GİRİŞ";
            }
            else if (hataliGiris <= 0)
            {
                label4.Visible = false;
            }
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            //sunucu.resetError();
            statusControl();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            statusControl();
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sunucu.getData();

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kutular Boş Olamaz..!");
            }

            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                for (int i = 0; i < sunucu.userName.Count; i++)
                {
                    if (textBox1.Text == sunucu.userName[i] && textBox2.Text == sunucu.password[i])
                    {
                        
                        //sunucu.errorUpdate(-1);
                        //statusControl();
                        MessageBox.Show("Başarılı Giriş");

                        if (sunucu.authorization[i] == "garson")
                        {
                            masaSecimEkran = new MasaSecimEkran();
                            masaSecimEkran.Show();
                            textBox1.Clear(); textBox2.Clear();
                        }
                        else if (sunucu.authorization[i] == "musteri")
                        {
                            musteriEkranGiris = new musteriEkranGiris();
                            musteriEkranGiris.Show();
                            textBox1.Clear(); textBox2.Clear();
                        }
                        else if (sunucu.authorization[i] == "kasa")
                        {
                           
                            textBox1.Clear(); textBox2.Clear();
                        }
                        else if (sunucu.authorization[i] == "asci")
                        {
                            
                            textBox1.Clear(); textBox2.Clear();
                        }
                        else if (sunucu.authorization[i] == "admin")
                        {
                            
                            textBox1.Clear(); textBox2.Clear();
                        }
                        break;

                    }
                    else if (i + 1 == sunucu.userName.Count)
                    {
                        MessageBox.Show("Girilen Bilgiler Hatalı .. \nTekrar Deneyin !");
                        textBox1.Clear(); textBox2.Clear();
                        hataliGiris++;
                        //sunucu.errorUpdate(hataliGiris);
                        statusControl();
                        break;
                    }

                }
            }
        }




    }
}
