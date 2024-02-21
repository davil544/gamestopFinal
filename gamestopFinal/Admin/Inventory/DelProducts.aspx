<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="DelProducts.aspx.cs" Inherits="gamestopFinal.Admin.Inventory.DelProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
     <div class="panel panel-heading panel-success"><h2>Gamestop Inventory List</h2></div>
     <asp:GridView ID="grdProducts" CellPadding="5" runat="server"></asp:GridView>
     <div class="panel panel-body">Choose the product that you would like to remove: <br />(Note Products 1 - 3 are hard-coded into the webserver and can not be removed):&nbsp;
        <asp:TextBox ID="txtRemove" runat="server" CssClass="form-control" Width="83px"></asp:TextBox>
        <br />
        <asp:Button ID="btnRemove" runat="server" Height="21px" Text="Remove" OnClick="btnRemove_Click" />
    &nbsp;
        <asp:Button ID="btnReturn" runat="server" Height="21px" Text="Return" OnClick="btnReturn_Click" />
</asp:Content>
