using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_8
{
    public partial class VollyballClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            theCal.SelectedDate = DateTime.Today.Date;
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int classDate;
            string timeSlot;

            if (rgbPC.Checked == false && rgbMC.Checked == false && rgbVC.Checked == false)
            {
                lblCampus.Visible = true;
                return;
            }

            if (rgbMC.Checked)
            {
                timeSlot = "10:00am - 12:00pm";
                classDate = 8;
            }
            else if (rgbVC.Checked)
            {
                timeSlot = "08:00am - 10:00am";
                classDate = 6;
            }
            else if (rgbPC.Checked)
            {
                timeSlot = "11:00am - 1:00pm";
                classDate = 4;
            }

            lblOutput.Text = "Hello " + name + ", your class has been succesfully booked for " + theCal.SelectedDate +
                                "\n\nYour class time slot is: ";

            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtStudNum.Text = string.Empty;
            
            rgbMC.Checked = false;  
            rgbVC.Checked = false;
            rgbPC.Checked = false;
        }
    }
}