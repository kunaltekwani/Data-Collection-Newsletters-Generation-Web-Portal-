﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConvConference.aspx.cs" Inherits="ConvConference" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
	<title>Achievement >>Conference Articles</title> 
	<meta name="description" content="GotYa Free Bootstrap Theme"/>
	<meta name="keywords" content="Template, Theme, web, html5, css3, Bootstrap" />
	<meta name="author" content="Łukasz Holeczek from creativeLabs"/>
	
	<!-- start: Mobile Specific -->
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
	<!-- end: Mobile Specific -->
	
	<!-- start: Facebook Open Graph -->
	<meta property="og:title" content=""/>
	<meta property="og:description" content=""/>
	<meta property="og:type" content=""/>
	<meta property="og:url" content=""/>
	<meta property="og:image" content=""/>
	<!-- end: Facebook Open Graph -->

    <!-- start: CSS -->
    <link href="css/bootstrap.css" rel="stylesheet">
    <link href="css/bootstrap-responsive.css" rel="stylesheet">
	<link href="css/style.css" rel="stylesheet">
	<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Droid+Sans:400,700">
	<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Droid+Serif">
	<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Boogaloo">
	<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Economica:700,400italic">
	<!-- end: CSS -->

    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
    <style>
        #aa {
            padding-left:50px;
        }

        .nav-bar-content-x >a{
            border-top-color:red !important;
            color:red !important;
        }
        .aaa >a {
            background-color:red !important;
        }
        .abc {
            font-family:'Arial Unicode MS';
            color:white;
            font-size:medium;
        }
        .back {
            font-family:'Arial Unicode MS';
            color:white;
            font-size:larger;
        }


        </style>

    <script type="text/javascript">
        function checkDate(sender, args) {

            //Check if the date selected is less than todays date
            if (sender._selectedDate > new Date()) {
                //show the alert message
                alert("You cannot select future date!");
                //set the selected date to todays date in calendar extender control
                sender._selectedDate = new Date();

                // set the date back to the current date
                sender._textbox.set_Value("")

            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--start: Header -->
	<header>
		
		<!--start: Container -->
		<div class="container">
			
			<!--start: Row -->
			<div class="row">
					
				
					
				<!--start: Navigation -->
				<div class="span9">
					
					<div class="navbar navbar-inverse navbar-fixed-top">
			    		<div class="navbar-inner">
			          		<a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
			            		<span class="icon-bar"></span>
			            		<span class="icon-bar"></span>
			            		<span class="icon-bar"></span>
			          		</a>
			          		<div class="nav-collapse collapse">
			            		<ul class="nav">
			              			 
                                    
                                    
			              			<li><a href="ConvAchieve.aspx">Achievements</a></li>
			              			<li class=""><a href="ConvBook.aspx">Book Publications</a></li>
									<li class="active nav-bar-content-x" ><a href="ConvConference.aspx">Conference Articles</a></li>
			              			<li class=""><a href="ConvJournal.aspx">Journal Articles</a></li>
                                    <li class=""><a href="ConvStudent_Achievement.aspx">Student Achievement</a></li>
                                    <li ><a href="index.aspx">Logout</a></li>
			            		</ul>
			          		</div>
			        	</div>
			      	</div>
					
				</div>	
				<!--end: N+avigation -->
					
			</div>
			<!--end: Row -->
			
		</div>
		<!--end: Container-->			
			
	</header>
        <br />			
      <ul>
      <li align="left"><h2><u><b class="back"><a href="ConvAchievements.aspx">Go to Main Achievement Page</a></b></u></h2></li></ul>
		<br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="From"></asp:Label>
        <asp:TextBox ID="FromDateText" runat="server"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="FromDate" runat="server" OnClientDateSelectionChanged="checkDate" TargetControlID="FromDateText"   Format="MM/dd/yyyy" />
        <asp:Label ID="Label2" runat="server" Text="To"></asp:Label>
        <asp:TextBox ID="ToDateText" runat="server"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="ToDate" runat="server" OnClientDateSelectionChanged="checkDate" TargetControlID="ToDateText"   Format="MM/dd/yyyy" />
        <asp:Button ID="Filter" runat="server" Text="Filter" OnClick="Filter_Click" />
        <asp:Button ID="Reset" runat="server" Text="Reset" OnClick="Reset_Click" />

               <div>

        <asp:GridView ID="GridView3" runat="server" AllowPaging="True" 
        AllowSorting="True" CellPadding="4" 
        ShowFooter="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" 
        BorderWidth="1px" OnRowCommand="OnRowCommandClick3"
            AutoGenerateColumns="False">
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                
        <Columns>
          <asp:TemplateField>
             <HeaderTemplate >
                <b class="abc">Delete</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Button runat="server" ID="btnDelete" Text="Delete" CommandName ="xDelete" CommandArgument='<%#Eval("Achievements_id")%>' />
             </ItemTemplate>
          </asp:TemplateField>
          
          
          
          <asp:TemplateField>
             <HeaderTemplate >
                <b class="abc">Update</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Button runat="server" ID="btnUpdate" Text="Update" CommandName ="xUpdate" CommandArgument='<%#Eval("Achievements_id")%>'/>
             </ItemTemplate>
          </asp:TemplateField>
          
          <asp:TemplateField>
             <HeaderTemplate >
                <b class="abc">Edit</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Button runat="server" ID="btnEdit" Text="Edit" CommandName ="xEdit" />
             </ItemTemplate>
          </asp:TemplateField>
          
          <asp:TemplateField>
             <HeaderTemplate >
                <b class="abc">Cancel</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Button runat="server" ID="btnCancel" Text="Cancel" CommandName ="xCancel" />
             </ItemTemplate>  
               <FooterTemplate >
                 <asp:Button ID="btninsert" runat="server" Text="insert" CommandName ="xInsert" />
             </FooterTemplate>           
          </asp:TemplateField>

           
          
          <asp:TemplateField>
             <HeaderTemplate >
              <b class="abc">Faculty Name</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Label runat="server" ID="lblname" Text='<%#Eval("Faculty_Name")%>' Font-Size="Medium" />
             </ItemTemplate>
              <EditItemTemplate >
                 <asp:TextBox ID="txtCName" runat="server" Text='<%#Eval("Faculty_Name")%>' Width="200px"></asp:TextBox>
             </EditItemTemplate>
             <FooterTemplate >
                 <asp:TextBox ID="txtCName" runat="server" Width="200px"></asp:TextBox>
             </FooterTemplate>
          </asp:TemplateField>
          
          <asp:TemplateField>
             <HeaderTemplate >
              <b class="abc">Details</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Label runat="server" ID="lblDetails" Text='<%#Eval("Details") %>' Font-Size="Medium" />
             </ItemTemplate>
              <EditItemTemplate >
                 <asp:TextBox ID="txtCDetails" runat="server" Text='<%#Eval("Details") %>' TextMode="MultiLine" Rows="1" Width="650px"></asp:TextBox>
                  
             </EditItemTemplate>
             <FooterTemplate >
                 <asp:TextBox ID="txtCDetails" runat="server" TextMode="MultiLine" Rows="1" Width="650px"></asp:TextBox>
                 
             </FooterTemplate>
          </asp:TemplateField>

            <asp:TemplateField>
             <HeaderTemplate >
              <b class="abc">Date & Time</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Label runat="server" ID="lbldate3" Text='<%#Eval("date") %>'  Font-Size="Medium"/>
             </ItemTemplate>
              <EditItemTemplate >
                 <asp:TextBox ID="txtTnD" runat="server" Text='<%#Eval("date") %>' width="100px"></asp:TextBox>
                  <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" OnClientDateSelectionChanged="checkDate" TargetControlID="txtTnD"  />
             </EditItemTemplate>
             <FooterTemplate >
                 <asp:TextBox ID="txtTnD" runat="server" width="100px"></asp:TextBox>
                 <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" OnClientDateSelectionChanged="checkDate" TargetControlID="txtTnD" />
             </FooterTemplate>
          </asp:TemplateField>


             <asp:TemplateField>
             <HeaderTemplate >
             <b class="abc">Inserted By</b>
             </HeaderTemplate>
             <ItemTemplate >
                <asp:Label runat="server" ID="lblfac" Text='<%#Eval("username") %>' Font-Size="Medium" />
             </ItemTemplate>
              <EditItemTemplate >
                 <asp:TextBox ID="txtfac" runat="server" Text='<%#Eval("username") %>'></asp:TextBox>
             </EditItemTemplate>
             <FooterTemplate >
                 <asp:TextBox ID="txtfac" runat="server"></asp:TextBox>
             </FooterTemplate>
          </asp:TemplateField>


             <asp:TemplateField>
             <HeaderTemplate >
             <b class="abc">Approval</b>
             </HeaderTemplate>
             <ItemTemplate >
                 <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Convert.ToBoolean(Eval("status")) %>' Enabled="False"/>
             </ItemTemplate>
              <EditItemTemplate >
                  <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Convert.ToBoolean(Eval("status")) %>'/>
             </EditItemTemplate>
             <FooterTemplate >
                 <asp:CheckBox ID="CheckBox3" runat="server" />
             </FooterTemplate>
          </asp:TemplateField>
          
         

        </Columns>
        
        
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        
            <RowStyle BackColor="White" ForeColor="#330099" />
        
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        
    </asp:GridView>
            </div>



        


                  <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
&nbsp;
    </form>
</body>
</html>
