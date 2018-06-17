using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Configuration;

public class Database
{
    public static string ConnectionString
    {

        get
        {
            return WebConfigurationManager.ConnectionStrings["conexiune"].ConnectionString;
        }
    }
}