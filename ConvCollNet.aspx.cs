using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ConvCollNet : System.Web.UI.Page
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
        //try
        //{
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select collaboration_and_Networking.Id,Details,status,faculty,Convert(Varchar(20),Date,103) as Date, Users.username from collaboration_and_Networking, Users where collaboration_and_Networking.faculty = Users.id";
            //"select Id,Details,status,faculty,Convert(Varchar(20),Date,103) as Date from collaboration_and_Networking";
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        //}
        //catch (Exception e1)
        //{
        //    script = "<script type=\"text/javascript\">alert('Try again!');</script>";
        //    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        //}
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
            int id;
            script = "<script type=\"text/javascript\">alert('Record Inserted');</script>";
            String Details, fac, TnD;
            bool status;


            Details = ((TextBox)GridView1.FooterRow.FindControl("txtDetails")).Text;
            fac = ((TextBox)GridView1.FooterRow.FindControl("txtfac")).Text;
            TnD = ((TextBox)GridView1.FooterRow.FindControl("txtTnD")).Text;
            status = ((CheckBox)GridView1.FooterRow.FindControl("Checkbox3")).Checked;
            if (fac.Equals("") || Details.Equals("") || status.Equals("") || TnD.Equals(""))
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
            cmd.CommandText = "insert into collaboration_and_Networking (Details,faculty,status,Date) values ('" + Details + "','"+ facx +"','"+ status+"','" + TnD+"')";
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
            cmd.CommandText = "delete from collaboration_and_Networking where Id=" + id;
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
            String Details, fac, TnD;
            bool status; 

            Details = ((TextBox)GridView1.Rows[index].Cells[4].Controls[1]).Text;
            fac = ((TextBox)GridView1.Rows[index].Cells[5].Controls[1]).Text;
            TnD = ((TextBox)GridView1.Rows[index].Cells[6].Controls[1]).Text;
            status = ((CheckBox)GridView1.Rows[index].Cells[7].Controls[1]).Checked;
             
            if (fac.Equals("") || Details.Equals("") || status.Equals("") || TnD.Equals(""))
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
            cmd.CommandText = "update collaboration_and_Networking set Details='"+ Details+"', status='"+status +"',faculty='"+facx +"', Date = '" +TnD+"' where Id= " + id;
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
            String fromDate = "";
            String toDate = "";


            fromDate = FromDateText.Text;
            toDate = ToDateText.Text; ;
            GetConnection();




            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select collaboration_and_Networking.Id,Details,status,faculty,Convert(Varchar(20),Date,103) as Date , Users.username from collaboration_and_Networking, Users where collaboration_and_Networking.faculty = Users.id and Date between '" + fromDate + "' and '" + toDate + "'";
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        catch (Exception e2)
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