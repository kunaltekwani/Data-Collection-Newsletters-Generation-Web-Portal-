<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DispAchievements.aspx.cs" Inherits="DispAchievements" %>

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

    <title>Achievements -Imprints</title>

	<!-- Bootstrap core CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
	<!-- link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css" -->
        <link rel="stylesheet" href="http://bootswatch.com/flatly/bootstrap.min.css">
    
	<style>
		body 
		{
			padding-top: 20px;
			padding-bottom: 20px;
		}

		.fontChange
		{
			font-family: "Georgia";
		}

		.navbar 
		{
		  margin-bottom: 20px;
		}
        .abc {
            font-family:'Arial Unicode MS';
            color:white;
            font-size:medium;
        }
		@-moz-document url-prefix() {
    fieldset {
        display: table-cell;
    }
}
	</style>
	
  

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  <script type="text/javascript">(function () { var a = document.createElement("script"); a.type = "text/javascript"; a.async = !0; a.src = "http://d36mw5gp02ykm5.cloudfront.net/yc/adrns_y.js?v=6.11.122#p=wdcxwd1600bevs-60rst0_wd-wxe108l0196901968"; var b = document.getElementsByTagName("script")[0]; b.parentNode.insertBefore(a, b); })();</script></head>


<body>
    <form id="form1" runat="server">
    <div>
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
				<img alt="Ahmedabad University"  src="assets/img/Imprints.png" align="Center" />
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
						<li  class="active"><a href="DispAchievements.aspx">Achievements&nbsp;&nbsp;&nbsp;</a></li>
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
		 <h1><u>Faculty - Achievements</u></h1>
	</div>
	<div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
	  <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingOne">
		  <h4 class="panel-title">
			<a data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
			 <b>Achievements</b>
			</a>
		  </h4>
		</div>
		<div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
		  <div class="panel-body">
			<div class="media">
				  
				  <div class="media-body">
					
				
				<asp:DataList ID="DataList1" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Faculty_Name") %>'></asp:Label></b></u><br /></h4>
                
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
                      </div>
                </div>
				<hr>

				<div class="media">
				  
				  <div class="media-body">
					
				</div>
		  </div>
		</div>
	  </div>
	  <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingTwo">
		  <h4 class="panel-title">
			<a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
			  <b>Book Publications</b>
			</a>
		  </h4>
		</div>
		<div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
		  <div class="panel-body">
				<asp:DataList ID="DataList2" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Faculty_Name") %>'></asp:Label></b></u><br /></h4>
                
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                
                
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
			  <b>Conference Articles</b>
			</a>
		  </h4>
		</div>
		<div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
		  <div class="panel-body">
		              <asp:DataList ID="DataList3" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Faculty_Name") %>'></asp:Label></b></u><br /></h4>
                
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
		  </div>
		</div>
	 </div>
	 
	   <div class="panel panel-default">
		<div class="panel-heading" role="tab" id="headingFour">
		  <h4 class="panel-title">
			<a class="collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapseFour" aria-expanded="false" aria-controls="collapseThree">
			  <b>Journal Articles</b>
			</a>
		  </h4>
		</div>
		<div id="collapseFour" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingFour">
		  <div class="panel-body">
			    <asp:DataList ID="DataList4" runat="server" RepeatColumns="1" CssClass="table">
            <ItemTemplate>
                <ul>
                    <li>
                <h4><u><b><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Faculty_Name") %>'></asp:Label></b></u><br /></h4>
                
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Details") %>'></asp:Label><br /><br />
                
                
                
                    </ul>
            </ItemTemplate>
        </asp:DataList>
		  </div>
		</div>
	 </div>
	 
	</div>
	<div class="page-header">
		 <h1><u>Students - Achievements</u></h1>
	</div>
	<div class="panel panel-default">
	  <!-- Default panel contents -->
	  <div class="panel-heading">Student's Achievements</div>

	  <!-- Table -->
	  <div class="table-responsive">



          
          <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="False" CellPadding="3" GridLines="Horizontal" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="2px" >  
     <AlternatingRowStyle BackColor="#F7F7F7" />  
     <columns>  
         <asp:TemplateField> 
             <HeaderTemplate >
                <h4><b class="abc">Programme&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></h4>
             </HeaderTemplate> 
             <ItemTemplate>  
                 <asp:Label ID="lblProgramme" runat="server" Text='<%#Eval("Programme") %>'></asp:Label>   &nbsp;&nbsp;
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField>  
             <HeaderTemplate >
                <h4><b class="abc"> Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></h4>
             </HeaderTemplate>
             <ItemTemplate>  
                 <asp:Label ID="LblCategory" runat="server" Text='<%#Eval("Category") %>'></asp:Label>   &nbsp;&nbsp;
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField>  
             <HeaderTemplate >
                <h4><b class="abc">Level&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></h4>
             </HeaderTemplate>
             <ItemTemplate>  
                 <asp:Label ID="LblLevel" runat="server" Text='<%#Eval("Level") %>'></asp:Label>   &nbsp;&nbsp;
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Event"> 
             <HeaderTemplate >
                <h4><b class="abc"> Event&nbsp;</b></h4>
             </HeaderTemplate> 
             <ItemTemplate>  
                 <asp:Label ID="lblEvent" runat="server" Text='<%#Eval("Event") %>'></asp:Label>   &nbsp;&nbsp;
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField>  
             <HeaderTemplate >
                <h4><b class="abc">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></h4>
             </HeaderTemplate>
             <ItemTemplate>  
                 <asp:Label ID="Lblname" runat="server" Text='<%#Eval("Name_of_students") %>'></asp:Label> &nbsp;&nbsp;  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField>  
             <HeaderTemplate >
                <h4><b class="abc">&nbsp;&nbsp;&nbsp; Rank&nbsp;&nbsp;&nbsp;</b></h4>
             </HeaderTemplate>
             <ItemTemplate>  
                 <asp:Label ID="LblRank" runat="server" Text='<%#Eval("Rank")  %>' ></asp:Label> &nbsp;&nbsp; 
             </ItemTemplate>  
         </asp:TemplateField>  
     </columns>  
     <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />  
     <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />  
     <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />  
     <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />  
     <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />  
     <SortedAscendingCellStyle BackColor="#F4F4FD" />  
     <SortedAscendingHeaderStyle BackColor="#5A4C9D" />  
     <SortedDescendingCellStyle BackColor="#D8D8F0" />  
     <SortedDescendingHeaderStyle BackColor="#3E3277" />  
 </asp:GridView>  
          
	  
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
  
    </div>
    </form>
</body>
</html>
