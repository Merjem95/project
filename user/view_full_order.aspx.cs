﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_view_full_order : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");
    int id;
    int tot = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
        

        id = Convert.ToInt32(Request.QueryString["id"].ToString());
        //open connection
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from order_details where order_id=" + id + "";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            tot = tot + Convert.ToInt32(dr["prod_price"].ToString()) * Convert.ToInt32(dr["prod_qty"].ToString());
        }
        r1.DataSource = dt;
        r1.DataBind();
        con.Close(); //close the connection
        l1.Text = "total order price=" + tot.ToString();
    }
}