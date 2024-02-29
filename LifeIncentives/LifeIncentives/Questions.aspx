<%@ Page Language="vb" MaintainScrollPositionOnPostBack="true" AutoEventWireup="false" CodeBehind="Questions.aspx.vb" Inherits="LifeIncentives.Questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="canonical" href="https://getbootstrap.com/docs/5.0/examples/sidebars"/>

    <!-- Bootstrap core CSS -->
    <link href="/docs/5.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>

    <!-- Favicons -->
    <link rel="apple-touch-icon" href="/docs/5.0/assets/img/favicons/apple-touch-icon.png" sizes="180x180"/>
    <link rel="icon" href="/docs/5.0/assets/img/favicons/favicon-32x32.png" sizes="32x32" type="image/png"/>
    <link rel="icon" href="/docs/5.0/assets/img/favicons/favicon-16x16.png" sizes="16x16" type="image/png"/>
    <link rel="manifest" href="/docs/5.0/assets/img/favicons/manifest.json"/>
    <link rel="mask-icon" href="/docs/5.0/assets/img/favicons/safari-pinned-tab.svg" color="#7952b3"/>
    <link rel="icon" href="/docs/5.0/assets/img/favicons/favicon.ico"/>
    <meta name="theme-color" content="#7952b3"/>

    <!-- Custom styles for this template-->
    <link href="I_css/sb-admin-2.min.css" rel="stylesheet"/>


</head>
<body>
    <!-- improve the styling of this page -->
    <form id="form1" runat="server">
    <div>
        <div class="container-fluid ">
            <div class="row">
                <div class="col-md-10 mx-auto">
                    <div class="card" style="border-radius: 25px; border: 2px solid #002316;color:darkblue;">
                        <div class="card-body" >
                            <div class="row">

                                <div class="col-md-6">
                                    <center>
                                        <h1 class="text-w">Please Answer a few more questions....</h1>
                                    </center>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">What type of school does your child go to:</label>
                                            <div class="form-group">
                                                <asp:RadioButtonList ID="RadioButtonList6" runat="server">
                                                     <asp:ListItem Text="School" Value="School">School</asp:ListItem>
                                                         <asp:ListItem Text="Tertiary" Value="Tertiary">Tertiary</asp:ListItem>
                                                </asp:RadioButtonList>                                              
                                            </div>
                                        </div>
                                    </div>
                                      <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">What type of school does your child go to:</label>
                                            <div class="form-group">
                                                <asp:RadioButtonList ID="RadioButtonList12" runat="server">
                                                    <asp:ListItem Text="Public" Value="Public">Public</asp:ListItem>
                                                         <asp:ListItem Text="Private" Value="Private">Private</asp:ListItem>
                                                </asp:RadioButtonList>              
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                                <label class="lbl-text">Do you pay for school fees(extra murals included)</label>
                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged1">
                                                    <asp:ListItem Text="fees" Value="Yes">Yes</asp:ListItem>
                                                    <asp:ListItem Text="Nofees" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>
                                                <div id="PayFees" runat="server" visible="false">
                                                    <div class="row">
                                                        <div class="col-md-12">
                                                            <label class="lbl-text">How much is the school fees per year</label>
                                                            <div class="form-group">
                                                                <asp:TextBox class="form-control" ID="TextBox6" runat="server" TextMode="SingleLine">
                                                                </asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
