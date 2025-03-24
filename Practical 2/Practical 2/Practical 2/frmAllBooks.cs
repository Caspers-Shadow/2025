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

namespace Practical_2
{
    public partial class frmAllBooks : Form
    {
        //|DATADIRECTORY|
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookClub.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand comm;
        private SqlDataAdapter adapt;
        private DataSet ds;

        public frmAllBooks()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Trying to make the database connection
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                MessageBox.Show("Yayy you are in");
                btnConnect.Enabled = false;
                btnDisplay.Enabled = true;
                btnTopRated.Enabled = true;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("nayy you are out" + ex);
            }
        }

        private void frmAllBooks_Load(object sender, EventArgs e)
        {
            //making the buttons unusable untilthe connection is made
            btnDisplay.Enabled = false;
            btnTopRated.Enabled = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Displays all entities in the table
            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Book";

            comm = new SqlCommand(sql, conn);
            adapt.SelectCommand = comm;
            adapt.Fill(ds, "SourceTable");

            dbView.DataSource = ds;
            dbView.DataMember = "SourceTable";

            conn.Close();
        }

        private void btnTopRated_Click(object sender, EventArgs e)
        {
            conn.Open();

            adapt = new SqlDataAdapter();
            ds = new DataSet();

            //Only displays books with a rating of 5
            string sql = "SELECT * FROM Book WHERE Rating = '5'";

            comm = new SqlCommand(sql, conn);
            adapt.SelectCommand = comm;
            adapt.Fill(ds, "SourceTable");

            dbView.DataSource = ds;
            dbView.DataMember = "SourceTable";

            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the entire application
            Application.Exit();
        }
    }
}
