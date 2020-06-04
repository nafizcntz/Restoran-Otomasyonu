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
    class eleman
    {
        private int elemanID;
        private string elemanAdi;
        private string elemanSoyadi;
        private string elemanSifre;
        private int elemanMaasi;
        private string elemanVasif;

        public string ElemanVasif { get => elemanVasif; set => elemanVasif = value; }
        public int ElemanMaasi { get => elemanMaasi; set => elemanMaasi = value; }
        public string ElemanSifre { get => elemanSifre; set => elemanSifre = value; }
        public string ElemanSoyadi { get => elemanSoyadi; set => elemanSoyadi = value; }
        public string ElemanAdi { get => elemanAdi; set => elemanAdi = value; }
        public int ElemanID { get => elemanID; set => elemanID = value; }

        public DataTable elemanBilgileriGoster()
        {
            string sorgu = "SELECT * FROM elemanBilgi";
            return sqlGoster.SorguyuCalistir(sorgu);

        }
        public int elemanEkle(string elemanAdi,string elemanSoyadi,string elemanSifre,int elemanMaasi,string elemanVasif)
        {
            string sorgu = string.Format("INSERT INTO elemanBilgi(elemanAdi,elemanSoyadi,elemanSifre,elemanMaasi,elemanVasif) VALUES('{0}','{1}','{2}',{3},'{4}')", elemanAdi, elemanSoyadi, elemanSifre, elemanMaasi, elemanVasif);
            return sqlDuzenle.SorgusuzCalistir(sorgu);
        }
        public int elemanGuncelle(string elemanAdi, string elemanSoyadi, string elemanSifre, int elemanMaasi, string elemanVasif,int elemanId)
        {
            string sorgu = string.Format("UPDATE elemanBilgi SET elemanAdi='{0}',"+"elemanSoyadi='{1}',"+"elemanSifre='{2}',"+"elemanMaasi={3},"+"elemanVasif='{4}'"+"WHERE elemanId={5}",elemanAdi,elemanSoyadi,elemanSifre,elemanMaasi,elemanVasif,elemanId);
            return sqlDuzenle.SorgusuzCalistir(sorgu);
        }
        public int elemanSil(int elemanId)
        {
            string sorgu =string.Format("DELETE FROM elemanBilgi WHERE elemanID={0}",elemanId);
            return sqlDuzenle.SorgusuzCalistir(sorgu);
        }

    }
}
 