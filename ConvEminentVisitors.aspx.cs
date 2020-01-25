using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ConvEminentVisitors : System.Web.UI.Page
{
    public static String path = "/img/visitors/";


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
            cmd.CommandText = "select Visitor_id,Visitor_Name, Visitor_details, Date, Img ,Users.username from Visitor,Users where Visitor.faculty= Users.id";


            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataList1.DataSource = dt;
            DataList1.DataBind();
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


    protected void ButtonUpload_Click(object sender, EventArgs e)
    {
        if (txtVisitorName.Text.Equals("") || txtDes.Text.Equals("") || txtDate.Text.Equals(""))
        {
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please insert all the fields.')", true);
        }
        else
        {
            String filePath = FileUpload1.PostedFile.FileName;
            String fileType = FileUpload1.PostedFile.ContentType;

            String visName = DropDownList1.Text + " " + txtVisitorName.Text;
            String visDetails = txtDes.Text;
            String visDate = txtDate.Text;
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
                        FileUpload1.SaveAs(Server.MapPath("~") + "/img/visitors/" + filePath);

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("@name", visName));
                        cmd.Parameters.Add(new SqlParameter("@details", visDetails));
                        cmd.Parameters.Add(new SqlParameter("@date", visDate));
                        cmd.Parameters.Add(new SqlParameter("@img", filePath));
                        cmd.CommandText = "insert into Visitor(Visitor_Name, Visitor_details, Date, Img,status,faculty) values(@name,@details,@date,@img,'True','1')";

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

    
    
    
    
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("Delete"))
        {
            int id = int.Parse(e.CommandArgument.ToString());
            GetConnection();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM Visitor WHERE Visitor_id =" + id;
            if (cmd.ExecuteNonQuery() >= 1)
            {
                script = "<script type=\"text/javascript\">alert('Successfully Deleted');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            else
            {
                script = "<script type=\"text/javascript\">alert('Cannot Delete!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            GetData();
        }
    }
}