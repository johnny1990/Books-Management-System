using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cautare_carti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCauta_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = Biblioteca.Cauta_carti(txtTitlu.Text, txtAutor.Text);
        GridView1.DataBind();
    }
}