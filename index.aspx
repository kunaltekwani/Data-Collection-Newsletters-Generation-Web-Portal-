<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="News Letter">
    <meta name="author" content="">
    <link rel="icon" href="assets/img/favicon.ico">

    <title>Imprints - School of Computer Studies</title>

    <!-- Bootstrap core CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
	<!-- Optional theme -->
	<!-- link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css" -->
        <link rel="stylesheet" href="http://bootswatch.com/flatly/bootstrap.min.css">
    
	<!-- Custom styles for this template -->
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
		
		
		.jumbotron 
		{
			background:transparent;
			background-image: url("assets/img/jumbotron.png");
			background-repeat: no-repeat;
			background-size: contain;
			
		}
		.tales 
		{
		  width: 100%;
		}
		.carousel-inner{
		  width:100%;
		  max-height: 400px !important;
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
				<img alt="Gesia" class="img-responsive" src="assets/img/ahmedabad-university-logo.png" style="width:auto;margin-top:-05px;margin-bottom:0px">
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
						<li><a href="DispTestimonials.aspx">Testimonials &nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispPlacement.aspx">Placement&nbsp;&nbsp;&nbsp;</a></li>
						
						<li><a href="contact.aspx">Contact</a></li>
                        <li><a href="login.aspx">Login</a></li>
					</ul>
				</div><!--/.nav-collapse -->
			</div><!--/.container-fluid -->
		</nav>
		
		<!-- Main component for a primary marketing message or call to action -->
		
		<div id="carousel" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carousel" data-slide-to="0"></li>
                <li data-target="#carousel" data-slide-to="1"></li>
                <li data-target="#carousel" data-slide-to="2"></li>
                <li data-target="#carousel" data-slide-to="3"></li>
                <%--<li data-target="#carousel" data-slide-to="4"></li>
                <li data-target="#carousel" data-slide-to="5"></li>--%>
            </ol>
            <div class="carousel-inner">
                <div class="item">
                    <img class="img-responsive img-rounded"  src="img/Slider/img2.jpg" alt="Slide 1">
					
                </div>
                <div class="item active">
                    <img class="img-responsive img-rounded" src="img/Slider/img2.jpg" alt="Slide 2">
					
                </div>
                <div class="item">
                    <img class="img-responsive img-rounded" src="img/Slider/img3.jpg" alt="Slide 3">
					
                </div>
                <div class="item">
                    <img class="img-responsive img-rounded" src="img/Slider/img4.jpg" alt="Slide 4">
					
                </div>
                
            </div>
            <a href="#carousel" class="left carousel-control" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
            </a>
            <a href="#carousel" class="right carousel-control" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
            </a>
        </div>

		</br></br>
		
		<div class="panel panel-default">
			<!-- Default panel contents -->
			<div class="panel-heading"><span class="glyphicon glyphicon-bookmark" aria-hidden="true"></span> From the Associate Dean's Desk</div>
			<div class="panel-body">
				<div class="row">
					<div class="col-md-10">
                        <asp:Label ID="LblDesk" runat="server" Text=""></asp:Label>
                        <div align="right"><b><u><asp:Label ID="Lblname" runat="server" Text=""></asp:Label><br />Associate Dean</u></b></div>
						
					</div>
					<div class="col-md-2">
						<img class="img-responsive img-thumbnail" src="img/Dean/bipin-mehta.jpg" class="img-rounded" alt="Prof. Bipin Mehta"> 
					</div>
				</div>
			</div>
		</div>
		
		</br></br>
		<!-- Site footer -->
		<div class="panel-footer">
			<p align="center">Imprints e-Newsletter | Designed & Updated by:Devang Koyani , Kunal Tekawani & Jaivin Ambrutya</p>
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
