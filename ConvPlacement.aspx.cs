using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class ConvPlacement : System.Web.UI.Page
{

    public static String path = "/pdf/";
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
            cmd.CommandText = "select Placement.id,pdf, year, Users.username from Placement,Users where Placement.faculty= Users.id and status='True'";


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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.Equals(""))
        {
            Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Please select a year!')", true);
        }
        else
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

                        cmd.CommandText = "insert into Placement(pdf,year,faculty,status) values(@pdf,@year,'1','True')";

                        con.Open();
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsUpdated > 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Inserted Successfully');", true);
                            GetConnection();
                            GetData();
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('Try Again');", true);
                        }
                    }
                    catch (Exception e1)
                    {
                        script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                    }
                }
            }
        }
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("Btn_PDF"))
        {
            int id = int.Parse(e.CommandArgument.ToString());

            GetConnection();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select Placement.id,pdf,year FROM Placement WHERE Placement.id =" + id;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String pdf = dr["pdf"].ToString();
                Response.Redirect("~" + path + pdf);
                con.Close();
            }

        }
        if (e.CommandName.Equals("Btn_Delete"))
        {
            int id = int.Parse(e.CommandArgument.ToString());
            GetConnection();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Placement where Placement.id=" + id;
            count = cmd.ExecuteNonQuery();
            if (count >= 1)
                if (!Page.ClientScript.IsClientScriptBlockRegistered("alert"))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "alert('deleted');", true);
                }
            GetConnection();
            GetData();

        }

    }
}