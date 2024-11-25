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

namespace Airline_Reservation
{
    public partial class flightSearch : Form
    {
        //Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
                                               Initial Catalog=AirlineDB;
                                               Integrated Security=True");
        public flightSearch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Navigation bars codings
        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void viewbtn2_Click(object sender, EventArgs e)
        {
            new View_booking().Show();
            this.Hide();
        }

        private void profilebtn2_Click(object sender, EventArgs e)
        {
            new My_Profile().Show();
            this.Hide();
        }

        private void logoutbtn2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            new Add_flight().Show();
            this.Close();
        }

        private void flightSearch_Load(object sender, EventArgs e)
        {
            try
            {
                //To Load flight numbers  to the flight number combobox
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT Fno FROM FlightDetailTbl", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    fnocmb.Items.Add(dr2["Fno"].ToString());
                }
                dr2.Close();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if something is selected in the ComboBox
                if (fnocmb.SelectedItem != null)
                {
                    string fno = fnocmb.SelectedItem.ToString();

                    // To load data to the relevant textboxes when the flight ID is searched
                    SqlCommand cmd1 = new SqlCommand("SELECT Date, DepAirport, DepTime, ArrAirport, ArrTime FROM FlightDetailTbl WHERE Fno = @fno", con);
                    cmd1.Parameters.AddWithValue("@fno", fno);
                    con.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();

                    if (dr1.Read())
                    {
                        depdate.Text = dr1["Date"].ToString();
                        deptext.Text = dr1["DepAirport"].ToString();
                        deptime.Text = dr1["DepTime"].ToString();
                        arrtext.Text = dr1["ArrAirport"].ToString();
                        arrtime.Text = dr1["ArrTime"].ToString(); // Fixed the column name
                    }
                    else
                    {
                        MessageBox.Show("Flight number not found!");
                    }

                    dr1.Close();
                }
                else
                {
                    // If nothing is selected in the ComboBox
                    MessageBox.Show("Please select a flight number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Operation error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Null reference error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }


        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            new Booking_Form().Show();
            this.Close();
        }
    }
}
