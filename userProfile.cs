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
        int accountNumber;

        public userProfile(int acctNo)
        {
            InitializeComponent();
            this.accountNumber = acctNo;

            String connectionString = "Server = DESKTOP-1JJOH8H; Database = MovieRental2; Trusted_Connection = yes;";

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
            MovieWatchList.Visible = true;
            MovieWatchList.Visible = true;
            moviesSearch.Visible = true;
            //userMoviesDropdown.Visible = true;

           // changeUserType.Visible = false;
        }

        private void userProfile_Load(object sender, EventArgs e)
        {

        }

        private void moviesSearch_Click(object sender, EventArgs e)
        {
            warningText.Visible = false;
            int planInt = Int32.Parse(custPlan.Text);
            Boolean flag = true;
            if (planInt == 1 & RentedMovies.Rows.Count >= 2)
            {
                flag = false;
                warningText.Visible = true;
            }
            if (planInt == 2 & RentedMovies.Rows.Count >= 3)
            {
                flag = false;
                warningText.Visible = true;
            }
            if (planInt == 3 & RentedMovies.Rows.Count >= 4)
            {
                flag = false;
                warningText.Visible = true;
            }
            if (planInt == 4 & RentedMovies.Rows.Count >= 5)
            {
                flag = false;
                warningText.Visible = true;
            }
            if (!flag == false)
            {
                int rowindex = MovieWatchList.CurrentCell.RowIndex;
                int columnindex = MovieWatchList.CurrentCell.ColumnIndex;

                String ID = MovieWatchList.Rows[rowindex].Cells[columnindex].Value.ToString();
                int ID2 = Int32.Parse(ID);
                myCommand.CommandText = "insert into orders (time_out, time_in, movie_id, customer_id, employee_ssn) VALUES(1, 1, " + ID2 + ", " + custAcctNo.Text + ",  1); DELETE FROM customer_watchlist WHERE movie_id = " + ID2 + " and customer_id = " + custAcctNo.Text + "; UPDATE movies SET copies_in_stock = copies_in_stock - 1 WHERE id = " + ID2 + ";";

                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();



                    myReader.Close();
                    warningText.Visible = false;
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
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

        private void moviePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental settingsWindow = new Rental(this.accountNumber);
            settingsWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            warningText.Visible = false;
            Console.WriteLine(custAcctNo.Text);
            Console.WriteLine(MovieWatchList.Rows.Count.ToString());
        
            myCommand.CommandText =
               "select distinct m.id, m.title, m.genre, m.copies_in_stock" +
               " from movies as m, customers as c, customer_watchlist as w" + 
               " where m.id = w.movie_id and w.customer_id = "+custAcctNo.Text+";";
            try
            {
                myReader = myCommand.ExecuteReader();

                MovieWatchList.Rows.Clear();
                while (myReader.Read())
                {
                    MovieWatchList.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                }
                myReader.Close();

            


                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {


                MessageBox.Show(e2.ToString(), "Error");
            }

            Console.WriteLine(MovieWatchList.Rows.Count.ToString());

            myCommand.CommandText =
               "select distinct m.id, m.title, m.genre, m.copies_in_stock" +
                " from movies as m, orders as o" +
                " where m.id = o.movie_id and o.customer_id = "+custAcctNo.Text+";";
            try
            {
                myReader = myCommand.ExecuteReader();

                RentedMovies.Rows.Clear();
                while (myReader.Read())
                {
                    RentedMovies.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                }
                myReader.Close();




                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {


                MessageBox.Show(e2.ToString(), "Error");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            warningText.Visible = false;
            int rowindex = RentedMovies.CurrentCell.RowIndex;
            int columnindex = RentedMovies.CurrentCell.ColumnIndex;

            String ID = RentedMovies.Rows[rowindex].Cells[columnindex].Value.ToString();
            int ID2 = Int32.Parse(ID);
            myCommand.CommandText = "DELETE FROM orders WHERE movie_id = " + ID2 + " and customer_id = " + custAcctNo.Text + "; UPDATE movies SET copies_in_stock = copies_in_stock + 1 WHERE id = " + ID2 + ";";

            try
            {
                
                myReader = myCommand.ExecuteReader();



                myReader.Close();
            }
            catch (Exception e3)
            {
               
            }

        }
    }
}
