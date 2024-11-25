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
    public partial class View_booking : Form
    {
        //Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
                                               Initial Catalog=AirlineDB;
                                               Integrated Security=True");
        public View_booking()
        {
            InitializeComponent();
        }
        
        //Close button
        private void Closebtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Close();
        }

        //Navigation bar code
        private void searchbtn2_Click_1(object sender, EventArgs e)
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

        private void profilebtn2_Click(object sender, EventArgs e)
        {
            new My_Profile().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add_flight().Show();
            this.Close();
        }
        //To display all the bookings to the admin
        private void View_booking_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Pbookingtbl ", con);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Displaying to the datagrid View
                dataGridView2.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
