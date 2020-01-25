using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class login1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String username = txtUname.Text;
        String pass = txtpwd.Text;

        if (txtUname.Equals("") || txtpwd.Equals(""))
        {
            ClientScript.RegisterClientScriptBlock(GetType(), "key", "alert('The fields should not be Null');", true);
        }
        else
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\HP\\Documents\\newsletter.mdf;Integrated Security=True;User Instance=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Users where username='" + username + "' and password='" + pass + "'";

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (username.Equals("DK"))
                    {

                        Response.Redirect("ConvActivities.aspx");
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            Session["uname"] = dr["id"].ToString();
                            Response.Redirect("Activities.aspx");
                        }
                    }
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(GetType(), "key", "alert('Enter valid username or password');", true);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception e1)
            {
                String script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
        }
    }
}