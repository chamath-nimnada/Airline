using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            new flightSearch().Show();
            this.Close();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            new View_booking().Show();
            this.Close();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            new My_Profile().Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            new Add_flight().Show();
            this.Close();
        }
    }
}
