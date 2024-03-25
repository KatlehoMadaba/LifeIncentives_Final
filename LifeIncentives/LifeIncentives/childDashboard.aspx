<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="childDashboard.aspx.vb" Inherits="LifeIncentives.childDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <img class="rectangle-508-5BJ" src="Dimg/" id="407:1681" />
        <div class="group-20127-nbW" id="407:1682">
            <div class="group-20125-WnQ" id="407:1683">
                <div class="group-20118-FV6" id="407:1684">
                    <p class="parent-incentives-9qN" id="407:1691">Parent Incentives</p>
                    <div class="auto-group-dr1n-3fr" id="AX3e7JhoCx88YWkojDDR1N">
                        <div class="progress-background-nNY" id="407:1692">
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" strole="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 70%; background-color:deeppink" hi>70%</div>
                            </div>
                            </div>
                        <p class="r50-6PE" id="407:1693">R<asp:Label ID="lbParentAmount" runat="server" Text="50"></asp:Label></p>
                        <%--<img class="group-zDi" src="Dimg/parentIcon.png" id="407:1694" />--%>
                            <asp:LinkButton ID="btnIncParent" runat="server" OnClick="btnIncParent_Click" data-toggle="modal" data-target="#myModal">
                                <img src="Dimg/plusSign2.png" id="416:1419"  class="vector-8ap"/>
                            </asp:LinkButton>
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
                            <asp:TextBox ID="txtIncParent" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="modal-footer">
                            <!-- Submit button inside the modal -->
                                <asp:Button ID="btnsubPInc" runat="server" OnClick="btnsubPInc_Click" Text="Send"/>
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
                         </div>
                        <asp:LinkButton ID="btnDecParent" runat="server" OnClick="btnDecParent_Click" data-toggle="modal" data-target="#myModal2">
                                  <img class="vector-fqe" src="Dimg/minusSign2.png" id="416:1420" />
                        </asp:LinkButton>
                         <div class="modal fade" id="myModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Enter Decrease Parent Incentive Amount</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <!-- Input box -->
                     <%--   <input type="text" id="textInput" class="form-control" placeholder="Enter text">--%>
                        <asp:TextBox ID="txtDecParent" runat="server"></asp:TextBox>
                    </div>
                    <div class="modal-footer">
                        <!-- Submit button -->
                         <asp:Button ID="btnsubPDec" runat="server" OnClick="btnsubPDec_Click" Text="submit"/>
                        <%--<button type="button" class="btn btn-primary" onclick="submitText()">Submit</button>--%>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
                    </div>
                </div>
            </div>
            <img class="icon-box-7Br" src="Dimg/parentIcon.png" id="407:1686" />
        </div>
        <asp:LinkButton ID="btnSendRequest" runat="server" OnClick="btnSendRequest_Click" CssClass="set-daily-goals-EXN">
             <img class="game-icons-achievement-q1N" src="Dimg/medalGoals.png" id="I407:1715;155:2003" />
                <div class="auto-group-aqtt-h3a" id="AX3eSJA9uaPmpeHCDGaQtt">
                <p class="set-daily-goals-DGp" id="I407:1715;155:2001">
                    View Your Goals
                    <br />
                </p>
            </div>
        </asp:LinkButton>
  <%--      <div class="set-daily-goals-EXN" id="I407:1715;155:1825">--%>
            <%--<div class="auto-group-zrma-7r4" id="AX3eNdbbRPKjiUgqbKzrMa">--%>
               
            <%--</div>--%>
        
     <%--   </div>--%>
                <asp:LinkButton ID="btnViewRequests" runat="server" OnClick="btnViewRequests_Click" CssClass="set-daily-goals-6Lc">
                      <img class="auto-group-33gx-njE" src="Dimg/approvedTick.png" id="AX3ehsYXyPSRmr3hr233gx" />
            <div class="auto-group-ec44-7Wc" id="AX3eo7tnrJCS9rbm1JEC44">
                <p class="set-daily-goals-djr" id="I407:1718;155:2001">View Requests</p>
            </div>

                </asp:LinkButton>
        <p class="your-yearly-goal-j2C" id="407:1722">
            Your Yearly Goal

            <br />
        </p>
        <div class="steps-21J" id="407:1723">
          <%--  <img class="tdesign-money-wPA" src="Dimg" id="407:1724" />
            <img class="ellipse-23-fKA" src="Dimg" id="407:1727" />
            <img class="ellipse-25-zcL" src="Dimg" id="407:1728" />
            <img class="ellipse-24-LRJ" src="Dimg" id="407:1729" />
            <div class="item-3785-H5e" id="407:1730">3785</div>
            <div class="r3785-AfE" id="407:1731">R3785</div>
            <div class="group-24-fbz" id="407:1732">
                <img class="vector-muv" src="Dimg" id="407:1733" />
                <img class="vector-5vc" src="Dimg" id="407:1734" />--%>
          <%--  </div>--%>
               <div class="container" style="margin-left:7%">
    <div class="row">
        <div class="col-md-3 col-sm-6">
            <div class="progressCircle blue">
                <span class="progressCircle-left">
                  <span class="progressCircle-bar"></span>
                </span>
                <span class="progressCircle-right">
                    <span class="progressCircle-bar"></span>
                </span>
                <div class="progressCircle-value"><asp:Label ID="lbpercentageProgress" runat="server" Text ="90%"></asp:Label></div>
            </div>
        </div>
