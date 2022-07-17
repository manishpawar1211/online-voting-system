using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_voting_system
{
    public partial class addcandidates : System.Web.UI.Page
    {
        SqlConnection con;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label11.Text = "";
            if (Page.IsPostBack)
            {
                string str = ConfigurationManager.ConnectionStrings["con"].ToString();
                con = new SqlConnection(str);
                con.Open();
                string c = "select id from election where title=";
                SqlCommand cmd = new SqlCommand(c, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    Label1.Text = Convert.ToString(dr.GetInt32(0));
                }
                else
                {
                    Label1.Text = "";
                }
                con.Close();
            }
        }

        protected void select_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;

            string firstColData = grdrow.Cells[0].Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
            
            con.Open();

            string command = "insert into candidate values ('" + firstColData + "'," + Convert.ToInt32(Label1.Text) + ",'" + DropDownList1.SelectedValue + "')";
            SqlCommand cmd = new SqlCommand(command, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException )
            {
                Label1.Text = "Already selected this candidate for this election!";
            }
            con.Close();

            LinkButton l1 = sender as LinkButton;
            l1.Visible = false;
        }

        protected void details_Click(object sender, EventArgs e)
        {
            GridViewRow grdow = (GridViewRow)((LinkButton)sender).NamingContainer;
            string firstcolData = grdow.Cells[0].Text;
            Response.Redirect("viewcandidate.aspx?id" + firstcolData);
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}