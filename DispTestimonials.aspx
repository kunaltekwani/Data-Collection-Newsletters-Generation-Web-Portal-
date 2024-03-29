﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DispTestimonials.aspx.cs" Inherits="DispTestimonials" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">
   <link rel="icon" href="assets/img/favicon.ico">

    <title>Testimonials - Imprints</title>

     <!-- Bootstrap core CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
	<!-- Optional theme -->
	<!-- link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css" -->
        <link rel="stylesheet" href="http://bootswatch.com/flatly/bootstrap.min.css">
    
	<style>
		body 
		{
			padding-top: 20px;
			padding-bottom: 20px;
		}

		.navbar 
		{
		  margin-bottom: 20px;
		}
	</style>
	
  

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
<body>
    <form id="form1" runat="server">
    <div class="container">
		<div class="row">
			<div class="col-xs-6 .col-sm-3">
				<img alt="Ahmedabad University" class="img-responsive" src="assets/img/ahmedabad-university-logo.png" style="width:auto;margin-top:-05px;margin-bottom:0px">
			</div>
					
			<div class="col-xs-6 .col-sm-3">
				<img align="right" alt="School of Computer Studies"  title="School of Computer Studies" class="img-responsive" src="assets/img/scs.png" style="width:300px;height:120px;margin-bottom:0px">
				<!-- <p align="right"><big>School of Computer Studies</big><br>AES Institute of Computer Studies<small></br>" Nurturing Next Generation IT Specialist & Entrepreneurs "</small></p> -->
			</div>
		</div>
<p align="center">
				<img alt="Ahmedabad University"  src="assets/img/Imprints.png" align="Center">
		<br>

		<!-- Static navbar -->
		<nav class="navbar navbar-default navbar-inverse">
			<div class="container-fluid">
				<div class="navbar-header">
					<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
					  <span class="sr-only">Toggle navigation</span>
					  <span class="icon-bar"></span>
					  <span class="icon-bar"></span>
					  <span class="icon-bar"></span>
					</button>
					<a class="navbar-brand" href="index.aspx" title="Imprints - News letter">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Home</a>
				</div>
				<div id="navbar" class="navbar-collapse collapse ">
					<ul class="nav navbar-nav">
						<li><a href="DispActivities.aspx"> &nbsp;&nbsp;&nbsp;Activities&nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispAchievements.aspx">Achievements&nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispCollaborations_n_networking.aspx">Collaborations & Networking&nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispEminent_vsitors.aspx">Eminent Visitors &nbsp;&nbsp;&nbsp;</a></li>
						<li class="active"><a href="DispTestimonials.aspx">Testimonials &nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispPlacement.aspx">Placement&nbsp;&nbsp;&nbsp;</a></li>
						
						<li><a href="contact.aspx">Contact</a></li>
					</ul>
				</div><!--/.nav-collapse -->
			</div><!--/.container-fluid -->
		</nav>
	   
		<div class="page-header">
		 <h1><u>Experience Sharing by Alumni</u></h1>
		</div>
		
		<div class="media">
			
            <div class="row">
		<div class="col-md-12">
            <div class="panel panel-default">
	
		<div style="margin-left:30px;">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <h4 class="media-heading"><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Alumni_name") %>'></asp:Label></b></h4>
                <small><asp:Label ID="LabelYear" runat="server" Text='<%# Eval("PassedYear") %>'></asp:Label><br /><br /></small>
                <div class="pull-right">
                <asp:Image ID="Image1" class="img-circle img-responsive media-object" style="width:10em; height:13em;" runat="server" ImageUrl='<%# ("~/") + path + Eval("img") %>' Height="300" Width="300"/><br />
                    </div>
                <asp:Label ID="LabelTopic" runat="server" Text='<%# Eval("Experience") %>'></asp:Label>&nbsp;&nbsp;
                
            </ItemTemplate>
        </asp:DataList>
    </div>
	
                </div>
            </div>
                </div>
			</br></br>
		<!-- Site footer -->
		<div class="panel-footer">
			<p align="center">Imprints e-Newsletter | Designed & Updated by: Devang Koyani , Kunal Tekawani & Jaivin Ambrutya</p>
		</div>
    </div> <!-- /container -->



	<!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>	
    </form>
</body>
</html>
