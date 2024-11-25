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
    public partial class Booking_Confirmation : Form
    {
        string bookid= "";
        //Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
                                               Initial Catalog=AirlineDB;
                                               Integrated Security=True");
        public Booking_Confirmation(string id)
        {
            InitializeComponent();
            this.bookid = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Booking_Form().Show();
            this.Close();
        }

        private void Booking_Confirmation_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM Pbookingtbl WHERE bookID= @bookid";

                SqlCommand cmd1 = new SqlCommand(sql, con);
                cmd1.Parameters.AddWithValue("@bookid", bookid);
                SqlDataAdapter dap = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                this.dataGridView1.DataSource = ds.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1(bookid);
                f1.Show();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
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
    }
}
