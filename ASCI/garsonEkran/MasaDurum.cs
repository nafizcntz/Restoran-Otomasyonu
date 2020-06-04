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
    class MasaDurum
    {
        //SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RILS1DJ\\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");
        SQLiteConnection baglan = new SQLiteConnection(@"data source=C:\Users\abdll\Desktop\Restoran.db");

        public string masaDurum;
        public Button[] dizi = new Button[21];
        public String[] masaDurumList = new String[21];


        public void masaAc(MasaSecimEkran form1,int selectedTable,Panel secimPaneli)
        {
            try { baglan.Open(); } catch (Exception e) { }

            //SqlCommand komut = new SqlCommand(" Update masaBilgi set masaDurum='" + "1" + "' where masaNo=(" + selectedTable + ")", baglan);
            SQLiteCommand komut = new SQLiteCommand("Update masaBilgi set masaDurum='" + "1" + "' where masaNo=(" + selectedTable + ")", baglan);
            komut.ExecuteNonQuery();
            koltukYenile();
            secimPaneli.Visible = false;

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i].Enabled = true;
            }
            baglan.Close();
            MasaMenuEkran form2 = new MasaMenuEkran();
            form2.Show();
            form1.Hide();

        }
        public void koltukYenile()
        {
            try
            {
                try { baglan.Open(); } catch (Exception e) { }

                //SqlCommand komut = new SqlCommand("Select *from masaBilgi", baglan);
                //SqlDataReader oku = komut.ExecuteReader();

                SQLiteCommand komut = new SQLiteCommand("Select *from masaBilgi", baglan);
                SQLiteDataReader oku = komut.ExecuteReader();

                for (int i = 0; oku.Read(); i++)
                {
                    masaDurum = oku["masaDurum"].ToString();
                    if ( masaDurum == "0") { dizi[i].BackColor = Color.Lime; }
                    else { dizi[i].BackColor = Color.Crimson; }
                    masaDurumList[i] = masaDurum;
                }
                oku.Close();
                baglan.Close();

            }
            catch (Exception e)
            {
            
            }
        }
        
    }
}
