using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hackathon2
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            string word = txtWord.Text.ToLower();
            if (WordStore.WordExists(word))
            {
                Response.Redirect("AddTranslation.aspx?word=" + word);
            }
            else
            {
                Response.Redirect("Error.aspx?word=" + word);
            }


        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            gvAllWords.DataSource = WordStore.GetAllWords();
            gvAllWords.DataBind();
            gvAllWords.Visible = true;
        }

    }
}