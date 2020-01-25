using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Configuration;

public partial class Reports : System.Web.UI.Page
{

    //private SqlConnection con;
    //private SqlCommand cmd;
    //private SqlDataAdapter adp;
    //public DataSet ds;


    //private void GetConnection()
    //{
    //    con = new SqlConnection();
    //    con.ConnectionString = ConfigurationManager.ConnectionStrings["Newsletter"].ConnectionString;
    //    con.Open();
    //}

    //private void GetData()
    //{
    //    cmd = new SqlCommand();
    //    cmd.Connection = con;
    //    cmd.CommandText = "select Activity_id,Activity_Name,Categories,Details,Place,Convert(Varchar(20),Time_and_Date,101) as Time_and_Date, status, Users.username from Activities, Users where Categories = 'Cultural' and Activities.faculty = Users.id and Time_and_Date between '" + FromDateText.Text.ToString() + "' and '" + ToDateText.Text.ToString() + "'";
    //    cmd.CommandType = CommandType.Text;

    //    adp = new SqlDataAdapter(cmd);
    //    ds = new DataSet("ds_cult_date");  
    //    adp.Fill(ds, "Activities");


    //    con.Close();


    //}

    


    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void Filter_Click1(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedValue.Equals(""))
        {
            String script = "<script type=\"text/javascript\">alert('Please Select Any Activity!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
        else if (DropDownList1.SelectedValue.Equals("Cultural"))
        {
            if (FromDateText.Text.Equals("") || ToDateText.Text.Equals(""))
            {
                String script = "<script type=\"text/javascript\">alert('Please Select Date!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            else
            {
                try
                {
                    Session["from"] = FromDateText.Text;
                    Session["to"] = ToDateText.Text;
                    

                    Response.Redirect("Report_Cultural_date.aspx");

                }
                catch (Exception e4)
                {
                    String script = "<script type=\"text/javascript\">alert('Try Again!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
            }
        }

        else if (DropDownList1.SelectedValue.Equals("Industrial Visit"))
        {
            if (FromDateText.Text.Equals("") || ToDateText.Text.Equals(""))
            {
                String script = "<script type=\"text/javascript\">alert('Please Select Date!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            else
            {
                try
                {
                    Session["from"] = FromDateText.Text;
                    Session["to"] = ToDateText.Text;

                    Response.Redirect("Report_Industrial_date.aspx");

                }
                catch (Exception e4)
                {
                    String script = "<script type=\"text/javascript\">alert('Try Again!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }

            }
        }
        else if (DropDownList1.SelectedValue.Equals("semwork"))
        {
            if (FromDateText.Text.Equals("") || ToDateText.Text.Equals(""))
            {
                String script = "<script type=\"text/javascript\">alert('Please Select Date!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            else
            {
                try
                {
                    Session["from"] = FromDateText.Text;
                    Session["to"] = ToDateText.Text;

                    Response.Redirect("Report_semwork_date.aspx");

                }
                catch (Exception e4)
                {
                    String script = "<script type=\"text/javascript\">alert('Try Again!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
            }

        }
        else if (DropDownList1.SelectedValue.Equals("Social"))
        {
            if (FromDateText.Text.Equals("") || ToDateText.Text.Equals(""))
            {
                String script = "<script type=\"text/javascript\">alert('Please Select Date!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            else
            {
                try
                {
                    Session["from"] = FromDateText.Text;
                    Session["to"] = ToDateText.Text;

                    Response.Redirect("Report_social_date.aspx");

                }
                catch (Exception e4)
                {
                    String script = "<script type=\"text/javascript\">alert('Try Again!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
            }
        }
        else if (DropDownList1.SelectedValue.Equals("Technical"))
        {
            if (FromDateText.Text.Equals("") || ToDateText.Text.Equals(""))
            {
                String script = "<script type=\"text/javascript\">alert('Please Select Date!');</script>";
                Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
            }
            else
            {
                try
                {
                    Session["from"] = FromDateText.Text;
                    Session["to"] = ToDateText.Text;

                    Response.Redirect("Report_technical_date.aspx");

                }
                catch (Exception e4)
                {
                    String script = "<script type=\"text/javascript\">alert('Try Again!');</script>";
                    Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
                }
            }
        }
    }
    protected void Rp_Click1(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue.Equals(""))
        {
            String script = "<script type=\"text/javascript\">alert('Please Select Any Activity!');</script>";
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), "alert", script, false);
        }
        else if (DropDownList1.SelectedValue.Equals("Cultural"))
        {
            Response.Redirect("Report_Cultural_approval.aspx");
        }
        else if (DropDownList1.SelectedValue.Equals("Industrial Visit"))
        {
            Response.Redirect("Report_Industrial_approval.aspx");

        }
        else if (DropDownList1.SelectedValue.Equals("semwork"))
        {
            Response.Redirect("Report_semwork_approval.aspx");
        }
        else if (DropDownList1.SelectedValue.Equals("Social"))
        {
            Response.Redirect("Report_social_approval.aspx");
        }
        else if (DropDownList1.SelectedValue.Equals("Technical"))
        {
            Response.Redirect("Report_technical_approval.aspx");
        }


    }
}

    


    
