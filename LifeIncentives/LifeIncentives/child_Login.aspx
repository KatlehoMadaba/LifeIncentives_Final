<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="child_Login.aspx.vb" Inherits="LifeIncentives.child_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>


    <title>Child Login</title>

    <!-- Custom fonts for this template-->
    <link href="Login%20and%20Sign%20Up%20assets/vendor/fontawesome-free/css/all.min.css" rel="stylesheet"  type="text/css"/>
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>

    <!-- Custom styles for this template-->
    <link href="Login%20and%20Sign%20Up%20assets/css/sb-admin-2.min.css" rel="stylesheet" /></head>
  <body style="background:linear-gradient(45deg,#002316,white)">
    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Welcome Back Child!</h1>
                                    </div>
                                    <form id="LoginForm" runat="server">
                                        <div>
                                            <label for="EmailTextBox">Child Name:</label>
                                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control form-control-user" placeholder="Child Name"></asp:TextBox>
                                        </div>
                                        <div>
                                            <label for="PasswordTextBox">Password:</label>
                                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control form-control-user" placeholder="Password"></asp:TextBox>
                                        </div>
                                        <div>
                                            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="Login_Click" CssClass="btn btn-primary btn-user btn-block" style="background-color:#0D986A"/>
                                        </div>
                                        <div>
                                            <asp:Label ID="Message" Visible="false" runat="server" Text="" ForeColor="Red"></asp:Label>
                                        </div>
                                    </form>
                                    <div class="text-center">
                                        <a class="small" href="ForgotPassword.aspx">Forgot Password?</a>
                                    </div>
                                    <div class="text-center">
                                        <a class="small" href="signUp.aspx">Create an Account!</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>
  
    <!-- Bootstrap core JavaScript-->
    <script src="Login%20and%20Sign%20Up%20assets/vendor/jquery/jquery.min.js"></script>
    <script src="Login%20and%20Sign%20Up%20assets/vendor/bootstrap/js/bootstrap.bundle.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="Login%20and%20Sign%20Up%20assets/vendor/jquery-easing/jquery.easing.min.js"></script>
    <!-- Custom scripts for all pages-->
    <script src="Login%20and%20Sign%20Up%20assets/js/sb-admin-2.min.js"></script>
  </body>  

</html>
