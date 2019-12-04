using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class user_update_order_details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");  
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) { 
            return;
        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from registration where email='" + Session["user"].ToString() + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            txt1.Text = dr["firstname"].ToString();
            txt2.Text = dr["lastname"].ToString();
            txt3.Text = dr["address"].ToString();
            txt4.Text = dr["city"].ToString();
            txt5.Text = dr["state"].ToString();
            txt6.Text = dr["mobile"].ToString();
        }

        con.Close();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update registration set firstname='" + txt1.Text + "',lastname='" + txt2.Text + "',address='" + txt3.Text + "',city='" + txt4.Text + "',state='" + txt5.Text + "',mobile='" + txt6.Text + "' where email='" + Session["user"].ToString() + "'";
        cmd.ExecuteNonQuery();
        txt1.Text="";
        txt2.Text ="";
        txt3.Text ="";
        txt4.Text ="";
        txt5.Text ="";
        txt6.Text="";
        con.Close();
        Response.Redirect("update_user_details.aspx");
    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }
}