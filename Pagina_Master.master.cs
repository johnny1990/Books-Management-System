using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Pagina_Master : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void lbIesire_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("login.aspx");
    }
}
