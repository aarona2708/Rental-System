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
    public partial class Rental : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        int returnID;
        int userAccount;
   

        public Rental(int userAccountNo)
        {
            InitializeComponent();
            this.userAccount = userAccountNo;
            String connectionString = "Server = DESKTOP-1JJOH8H; Database = MovieRental2; Trusted_Connection = yes;";


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

        private void button2_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from movies";
            try
            {
                myReader = myCommand.ExecuteReader();

                movieGrid.Rows.Clear();
                while (myReader.Read())
                {
                    movieGrid.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                }
                myReader.Close();

                textBox1.Text = "";
              

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {


                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void Searcj_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from movies where title like '%" + textBox1.Text + "%'";
            try
            {
                myReader = myCommand.ExecuteReader();

                movieGrid.Rows.Clear();
                while (myReader.Read())
                {
                    movieGrid.Rows.Add(myReader["id"].ToString(), myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString());
                }
                myReader.Close();

                textBox1.Text = "";
             

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {


                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = movieGrid.CurrentCell.RowIndex;
            int columnindex = movieGrid.CurrentCell.ColumnIndex;

            String ID = movieGrid.Rows[rowindex].Cells[columnindex].Value.ToString();
            int ID2 = Int32.Parse(ID);

            this.returnID = ID2;

            myCommand.CommandText = "INSERT INTO customer_watchlist (customer_id, movie_id) VALUES ("+this.userAccount+", "+ID2+")";
            try
            {
                myReader = myCommand.ExecuteReader();
                myReader.Close();

                textBox1.Text = "";


                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {

               
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            userProfile profile = new userProfile(userAccount);
            profile.Show();
        }
    }
}
