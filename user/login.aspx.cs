using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_MyAccount : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");
    int tot = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void b1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from registration where email='" + t1.Text + "'and password='" + t2.Text + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        //from the table registration,if is_admin is true update is_admin_login table with true
        string is_admin = dt.Rows[0]["is_admin"].ToString();
        if (is_admin == "True")
        {
            SqlCommand cmd2 = new SqlCommand("UPDATE is_admin_login SET IsLogged = '1'", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
        }

        //if is_admin_login is false the user cannot sign in
        else
        {
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from is_admin_login";
            cmd3.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
            da1.Fill(dt1);

            string IsLogged = dt1.Rows[0]["IsLogged"].ToString();
            if (IsLogged == "False")
            {
                Response.Write("Admin is not logged. You cannot login.");
                Response.End();
            }
        }
        tot = Convert.ToInt32(dt.Rows.Count.ToString());

        if (tot > 0)
        {
            if (Session["checkoutbutton"] == "yes")
            {
                Session["user"] = t1.Text;
                Response.Redirect("update_user_details.aspx");
            }
            else
            {
                Session["user"] = t1.Text;
                Response.Redirect("order_details.aspx");
            }
        }
        else
        {

            l1.Text = "invalid email or password ";
        }
        con.Close();

    }

}