</div>
        </div>
            </div>
        <div class="welcome-Qhz" id="407:1737">
            <span class="welcome-Qhz-sub-0">Welcome</span>
            <span class="welcome-Qhz-sub-1"></span>
        </div>

        <div class="katleho-A4t" id="407:1738"><asp:Label runat="server" ID="lbChildName" Text="Katleho"/></div>
        <div class="item-123-TJt" id="407:1739"><asp:Label runat="server" ID="lbChildID" Text="1231" /></div>
        <div class="cil-child-MfA" id="407:1765">
            <img class="vector-Sgc" src="Dimg/" id="407:1767" />
        </div>
        <div class="line-8-yAk" id="408:1772"></div>
        <div class="group-20128-6mA" id="416:1370">
            <div class="group-20125-dFJ" id="416:1371">
                <div class="group-20118-Zek" id="416:1372">
                    <p class="parent-incentives-68t" id="416:1381">Goverment Incentives</p>
                    <div class="auto-group-sqme-Pdn" id="AX3fN27dwZD5Wvz8fDsqmE">
                        <div class="progress-background-KGY" id="416:1382">
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" strole="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 70%; background-color: orange">70%</div>
                            </div>
                        </div>
                        <p class="r50-qVn" id="416:1383">R<asp:Label ID="govAmount" runat="server" Text="50"></asp:Label></p>
                        <%--<img class="group-LxL" src="Dimg/parentIcon.png" id="416:1384" />--%>
                        <div class="group-Uoe" id="416:1415">
                            <%--             <img class="vector-CzY" src="Dimg/parentIcon.png" id="416:1416" />--%>
                            <asp:LinkButton ID="btnIncGov" runat="server" OnClick="btnIncGov_Click" data-toggle="modal" data-target="#myModal4">
                                   <img class="vector-ue4" src="Dimg/plusSign2.png" id="416:1417" />
                            </asp:LinkButton>
                            <div class="modal fade" id="myModal4" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel2" aria-hidden="true">
                                <div class="modal-dialog" role="document">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h5 class="modal-title" id="exampleModalLabel2">Increase Goverment Amount</h5>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                <span aria-hidden="true">&times;</span>
                                            </button>
                                        </div>
                                        <div class="modal-body">
                                            <!-- Input box -->
                                            <%--<input type="text" id="textInput" class="form-control" placeholder="Enter text">--%>
                                            <asp:TextBox ID="txtGovermnmentAmount" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="modal-footer">
                                            <!-- Submit button -->
                                            <asp:Button ID="btnsubGInc" runat="server" OnClick="btnsubGInc_Click" Text="Submit"/>
                                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <asp:LinkButton ID="btnDecGov" runat="server" OnClick="btnDecGov_Click" data-toggle="modal" data-target="#myModal5">
                            <img class="vector-f7S" src="Dimg/biggerMinus.png" id="416:1418" />
                        </asp:LinkButton>
                        <div class="modal fade" id="myModal5" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel4" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel4">Government Decrease Amount</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- Input box -->
                                 <asp:TextBox ID="txtDecGov" runat="server" ></asp:TextBox>
                                    </div>
                                    <div class="modal-footer">
                                        <!-- Submit button -->
                                       <asp:Button ID="btnsubGDec" runat="server" OnClick="btnsubGDec_Click"  Text="submit"/>
                                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <img class="icon-box-7VE" src="Dimg/govIcon.png" id="416:1409" />
        </div>
</asp:Content>