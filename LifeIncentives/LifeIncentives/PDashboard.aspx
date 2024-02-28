<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="PDashboard.aspx.vb" Inherits="LifeIncentives.PDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--    <asp:Button ID="btnSubGdec" OnClick="btnSubGdec_Click1" runat="server" />--%>
  <%--  <asp:LinkButton ID="LinkButton1" OnClick="btnGIncParent_Click1" runat="server"  data-toggle="modal" data-target="#myModal77">
                           <img class="vector-S8k" src="Dimg/plusSign2.png" id="406:1630" />
                     </asp:LinkButton>--%>

  <%--  <asp:Button ID="Button2" runat="server" OnClick="btnsubGDec_Click"  Text="submit"/>--%>
      <div class="line-7-YXv" id="406:1455"></div>
            <img class="rectangle-508-sq6" src="Dimg/" id="406:1580" />
            <div class="group-20127-Q4L" id="407:1633">
                <div class="group-20125-XPr" id="407:1634">
                    <div class="group-20118-4eg" id="407:1635">
                        <div class="progress-background-o6U" id="407:1644">
                            <asp:LinkButton ID="lbParentPercentage" runat="server" Text="70%"></asp:LinkButton>
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" strole="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width:/* 70%*/ ; background-color: deeppink">70%</div>
                            </div>
                        </div>
                        <p class="r50-uQQ" id="407:1645">R<asp:Label ID="lbParentAmount" runat="server"></asp:Label></p>
                        <div class="group-CuJ" id="407:1646">
<%--    <asp:LinkButton ID="btnPIncParent" OnClick="btnPIncreseParent_Click" runat="server" data-toggle="modal" data-target="#myModal">
        <img class="vector-4Ap" src="Dimg/plusSign2.png" id="407:1648" /> 
    </asp:LinkButton>--%>
                            <asp:LinkButton ID="btnIncParentP" runat="server" OnClick="btnIncParentP_Click" data-toggle="modal" data-target="#myModalIncParentP">
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
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
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
                        </asp:LinkButton>
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
                        <p class="government-incentives-CyA" id="406:1626">Government Incentives</p>
                        <div class="progress-background-8M2" id="406:1627">
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" strole="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 70%; background-color: orange">70%</div>
                            </div>
                        </div>
                        <div class="auto-group-uxmw-doa" id="HnvZCsFCo5Den6WdhvUXmW">
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
                </div>
                <img class="icon-box-aMS" src="Dimg/govIcon.png" id="406:1620" />
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
                </div>
            </div>

            <div class="set-daily-goals-WeQ" id="I406:1607;155:1825">
                  <asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="btnViewGoals" CssClass="set-daily-goals-hMW">Set Goals</asp:LinkButton>
                <img class="game-icons-achievement-WXv" src="Dimg/medalGoals.png" id="I406:1607;155:2003" />
<%--                <asp:LinkButton ID="LinkButton5" runat="server" OnClientClick="btnViewGoals" CssClass="set-daily-goals-hMW">Set Goals</asp:LinkButton>--%>
              <%--      <asp:LinkButton runat="server"  OnClick="transactionsBtn" CssClass="set-daily-goals-hMW">View Your Goals</asp:LinkButton>--%>
                    <br />
            </div>
            <div class="set-daily-goals-NTe" id="I406:1596;155:1825">
                   <asp:LinkButton ID="btnApproveReq" runat="server" OnClick="btnApproveReq_Click">
                <img class="auto-group-ezhi-33z" src="Dimg/approvedTick.png" id="HnvZm6pVcfJqPsLPyVezHi" />
                <div class="auto-group-xl6g-ZY8" id="HnvZrbfLLwutZ7ivuQXL6g">
                         <p class="set-daily-goals-gse" id="I406:1596;155:2001">View Requests</p>
                    </asp:LinkButton>
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
                   
      <%--          <div class="group-24-L6x" id="406:1590">
                    <img class="vector-Fzc" src="/api/try-prod-ap-southeast-1-first-cluster/project..." id="406:1591" />
                    <img class="vector-b2t" src="/api/try-prod-ap-southeast-1-first-cluster/project..." id="406:1592" />
                </div>--%>
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
                <asp:Label ID="childIDlb" runat="server" ></asp:Label>
            </div>
 




</asp:Content>
