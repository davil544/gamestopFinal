<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="DelCustomers.aspx.cs" Inherits="gamestopFinal.Admin.Customers.DelCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
    <div class="panel panel-heading panel-success"><h2>Gamestop Registered Customers</h2></div>
    <asp:GridView ID="grdCustomers" runat="server"></asp:GridView>
    <br />
    <div class="panel panel-body">Choose the customer that you would like to remove (by Customer ID):&nbsp;
        <asp:TextBox ID="txtRemove" runat="server" CssClass="form-control" Width="83px"></asp:TextBox>
        <br />
        <asp:Button ID="btnRemove" runat="server" Height="21px" Text="Remove" OnClick="btnRemove_Click" />
    &nbsp;
        <asp:Button ID="btnReturn" runat="server" Height="21px" Text="Return" OnClick="btnReturn_Click" />
    </div>
</asp:Content>
