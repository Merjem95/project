using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_testing : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else{
            string script = "alert('" + Session["user"].ToString() + "');";
        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
    //protected void b4_Click(object sender, EventArgs e)
    //{
    //    s = Convert.ToString(Request.Cookies["ckArticleDetails"].Value);
    //    string[] strArr = s.Split('.');
    //    for (int i = 0; i < strArr.Length; i++)
    //    {
    //        Response.Write(strArr[i].ToString());
    //        Response.Write("<br>");
    //    }
    //}
    //protected void b3_Click(object sender, EventArgs e)
    //{
    //    Response.Cookies["ckArticleDetails"].Value = Request.Cookies["ckArticleDetails"].Value + ".";
    //}
}