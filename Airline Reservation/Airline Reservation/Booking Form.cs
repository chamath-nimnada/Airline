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
    public partial class Booking_Form : Form
    {
        string bookid = "";
        //Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SDPNF2L\MSSQLSERVER01;
                                               Initial Catalog=AirlineDB;
                                               Integrated Security=True");
        public Booking_Form()
        {
            InitializeComponent();
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
             bookid = this.bookidtxt.Text;
            Booking_Confirmation b1 =new Booking_Confirmation(bookid);
            b1.Show();
            this.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            new flightSearch().Show();
            this.Close();
        }

        //Method to Calculate the ticket price
        private double CalcPrice(string tclass)
        {
            double bprice = 100000;
            double fprice = 0;
            switch (tclass)
            {
                case "Economy Class":
                    fprice = bprice;
                    return fprice;
                case "Business Class":
                    fprice = bprice + (bprice * 0.50);
                    return fprice;
                case "First Class":
                    fprice = bprice + (bprice * 0.75);
                    return fprice;
                default:
                    throw new ArgumentException("Invalid ticket class");
            }
        }
        //Method to insert booking information into the database
        private void booking(string ticketClass, double price)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Pbookingtbl(ppno, pname, page, gender, Ttype, price) VALUES (@pno, @name, @age,@gender, @ttype, @price)", con);
            cmd1.Parameters.AddWithValue("@pno", psprtnotxt.Text);
            cmd1.Parameters.AddWithValue("@name", pasnametxt.Text);
            cmd1.Parameters.AddWithValue("@age", pasagetxt.Text);
            cmd1.Parameters.AddWithValue("@gender", SelectedGender());
            cmd1.Parameters.AddWithValue("@ttype", ttype.Text);
            cmd1.Parameters.AddWithValue("@price", price);

            try
            {
                int r1 = cmd1.ExecuteNonQuery();
                if (r1 > 0)
                {
                    MessageBox.Show("Booking Confirmed !");
                }
                else
                {
                    MessageBox.Show("Error Adding booking!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //method to  input data into the database in the  radio button
        private string SelectedGender()
        {
            if (malerad.Checked)
            {
                return "Male";
            }
            else if (femalerad.Checked)
            {
                return "Female";
            }
            return null;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //Validations
            if (this.psprtnotxt.Text == "")
            {
                this.errorProvider1.SetError(this.psprtnotxt, "Passport Number cannot be empty");
                return;
            }
            else if (this.pasnametxt.Text == "")
            {
                this.errorProvider1.SetError(this.pasnametxt, "Passenger Name cannot be empty");
                return;
            }
            else if (this.pasagetxt.Text == "")
            {
                this.errorProvider1.SetError(this.pasagetxt, "Passenger Age cannot be empty");
                return;
            }

            else if (ttype.SelectedIndex == -1)
            {
                errorProvider1.SetError(ttype, "Please select a ticket class from the list");
                return;
            }
            //assigning variables
            string gender = SelectedGender();
            string selectedClass = ttype.SelectedItem.ToString();

            double price = CalcPrice(selectedClass);
            totprice.Text = price.ToString();
            //Calling the booking information method
            booking(selectedClass, price);
        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {
            //To auto Increment
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT MAX(bookID) FROM PbookingTbl", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();
            {
                if(dr1.GetValue(0).ToString() == "")
                {
                    this.bookidtxt.Text = "1";
                }
                else
                {
                    this.bookidtxt.Text = (Convert.ToInt32(dr1.GetValue(0).ToString()) + 1).ToString();
                }
                dr1.Close();
                con.Close();
            }


        }
    }
}
