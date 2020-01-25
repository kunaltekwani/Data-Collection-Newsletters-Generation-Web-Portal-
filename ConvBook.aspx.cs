using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ConvBook : System.Web.UI.Page
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
        cmd.CommandText = "select Achievements_id,Categories,Faculty_name,Details,status,Convert(Varchar(20),date,101) as date, Users.username from Achievements, Users where Categories = 'Book' and Achievements.faculty = Users.id";
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
            bool status;
            script = "<script type=\"text/javascript\">alert('Record Inserted');</script>";
            String name, Details, fac, TnD;


            name = ((TextBox)GridView2.FooterRow.FindControl("txtBName")).Text;
            Details = ((TextBox)GridView2.FooterRow.FindControl("txtBDetails")).Text;
            TnD = ((TextBox)GridView2.FooterRow.FindControl("txtTnD")).Text;
            fac = ((TextBox)GridView2.FooterRow.FindControl("txtfac")).Text;
            status = ((CheckBox)GridView2.FooterRow.FindControl("Checkbox3")).Checked;

            if (name.Equals("") || Details.Equals("") || TnD.Equals("") || fac.Equals(""))
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
            cmd.CommandText = "insert into Achievements(Faculty_Name,Categories,Details,faculty,status,date) values ( '" + name + "','Book','" + Details + "','" + facx + "','" + status + "','" + TnD + "')";
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
            bool status;
            String name, Details, Place, TnD, fac;

            id = e.CommandArgument.ToString();
            name = ((TextBox)GridView2.Rows[index].Cells[4].Controls[1]).Text;
            Details = ((TextBox)GridView2.Rows[index].Cells[5].Controls[1]).Text;
            TnD = ((TextBox)GridView2.Rows[index].Cells[6].Controls[1]).Text;
            fac = ((TextBox)GridView2.Rows[index].Cells[7].Controls[1]).Text;
            status = ((CheckBox)GridView2.Rows[index].Cells[8].Controls[1]).Checked;

            if (name.Equals("") || Details.Equals("") || TnD.Equals("") || fac.Equals(""))
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
                cmd.CommandText = "update Achievements set Faculty_Name='" + name + "',Details='" + Details + "',faculty=" + facx + ",status='" + status + "',date = '" + TnD + "' where Achievements_id= " + id;
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

    protected void Filter_Click(object sender, EventArgs e)
    {
        if (FromDateText.Text.Equals("") || ToDateText.Text.Equals(""))
        {
            script = "<script type=\"text/javascript\">alert('Please Select Date!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
        else
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
                cmd.CommandText = "select Achievements_id,Categories,Faculty_name,Details,status,Convert(Varchar(20),date,101) as date, Users.username from Achievements, Users where Categories = 'Achievement' and Achievements.faculty = Users.id and Time_and_Date between '" + fromDate + "' and '" + toDate + "'";
                adp = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adp.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();

            }
            catch (Exception e4)
            {
                script = "<script type=\"text/javascript\">alert('Please Select Date!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
        }
        //String query = "select * from Activities where Time_and_Date between fromDate and toDate";
    }
    protected void Reset_Click(object sender, EventArgs e)
    {
        GetConnection();
        GetData();
    }
}