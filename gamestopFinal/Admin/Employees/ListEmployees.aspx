<%@ Page Title="List of Employees" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="ListEmployees.aspx.cs" Inherits="gamestopFinal.Admin.Employees.ListEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
     <div class="panel panel-heading panel-success"><h2>Gamestop Registered Employees</h2></div>
     <asp:GridView ID="grdEmployees" CellPadding="5" runat="server"></asp:GridView> <!-- CellPadding not working, ask Professor about this -->
     <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
     <br />
     <br />
     <b><u>Employee Management</u></b><br />
     &nbsp;<asp:Button ID="btnAddEmp" runat="server" Text="Add" OnClick="btnAddEmp_Click" />
&nbsp;
     <asp:Button ID="btnRemEmp" runat="server" Text="Remove" OnClick="btnRemEmp_Click" />
</asp:Content>
