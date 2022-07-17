using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using Ubiety.Dns.Core;

namespace online_voting_system
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public object LinkButton11 { get; private set; }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            try 
            {
                if (Session["role"]==null)
                {
                    LinkButton4.Visible = true;//admin login link button
                    LinkButton14.Visible = true;//signup link button

                    LinkButton10.Visible = true;//userlogin link button
                    LinkButton.Visible = false;//logout link button
                    LinkButton2.Visible = false;//hello user link button

                    LinkButton4.Visible = true;//admin login link button
                    LinkButton6.Visible = false;//edit election link button
                    LinkButton1.Visible = false;//add candidates link button
                    LinkButton3.Visible = false;//add elections link button
                    LinkButton5.Visible = false;//election link button
                    /*LinkButton7.Visible = false;//view candidate link button*/
                    LinkButton8.Visible = false;//voting link button
                    LinkButton9.Visible = false;//result link button

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton4.Visible = false;//admin login link button
                    LinkButton14.Visible = true;//signup link button

                    LinkButton10.Visible = true;//userlogin link button
                    LinkButton.Visible = true;//logout link button
                    LinkButton2.Visible = true;//hello user link button
                    LinkButton2.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = false;//edit election link button
                    LinkButton1.Visible = true;//add candidates link button
                    LinkButton3.Visible = true;//add elections link button
                    LinkButton5.Visible = true;//election link button
                    /*LinkButton7.Visible = true;//view candidate link button*/
                    LinkButton8.Visible = true;//voting link button
                    LinkButton9.Visible = true;//result link button
                }
                else if(Session["role"].Equals("admin"))
                {

                    LinkButton4.Visible = true;//admin login link button
                    LinkButton14.Visible = false;//signup link button

                    LinkButton10.Visible = false;//userlogin link button
                    LinkButton.Visible = true;//logout link button
                    LinkButton2.Visible = true;//hello user link button
                    LinkButton2.Text = "Hello Admin";

                    LinkButton4.Visible = false;//admin login link button
                    LinkButton6.Visible = true;//edit election link button
                    LinkButton1.Visible = true;//add candidates link button
                    LinkButton3.Visible = true;//add elections link button
                    LinkButton5.Visible = true;//election link button
                    /*LinkButton7.Visible = true;//view candidate link button*/
                    LinkButton8.Visible = true;//voting link button
                    LinkButton9.Visible = true;//result link button
                }
                
            }
            catch (Exception )
            {
                //
            }
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("editelctions.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addcandidates.apx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("addelections.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("election.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("voting.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("result.aspx");
        }
       
        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
           /* LinkButton4.Visible = true;//admin login link button
            LinkButton14.Visible = true;//signup link button
            
            LinkButton.Visible = false;//logout link button
            LinkButton2.Visible = false;//hello user link button

            LinkButton4.Visible = true;//admin login link button
            LinkButton6.Visible = false;//edit election link button
            LinkButton1.Visible = false;//add candidates link button
            LinkButton3.Visible = false;//add elections link button
            LinkButton5.Visible = false;//election link button
            LinkButton7.Visible = false;//view candidate link button
            LinkButton8.Visible = false;//voting link button
            LinkButton9.Visible = false;//result link button*/

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }
        protected void LinkButton10_click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        

    }
}