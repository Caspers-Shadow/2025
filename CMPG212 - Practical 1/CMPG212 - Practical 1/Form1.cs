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

/**
 * Practical 1 
 * 43054226
 * 48282928
 **/

namespace CMPG212___Practical_1
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\43054226\source\repos\CMPG212 - Practical 1\CMPG212 - Practical 1\Employee.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapt;
        DataSet ds;
        SqlDataReader theReader;

        bool definitlyConn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                conn.Close();

                definitlyConn = true;

                MessageBox.Show("Yayyyyyyyyyy");
            }
            catch (Exception mess)
            {
                MessageBox.Show("Ooops" + mess);
                btnConnect.TabIndex = 0;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!definitlyConn)
            {
                MessageBox.Show("Jy het aan gejaag. Game over.");
                return;
            }

            try
            {
                conn.Open();
                adapt = new SqlDataAdapter();

                ds = new DataSet();

                string sql = "SELECT * FROM Person";

                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "Person");

                dbTabelHelp.DataSource = ds;
                dbTabelHelp.DataMember = "Person";
                conn.Close();
            }
            catch (Exception again)
            {
                MessageBox.Show("Really mah guy, again oops." + again);
                return;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!definitlyConn)
            {
                MessageBox.Show("Jy het weer aan gejaag. Game over. Stop trying.");
                return;
            }

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Person";

                comm = new SqlCommand(sql, conn);
                theReader = comm.ExecuteReader();

                lstOut.Items.Add("ID" + "\t" + "Fisrt Name" + "\t" + "Last name" + "\t" + "Position" + "\t" + "Email");
                lstOut.Items.Add("--------------------------------------------------");
                while (theReader.Read())
                {
                    lstOut.Items.Add(theReader.GetValue(0) + "\t" + theReader.GetValue(1) + theReader.GetValue(2) + "\t" + theReader.GetValue(3) + "\t" + theReader.GetValue(4));

                }

                conn.Close();
            }
            catch (Exception ai)
            {
                MessageBox.Show("I said what i said. try again." + ai);
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
            this.Close();
        }
    }
}
