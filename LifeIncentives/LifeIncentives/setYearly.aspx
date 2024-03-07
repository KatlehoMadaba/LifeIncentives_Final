<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="setYearly.aspx.vb" Inherits="LifeIncentives.setYearly" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome to Life Incentives:</h1><br/>
    <p>Since its your first time please set a yearly percentage pay back goal for your child to achieve:</p><br />
    <p>Total Owing to You:</p><asp:Label ID="totalParentlb" runat="server"></asp:Label>
    <p>Total Owing to the government :</p> <asp:Label ID="totalGovlb" runat="server"></asp:Label>
    <asp:DropDownList ID="percentOptionsGov" runat="server">
         <asp:ListItem Text="10%" Value="10"></asp:ListItem>
         <asp:ListItem Text="20%" Value="20"></asp:ListItem>
        <asp:ListItem Text="30%" Value="30"></asp:ListItem>
        <asp:ListItem Text="40%" Value="40"></asp:ListItem>
        <asp:ListItem Text="50%" Value="50"></asp:ListItem>
    </asp:DropDownList>
     <asp:Button ID="btnparentGoalsub" runat="server" OnClick="btnparentGoalsub_Click" Text="submit G" />

    <asp:DropDownList ID="percentOptionsPar" runat="server">
        <asp:ListItem Text="10%" Value="10"></asp:ListItem>
        <asp:ListItem Text="20%" Value="20"></asp:ListItem>
        <asp:ListItem Text="30%" Value="30"></asp:ListItem>
        <asp:ListItem Text="40%" Value="40"></asp:ListItem>
        <asp:ListItem Text="50%" Value="50"></asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="btngovermentGoalsub" runat="server" OnClick="btngovermentGoalsub_Click" Text="submit P" />
    <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
</asp:Content>
