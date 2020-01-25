<%@ Page validateRequest="false" enableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="ConvEminentVisitors.aspx.cs" Inherits="ConvEminentVisitors" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
    <title>Eminent Visitors</title>
    <meta name="description" content="GotYa Free Bootstrap Theme" />
    <meta name="keywords" content="Template, Theme, web, html5, css3, Bootstrap" />
    <meta name="author" content="Łukasz Holeczek from creativeLabs" />
    <!-- end: Meta -->

    <!-- start: Mobile Specific -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <!-- end: Mobile Specific -->

    <!-- start: Facebook Open Graph -->
    <meta property="og:title" content="" />
    <meta property="og:description" content="" />
    <meta property="og:type" content="" />
    <meta property="og:url" content="" />
    <meta property="og:image" content="" />
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
        .edit 
        {
            font-family:sans-serif;
            font-size:larger;
        }
        .edit1
        {
            font-family:sans-serif;
            font-size:x-large;
        }
    </style>

    <script type="text/javascript">
        function checkDate(sender, args) {

            //Check if the date selected is less than todays date
            if (sender._selectedDate > new Date()) {
                //show the alert message
                alert("You cannot select this date!");
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
			              			<li><a href="ConvAchievements.aspx">Achievements</a></li>
									<li><a href="ConvCollNet.aspx">Collabration & Networking</a></li>
									<li class="active"><a href="ConvEminentVisitors.aspx">Eminent Visitors</a></li>
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

            <div align="center">
                <div class="page-header">
                    <h1><u>EmnientVisitors</u></h1>
                </div>
                    <div style="margin-left:100px;">
                        </div>
                          <h2><u>Insert a new record</u></h2>
                

                <ul>
                    <li>
                        <asp:Label ID="Label1" runat="server" Text="Select a Photo : "></asp:Label>
                        &nbsp<asp:FileUpload ID="FileUpload1" runat="server" />
                       
                    </li>
                    <br />
                    <li>
                        <asp:Label ID="Label2" runat="server" Text="Name of Visitor : "></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Dr.</asp:ListItem>
                            <asp:ListItem>Prof.</asp:ListItem>
                            <asp:ListItem>Mr.</asp:ListItem>
                            <asp:ListItem>Mrs.</asp:ListItem>
                            <asp:ListItem>Miss.</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="txtVisitorName" runat="server" PlaceHolder="Full Name"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="LblFU" runat="server" Text="" ForeColor="Red"></asp:Label>
                        

                    </li>
                    <li>
                        <asp:Label ID="Label3" runat="server" Text="Date of visit :"></asp:Label>
                        <asp:TextBox ID="txtDate" runat="server" ></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" OnClientDateSelectionChanged="checkDate" TargetControlID="txtDate" />
                        
                    </li>
                    <li>
                        <asp:Label ID="Label5" runat="server" Text="Description : "></asp:Label>
                        
                        &nbsp;<asp:TextBox ID="txtDes" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                        
                    </li>
                    <li>
                        <asp:Button ID="ButtonUpload" runat="server" Text="Upload" OnClick="ButtonUpload_Click" />

                        </li>
                    
                </ul>
            </div>

                        <br />
                        <br />
        
        

        

        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" CssClass="table" GridLines="Horizontal" OnItemCommand="DataList1_ItemCommand">
            <ItemTemplate>
                <u><b class="edit1"><asp:Label ID="LabelName" runat="server" Text='<%# Eval("Visitor_Name") %>'></asp:Label><br /></b></u><br />

                <b class="edit"><asp:Image ID="Image1" runat="server" ImageUrl='<%# ("~/") + path + Eval("Img") %>' Height="250" Width="250"/><br /><br />

                <asp:Label ID="LabelDate" runat="server" Text='<%# Eval("Date") %>'></asp:Label><br />
        
                <asp:Label ID="LabelDetails" runat="server" Text='<%# Eval("Visitor_details") %>'></asp:Label><br />
                <asp:Label ID="Label4" runat="server" Text="Inserted By: "></asp:Label>
                <asp:Label ID="Label6" runat="server" Text='<%# Eval("username") %>'></asp:Label><br />
                

                <br /></b>
                <asp:Button ID="Button1" runat="server" Text="Delete Record" CommandName="Delete" CommandArgument='<%#Eval("Visitor_id") %>'/>
            </ItemTemplate>
            <FooterTemplate>
                
            </FooterTemplate>
        </asp:DataList>
    </div>

                

               
            </div>




            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

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
