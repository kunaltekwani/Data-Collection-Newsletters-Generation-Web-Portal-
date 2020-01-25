using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class DispActivities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Activity_Name, Details,Time_and_Date,place from Activities where Categories = 'Cultural' and status = 'True'";

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            DataList1.DataSource = dt;
            DataList1.DataBind();

            //Industrial
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Activity_Name, Details,Time_and_Date,place from Activities where Categories = 'Industrial'";

            con.Open();
            SqlDataReader dr2 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            con.Close();

            DataList2.DataSource = dt2;
            DataList2.DataBind();

            //SemWork
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Activity_Name, Details,Time_and_Date,place from Activities where Categories = 'Seminar & Workshop'";

            con.Open();
            SqlDataReader dr3 = cmd.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(dr3);
            con.Close();

            DataList3.DataSource = dt3;
            DataList3.DataBind();


            //Social

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Activity_Name, Details,Time_and_Date,place from Activities where Categories = 'Social Activity'";

            con.Open();
            SqlDataReader dr4 = cmd.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Load(dr4);
            con.Close();

            DataList4.DataSource = dt4;
            DataList4.DataBind();


            //Technical

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Activity_Name, Details,Time_and_Date,place from Activities where Categories = 'Technical'";

            con.Open();
            SqlDataReader dr5 = cmd.ExecuteReader();
            DataTable dt5 = new DataTable();
            dt5.Load(dr5);
            con.Close();

            DataList5.DataSource = dt5;
            DataList5.DataBind();

        }
        catch (Exception e1)
        {
            String script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }


    }
}