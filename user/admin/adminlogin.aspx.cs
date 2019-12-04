using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class admin_adminlogin : System.Web.UI.Page{
    //Shopping database sql connection 
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True"); 
    int i;
    protected void Page_Load(object sender, EventArgs e){
    }
    //In button login click 
    protected void b1_Click(object sender, EventArgs e){
        i = 0; //initialize i
        con.Open(); //open connection
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Create a query which will select all records where username will be equal to textbox written on login form
        // and the password equal to textbox password written on login form
         cmd.CommandText = "Select * from admin_login where username='"+t1.Text+"' and password='"+t2.Text+"'";
         cmd.ExecuteNonQuery();
        //creating new data table
         DataTable dt = new DataTable();
         //creating new data adapter command
         SqlDataAdapter da = new SqlDataAdapter(cmd);
         da.Fill(dt);
         i = Convert.ToInt32(dt.Rows.Count.ToString());
        //if the condition is true it will send us to the admin page 
         if (i == 1) {
             Response.Redirect("Default.aspx");
         }
         //if the condition is fase it will appear a warning text "you have entered invalid username or password"
         else {
             l1.Text = "you have entered invalid username or password";
         }
         con.Close(); //closing the conection
    }
    protected void bClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("../home.aspx");
    }
}

