using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Returnare : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnReturnare_Click(object sender, EventArgs e)
    {
        String status = Biblioteca.Returnare_carte(txtIdCarte.Text, txtIdMembru.Text, Session["Nume_utilizator"].ToString());
        if (status == null)
            lblMsg.Text = "Carte returnata cu succes!";
        else
            lblMsg.Text = "Eroare" + status;
    }
}