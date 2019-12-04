using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class view_cart : System.Web.UI.Page
{
    string s;
    string t;
    string[] a = new string[50];
    int tot = 0;

    protected void btncheckout_Click(object sender, EventArgs e)
    {
        Session["checkoutbutton"] = "yes";
        Response.Redirect("user/checkout.aspx");
    }
    

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.AddRange(
                            new DataColumn[8]
                                {
                                new DataColumn("IDProd"),
                                new DataColumn("ProdName"),
                                new DataColumn("ProdDesc"),
                                new DataColumn("ProdPrice"),
                                new DataColumn("ProdQty"),
                                new DataColumn("ProdImg"),
                                new DataColumn("rowIndex"),
                                new DataColumn("product_id")
                                }
                            );
        if (Request.Cookies["ckArticleDetails"] != null)
        {


            //if (   Request.Cookies["ckArticleDetails"].Value.Length != 0)
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

                    dt.Rows.Add(
                                        a[0].ToString(),
                                        a[1].ToString(),
                                        a[2].ToString(),
                                        a[3].ToString(),
                                        a[4].ToString(),
                                        a[5].ToString(),
                                        i.ToString(),
                                        a[6].ToString()
                                    );

 tot = tot + (Convert.ToInt32(a[3].ToString()) * Convert.ToInt32(a[4].ToString()));
                
                
                }
               

            }
        }
        d1.DataSource = dt;
        d1.DataBind();

        l1.Text = "You have to pay: $" + tot.ToString();
    }

    protected void btnclose_Click(object sender, EventArgs e)
    {
        Response.Redirect("user/home.aspx");
    }
}