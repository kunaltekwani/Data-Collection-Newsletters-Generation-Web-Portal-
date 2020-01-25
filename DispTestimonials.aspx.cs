using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class DispTestimonials : System.Web.UI.Page
{
    public static String path = "/img/Testimonial/";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\HP\\Documents\\newsletter.mdf;Integrated Security=True;User Instance=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Alumni_name,PassedYear,Experience,img from Testimonials";

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