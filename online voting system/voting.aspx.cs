using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_voting_system
{
    

    public partial class voting : System.Web.UI.Page
    {
        SqlConnection con;
        int election_id;
        string title;
        bool authorised;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                election_id = Convert.ToInt32(Request.QueryString["id"]);
                title = Request.QueryString["title"].ToString();
            }
            Label1.Text = "";

        }
        protected void vote_click(object sender, EventArgs e)
        {
            string Main_Category;
            string Cast;

            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;

            string firstColData = grdrow.Cells[0].Text;
            string str = ConfigurationManager.ConnectionStrings["con"].ToString();
            con = new SqlConnection(str);
            con.Open();

            bool authorised = false;
            string str1 = "";
            string str2 = "";
            SqlCommand cmd2 = new SqlCommand(str1,con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();

            dr2.Close();

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read() == true)
            {
                authorised = true;
            }
            dr1.Close();
            if (authorised)
            {
                string command = "insert into votes values (" + election_id + ",'" + title + "','" + firstColData + "','" + Context.User.Identity.Name + "')";
                SqlCommand cmd = new SqlCommand(command, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Label1.Text = "Already Voted!";
                }
            }
            else
            {
                Label1.Text = "You have not been authorised by admin to vote in this election as per your credentials!";
            }
            con.Close();

            LinkButton l1 = sender as LinkButton;
            l1.Visible = false;




        }
    }
}