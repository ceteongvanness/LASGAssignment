using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MK.Framework.ACE.Entities;

namespace Ass5.UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Process.TaskController login = new Process.TaskController();

            Session["Login"] = login.LoginVerify(txtUsername.Text, txtPassword.Text);
            User user = (User)Session["Login"];

            string name = txtUsername.Text.Trim();

            if (user.ToString() != null && user.UserID.ToString() == "2")
            {
                Session["Username"] = name;
                Response.Redirect("TimeEntry.aspx");
            }
            else
            {
                Session["Username"] = name;
                Response.Redirect("StatusTimeEntry.aspx");
            }



        }
    }
}