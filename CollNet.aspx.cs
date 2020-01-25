using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class CollNet : System.Web.UI.Page
{
    private SqlConnection con;
    private SqlCommand cmd;
    private DataSet ds;
    private static byte flag = 0;
    private SqlDataAdapter adp;
    private String script = "";
    private int count = 0;

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
            cmd.CommandText = "select Id,status,faculty,Details,Convert(Varchar(20),Date,101) as Date from collaboration_and_Networking"; // where faculty = '" + Session["uname"].ToString() + "'";
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
            script = "<script type=\"text/javascript\">alert('Record Inserted');</script>";
            String  Details,TnD;


            
            Details = ((TextBox)GridView1.FooterRow.FindControl("txtDetails")).Text;
            TnD = ((TextBox)GridView1.FooterRow.FindControl("txtTnD")).Text;
            
            if ( Details.Equals("") ||  TnD.Equals(""))
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
            cmd.CommandText = "insert into collaborAtion_and_Networking (Details,Date,faculty,status) values ('" + Details + "','"+TnD+"','" + Session["uname"].ToString() + "','False')";
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
            script = "<script type=\"text/javascript\">alert('Successfully Deleted');</script>";
            string id;
            id = e.CommandArgument.ToString();
            GetConnection();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from collaborAtion_and_Networking where Id=" + id;
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
            GridView1.EditIndex = -1;
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
            string id;
            id = e.CommandArgument.ToString();
            String Details,TnD;

            Details = ((TextBox)GridView1.Rows[index].Cells[4].Controls[1]).Text;
            TnD = ((TextBox)GridView1.Rows[index].Cells[5].Controls[1]).Text;
            
            if (Details.Equals("") ||  TnD.Equals(""))
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
            cmd.CommandText = "update collaboration_and_Networking set Details='"+ Details +"',Date='"+TnD+"' where Id= " + id;
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
    


}