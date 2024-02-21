<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="gamestopFinal.Checkout" %>
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
    <asp:Panel ID="pnlGuestOrReg" runat="server" Visible="true">
        <div class="jumbotron">
            <h1>How would you like to check out today?</h1>
            <p>'Login and Checkout' button currently does not work</p>
            <p><asp:Button ID="btnGuest" runat="server" BackColor="#337AB7" ForeColor="White" Height="41px" Text="Guest Checkout" OnClick="btnGuest_Click" />
               <asp:Button ID="btnReg" runat="server" BackColor="#337AB7" ForeColor="White" Height="41px" Text="Login and Checkout" Enabled="False" />
               <asp:Button ID="btnCancel" runat="server" BackColor="#337AB7" ForeColor="White" Height="41px" Text="Cancel" OnClientClick="return confirmCancel()" OnClick="btnCancel_Click" />
            </p>
        </div>
    </asp:panel>
    <asp:Panel ID="pnlGuestCheckout" runat="server" Visible="false">
        <div class="panel-body">
            <div class="form-group">
                <table>
                    <tr style="width: 33%; float: left;">
                        <td>
                            <label>First Name: </label>
                            <asp:TextBox ID="txtFname" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>Last Name: </label>
                            <asp:TextBox ID="txtLname" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>Address 1: </label>
                            <asp:TextBox ID="txtAdd1" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>Address 2: </label>
                            <asp:TextBox ID="txtAdd2" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>City: </label>
                            <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>State: </label>
                            <asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>Zip (Postal) Code: </label>
                            <asp:TextBox ID="txtZip" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="width: 33%; float: right;">
                        <td>    <!-- Cart Display Starts -->
                            <table style="border: 1px solid black">
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
                                </tr>
                                <tr>
                                    <td><asp:Label ID="lblTax" runat="server" Text=""></asp:Label></td>
                                </tr>
                            </table>
                            <table>
                                <tr>
                                    <th>Subtotal</th>
                                </tr>
                                <tr>
                                    <td><asp:Label ID="lblSubtotal" runat="server" Text=""></asp:Label></td>
                                </tr>
                            </table>
                        <br />
                            <table>
                                <tr>
                                    <th>Total</th>
                                </tr>
                                <tr>
                                    <td><asp:Label ID="lblTotal" runat="server" Text=""></asp:Label></td>
                                </tr>
                            </table>
                        </td>   <!-- Cart Display Ends -->
                    </tr>

                    <tr style="width: 33%; float: right;">
                        <td>
                            <h4>Only Credit / Debit cards are accepted.</h4>
                            <label>Name On Card: </label>
                            <asp:TextBox ID="txtCardName" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>Card Number:
                                <br />(XXXX-XXXX-XXXX-XXXX)
                            </label>
                            <asp:TextBox ID="txtCardNum" runat="server" CssClass="form-control"></asp:TextBox>

                            <label>Card Exp Date (MM/YY): </label>
                            <asp:TextBox ID="txtCardExpDate" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    
                </table>

                <br/ />

                
            </div>

            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>

            <div class="form-group text-center">
                <asp:Button ID="btnContinue" runat="server" Text="Continue" OnClick="btnContinue_Click"   />
                <asp:Button ID="btnCancel2" runat="server" Text="Cancel" OnClientClick="return confirmCancel()" OnClick="btnCancel_Click" />
            </div>
        </div> <%--Closes Panel Body --%>
    </asp:Panel>
</asp:Content>
