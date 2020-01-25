using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class index : System.Web.UI.Page
{
    public static String path1 = "/img/Slider/";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name,desk from Dean";

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lblname.Text = dr["name"].ToString();
                LblDesk.Text = dr["desk"].ToString();
            }
            con.Close();

        }
        catch (Exception e1)
        {
            String script = "<script type=\"text/javascript\">alert(Try Again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }


    }
}