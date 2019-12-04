using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_product_desc : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");

    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");
    int qty;
    int id;
    string IDProd, ProdName, ProdDesc, ProdPrice, ProdQty, ProdImg;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if(Request.QueryString["id"]==null)
        {
            Response.Redirect("display_item.aspx");
        }
        else
        {
            
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            con.Open();
            show();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product where IDProd="+id+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            d1.DataSource = dt;
            d1.DataBind();
           
            con.Close();
        }

        qty = get_qty(id);
        if (qty == 0)
        {
            l2.Visible = false;
            t1.Visible = false;
            btnAddToCart.Visible = false;
            l1.Text = "There is no available quantity of this item";
        }
        else { }
    }

    protected void b2_Click(object sender, EventArgs e)
    {
        Response.Redirect("display_item.aspx");
    }

    public int get_qty(int id)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from product where IDProd=" + id + "";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        
        foreach (DataRow dr in dt.Rows)
        {
            qty = Convert.ToInt32(dr["ProdQty"].ToString());
        }
        con.Close();
        return qty;
        

    }
    
    protected void btncom_Click(object sender, EventArgs e)
    {
       // string a;
       // a=ConfigurationManager.ConnectionStrings[].ToString();
        con.Open();
        SqlCommand cmd= new SqlCommand("insert into comment"+"(name,com,time,idProd)values(@name,@com,@time,@idProd)",con);
        cmd.Parameters.AddWithValue("@name",tname.Text);
        cmd.Parameters.AddWithValue("@com",tcom.Text);
        cmd.Parameters.AddWithValue("@time",DateTime.Now);
        cmd.Parameters.AddWithValue("@idProd", Request.QueryString["id"].ToString());
        cmd.ExecuteNonQuery();

        Response.Redirect("product_desc.aspx?id=" + id.ToString());
        
    }

    protected void show()
    {
        SqlCommand cmd = con.CreateCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
       // con.Open();
        cmd.CommandText = "select * from comment where idProd=" + Request.QueryString["id"].ToString() + " order by time desc";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds, "comment");
        rcom.DataSource = ds;       //repeater of comments
        rcom.DataBind();
        //con.Close();
    }



    protected void btnAddToCart_Click(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from product where IDProd=" + id + "";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            IDProd = dr["IDProd"].ToString();
            ProdName = dr["ProdName"].ToString();
            ProdDesc = dr["ProdDesc"].ToString();
            ProdPrice = dr["ProdPrice"].ToString();
            ProdQty = dr["ProdQty"].ToString();
            ProdImg = dr["ProdImg"].ToString();
        }
        //con.Close();


        if (t1.Text == "")
        {
            l1.Text = "Please enter the quantity of your product";
        }
        else if (Convert.ToInt32(t1.Text) > Convert.ToInt32(ProdQty))
        {
            l1.Text = "Please enter lower quantity";
        }


        else
        {
            l1.Text = "";

            string strArticleDetails;
            strArticleDetails = IDProd.ToString() + "," +
                                ProdName.ToString() + "," +
                                ProdDesc.ToString() + "," +
                                ProdPrice.ToString() + "," +
                                t1.Text + "," +
                                    ProdImg.ToString() + "," +
                                    id.ToString() + "," +
                                    0;

            if (Request.Cookies["ckArticleDetails"] == null)
            {
                Response.Cookies["ckArticleDetails"].Value = strArticleDetails;
            }
            else
            {
                Response.Cookies["ckArticleDetails"].Value = Request.Cookies["ckArticleDetails"].Value + "|" + strArticleDetails;
            }

            Response.Cookies["ckArticleDetails"].Expires = DateTime.Now.AddDays(1);

            //SqlCommand cmd1 = con.CreateCommand();
            //cmd1.CommandType = CommandType.Text;
            //cmd1.CommandText = "update product set ProdQty=ProdQty-" + t1.Text+"where IDProd="+id;
            //cmd1.ExecuteNonQuery();
            Response.Redirect("product_desc.aspx?id=" + id.ToString());

            //Page.ClientScript.RegisterStartupScript(
            //                   Page.GetType(),
            //                   "MessageBox",
            //                   "<script language='javascript'>alert('" + Request.Cookies["ckArticleDetails"].Value + "');</script>"
            //                );

            // aa = "testing|testing1";
        }
    }
 
}
