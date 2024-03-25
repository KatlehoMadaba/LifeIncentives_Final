<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="parentDashboard.aspx.vb" Inherits="LifeIncentives.parentDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                        <p class="r50-6PE" id="407:1693">R<asp:Label ID="lbParentAmount" runat="server"></asp:Label></p>
                        <%--<img class="group-zDi" src="Dimg/parentIcon.png" id="407:1694" />--%>
                        <asp:LinkButton ID="btnIncParent" runat="server" OnClick="btnIncParent_Click" data-toggle="modal" data-target="#myModal">
                               <img src="Dimg/plusSign2.png" id="416:1419"  class="vector-8ap"/>
                        </asp:LinkButton>
                           <%-- <asp:LinkButton ID="btnIncParent" runat="server" OnClick="btnIncParent_Click" data-toggle="modal" data-target="#myModal">
                                <img src="Dimg/plusSign2.png" id="416:1419"  class="vector-8ap"/>
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
                     <%--    <asp:LinkButton ID="btnDecParent" runat="server" OnClick="btnDecParent_Click" data-toggle="modal" data-target="#myModal2">
                                  <img class="vector-fqe" src="Dimg/minusSign2.png" id="416:1420" />
                        </asp:LinkButton>--%>
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
                        <asp:TextBox ID="txtDecParentP" runat="server"></asp:TextBox>
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
    <%--    <asp:LinkButton ID="btnSendRequest" runat="server" OnClick="btnSendRequest_Click" CssClass="set-daily-goals-EXN">
             <img class="game-icons-achievement-q1N" src="Dimg/medalGoals.png" id="I407:1715;155:2003" />
                <div class="auto-group-aqtt-h3a" id="AX3eSJA9uaPmpeHCDGaQtt">
                <p class="set-daily-goals-DGp" id="I407:1715;155:2001">
                    View Your Goals
                    <br />
                </p>
            </div>
        </asp:LinkButton>--%>
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
             <%--   <asp:LinkButton ID="btnViewRequests" runat="server" OnClick="btnViewRequests_Click" CssClass="set-daily-goals-6Lc">
                      <img class="auto-group-33gx-njE" src="Dimg/approvedTick.png" id="AX3ehsYXyPSRmr3hr233gx" />
            <div class="auto-group-ec44-7Wc" id="AX3eo7tnrJCS9rbm1JEC44">
                <p class="set-daily-goals-djr" id="I407:1718;155:2001">View Requests</p>
            </div>

                </asp:LinkButton>--%>
        <p class="your-yearly-goal-j2C" id="407:1722">
            Your Yearly Goal

            <br />
        </p>
        <div class="steps-21J" id="407:1723">
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

        <div class="katleho-A4t" id="407:1738"><asp:Label runat="server" ID="childnameLabel" /></div>
        <div class="item-123-TJt" id="407:1739"><asp:Label runat="server" ID="childIDlb"/></div>
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
                        <p class="r50-qVn" id="416:1383">R<asp:Label ID="govAmountlb" runat="server" Text="50"></asp:Label></p>
                        <%--<img class="group-LxL" src="Dimg/parentIcon.png" id="416:1384" />--%>
                        <div class="group-Uoe" id="416:1415">
                            <%--             <img class="vector-CzY" src="Dimg/parentIcon.png" id="416:1416" />--%>
                            <asp:LinkButton ID="btnIncGov" runat="server" OnClick="btnIncGov_Click" data-toggle="moodal" data-target="#myModal4">
                                <img class="vector-ue4" src="Dimg/plusSign2.png" id="416:1417" />
                            </asp:LinkButton>
                           <%-- <asp:LinkButton ID="btnIncGov" runat="server" OnClick="btnIncGov_Click" data-toggle="modal" data-target="#myModal4">
                                   <img class="vector-ue4" src="Dimg/plusSign2.png" id="416:1417" />
                            </asp:LinkButton>--%>
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
                                            <asp:TextBox ID="txtIncGovP" runat="server"></asp:TextBox>
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
                   <%--     <asp:LinkButton ID="btnDecGov" runat="server" OnClick="btnDecGov_Click" data-toggle="modal" data-target="#myModal5">
                            <img class="vector-f7S" src="Dimg/biggerMinus.png" id="416:1418" />
                        </asp:LinkButton>--%>
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
                                 <asp:TextBox ID="txtDecGovP" runat="server" ></asp:TextBox>
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





      <%--<%--<%--<%--<%--<%--<%--<div class="line-7-YXv" id="406:1455"></div>
            <img class="rectangle-508-sq6" src="Dimg/" id="406:1580" />
            <div class="group-20127-Q4L" id="407:1633">
                <div class="group-20125-XPr" id="407:1634">
                    <div class="group-20118-4eg" id="407:1635">
                        <p class="r50-uQQ" id="407:1645">R<asp:Label ID="lbParentAmount" runat="server"></asp:Label></p>
                        <div class="group-CuJ" id="407:1646">
