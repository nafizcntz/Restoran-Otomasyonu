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
                string tarih = DateTime.Now.ToShortDateString();
                string saat = DateTime.Now.ToShortTimeString();
                string siparisTuru = "paket";
                /*
                SqlCommand komut2 = new SqlCommand("Insert Into yemekSepet (masaNo,yemekAdi,yemekTutari,yemekAdedi,yemekAraTutar,id,tarih,saat,siparisTuru) Values " +
                "('" + siparisId.ToString() + " ' ,'" + SecilenYemekAd[i].ToString() + "','" + SecilenYemekTutar[i].ToString() + "' ,'" + SecilenYemekAded[i].ToString() + "' ,'" + SecilenYemekAraTutar[i].ToString() + "' ,'" + SiparisId.ToString() + "' ,'" + tarih + "','" + saat + "','" + siparisTuru + "')", baglan);
                */

                SQLiteCommand komut2 = new SQLiteCommand("Insert Into yemekSepet (masaNo,yemekAdi,yemekTutari,yemekAdedi,yemekAraTutar,id,tarih,saat,siparisTuru) Values " +
                "('" + siparisId.ToString() + " ' ,'" + SecilenYemekAd[i].ToString() + "','" + SecilenYemekTutar[i].ToString() + "' ,'" + SecilenYemekAded[i].ToString() + "' ,'" + SecilenYemekAraTutar[i].ToString() + "' ,'" + SiparisId.ToString() + "' ,'" + tarih + "','" + saat + "','" + siparisTuru + "')", baglan);
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
