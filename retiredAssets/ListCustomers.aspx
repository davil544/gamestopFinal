<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="ListCustomers.aspx.cs" Inherits="gamestopFinal.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
 <div class="panel panel-heading panel-success"><h2>Gamestop Registered Customers</h2></div>
 
 <asp:GridView ID="grdCustomers" runat="server"></asp:GridView>
</asp:Content>
