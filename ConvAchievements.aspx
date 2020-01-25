﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConvAchievements.aspx.cs" Inherits="ConvAchievement1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta charset="utf-8">
	<title>Achievement</title> 
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
			              			<li><a href="ConvActivities.aspx">Activities</a></li>
			              			<li class="active"><a href="ConvAchievements.aspx">Achievement</a></li>
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
	<!--end: Header-->
        <br />
        <br />
        <br />
        <br />
    <div class="aa">
        <ul>
            <li><a href="ConvAchieve.aspx">Faculty Achievements</a></li>
           <br />
           <br />
        
            <li><a href="ConvBook.aspx">Book Publications</a></li>
            <br />
            <br />
        
            <li><a href="ConvConference.aspx">Conference Articles</a></li>
            <br />
            <br />
        
            <li><a href="ConvJournal.aspx">Journal Articles</a></li>
             <br />
            <br />

              <li><a href="ConvStudent_Achievement.aspx">Student Achievements</a></li>
             <br />
            <br />
        </ul>

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