<%--    <asp:LinkButton ID="btnPIncParent" OnClick="btnPIncreseParent_Click" runat="server" data-toggle="modal" data-target="#myModal">
        <img class="vector-4Ap" src="Dimg/plusSign2.png" id="407:1648" /> 
    </asp:LinkButton>--%>
                           <%-- <asp:LinkButton ID="btnIncParentP" runat="server" OnClick="btnIncParentP_Click" data-toggle="modal" data-target="#myModalIncParentP">
                                    <img class="vector-4Ap" src="Dimg/plusSign2.png" id="407:1648" /> 
                            </asp:LinkButton>
                            <div class="modal fade" id="myModalIncParentP" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel78" aria-hidden="true">
                                <div class="modal-dialog" role="document">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h5 class="modal-title" id="exampleModalLabel78">Parent Increase Amount</h5>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                <span aria-hidden="true">&times;</span>
                                            </button>
                                        </div>
                                        <div class="modal-body">
                                            <!-- Input box -->
                                            <asp:TextBox ID="txtIncParent" runat="server" ></asp:TextBox>
                                        </div>
                                        <div class="modal-footer">
                                            <!-- Submit button -->
                                            <asp:Button ID="btnSubPinc" OnClick="btnSubPinc_Click1" runat="server" Text="Submit" />
                                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <asp:LinkButton ID="btnDecParentP" runat="server" OnClick="btnDecParentP_Click"  data-toggle="modal" data-target="#myModalDecParentP">
                             <img class="vector-BFS" src="Dimg/minusSign2.png" id="407:1649" />  <%-- correct minus sign --%>
                      <%--  </asp:LinkButton>
                                <div class="modal fade" id="mmyModalDecParentP" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel22" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel22">Parent Decrease Amount</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- Input box -->
                               <asp:TextBox ID="txtDecParentP" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="modal-footer">
                                        <!-- Submit button -->
                                         <asp:Button ID="btnSubPdec" OnClick="btnSubPdec_Click1" runat="server" />
                                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <img class="icon-box-qKz" src="Dimg/parentIcon.png" id="407:1637" />
                <p class="parent-incentives-9rU" id="407:1643">Parent Incentives</p>
            </div>
            <div class="group-20126-Sqa" id="406:1616">
                <div class="group-20125-y4p" id="406:1617">
                    <div class="group-20118-i2Q" id="406:1618">
                        <p class="government-incentives-CyA" id="406:1626">Government Incentives</p>--%>
                       <%-- <div class="progress-background-8M2" id="406:1627">
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" strole="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 70%; background-color: orange">70%</div>
                            </div>
                        </div>--%>
                       <%-- <div class="auto-group-uxmw-doa" id="HnvZCsFCo5Den6WdhvUXmW">
                            <p class="r50-y6k" id="406:1628">R<asp:Label ID="govAmountlb" runat="server"></asp:Label></p>
                        </div>
                           <asp:LinkButton ID="btnDecGovP" runat="server" OnClick="btnDecGovP_Click" data-toggle="modal" data-target="#myModalDecGov" >
                                  <img class="vector-uWC" src="Dimg/minusSign2.png" id="406:1632" />
                            </asp:LinkButton>
                               <div class="modal fade" id="myModalDecGov" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">Government Decrease Amount</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- Input box -->
                               <asp:TextBox ID="txtDecGovP" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="modal-footer">
                                        <!-- Submit button -->
                                     <asp:Button ID="Button1" OnClick="btnSubGdec_Click1" runat="server"  Text="submit"/>
                                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>--%>
                <%--<img class="icon-box-aMS" src="Dimg/govIcon.png" id="406:1620" />
                <div class="group-iCk" id="406:1629">
                    <asp:LinkButton ID="btnInGovParent" runat="server" OnClick="btnInGovParent_Click" data-toggle="modal" data-target="#myModal88">
                          <img class="vector-S8k" src="Dimg/plusSign2.png" id="406:1630" />
                    </asp:LinkButton>
                      <div class="modal fade" id="myModal88" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel4" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel4">Government Increase Amount</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- Input box -->
                                 <asp:TextBox ID="txtIncGovP" runat="server" ></asp:TextBox>
                                    </div>
                                    <div class="modal-footer">
                                        <!-- Submit button -->
                                       <asp:Button ID="btnSubGovIncP" runat="server" OnClick="btnSubGovIncP_Click"  Text="submit"/>
                                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                   <%-- <img class="vector-AaY" src="Dimg/plusSign.png" id="406:1631" />--%>
              <%--  </div>
            </div>

            <div class="set-daily-goals-WeQ" id="I406:1607;155:1825">
                <p class="set-daily-goals-gse">Parent Percentage</p>
                <div class="progress-background-o6U" id="407:1644">
                            <asp:LinkButton ID="lbParentPercentage" runat="server" Text="70%"></asp:LinkButton>
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" strole="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width:/* 70%*/ ; background-color: deeppink">70%</div>
                            </div>
                        </div>
                  <%--<asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="btnViewGoals" > </asp:LinkButton>
       <%--         <img class="game-icons-achievement-WXv" src="Dimg/medalGoals.png" id="I406:1607;155:2003" />--%>
                  <%--  <br />
            </div>
            <div class="set-daily-goals-NTe" id="I406:1596;155:1825">
                 <p class="set-daily-goals-gse" id="I406:1596;155:2001">Goverment Percentage</p>
                 <div class="progress-background-8M2" id="406:1627">
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" strole="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 70%; background-color: orange">70%</div>
                            </div>
                        </div>
            <%--       <asp:LinkButton ID="btnApproveReq" runat="server" OnClick="btnApproveReq_Click">
                <img class="auto-group-ezhi-33z" src="Dimg/approvedTick.png" id="HnvZm6pVcfJqPsLPyVezHi" />
                <div class="auto-group-xl6g-ZY8" id="HnvZrbfLLwutZ7ivuQXL6g">
                         <p class="set-daily-goals-gse" id="I406:1596;155:2001">Goverment Percentage</p>
                    </asp:LinkButton>--%>
               <%-- </div>
            </div>
    </div>

                </div>
            <p class="your-childs-yearly-goal-y64" id="406:1593">
                <asp:Label ID="lblYearlyGoal" runat="server" ></asp:Label>
                Your Childs Yearly Goal

            <br />
            </p>
            <div class="steps-G5A" id="406:1581">
                 <div class="progressCircle blue">
            <span class="progressCircle-left">
                <span class="progressCircle-bar"></span>
            </span>
            <span class="progressCircle-right">
                <span class="progressCircle-bar"></span>
            </span>
            <div class="progressCircle-value">90%</div>
        </div>
            </div>
            <div class="welcome-itC" id="406:1458">
                <span class="welcome-itC-sub-0">Welcome</span>
                <span class="welcome-itC-sub-1"></span>
            </div>
            <div class="katleho-gCk" id="406:1437">
                <asp:Label ID="childnameLabel" runat="server"></asp:Label>
            </div>
            <div class="item-123-CRz" id="406:1459">
 <%--               <asp:Label ID="childIdLabel" runat="server" Text="Label"></asp:Label>--%>
               <%-- <asp:Label ID="childIDlb" runat="server" ></asp:Label>
            </div>
    </div>--%
--%>
</asp:Content>