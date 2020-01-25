using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ConvTestimonials : System.Web.UI.Page
{   

    public static String path = "/img/Testimonial/";

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
            cmd.CommandText = "select Alumni_id,Alumni_name,PassedYear,Experience,img from Testimonials";


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

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("Delete"))
        {
            try
            {
                int id = int.Parse(e.CommandArgument.ToString());
                GetConnection();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "DELETE FROM Testimonials WHERE Alumni_id =" + id;
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
            catch (Exception e1)
            {
                script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
        }
    }

    protected void ButtonUpload_Click(object sender, EventArgs e)
    {
        if (txtAlName.Text.Equals("") || txtExp.Text.Equals("") || DropDownList1.SelectedValue == "" || DropDownList2.SelectedValue == "")
        {
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please insert all the fields!')", true);
        }
        else
        {
            String filePath = FileUpload1.PostedFile.FileName;
            String fileType = FileUpload1.PostedFile.ContentType;

            String alName = txtAlName.Text;
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
                        script = "<script type=\"text/javascript\">alert('Try again!');</script>";
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
}