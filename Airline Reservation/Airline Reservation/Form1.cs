using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Airline_Reservation
{
    public partial class Form1 : Form
    {
        string id = "";
        public Form1(string bookID)
        {
            InitializeComponent();
            this.id = bookID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
                                               Initial Catalog=AirlineDB;
                                               Integrated Security=True");
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT bookID,ppno,pname,Ttype,price FROM Pbookingtbl WHERE bookID=@bookid", con);
                cmd2.Parameters.AddWithValue("@bookid", id);
                SqlDataAdapter dap = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                CrystalReport22 cr1 = new CrystalReport22();
                cr1.Load();
                cr1.SetDataSource(ds.Tables[0]);

                crystalReportViewer1.ReportSource = cr1;

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
    }
}
