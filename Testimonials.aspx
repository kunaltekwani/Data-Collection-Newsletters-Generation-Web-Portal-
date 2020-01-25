<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Testimonials.aspx.cs" Inherits="Testimonials" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


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
			              			<li><a href="Activities.aspx">Activities</a></li>
			              			<li><a href="Achievements.aspx">Achievements</a></li>
									<li><a href="CollNet.aspx">Collabration & Networking</a></li>
									<li><a href="EminentVisitors.aspx">Eminent Visitors</a></li>
			              			<li class="active"><a href="Testimonials.aspx">Testimonials</a></li>
                                    <li><a href="Placement.aspx">Placment</a></li>
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
	
         <div align="center">
        <div class="page-header">
		 <h1><u>Experience Sharing by Alumni</u></h1>
		</div>

        <ul>
                    <li>
                        <asp:Label ID="Label1" runat="server" Text="Select a Photo : "></asp:Label>
                        &nbsp<asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator>
                    </li>
                    <br />
                    <li>
                        
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem>Mr.</asp:ListItem>
                            <asp:ListItem>Mrs.</asp:ListItem>
                            <asp:ListItem>Miss.</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="Label2" runat="server" Text=" : "></asp:Label>
                        <asp:TextBox ID="txtAlName" runat="server" Placeholder="Name of Alumni"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="txtAlName"></asp:RequiredFieldValidator>
                        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" ErrorMessage="Enter String only" ControlToValidate="txtAlName" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </li>
                    
                    <li>
                        <asp:Label ID="Label4" runat="server" Text="Experience : "></asp:Label>
                        <asp:TextBox ID="txtExp" runat="server"  Rows="3" Width="400px" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="txtExp"></asp:RequiredFieldValidator>
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
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
                        
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
                        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="DropDownList2"></asp:RequiredFieldValidator>
                    </li>
                    <li>
                        <asp:Button ID="ButtonUpload" runat="server" Text="Submit" OnClick="ButtonUpload_Click" />

                        </li>
                    
                </ul>
             </div>
<%--         <ul>
            <li>
                <asp:Label ID="Label1" runat="server" Text="Select a Photo : "></asp:Label>
                &nbsp<asp:FileUpload ID="FileUpload1" runat="server" />
             </li>
              <li>
                  <asp:Label ID="Label2" runat="server" Text="Name of Alumni :"></asp:Label>
                  <asp:TextBox ID="txtAluName" runat="server"></asp:TextBox>
             </li>
              <li>
                  <asp:Label ID="Label3" runat="server" Text="Year Passed :"></asp:Label>
                  <asp:TextBox ID="txtYearPassed" runat="server"></asp:TextBox>
             </li>
		     <li>
                  <asp:Label ID="Label4" runat="server" Text="Experience :"></asp:Label>
                 <textarea id="txtExp" cols="20" rows="2"></textarea>
             </li>
             <li>
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </li>

		    

        </ul>--%>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>d
        </div>
        </form>


        <!-- start: Java Script -->
<!-- Placed at the end of the document so the pages load faster -->
<script src="js/jquery-1.8.2.js"></script>
<script src="js/bootstrap.js"></script>
<script src="js/flexslider.js"></script>
<script src="js/carousel.js"></script>
<script src="js/jquery.cslider.js"></script>
<script src="js/slider.js"></script>
<script defer="defer" src="js/custom.js"></script>
<!-- end: Java Script -->
</body>
</html>
