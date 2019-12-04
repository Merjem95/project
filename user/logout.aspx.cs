using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");
        con.Open();
        SqlCommand cmd2 = new SqlCommand("UPDATE is_admin_login SET IsLogged = '0'", con);
        SqlDataReader rd2 = cmd2.ExecuteReader();

        Session.Clear();
        Response.Redirect("login.aspx");
    }
}