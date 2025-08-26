using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Hackathon2
{
    public partial class MyWords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            gvWords.DataSource = WordStore.GetAllWords();
            gvWords.DataBind();

        }        
    }
}