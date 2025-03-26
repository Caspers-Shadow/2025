using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_6
{
    public partial class CourseRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Makes the visibility false when the form loads
            imgWeb.Visible = false;
            imgAI.Visible = false;
            imgData.Visible = false;
            imgCyber.Visible = false;

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string mode = ddlStudyMode.Text;
            string course = lstCourses.Text;
            int courseNum = lstCourses.SelectedIndex;

            //Checks to see if the listbox was selected and if not error
            if (courseNum == -1)
            {
                lblOutput.Text = "Choose a course";
                return;
            
            }

            //Shows image assigned to course

            if (courseNum == 0)
            {
                imgWeb.Visible = true;

            }
            else if (courseNum == 1)
            {
                imgAI.Visible = true;

            }
            else if (courseNum == 2)
            {
                imgData.Visible = true;
            }
            else if (courseNum == 3)
            {
                imgCyber.Visible = true;
            }
            else
            {
                lblOutput.Text = "Invalid course!";
            }

            //Final output
            lblOutput.ForeColor = System.Drawing.Color.Black;
            lblOutput.Text = "Hi " + name + " you have successfully registered " + mode + " for " + course + " Course";

            


        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all nesseccary tools
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;

            lstCourses.SelectedIndex = -1;
            ddlStudyMode.SelectedIndex = 0;

            imgWeb.Visible = false;
            imgData.Visible = false;
            imgAI.Visible = false;
            imgCyber.Visible=false;

            lblOutput.ForeColor = System.Drawing.Color.Red;
            lblOutput.Text = "Make sure all the requires information have been provided!";

        }
    }
}