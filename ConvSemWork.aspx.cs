using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class ConvSemWork : System.Web.UI.Page
{
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
    }

    private void GetData()
    {
        try
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Activity_id,Activity_Name,Categories,Details,Place,Convert(Varchar(20),Time_and_Date,101) as Time_and_Date, status, Users.username from Activities, Users where Categories = 'Seminar & Workshop' and Activities.faculty = Users.id";
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        catch (Exception e1)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            GetConnection();
            GetData();
        }
    }


    protected void OnRowCommandClick(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("xInsert"))
        {
            try
            {
                String name, Details, Place, TnD, fac;
                bool status;
                script = "<script type=\"text/javascript\">alert('Record Inserted');</script>";

                name = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;
                Details = ((TextBox)GridView1.FooterRow.FindControl("txtDetails")).Text;
                Place = ((TextBox)GridView1.FooterRow.FindControl("txtPlace")).Text;
                TnD = ((TextBox)GridView1.FooterRow.FindControl("txtTnD")).Text;
                fac = ((TextBox)GridView1.FooterRow.FindControl("txtfac")).Text;
                status = ((CheckBox)GridView1.FooterRow.FindControl("Checkbox3")).Checked;
                if (name.Equals("") || Details.Equals("") || Place.Equals("") || TnD.Equals("") || fac.Equals(""))
                {

                    script = "<script type=\"text/javascript\">alert('Please Insert all the fields!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
                else
                {
                    GetConnection();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Users.id from Users where Users.username = '" + fac + "'";
                    int facx = (int)((Object)cmd.ExecuteScalar());
                    cmd.CommandText = "insert into Activities(Activity_Name,Categories,Details,Place,Time_and_Date,faculty,status) values ( '" + name + "','Seminar & Workshop','" + Details + "','" + Place + "','" + TnD + "','" + facx + "','" + status + "')";
                    count = cmd.ExecuteNonQuery();
                    GridView1.EditIndex = -1;
                    GetData();
                    flag = 0;
                    if (count >= 1)
                        if (!Page.ClientScript.IsClientScriptBlockRegistered("alert"))
                        {
                            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                        }
                }
            }
            catch (NullReferenceException nre)
            {
                script = "<script type=\"text/javascript\">alert('Please Write correct or Existing name of Faculty!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }






            catch (Exception e1)
            {
                script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
        }
        else if (e.CommandName.Equals("xDelete"))
        {
            try
            {

                script = "<script type=\"text/javascript\">alert('Record Delete');</script>";
                string id;
                id = e.CommandArgument.ToString();
                GetConnection();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Activities where Activity_id=" + id;
                count = cmd.ExecuteNonQuery();
                GetData();
                if (count >= 1)
                    if (!Page.ClientScript.IsClientScriptBlockRegistered("alert"))
                    {
                        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                    }
            }
            catch (Exception e1)
            {
                script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
        }
        else if (e.CommandName.Equals("xCancel"))
        {
            GridView1.EditIndex = -1;
            GetConnection();
            GetData();
        }
        else if (e.CommandName.Equals("xUpdate"))
        {
            try
            {
            GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);
            int index = row.RowIndex;

            if (flag == 0)
            {
                return;
            }
            
                String name, Details, Place, TnD, fac;
                bool status;
                script = "<script type=\"text/javascript\">alert('Record Update');</script>";
                string id;
                id = e.CommandArgument.ToString();
                name = ((TextBox)GridView1.Rows[index].Cells[4].Controls[1]).Text;
                Details = ((TextBox)GridView1.Rows[index].Cells[5].Controls[1]).Text;
                Place = ((TextBox)GridView1.Rows[index].Cells[6].Controls[1]).Text;
                TnD = ((TextBox)GridView1.Rows[index].Cells[7].Controls[1]).Text;
                fac = ((TextBox)GridView1.Rows[index].Cells[8].Controls[1]).Text;
                status = ((CheckBox)GridView1.Rows[index].Cells[9].Controls[1]).Checked;
                if (name.Equals("") || Details.Equals("") || Place.Equals("") || TnD.Equals("") || fac.Equals(""))
                {

                    script = "<script type=\"text/javascript\">alert('Please Insert all the fields!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
                else
                {

                    GetConnection();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select Users.id from Users where Users.username = '" + fac + "'";
                    int facx = (int)((Object)cmd.ExecuteScalar());
                    cmd.CommandText = "update Activities set Activity_Name='" + name + "',Details='" + Details + "',Place='" + Place + "',Time_and_Date='" + TnD + "',faculty=" + facx + ",status='" + status + "' where Activity_id= " + id;
                    count = cmd.ExecuteNonQuery();
                    GridView1.EditIndex = -1;
                    GetData();
                    flag = 0;
                    if (count >= 1)
                        if (!Page.ClientScript.IsClientScriptBlockRegistered("alert"))
                        {
                            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                        }
                }
            }
            catch (InvalidCastException ice)
            {
                script = "<script type=\"text/javascript\">alert('Please select Correct Button!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }





            catch (NullReferenceException nre)
            {
                script = "<script type=\"text/javascript\">alert('Please Write correct or Existing name of Faculty!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }






            catch (Exception e1)
            {
                script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
        }
        else if (e.CommandName.Equals("xEdit"))
        {
            GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);
            int index = row.RowIndex;
            flag = 1;
            GridView1.EditIndex = index; //generates textbox on displayed data instead of labels
            GetConnection();
            GetData();
        }
        
    }

    protected void Filter_Click(object sender, EventArgs e)
    {
        try
        {

            String fromDate;
            String toDate;

            fromDate = FromDateText.Text;
            toDate = ToDateText.Text; ;
            GetConnection();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Activity_id,Activity_Name,Categories,Details,Place,Convert(Varchar(20),Time_and_Date,101) as Time_and_Date, status, Users.username from Activities, Users where Categories = 'Seminar & Workshop' and Activities.faculty = Users.id and Time_and_Date between '" + fromDate + "' and '" + toDate + "'";
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        catch (Exception e1)
        {
            script = "<script type=\"text/javascript\">alert('Try again!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
        //String query = "select * from Activities where Time_and_Date between fromDate and toDate";
    }
    protected void Reset_Click(object sender, EventArgs e)
    {
        GetConnection();
        GetData();
    }
}