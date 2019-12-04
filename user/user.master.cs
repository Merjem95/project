using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_user : System.Web.UI.MasterPage
{

    string s;
    string t;
    string[] a = new string[100];
    int tot = 0;
    int totcount = 0;
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MH;Initial Catalog=shopping;Integrated Security=True");  
    protected void Page_Load(object sender, EventArgs e)
    {
        //datalist
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText="select * from prod_category";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        dd.DataSource = dt;
        dd.DataBind();

        con.Close();

        //datalist
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

                    tot = tot + (Convert.ToInt32(a[3].ToString()) * Convert.ToInt32(a[4].ToString()) );
                    totcount = totcount + 1;
                    totitem.Text = totcount.ToString();
                    totprice.Text = tot.ToString();
                }
                
            }
        }
    }
}
