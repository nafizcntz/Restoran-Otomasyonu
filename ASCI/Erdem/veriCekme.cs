using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

namespace ASCI
{
    class veriCekme
    {
        private ArrayList id = new ArrayList();
        private ArrayList siparisTuru = new ArrayList();
        private ArrayList masaNo= new ArrayList();
        private ArrayList yemekAdi = new ArrayList();
        private ArrayList yemekTutari = new ArrayList();
        private ArrayList yemekAdedi = new ArrayList();
        private ArrayList yemekAraTutari = new ArrayList();
        private ArrayList siparisSaat = new ArrayList();
        private ArrayList siparisDakika = new ArrayList();
        private ArrayList siparisGunu = new ArrayList();
        private ArrayList siparisAyi = new ArrayList();
        private ArrayList siparisYili = new ArrayList();

        public ListView listView1 = new ListView();
        public PictureBox[] picturebox = new PictureBox[21];
        public RichTextBox[] richtextbox = new RichTextBox[21];

        public ArrayList Id { get => id; set => id = value; }
        public ArrayList SiparisTuru { get => siparisTuru; set => siparisTuru = value; }
        public ArrayList MasaNo { get => masaNo; set => masaNo= value; }
        public ArrayList YemekAdi { get => yemekAdi; set => yemekAdi = value; }
        public ArrayList YemekTutari { get => yemekTutari; set => yemekTutari = value; }
        public ArrayList YemekAdedi { get => yemekAdedi; set => yemekAdedi = value; }
        public ArrayList YemekAraTutari { get => yemekAraTutari; set => yemekAraTutari = value; }
        public ArrayList SiparisSaat { get => siparisSaat; set => siparisSaat = value; }
        public ArrayList SiparisDakika { get => siparisDakika; set => siparisDakika = value; }
        public ArrayList SiparisGunu { get => siparisGunu; set => siparisGunu = value; }
        public ArrayList SiparisAyi { get => siparisAyi; set => siparisAyi = value; }
        public ArrayList SiparisYili { get => siparisYili; set => siparisYili = value; }


