 <%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Test.aspx.vb" Inherits="LifeIncentives.Test" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="btnPc" OnClick="btnPc_Click"  runat="server" data-toggle="modal" data-target="myModal">
                 <img class="vector-4Ap" src="Dimg/plusSign2.png" id="407:1648" /> 
                <%--correct plus sign--%>
            </asp:LinkButton>
              <%--<asp:LinkButton ID="btnPIncParent" OnClick="btnPIncreseParent_Click" runat="server" data-toggle="modal" data-target="#myModal"> 
                                </asp:LinkButton>--%>
                        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="myModalLabel">Increase Parent Incentive</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- Textbox inside the modal -->
                                        <%--<asp:TextBox ID="TextBoxInput" runat="server" CssClass="form-control"></asp:TextBox>--%>
                                        <asp:TextBox ID="txtPIncParent" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="modal-footer">
                                        <!-- Submit button inside the modal -->
                                        <asp:Button ID="btnS" OnClick="btnS_Click" runat="server"  Text="submit" /> 
                                        <%--<asp:Button ID="btnSubPinc" OnClick="btnSubPinc_Click1" runat="server" Text="Submit" />--%>
                                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                         </div>
        </div>
    </form>
      <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
      <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <script>
        // Function to handle submission of text
        function submitText() {
            var text = document.getElementById("textInput").value;
            // You can perform further actions with the submitted text here
            console.log("Submitted Text:", text);
            // Close the modal
            $('#myModal').modal('hide');
        }
    </script>
</body>
</html>
