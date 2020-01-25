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

public partial class Report_technical_date : System.Web.UI.Page
{
    private SqlConnection con;
    private SqlCommand cmd;
    private SqlDataAdapter adp;
    private DataSet ds;

    private void GetConnection()
    {
        con = new SqlConnection();
        con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\HP\\Documents\\newsletter.mdf;Integrated Security=True;User Instance=True";
        con.Open();
    }

    private void GetData()
    {
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select Activity_id,Activity_Name,Categories,Details,Place,Convert(Varchar(20),Time_and_Date,101) as Time_and_Date, status, Users.username from Activities, Users where Categories = 'Technical' and Activities.faculty = Users.id and Time_and_Date between '" + Session["from"].ToString() + "' and '" + Session["to"].ToString() + "'";
        cmd.CommandType = CommandType.Text;

        adp = new SqlDataAdapter(cmd);
        ds = new DataSet("ds_tech_date");
        adp.Fill(ds, "Activities");


        con.Close();


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        GetConnection();
        GetData();


        ds.WriteXml(Server.MapPath("~") + "\\App_Data\\rep_act.xml");
        ds.WriteXmlSchema(Server.MapPath("~") + "\\App_Data\\rep_act.xsd");


        ReportDocument rd = new ReportDocument();
        rd.Load(Server.MapPath("~") + "\\App_Data\\Report_technical_date.rpt");
        rd.SetDataSource(ds);
        CrystalReportViewer1.ReportSource = rd;
        CrystalReportViewer1.DataBind();
        CrystalReportViewer1.RefreshReport();

    }
}