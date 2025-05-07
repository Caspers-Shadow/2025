using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

/*Practical 9
 * 43054226
 * 48282928
 */

namespace Practical_9
{
    public partial class Default : System.Web.UI.Page
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Patients.mdf;Integrated Security=True";
        SqlCommand comm;
        SqlConnection conn;

        SqlDataReader reader;
        
        SqlDataAdapter adapter;
        DataSet ds;

        private void SelectingAll()
        {
            //Shows all entities in the database
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Patients";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds);

                gvBooking.DataSource = ds;
                gvBooking.DataBind();
            }
            catch (Exception ex)
            {
                lblOutput.Text = "Ouch pyn: " + ex.Message;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Refreshes the DataView
            if (!IsPostBack)
            {
               SelectingAll();
            }

        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string service = ddlService.SelectedItem.Text;
            string paymentType = "";

            //Ereror validation
            if (rdoAid.Checked)
            {
                paymentType = "Medical Aid";
            }
            else if (rdoCash.Checked)
            {
                paymentType = "Cash";
            }
            else
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Pick a Payment Method";
                return;
            }           

                DateTime selectedDate = TheCal.SelectedDate;
            if (selectedDate < DateTime.Today)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Appointment must be in the future.";
                return;
            }
            else if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "The appoimntment can not be on a weekend";
                return;
            }
            else
            {
                lblOutput.Text = "";
            }

            //Reading into the database
            try
            {

                conn = new SqlConnection(conStr);

                string sql = "INSERT INTO Patients (Name, Email, Service, Payment, Date) VALUES (@name, @email, @service, @method, @appointment)";

                using (comm = new SqlCommand(sql, conn))
                {

                    comm.Parameters.AddWithValue("@name", name);
                    comm.Parameters.AddWithValue("@email", email);
                    comm.Parameters.AddWithValue("@service", service);
                    comm.Parameters.AddWithValue("@method", paymentType);
                    comm.Parameters.AddWithValue("@appointment", selectedDate.Date);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }

                conn.Close();

                lblOutput.ForeColor = System.Drawing.Color.Black;
                lblOutput.Text = "Hi " + name + ", your appointment for " + service + " has been booked for " + selectedDate.ToString("dddd, dd MMMM yyyy") + " at 00:00.";

                lblBookingShow.Visible = true;
                gvBooking.Visible = true;

                ClearForm();
                SelectingAll();
            }
            catch (Exception ex)
            {
                lblOutput.Text = "Ouch pyn 2: " + ex.Message;
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";

            ddlService.SelectedIndex = -1;

            rdoCash.Checked = false;
            rdoAid.Checked = false;

            TheCal.SelectedDate = DateTime.Today;
        }
    }
}