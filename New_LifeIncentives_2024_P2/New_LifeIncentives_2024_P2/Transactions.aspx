<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Transactions.aspx.vb" Inherits="New_LifeIncentives_2024_P2.Transactions" %>

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
                            <img width="100px"  src="T-Images/Transaction.png" />
                        </center>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col">
                        <center>
                           <h4>Transaction</h4>
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

                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" EmptyDataText="No data available" BorderColor="#006600" CellSpacing="40" CellPadding="20" CssClass="table table-striped table-borderless table-" EditRowStyle-HorizontalAlign="Center" EditRowStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-CssClass="thead-light">
                             <HeaderStyle CssClass="thead-light"/>
                             <Columns>

                                 <asp:BoundField DataField="StartDateTime" HeaderText="StartDateTime" SortExpression="StartDateTime" />
                                 <asp:BoundField DataField="EndDateTime" HeaderText="EndDateTime" SortExpression="EndDateTime" />
                                 <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                                 <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                 <asp:BoundField DataField="TimePeriod" HeaderText="TimePeriod" SortExpression="TimePeriod" />
                                 <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                                 <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"  ItemStyle-CssClass="badge bg-success text-white table_status"   />
                             </Columns>
                                     <RowStyle CssClass="text-center" />
                                     </asp:GridView>

                                     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:conn2 %>" SelectCommand="SELECT [StartDateTime], [EndDateTime], [Category], [Description], [TimePeriod], [Amount], [Status] FROM [TBL_View_Goals]"></asp:SqlDataSource>

                     </div>
               </div>
            </div>
         </div>
        <a href="P-Dashboard.aspx"><< Back to Home</a><br><br>
      </div>
    </div>
    </div>

</asp:Content>
