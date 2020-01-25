<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DispEminent_vsitors.aspx.cs" Inherits="eminent_vsitors" %>

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

    <title>Eminent Visitors -Imprints</title>

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
						<li  class="active"><a href="DispEminent_vsitors.aspx">Eminent Visitors &nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispTestimonials.aspx">Testimonials &nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispPlacement.aspx">Placement&nbsp;&nbsp;&nbsp;</a></li>
						
						<li><a href="contact.aspx">Contact</a></li>
					</ul>
				</div><!--/.nav-collapse -->
			</div><!--/.container-fluid -->
		</nav>
	   <div class="page-header">
		 <h2><u>Eminent Visitors at SCS</u></h2>
		 <hr>
	  </div>
	  
            <div class="row">
		<div class="col-md-12">
            <div class="panel panel-default">
	 

            <div style="margin-left:20px;">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" CssClass="table">
            <ItemTemplate>
                <u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Visitor_Name") %>'></asp:Label><br /></b></u><br />
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# ("~/") + path + Eval("Img") %>' Height="250" Width="250"/><br /><br />
                <asp:Label ID="LabelDate" runat="server" Text='<%# Eval("Date") %>'></asp:Label><br />
                <asp:Label ID="LabelDetails" runat="server" Text='<%# Eval("Visitor_details") %>'></asp:Label>
                
            </ItemTemplate>
        </asp:DataList>
    </div>

		</div>
                </div>
		</div>

	
</br></br>
		<!-- Site footer -->
		<div class="panel-footer" >
			<p align="center">Imprints e-Newsletter | Designed & Updated by:Devang Koyani , Kunal Tekawani & Jaivin Ambrutya</p>
		</div>
    </div> <!-- /container -->


  <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>	
  </body>
    </form>
</body>
</html>
