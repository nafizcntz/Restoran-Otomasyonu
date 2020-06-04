using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GarsonEkran
{
    
    class Yemek
    {


        //public SqlConnection baglan;
        public SQLiteConnection baglan;

        private ArrayList yemekMenuId = new ArrayList();
        private ArrayList yemekMenuAd = new ArrayList();
        private ArrayList yemekMenuFiyat = new ArrayList();

        private ArrayList yemekId = new ArrayList();
        private ArrayList yemekAdi = new ArrayList();
        private ArrayList yemekTutari = new ArrayList();
        private ArrayList yemekAdedi = new ArrayList();
        private ArrayList yemekAraTutari = new ArrayList();
        private ArrayList yil = new ArrayList();
        private ArrayList ay = new ArrayList();
        private ArrayList gun = new ArrayList();
        private ArrayList saat = new ArrayList();
        private ArrayList dakika = new ArrayList();
        private ArrayList siparisTuru = new ArrayList();

        private ArrayList secilenYemekAd = new ArrayList();
        private ArrayList secilenYemekAded = new ArrayList();
        private ArrayList secilenYemekTutar = new ArrayList();
        private ArrayList secilenYemekAraTutar = new ArrayList();

        public ArrayList YemekMenuId { get => yemekMenuId; set => yemekMenuId = value; }
        public ArrayList YemekMenuAd { get => yemekMenuAd; set => yemekMenuAd = value; }
        public ArrayList YemekMenuFiyat { get => yemekMenuFiyat; set => yemekMenuFiyat = value; }
        public ArrayList YemekId { get => yemekId; set => yemekId = value; }
        public ArrayList YemekAdi { get => yemekAdi; set => yemekAdi = value; }
        public ArrayList YemekTutari { get => yemekTutari; set => yemekTutari = value; }
        public ArrayList YemekAdedi { get => yemekAdedi; set => yemekAdedi = value; }
        public ArrayList YemekAraTutari { get => yemekAraTutari; set => yemekAraTutari = value; }
        public ArrayList SiparisTuru { get => siparisTuru; set => siparisTuru = value; }
        public ArrayList SecilenYemekAd { get => secilenYemekAd; set => secilenYemekAd = value; }
        public ArrayList SecilenYemekAded { get => secilenYemekAded; set => secilenYemekAded = value; }
        public ArrayList SecilenYemekTutar { get => secilenYemekTutar; set => secilenYemekTutar = value; }
        public ArrayList SecilenYemekAraTutar { get => secilenYemekAraTutar; set => secilenYemekAraTutar = value; }
        public ArrayList Yil { get => yil; set => yil = value; }
        public ArrayList Ay { get => ay; set => ay = value; }
        public ArrayList Saat { get => saat; set => saat = value; }
        public ArrayList Gun { get => gun; set => gun = value; }
        public ArrayList Dakika { get => dakika; set => dakika = value; }

        public int masaId;
        public ListView listView1 = new ListView();
        public ListView listView2 = new ListView();
        public Label toplamLBL = new Label();
        public Label toplamLBL2 = new Label();
        public Label sepetBosLBL = new Label();
        public Label duzenleAdetLBL = new Label();

        public Yemek()
        {
            //baglan = new SqlConnection("Data Source=DESKTOP-RILS1DJ\\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");
            baglan = new SQLiteConnection(@"data source=C:\Users\abdll\Desktop\Restoran.db");
            fiyatCek();
        }

        public string yemekIdCevir(string s)
        {
            string id = YemekMenuId[YemekMenuAd.IndexOf(s)].ToString();
            return id;
        }
        public void fiyatCek()
        {
            /*
            try
            {
                try { baglan.Open(); } catch (Exception e) { }

                SqlCommand komut = new SqlCommand("Select *from yemekBilgi", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                for (int i = 0; oku.Read(); i++)
                {
                    YemekMenuId.Add(oku["id"].ToString().Trim());
                    YemekMenuAd.Add(oku["yemekAd"].ToString().Trim());
                    YemekMenuFiyat.Add(oku["yemekFiyat"].ToString().Trim());

                }
                oku.Close();
                baglan.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata");
            }
            */

            try
            {
                try { baglan.Open(); } catch (Exception e) { }

                SQLiteCommand komut = new SQLiteCommand("Select *from yemekBilgi", baglan);
                SQLiteDataReader oku = komut.ExecuteReader();

                for (int i = 0; oku.Read(); i++)
                {
                    YemekMenuId.Add(oku["id"].ToString().Trim());
                    YemekMenuAd.Add(oku["yemekAd"].ToString().Trim());
                    YemekMenuFiyat.Add(oku["yemekFiyat"].ToString().Trim());

                }
                oku.Close();
                baglan.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata");
            }

        }
        public void yemekSec(string id)
        {
            listView2.Items.Clear();
            double total = 0;
            for (int i = 0; i < SecilenYemekAd.Count; i++)
            {
                if (SecilenYemekAd[i].ToString() == id)
                {

                    SecilenYemekAded[i] = int.Parse(SecilenYemekAded[i].ToString()) + 1;
                    SecilenYemekAraTutar[i] = int.Parse(SecilenYemekAraTutar[i].ToString()) + int.Parse(SecilenYemekTutar[i].ToString());


                    for (i = 0; i < SecilenYemekAd.Count; i++)
                    {

                        ListViewItem ekle = new ListViewItem();

                        ekle.Text = SecilenYemekAd[i].ToString();
                        ekle.SubItems.Add(SecilenYemekTutar[i].ToString());
                        ekle.SubItems.Add(SecilenYemekAded[i].ToString());
                        ekle.SubItems.Add(SecilenYemekAraTutar[i].ToString());

                        total += Double.Parse(SecilenYemekAraTutar[i].ToString());


                        listView2.Items.Add(ekle);
                    }
                    toplamLBL2.Text = "TOPLAM : " + total.ToString() + " ₺";

                    return;
                }
            }

            int indis = YemekMenuAd.IndexOf(id);

            SecilenYemekAd.Add(YemekMenuAd[indis]); SecilenYemekAded.Add("1"); SecilenYemekTutar.Add(YemekMenuFiyat[indis]); SecilenYemekAraTutar.Add(YemekMenuFiyat[indis]);

            for (int i = 0; i < SecilenYemekAd.Count; i++)
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = SecilenYemekAd[i].ToString();
                ekle.SubItems.Add(SecilenYemekTutar[i].ToString());
                ekle.SubItems.Add(SecilenYemekAded[i].ToString());
                ekle.SubItems.Add(SecilenYemekAraTutar[i].ToString());

                total += Double.Parse(SecilenYemekAraTutar[i].ToString());

                listView2.Items.Add(ekle);
            }
            toplamLBL2.Text = "TOPLAM : " + total.ToString() + " ₺";
        }

        public void sepetOnayla()
        {
            for (int i = 0; i < SecilenYemekAd.Count; i++)
            {
                string id = masaId.ToString() + yemekIdCevir(SecilenYemekAd[i].ToString());

                bool gecici = false;
                for (int j = 0; j < yemekId.Count; j++)
                {

                    //MessageBox.Show(id + "    " + yemekId[j].ToString() + "     " + secilenYemekAd.Count.ToString());

                    /*
                    if (id == yemekId[j].ToString())
                    {
                        baglan.Open();
                        double yemekAdedi1; double yemekAraTutar1;
                        SqlCommand komut = new SqlCommand("Select *from yemekSepet Where id = " + id, baglan);
                        SqlDataReader reader = komut.ExecuteReader();
                        reader.Read();

                        yemekAdedi1 = Double.Parse(reader["yemekAdedi"].ToString().Trim()) + Double.Parse(SecilenYemekAded[i].ToString());
                        yemekAraTutar1 = Double.Parse(reader["yemekAraTutar"].ToString().Trim()) + Double.Parse(SecilenYemekAraTutar[i].ToString());
                        reader.Close();

                        //MessageBox.Show("evet");
                        SqlCommand komut1 = new SqlCommand(" Update yemekSepet set yemekAdedi='" + yemekAdedi1.ToString() + "' , yemekAraTutar='" + yemekAraTutar1.ToString() + "'  where id=(" + id + ")", baglan);
                        komut1.ExecuteNonQuery();
                        baglan.Close();

                        gecici = true;
                        break;

                    }
                    */

                    if (id == yemekId[j].ToString())
                    {
                        baglan.Open();
                        double yemekAdedi1; double yemekAraTutar1;
                        SQLiteCommand komut = new SQLiteCommand("Select *from yemekSepet Where id = " + id, baglan);
                        SQLiteDataReader reader = komut.ExecuteReader();
                        reader.Read();

                        yemekAdedi1 = Double.Parse(reader["yemekAdedi"].ToString().Trim()) + Double.Parse(SecilenYemekAded[i].ToString());
                        yemekAraTutar1 = Double.Parse(reader["yemekAraTutar"].ToString().Trim()) + Double.Parse(SecilenYemekAraTutar[i].ToString());
                        reader.Close();

                        //MessageBox.Show("evet");
                        SQLiteCommand komut1 = new SQLiteCommand(" Update yemekSepet set yemekAdedi='" + yemekAdedi1.ToString() + "' , yemekAraTutar='" + yemekAraTutar1.ToString() + "'  where id=(" + id + ")", baglan);
                        komut1.ExecuteNonQuery();
                        baglan.Close();

                        gecici = true;
                        break;

                    }
                }
                if (gecici) { continue; }


                baglan.Open();
                string yil = DateTime.Now.Year.ToString();
                string ay = DateTime.Now.Month.ToString();
                string gun = DateTime.Now.Day.ToString();
                string saat = DateTime.Now.Hour.ToString();
                string dakika = DateTime.Now.Minute.ToString();
                string siparisTuru = "masa";
                /*
            SqlCommand komut2 = new SqlCommand("Insert Into yemekSepet (masaNo,yemekAdi,yemekTutari,yemekAdedi,yemekAraTutar,id,tarih,saat,siparisTuru) Values " +
            "('" + masaId.ToString() + " ' ,'" + SecilenYemekAd[i].ToString() + "','" + SecilenYemekTutar[i].ToString() + "' ,'" + SecilenYemekAded[i].ToString() + "' ,'" + SecilenYemekAraTutar[i].ToString() + "' ,'" + id.ToString() + "' ,'" + tarih + "','" + saat + "','" + siparisTuru + "')", baglan);
            */
                SQLiteCommand komut2 = new SQLiteCommand("Insert Into yemekSepet (masaNo,yemekAdi,yemekTutari,yemekAdedi,yemekAraTutar,id,yil,ay,gun,saat,dakika,siparisTuru) Values " +
                "('" + masaId.ToString() + " ' ,'" + SecilenYemekAd[i].ToString() + "','" + SecilenYemekTutar[i].ToString() + "' ,'" + SecilenYemekAded[i].ToString() + "' ,'" + SecilenYemekAraTutar[i].ToString() + "' ,'" + id.ToString() + "' ,'" + yil + "','" + ay + "','" + gun + "','" + saat + "','" + dakika + "','" + siparisTuru + "')", baglan);

                komut2.ExecuteNonQuery();
                baglan.Close();


            }
            toplamLBL2.Text = "TOPLAM : 0 ₺";
                listView2.Items.Clear();
                SecilenYemekAd.Clear(); SecilenYemekAded.Clear(); SecilenYemekAraTutar.Clear(); SecilenYemekTutar.Clear();
                sepetYenile();
            
        }

        public void sepettenSil(int secilenIndis)
        {


            SecilenYemekAd.RemoveAt(secilenIndis);
            SecilenYemekAded.RemoveAt(secilenIndis);
            SecilenYemekAraTutar.RemoveAt(secilenIndis);
            SecilenYemekTutar.RemoveAt(secilenIndis);


            sepetYenile();

            sepetYenile();

        }

        public void sepetDuzenle(int secilenIndis)
        {
            if (duzenleAdetLBL.Text == "0")
            {
                sepettenSil(secilenIndis);
                sepetYenile();
                return;
            }

     
            SecilenYemekAded[secilenIndis] = duzenleAdetLBL.Text;
            SecilenYemekAraTutar[secilenIndis] = int.Parse(SecilenYemekTutar[secilenIndis].ToString()) * int.Parse(SecilenYemekAded[secilenIndis].ToString());
            sepetYenile(); 
        }

        public void sepetYenile()
        {
            double total = 0;
            listView2.Items.Clear();

            for (int i = 0; i < SecilenYemekAd.Count; i++)
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = SecilenYemekAd[i].ToString();
                ekle.SubItems.Add(SecilenYemekTutar[i].ToString());
                ekle.SubItems.Add(SecilenYemekAded[i].ToString());
                ekle.SubItems.Add(SecilenYemekAraTutar[i].ToString());

                total += Double.Parse(SecilenYemekAraTutar[i].ToString());


                listView2.Items.Add(ekle);
            }
            toplamLBL2.Text = "TOPLAM : " + total.ToString() + " ₺";
        }
        public void toplamHesapla()
        {
            float toplam = 0.0f;
            for (int i = 0; i < yemekAraTutari.Count; i++)
            {
                toplam += float.Parse(yemekAraTutari[i].ToString());
            }

            toplamLBL.Text = "TOPLAM : " + toplam.ToString() + " ₺";
        }



    }
  
  
}
