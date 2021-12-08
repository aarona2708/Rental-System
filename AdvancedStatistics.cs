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
    public partial class AdvancedStatistics : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public AdvancedStatistics()
        {
            InitializeComponent();
            String connectionString = "Server = IANPC; Database = MovieRental; Trusted_Connection = yes;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            System.Data.SqlClient.SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

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


        private void button1_Click(object sender, EventArgs e)
        {
            int queryOption = queryBox.SelectedIndex;

            if (queryOption == 1 || queryOption == 4)
            {
                selectGenreComboBox.Show();
                selectGenreLabel.Show();
            }
            else
            {
                selectGenreComboBox.Hide();
                selectGenreLabel.Hide();
            }

            switch (queryOption)
            {
                case 0:
                    displayListView.Clear();
                    ShowBelowAverageRenters();
                    break;

                case 1:
                    if (selectGenreComboBox.SelectedIndex != -1)
                    {
                        displayListView.Clear();
                        ShowUsersWhoHaveNotRentedGenre(selectGenreComboBox.SelectedItem.ToString());
                    }
                    break;

                case 2:
                    displayListView.Clear();
                    ShowUsersWhoHaveRentedAllGenres();
                    break;

                case 3:
                    displayListView.Clear();
                    ShowMoviesRentedAboveAverage();
                    break;

                case 4:
                    if (selectGenreComboBox.SelectedIndex != -1)
                    {
                        displayListView.Clear();
                        ShowUsersWhoRentGenreMoreThanAverage(selectGenreComboBox.SelectedItem.ToString());
                    }
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAndEmployee2 main = new UserAndEmployee2();
            main.Show();
        }

        private void AdvancedStatistics_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowBelowAverageRenters()
        {
            myCommand.CommandText =
                    "SELECT account_number, first_name, last_name, COUNT(customer_id) rentals " +
                    "FROM orders o " +
                    "RIGHT JOIN customers c ON o.customer_id = c.account_number " +
                    "GROUP BY account_number, first_name, last_name " +
                    "HAVING COUNT(customer_id) < (" +
                        "SELECT AVG(rental_count.rentals) avg_rentals " +
                        "FROM(" +
                            "SELECT COUNT(account_number) rentals " +
                            "FROM customers c JOIN orders o ON c.account_number = o.customer_id " +
                            "GROUP BY customer_id" +
                        ") rental_count" +
                    ")";
            try
            {
                ReformatColumns(new List<string> { "Account Number", "First Name", "Last Name", "Rentals" });
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    ListViewItem item = new ListViewItem(myReader["account_number"].ToString());
                    item.SubItems.Add(myReader["first_name"].ToString());
                    item.SubItems.Add(myReader["last_name"].ToString());
                    item.SubItems.Add(myReader["rentals"].ToString());

                    displayListView.Items.Add(item);
                }

                myReader.Close();
                ShowResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void ShowUsersWhoHaveNotRentedGenre(string genre)
        {
            myCommand.CommandText = 
                "SELECT customer_id, first_name, last_name " +
                "FROM orders o " +
                "JOIN customers c ON o.customer_id = c.account_number " +
                "JOIN movies m ON o.movie_id = m.id " +
                "WHERE customer_id NOT IN (" +
                    "SELECT customer_id " +
                    "FROM orders o JOIN movies m ON o.movie_id = m.id " +
                    "WHERE genre = '" + genre + "' " +
                    "GROUP BY customer_id, genre" +
                ") " +
                "GROUP BY customer_id, first_name, last_name " +
                "ORDER BY customer_id";
            try
            {
                ReformatColumns(new List<string> {"Customer ID", "First Name", "Last Name"});
                myCommand.Parameters.Add(new SqlParameter("@genre", genre));
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    ListViewItem item = new ListViewItem(myReader["customer_id"].ToString());
                    item.SubItems.Add(myReader["first_name"].ToString());
                    item.SubItems.Add(myReader["last_name"].ToString());

                    displayListView.Items.Add(item);
                }

                myReader.Close();
                myCommand.Parameters.Clear();
                ShowResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void ShowUsersWhoHaveRentedAllGenres()
        {
            myCommand.CommandText =
                "SELECT DISTINCT account_number, first_name, last_name " +
                "FROM orders o RIGHT JOIN customers c ON o.customer_id = c.account_number " +
                "LEFT JOIN movies m ON o.movie_id = m.id WHERE NOT EXISTS( " +
                    "SELECT DISTINCT genre " +
                    "FROM movies m " +
                    "WHERE genre NOT IN( " +
                        "SELECT genre " +
                        "FROM( " +
                            "SELECT DISTINCT account_number, genre " +
                            "FROM orders o RIGHT JOIN customers c ON o.customer_id = c.account_number " +
                            "LEFT JOIN movies m ON o.movie_id = m.id " +
                        ") account_genres " +
                        "WHERE account_genres.account_number = c.account_number AND genre IS NOT NULL" +
                    ")" +
                ")";
            try
            {
                ReformatColumns(new List<string> { "Account Number", "first_name", "last_name" });
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    ListViewItem item = new ListViewItem(myReader["account_number"].ToString());
                    item.SubItems.Add(myReader["first_name"].ToString());
                    item.SubItems.Add(myReader["last_name"].ToString());

                    displayListView.Items.Add(item);
                }

                myReader.Close();
                ShowResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void ShowMoviesRentedAboveAverage()
        {
            myCommand.CommandText =
                "SELECT m.id test, title, COUNT(m.id) rentals " +
                "FROM movies m LEFT " +
                "JOIN orders o ON o.movie_id = m.id " +
                "GROUP BY m.id, title " +
                "HAVING COUNT(m.id) > ( " +
                    "SELECT AVG(rental_count.rentals) " +
                    "FROM( " +
                        "SELECT COUNT(m.id) rentals " +
                        "FROM movies m JOIN orders o ON m.id = o.movie_id " +
                        "GROUP BY m.id " +
                    ") rental_count " +
                ")";
            try
            {
                ReformatColumns(new List<string> { "Movie ID", "Title", "Rentals" });
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    ListViewItem item = new ListViewItem(myReader["test"].ToString());
                    item.SubItems.Add(myReader["title"].ToString());
                    item.SubItems.Add(myReader["rentals"].ToString());
                    
                    displayListView.Items.Add(item);
                }

                myReader.Close();
                ShowResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowUsersWhoRentGenreMoreThanAverage(string genre)
        {
            myCommand.CommandText =
                "SELECT account_number, first_name, last_name, COUNT(genre) rented " +
                "FROM customers c JOIN orders o ON c.account_number = o.customer_id JOIN movies m ON o.movie_id = m.id " +
                "WHERE genre = '" + genre + "' " +
                "GROUP BY account_number, first_name, last_name " +
                "HAVING COUNT(genre) > ( " +
                    "SELECT AVG(genre_rented.times_rented) " +
                    "FROM( " +
                        "SELECT COUNT(genre) times_rented " +
                        "FROM customers c JOIN orders o ON c.account_number = o.customer_id JOIN movies m ON o.movie_id = m.id " +
                        "WHERE genre = '" + genre + "' " +
                        "GROUP BY account_number " +
                    ") genre_rented " +
                ")";

            try
            {
                ReformatColumns(new List<string> { "Accout Number", "First Name", "Last Name", "Times Genre Rented" });
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    ListViewItem item = new ListViewItem(myReader["account_number"].ToString());
                    item.SubItems.Add(myReader["first_name"].ToString());
                    item.SubItems.Add(myReader["last_name"].ToString());
                    item.SubItems.Add(myReader["rented"].ToString());

                    displayListView.Items.Add(item);
                }

                myReader.Close();
                ShowResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ReformatColumns(List<string> headers)
        {
            displayListView.Columns.Clear();

            foreach (string header in headers)
            {
                displayListView.Columns.Add(header);
            }

            displayListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void ShowResults()
        {
            resultsLabel.Text = "Displaying " + displayListView.Items.Count + " results";
        }
    }
}
