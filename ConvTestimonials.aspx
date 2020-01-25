<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConvTestimonials.aspx.cs" Inherits="ConvTestimonials" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8">
	<title>Testimonials</title> 
	<meta name="description" content="GotYa Free Bootstrap Theme"/>
	<meta name="keywords" content="Template, Theme, web, html5, css3, Bootstrap" />
	<meta name="author" content="Łukasz Holeczek from creativeLabs"/>
	<!-- end: Meta -->
	
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
                                    <li><a href="adminindex.aspx">Index</a></li>
			              			<li ><a href="ConvActivities.aspx">Activities</a></li>
			              			<li><a href="ConvAchievements.aspx">Achievements</a></li>
									<li><a href="ConvCollNet.aspx">Collabration & Networking</a></li>
									<li><a href="ConvEminentVisitors.aspx">Eminent Visitors</a></li>
			              			<li  class="active"><a href="ConvTestimonials.aspx">Testimonials</a></li>
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
	<!--end: Header-->
        <br />
        <br />
        <br />
        <br />
	   
		
		
		<div class="media">
			<div align="center">
        <div class="page-header">
		 <h1><u>Experience Sharing by Alumni</u></h1>
		</div>

        <ul>
                    <li>
                        <asp:Label ID="Label1" runat="server" Text="Select a Photo : "></asp:Label>
                        &nbsp<asp:FileUpload ID="FileUpload1" runat="server" />
                        
                    </li>
                    <br />
                    <li>
                        <asp:Label ID="Label2" runat="server" Text="Name of Alumni : "></asp:Label>
                        <asp:TextBox ID="txtAlName" runat="server" Placeholder="Name"></asp:TextBox>
                        
                    </li>
                    
                    <li>
                        <asp:Label ID="Label4" runat="server" Text="Experience : "></asp:Label>
                        <asp:TextBox ID="txtExp" runat="server"  Rows="3" Width="400px" TextMode="MultiLine"></asp:TextBox>
                        
                    </li>
                    <li>
                        <asp:Label ID="Label5" runat="server" Text="Select Batch : "></asp:Label>
                        &nbsp;Starting Year
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            
                            <asp:ListItem> </asp:ListItem>
                            
                            <asp:ListItem>2000</asp:ListItem>
                            <asp:ListItem>2001</asp:ListItem>
                            <asp:ListItem>2002</asp:ListItem>
                            <asp:ListItem>2003</asp:ListItem>
                            <asp:ListItem>2004</asp:ListItem>
                            <asp:ListItem>2005</asp:ListItem>
                            <asp:ListItem>2006</asp:ListItem>
                            <asp:ListItem>2007</asp:ListItem>
                            <asp:ListItem>2008</asp:ListItem>
                            <asp:ListItem>2009</asp:ListItem>
                            <asp:ListItem>2010</asp:ListItem>
                            <asp:ListItem>2011</asp:ListItem>
                            <asp:ListItem>2012</asp:ListItem>
                            <asp:ListItem>2013</asp:ListItem>
                            <asp:ListItem>2014</asp:ListItem>
                            <asp:ListItem>2015</asp:ListItem>
                            <asp:ListItem>2016</asp:ListItem>
                            <asp:ListItem>2017</asp:ListItem>
                            <asp:ListItem>2018</asp:ListItem>
                            <asp:ListItem>2019</asp:ListItem>
                            <asp:ListItem>2020</asp:ListItem>
                        </asp:DropDownList>
                        
                        
&nbsp;Ending Year
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem>2000</asp:ListItem>
                            <asp:ListItem>2001</asp:ListItem>
                            <asp:ListItem>2002</asp:ListItem>
                            <asp:ListItem>2003</asp:ListItem>
                            <asp:ListItem>2004</asp:ListItem>
                            <asp:ListItem>2005</asp:ListItem>
                            <asp:ListItem>2006</asp:ListItem>
                            <asp:ListItem>2007</asp:ListItem>
                            <asp:ListItem>2008</asp:ListItem>
                            <asp:ListItem>2009</asp:ListItem>
                            <asp:ListItem>2010</asp:ListItem>
                            <asp:ListItem>2011</asp:ListItem>
                            <asp:ListItem>2012</asp:ListItem>
                            <asp:ListItem>2013</asp:ListItem>
                            <asp:ListItem>2014</asp:ListItem>
                            <asp:ListItem>2015</asp:ListItem>
                            <asp:ListItem>2016</asp:ListItem>
                            <asp:ListItem>2017</asp:ListItem>
                            <asp:ListItem>2018</asp:ListItem>
                            <asp:ListItem>2019</asp:ListItem>
                            <asp:ListItem>2020</asp:ListItem>
                        </asp:DropDownList>
                        
                    </li>
                    <li>
                        <asp:Button ID="ButtonUpload" runat="server" Text="Submit" OnClick="ButtonUpload_Click" />

                        </li>
                    
                </ul>
             </div>
	
		<div style="margin-left:20px;">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" CssClass="table" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <h4 class="media-heading"><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Alumni_name") %>'></asp:Label></b></h4>
                <h5><asp:Label ID="LabelYear" runat="server" Text='<%# Eval("PassedYear") %>'></asp:Label><br /><br /></h5>
                <div class="pull-right">
                <asp:Image ID="Image1" class="img-circle img-responsive media-object" style="width:10em; height:13em;" runat="server" ImageUrl='<%# ("~/") + path + Eval("img") %>' Height="300" Width="300"/><br />
                    
                    
                    </div>
                <asp:Label ID="LabelTopic" runat="server" Text='<%# Eval("Experience") %>'></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Delete Record" CommandName="Delete" CommandArgument='<%#Eval("Alumni_id") %>'/>
                
            </ItemTemplate>
        </asp:DataList>
    </div>
	
			</br></br>
		<!-- Site footer -->
		<%--<div class="panel-footer">
			<p align="center"> 	Imprints e-Newsletter 2016 | Designed by: DK,KT & JA</p>
		</div>--%>
    </div> <!-- /container -->



	<!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>	
    </form>
   
</body>
</html>
