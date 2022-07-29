using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_booking2
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            view_flight form = new view_flight();

            form.ShowDialog();

        }

        private void ticket_booking_Click(object sender, EventArgs e)
        {
            Ticket form = new Ticket();

            form.ShowDialog();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            CancellationTicket form = new CancellationTicket();

            form.ShowDialog();
        }

        private void addFlight_Click(object sender, EventArgs e)
        {
           FlightTable form = new FlightTable();

            form.ShowDialog();

        }

        private void addPassenger_Click(object sender, EventArgs e)
        {
            AddPassenger form = new AddPassenger();

            form.ShowDialog();
        }

        private void viewPassenger_Click(object sender, EventArgs e)
        {
            ViewPassenger form = new ViewPassenger();

            form.ShowDialog();
        }
    }
}
