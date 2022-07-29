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

namespace Flight_booking2
{
    public partial class AddPassenger : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DEEPAK;Initial Catalog=passportDB;Integrated Security=True");


        public AddPassenger()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if(passID.Text=="" || name.Text=="" || number.Text == "" || address.Text == "" || nationality.Text == "" || gender.Text == "")
            {
                MessageBox.Show("Missing Information");


            }
            else
            {
                try
                {
                    
                    connection.Open();
                    string query="insert into passenger values ("+ Int32.Parse(passID.Text) + ", '" +name.Text + "', '" + number.Text+ "' ,'" + address.Text + "', '" + nationality.Text + "', '" + gender.Text + "'); ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
