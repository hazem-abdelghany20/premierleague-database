using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ms3
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void clubrep(object sender, EventArgs e)
        {
            Response.Redirect("club_rep.aspx");
        }
        protected void manager(object sender, EventArgs e)
        {
            Response.Redirect("manager.aspx");
        }
    }
}