using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_voting_system
{
    
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["uid"] != null)
            {
                string msg = "You have succesfully registered" + Request.QueryString["uid"].ToString() + ".please Login";
                Label1.Text = msg;
            }
            else
            {
               Label1.Text = null;
            }
        }
    }
}