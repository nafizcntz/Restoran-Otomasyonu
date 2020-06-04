using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace ASCI
{
    class girisSunucu
    {
        //SqlConnection dba = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");

        SQLiteConnection db = new SQLiteConnection(@"data source=C:\Users\abdll\Desktop\Restoran.db");
        public List<string> userName = new List<string>();
        public List<string> password = new List<string>();
        public List<string> authorization = new List<string>();
        public int isBlock = 0 , errorCount = 0;

        public void controlBlock()
        {
            db.Open();
            //SqlCommand komut = new SqlCommand("Select *from block", db);
            //SqlDataReader oku = komut.ExecuteReader();
            SQLiteCommand komut = new SQLiteCommand("Select *from block", db);
            SQLiteDataReader oku = komut.ExecuteReader();
            oku.Read();
            isBlock = Int32.Parse((oku["isBlock"]).ToString());
            errorCount = Int32.Parse((oku["errorCount"]).ToString());

            db.Close();
        }

        /*
        public void errorUpdate(int errorCount)
        {
            try { db.Open(); } catch (Exception e) { }

            SQLiteCommand komut1 = new SQLiteCommand(" Update yemekSepet set yemekAdedi='" + "fgdgfd" + "' , yemekAraTutar='" + "dfgdfg" + "'  where id=(" + 1 + ")", db);
            komut1.ExecuteNonQuery();

            /*
            if (errorCount == -1)
            {
                //SqlCommand komut = new SqlCommand("Update block set isBlock='" + 0 + "' , errorCount= '" + 0 + "' ", db);
                //SQLiteCommand komut = new SQLiteCommand("Update block set isBlock='" + 0 + "' , errorCount= '" + 0 + "' ", db);
                SQLiteCommand komut = new SQLiteCommand("UPDATE block set isBlock = '0', errorCount = 0", db);
                komut.ExecuteNonQuery();
                
            }
            else if (errorCount <3)
            {
                //SqlCommand komut = new SqlCommand("Update block set errorCount='" + errorCount + "' ", db);
                //SQLiteCommand komut = new SQLiteCommand("Update block set errorCount='" + errorCount + "' ", db);
                SQLiteCommand komut = new SQLiteCommand("UPDATE block set errorCount = '"+errorCount+"' ", db);
                komut.ExecuteNonQuery();
            }
            else if(errorCount >= 3)
            {
                //SqlCommand komut = new SqlCommand("Update block set isBlock='" + 1 + "' , errorCount= '"+ errorCount+"' ", db);
                //SQLiteCommand komut = new SQLiteCommand("Update block set isBlock='" + 1 + "' , errorCount= '" + errorCount + "' ", db);
                SQLiteCommand komut = new SQLiteCommand("UPDATE block set isBlock = '1', errorCount = '"+errorCount.ToString()+"' ", db);
                komut.ExecuteNonQuery();
            }
            

            db.Close();
        }*/ 
    
        public void getData()
        {
            userName.Clear(); password.Clear(); authorization.Clear();
            db.Open();
            //SqlCommand komut = new SqlCommand("Select *from users", db);
            //SqlDataReader oku = komut.ExecuteReader();

            SQLiteCommand komut = new SQLiteCommand("Select *from users", db);
            SQLiteDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                userName.Add(oku["userName"].ToString().Trim());
                password.Add(oku["password"].ToString().Trim());
                authorization.Add(oku["authorization"].ToString().Trim());

            }
            
            db.Close();
        }

        /*
        public void resetError()
        {
            db.Open();
            SqlCommand komut = new SqlCommand("Update block set isBlock='" + 0 + "' , errorCount= '" + 0 + "' ", dba);
            //SQLiteCommand komut = new SQLiteCommand("Update block set isBlock='" + 0 + "' , errorCount= '" + 0 + "' ", db);
            komut.ExecuteNonQuery();

            db.Close();
        }
        */




    }

    
}
