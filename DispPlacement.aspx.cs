using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class DispPlacement : System.Web.UI.Page
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
        try
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\HP\\Documents\\newsletter.mdf;Integrated Security=True;User Instance=True";
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        catch (Exception e1)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
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
    
    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("~/Pdf/e-ChallanICICI.pdf");
    //}
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("Btn_PDF"))
        {
            try
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
            catch (Exception e1)
            {
                script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            
        }

    }
}