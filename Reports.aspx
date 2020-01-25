<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Reports" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
	<title>Activities >> Cultural Activities</title> 
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
    <header>
		
		<!--start: Container -->
		<div class="container">
			
			<!--start: Row -->
			<div class="row">
					
				
					
				<!--start: Navigation -->
				<div class="span9">
					
					<div class="navbar navbar-inverse navbar-fixed-top ">
			    		<div class="navbar-inner">
                            
			          		<%--<a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
			            		
                                  <span class="icon-bar"></span>
			            		<span class="icon-bar"></span>
			            		<span class="icon-bar"></span>
			          		</a>--%>
			          		<div class="nav-collapse collapse">
			            		<ul class="nav">
                                    
                                    
                                    
			              			<li><a href="ConvCultural.aspx">Cultural Events</a></li>
			              			<li class=""><a href="ConvIndustrial.aspx">Industrial Visit</a></li>
									<li class=""><a href="ConvSemWork.aspx">Seminars & Workshops</a></li>
									<li class=""><a href="ConvSocial.aspx">Social Activities</a></li>
			              			<li class=""><a href="ConvTechnical.aspx">Technical Events</a></li>
                                    <li  class="active nav-bar-content-x" ><a href="Reports.aspx">Reports</a></li>
                                    <li ><a href="Login.aspx">Logout</a></li>
			              			
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
        <br />
        <ul>
            <li align="left"><h1><b class="back"><u><a href="ConvActivities.aspx">Back to Activities</a></u></b></h1></li>
        </ul>
        <br />
        <br />
        <br />
        
        
        <h3>Select Category from the list</h3>&nbsp<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Cultural</asp:ListItem>
            <asp:ListItem>Industrial Visit</asp:ListItem>
            <asp:ListItem Value="semwork">Seminar &amp; Workshop</asp:ListItem>
            <asp:ListItem>Social</asp:ListItem>
            <asp:ListItem>Technical</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label1" runat="server" Text="From"></asp:Label>
        <asp:TextBox ID="FromDateText" runat="server"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="FromDate" runat="server" OnClientDateSelectionChanged="checkDate" TargetControlID="FromDateText"   Format="MM/dd/yyyy" />
        <asp:Label ID="Label2" runat="server" Text="To"></asp:Label>
        <asp:TextBox ID="ToDateText" runat="server"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="ToDate" runat="server" OnClientDateSelectionChanged="checkDate" TargetControlID="ToDateText"   Format="MM/dd/yyyy" />
        <asp:Button ID="Filter" runat="server" Text="View Report Between two Dates" OnClick="Filter_Click1" />
        &nbsp;
        <asp:Button ID="Rp" runat="server" Text="View Approved Records in Report" OnClick="Rp_Click1" />
        
        
        


    </div>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </form>
</body>
</html>
