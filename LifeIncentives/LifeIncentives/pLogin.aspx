<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="pLogin.aspx.vb" Inherits="LifeIncentives.pLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Parent Login</h1>
    <asp:TextBox ID="idttxt" runat="server" ></asp:TextBox>
    <asp:TextBox ID="nametxt" runat="server"></asp:TextBox> 
    <asp:button ID="btnSubmit" runat="server" Text="submit" />
</asp:Content>
