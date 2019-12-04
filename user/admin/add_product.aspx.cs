using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_add_product : System.Web.UI.Page
{    //Shopping database sql connection
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");
    string a, b,query;
    
    
    protected void Page_Load(object sender, EventArgs e){ }
    protected void b1_Click(object sender, EventArgs e) {
        
        a = Class1.GetRandomPassword(10).ToString(); //it changes the  name of image so it won't have two in a folder
        // upload the image from the images folder
        f1.SaveAs(Request.PhysicalApplicationPath + "./images/" + a + f1.FileName.ToString()); 
        b = "images/" + a + f1.FileName.ToString();
        //open connection
        con.Open();
        SqlCommand cmd = con.CreateCommand(); 
        cmd.CommandType = CommandType.Text;
        //sql query which add in table product all the values typen into textboxes 

        cmd.CommandText = "insert into product values('" + t1.Text + "','" + t2.Text + "'," + t3.Text + "," + t4.Text + ",'" + b.ToString() + "','" + ddl.SelectedItem.Value + "')"; //'"++"' for prodquantity we remove ''
        cmd.ExecuteNonQuery();
        //after execution clear all textboxes 
        t1.Text = "";
        t2.Text = "";
        t3.Text = "";
        t4.Text = "";
        con.Close(); //close the connection
    }


    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        query = "select distinct prod_catagory from prod_category where prod_catagory ='" + ddl.SelectedItem.ToString() + "'";
    }
}

