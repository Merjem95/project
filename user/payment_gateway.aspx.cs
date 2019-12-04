using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_payment_gateway : System.Web.UI.Page
{
    int tot = 0;
    string s;
    string t;
    string[] a = new string[50];//50
    string order_no;

    protected void Page_Load(object sender, EventArgs e)
    {
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

                    tot = tot + (Convert.ToInt32(a[3].ToString()) * Convert.ToInt32(a[4].ToString()));
                    
                }

                Session["tot"] = tot.ToString();

            }
            //implement paypal
            order_no = Class1.GetRandomPassword(10).ToString();
            Session["order_no"] = order_no.ToString();

            Response.Write("<form action='https://www.sandbox.paypal.com/cgi-bin/webscr' method='post' name='buyCredits' id='buyCredits'>");
            Response.Write("<input type='hidden' name ='cmd' value='_xclick'>");
            Response.Write("<input type='hidden' name ='business' value='testmerjem@gmail.com'>");
            Response.Write("<input type='hidden' name ='currency_code' value='USD'>");
            Response.Write("<input type='hidden' name ='item_name' value='payment for purchase'>");
            Response.Write("<input type='hidden' name ='item_number' value='0'>");
            Response.Write("<input type='hidden' name ='amount' value='" + Session["tot"].ToString() + "'>");
            //Response.Write("<input type='hidden' name ='quantity' value='" + a[4].ToString() + "'>");
            Response.Write("<input type='hidden' name ='return' value='http://localhost:1055/user/payment_success.aspx?order=" + order_no.ToString() + "'>");
            Response.Write("</form>");

            Response.Write("<script type='text/javascript'>");
            Response.Write("document.getElementById('buyCredits').submit();");
            Response.Write("</script>");
            //end
        
        }

    
    }
}