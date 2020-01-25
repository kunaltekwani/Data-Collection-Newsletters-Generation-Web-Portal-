<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EminentVisitors.aspx.cs" Inherits="ShowVisitors" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
    <script type="text/javascript">
        function checkDate(sender, args) {

            //Check if the date selected is less than todays date
            if (sender._selectedDate > new Date()) {
                //show the alert message
                alert("You cannot select future date!");
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
                                            <li class="active"><a href="EminentVisitors.aspx">Eminent Visitors</a></li>
                                            <li><a href="Testimonials.aspx">Testimonials</a></li>
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
                    <h1><u>Add Emnient Visitors</u></h1>
                </div>
                
                

                <ul>
                    <li>
                        <asp:Label ID="Label1" runat="server" Text="Select a Photo : "></asp:Label>
                        &nbsp<asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator>
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
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="txtVisitorName"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" ErrorMessage="Enter String only" ControlToValidate="txtVisitorName" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>

                    </li>
                    <li>
                        <asp:Label ID="Label3" runat="server" Text="Date of visit :"></asp:Label>
                        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtDate" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="txtDate"></asp:RequiredFieldValidator>
                    </li>
                    <li>
                        <asp:Label ID="Label5" runat="server" Text="Description : "></asp:Label>
                        
                        &nbsp;<asp:TextBox ID="txtDes" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage = "*" ForeColor="Red" ControlToValidate="txtDes"></asp:RequiredFieldValidator>
                        
                    </li>
                    <li>
                        <asp:Button ID="ButtonUpload" runat="server" Text="Upload" OnClick="ButtonUpload_Click" />

                        </li>
                    
                </ul>
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
<a href="EminentVisitors.aspx">EminentVisitors.aspx</a>
</html>
