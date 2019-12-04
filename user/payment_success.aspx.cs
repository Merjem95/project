using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_payment_success : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");

    string order = "";
    string order_id;
    string s;
    string t;
    string[] a = new string[8];//50

    protected void Page_Load(object sender, EventArgs e)
    {
        
        con.Open();
        order = Request.QueryString["order"].ToString();//get order nr from localhost link

        if (order == Session["order_no"].ToString())
        {
            
            //getting user details and storing on order_details table
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where email='" + Session["user"].ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into orders values('" + dr["firstname"].ToString() + "','" + dr["lastname"].ToString() + "','" + dr["email"].ToString() + "','" + dr["address"].ToString() + "','" + dr["city"].ToString() + "','" + dr["state"].ToString() + "','" + dr["pincode"].ToString() + "','" + dr["mobile"].ToString() + "')";
                cmd1.ExecuteNonQuery();
            }
            //end storing user datails

            //get order id from tabl order
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from orders where email='" + Session["user"].ToString() + "' order by id desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                order_id = dr2["id"].ToString();
            }
            //end get order id from tabl order

            //getting ordered items from cookies
            if (Request.Cookies["ckArticleDetails"] != null)
            {
                if (!String.IsNullOrWhiteSpace(Request.Cookies["ckArticleDetails"].Value))
                {
                    s = Convert.ToString(Request.Cookies["ckArticleDetails"].Value);
                    if (s.Substring(0, 1) == "|") { s = s.Substring(1, s.Length - 1); }
                    string[] strArr = s.Split('|');

                    for (int i = 0; i < strArr.Length; i++)
                    {
                        t = Convert.ToString(strArr[i].ToString());
                        string[] strArr1 = t.Split(',');
                        for (int j = 0; j < strArr1.Length; j++)
                        {
                            a[j] = strArr1[j].ToString();
                        }

                        SqlCommand cmd3 = con.CreateCommand();                      
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "insert into order_details values('" + order_id.ToString() + "','" + a[1].ToString() + "','" + a[3].ToString() + "','" + a[4].ToString() + "','" + a[5].ToString() + "')";
                        cmd3.ExecuteNonQuery();
                   
                    }//for loop


                }//if not string

            }//if cookies not null
            //end of getting items from cookies
        }//if order==
        else
        {
            Response.Redirect("login.aspx");
        }
        con.Close();
        Session["user"] = "";
        Request.Cookies["ckArticleDetails"].Expires = DateTime.Now.AddDays(-1);
        Request.Cookies["ckArticleDetails"].Expires = DateTime.Now.AddDays(-1);
        Response.Redirect("display_item.aspx");


    }
}