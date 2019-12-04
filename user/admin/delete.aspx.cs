using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class user_admin_delete : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(!IsPostBack){
            int id = Convert.ToInt32 (Request.QueryString["id"].ToString());
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                
                cmd.CommandText = "delete from product where IDProd=" + id + "";
                cmd.ExecuteNonQuery();
                Response.Redirect("table.aspx");
            }
            catch (Exception ex){
                Response.Write(ex.Message);
            }
        }

        
    }
}