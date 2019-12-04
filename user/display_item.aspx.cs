using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_display_item : System.Web.UI.Page
{
    //sql connection of shopping database 
    
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");
    string category, search;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();                            //open connection
        
        //Creates and returns a SqlCommand object associated with the SqlConnection
        SqlCommand cmd = con.CreateCommand(); 
        cmd.CommandType = CommandType.Text;

        if (Request.QueryString["category"] == null)
        {
            cmd.CommandText = "select * from product";
        }
        else {
            cmd.CommandText = "select * from product where prod_category='" + Request.QueryString["category"].ToString() + "'";
        }

        if (Request.QueryString["category"] == null && Request.QueryString["search"] != null)
        {
            cmd.CommandText = "select * from product where ProdName like('%" + Request.QueryString["search"].ToString() + "%')";//%starting and ending anything
        }
        else {
            
        }
       
        cmd.ExecuteNonQuery(); //executes statement against the connection and returns the number of rows affected
        DataTable dt = new DataTable(); //new data adapter
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //changes the data in the DataSet to match the data in the data source
        da.Fill(dt); 
        d1.DataSource=dt; //d1=repeater's id
        d1.DataBind();
       
        con.Close(); //close the connection
    }
}