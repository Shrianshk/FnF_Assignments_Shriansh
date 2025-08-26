using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hackathon2
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string word = Request.QueryString["word"];
            lblError.Text = $"'{word}' is not present in the application. Please try another word.";

        }
    }
}