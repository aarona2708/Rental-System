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
    public partial class customerUI : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public customerUI()
        {
            InitializeComponent();
            String connectionString = "Server = DESKTOP-1JJOH8H; Database = MovieRental; Trusted_Connection = yes;";

            customerDropdown.Items.Add("Show All");

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

        private void Users_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = Users.Rows[index];
            if (selectedRow.Cells[0].Value != null)
            {
                custAcctNo.Text = selectedRow.Cells[0].Value.ToString();
                myCommand.CommandText = "select * from customers where account_number = " + custAcctNo.Text;

                this.Hide();
                userProfile homeWindow = new userProfile(Int32.Parse(custAcctNo.Text));
                homeWindow.Show();
                /*
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
                */
            }
            else { return; }
            /*
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

            Users.Visible = false;
            customerDropdown.Visible = false;
            customerSearchBox.Visible = false;
            custSearchButton.Visible = false;
            userTabUserList.Visible = false;
            changeUserType.Visible = false;
            */
        }

        private void backButton_Click(object sender, EventArgs e)
        {/*
            customerName.Visible = false;
            custAcctNo.Visible = false;
            custPlan.Visible = false;
            custDate.Visible = false;
            custAddress.Visible = false;
            custCity.Visible = false;
            custState.Visible = false;
            custZip.Visible = false;
            custPhone.Visible = false;
            custCred.Visible = false;

            acctNoText.Visible = false;
            planText.Visible = false;
            dateText.Visible = false;
            addressText.Visible = false;
            cityText.Visible = false;
            stateText.Visible = false;
            zipText.Visible = false;
            phoneText.Visible = false;
            credText.Visible = false;
            backButton.Visible = false;
            userPic.Visible = false;
            userActivity.Visible = false;
            userSettings.Visible = false;
            MovieLists.Visible = false;
            moviesSearch.Visible = false;
            userMoviesDropdown.Visible = false;

            Users.Visible = true;
            customerDropdown.Visible = true;
            customerSearchBox.Visible = true;
            custSearchButton.Visible = true;
            userTabUserList.Visible = true;
            changeUserType.Visible = true;
            */
        }

        private void userTabUserList_Click(object sender, EventArgs e)
        {
            
        }

        private void custSearchButton_Click_1(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from customers";
            if (customerDropdown.Text == "Show All")
            {
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    Users.Rows.Clear();
                    while (myReader.Read())
                    {
                        Users.Rows.Add(myReader["account_number"].ToString(), myReader["first_name"].ToString(), myReader["last_name"].ToString(), myReader["phone_no"].ToString(), myReader["account_type"].ToString());
                    }

                    myReader.Close();
                }
                catch
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }


            if (customerDropdown.Text == "Show users with")
                myCommand.CommandText += " where ssn like %" + customerSearchBox.Text + "%";
        }

        private void changeUserType_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen homeWindow = new MainScreen();
            homeWindow.Show();
        }
    }
}

