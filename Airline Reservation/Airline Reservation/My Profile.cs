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
    
    public partial class My_Profile : Form
    {
        //Sql Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
            Initial Catalog=AirlineDB;
            Integrated Security=True");
        public My_Profile()
        {
            InitializeComponent();
        }

        //navigation bars coding
        private void viewbtn2_Click(object sender, EventArgs e)
        {
            new View_booking().Show();
            this.Close();
        }

        
        private void searchbtn2_Click(object sender, EventArgs e)
        {
            new flightSearch().Show();
            this.Hide();
        }
        private void dashboardbtn_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        private void logoutbtn2_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void closebtn2_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        private void My_Profile_Load(object sender, EventArgs e)
        {
            //To show the Username and password of the logged in user
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT adminName, address, tel, uname FROM Admintbl", con);

            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                adnametxt.Text = dr["adminName"].ToString();
                adresstxt.Text = dr["address"].ToString();
                contacttxt.Text = dr["tel"].ToString();
                usernametxt2.Text = dr["uname"].ToString();
                
            }
            else
            {
                MessageBox.Show("An error Occured !");
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add_flight().Show();
            this.Close();
        }
    }
}
