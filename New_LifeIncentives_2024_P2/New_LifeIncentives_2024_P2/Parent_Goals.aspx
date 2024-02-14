<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Parent_Goals.aspx.vb" Inherits="New_LifeIncentives_2024_P2.Parent_Goals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SB Admin 2 - Charts</title>

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">




<style>

    .setGoalsCard, .recommend {
        height: 100%;
        border-radius: 20px;
        overflow: hidden;
        transition: transform 0.3s;
        margin-top: 10px;
        margin-left: 10px;

        background-color: rgba(255, 255, 255, 0.9); /* Adjust the alpha value for transparency */
        border: 1px solid rgba(255, 255, 255, 0.5);
        padding: 15px;
    }



    .lbl-text {
    font-weight: bold;
    display: block;
    margin-bottom: 5px;
    }


    .recommend-container {
        max-height: 500px;
        max-width: 100%;
        overflow-y: auto;
        max-width: auto;
        margin-left: auto;
        margin-right: auto;
    }

    .goals-container {
    max-height: 300px;
    overflow-y: auto;
    max-width: auto;
    margin-left: auto;
    margin-right: auto;
    }

    .btn{
        background-color:#013220;
        color:white;
    }

    .btn:hover{
        background-color:#0D986A;
        color:white;
    }

    .lbl-text{
        font-family: Quicksand, 'Source Sans Pro';
        font-size:20px; 
        color:#013220;
    }


</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="bg-white" style="font-family: Quicksand, 'Source Sans Pro';font-size:50px; font-weight:700;">
            <center>
                <div style="display:inline-flex">
                    <div style="color:#013220">Set</div>
                    <div style="color:#0D986A;margin-left:10px">Goals</div>
                </div>
                <img style="height:50px" src="I_img/SetGoals.png" />                
            </center>
        </div>
 
                    <!-- Set Goals Section -->
         
                                <div style="display:inline-flex">
                                        <div style="max-width:800px">
                                                <div class="setGoalsCard">
                                                        <div class="text-center">
                                                            <h1 class="text-welcome" style="color:#0D986A;font-family:Quicksand,'Source Sans Pro';font-weight:bolder;">Goals</h1>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-6">
                                                                <asp:Label ID="Label2" runat="server" Text="Category" CssClass="lbl-text"></asp:Label>
                                                                <div class="form-group">
                                                                    <asp:TextBox CssClass="form-control" ID="txtCat" runat="server"></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-6">
                                                                <asp:Label ID="Label6" runat="server" Text="Description" CssClass="lbl-text"></asp:Label>
                                                                <div class="form-group">
                                                                    <asp:TextBox CssClass="form-control" ID="txtDes" runat="server"></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-6">
                                                                <asp:Label ID="Label7" runat="server" Text="Amount" CssClass="lbl-text"></asp:Label>
                                                                <div class="form-group">
                                                                    <asp:TextBox CssClass="form-control" ID="txtPrice" runat="server"></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-6">
                                                                <asp:Label ID="Label3" runat="server" Text="No. Days" CssClass="lbl-text"></asp:Label>
                                                                <div class="form-group">
                                                                    <asp:TextBox CssClass="form-control" ID="txtDays" runat="server"></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-6 text-center" style="font-size:18px; font-weight:bold;color:#007BFF">
                                                                <asp:Label ID="lblTotalAmount" runat="server" 
                                                                    style="font-size:30px;font-family:Quicksand,'Source Sans Pro';color:#013220" />
                                                            </div>
                                                            <div class="col-md-2 text-center">
                                                                <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="Add" />
                                                            </div>
                                                            <div class="col-md-2 text-center">
                                                                <asp:Button ID="Button2" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Submit" />
                                                            </div>
                                                        </div>
                                                        <div class="goals-container table-responsive" style="margin-top:10px">
                                                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Description" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-striped">
                                                            <HeaderStyle CssClass="thead-light" />
                                                            <Columns>
                                                                <asp:BoundField DataField="StartDateTime" HeaderText="Start Date Time" SortExpression="StartDateTime" ItemStyle-CssClass="align-middle" />
                                                                <asp:BoundField DataField="EndDateTime" HeaderText="End Date Time" SortExpression="EndDateTime" ItemStyle-CssClass="align-middle" />
                                                                <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" ItemStyle-CssClass="align-middle" />
                                                                <asp:BoundField DataField="Description" HeaderText="Task" SortExpression="Description" ItemStyle-CssClass="align-middle" />
                                                                <asp:BoundField DataField="TimePeriod" HeaderText="Days" SortExpression="TimePeriod" ItemStyle-CssClass="align-middle" DataFormatString="{0} days" />
                                                                <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" ItemStyle-CssClass="align-middle" />
                                                                <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass="btn btn-sm" />
                                                            </Columns>
                                                            </asp:GridView>

                                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conn2 %>"
                                                                SelectCommand="SELECT [StartDateTime], [EndDateTime], [Category], [Description], [TimePeriod], [Amount], [Status] FROM [TBL_Set_Goals] WHERE [Status] = @Status"
                                                                DeleteCommand="DELETE FROM [TBL_Set_Goals] WHERE [Description] = @Description">
                                                                <SelectParameters>
                                                                    <asp:Parameter Name="Status" Type="String" DefaultValue="Selected" />
                                                                </SelectParameters>
                                                                <DeleteParameters>
                                                                    <asp:Parameter Name="Description" Type="String" />
                                                                </DeleteParameters>
                                                            </asp:SqlDataSource>

                                                        </div>                                          
                                                </div>
                                     
                                        </div>
                                  
                                        <div style="max-width:100%">
                                                <!-- Recommendations Section -->
                                                <div class="recommend">
                                                        <h1 style="text-align:center;color:#0D986A;font-family: Quicksand,'Source Sans Pro';font-weight:bolder;" class="text-welcome">Recommendations</h1>
                                                        <div class="form-group">
                                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Search" oninput="searchGridView();"></asp:TextBox>
                                                        </div>

                                                        <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
                                                        <script>
                                                            $(document).ready(function () {
                                                                // Search function
                                                                $('#<%= TextBox1.ClientID %>').on('input', function () {
                                                                    var searchText = $(this).val().toLowerCase();
                                                                    $('#<%= GridView2.ClientID %> tr:gt(0)').each(function () {
                                                                        var rowData = $(this).text().toLowerCase();
                                                                        $(this).toggle(rowData.includes(searchText));
                                                                    });
                                                                });
                                                            });
                                                        </script>

                                                        <div class="recommend-container table-responsive">
                                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CssClass="table table-bordered table-striped">
                                                                <HeaderStyle CssClass="thead-light" />
                                                                <Columns>
                                                                    <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" ItemStyle-CssClass="align-middle" />
                                                                    <asp:BoundField DataField="Task" HeaderText="Task" SortExpression="Task" ItemStyle-CssClass="align-middle" />
                                                                    <asp:BoundField DataField="Default_Price" HeaderText="Amount (R)" SortExpression="Task" ItemStyle-CssClass="align-middle"/>
                                                                    <asp:BoundField DataField="Default_Time" HeaderText="Days" SortExpression="Category" ItemStyle-CssClass="align-middle"/>
                                                                    <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass="btn btn-sm" />
                                                                </Columns>
                                                            </asp:GridView>
                                                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:conn2 %>" SelectCommand="SELECT [Category], [Task], [Default_Price], [Default_Time] FROM [TBL_Recommendations]"></asp:SqlDataSource>
                                                        </div>

                                                </div>
                                       
                                        </div>
                                  
                                </div>
                           
</asp:Content>
