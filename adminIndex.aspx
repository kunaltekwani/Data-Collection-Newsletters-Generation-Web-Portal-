<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminIndex.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
	<title>Activities</title> 
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
        .aa {
            padding-left:100px;
            font-family:'Arial Unicode MS';
            font-size:x-large;
        }
        </style>
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
					
					<div class="navbar navbar-inverse navbar-fixed-top">
			    		<div class="navbar-inner">
			          		<a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
			            		<span class="icon-bar"></span>
			            		<span class="icon-bar"></span>
			            		<span class="icon-bar"></span>
			          		</a>
			          		<div class="nav-collapse collapse">
			            		<ul class="nav">
                                    <li class="active"><a href="adminindex.aspx">Index</a></li>
			              			<li><a href="ConvActivities.aspx">Activities</a></li>
			              			<li><a href="ConvAchievements.aspx">Achievements</a></li>
									<li><a href="ConvCollNet.aspx">Collabration & Networking</a></li>
									<li><a href="ConvEminentVisitors.aspx">Eminent Visitors</a></li>
			              			<li><a href="ConvTestimonials.aspx">Testimonials</a></li>
                                    <li><a href="ConvPlacement.aspx">Placment</a></li>
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

        <ul>
            <h2><a href="ConvActivities.aspx">Go to Activities</a></h2>
        </ul>
        <br />
        <br />
        <br />
        <h3>Select Slider number And change the Image</h3>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="130px">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Slider1</asp:ListItem>
            <asp:ListItem>Slider2</asp:ListItem>
            <asp:ListItem>Slider3</asp:ListItem>
            <asp:ListItem>Slider4</asp:ListItem>
        </asp:DropDownList> 
        &nbsp; 
        <asp:FileUpload ID="FileUpload2" runat="server" />   
        <asp:Button ID="Button1" runat="server" Text="Change Slider" OnClick="Button1_Click"/>
        <br />
        <br />
        <br />

        <h2>From the Associate Dean's Desk</h2>
        <br />
        <h3><b>Details</b></h3><br />
        <asp:TextBox ID="txtDesk" runat="server" TextMode="MultiLine" Rows="6" Width="600px"></asp:TextBox>
        <br />
        <br />
         <div align="right" >
            
        <b><h3>Name of Associate Dean</h3><asp:TextBox ID="txtname" runat="server" Placeholder="Name of Associate Dean" Height="31px" Width="150px"></asp:TextBox></b></div>

    </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select a Photo : "></asp:Label>
                        &nbsp<asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <b><asp:Button ID="btnupload" runat="server" Text="Make Change" OnClick="btnupload_Click" /></b>

        </div>
    </form>
</body>
</html>
