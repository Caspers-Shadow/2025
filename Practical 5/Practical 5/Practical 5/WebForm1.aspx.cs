using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 * Practical 5
 * 43054226
 */

namespace Practical_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtFirstName.Text;
            string surname = txtLastName.Text;
            string phone = txtPhoneNum.Text;
            string email = txtEmail.Text;

            //Checking that the  amount is an integer
            if (!int.TryParse(txtAmount.Text, out int amount))
            {
                lblResult.Text = "Invalid amount";
                return;
            }

            string colour = ddlColour.SelectedItem.Text;


            //Assigning the right prices to the right colours
            double price;

            if (colour == "Black")
            {
                price = 45.50;
            }
            else
            {
                price = 30;
            }

            //Output and calculations for each
            lblResult.Text = "Selections made for " + name + " " + surname + " ---- Colour: " + colour + " - (Amount) " +  amount;

            double totalCost = price * amount;

            lblAmount.Text = "Total cost, excluding tax = R" + totalCost;

            double tax = totalCost * 0.15;

            lblTax.Text = "Total amount of tax = R" + tax;

            double finalTotal = totalCost + tax;

            lblTotal.Text = "Total cost, including tax = R" + finalTotal;
        }
    }
}