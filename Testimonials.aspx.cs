using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Testimonials : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonUpload_Click(object sender, EventArgs e)
    {
        String filePath = FileUpload1.PostedFile.FileName;
        String fileType = FileUpload1.PostedFile.ContentType;

        String alName = DropDownList3.Text + " "+ txtAlName.Text;
        String alExp = txtExp.Text;
        String AlYear = DropDownList1.Text + "-" + DropDownList2.Text;
        string ext = System.IO.Path.GetExtension(this.FileUpload1.PostedFile.FileName);

        if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
        {

            if (FileUpload1.PostedFile.ContentLength > 10000000)
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
            }
            if (ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".png"))
            {
                try
                {
                    FileUpload1.SaveAs(Server.MapPath("~") + "/img/Testimonial/" + filePath);

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@name", alName));
                    cmd.Parameters.Add(new SqlParameter("@exp", alExp));
                    cmd.Parameters.Add(new SqlParameter("@year", AlYear));
                    cmd.Parameters.Add(new SqlParameter("@img", filePath));
                    cmd.CommandText = "insert into Testimonials(Alumni_name, Experience,Img,PassedYear) values(@name,@exp,@img,@year)";

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
            else
            {

                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg or .png image types!')", true);

            }
        }
        //if (DropDownList1.Text.Equals(" ") || DropDownList2.Text.Equals(" "))
        //{
        //    ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select Year!');", true);
        //}
        
            

            
    
    else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select a File!');", true);
        }
    }
}