using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_7
{
    public partial class Pizza : System.Web.UI.Page
    {
        decimal thick = 10m;
        decimal thin = 5m;
        decimal total = 0m;
        decimal sizeprice = 0m;
        decimal tip = 0m;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string size = ddlSize.SelectedItem.Text;

            if (size == "Small")
            {
                sizeprice = 30m;
            }
            else if (size == "Medium")
            {
                sizeprice = 50m;
            }
            else if (size == "Large")
            {
                sizeprice = 90m;
            }
            else
            {
                lblOutput.Text = "You kind of need to pick something";
                return;
            }

                total += sizeprice;

            //Because the have to add a topping this will automatically have R5 included 
            total += 5m;

            if (rdThin.Checked)
            {
                total += thin;
            }
            else if (rdThick.Checked)
            {
                total += thick;
            }
            else
            {
                if (!rdThick.Checked && !rdThin.Checked)
                {
                    lblOutput.Text = "Specify a crust type";
                    return;
                }

            }

            if (!decimal.TryParse(txtTip.Text, out tip))
            {
                lblOutput.Text = "Thats not a valid number";
                return;
            }

                lblOutput.Text = "Hi " + name + ", you have ordered a " + size + " pizza with a total cost of " + total.ToString("c")
                                    + "\nYour tip of " + tip.ToString("c") + " will be collected on deleviry. Thank you" ;


        }

        protected void radButton_CheckChanged(object sender, EventArgs e)
        {
            
        }

        protected void chkTrip_CheckedChanged(object sender, EventArgs e)
        {
            
                txtTip.Visible = chkTrip.Checked;
           
        }
    }
}