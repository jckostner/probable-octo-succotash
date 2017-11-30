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
            connectionString = "server=mysql.cs.ksu.edu;port=3306;database=rgleroux;uid=rgleroux;pwd=Team20;convert zero datetime=True";
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
            Results.Items.Clear(); //clears all items

            if(MovieTitleTextBox.Text != "")
            {
                searchMovieTitle();
            }
            else if(ActorNameCheckBox.Checked = true && ActorNameTextBox.Text != "")
            {
                if(DirectCheckBox.Checked = true && DirectorNameTextBox.Text != "")
                {
                    if(GenreCheckBox.Checked = true && GenreBox.SelectedIndex >= 0)
                    {
                        searchActorDirectorGenre(); //needs done
                    }
                    else
                    {
                        searchActorDirector();
                    }
                    
                }
                else if(GenreCheckBox.Checked = true && GenreBox.SelectedIndex >= 0)
                {
                    searchActorGenre();
                }
                else if(ReleaseCheckBox.Checked = true && (ReleasedBox1.Text != "" && ReleasedBox2.Text != ""))
                {
                    searchActorRelease();
                }
                else if(RatingCheckBox.Checked = true && RatingBox.SelectedIndex >= 0)
                {
                    searchActorRating();
                }
                else
                {
                    searchActorName(); 
                }
            } //all done
            else if(DirectCheckBox.Checked = true && DirectorNameTextBox.Text != "")
            {
                if (GenreCheckBox.Checked = true && GenreBox.SelectedIndex >= 0)
                {
                    searchDirectorGenre();
                }
                else if(ReleaseCheckBox.Checked = true && (ReleasedBox1.Text != "" && ReleasedBox2.Text != ""))
                {
                    searchDirectorRelease();
                }
                else if(RatingCheckBox.Checked = true && RatingBox.SelectedIndex >= 0)
                {
                    searchDirectorRating(); 
                }
                else
                {
                    searchDirectorName();
                }
            } //all done
            else if(CountryCheckBox.Checked = true && CountryBox.SelectedIndex >= 0)
            {
                if(GenreCheckBox.Checked = true && GenreBox.SelectedIndex >= 0)
                {
                    if(ReleaseCheckBox.Checked = true && ReleasedBox1.Text != "" && ReleasedBox2.Text != "")
                    {
                        searchCountryGenreRelease();
                    }
                    else
                    {
                        searchCountryGenre();
                    }
                    
                }
                else if(ReleaseCheckBox.Checked = true && ReleasedBox1.Text != "" && ReleasedBox2.Text != "")
                {
                    searchCountryRelease();
                }
                else if(RatingCheckBox.Checked = true && RatingBox.SelectedIndex >= 0)
                {
                    searchCountryRating();
                }
                else
                {
                    searchCountry();
                }               
            } //all done
            else if(GenreCheckBox.Checked = true && GenreBox.SelectedIndex >= 0)
            {
                if(ReleaseCheckBox.Checked = true && ReleasedBox1.Text != "" && ReleasedBox2.Text != "")
                {
                    searchGenreRelease();
                }
                else if(RatingCheckBox.Checked = true && RatingBox.SelectedIndex >= 0)
                {
                    searchGenreRating();
                }
                else
                {
                    searchGenre();
                }
                
            } //all done
            else if(ReleaseCheckBox.Checked = true && ReleasedBox1.Text != "" && ReleasedBox2.Text != "")
            {
                if(RatingCheckBox.Checked = true && RatingBox.SelectedIndex >= 0)
                {
                    searchReleaseRating();
                }
                else
                {
                    searchRelease();
                }
                
            } //all done
            else if(RatingCheckBox.Checked = true && RatingBox.SelectedIndex >= 0)
            {
                searchRating();
            } //all done
            else
            {
                MessageBox.Show("Not a valid query...");
            }
        }

        private void searchCountryGenreRelease()
        {
            string CountryGenreRelease_search = "SELECT * FROM movies m, countries c, genres g WHERE c.name ='" + CountryBox.SelectedItem.ToString()
                                                +"' AND g.genre = '" + GenreBox.SelectedItem.ToString() + "' AND m.releaseDate BETWEEN '" + ReleasedBox1.Text.ToString() + "-01-01'" + " AND '" + ReleasedBox2.Text.ToString() + "-12-31'"
                                                + " AND c.countryID = m.producedIn AND m.gID = g.genreID";

            MySqlCommand cmd = new MySqlCommand(CountryGenreRelease_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchActorDirectorGenre()
        {
            string ActorDirectorGenre_search = "SELECT * FROM movies m, actorMovies am, actorIDs aid, directorIDs did, directorMovies dm, genres g WHERE aid.name LIKE '%" 
                                                + ActorNameTextBox.Text.ToString() + "%' AND did.name LIKE '%" + DirectorNameTextBox.Text.ToString() + "%' AND g.genre = '"
                                                + GenreBox.SelectedItem.ToString() + "' AND m.movieID = am.movID AND m.movieID = dm.movID AND m.gID = g.genreID AND"
                                                + " am.actorMovieID = aid.actorID AND dm.directorMovieID = did.directorID";

            MySqlCommand cmd = new MySqlCommand(ActorDirectorGenre_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchReleaseRating()
        {
            string GenreRelease_search = "SELECT * FROM movies m, review r WHERE r.rating = '" + RatingBox.SelectedItem.ToString() + "' and  m.releaseDate BETWEEN '" + ReleasedBox1.Text.ToString() + "-01-01'" + " AND '" + ReleasedBox2.Text.ToString() + "-12-31' and m.movieID = r.movID";
            MySqlCommand cmd = new MySqlCommand(GenreRelease_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchGenreRating()
        {
            string GenreRating_search = "SELECT * FROM movies m, genres g, review r WHERE g.genre = '" + GenreBox.SelectedItem.ToString() + "' and m.gID = g.genreID and r.rating = '" + RatingBox.SelectedItem.ToString() + "' and r.movID = m.movieID";
            MySqlCommand cmd = new MySqlCommand(GenreRating_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchGenreRelease()
        {
            string GenreRelease_search = "SELECT * FROM movies m, genres g WHERE g.genre = '" + GenreBox.SelectedItem.ToString() + "' and  m.releaseDate BETWEEN '" + ReleasedBox1.Text.ToString() + "-01-01'" + " AND '" + ReleasedBox2.Text.ToString() + "-12-31' and m.gID = g.genreID";
            MySqlCommand cmd = new MySqlCommand(GenreRelease_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchCountryRating()
        {
            string CountryRating_search = "SELECT * from movies m, countries c, review r WHERE c.name = '" + CountryBox.SelectedItem.ToString() + "' AND r.rating = '" + RatingBox.SelectedItem.ToString() + "' AND r.movID = m.movieID AND c.countryID = m.producedIn";
            MySqlCommand cmd = new MySqlCommand(CountryRating_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchCountryRelease()
        {
            string CountryRelease_search = "SELECT * FROM movies m, countries c WHERE c.name = '" + CountryBox.SelectedItem.ToString() + "' and  m.releaseDate BETWEEN '" + ReleasedBox1.Text.ToString() + "-01-01'" + " AND '" + ReleasedBox2.Text.ToString() + "-12-31' and m.producedIn = c.countryID";
            MySqlCommand cmd = new MySqlCommand(CountryRelease_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchCountryGenre()
        {
            string CountryGenre_search = "SELECT * FROM countries c, genres g, movies m WHERE c.name = '" + CountryBox.SelectedItem.ToString() + "' and g.genre = '" + GenreBox.SelectedItem.ToString() + "' and g.genreID = m.gID and c.countryID = m.producedIn";
            MySqlCommand cmd = new MySqlCommand(CountryGenre_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[6].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchDirectorRating()
        {
            string DirectorRating_search = "SELECT * FROM movies m, directorIDs did, directorMovies dm, review r WHERE did.name LIKE '%" + DirectorNameTextBox.Text.ToString() + "%' and r.rating ='" + RatingBox.SelectedItem.ToString() + "' and m.movieID = r.movID AND dm.movID = m.movieID AND did.directorID = dm.directorMovieID";
            MySqlCommand cmd = new MySqlCommand(DirectorRating_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchDirectorRelease()
        {
            string DirectorRelease_Search = "SELECT * FROM directorIDs did, directorMovies dm, movies m WHERE did.name LIKE '%" + DirectorNameTextBox.Text.ToString() + "%' and did.directorID = dm.directorMovieID and dm.movID = m.movieID and m.releaseDate BETWEEN '" + ReleasedBox1.Text.ToString() + "-01-01'" + " AND '" + ReleasedBox2.Text.ToString() + "-12-31'";
            MySqlCommand cmd = new MySqlCommand(DirectorRelease_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[6].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchDirectorGenre()
        {
            string DirectorGenre_search = "SELECT * FROM movies m, directorIDs did, directorMovies dm, genres g WHERE g.genre = '" + GenreBox.SelectedItem.ToString() + "' and did.name LIKE '%" + DirectorNameTextBox.Text.ToString() + "%' and did.directorID = dm.directorMovieID and g.genreID = m.gID and dm.movID = m.movieID" ;
            MySqlCommand cmd = new MySqlCommand(DirectorGenre_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchActorRating() 
        {
            string ActorRating_search = "SELECT * FROM movies m, actorIDs aid, actorMovies am, review r WHERE aid.name LIKE '%" + ActorNameTextBox.Text.ToString() + "%' and r.rating ='" + RatingBox.SelectedItem.ToString() + "' and m.movieID = r.movID AND am.movID = m.movieID AND aid.actorID = am.actorMovieID";
            MySqlCommand cmd = new MySqlCommand(ActorRating_search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchActorRelease()
        {
            string ActorRelease_Search = "SELECT * FROM actorIDs aid, actorMovies am, movies m WHERE aid.name LIKE '%" + ActorNameTextBox.Text.ToString() + "%' and aid.actorID = am.actorMovieID and am.movID = m.movieID and m.releaseDate BETWEEN '" + ReleasedBox1.Text.ToString() + "-01-01'" + " AND '" + ReleasedBox2.Text.ToString() + "-12-31'";
            MySqlCommand cmd = new MySqlCommand(ActorRelease_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[6].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchActorGenre()
        {
            string ActorGenre_Search = "SELECT * FROM actorIDs aid, actorMovies am, genres g, movies m WHERE aid.name LIKE '%" + ActorNameTextBox.Text.ToString() + "%' and aid.actorID = am.actorMovieID and m.movieID = am.movID and g.genre ='" + GenreBox.SelectedItem.ToString() + "' and g.genreID = m.gID";
            MySqlCommand cmd = new MySqlCommand(ActorGenre_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[8].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchActorDirector()
        {
            string ActorDirector_Search = "SELECT * FROM actorIDs aid, actorMovies am, directorIDs did, directorMovies dm, movies m WHERE aid.name LIKE '%" + ActorNameTextBox.Text.ToString() + "%' and aid.actorID = am.actorMovieID and did.name LIKE '%" + DirectorNameTextBox.Text.ToString() + "%' and did.directorID = dm.directorMovieID and m.movieID = dm.movID and dm.movID = am.movID and am.movID = m.movieID";
            MySqlCommand cmd = new MySqlCommand(ActorDirector_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[10].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        } 

        private void searchRating()
        {
            string Rating_Search = "SELECT * FROM review r, movies m WHERE r.rating ='" + RatingBox.SelectedItem.ToString() + "' and m.movieID = r.movID"; //movie titles based on rating
            MySqlCommand cmd = new MySqlCommand(Rating_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[6].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        } 

        private void searchRelease()
        {
            string Between_Search = "SELECT * FROM movies m WHERE m.releaseDate BETWEEN '" + ReleasedBox1.Text.ToString() + "-01-01'" + " AND '" + ReleasedBox2.Text.ToString() + "-12-31'"; //gets movies between the two dates
            MySqlCommand cmd = new MySqlCommand(Between_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchGenre()
        {
            string Genre_Search = "SELECT * FROM genres g, movies m WHERE g.genre ='" + GenreBox.SelectedItem.ToString() + "' and g.genreID = m.gID"; //movie titles based on genre
            MySqlCommand cmd = new MySqlCommand(Genre_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[4].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchCountry()
        {           
            string Country_Search = "SELECT * FROM countries c, movies m WHERE c.name ='" + CountryBox.SelectedItem.ToString() + "' and c.countryID = m.producedIn"; //movie titles based on country
            MySqlCommand cmd = new MySqlCommand(Country_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[4].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchDirectorName()
        {
            string DirectorName_Search = "SELECT * FROM directorIDs did, directorMovies dm, movies m WHERE did.name LIKE '%" + DirectorNameTextBox.Text.ToString() + "%' and did.directorID = dm.directorMovieID and m.movieID = dm.movID"; //gets movie titles based on director
            MySqlCommand cmd = new MySqlCommand(DirectorName_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[6].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchMovieTitle()
        {
            //Gets all movie titles that are like what is typed in the textbox
            string Title_Search = "SELECT * FROM movies WHERE name LIKE '%" + MovieTitleTextBox.Text.ToString() + "%'"; 
            MySqlCommand cmd = new MySqlCommand(Title_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[2].ToString());                   
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void searchActorName()
        {
            //movie titles based on actor name
            string ActorName_Search = "SELECT * FROM actorIDs aid, actorMovies am, movies m WHERE aid.name LIKE '%" + ActorNameTextBox.Text.ToString() + "%' and aid.actorID = am.actorMovieID and m.movieID = am.movID"; //gets movie titles based on actor
            MySqlCommand cmd = new MySqlCommand(ActorName_Search, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            do
            {
                while (rdr.Read())
                {
                    Results.Items.Add(rdr[6].ToString());
                }
            } while (rdr.NextResult());
            rdr.Close();
        }

        private void ActorNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ActorNameCheckBox.Checked == true)
            {
                ActorNameTextBox.Enabled = true;
                CountryCheckBox.Enabled = false;
                
            }
            else
            {
                ActorNameTextBox.Enabled = false;
                CountryCheckBox.Enabled = true;
                
            }
        }

        private void DirectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(DirectCheckBox.Checked == true)
            {
                DirectorNameTextBox.Enabled = true;
                CountryCheckBox.Enabled = false;
            }
            else
            {
                DirectorNameTextBox.Enabled = false;
                CountryCheckBox.Enabled = true;
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Resets all fields 
            Results.Items.Clear();
            MovieTitleTextBox.Text = "";
            ActorNameTextBox.Text = "";
            DirectorNameTextBox.Text = "";
            CountryBox.SelectedIndex = -1;
            CountryBox.Text = "Please Select";
            GenreBox.SelectedIndex = -1;
            GenreBox.Text = "Please Select";
            ReleasedBox1.Text = "";
            ReleasedBox2.Text = "";
            RatingBox.SelectedIndex = -1;
            RatingBox.Text = "Please Select";
            ActorNameCheckBox.Checked = false;
            DirectCheckBox.Checked = false;
            CountryCheckBox.Checked = false;
            GenreCheckBox.Checked = false;
            RatingCheckBox.Checked = false;
            ReleaseCheckBox.Checked = false;
            

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportResultsBox.Items.Clear();
            //Checks if one of the items is selected.
            if (Results.SelectedItem != null)
            {
                tabControl1.SelectTab(1);
                string[] MovieInfo = new string[10];
                string[] results = new string[10];

                string MovieInfoString = "SELECT * FROM movies WHERE name = '" + Results.SelectedItem + "'";
                MySqlCommand cmd = new MySqlCommand(MovieInfoString, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                do
                {
                    for(int i = 0; i < rdr.FieldCount; i++)
                    {
                        rdr.Read();
                        MovieInfo[i] = rdr[i].ToString();
                    }
                } while (rdr.NextResult());
                rdr.Close();
                reportResultsBox.Items.Add(MovieInfo[2]);
                reportResultsBox.Items.Add("    Release Date: " + MovieInfo[1].Substring(0, 8));
                reportResultsBox.Items.Add("    Length (min): " + MovieInfo[3]);

                string GenreString = "SELECT * FROM genres WHERE genreID = '" + MovieInfo[4] + "'";
                cmd = new MySqlCommand(GenreString, cnn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                results[0] = rdr[1].ToString();
                rdr.Close();
                reportResultsBox.Items.Add("    Genre: " + results[0]);

                string ProducerString = "SELECT * FROM companies WHERE companyID = '" + MovieInfo[5] + "'";
                cmd = new MySqlCommand(ProducerString, cnn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                results[0] = rdr[1].ToString();
                rdr.Close();
                reportResultsBox.Items.Add("    Producer: " + results[0]);

                string CountryString = "SELECT * FROM countries WHERE countryID = '" + MovieInfo[6] + "'";
                cmd = new MySqlCommand(CountryString, cnn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                results[0] = rdr[1].ToString();
                rdr.Close();
                reportResultsBox.Items.Add("    Country: " + results[0]);

                string DirectorString = "SELECT * FROM directorMovies JOIN directorIDs ON " +
                    "directorMovies.directorMovieID = directorIDs.directorID  WHERE movID = '" + 
                    MovieInfo[0] + "'";
                cmd = new MySqlCommand(DirectorString, cnn);
                rdr = cmd.ExecuteReader();
                rdr.Read();
                results[0] = rdr[3].ToString();
                rdr.Close();
                reportResultsBox.Items.Add("    Director: " + results[0]);

                string ActorsString = "SELECT * FROM actorMovies JOIN actorIDs ON actorMovies.actorMovieID" +
                    "=actorIDs.actorID WHERE movID = '" + MovieInfo[0] + "'";
                cmd = new MySqlCommand(ActorsString, cnn);
                rdr = cmd.ExecuteReader();
                reportResultsBox.Items.Add("    Actors: ");
                do
                {
                    while (rdr.Read())
                    {
                        reportResultsBox.Items.Add("        " + rdr[3].ToString());
                    }
                } while (rdr.NextResult());
                rdr.Close();

            }
        }
    }
}
