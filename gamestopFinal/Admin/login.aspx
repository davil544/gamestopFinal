﻿<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="gamestopFinal.Admin.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
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
