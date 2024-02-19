<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="landingPage.aspx.vb" Inherits="LifeIncentives.landingPage" %>





<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-10 mx-auto">
                        <div class="card card-curve">
                            <div class="row">
                                <div class="col-md-6">
                                    <img src="T-Images/Landing%20Page.png" class="img-intro" />
                                </div>
                                <div class="col-md-6">
                                    <center>
                                        <h1 class="text-wel">Welcome</h1>
                                        <h1 class="text-to text-space">To</h1>
                                        <h1 class="text-space"><span class="text-Life">Life</span><span class="text-Inc">Incentives</span></h1>
                                        <div class="btn-space">
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
