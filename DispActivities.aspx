<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DispActivities.aspx.cs" Inherits="DispActivities" %>

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

    <title>Activities -Imprints</title>

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
	    #aa {
            text-align:right;
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
						<li class="active"><a href="DispActivities.aspx"> &nbsp;&nbsp;&nbsp;Activities&nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispAchievements.aspx">Achievements&nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispCollaborations_n_networking.aspx">Collaborations & Networking&nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispEminent_vsitors.aspx">Eminent Visitors &nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispTestimonials.aspx">Testimonials &nbsp;&nbsp;&nbsp;</a></li>
						<li><a href="DispPlacement.aspx">Placement&nbsp;&nbsp;&nbsp;</a></li>
						
						<li><a href="contact.aspx">Contact</a></li>
					</ul>
				</div><!--/.nav-collapse -->
			</div><!--/.container-fluid -->
		</nav>
	  
	 <div class="page-header">
		 <h1>Activities </h1>
	</div>
	<div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
	  <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingOne">
		  <h4 class="panel-title">
			<a data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
			 <b>Cultural Events</b>
			</a>
		  </h4>
		</div>
		<div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
		  <div class="panel-body">
			<asp:DataList ID="DataList1" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Activity_Name") %>'></asp:Label></b></u><br /></h4>
                <small><asp:Label ID="LabelDate" runat="server" Text='<%# ("<u>Date</u> : ") +Eval("Time_and_Date") %>'></asp:Label></small><br />
                        <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                <div id="aa"><asp:Label ID="Label2" runat="server" Text='<%# ("<u>Place</u> : ") + Eval("Place") %>'></asp:Label><br /></div>
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
		  </div>
		</div>
	  </div>
	  <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingTwo">
		  <h4 class="panel-title">
			<a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
			  <b>Industrial Visit</b>
			</a>
		  </h4>
		</div>
		<div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
		  <div class="panel-body">
				
				<asp:DataList ID="DataList2" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Activity_Name") %>'></asp:Label></b></u><br /></h4>
                <small><asp:Label ID="LabelDate" runat="server" Text='<%# ("<u>Date</u> : ") +Eval("Time_and_Date") %>'></asp:Label></small><br />
                        <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                <div id="aa"><asp:Label ID="Label2" runat="server" Text='<%# ("<u>Place</u> : ") + Eval("Place") %>'></asp:Label><br /></div>
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
			
		  </div>
		</div>
	  </div>
	  <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingThree">
		  <h4 class="panel-title">
			<a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
			  <b>Seminars & Workshops</b>
			</a>
		  </h4>
		</div>
		<div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
		  <div class="panel-body">
		   	<asp:DataList ID="DataList3" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Activity_Name") %>'></asp:Label></b></u><br /></h4>
                <small><asp:Label ID="LabelDate" runat="server" Text='<%# ("<u>Date</u> : ") +Eval("Time_and_Date") %>'></asp:Label></small><br />
                        <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                <div id="aa"><asp:Label ID="Label2" runat="server" Text='<%# ("<u>Place</u> : ") + Eval("Place") %>'></asp:Label><br /></div>
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
		  </div>
		</div>
	 </div>
	 
	   <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingFour">
		  <h4 class="panel-title">
			<a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseFour" aria-expanded="false" aria-controls="headingFour">
			 <b>Social Activities</b>
			</a>
		  </h4>
		</div>
		<div id="collapseFour" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFour">
		  <div class="panel-body">
			<asp:DataList ID="DataList4" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Activity_Name") %>'></asp:Label></b></u><br /></h4>
                <small><asp:Label ID="LabelDate" runat="server" Text='<%# ("<u>Date</u> : ") +Eval("Time_and_Date") %>'></asp:Label></small><br />
                        <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                <div id="aa"><asp:Label ID="Label2" runat="server" Text='<%# ("<u>Place</u> : ") + Eval("Place") %>'></asp:Label><br /></div>
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
		  </div>
		</div>
	 </div>
	 
	   <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingFive">
		  <h4 class="panel-title">
			<a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseFive" aria-expanded="false" aria-controls="collapseFive">
			<b>Technical Events</b>
			</a>
		  </h4>
		</div>
		<div id="collapseFive" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFive">
		  <div class="panel-body">
			<asp:DataList ID="DataList5" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Activity_Name") %>'></asp:Label></b></u><br /></h4>
                <small><asp:Label ID="LabelDate" runat="server" Text='<%# ("<u>Date</u> : ") +Eval("Time_and_Date") %>'></asp:Label></small><br />
                        <br />
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                <div id="aa"><asp:Label ID="Label2" runat="server" Text='<%# ("<u>Place</u> : ") + Eval("Place") %>'></asp:Label><br /></div>
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
		  </div>
		</div>
	 </div>
	 
	    
	 
	</div>
	
	<div class="panel panel-default">
			
				
		  <div class="panel-body">
			<div class="row">
		<div class="col-md-2">
		</div>
		
		<div class="col-md-8">
			<div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="margin auto 0;">
						  <!-- Indicators -->
						  <ol class="carousel-indicators">
							
							<li data-target="#carousel-example-generic" data-slide-to="0"></li>
							<li data-target="#carousel-example-generic" data-slide-to="1"></li>
							<li data-target="#carousel-example-generic" data-slide-to="2"></li>
							<li data-target="#carousel-example-generic" data-slide-to="3"></li>
							<li data-target="#carousel-example-generic" data-slide-to="4"></li>
							<li data-target="#carousel-example-generic" data-slide-to="5"></li>
							<li data-target="#carousel-example-generic" data-slide-to="6"></li>
							<li data-target="#carousel-example-generic" data-slide-to="7"></li>
							<li data-target="#carousel-example-generic" data-slide-to="8"></li>
							<li data-target="#carousel-example-generic" data-slide-to="9"></li>
							
							
							
						  </ol>

						  <!-- Wrapper for slides -->
						  <div class="carousel-inner" role="listbox">
							<div class="item active">
							 <img class="img-responsive" src="assets/img/0.jpg" alt="">
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/1.jpg" alt="">
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/2.jpg" alt="">
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/3.jpg" alt="" >
							</div>
							<div class="item">
							  <img  class="img-responsive"src="assets/img/4.jpg" alt="" >
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/5.jpg" alt=""   >
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/6.jpg" alt=""   >
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/7.jpg" alt=""   >
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/8.jpg" alt=""   >
							</div>
							<div class="item">
							  <img class="img-responsive" src="assets/img/9.jpg" alt=""   >
							</div>
						
							
						  </div>

						  <!-- Controls -->
						  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
							<span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
							<span class="sr-only">Previous</span>
						  </a>
						  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
							<span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
							<span class="sr-only">Next</span>
						  </a>
		</div>
		</div>
		
		<div class="col-md-2">
		</div>
	</div>
			
		  </div>
		  <div class="panel-footer">Gallery</div>
		</div>
	
	
	
		</br></br>
		<!-- Site footer -->
		<div class="panel-footer">
			<p align="center">Imprints e-Newsletter | Designed & Updated by:=Devang Koyani , Kunal Tekawani & Jaivin Ambrutya</p>
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
