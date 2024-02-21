<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="CheckoutConfirm.aspx.cs" Inherits="gamestopFinal.CheckoutConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function confirmCancel() {
            if (confirm("Are you sure you want to cancel this purchase?")==true)
                return true;
            else
                return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="page-header">
        <h1>Confirm Purchase
            <br /><small>Please confirm that all of the information is correct.</small>
        </h1>
    </div>
    <div class="panel panel-warning">
        <div class="panel-body">
            <div class="form-group">
                <table style="width: 45%; float: left;">
                    <tr>
                        <td>
                            <label>First Name: </label>
                            <asp:Label ID="lblFname" runat="server" Text="" CssClass="form-control"></asp:Label>

                            <label>Last Name: </label>
                            <asp:Label ID="lblLname" runat="server" Text="" CssClass="form-control"></asp:Label>

                            <label>Address 1: </label>
                            <asp:Label ID="lblAdd1" runat="server" Text="" CssClass="form-control"></asp:Label>

                            <label>Address 2: </label>
                            <asp:Label ID="lblAdd2" runat="server" Text="" CssClass="form-control"></asp:Label>

                            <label>City: </label>
                            <asp:Label ID="lblCity" runat="server" Text="" CssClass="form-control"></asp:Label>

                            <label>State: </label>
                            <asp:Label ID="lblState" runat="server" Text="" CssClass="form-control"></asp:Label>

                            <label>Zip (Postal) Code: </label>
                            <asp:Label ID="lblZip" runat="server" Text="" CssClass="form-control"></asp:Label>
                        </td>
                    </tr>
                </table>

                <table style="width: 45%; float: right">
                    <tr>
                        <td>
                            <br />
                            <table style="width: 50%; float: left">
                                <tr>
                                    <td>
                                        <label>Name on card: </label>
                                        <asp:Label ID="lblCardholderName" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 50%; float: right">
                                <tr>
                                    <td>
                                        <label>Exp Date: </label>
                                        <asp:Label ID="lblCardExp" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>

                            <p><label>Card Number (Last 4): </label>
                                <asp:Label ID="lblCardNum" runat="server" Text=""></asp:Label>
                            </p>
                            <br />
                            <p><label>Products Ordered: </label>
                                <asp:Label ID="lblProductName" runat="server" Text=""></asp:Label>
                            </p> <br />
                            <p>
                                <label>Product Price: </label>
                                <asp:Label ID="lblProductPrice" runat="server" Text=""></asp:Label>
                            </p> <br /><br />

                            
                            <table style="width: 50%; float: left">
                                <tr>
                                    <td>
                                        <label>Subtotal: </label>
                                        <asp:Label ID="lblSubtotal" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 50%; float: right">
                                <tr>
                                    <td>
                                        <label>NY State Tax: </label>
                                        <asp:Label ID="lblTax" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <br /><br />
                            
                            <p>
                                <label>Total:</label>
                                <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                            </p>
                            <br /><br />
                            <p><asp:Button ID="btnPurchase" runat="server" Text="Purchase" OnClick="btnPurchase_Click" />
&nbsp;&nbsp;
                                <asp:Button ID="btnReturn" runat="server" Text="Go Back" OnClick="btnReturn_Click" />
&nbsp;&nbsp;
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel Order" OnClientClick="return confirmCancel()" OnClick="btnCancel_Click" />
                            </p>
                        </td>
                    </tr>
                </table>
            </div>
        </div>  
    </div>
</asp:Content>
