<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeBehind="CheckoutConfirmed.aspx.cs" Inherits="gamestopFinal.CheckoutConfirmed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="alert alert-success" role="alert"><h2>Thank you for your order <asp:label id="lblCustName" runat="server" text="Label"></asp:label>, you
    will get an email when the items have shipped.</h2></div>
</asp:Content>
