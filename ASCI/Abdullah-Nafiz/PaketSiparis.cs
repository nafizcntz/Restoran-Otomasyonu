using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace ASCI
{
    class PaketSiparis : Yemek
    {
        private string musteriAd;
        private string musteriSoyad;
        private string siparisId;

        public string MusteriAd { get => musteriAd; set => musteriAd = value; }
        public string MusteriSoyad { get => musteriSoyad; set => musteriSoyad = value; }
        public string SiparisId { get => siparisId; set => siparisId = value; }

        public void paketOnayla()
        {
            for (int i = 0; i < SecilenYemekAd.Count; i++)
            {
                //string id = masaId.ToString() + yemekIdCevir(SecilenYemekAd[i].ToString());

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
                "('" + masaId.ToString() + " ' ,'" + SecilenYemekAd[i].ToString() + "','" + SecilenYemekTutar[i].ToString() + "' ,'" + SecilenYemekAded[i].ToString() + "' ,'" + SecilenYemekAraTutar[i].ToString() + "' ,'" + siparisId.ToString() + "' ,'" + yil + "','" + ay + "','" + gun + "','" + saat + "','" + dakika + "','" + siparisTuru + "')", baglan);
                komut2.ExecuteNonQuery();
                baglan.Close();

            }

            toplamLBL2.Text = "TOPLAM : 0 ₺";
            listView2.Items.Clear();
            SecilenYemekAd.Clear(); SecilenYemekAded.Clear(); SecilenYemekAraTutar.Clear(); SecilenYemekTutar.Clear();
            sepetYenile();
        }
    }
}
