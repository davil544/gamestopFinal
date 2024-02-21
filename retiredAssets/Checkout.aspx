<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="gamestopFinal.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <asp:Panel ID="pnlGuestOrReg" runat="server" Visible="true">
        <div class="jumbotron">
            <h1>How would you like to check out today?</h1>
            <p>Guest Checkout is the only option that currently works</p>
            <p><asp:Button ID="btnGuest" runat="server" BackColor="#337AB7" ForeColor="White" Height="41px" Text="Guest Checkout" OnClick="btnGuest_Click" />
                <asp:Button ID="btnReg" runat="server" BackColor="#337AB7" ForeColor="White" Height="41px" Text="Login and Checkout" Enabled="False" />
            </p>
        </div>
    </asp:panel>
    <asp:Panel ID="pnlGuestCheckout" runat="server" Visible="false">
        <div>Sample Guest Checkout</div>
    </asp:Panel>
</asp:Content>
