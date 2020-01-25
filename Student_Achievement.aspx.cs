using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Student_Achievement : System.Web.UI.Page
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
        cmd.CommandText = "select Id,Programme,Category,Level,Event,Name_of_students,Rank,Convert(Varchar(20),date,101) as date from Student_Achievements";   //where faculty = '" + Session["uname"].ToString() + "'";
        adp = new SqlDataAdapter(cmd);
        ds = new DataSet();
        adp.Fill(ds);
        GridView5.DataSource = ds.Tables[0];
        GridView5.DataBind();
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
    protected void OnRowCommandClick5(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("xInsert"))
        {
            try
            {
            int id;
            script = "<script type=\"text/javascript\">alert('Record Inserted');</script>";
            String programme, Category, Level, Event, NoS, Rank, TnD;


            programme = ((TextBox)GridView5.FooterRow.FindControl("txtpg")).Text;
            Category = ((TextBox)GridView5.FooterRow.FindControl("txtcat")).Text;
            Level = ((TextBox)GridView5.FooterRow.FindControl("txtlevel")).Text;
            Event = ((TextBox)GridView5.FooterRow.FindControl("txtevent")).Text;
            NoS = ((TextBox)GridView5.FooterRow.FindControl("txtname")).Text;
            Rank = ((TextBox)GridView5.FooterRow.FindControl("txtrank")).Text;
            TnD = ((TextBox)GridView5.FooterRow.FindControl("txtTnD")).Text;

            if (programme.Equals("") || Category.Equals("") || Level.Equals("") || Event.Equals("") || NoS.Equals("") || Rank.Equals("") || TnD.Equals("") )
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
            cmd.CommandText = "insert into Student_Achievements(Programme,Category,Level,Event,Name_of_students,Rank,date) values ('" + programme + "','" + Category + "', '" + Level + "','" + Event + "','" + NoS + "','" + Rank + "','" + TnD + "' )";  //,faculty    ,'" + Session["uname"].ToString() + "'
            count = cmd.ExecuteNonQuery();
            GridView5.EditIndex = -1;
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
            cmd.CommandText = "delete from Student_Achievements where Id=" + id;
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
            GridView5.EditIndex = -1;
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
            String programme, Category, Level, Event, NoS, Rank, TnD;

            id = e.CommandArgument.ToString();
            programme = ((TextBox)GridView5.Rows[index].Cells[4].Controls[1]).Text;
            Category = ((TextBox)GridView5.Rows[index].Cells[5].Controls[1]).Text;
            Level = ((TextBox)GridView5.Rows[index].Cells[6].Controls[1]).Text;
            Event = ((TextBox)GridView5.Rows[index].Cells[7].Controls[1]).Text;
            NoS = ((TextBox)GridView5.Rows[index].Cells[8].Controls[1]).Text;
            Rank = ((TextBox)GridView5.Rows[index].Cells[9].Controls[1]).Text;
            TnD = ((TextBox)GridView5.Rows[index].Cells[10].Controls[1]).Text;

            if (programme.Equals("") || Category.Equals("") || Level.Equals("") || Event.Equals("") || NoS.Equals("") || Rank.Equals("") || TnD.Equals(""))
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
                cmd.CommandText = "update Student_Achievements set Programme='" + programme + "',Category ='" + Category + "',Level = '" + Level + "',Event ='" + Event + "',Name_of_students = '" + NoS + "',Rank= '" + Rank + "',date='" + TnD + "'  where Id= " + id;
                count = cmd.ExecuteNonQuery();
                GridView5.EditIndex = -1;
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
            GridView5.EditIndex = index; //generates textbox on displayed data instead of labels
            GetConnection();
            GetData();
        }



    }


}