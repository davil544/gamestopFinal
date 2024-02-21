<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="gamestopFinal.Admin.Inventory.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
    <div class="panel panel-heading panel-success"><h2>Gamestop Inventory List</h2></div>
     <asp:GridView ID="grdProducts" CellPadding="5" runat="server"></asp:GridView>
     <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
     <br />
     <br />
     <b><u>Inventory Management</u></b><br />
     &nbsp;<asp:Button ID="btnAddProduct" runat="server" Text="Add" OnClick="btnAddProduct_Click" />
&nbsp;
     <asp:Button ID="btnRemProduct" runat="server" Text="Remove" OnClick="btnRemProduct_Click" />
</asp:Content>
