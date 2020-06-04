using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using static ASCI.VeriErisimi;

namespace ASCI
{
    class Siparis : YemekBilgileri
    {

        private int siparisId;
        private string masaNo;
        private string yemekAdedi;
        private string yemekAraTutar;
        private string gun;
        private string ay;
        private string yil;
        private string saat;
        private string siparisTuru;

        public int SiparisId { get => siparisId; set => siparisId = value; }
        public string MasaNo { get => masaNo; set => masaNo = value; }
        public string YemekAdedi { get => yemekAdedi; set => yemekAdedi = value; }
        public string YemekAraTutar { get => yemekAraTutar; set => yemekAraTutar = value; }
        public string Saat { get => saat; set => saat = value; }
        public string SiparisTuru { get => siparisTuru; set => siparisTuru = value; }
        public string Gun { get => gun; set => gun = value; }
        public string Ay { get => ay; set => ay = value; }
        public string Yil { get => yil; set => yil = value; }

        public DataTable yemekBilgileriniAl()
        {
            string sorgu = "SELECT id,yemekAd FROM yemekBilgi ";
            return sqlGoster.SorguyuCalistir(sorgu);
        }
        
        public DataTable satislariGoster(string gun,string ay,string yil,int sıfırdandorde)
        {
            string sorgu = string.Format("SELECT yemekAdi,sum(yemekAdedi) AS satışadedi,sum(yemekAraTutar) AS ürünhasılatı FROM yemekSepet yespt1 INNER JOIN yemekBilgi ymkblg1 ON yespt1.yemekAdi = ymkblg1.yemekAd WHERE  gun='{0}' AND ay='{1}' AND yil= '{2}' AND ymkblg1.id/1000 = {3} GROUP BY yemekAdi",gun,ay,yil,sıfırdandorde);
            return sqlGoster.SorguyuCalistir(sorgu);
        }

    }
}

