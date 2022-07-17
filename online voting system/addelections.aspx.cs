using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_voting_system
{
    public partial class addelections : System.Web.UI.Page
    {
        SqlConnection con;
        private string strcon;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["con"].ToString();
            con = new SqlConnection(str);
            con.Open();

            if (checkMemberExists())
            {

                Response.Write("<script>alert('Member Already Exist with this Member ID, try other ID');</script>");
            }
            else
            {
                signupNewUser();
            }

            bool checkMemberExists()
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from election where memberid='" + TextBox13.Text.Trim() + "';", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {

                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
                return false;

                void signupNewUser()
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        string query = $"insert into elections values('{TextBox13.Text.Trim()}','{TextBox4.Text.Trim()}','{TextBox1.Text.Trim()}','{TextBox3.Text.Trim()}','{TextBox14.Text.Trim()}','{TextBox15.Text.Trim()}','{TextBox11.Text.Trim()}','{TextBox12.Text.Trim()}');";
                        SqlCommand cmd = new SqlCommand(query, con);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            Label1.Text = "Error.Maybe ELection is already added?";
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('" + ex.Message + "');</script>");
                    }
                }
            }

            
        } 

        private void signupNewUser()
        {  
            throw new NotImplementedException();
        }
    }

   
}