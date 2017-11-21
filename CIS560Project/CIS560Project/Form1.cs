using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CIS560Project
{
    public partial class Form1 : Form
    {

        private MySqlConnection cnn;

        public Form1()
        {
            InitializeComponent();
            connect(); //Used to Connect to DataBase

            //Sets all fields to false, until checked
            ActorNameTextBox.Enabled = false;
            DirectorNameTextBox.Enabled = false;
            CountryBox.Enabled = false;
            GenreBox.Enabled = false;
            ReleasedBox1.Enabled = false;
            ReleasedBox2.Enabled = false;
            RatingBox.Enabled = false;
        }

        private void connect()
        {
            string connectionString = null;
            connectionString = "server=mysql.cs.ksu.edu;port=3306;database=rgleroux;uid=rgleroux;pwd=Team20;";
            cnn = new MySqlConnection(connectionString);

            //attempts to open the connection
            try
            {
                cnn.Open();                
                MessageBox.Show("Connection Open!");
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection!");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //starts list of queries
            string Title_Search = "SELECT * FROM movies WHERE name LIKE '%" + MovieTitleTextBox.Text.ToString() + "%'"; //Gets movie title - 1
            string ActorName_Search = "SELECT * FROM actorIDs aid, actorMovies am, movies m WHERE aid.name ='" + ActorNameTextBox.Text.ToString() + "' and aid.actorID = am.actorMovieID and m.movieID = am.movID"; //6 is movie title

            MySqlCommand cmd = new MySqlCommand(ActorName_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
               richTextBox1.Text = rdr[0].ToString() + rdr[6].ToString();
            }
           
        }

        private void ActorNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ActorNameCheckBox.Checked == true)
            {
                ActorNameTextBox.Enabled = true;
            }
            else
            {
                ActorNameTextBox.Enabled = false;
            }
        }

        private void DirectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(DirectCheckBox.Checked == true)
            {
                DirectorNameTextBox.Enabled = true;
            }
            else
            {
                DirectorNameTextBox.Enabled = false;
            }
        }

        private void CountryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CountryCheckBox.Checked == true)
            {
                CountryBox.Enabled = true;
            }
            else
            {
                CountryBox.Enabled = false;
            }
        }

        private void GenreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(GenreCheckBox.Checked ==  true)
            {
                GenreBox.Enabled = true;
            }
            else
            {
                GenreBox.Enabled = false;
            }
        }

        private void ReleaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ReleaseCheckBox.Checked == true)
            {
                ReleasedBox1.Enabled = true;
                ReleasedBox2.Enabled = true;
            }
            else
            {
                ReleasedBox1.Enabled = false;
                ReleasedBox2.Enabled = false;
            }
        }

        private void RatingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(RatingCheckBox.Checked == true)
            {
                RatingBox.Enabled = true;
            }
            else
            {
                RatingBox.Enabled = false;
            }
        }
    }
}
