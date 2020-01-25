using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class DispCollaborations_n_networking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Details from collaboration_and_Networking where status = 'True'";

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
        catch (Exception e1)
        {
            String script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
    }
}