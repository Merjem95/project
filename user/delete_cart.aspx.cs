using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_delete_cart : System.Web.UI.Page
{
    string s;
    string t;
    string[] a = new string[50];
    int rowIndexID;
    string IDProd, ProdName, ProdDesc, ProdPrice, ProdQty, ProdImg, rowIndex;
    string strCookieAllFields, strCookie;
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        rowIndexID = Convert.ToInt32(Request.QueryString["id"].ToString());
        
        DataTable dt = new DataTable();
        dt.Rows.Clear();
        dt.Columns.AddRange(
                new DataColumn[7]
                    {
                        new DataColumn("IDProd"),
                        new DataColumn("ProdName"),
                        new DataColumn("ProdDesc"),
                        new DataColumn("ProdPrice"),
                        new DataColumn("ProdQty"),
                        new DataColumn("ProdImg"),
                        new DataColumn("rowIndex")
                    }
                );

        if (Request.Cookies["ckArticleDetails"] != null)
        {
            if (!String.IsNullOrWhiteSpace(Request.Cookies["ckArticleDetails"].Value))
            {
                s = Convert.ToString(Request.Cookies["ckArticleDetails"].Value);
                
                if (s.Substring(0, 1) == "|") {
                    s = s.Substring(1, s.Length - 1); 
                }

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
                        i.ToString());
                }
            }
        }

        dt.Rows.RemoveAt(rowIndexID);
        Response.Cookies["ckArticleDetails"].Expires = DateTime.Now.AddDays(-1);
        Response.Cookies["ckArticleDetails"].Expires = DateTime.Now.AddDays(-1);


        foreach (DataRow dr in dt.Rows)
        {
            IDProd = dr["IDProd"].ToString();
            ProdName = dr["ProdName"].ToString();
            ProdDesc = dr["ProdDesc"].ToString();
            ProdPrice = dr["ProdPrice"].ToString();
            ProdQty = dr["ProdQty"].ToString();
            ProdImg = dr["ProdImg"].ToString();
            rowIndex = dr["rowIndex"].ToString();

            strCookieAllFields =
                    IDProd.ToString() + "," +
                    ProdName.ToString() + "," +
                    ProdDesc.ToString() + "," +
                    ProdPrice.ToString() + "," +
                    ProdQty.ToString() + "," +
                    ProdImg.ToString() + "," +
                    rowIndex.ToString();

           
            if (count == 0)
            {
                strCookie = strCookieAllFields;
            }
            else
            {
                strCookie += "|" + strCookieAllFields;
            }
            
            count = count + 1;
        }

        Response.Cookies["ckArticleDetails"].Value = strCookie;
        Response.Cookies["ckArticleDetails"].Expires = DateTime.Now.AddDays(1);

        Response.Redirect("../view_cart.aspx");
    }
}