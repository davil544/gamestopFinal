<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="DelEmployeeConfirm.aspx.cs" Inherits="gamestopFinal.Admin.Employees.DelEmployeeConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
    <div class="panel panel-heading panel-success"><h2>Gamestop Registered Employees</h2></div>
     <asp:GridView ID="grdEmployees" runat="server"></asp:GridView>
    <br />
    <div class="panel panel-body">Please confirm this is the employee ID you wish to remove (This cannot be undone):<br /> <br />
        <asp:Label ID="lblRemove" runat="server" CssClass="form-control" Width="83px"></asp:Label>
        <br /> <br />
        <asp:Button ID="btnRemove" runat="server" Height="21px" Text="Remove" OnClick="btnRemove_Click" />
    &nbsp;
        <asp:Button ID="btnReturn" runat="server" Height="21px" Text="Return" OnClick="btnReturn_Click" />
    </div>
</asp:Content>
