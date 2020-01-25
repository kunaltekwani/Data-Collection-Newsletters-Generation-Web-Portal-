using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class DispAchievements : System.Web.UI.Page
{

    private SqlConnection con;
    private SqlCommand cmd;
    private DataSet ds;
    private SqlDataAdapter adp;
    private String script = "";
    private int count = 0;
    private static byte flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Faculty_Name,Details from Achievements where Categories = 'Achievement' and status = 'True'";

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            DataList1.DataSource = dt;
            DataList1.DataBind();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Faculty_Name,Details from Achievements where Categories = 'Book' and status = 'True'";

            con.Open();
            SqlDataReader dr2 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            con.Close();

            DataList2.DataSource = dt2;
            DataList2.DataBind();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Faculty_Name,Details from Achievements where Categories = 'Conference' and status = 'True'";

            con.Open();
            SqlDataReader dr3 = cmd.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(dr3);
            con.Close();

            DataList3.DataSource = dt3;
            DataList3.DataBind();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Faculty_Name,Details from Achievements where Categories = 'Journal' and status = 'True'";

            con.Open();
            SqlDataReader dr4 = cmd.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Load(dr4);
            con.Close();

            DataList4.DataSource = dt4;
            DataList4.DataBind();
        }
        catch (Exception e1)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }

        if (!IsPostBack)
        {
            GetConnection();
            GetData();

        }  




    }
    private void GetConnection()
    {
        con = new SqlConnection();
        con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\HP\\Documents\\newsletter.mdf;Integrated Security=True;User Instance=True";
        con.Open();
    }

    private void GetData()
    {
        try
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Programme,Category,Level,Event,Name_of_Students,Rank,status from Student_Achievements where status = 'True'"; //and faculty = '" + Session["uname"].ToString() + "'";
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            gridView1.DataSource = ds.Tables[0];
            gridView1.DataBind();
        }
        catch (Exception e1)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
    }
}