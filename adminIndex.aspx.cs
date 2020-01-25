using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    public static String path1 = "/img/Slider/";

    private SqlConnection con;
    private SqlCommand cmd;
    private DataSet ds;
    private SqlDataAdapter adp;
    private String script = "";
    private int count = 0;
    private static byte flag = 0;



    private void GetConnection()
    {
        con = new SqlConnection();
        con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\HP\\Documents\\newsletter.mdf;Integrated Security=True;User Instance=True";
        con.Open();
        cmd = new SqlCommand();
        cmd.Connection = con;
    }

    private void GetData()
    {
        try
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Dean";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr["name"].ToString();
                txtDesk.Text = dr["desk"].ToString();
            }

            con.Close();
        }
        catch (Exception e1)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GetConnection();
            GetData();
        }
        
    }

    
    protected void Button1_Click(object sender, EventArgs e)
    {

        String filePath = FileUpload2.PostedFile.FileName;
        String fileType = FileUpload2.PostedFile.ContentType;

        
        if (DropDownList1.SelectedIndex == 0)
        {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please Select a Slider from Dropdown!');", true);
        }

        else if (DropDownList1.SelectedIndex == 1)
        {
             string ext = System.IO.Path.GetExtension(this.FileUpload2.PostedFile.FileName);
             if (FileUpload2.PostedFile != null && FileUpload2.PostedFile.FileName != "")
             {
                 if (FileUpload2.PostedFile.ContentLength > 10000000)
                 {
                     Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
                 }
                 if (ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".png"))
                 {
                     try
                     {
                         FileUpload2.SaveAs(Server.MapPath("~") + "/img/Slider/" + filePath);
                         string s = Server.MapPath("~") + "/img/Slider/" + filePath;

                         SqlConnection con = new SqlConnection();
                         con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

                         SqlCommand cmd = new SqlCommand();
                         cmd.Connection = con;
                         cmd.CommandType = CommandType.Text;
                         cmd.CommandText = "update slider set img='" + filePath + "' where id= '1'";
                         con.Open();
                         int rowsUpdated = cmd.ExecuteNonQuery();
                         con.Close();

                         if (rowsUpdated > 0)
                         {
                             ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Updated Successfully');", true);

                         }
                         else
                             ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
                     }
                     catch (Exception e2)
                     {
                         script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                         Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                     }
                 }
                 else
                 {

                     Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg or .png image types!')", true);

                 }
             }
             else
             {
                 ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select a File!');", true);
             }
        }
        else if (DropDownList1.SelectedIndex == 2)
        {
            string ext = System.IO.Path.GetExtension(this.FileUpload2.PostedFile.FileName);

            if (FileUpload2.PostedFile != null && FileUpload2.PostedFile.FileName != "")
            {
                if (FileUpload2.PostedFile.ContentLength > 10000000)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
                }
                if (ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".png"))
                {
                    try
                    {
                        FileUpload2.SaveAs(Server.MapPath("~") + "/img/Slider/" + filePath);

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update slider set img='" + filePath + "' where id= '2'";
                        con.Open();
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsUpdated > 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Updated Successfully');", true);

                        }
                        else
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
                    }
                    catch (Exception e2)
                    {
                        script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                    }
                }
                else
                {

                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg or .png image types!')", true);

                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select a File!');", true);
            }
             
        }
        else if (DropDownList1.SelectedIndex == 3)
        {
            string ext = System.IO.Path.GetExtension(this.FileUpload2.PostedFile.FileName);

            if (FileUpload2.PostedFile != null && FileUpload2.PostedFile.FileName != "")
            {
                if (FileUpload2.PostedFile.ContentLength > 10000000)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
                }
                if (ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".png"))
                {
                    try
                    {
                        FileUpload2.SaveAs(Server.MapPath("~") + "/img/Slider/" + filePath);

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update slider set img='" + filePath + "' where id= '3'";
                        con.Open();
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsUpdated > 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Updated Successfully');", true);

                        }
                        else
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
                    }
                    catch (Exception e2)
                    {
                        script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                    }
                }
                else
                {

                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg or .png image types!')", true);

                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select a File!');", true);
            }
        }
        else if (DropDownList1.SelectedIndex == 4)
        {
            string ext = System.IO.Path.GetExtension(this.FileUpload2.PostedFile.FileName);
            if (FileUpload2.PostedFile != null && FileUpload2.PostedFile.FileName != "")
            {
                if (FileUpload2.PostedFile.ContentLength > 10000000)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
                }
                if (ext.Equals(".jpg") || ext.Equals(".jpeg") || ext.Equals(".png"))
                {
            try
            {

            FileUpload2.SaveAs(Server.MapPath("~") + "/img/Slider/" + filePath);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update slider set img='" + filePath + "' where id= '4'";
            con.Open();
            int rowsUpdated = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsUpdated > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Updated Successfully');", true);

            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
            }
            catch (Exception e2)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
        }
            }
            else
            {

                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg or .png image types!')", true);

            }
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select a File!');", true);
        }
        
         
        
    }
    protected void btnupload_Click(object sender, EventArgs e)
    {
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
            String filePath = FileUpload1.PostedFile.FileName;
            String fileType = FileUpload1.PostedFile.ContentType;

            String Name = txtname.Text;
            String desk = txtDesk.Text;

            



            FileUpload1.SaveAs(Server.MapPath("~") + "/img/Dean/" + filePath);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Dean set name='" + Name + "',desk='" + desk + "',img='" + filePath + "' where Id= '2'";
            con.Open();
            int rowsUpdated = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsUpdated > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Updated Successfully');", true);

            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
            GetData();
        }
        catch (Exception e2)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }

    }
            else
                {

                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please choose only .jpg or .png image types!')", true);

                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Please select a File!');", true);
            }
                }
            
}