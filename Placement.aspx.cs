using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Placement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String year = DropDownList1.Text;
        String filePath = FileUpload1.PostedFile.FileName;
        String fileType = FileUpload1.PostedFile.ContentType;
        string ext = System.IO.Path.GetExtension(this.FileUpload1.PostedFile.FileName);
        if (FileUpload1.PostedFile.ContentLength > 100000000)
        {
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
        }
        else
        {
            if (ext != ".pdf")
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only PDF File!')", true);
            }
            else
            {

                try
                {

                    FileUpload1.SaveAs(Server.MapPath("~") + "/PDF/" + filePath);



                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@pdf", filePath));
                    cmd.Parameters.Add(new SqlParameter("@year", year));

                    cmd.CommandText = "insert into Placement(pdf,year,faculty,status) values(@pdf,@year,'" + Session["uname"].ToString() + "','True')";

                    con.Open();
                    int rowsUpdated = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsUpdated > 0)
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Inserted Successfully');", true);
                    else
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
                }
                catch (Exception e1)
                {
                    String script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
            }
        }
    }
}