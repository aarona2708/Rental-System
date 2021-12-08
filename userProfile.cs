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
    public partial class userProfile : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public userProfile(int acctNo)
        {
            InitializeComponent();

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

            myCommand.CommandText = "select * from customers where account_number = " + acctNo;

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    customerName.Text = myReader["first_name"].ToString() + " " + myReader["last_name"].ToString();
                    custAcctNo.Text = myReader["account_number"].ToString();
                    custPlan.Text = myReader["account_type"].ToString();
                    custDate.Text = myReader["account_creation_date"].ToString();
                    custAddress.Text = myReader["address"].ToString();
                    custCity.Text = myReader["city"].ToString();
                    custState.Text = myReader["state"].ToString();
                    custZip.Text = myReader["zip_code"].ToString();
                    custPhone.Text = myReader["phone_no"].ToString();
                    custCred.Text = myReader["credit_card_no"].ToString();

                }

                myReader.Close();
            }
            catch
            {
                return;
                //MessageBox.Show(e3.ToString(), "Error");
            }

            customerName.Visible = true;
            custAcctNo.Visible = true;
            custPlan.Visible = true;
            custDate.Visible = true;
            custAddress.Visible = true;
            custCity.Visible = true;
            custState.Visible = true;
            custZip.Visible = true;
            custPhone.Visible = true;
            custCred.Visible = true;

            acctNoText.Visible = true;
            planText.Visible = true;
            dateText.Visible = true;
            addressText.Visible = true;
            cityText.Visible = true;
            stateText.Visible = true;
            zipText.Visible = true;
            phoneText.Visible = true;
            credText.Visible = true;

            backButton.Visible = true;
            userPic.Visible = true;
            userActivity.Visible = true;
            userSettings.Visible = true;
            MovieLists.Visible = true;
            MovieLists.Visible = true;
            moviesSearch.Visible = true;
            userMoviesDropdown.Visible = true;

           // changeUserType.Visible = false;
        }

        private void userProfile_Load(object sender, EventArgs e)
        {

        }

        private void moviesSearch_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from movies";
            if (userMoviesDropdown.Text == "My Queue")
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerUI settingsWindow = new customerUI();
            settingsWindow.Show();
        }

        private void userSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSettings settingsWindow = new UserSettings(Int32.Parse(custAcctNo.Text));
            settingsWindow.Show();
        }
    }
}
