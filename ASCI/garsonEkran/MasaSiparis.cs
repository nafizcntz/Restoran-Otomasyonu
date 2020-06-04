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
    internal class MasaSiparis : Yemek
    {

        //SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RILS1DJ\\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");
        
        private string masaNo;

        public string MasaNo { get => masaNo; set => masaNo = value; }

        public void listedenSil(int secilenIndis)
        {
            string silinecekDeger = masaId.ToString() + yemekIdCevir(YemekAdi[secilenIndis].ToString()).ToString();
            baglan.Open();

            //SqlCommand komut = new SqlCommand("Delete from yemekSepet Where id = " + silinecekDeger, baglan);
            SQLiteCommand komut = new SQLiteCommand("Delete from yemekSepet Where id = " + silinecekDeger, baglan);
            komut.ExecuteNonQuery();
            baglan.Close();

            listeYenile();


        }

        public void listeDuzenle(int secilenIndis)
        {
            if (duzenleAdetLBL.Text == "0")
            {
                listedenSil(secilenIndis);
                listeYenile();
                return;
            }


            string id = masaId.ToString() + yemekIdCevir(YemekAdi[secilenIndis].ToString());


            baglan.Open();
            double yemekAdedi1; double yemekAraTutar1;
            yemekAdedi1 = double.Parse(duzenleAdetLBL.Text);
            yemekAraTutar1 = double.Parse(YemekTutari[secilenIndis].ToString()) * yemekAdedi1;
            //SqlCommand komut1 = new SqlCommand(" Update yemekSepet set yemekAdedi='" + yemekAdedi1.ToString() + "' , yemekAraTutar='" + yemekAraTutar1.ToString() + "'  where id=(" + id + ")", baglan);
            SQLiteCommand komut1 = new SQLiteCommand(" Update yemekSepet set yemekAdedi='" + yemekAdedi1.ToString() + "' , yemekAraTutar='" + yemekAraTutar1.ToString() + "'  where id=(" + id + ")", baglan);
            komut1.ExecuteNonQuery();
            baglan.Close();

            YemekAdedi[secilenIndis] = duzenleAdetLBL.Text;
            YemekAraTutari[secilenIndis] = int.Parse(YemekAraTutari[secilenIndis].ToString()) * int.Parse(YemekAdedi[secilenIndis].ToString());
            listeYenile();
        }

        public void listeYenile()
        {
            listView1.Items.Clear();
            YemekId.Clear(); YemekAdi.Clear(); YemekTutari.Clear(); YemekAdedi.Clear(); YemekAraTutari.Clear();
            baglan.Open();
            //SqlCommand komut = new SqlCommand("Select *from yemekSepet", baglan);
            //SqlDataReader oku = komut.ExecuteReader();

            SQLiteCommand komut = new SQLiteCommand("Select *from yemekSepet", baglan);
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                if (masaId == Int32.Parse(oku["masaNo"].ToString().Trim()))
                {

                    YemekId.Add(oku["id"].ToString().Trim());
                    YemekAdi.Add(oku["yemekAdi"].ToString().Trim());
                    YemekTutari.Add(oku["yemekTutari"].ToString().Trim());
                    YemekAdedi.Add(oku["yemekAdedi"].ToString().Trim());
                    YemekAraTutari.Add(oku["yemekAraTutar"].ToString().Trim());
                    Yil.Add(oku["yil"].ToString().Trim());
                    Ay.Add(oku["ay"].ToString().Trim());
                    Gun.Add(oku["gun"].ToString().Trim());
                    Saat.Add(oku["saat"].ToString().Trim());
                    Dakika.Add(oku["dakika"].ToString().Trim());
                    SiparisTuru.Add(oku["siparisTuru"].ToString().Trim());

                }

            }

            baglan.Close();

            for (int i = 0; i < YemekId.Count; i++)
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = YemekAdi[i].ToString();
                ekle.SubItems.Add(YemekTutari[i].ToString());
                ekle.SubItems.Add(YemekAdedi[i].ToString());
                ekle.SubItems.Add(YemekAraTutari[i].ToString());

                listView1.Items.Add(ekle);
            }

            toplamHesapla();

            if (YemekAdi.Count <= 0) { sepetBosLBL.Visible = true; } else { sepetBosLBL.Visible = false; }
        }
    }
    }

