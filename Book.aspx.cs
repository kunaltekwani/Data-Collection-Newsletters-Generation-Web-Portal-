using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Book : System.Web.UI.Page
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
        cmd.CommandText = "select Achievements_id,Categories,Faculty_name,Details,status,Convert(Varchar(20),date,101) as date from Achievements where Categories = 'Book'"; //and faculty = '" + Session["uname"].ToString() + "'";
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();
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
         protected void OnRowCommandClick2(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("xInsert"))
        {
            try
            {
            int id;
            script = "<script type=\"text/javascript\">alert('Record Inserted');</script>";
            String name, Details,TnD;


            name = ((TextBox)GridView2.FooterRow.FindControl("txtBName")).Text;
            Details = ((TextBox)GridView2.FooterRow.FindControl("txtBDetails")).Text;
            TnD = ((TextBox)GridView2.FooterRow.FindControl("txtTnD")).Text;

            if (name.Equals("") || Details.Equals("") || TnD.Equals(""))
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
            cmd.CommandText = "insert into Achievements(Categories,Faculty_Name,Details,date) values ( 'Book','" + name + "', '" + Details + "','" + TnD + "')"; //,faculty    '" + Session["uname"].ToString() + "',
            count = cmd.ExecuteNonQuery();
            GridView2.EditIndex = -1;
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
                script = "<script type=\"text/javascript\">alert('Successfully Deleted');</script>";
                string id;
                id = e.CommandArgument.ToString();
                GetConnection();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Achievements where Achievements_id=" + id;
                count = cmd.ExecuteNonQuery();
                GetData();
                if (count >= 1)
                    if (!Page.ClientScript.IsClientScriptBlockRegistered("alert"))
                    {
                        Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                    }
            }
            catch (Exception e2)
            {
                script = "<script type=\"text/javascript\">alert('Try again!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
        }
        else if (e.CommandName.Equals("xCancel"))
        {
            GridView2.EditIndex = -1;
            GetConnection();
            GetData();
        }
        else if (e.CommandName.Equals("xUpdate"))
        {
            try
            {
            script = "<script type=\"text/javascript\">alert('Successfully Updated');</script>";
            GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);
            int index = row.RowIndex;

            if (flag == 0)
            {
                return;
            }
            String id;
            String name, Details, Place, TnD;

            id = e.CommandArgument.ToString();
            name = ((TextBox)GridView2.Rows[index].Cells[4].Controls[1]).Text;
            Details = ((TextBox)GridView2.Rows[index].Cells[5].Controls[1]).Text;
            TnD = ((TextBox)GridView2.Rows[index].Cells[6].Controls[1]).Text;

            if (name.Equals("") || Details.Equals("") || TnD.Equals(""))
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
                cmd.CommandText = "update Achievements set Faculty_Name='" + name + "',Details='" + Details + "',date='" + TnD + "' where Achievements_id= " + id;
                count = cmd.ExecuteNonQuery();
                GridView2.EditIndex = -1;
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
            GridView2.EditIndex = index; //generates textbox on displayed data instead of labels
            GetConnection();
            GetData();
        }



    }

    }
