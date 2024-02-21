<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="gamestopFinal.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
    <style>
        table, th,td {
            border: 1px solid black;
            padding-left: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <!-- <asp:GridView ID="grdCart" runat="server"></asp:GridView> --->
    <asp:Panel ID="pnlCart" runat="server" Visible="false">
        <table style="width: 80%; border: 1px solid black">
            <tr style="text-align: center;">
                <th>Product Name</th>
                <th>Product Price</th>
            </tr>
            <tr>
                <td><asp:Label ID="lblProductName" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="lblProductPrice" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    <br />
        <table>
    	    <tr>
                <th>NY State Tax</th>
        	    <th>Subtotal</th>
                <th>Total</th>
            </tr>
            <tr>
                <td><asp:Label ID="lblTax" runat="server" Text=""></asp:Label></td>
    	        <td><asp:Label ID="lblSubtotal" runat="server" Text=""></asp:Label></td>
                <td><asp:Label ID="lblTotal" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    <br />
        <!-- <asp:Label ID="lblCart" runat="server" Text=""></asp:Label> <br /> -->
        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
        <asp:Button ID="btnClearCart" runat="server" Text="Empty Cart" OnClick="btnClearCart_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlCartEmpty" runat="server" Visible="false"><h3>The cart is empty.</h3></asp:Panel>
</asp:Content>
