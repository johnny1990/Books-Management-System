using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rezervare : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string Id_carte = Request.QueryString["Id_carte"];
            if (Id_carte != null)
                txtIdCarte.Text = Id_carte;
        }

    }
    protected void btnRezerva_Click(object sender, EventArgs e)
    {
        String status = Biblioteca.Rezerva_Carte(txtIdCarte.Text, txtIdMembru.Text, Session["Nume_utilizator"].ToString());
        if (status == null)
            lblMsg.Text = "Cartea a fost rezervata!";
        else
            lblMsg.Text = "Eroare ->" + status;
    }
}