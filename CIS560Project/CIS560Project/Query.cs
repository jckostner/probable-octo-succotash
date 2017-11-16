using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CIS560Project {
    public class Query
    {
        public Query()
        {

        }

        /*public static void connectDatabase()
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=mysql.cs.ksu.edu;port=3306;database=jckostner94;uid=jckostner94;pwd=Darba1994!;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open!");
                string sql = "SELECT * FROM actorIDs WHERE name LIKE 'Tom'";
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Form1.richTextBox1.Text.Insert(0, rdr[0]);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }*/

        public static void actorQuery()
        {

        }
    }
}