<%--                                        <div id="Funding" runat="server" visible="false">
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <label class="lbl-text">What is your funding system</label>
                                                    <div class="form-group">
                                                        <asp:RadioButtonList ID="RadioButtonList7" runat="server">
                                                         <asp:ListItem Text="Bursary" Value="Bursary"></asp:ListItem>
                                                         <asp:ListItem Text="Goverment" Value="Goverment"></asp:ListItem>
                                                        </asp:RadioButtonList>                                                                        
                                                    </div>
                                                </div>
                                            </div>
                                        </div>--%>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">Do you pay for stationery(books,pens,etc)</label>
                                            <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged1">
                                                  <asp:ListItem Text="stationary" Value="Yes">Yes</asp:ListItem>
                                                <asp:ListItem Text="NoStationary" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>                                             
                                            <div id="Stationary" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much is stationary per year</label>
                                                        <div class="form-group">
                                                            <asp:TextBox class="form-control" ID="TextBox7" runat="server" TextMode="SingleLine">
                                                           </asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">Do you give an allowance</label>
                                            <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList4_SelectedIndexChanged">
                                                  <asp:ListItem Text="Allowance" Value="Yes">Yes</asp:ListItem>
                                                <asp:ListItem Text="NoAllowance" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>                                  
                                            <div id="allowance" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much is per year</label>
                                                        <div class="form-group">
                                                            <asp:TextBox class="form-control" ID="TextBox8" runat="server" TextMode="SingleLine">
                                                            </asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">Do you pay for transport</label>
                                            <asp:RadioButtonList ID="RadioButtonList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList5_SelectedIndexChanged1">
                                                <asp:ListItem Text="Transport" Value="Yes">Yes</asp:ListItem>
                                                <asp:ListItem Text="NoTransport" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>            
                                            <div id="Transport" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much do you pay for transport yearly</label>
                                                        <div class="form-group">
                                                            <asp:TextBox class="form-control" ID="TextBox9" runat="server" TextMode="SingleLine">
                                                            </asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                   <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">Do you pay for accomodation?</label>
                                            <asp:RadioButtonList ID="RadioButtonList13" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList13_SelectedIndexChanged1">
                                                  <asp:listitem text= "accommodtion" value="Yes">Yes</asp:listitem>
                                                <asp:listitem text="noaccommodtion" value="No">No</asp:listitem>
                                            </asp:RadioButtonList>              
                                            <div id="accommodtion" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much do you pay for accomadation yearly</label>
                                                        <div class="form-group">
                                                            <asp:TextBox ID="TextBox10" runat="server" TextMode="SingleLine"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div>
        <div class="container-fluid ">
            <div class="row">
                <div class="col-md-10 mx-auto">
                    <div class="card" style="border-radius: 25px; border: 2px solid #002316;color:darkblue;">
                        <div class="card-body">
                            <div class="row">

                                <div class="col-md-6">
                                     <center>
                                        <h1 class="text-w">Additional Expenses </h1>
                                    </center>
                                       <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">Do you pay for any additional memberships for you child?(e.g gym memberships)</label>
                                            <asp:RadioButtonList ID="RadioButtonList8" runat="server" TextMode="SingleLine" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList8_SelectedIndexChanged" >
                                                  <asp:ListItem Text="memberships" Value="Yes">Yes</asp:ListItem>
                                                <asp:ListItem Text="Nomemberships" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>
                                            <div id="memberships" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much do you pay for memberships yearly</label>
                                                        <div class="form-group">
                                                            <asp:TextBox class="form-control" ID="TextBox11" runat="server" TextMode="SingleLine">
                                                            </asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                       <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">Do you pay for external classes</label>
                                            <asp:RadioButtonList ID="RadioButtonList9" runat="server" TextMode="SingleLine" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList9_SelectedIndexChanged" >
                                                <asp:ListItem Text="Classes" Value="Yes">Yes</asp:ListItem>
                                                <asp:ListItem Text="Noclasses" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>
                                            <div id="classes" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much do you pay for external classes yearly</label>
                                                        <div class="form-group">
                                                            <asp:TextBox class="form-control" ID="TextBox12" runat="server" TextMode="SingleLine">
                                                            </asp:TextBox>
                                                        </div>
                                                        
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                      <div class="row"> 
                                        <div class="col-md-12">
                                            <label class="lbl-text">Woud you like to include the gadgets you buy your child in the incentives?
                                            </label>
                                            <asp:RadioButtonList ID="RadioButtonList10" runat="server" TextMode="SingleLine" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList10_SelectedIndexChanged">
                                                  <asp:ListItem Text="Gadgets" Value="Yes">Yes</asp:ListItem>
                                                <asp:ListItem Text="Nogadgets" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>
                                            <div id="gadgets" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much do you spend on the gadgets yearly</label>
                                                        <div class="form-group">
                                                            <asp:TextBox class="form-control" ID="TextBox13" runat="server" TextMode="SingleLine">
                                                            </asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                   </div>
                                </div>
                                     <div class="row">
                                        <div class="col-md-12">
                                            <label class="lbl-text">Would You like to include money for celebrations in the incentives?</label>
                                            <asp:RadioButtonList ID="RadioButtonList11" runat="server" TextMode="SingleLine" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList11_SelectedIndexChanged">
                                                <asp:ListItem Text="Celebrations" Value="Yes">Yes</asp:ListItem>
                                                <asp:ListItem Text="Nocelebrations" Value="No">No</asp:ListItem>
                                            </asp:RadioButtonList>   
                                            <div id="celebrations" runat="server" visible="false">
                                                <div class="row">
                                                    <div class="col-md-12">
                                                        <label class="lbl-text">How much do you spend on celebrations yearly</label>
                                                        <div class="form-group">
                                                            <asp:TextBox  class="form-control" ID="TextBox14" runat="server" TextMode="SingleLine"></asp:TextBox>
                                                        </div>
                                                    </div>
                                              </div>
                                       </div>
                                 </div>
                            </div>
                                <center>
                                                    <div class="button-container">
                                                                <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="SubmitClick" style="background-color:transparent;color:#0D986A ;border-radius: 25px; border: 2px solid #cda45e;"/>                             
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
    </form>
</body>
</html>
