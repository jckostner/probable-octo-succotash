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

            Tab.Selected += new TabControlEventHandler(Tab_Selected);
            AdminDisplay.SelectedIndexChanged += new EventHandler(AdminDisplay_Click);
            
            //Sets all fields to false, until checked
            ActorNameTextBox.Enabled = false;
            DirectorNameTextBox.Enabled = false;
            CountryBox.Enabled = false;
            GenreBox.Enabled = false;
            ReleasedBox1.Enabled = false;
            ReleasedBox2.Enabled = false;
            RatingBox.Enabled = false;

        }

        private void AdminDisplay_Click(object sender, EventArgs e)
        {
            if(AdminDisplay.SelectedItem != null)
            {
                AdminSelect.Enabled = true;
            }
        }

        private void Tab_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage.Name == tabPage3.Name)
            {
                DisableAdmin();
                ClearAdmin();
            }
            else
            {

            }
        }

        private void ClearAdmin()
        {
            AdminActor.Text = "";
            AdminCountry.Text = "Please Select";
            AdminGenre.Text = "Please Select";
            AdminDirector.Text = "";
            AdminLength.Text = "";
            AdminRating.Text = "Please Select";
            AdminSound.Text = "";
            AdminTracks.Text = "";
            AdminReview.Text = "Please Select";
            AdminRelease.Text = "";
            AdminMovie.Text = "";
            AdminSearch.Text = "";
            AdminDisplay.Items.Clear();
            AdminDisplay.Enabled = false;
            AdminSelect.Enabled = false;
            AdminProducer.Text = "";
            DisableAdmin();
        }

        private void DisableAdmin()
        {
            
            AdminDelete.Enabled = false;     
            AdminUpdate.Enabled = false;
            AdminSelect.Enabled = false;
            AdminDisplay.Enabled = false;
        }

        private void EnableAdmin()
        {
            AdminDelete.Enabled = true;
            AdminUpdate.Enabled = true;
            AdminSelect.Enabled = true;
            AdminDisplay.Enabled = true;
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

        //this starts the lsit of queries
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
        //end list of queries

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
            //Checks if one of the items is selected.
            if(Results.SelectedItem != null)
            {
                if (Results.SelectedItem.ToString()[0] != ' ')
                {
                    string[] MovieInfo = new string[10];
                    string[] results = new string[10];

                    string MovieInfoString = "SELECT * FROM movies WHERE name = '" + Results.SelectedItem + "'";
                    Results.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand(MovieInfoString, cnn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    do
                    {
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            rdr.Read();
                            if (i == 1)
                            {
                                System.DateTime dt = (System.DateTime)rdr.GetValue(i);
                                MovieInfo[i] = dt.Month + "/" + dt.Day + "/" + dt.Year;
                            }
                            else
                            {
                                MovieInfo[i] = rdr[i].ToString();
                            }
                        }
                    } while (rdr.NextResult());
                    rdr.Close();
                    Results.Items.Add(MovieInfo[2]);
                    Results.Items.Add("    Release Date: " + MovieInfo[1]);
                    Results.Items.Add("    Length (min): " + MovieInfo[3]);

                    string ReviewString = "SELECT * FROM review WHERE movID = '" + MovieInfo[0] + "'";
                    cmd = new MySqlCommand(ReviewString, cnn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        results[0] = rdr[2].ToString();
                    }
                    rdr.Close();
                    Results.Items.Add("    Rating: " + results[0]);

                    string GenreString = "SELECT * FROM genres WHERE genreID = '" + MovieInfo[4] + "'";
                    cmd = new MySqlCommand(GenreString, cnn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        results[0] = rdr[1].ToString();
                    }
                    rdr.Close();
                    Results.Items.Add("    Genre: " + results[0]);

                    string ProducerString = "SELECT * FROM companies WHERE companyID = '" + MovieInfo[5] + "'";
                    cmd = new MySqlCommand(ProducerString, cnn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        results[1] = rdr[1].ToString();
                    }
                    rdr.Close();
                    Results.Items.Add("    Producer: " + results[1]);

                    string CountryString = "SELECT * FROM countries WHERE countryID = '" + MovieInfo[6] + "'";
                    cmd = new MySqlCommand(CountryString, cnn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        results[2] = rdr[1].ToString();
                    }
                    rdr.Close();
                    Results.Items.Add("    Country: " + results[2]);

                    string DirectorString = "SELECT * FROM directorMovies JOIN directorIDs ON " +
                        "directorMovies.directorMovieID = directorIDs.directorID  WHERE movID = '" +
                        MovieInfo[0] + "'";
                    cmd = new MySqlCommand(DirectorString, cnn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        results[3] = rdr[3].ToString();
                    }
                    rdr.Close();
                    Results.Items.Add("    Director: " + results[3]);

                    string ActorsString = "SELECT * FROM actorMovies JOIN actorIDs ON actorMovies.actorMovieID" +
                        "=actorIDs.actorID WHERE movID = '" + MovieInfo[0] + "'";
                    cmd = new MySqlCommand(ActorsString, cnn);
                    rdr = cmd.ExecuteReader();
                    Results.Items.Add("    Actors: ");
                    do
                    {
                        while (rdr.Read())
                        {
                            Results.Items.Add("        " + rdr[3].ToString());
                        }
                    } while (rdr.NextResult());
                    rdr.Close();
                }
                else if (!Results.SelectedItem.ToString().Substring(0, 8).Equals("        ") &&
                 Results.SelectedItem.ToString().Split(':').Length == 2)
                {
                    string[] itemSplit = Results.SelectedItem.ToString().Split(':');
                    itemSplit[1] = itemSplit[1].Substring(1);
                    Results.Items.Clear();

                    if (itemSplit[0] == "    Genre")
                    {
                        string MoviesByGenreString = "SELECT * FROM movies JOIN genres ON movies.gID=genres.genreID " +
                            "WHERE genre = '" + itemSplit[1] + "' ORDER BY movies.name";
                        MySqlCommand cmd = new MySqlCommand(MoviesByGenreString, cnn);
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
                    else if (itemSplit[0] == "    Country")
                    {
                        string MoviesByCountryString = "SELECT * FROM movies JOIN countries ON movies.cID = countries.countryID " +
                            "WHERE countries.name = '" + itemSplit[1] + "' ORDER BY movies.name";
                        MySqlCommand cmd = new MySqlCommand(MoviesByCountryString, cnn);
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
                    else if (itemSplit[0] == "    Director")
                    {
                        string MoviesByDirectorString = "SELECT * FROM movies JOIN directorMovies ON movies.movieID=directorMovies.movID " +
                            "JOIN directorIDs on directorMovies.directorMovieID=directorIDs.directorID WHERE directorIDs.name = '" + itemSplit[1] +
                            "' ORDER BY movies.name";
                        MySqlCommand cmd = new MySqlCommand(MoviesByDirectorString, cnn);
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
                    else if (itemSplit[0] == "    Actor")
                    {

                    }
                }
                else
                {
                    string MoviesByActorsString = "SELECT * FROM movies JOIN actorMovies ON movies.movieID=actorMovies.movID " +
                        "JOIN actorIDs on actorMovies.actorMovieID=actorIDs.actorID WHERE actorIDs.name = '" + Results.SelectedItem.ToString().Substring(8)
                        + "' ORDER BY movies.name";
                    MySqlCommand cmd = new MySqlCommand(MoviesByActorsString, cnn);
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
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton02_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton02.Checked == true)
            {
                radioButton15.Enabled = false;
                radioButton16.Enabled = false;
            }
            else
            {
                radioButton15.Enabled = true;
                radioButton16.Enabled = true;
            }
        }

        private void AdminClear_Click(object sender, EventArgs e)
        {
            ClearAdmin();
        }

        private void AdminSearchButton_Click(object sender, EventArgs e)
        {
            if(AdminSearch.Text == "")
            {
                MessageBox.Show("Please Enter a Movie Title First");
            }
            else
            {
                AdminDisplay.Items.Clear(); //clears out all previous movie titles

                //populate movie titles
                string MovieInfoString = "SELECT * FROM movies WHERE name LIKE '%" + AdminSearch.Text.ToString() + "%'";
                MySqlCommand cmd = new MySqlCommand(MovieInfoString, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                do
                {
                    while (rdr.Read())
                    {
                        AdminDisplay.Items.Add(rdr[2].ToString());
                    }
                } while (rdr.NextResult());
                rdr.Close();
                AdminDisplay.Enabled = true;
                
            }
        }

        private void AdminSelect_Click(object sender, EventArgs e)
        {
            //options to delete and update
            AdminDelete.Enabled = true;
            AdminUpdate.Enabled = true;

            string[] MovieInfo = new string[10];
            string[] results = new string[10];

            string MovieInfoString = "SELECT * FROM movies WHERE name = '" + AdminDisplay.SelectedItem + "'";
            MySqlCommand cmd = new MySqlCommand(MovieInfoString, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            do
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    rdr.Read();
                    MovieInfo[i] = rdr[i].ToString();
                }
            } while (rdr.NextResult());
            rdr.Close();

            AdminMovie.Text = MovieInfo[2]; //sets movie title
            AdminRelease.Text = MovieInfo[1].Substring(0, 8); //sets release date
            AdminLength.Text = MovieInfo[3]; //sets movie length

            //Genre Search
            string GenreString = "SELECT * FROM genres WHERE genreID = '" + MovieInfo[4] + "'";
            cmd = new MySqlCommand(GenreString, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[1].ToString();
            rdr.Close();
            AdminGenre.SelectedItem = results[0]; //sets movie genre

            //Company Search
            string ProducerString = "SELECT * FROM companies WHERE companyID = '" + MovieInfo[5] + "'";
            cmd = new MySqlCommand(ProducerString, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[1].ToString();
            rdr.Close();
            AdminProducer.Text = results[0]; //sets movie producer

            //Country Search
            string CountryString = "SELECT * FROM countries WHERE countryID = '" + MovieInfo[6] + "'";
            cmd = new MySqlCommand(CountryString, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[1].ToString();
            rdr.Close();
            AdminCountry.SelectedItem = results[0]; //sets movie country

            //Director Search
            string DirectorString = "SELECT * FROM directorMovies JOIN directorIDs ON " +
                    "directorMovies.directorMovieID = directorIDs.directorID  WHERE movID = '" +
                    MovieInfo[0] + "'";
            cmd = new MySqlCommand(DirectorString, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[3].ToString();
            rdr.Close();
            AdminDirector.Text = results[0];

            //Actor Search
            string ActorsString = "SELECT * FROM actorMovies JOIN actorIDs ON actorMovies.actorMovieID" +
                    "=actorIDs.actorID WHERE movID = '" + MovieInfo[0] + "'";
            cmd = new MySqlCommand(ActorsString, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[3].ToString();
            rdr.Close();
            AdminActor.Text = results[0];

            //Rating Search
            string RatingString = "SELECT * FROM review JOIN movies on review.movID = movies.movieID WHERE movID = '" + MovieInfo[0] + "'";
            cmd = new MySqlCommand(RatingString, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[2].ToString();
            rdr.Close();
            AdminRating.SelectedIndex = Convert.ToInt32(results[0]) - 1;
            AdminRating.SelectedItem = results[0];

            //Sound Track Search
            string SoundTrackSearch = "SELECT * FROM soundTracks JOIN movies on soundTracks.movID = movies.movieID WHERE movID = '" + MovieInfo[0] + "'";
            cmd = new MySqlCommand(SoundTrackSearch, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[1].ToString();
            rdr.Close();
            AdminSound.Text = results[0];

            //Sound Track # search
            string SoundTrackNumSearch = "SELECT * FROM soundTracks JOIN movies on soundTracks.movID = movies.movieID WHERE movID = '" + MovieInfo[0] + "'";
            cmd = new MySqlCommand(SoundTrackNumSearch, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[3].ToString();
            rdr.Close();
            AdminTracks.Text = results[0];


            //Reviewed by Search
            string ReviewBySearch = "SELECT * FROM reviewers JOIN review ON reviewers.reviewerID = review.rID WHERE movID = '" + MovieInfo[0] + "'";
            cmd = new MySqlCommand(ReviewBySearch, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            results[0] = rdr[1].ToString();
            rdr.Close();
            AdminReview.SelectedItem = results[0];
        }

        private void AdminDelete_Click(object sender, EventArgs e)
        {
            //get movieID
            string getMovieID = "SELECT movieID FROM movies WHERE name ='" + AdminDisplay.SelectedItem + "'";
            MySqlCommand cmd = new MySqlCommand(getMovieID, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int movieID = Convert.ToInt32(rdr[0]);
            rdr.Close();


            //Deletes the movie
            string DeleteMovie = "DELETE FROM movies WHERE name ='" + AdminDisplay.SelectedItem + "'";
            cmd = new MySqlCommand(DeleteMovie, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Close();

            //deltes from actorMovies
            string DeleteActorMovie = "DELETE FROM actorMovies WHERE movID = '" + movieID.ToString() + "'";
            cmd = new MySqlCommand(DeleteActorMovie, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Close();

            //delete rating
            string DeleteRating = "DELETE FROM review WHERE movID = '" + movieID.ToString() + "'";
            cmd = new MySqlCommand(DeleteRating, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Close();

            //delete sound tracks
            string DeleteST = "DELETE FROM soundTracks WHERE movID = '" + movieID.ToString() + "'";
            cmd = new MySqlCommand(DeleteST, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Close();

            //delete directorMovie
            string DeleteDirectorMovie = "DELETE FROM directorMovies WHERE movID = '" + movieID.ToString() + "'";
            cmd = new MySqlCommand(DeleteDirectorMovie, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Close();
        } //works

        private void AdminUpdate_Click(object sender, EventArgs e)
        {
            //get movieID
            string getMovieID = "SELECT movieID FROM movies WHERE name ='" + AdminDisplay.SelectedItem.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(getMovieID, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int movieID = Convert.ToInt32(rdr[0]);
            rdr.Close();

            string MovieNameUpdate = "UPDATE movies SET releaseDate = '" + AdminRelease.Text + "', name = '" + AdminMovie.Text + "', movielength = '" 
                                      + AdminLength.Text + "', gID ='" + (AdminGenre.SelectedIndex + 1) + "' WHERE movieID = '" + movieID + "'";
            cmd = new MySqlCommand(MovieNameUpdate, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            rdr.Close();

            //string ActorUpdate = "UPDATE actorMovies SET movID = '" + movieID + "' WHERE actorMovieID = actorIDs.actorID AND actorIDs.name = '" + AdminActor.Text + "'";

            MessageBox.Show("Update Successfull");
            ClearAdmin();
        } //not done

        private void AdminAdd_Click(object sender, EventArgs e)
        {
            string MaxMID = "SELECT MAX(movieID) FROM movies";
            MySqlCommand cmd = new MySqlCommand(MaxMID, cnn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int max = Convert.ToInt32(rdr[0]);
            rdr.Close();

            string AddMovies = "INSERT INTO movies (movieID, releaseDate, name, movieLength, gID, cID, producedIn) VALUES ('"
                + (max + 1) + "', '" + AdminRelease.Text + "', '" + AdminMovie.Text + "', '" + AdminLength.Text + "', '" + (AdminGenre.SelectedIndex + 1) + "', '"
                + 1 + "', '" + (AdminCountry.SelectedIndex + 1) + "')";
            MessageBox.Show(AddMovies);
            cmd = new MySqlCommand(AddMovies, cnn);
            rdr = cmd.ExecuteReader();
            rdr.Close();
        } //kinda works
    }
}
