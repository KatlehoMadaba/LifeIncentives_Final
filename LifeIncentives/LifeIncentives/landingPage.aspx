<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="landingPage.aspx.vb" Inherits="LifeIncentives.landingPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>

        
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>


    <title>SB Admin 2 - Landing page</title>

    <!-- Custom fonts for this template-->
    <link href="Login%20and%20Sign%20Up%20assets/vendor/fontawesome-free/css/all.min.css" rel="stylesheet"  type="text/css"/>
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>

    <!-- Custom styles for this template-->
    <link href="Login%20and%20Sign%20Up%20assets/css/sb-admin-2.min.css" rel="stylesheet" />
</head>
<body  style="background-color:#002316">
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-10 mx-auto">
                        <div class="card card-curve">
                            <div class="row">
                                <div class="col-md-6">
                                    <img src="T-Images/Landing%20Page.png" class="img-intro card-img" />
                                </div>
                                <div class="col-md-6">
                                    <center>
                                        <h1 class="text-wel">Welcome</h1>
                                        <h1 class="text-to text-space">To</h1>
                                        <h1 class="text-space"><span class="text-Life">Life</span><span class="text-Inc">Incentives</span></h1>
                                        <div class="btn-space switch">

                                            <div class="button-container">
                                                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn1 btn-curve btntxt-space" Height="50px" Width="220px" />
                                                <asp:Button ID="SignupButton" runat="server" Text="Signup" CssClass="btn2 btn-curve" Height="50px" Width="145px" />

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
    </form>
</body>
</html>
