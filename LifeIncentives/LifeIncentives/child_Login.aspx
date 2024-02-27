<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="child_Login.aspx.vb" Inherits="LifeIncentives.child_Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="bootstrap-5.3.2-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/StyleSheet1.css" rel="stylesheet"  />
    <link href="css/DashboardStyle.css" rel="stylesheet" />
    <%--fontawesome--%>
    <link href="fontawesome-free-6.4.2-web/css/all.css" rel="stylesheet" />

    <%--Google fonts--%>

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Frank+Ruhl+Libre&display=swap" rel="stylesheet">
    <link rel = "stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Fraunces:opsz@9..144&display=swap" rel="stylesheet">
       <link rel = "stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

    <%--Google fonts--%>

     <!-- Favicons -->
  <link href="assets/img/favicon.png" rel="icon">
  <link href="assets/img/apple-touch-icon.png" rel="apple-touch-icon">

  <!-- Google Fonts -->
  <link href="https://fonts.gstatic.com" rel="preconnect">
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Nunito:300,300i,400,400i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

  <!-- Vendor CSS Files -->
  <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <link href="assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
  <link href="assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
  <link href="assets/vendor/quill/quill.snow.css" rel="stylesheet">
  <link href="assets/vendor/quill/quill.bubble.css" rel="stylesheet">
  <link href="assets/vendor/remixicon/remixicon.css" rel="stylesheet">
  <link href="assets/vendor/simple-datatables/style.css" rel="stylesheet">

  <!-- Template Main CSS File -->
  <link href="assets/css/style.css" rel="stylesheet">

</head>
<body>
    <form id="form1" runat="server">
        <div>

                <div>
        <div class="container-fluid ">
            <div class="row">
                <div class="col-md-10 mx-auto">
                    <div class="card">
                        <div class="card-body">
                             

                            <div class="row">
                                <div class="col-md-6">
                                    <img src="Images/C-Signup.png" class="img-intro"/>
                                </div>
                                <div class="col-md-6">
                                    <center>
                                        <h1 class="text-wel text-space">Welcome</h1>
                                    </center>
                                    <center>
                                        <h1 class="text-wel text-In">To</h1>
                                    </center>
                                    <center>
                                        <div class="row">
                                             <h1 class="text-wel text-space">Child<span class="text-In">Login</span></h1>
                                        </div>
                                      <div class="row">
                                            <div class="col-md-12">
                                                <asp:Label ID="lblUsername" runat="server" Text="Username"><span class="lbl-text">Enter Your Name</span></asp:Label>
                                                <div class="form-group">
                                                    <asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                       <div class="row">
                                            <div class="col-md-12">
                                                <asp:Label ID="lblCode" runat="server" Text="lblCode"><span class="lbl-text">Child Id Number</span></asp:Label>
                                                <div class="form-group">
                                                    <asp:TextBox class="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </center>
                                    <center>
                                        <div class="btn-space">
                                            <div class="button-container">
                                                <asp:Button ID="btnChildLogin" runat="server" Text="Login" CssClass="btn1 btn-curve btntxt-space" Height="50px" Width="220px" />
                                                <asp:Button ID="btnParentLogin" runat="server" Text="Parent" CssClass=" btn2 btn-curve" Height="50px" Width="145px"/>
                                            </div>
                                        </div>
                                    </center>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

        </div>
    </form>
    <script src="bootstrap-5.3.2-dist/js/bootstrap.bundle.js"></script>
    <script src="bootstrap-5.3.2-dist/js/bootstrap.min.js"></script>
</body>
</html>
