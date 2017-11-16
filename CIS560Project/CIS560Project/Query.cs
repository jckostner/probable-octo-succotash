using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


public class Query
{
	public Query()
	{
    
	}
    
    public static void connectDatabase()
    {
        string connectionString = null;
        MySqlConnection cnn;
        connectionString = "server=mysql.cs.ksu.edu/jckostner94;port=3306;database=jckostner94;uid=jckostner94;pwd=Darba1994!;";
        cnn = new MySqlConnection(connectionString);
        try
        {
            cnn.Open();
            MessageBox.Show("Connection Open!");
            cnn.Close();
        } catch (Exception ex)
        {
            MessageBox.Show("Can not open connection!");
        }
    }
}
