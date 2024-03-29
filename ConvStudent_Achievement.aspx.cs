1
00:00:00.06 --> 00:00:01.06
- [Instructor] We will returning

2
00:00:01.06 --> 00:00:04.03
to styling forms and form inputs

3
00:00:04.03 --> 00:00:05.07
in more depth and detail

4
00:00:05.07 --> 00:00:07.09
as we walk through different dimensions

5
00:00:07.09 --> 00:00:11.09
of making forms inviting,
accessible, and responsive.

6
00:00:11.09 --> 00:00:12.08
But first,

7
00:00:12.08 --> 00:00:16.07
let's quickly establish the
essentials of styling a form.

8
00:00:16.07 --> 00:00:22.04
This basically involves
styling CSS for three elements.

9
00:00:22.04 --> 00:00:23.04
I said basically.

10
00:00:23.04 --> 00:00:25.04
There's more to it but this is a start.

11
00:00:25.04 --> 00:00:29.05
Notice that we already have in the coding

12
00:00:29.05 --> 00:00:32.03
a style for the form element itself

13
00:00:32.03 --> 00:00:34.07
and that's applying the padding.

14
00:00:34.07 --> 00:00:37.08
By the way, I'm using RMS, root MS,

15
00:00:37.08 --> 00:00:39.05
as my unit of measurement here,

16
00:00:39.05 --> 00:00:42.05
so that everything will be responsive.

17
00:00:42.05 --> 00:00:46.01
The form style was already created.

18
00:00:46.01 --> 00:00:48.06
The other two styles that we'll need

19
00:00:48.06 --> 00:00:50.01
are label and input.

20
00:00:50.01 --> 00:00:53.04
Let me do label next.

21
00:00:53.04 --> 00:00:56.00
So I'm just adding some
basic styling to the label,

22
00:00:56.00 --> 00:00:58.05
color and display block,

23
00:00:58.05 --> 00:01:05.00
so that each label is on
a new row in the form.

24
00:01:05.00 --> 00:01:07.06
Next I'll do input.

25
00:01:07.06 --> 00:01:11.01
I'm assigning an input color

26
00:01:11.01 --> 00:01:14.09
and stretching the default input width

27
00:01:14.09 --> 00:01:18.03
to take up the entire width of the form.

28
00:01:18.03 --> 00:01:19.02
You probably noticed

29
00:01:19.02 --> 00:01:24.07
that I already have a simple
style for the body tag as well.

30
00:01:24.07 --> 00:01:27.07
We set that up in an earlier chapter.

31
00:01:27.07 --> 00:01:28.06
Part of the objective

32
00:01:28.06 --> 00:01:31.06
of creating these very
basic, very simple styles now

33
00:01:31.06 --> 00:01:33.06
is so that we can distinguish

34
00:01:33.06 --> 00:01:35.05
the different elements of the form

35
00:01:35.05 --> 00:01:37.07
as we design and test them.

36
00:01:37.07 --> 00:01:38.08
In other words,

37
00:01:38.08 --> 00:01:41.01
right now the point of these styles

38
00:01:41.01 --> 00:01:43.01
is more function than style.

39
00:01:43.01 --> 00:01:46.08
It helps us identify what's what.

40
00:01:46.08 --> 00:01:49.07
Later, we'll apply more developed styles

41
00:01:49.07 --> 00:01:51.08
that adapt to different devices,

42
00:01:51.08 --> 00:01:54.05
like high contrast colors
and stripped down display

43
00:01:54.05 --> 00:01:56.03
for mobile devices.

44
00:01:56.03 --> 00:01:57.04
But now we've established

45
00:01:57.04 --> 00:02:00.09
the basic building blocks
of a contemporary form.

46
00:02:00.09 --> 00:02:05.06
On now to applying HTML input types

47
00:02:05.06 --> 00:02:08.04
to make our form really effective.

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
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
            bool status;
            String programme, Category, Level, Event, NoS, Rank, fac, TnD;

            id = e.CommandArgument.ToString();
            programme = ((TextBox)GridView5.Rows[index].Cells[4].Controls[1]).Text;
            Category = ((TextBox)GridView5.Rows[index].Cells[5].Controls[1]).Text;
            Level = ((TextBox)GridView5.Rows[index].Cells[6].Controls[1]).Text;
            Event = ((TextBox)GridView5.Rows[index].Cells[7].Controls[1]).Text;
            NoS = ((TextBox)GridView5.Rows[index].Cells[8].Controls[1]).Text;
            Rank = ((TextBox)GridView5.Rows[index].Cells[9].Controls[1]).Text;
            TnD = ((TextBox)GridView5.Rows[index].Cells[10].Controls[1]).Text;
            fac = ((TextBox)GridView5.Rows[index].Cells[11].Controls[1]).Text;
            status = ((CheckBox)GridView5.Rows[index].Cells[12].Controls[1]).Checked;

            if (programme.Equals("") || Category.Equals("") || TnD.Equals("") || fac.Equals("") || NoS.Equals("") || Rank.Equals("") || Event.Equals("") || Level.Equals(""))
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
                cmd.CommandText = "update Student_Achievements set Programme='" + programme + "', Category='" + Category + "',Level='" + Level + "',Event='" + Event + "' ,Name_of_students ='" + NoS + "', Rank ='" + Rank + "', faculty='" + facx + "',status='" + status + "',date='" + TnD + "' where Id= " + id;
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
                cmd.CommandText = "select Student_Achievements.Id,Programme,Category,Level,Event,Name_of_students,Rank,status,Convert(Varchar(20),date,101) as date, Users.username from Student_Achievements,Users where Student_Achievements.faculty = Users.id and date between '" + fromDate + "' and '" + toDate + "'";
                adp = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adp.Fill(ds);
                GridView5.DataSource = ds.Tables[0];
                GridView5.DataBind();

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