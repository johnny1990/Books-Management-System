using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;

public class Biblioteca
{
    public static string Autentificare(string Nume_utilizator, string Parola)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Autentificare", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter rp = new SqlParameter("Nume_complet", SqlDbType.VarChar, 50);
            rp.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(rp);

            cmd.Parameters.AddWithValue("@Nume_utilizator", Nume_utilizator);
            cmd.Parameters.AddWithValue("@Parola", Parola);
            cmd.ExecuteNonQuery();
            HttpContext.Current.Trace.Write("Accesat cu succes. Valoare returnata :" + rp.Value.ToString());
            return rp.Value.ToString();
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare in autentificare -->" + ex.Message);
            return null;
        }
    }


    public static string Rezerva_Carte(string Id_carte, string Id_membru, string Bibliotecar)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Rezervare_carte", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_carte", Id_carte);
            cmd.Parameters.AddWithValue("@Id_membru", Id_membru);
            cmd.Parameters.AddWithValue("@Bibliotecar", Bibliotecar);
            cmd.ExecuteNonQuery();
            return null;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare in rezervare -->" + ex.Message);
            return ex.Message;
        }
    }


    public static string Returnare_carte(string Id_carte, string Id_membru, string Bibliotecar)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Returnare_carte", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_carte", Id_carte);
            cmd.Parameters.AddWithValue("@Id_membru", Id_membru);
            cmd.Parameters.AddWithValue("@Bibliotecar", Bibliotecar);
            cmd.ExecuteNonQuery();
            return null;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare in returnarea cartii -->" + ex.Message);
            return ex.Message;
        }
    }

    public static DataTable Afiseaza_carti_adaugate_recent()
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);

        try
        {
            SqlDataAdapter da= new SqlDataAdapter("Carti_adaugate_recent", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "Carti");
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare in afisarea cartilor adaugate recent -->" + ex.Message);
            return null;
        }
    }


    public static DataTable Raport_rezervari()
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("Raport_rezervari", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "Rezervari");
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare raport rezervare -->" + ex.Message);
            return null;
        }
    }

    public static DataTable Istoric_carte(string Id_carte)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("Istoric_carte", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Id_carte", Id_carte);
            DataSet ds = new DataSet();
            da.Fill(ds, "Rezervare_carte");
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare istoric carti -->" + ex.Message);
            return null;
        }
    }

    public static DataTable Istoric_membru(string Id_membru)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("Istoric_membru", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Id_membru", Id_membru);
            DataSet ds = new DataSet();
            da.Fill(ds, "Istoric_membru");
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare istoric carti -->" + ex.Message);
            return null;
        }
    }


    public static DataTable Cauta_carti(string title, string author)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("Cauta_carti", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Titlu", title);
            da.SelectCommand.Parameters.AddWithValue("@Autori", author);
            DataSet ds = new DataSet();
            da.Fill(ds, "Carti");
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Eroare in cautare carte -->" + ex.Message);
            return null;
        }
    }
}