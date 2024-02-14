<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="childGoals.aspx.vb" Inherits="New_LifeIncentives_2024_P2.childGoals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
      <div class="row">
         <div class="col-md-10 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                            <img width="100px"  src="T-Images/tasks.png" />
                        </center>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col">
                        <center>
                           <h4>Tasks</h4>
                        </center>
                     </div>
                  </div>
                   <div class="row">  
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">

                         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Description" DataSourceID="SqlDataSource1" EmptyDataText="No tasks available" BorderColor="#006600" CellSpacing="40" CellPadding="20" CssClass="table table-striped table-borderless table-">
                             <Columns>
                                 <asp:BoundField DataField="StartDateTime" HeaderText="StartDateTime" SortExpression="StartDateTime" />
                                 <asp:BoundField DataField="EndDateTime" HeaderText="EndDateTime" SortExpression="EndDateTime" />
                                 <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                                 <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                 <asp:BoundField DataField="TimePeriod" HeaderText="TimePeriod" SortExpression="TimePeriod" />
                                 <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                                 <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass="btn btn-sm badge bg-success" DeleteText="Complete" />
                             </Columns>
                         </asp:GridView>
                                    
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conn2 %>" 
                             SelectCommand="SELECT [StartDateTime], [EndDateTime], [Category], [Description], [TimePeriod], [Amount] FROM [TBL_Set_Goals]"
                             DeleteCommand="DELETE FROM [TBL_Set_Goals] WHERE [Description] = @Description">
                             <DeleteParameters>
                               <asp:Parameter Name="Description" Type="String"/>
                            </DeleteParameters>
                         </asp:SqlDataSource>
                                    
                                    
                     </div>
               </div>
            </div>
         </div>
        <a href="P-Dashboard.aspx"><< Back to Home</a><br><br>
      </div>
    </div>
    </div>

</asp:Content>
