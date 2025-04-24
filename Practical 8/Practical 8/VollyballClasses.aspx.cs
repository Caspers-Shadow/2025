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
    }
}