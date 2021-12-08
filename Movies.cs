using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT_291_Project
{
    public partial class Movies : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Movies(int acctNo)
        {
            InitializeComponent();
            acctNoHolder.Text = acctNo.ToString();
            //Comedy, Drama, Action or Foreign
            genreDropDown.Items.Add("Action");
            genreDropDown.Items.Add("Comedy");
            genreDropDown.Items.Add("Drama");
            genreDropDown.Items.Add("Action");

            userMoviesDropdown.Items.Add("My Queue");
            userMoviesDropdown.Items.Add("My Watchlist");
            userMoviesDropdown.Items.Add("My Suggestions");

            String connectionString = "Server = PLEASEDONTHACKM; Database = MovieRental; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from movies";
            if (genreDropDown.Text == "Action")
            {

                myCommand.CommandText += " where genre = " + "'Action'";
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    MovieLists.Rows.Clear();
                    while (myReader.Read())
                    {
                        MovieLists.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                    }

                    myReader.Close();
                }
                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }


            else if (genreDropDown.Text == "Comedy")
            {
                myCommand.CommandText += " where genre = " + "'Comedy'";
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    MovieLists.Rows.Clear();
                    while (myReader.Read())
                    {
                        MovieLists.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());

                        myReader.Close();
                    }
                }

                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }

            else if (genreDropDown.Text == "Drama")
            {
                myCommand.CommandText += " where genre = " + "'Drama'";
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    MovieLists.Rows.Clear();
                    while (myReader.Read())
                    {
                        MovieLists.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                    }

                    myReader.Close();
                }
                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }

            else if (genreDropDown.Text == "Foreign")
            {
                myCommand.CommandText += " where genre = " + "'Foreign'";
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    MovieLists.Rows.Clear();
                    while (myReader.Read())
                    {
                        MovieLists.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                    }

                    myReader.Close();
                }
                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }

        private void rentButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            userProfile settingsWindow = new userProfile(Int32.Parse(acctNoHolder.Text));
            settingsWindow.Show();
        }

        private void moviesSearch_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from movies ";
            if (userMoviesDropdown.Text == "My Queue")
            {
                myCommand.CommandText = "select * from movies where id = " + Int32.Parse(acctNoHolder.Text);
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    MovieLists.Rows.Clear();
                    while (myReader.Read())
                    {
                        MovieLists.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                    }

                    myReader.Close();
                }
                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }

            // CREATE A WATCHLIST TABLE
            else if (userMoviesDropdown.Text == "My Watchlist")
            {
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    MovieLists.Rows.Clear();
                    while (myReader.Read())
                    {
                        MovieLists.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                    }

                    myReader.Close();
                }
                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }

            // GET SUGGESTION LIST FROM EMPLOYEE
            else if (userMoviesDropdown.Text == "My Suggestions")
            {
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    MovieLists.Rows.Clear();
                    while (myReader.Read())
                    {
                        MovieLists.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                    }

                    myReader.Close();
                }
                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }
    }
}
