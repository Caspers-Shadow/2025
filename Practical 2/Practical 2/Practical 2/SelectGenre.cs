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
    public partial class frmSelectGenre : Form
    {
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookClub.mdf;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand comm;
        private SqlDataReader reader;
        public frmSelectGenre()
        {
            InitializeComponent();
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Giving output
            try
            {
                lstOutput.Items.Clear();
                conn.Open();

                string sql = "SELECT * FROM Book WHERE Genre = '" + cmbGenre.SelectedItem +"'";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                lstOutput.Items.Add("ID\tTitle\tAuthor\tGenre\tRating\tPrice");
                lstOutput.Items.Add("==================================================================");

                while (reader.Read())
                {
                    lstOutput.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t"+ reader.GetValue(3) +"\t" + reader.GetValue(4) + "\t" + reader.GetValue(5) + "\t");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void frmSelectGenre_Load(object sender, EventArgs e)
        {
            //Adding items to the combobox
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                string sql = "SELECT DISTINCT Genre FROM Book";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    cmbGenre.Items.Add(reader.GetValue(0));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
