using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ShowVisitors : System.Web.UI.Page
{
    protected void ButtonUpload_Click(object sender, EventArgs e)
    {
        
        String filePath = FileUpload1.PostedFile.FileName;
        String fileType = FileUpload1.PostedFile.ContentType;

        String visName = DropDownList1.Text + " " + txtVisitorName.Text;
        String visDetails = txtDes.Text;
        String visDate = txtDate.Text;
        string ext = System.IO.Path.GetExtension(this.FileUpload1.PostedFile.FileName);

        if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
        {

            if (FileUpload1.PostedFile.ContentLength > 1000000)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
            }
            if (ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".png"))
            {
                try
                {
                    FileUpload1.SaveAs(Server.MapPath("~") + "/img/visitors/" + filePath);

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\HP\\Documents\\newsletter.mdf;Integrated Security=True;User Instance=True";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@name", visName));
                    cmd.Parameters.Add(new SqlParameter("@details", visDetails));
                    cmd.Parameters.Add(new SqlParameter("@date", visDate));
                    cmd.Parameters.Add(new SqlParameter("@img", filePath));
                    cmd.CommandText = "insert into Visitor(Visitor_Name, Visitor_details, Date, Img) values(@name,@details,@date,@img)";

                    con.Open();
                    int rowsUpdated = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsUpdated > 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Inserted Successfully');", true);
                        txtVisitorName.Text = "";
                        txtDate.Text = "";
                        txtDes.Text = "";
                    }
                    else
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
                }
                catch (Exception e1)
                {
                    String script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
            }
            else
            {

                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg or .png  image types!')", true);

            }
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select a File!');", true);
        }
    }
}