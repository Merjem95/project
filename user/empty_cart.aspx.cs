using System;

public partial class user_delete_cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Response.Cookies["ckArticleDetails"].Value);
        Response.Cookies["ckArticleDetails"].Expires = DateTime.Now.AddDays(-1);
    }
}