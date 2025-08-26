using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hackathon2
{
    public partial class AddTranslation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                lblWord.Text = Request.QueryString["word"];
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string word = lblWord.Text;
            string translation = txtTranslation.Text;
            WordStore.AddTranslation(word, translation);
            Response.Redirect("MyWords.aspx");

        }
    }
}