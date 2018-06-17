using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAutentificare_Click(object sender, EventArgs e)
    {
        String Nume_complet = Biblioteca.Autentificare(txtUtilizator.Text, txtParola.Text);
        if (Nume_complet == null || Nume_complet.Length == 0)
            lblMsg.Text = "Nume utilizator sau parola gresite!";
        else
        {
            Session.Add("Nume_utilizator", txtUtilizator.Text);
            Session.Add("Nume_complet", Nume_complet);
            FormsAuthentication.RedirectFromLoginPage(txtUtilizator.Text, false);
        }
    }
}