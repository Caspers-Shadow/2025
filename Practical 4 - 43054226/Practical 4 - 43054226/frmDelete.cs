using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Mariska Adriaanzen
 * 43054226
 */

namespace Practical_4___43054226
{
    public partial class frmDelete : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Car.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapter;

        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnFinalDelete_Click(object sender, EventArgs e)
        {
            //Deleting an entry
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                string sql = "DELETE FROM Vehicle WHERE Model = @model";

                using (comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@model", txtModelDelete.Text);
                    comm.ExecuteNonQuery();
                }

                conn.Close();

                //Closes the form 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We have a problem general: " + ex);
            }
        }
    }
}
