<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="gamestopFinal.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-heading">
        <h2>Gamestop Web Store Administration</h2>
    </div>
    <div class="panel panel-body panel-success">
        <h5> <a href="EmpRegistration.aspx">Add Newly Hired Employee</a> </h5>
        <h5> <a href="ListCustomers.aspx">List Registered Customers</a></h5>
        <h5> <a href="logout.aspx">Log out</a></h5>
    </div>
</asp:Content>
