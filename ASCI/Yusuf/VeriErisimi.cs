using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ASCI
{
    public class VeriErisimi
    {
        protected static string vtYolu = @"data source =  C:\Users\ASUS\Desktop\ASCI - Yedek - Copy\ASCI\bin\Debug\Restoran.db";
        public class sqlGoster : VeriErisimi
        {
            public static DataTable SorguyuCalistir(string sorgu)
            {
                SQLiteConnection baglanti = new SQLiteConnection(vtYolu);
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                SQLiteDataAdapter uyarlayıcı = new SQLiteDataAdapter(komut);
                DataTable vt = new DataTable();
                uyarlayıcı.Fill(vt);
                return vt;
            }
        }
        public class sqlDuzenle : VeriErisimi
        {
            public static int SorgusuzCalistir(string sorgu)
            {
                SQLiteConnection baglanti = new SQLiteConnection(vtYolu);
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
                komut.CommandText = sorgu;
                komut.CommandType = CommandType.Text;
                return komut.ExecuteNonQuery();
            }
        }
    }
}
//5,6,11,13,14,17,23,24,25,28,29,30,32,34,35,38,43,61,72,75,79,80,84 veri yapıları quizi(ağaçlar slaytı)