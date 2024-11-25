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
    public partial class Add_flight : Form
    {
        //Connecting to the database
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
                                               Initial Catalog=AirlineDB;
                                               Integrated Security=True");
        public Add_flight()
        {
            InitializeComponent();
        }

        //navigation quick access code
        private void addbtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            new flightSearch().Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            new My_Profile().Show();
            this.Hide();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            new View_booking().Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //Validations
            DateTime date = datetxt.Value.Date;

            if (this.fnotxt.Text == "")
            {
                this.errorProvider1.SetError(this.fnotxt, "Flight Number cannot be null");
                return;
            }
            else if(date < DateTime.Now.Date)
            {
                errorProvider1.SetError(datetxt, "The date entered is a previous date");
                return;
            }
            else if(depcmb.SelectedIndex == -1)
            {
                errorProvider1.SetError(depcmb, "Please select a departure airport from the list");
                return;
            }
            else if (arrivalcmb.SelectedIndex == -1)
            {
                errorProvider1.SetError(arrivalcmb, "Please select a destination from the list");
                return;
            }
            try
            {
                con.Open();
                //To add flight details to the databases flight table
                SqlCommand cmd1 = new SqlCommand("INSERT INTO flightDetailTbl (Fno, Date, DepAirport, DepTime, ArrAirport, ArrTime) VALUES(@fno, @date, @dair, @dtime, @aair, @atime)", con);
                cmd1.Parameters.AddWithValue("@fno", fnotxt.Text);
                cmd1.Parameters.AddWithValue("@date", datetxt.Text);
                cmd1.Parameters.AddWithValue("@dair", depcmb.Text);
                cmd1.Parameters.AddWithValue("@dtime", deptime.Value);
                cmd1.Parameters.AddWithValue("@aair", arrivalcmb.Text);
                cmd1.Parameters.AddWithValue("@atime", Arrtime.Value);

                int ret = cmd1.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Flight Details added Successfully");
                    fnotxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
