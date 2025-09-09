using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginEncrypt
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSRegister_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            User user = new User
            {
                UserName = txtUsername.Text,
                HashPassword = txtPassword.Text
            };

            repo.AddUser(user);
            Response.Write("User registered successfully!");
        }

       
    }
}