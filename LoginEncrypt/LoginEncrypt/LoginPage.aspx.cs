using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginEncrypt
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            bool isValid = repo.ValidateUser(txtUsername.Text, txtPassword.Text);

            if (isValid)
            {
                Response.Write("Login successful!");
                // Redirect to dashboard or home page
            }
            else
            {
                Response.Write("Invalid username or password.");
            }
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}