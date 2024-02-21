<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="gamestopFinal.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-heading">
        <h1>Gamestop Website Administration</h1>
    </div>

    <div class="panel panel-body">
        <div class="danger">
            &nbsp;<asp:Login ID="formAdminLogin" runat="server" OnAuthenticate="formAdminLogin_Authenticate">
            </asp:Login>
            <br />
            <asp:Button ID="btnAdminLogin" runat="server" OnClick="adminLogin_Click" Text="Force Log In" />
        </div>
    </div>
</asp:Content>
