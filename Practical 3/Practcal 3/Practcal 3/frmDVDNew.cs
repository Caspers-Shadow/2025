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

/*
 * Practical 3
 * 43054226
 * 48282928
 */

namespace Practcal_3
{
    public partial class frmDVDNew : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Movies.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapt;
        DataSet ds;

        public frmDVDNew()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //Setting up the scrollbars parameters
            sbAge.Minimum = 0;
            sbAge.Maximum = 100;
            sbAge.SmallChange = 1;
            sbAge.LargeChange = 1;

            try
            {
                conn.Open();
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                //Making the dynamic age selection
                string sql = "SELECT * FROM DVD WHERE Age <='" + sbAge.Value.ToString() +"'";
                //Displaying the value of the scrollbar
                lblDisplay.Text = sbAge.Value.ToString();

                comm = new SqlCommand(sql, conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "SourceTable");

                dbvGrid.DataSource = ds;
                dbvGrid.DataMember = "SourceTable";

                conn.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDVDNew_Load(object sender, EventArgs e)
        {            //Initial connection string
            conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                //Dislpaying the entire database
                string sql = "SELECT * FROM DVD";

                comm = new SqlCommand(sql,conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "SourceTable");

                dbvGrid.DataSource = ds;
                dbvGrid.DataMember = "SourceTable";

                MessageBox.Show("Yayyyyy you did it!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been a id10t problem: " + ex);
            }

            
        }

        

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                //Displaying all the action movies

                string sql = "SELECT * FROM DVD WHERE Type LIKE '%ACT%'";

                comm = new SqlCommand(sql, conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "SourceTable");

                dbvGrid.DataSource = ds;
                dbvGrid.DataMember = "SourceTable";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been a id10t problem: " + ex);
            }

        }
    }
}
