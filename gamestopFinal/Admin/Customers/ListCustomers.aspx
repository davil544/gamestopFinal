<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ListCustomers.aspx.cs" Inherits="gamestopFinal.Admin.Customers.ListCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
     <div class="panel panel-heading panel-success"><h2>Gamestop Registered Customers</h2></div>
     <asp:GridView ID="grdCustomers" runat="server"></asp:GridView>
     <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
     <br />
     <br />
     <br />
     <span class="auto-style1"><strong>Customer Management</strong></span><br />
&nbsp;<asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;
     <asp:Button ID="btnRemove" runat="server" Text="Remove" OnClick="btnRemove_Click" /> <!-- Make these buttons work -->
</asp:Content>
