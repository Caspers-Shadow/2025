using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practical_Assignment_1___43054226
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private bool isConnected = false;
        private string connectionString = @"C:\\Users\\User\\OneDrive\\Documents\\2025\\CMPG 212\\Practical Assignment 1 - 43054226"; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                isConnected = true;
                MessageBox.Show("Connected to Database yayyyyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }
    }
}
