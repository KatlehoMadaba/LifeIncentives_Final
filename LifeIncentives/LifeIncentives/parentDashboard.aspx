<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="parentDashboard.aspx.vb" Inherits="LifeIncentives.parentDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <link href="Dcss/parentDashboard.css" rel="stylesheet"/>
      <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <!-- Button to open the modal -->
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">
                Open Modal
            </button>

            <!-- Modal -->
            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="myModalLabel">Modal Title</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <!-- Textbox inside the modal -->
                            <asp:TextBox ID="TextBoxInput" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="modal-footer">
                            <!-- Submit button inside the modal -->
                      
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
>

           
</asp:Content>
