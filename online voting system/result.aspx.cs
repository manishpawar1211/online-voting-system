using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_voting_system
{
    public partial class result : System.Web.UI.Page
    {
        int election_id;
        String election_name;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["id"] != null && Request.QueryString["title"] != null)
            {
                election_id = Convert.ToInt32(Request.QueryString["id"]);
                election_name = Request.QueryString["title"];
            }
        }
    }
}