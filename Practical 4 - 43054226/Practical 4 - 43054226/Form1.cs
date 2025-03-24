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
 * Mariska Adriaanzen
 * 43054226
 */

namespace Practical_4___43054226
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Car.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        DataSet ds; 
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        //Object made to load the data from the table into the datagridview

        public void LoadData()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Vehicle";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "SourceTable");

                dgvVehicles.DataSource = ds;
                dgvVehicles.DataMember = "SourceTable";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We have a problem general: " + ex);
            }
        }

        //Object to load the type into the combobox

        private void LoadCombo()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                string sql = "SELECT DISTINCT Type FROM Vehicle";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                cmbType.Items.Clear();
                while (reader.Read())
                {
                    cmbType.Items.Add(reader["Type"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We have a problem general: " + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Puts the data into the datagridview and intothe combobox
            try
            {
                LoadCombo();
                LoadData();
                

                MessageBox.Show("Yayyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("We have a problem general: " + ex);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                // Actively looking for what has been put into the textbox
                string sql = "SELECT * FROM Vehicle WHERE VIN_Number LIKE '%" + txtSearch.Text + "%'" +
                                                    "OR Brand LIKE '%" + txtSearch.Text + "%'" +
                                                    "OR Model LIKE '%" + txtSearch.Text + "%'" +
                                                    "OR Year LIKE '%" + txtSearch.Text + "%'" +
                                                    "OR Type LIKE '%" + txtSearch.Text + "%'";


                comm = new SqlCommand(sql, conn);
                adapter.SelectCommand = comm;
                adapter.Fill(ds, "Vehicle");

                dgvVehicles.DataSource = ds;
                dgvVehicles.DataMember = "Vehicle";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We have a problem general: " + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Goes to the next form to delete an entry
            frmDelete delete = new frmDelete();
            delete.ShowDialog();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adds new info into the table
            try
            {
                //Checks that the values arent null
                if (string.IsNullOrEmpty(txtVIN.Text) || string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtYear.Text) || cmbType.SelectedItem == null)
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                conn.Open();
                string query = "INSERT INTO Vehicle (VIN_Number, Brand, Model, Year, Type) VALUES (@VIN, @Brand, @Model, @Year, @Type)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@VIN", txtVIN.Text);
                    cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Year", int.Parse(txtYear.Text));
                    cmd.Parameters.AddWithValue("@Type", cmbType.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle added successfully.");
                    LoadData();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
