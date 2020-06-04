using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace ASCI
{
     class Sql
    {
        private static string yol = @"data source = "+ Application.StartupPath + "\\" + "Restoran.db";

        public static DataTable select(string query)
        {
            
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            
            return datatable;
            
        }
        public static int read(string query,int value)
        {
            int readed = 0;
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                readed = int.Parse(da.GetValue(value).ToString());
            }
            
            
            return readed;
            
        }

        public static int sqlcommand(string query)
        {
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            
            return cmd.ExecuteNonQuery();
            
        }

        public static void dataFromGridView(System.Windows.Forms.DataGridView r)
        {
            SQLiteConnection con = new SQLiteConnection(yol);
            con.Open();
            for(int i=0; i<r.Rows.Count - 1; i++)
            {
                string command = string.Format("INSERT INTO deliverer (Name,Surname,Number,Address,Orders,TotalPrice) VALUES('{0}','{1}','{2}','{3}','{4}',{5})" 
                    ,r.Rows[i].Cells[0].Value, r.Rows[i].Cells[1].Value, r.Rows[i].Cells[2].Value, r.Rows[i].Cells[3].Value, r.Rows[i].Cells[4].Value, r.Rows[i].Cells[5].Value);
                SQLiteCommand cmd = new SQLiteCommand(command, con);
                cmd.ExecuteNonQuery();
                


            }
           
            
        }

                
    }

    

}


   