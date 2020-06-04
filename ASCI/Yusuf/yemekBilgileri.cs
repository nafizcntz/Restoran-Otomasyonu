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
    class YemekBilgileri
    {
        protected int yemekID;
        protected string yemekAdi;
        protected string yemekFiyati;

        public int YemekID { get => yemekID; set => yemekID = value; }
        public string YemekAdi { get => yemekAdi; set => yemekAdi = value; }
        public string YemekFiyati { get => yemekFiyati; set => yemekFiyati = value; }

        public DataTable anaYemekGoster()
        {
            string sorgu = "SELECT id,yemekAd,yemekFiyat FROM yemekBilgi WHERE id/1000=0";
            return sqlGoster.SorguyuCalistir(sorgu);
        }
        public DataTable corbaGoster()
        {
            string sorgu = "SELECT id,yemekAd,yemekFiyat FROM yemekBilgi WHERE id/1000=1";
            return sqlGoster.SorguyuCalistir(sorgu);
        }
        public DataTable icecekGoster()
        {
            string sorgu = "SELECT id,yemekAd,yemekFiyat FROM yemekBilgi WHERE id/1000=4";
            return sqlGoster.SorguyuCalistir(sorgu);
        }
        public DataTable salataGoster()
        {
            string sorgu = "SELECT id,yemekAd,yemekFiyat FROM yemekBilgi WHERE id/1000=2";
            return sqlGoster.SorguyuCalistir(sorgu);
        }
        public DataTable tatliGoster()
        {
            string sorgu = "SELECT id,yemekAd,yemekFiyat FROM yemekBilgi WHERE id/1000=3";
            return sqlGoster.SorguyuCalistir(sorgu);
        }
        public int yemekEkle(string yemekAdi, int yemekID, string yemekFiyati)
        {
            string sorgu = string.Format("INSERT INTO yemekBilgi(yemekAd,id,yemekFiyat) VALUES('{0}','{1}','{2}')", yemekAdi,yemekID,yemekFiyati);
            return sqlDuzenle.SorgusuzCalistir(sorgu);
        }
        public int yemekDuzenle(string yemekAdi, string yemekFiyati)
        {
            string sorgu = string.Format("UPDATE yemekBilgi SET yemekFiyat='{0}'" + " WHERE yemekAd='{1}'",yemekFiyati,yemekAdi);
            return sqlDuzenle.SorgusuzCalistir(sorgu);
        }
        public int yemekSil(string yemekAdi)
        {
            string sorgu = string.Format("DELETE FROM yemekBilgi WHERE yemekAd='{0}'", yemekAdi);
            return sqlDuzenle.SorgusuzCalistir(sorgu);
        }
    }
}

