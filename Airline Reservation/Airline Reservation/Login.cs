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
{    public partial class Login : Form
    { 
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
            Initial Catalog=AirlineDB;
            Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com1 = new SqlCommand("SELECT uname, password FROM Admintbl WHERE uname=@uname AND password=@pswrd",con);
            com1.Parameters.AddWithValue("@uname", this.usernametxt.Text);
            com1.Parameters.AddWithValue("@pswrd", this.pswrdtxt.Text);

            SqlDataReader dr = com1.ExecuteReader();
            if (dr.Read() == true)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                usernametxt.Clear();
                pswrdtxt.Clear();
            }
            con.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