        public void listeKontrol()
        {
            ListViewItem item = new ListViewItem();
            for (int i = 0; i <= Id.Count - 1; i++)
            {
                item = listView1.Items.Add(Id[i].ToString()); //id int tanımlı bu yüzden string'e çeviriyoruz
                item.SubItems.Add(SiparisTuru[i].ToString() + " " + MasaNo[i].ToString());
                // item.SubItems.Add(s.masaNo[i].ToString());
                item.SubItems.Add(YemekAdi[i].ToString());
                // item.SubItems.Add(s.YemekTutari[i].ToString());
                item.SubItems.Add(YemekAdedi[i].ToString());
                // item.SubItems.Add(s.YemekAraTutari[i].ToString());
                item.SubItems.Add(SiparisSaat[i].ToString() + "." + SiparisDakika[i].ToString());
                // item.SubItems.Add(s.SiparisDakika[i].ToString());
                item.SubItems.Add(SiparisGunu[i].ToString() + "." + SiparisAyi[i].ToString() + "." + SiparisYili[i].ToString());
                // item.SubItems.Add(siparisAyi[i].ToString());
                // item.SubItems.Add(siparisYili[i].ToString());
            }

            for (int i = 0; i <= Id.Count - 1; i++)
            {
                if (SiparisTuru[i].ToString() == "order")  //adres siparisi ise
                {
                    if (DateTime.Now.Year == int.Parse(SiparisYili[i].ToString()))
                    {
                        if (DateTime.Now.Month == int.Parse(SiparisAyi[i].ToString()))
                        {
                            if (DateTime.Now.Day == int.Parse(SiparisGunu[i].ToString()))
                            {
                                if (DateTime.Now.Hour == int.Parse(SiparisSaat[i].ToString()))
                                {
                                    if (DateTime.Now.Minute >= int.Parse(SiparisDakika[i].ToString()) + 15)
                                    {
                                        listView1.Items[i].BackColor = Color.Tomato;
                                    }
                                    else
                                    {
                                        listView1.Items[i].BackColor = Color.DarkCyan;
                                    }
                                }

                                else if (DateTime.Now.Hour - 1 == int.Parse(SiparisSaat[i].ToString()))
                                {
                                    if (60 - int.Parse(SiparisDakika[i].ToString()) + DateTime.Now.Minute >= 15)
                                    {
                                        listView1.Items[i].BackColor = Color.Tomato;
                                    }
                                    else
                                    {
                                        listView1.Items[i].BackColor = Color.DarkCyan;
                                    }
                                }
                                else
                                {
                                    listView1.Items[i].BackColor = Color.Tomato;
                                }
                            }
                            else
                            {
                                listView1.Items[i].BackColor = Color.Tomato;
                            }
                        }
                        else
                        {
                            listView1.Items[i].BackColor = Color.Tomato;
                        }
                    }
                    else
                    {
                        listView1.Items[i].BackColor = Color.Tomato;
                    }
                }

                else if (SiparisTuru[i].ToString() == "masa")   //masa siparisi ise
                {
                    if (DateTime.Now.Year == int.Parse(SiparisYili[i].ToString()))
                    {
                        if (DateTime.Now.Month == int.Parse(SiparisAyi[i].ToString()))
                        {
                            if (DateTime.Now.Day == int.Parse(SiparisGunu[i].ToString()))
                            {
                                if (DateTime.Now.Hour == int.Parse(SiparisSaat[i].ToString()))
                                {
                                    if (DateTime.Now.Minute >= int.Parse(SiparisDakika[i].ToString()) + 15)
                                    {
                                        listView1.Items[i].BackColor = Color.Tomato;
                                    }
                                    else
                                    {
                                        listView1.Items[i].BackColor = Color.LimeGreen;
                                    }
                                }

                                else if (DateTime.Now.Hour - 1 == int.Parse(SiparisSaat[i].ToString()))
                                {
                                    if (60 - int.Parse(SiparisDakika[i].ToString()) + DateTime.Now.Minute >= 15)
                                    {
                                        listView1.Items[i].BackColor = Color.Tomato;
                                    }
                                    else
                                    {
                                        listView1.Items[i].BackColor = Color.LimeGreen;
                                    }
                                }
                                else
                                {
                                    listView1.Items[i].BackColor = Color.Tomato;
                                }
                            }
                            else
                            {
                                listView1.Items[i].BackColor = Color.Tomato;
                            }
                        }
                        else
                        {
                            listView1.Items[i].BackColor = Color.Tomato;
                        }
                    }
                    else
                    {
                        listView1.Items[i].BackColor = Color.Tomato;
                    }
                }
                else
                {

                }
            }
        }
        public void listele()
        {
            SQLiteConnection baglanti = new SQLiteConnection(@"data source = " + Application.StartupPath + "\\" + "Restoran.db");
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand("SELECT * from yemekSepet ORDER BY id DESC", baglanti);
            SQLiteDataReader dr = komut.ExecuteReader();

            //listView1.View = View.Details;
            //listView1.GridLines = true;
            //listView1.CheckBoxes = true;

            Id.Clear(); SiparisTuru.Clear(); MasaNo.Clear(); YemekAdi.Clear();
            YemekTutari.Clear(); YemekAdedi.Clear(); YemekAraTutari.Clear();
            SiparisSaat.Clear(); SiparisDakika.Clear(); SiparisGunu.Clear(); SiparisAyi.Clear(); SiparisYili.Clear();
            listView1.Items.Clear();

            while (dr.Read())
            {
                //s.Id.Add(dr.GetInt32(0).ToString().Trim()); //id int tanımlı bu yüzden string'e çeviriyoruz
                Id.Add(dr.GetInt32(5));
                SiparisTuru.Add(dr.GetString(11).Trim());
                MasaNo.Add(dr.GetString(0));
                YemekAdi.Add(dr.GetString(1).Trim());
                YemekTutari.Add(dr.GetString(2).Trim());
                YemekAdedi.Add(dr.GetString(3).Trim());
                //item.SubItems.Add(dr.GetString(6));
                YemekAraTutari.Add(dr.GetString(4).Trim());
                SiparisSaat.Add(dr.GetString(9));
                SiparisDakika.Add(dr.GetString(10));
                SiparisGunu.Add(dr.GetString(8));
                SiparisAyi.Add(dr.GetString(7));
                SiparisYili.Add(dr.GetString(6));
            }
            baglanti.Close();
            listeKontrol();
        }
        public void masayaVeriGonderme(int masa)
        {
            SQLiteConnection baglanti = new SQLiteConnection(@"data source = " + Application.StartupPath + "\\" + "Restoran.db");
            baglanti.Open();

            SQLiteCommand masaNo= new SQLiteCommand("Select * from yemekSepet where masaNo= " + masa);
            masaNo.Connection = baglanti;
            SQLiteDataReader dr = masaNo.ExecuteReader();

            SQLiteCommand ayniSaat = new SQLiteCommand("SELECT * from yemekSepet where strftime('%Y')==yil and strftime('%m')==ay" +
                " and strftime('%d')==gun and strftime('%H')+3==saat and strftime('%M')-15<dakika and masaNo= "+(masa+1));
            ayniSaat.Connection = baglanti;
            SQLiteDataReader ayniSaatDR = ayniSaat.ExecuteReader();

            SQLiteCommand farkliSaat = new SQLiteCommand("SELECT * from yemekSepet where strftime('%Y')==yil and strftime('%m')==ay" +
                " and strftime('%d')==gun and strftime('%H')+2==gun and 60-dakika+strftime('%M')<15 and masaNo="+ (masa + 1));
            farkliSaat.Connection = baglanti;
            SQLiteDataReader farkliSaatDR = farkliSaat.ExecuteReader();

            richtextbox[masa].Clear();

            
            while (ayniSaatDR.Read())
            {
                richtextbox[masa ].Text += ayniSaatDR["yemekAdi"].ToString() + "\tx" + ayniSaatDR["yemekAdedi"].ToString() + "\n";
                picturebox[masa ].Visible = true;
            }
            while (farkliSaatDR.Read())
            {
                richtextbox[masa ].Text += farkliSaatDR["yemekAdi"].ToString() + "\tx" + farkliSaatDR["yemekAdedi"].ToString() + "\n";
                picturebox[masa ].Visible = true;
            }           
            dr.Close();            
            baglanti.Close();
        }
    }
}
