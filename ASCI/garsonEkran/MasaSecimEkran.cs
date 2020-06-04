using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASCI
{
    public partial class MasaSecimEkran : MetroFramework.Forms.MetroForm
    {
        public MasaSecimEkran()
        {
            InitializeComponent();
        }
        Yemek yemek = new Yemek();

        //SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RILS1DJ\\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");
        
        static public int selectedTable = 0;
        int masaAktarDurum = 0, secilenmasaSayisi = 0;
        int[] secilenMasalar = new int[2];

        MasaDurum masaDurum = new MasaDurum();
        MasaSiparis masaSiparis = new MasaSiparis();


        private void Form1_Load(object sender, EventArgs e)
        {
            yemek.baglan.Open();
            timer1.Start();
            butonAta();
            masaDurum.koltukYenile();
            secimPaneli.Location = new Point(390, 265);
            aktarUyariPanel.Location = new Point(390, 265);
            secilenMasalar[0] = -1; secilenMasalar[1] = -1;

        }

        public static Button[] dizi = new Button[21];
        public static String[] masaDurumList = new String[21];
        public void butonAta()
        {
            masaDurum.dizi[0]= M1;
            masaDurum.dizi[1] = M2;
            masaDurum.dizi[2] = M3;
            masaDurum.dizi[3] = M4;
            masaDurum.dizi[4] = M5;
            masaDurum.dizi[5] = M6;
            masaDurum.dizi[6] = M7;
            masaDurum.dizi[7] = M8;
            masaDurum.dizi[8] = M9;
            masaDurum.dizi[9] = M10;
            masaDurum.dizi[10] = M11;
            masaDurum.dizi[11] = M12;
            masaDurum.dizi[12] = M13;
            masaDurum.dizi[13] = M14;
            masaDurum.dizi[14] = M15;
            masaDurum.dizi[15] = M16;
            masaDurum.dizi[16] = M17;
            masaDurum.dizi[17] = M18;
            masaDurum.dizi[18] = M19;
            masaDurum.dizi[19] = M20;
            masaDurum.dizi[20] = M21;
            masaDurum.koltukYenile();

        }
        /*public void koltukYenile()
        {
            try
            {
                try { baglan.Open(); } catch (Exception e) { }
                SqlCommand komut = new SqlCommand("Select *from masaBilgi", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                for (int i = 0; oku.Read(); i++)
                {
                    if (oku["masaDurum"].ToString() == "0") { dizi[i].BackColor = Color.Lime; }
                    else { dizi[i].BackColor = Color.Crimson; }
                    masaDurumList[i] = oku["masaDurum"].ToString();
                }
                oku.Close();
                

            }
            catch (Exception e)
            {
                
            }
        }
      */

        public Color color1,color2;
        public void panelVeyaAktarAc(int secilen, Button button)
        {
            if (masaAktarDurum == 0)
            {
                selectedTable = secilen;
                secimPaneli.Visible = true;
                masaNoTXT.Text = selectedTable + " NO'lu MASA";

                if (masaDurum.masaDurumList[selectedTable - 1] == "0") { masaAcBTN.Text = "MASAYI AÇ"; masaAcBTN.BackColor = Color.DodgerBlue; }
                else { masaAcBTN.Text = "MASAYA GİR"; masaAcBTN.BackColor = Color.Yellow; }


                for (int i = 0; i < 21; i++)
                {
                    masaDurum.dizi[i].Enabled = false;
                }

            }
            else if (masaAktarDurum == 1)
            {
                timer1.Stop();

                if (secilenmasaSayisi < 2)
                {

                    if (secilenMasalar[0] == -1 && secilenMasalar[1] == -1)  //İki Seçimde Boşsa
                    {
                        color1 = button.BackColor;
                        button.BackColor = Color.Blue;
                        secilenMasalar[0] = secilen;
                        birinciMasaLbl.Text = "1. Masa : " + secilenMasalar[0];
                        secilenmasaSayisi++;
                    }

                    else if (secilenMasalar[0] == -1 && secilenMasalar[1] != -1 && secilenMasalar[1] != secilen) //1.Secim Boş , 2.Secimin Dolu ve Seçilenin 2 den farklı olması
                    {
                        color1 = button.BackColor;
                        button.BackColor = Color.Blue;
                        secilenMasalar[0] = secilen;
                        birinciMasaLbl.Text = "1. Masa : " + secilenMasalar[0];
                        secilenmasaSayisi++;
                    }

                    else if (secilenMasalar[0] == -1 && secilenMasalar[1] != -1 && secilenMasalar[1] == secilen) //1.Secim Boş , 2.Secimin Dolu ve Seçilenin 2 ile aynı olması
                    {
                        button.BackColor = color2;
                        secilenMasalar[1] = -1;
                        birinciMasaLbl.Text = "2. Masa : -";
                        secilenmasaSayisi--;
                    }

                    else if (secilenMasalar[0] != -1 && secilenMasalar[1] == -1 && secilenMasalar[0] != secilen) //1.Dolu , 2.Boş ve Seçilenin 1 den farklı olması
                    {
                        color2 = button.BackColor;
                        button.BackColor = Color.Orange;
                        secilenMasalar[1] = secilen;
                        ikinciMasaLbl.Text = "2. Masa : " + secilenMasalar[1];
                        secilenmasaSayisi++;
                    }

                    else if (secilenMasalar[0] != -1 && secilenMasalar[1] == -1 && secilenMasalar[0] == secilen) //1.Dolu , 2.Boş ve Seçilenin 1 ile aynı olması
                    {
                        button.BackColor = color1;
                        secilenMasalar[0] = -1;
                        birinciMasaLbl.Text = "1. Masa : -";
                        secilenmasaSayisi--;
                    }

                    else if (secilenMasalar[0] == secilen)
                    {
                        button.BackColor = color1;
                        secilenMasalar[0] = -1;
                        birinciMasaLbl.Text = "1. Masa : -";
                        secilenmasaSayisi--;
                    }

                    else if (secilenMasalar[1] == secilen)
                    {
                        button.BackColor = color2;
                        secilenMasalar[1] = -1;
                        ikinciMasaLbl.Text = "2. Masa : -";
                        secilenmasaSayisi--;
                    }

                    if (secilenmasaSayisi == 2)
                    {
                        masaAktarBtn.Text = "ONAYLA";
                        masaAktarDurum = 2;
                    }

                    if (secilenMasalar[0] == -1 && secilenMasalar[1] == -1) //1.Dolu , 2.Boş ve Seçilenin 1 ile aynı olması
                    {
                        
                        
                        birinciMasaLbl.Text = "1. Masa : -";
                        ikinciMasaLbl.Text = "2. Masa : -";
                    }


                }


            }

            else if (masaAktarDurum == 2)
            {

                if (secilenMasalar[0] == secilen)
                {
                    secilenMasalar[0] = -1; birinciMasaLbl.Text = "1. Masa : -"; button.BackColor = color1;
                    masaAktarBtn.Text = "İPTAL ET";
                    masaAktarDurum = 1;
                    secilenmasaSayisi--;

                }

                else if (secilenMasalar[1] == secilen)
                {
                    secilenMasalar[1] = -1; ikinciMasaLbl.Text = "2. Masa : -"; button.BackColor = color2;
                    masaAktarBtn.Text = "İPTAL ET";
                    masaAktarDurum = 1;
                    secilenmasaSayisi--;
                }

            }
            
        }

        /*public void masaAc()
        {
            try { baglan.Open(); } catch (Exception e) { }
            SqlCommand komut = new SqlCommand(" Update masaBilgi set masaDurum='" + "1" + "' where masaNo=(" + selectedTable + ")", baglan);
            komut.ExecuteNonQuery();

            masaDurum.koltukYenile();
            secimPaneli.Visible = false;

            for (int i = 0; i < dizi.Length; i++)
            {
                masaDurum.dizi[i].Enabled = true;
            }
            baglan.Close();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }
        */

        /*public string yemekIdCevir(string s)
        {
            if (s == "pilav") { return "001"; }
            else if (s == "fasulye") { return "002"; }
            else if (s == "nohut") { return "003"; }
            else if (s == "dolma") { return "004"; }
            else if (s == "eriste") { return "005"; }
            else if (s == "makarna") { return "006"; }
            else if (s == "tavuksote") { return "007"; }
            else if (s == "sinitzel") { return "008"; }
            else return "000";
        }
        */

        private void İptalBTN_Click(object sender, EventArgs e)
        {
            secimPaneli.Visible = false;

            for (int i = 0; i < dizi.Length; i++)
            {
                masaDurum.dizi[i].Enabled = true;
            }
        }

        private void MasaAktarBtn_Click(object sender, EventArgs e)
        {
            if (masaAktarDurum == 0)
            {
                masaAktarBtn.Text = "İPTAL ET";
                masaAktarDurum = 1;
                aktarPanel.Visible = true;

                birinciMasaLbl.Text = "1. Masa : -"; ikinciMasaLbl.Text = "2. Masa : -";
                secilenMasalar[0] = -1; secilenMasalar[1] = -1; secilenmasaSayisi = 0;
                masaDurum.koltukYenile();
            }

            else if(masaAktarDurum == 1)
            {
                masaAktarBtn.Text = "MASA AKTAR";
                masaAktarDurum = 0;
                aktarPanel.Visible = false;
                timer1.Start();

                birinciMasaLbl.Text = "1. Masa : -"; ikinciMasaLbl.Text = "2. Masa : -";
                secilenMasalar[0] = -1; secilenMasalar[1] = -1; secilenmasaSayisi = 0;
                masaDurum.koltukYenile();

            }

            else if(masaAktarDurum == 2)
            {
                for (int i = 0; i < 21; i++)
                {
                    masaDurum.dizi[i].Enabled = false;
                }

                aktarUyariPanel.Visible = true;
                aktarUyariYaziLbl.Text = secilenMasalar[0] + " NO'LU MASA " + secilenMasalar[1] + " NO'LU MASAYA AKTARILSIN MI ? ";
            }
        }

        private void AktarOnaylaBtn_Click(object sender, EventArgs e)
        {
            masaAktarBtn.Text = "MASA AKTAR";
            masaAktarDurum = 0;
            aktarPanel.Visible = false;
            timer1.Start();

            try { yemek.baglan.Open(); } catch (Exception ex) { }
          
            //SQLiteCommand deaktif = new SqlCommand(" Update masaBilgi set masaDurum='" + "0" + "' where masaNo=(" + secilenMasalar[0] + ")", baglan);  //1. masa deaktif oluyor
            //deaktif.ExecuteNonQuery();
            //SqlCommand aktif = new SqlCommand(" Update masaBilgi set masaDurum='" + "1" + "' where masaNo=(" + secilenMasalar[1] + ")", baglan); //2. masa aktif oluyor
            //aktif.ExecuteNonQuery();

            SQLiteCommand deaktif = new SQLiteCommand(" Update masaBilgi set masaDurum='" + "0" + "' where masaNo=(" + secilenMasalar[0] + ")", yemek.baglan);  //1. masa deaktif oluyor
            deaktif.ExecuteNonQuery();
            SQLiteCommand aktif = new SQLiteCommand(" Update masaBilgi set masaDurum='" + "1" + "' where masaNo=(" + secilenMasalar[1] + ")", yemek.baglan); //2. masa aktif oluyor
            aktif.ExecuteNonQuery();


            //SqlCommand komut = new SqlCommand("Select *from yemekSepet", baglan);
            //SqlDataReader reader = komut.ExecuteReader();

            SQLiteCommand komut = new SQLiteCommand("Select *from yemekSepet", yemek.baglan);
            SQLiteDataReader reader = komut.ExecuteReader();

            ArrayList yemekAd1 = new ArrayList();
            ArrayList yemekAd2 = new ArrayList();
            ArrayList yemekAded1 = new ArrayList();
            ArrayList yemekAded2 = new ArrayList();
            ArrayList yemekAraTutar1 = new ArrayList();
            ArrayList yemekAraTutar2 = new ArrayList();
            ArrayList yemekId1 = new ArrayList();
            ArrayList yemekId2 = new ArrayList();

            for(int i = 0; reader.Read(); i++)
            {
                if(reader["masaNo"].ToString().Trim() == secilenMasalar[0].ToString())
                {
                    yemekAd1.Add(reader["yemekAdi"].ToString().Trim());
                    yemekAded1.Add(reader["yemekAdedi"].ToString().Trim());
                    yemekAraTutar1.Add(reader["yemekAraTutar"].ToString().Trim());
                    yemekId1.Add(reader["id"].ToString().Trim());
                }

                else if(reader["masaNo"].ToString().Trim() == secilenMasalar[1].ToString())
                {
                    yemekAd2.Add(reader["yemekAdi"].ToString().Trim());
                    yemekAded2.Add(reader["yemekAdedi"].ToString().Trim());
                    yemekAraTutar2.Add(reader["yemekAraTutar"].ToString().Trim());
                    yemekId2.Add(reader["id"].ToString().Trim());
                }
            }
            reader.Close();
            bool a=true;
            for(int i = 0; i < yemekAd1.Count; i++)
            {
                for(int j = 0; j < yemekAd2.Count; j++)
                {
                    a = true;

                    if ( (  secilenMasalar[1].ToString() + masaSiparis.yemekIdCevir(yemekAd1[i].ToString())  ) == yemekId2[j].ToString())
                    {
                        string yeniYemekAded = (int.Parse(yemekAded1[i].ToString()) + int.Parse(yemekAded2[j].ToString())).ToString();
                        string yeniYemekAraTutar = (int.Parse(yemekAraTutar1[i].ToString()) + int.Parse(yemekAraTutar2[j].ToString())).ToString();

                        /*
                        SqlCommand guncelle = new SqlCommand("Update yemekSepet set yemekAdedi='" + yeniYemekAded + "' , yemekAraTutar='" + yeniYemekAraTutar + "' Where id = (" + yemekId2[j] + ")", baglan);
                        guncelle.ExecuteNonQuery();
                        SqlCommand sil = new SqlCommand("Delete from yemekSepet Where id =" + yemekId1[i], baglan);
                        sil.ExecuteNonQuery();
                        */

                        SQLiteCommand guncelle = new SQLiteCommand("Update yemekSepet set yemekAdedi='" + yeniYemekAded + "' , yemekAraTutar='" + yeniYemekAraTutar + "' Where id = (" + yemekId2[j] + ")", yemek.baglan);
                        guncelle.ExecuteNonQuery();
                        SQLiteCommand sil = new SQLiteCommand("Delete from yemekSepet Where id =" + yemekId1[i], yemek.baglan);
                        sil.ExecuteNonQuery();
                        a = false;
                        break;
                    }
                    
                 
                }

                if (a)
                {
                    string yeniYemekId = secilenMasalar[1].ToString() + masaSiparis.yemekIdCevir(yemekAd1[i].ToString());
                    string yeniMasaNo = secilenMasalar[1].ToString();

                    //SqlCommand guncelle = new SqlCommand("Update yemekSepet set masaNo='" + yeniMasaNo + "' , id='" + yeniYemekId + "' Where id = (" + yemekId1[i] + ")", baglan);
                    SQLiteCommand guncelle = new SQLiteCommand("Update yemekSepet set masaNo='" + yeniMasaNo + "' , id='" + yeniYemekId + "' Where id = (" + yemekId1[i] + ")", yemek.baglan);
                    guncelle.ExecuteNonQuery();

                    
                }
            }



            yemekAd1.Clear(); yemekAd2.Clear(); yemekAded1.Clear(); yemekAded2.Clear(); yemekAraTutar1.Clear(); yemekAraTutar2.Clear(); yemekId1.Clear(); yemekId2.Clear();

            yemek.baglan.Close();

            
            //sıfırlama işlemleri
            aktarUyariPanel.Visible = false;
            birinciMasaLbl.Text = "1. Masa : -"; ikinciMasaLbl.Text = "2. Masa : -";
            secilenMasalar[0] = -1; secilenMasalar[1] = -1; secilenmasaSayisi = 0;
           
            //Masaları aktif hale getiriyor
            for (int i = 0; i < 21; i++)
            {
                masaDurum.dizi[i].Enabled = true;
                
            }
            masaDurum.koltukYenile();
        }

        private void AktarIptalBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
            {
                dizi[i].Enabled = true;
            }

            aktarUyariPanel.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            masaDurum.koltukYenile();
        }

        private void MasaAcBTN_Click(object sender, EventArgs e)
        {
            masaDurum.masaAc(this,selectedTable,secimPaneli);
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            ProgramGiris form = new ProgramGiris();
            form.Show();
            this.Hide();
        }

        private void M1_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(1,M1);
        }

        private void M2_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(2, M2);
        }

        private void M3_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(3, M3);
        }

        private void M4_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(4, M4);
        }

        private void M5_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(5, M5);
        }

        private void M6_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(6, M6);
        }

        private void M7_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(7, M7);
        }

        private void M8_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(8, M8);
        }

        private void M9_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(9, M9);
        }

        private void M10_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(10, M10);
        }

        private void M11_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(11, M11);
        }

        private void M12_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(12, M12);
        }

        private void M13_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(13, M13);
        }

        private void M14_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(14, M14);
        }

        private void M15_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(15, M15);
        }

        private void M16_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(16, M16);
        }

        private void M17_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(17, M17);
        }

        private void M18_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(18, M18);
        }

        private void M19_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(19, M19);
        }


        private void M20_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(20, M20);
        }

        private void M21_Click(object sender, EventArgs e)
        {
            panelVeyaAktarAc(21, M21);
        }

    }
}
