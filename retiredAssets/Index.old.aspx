<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="Index.old.aspx.cs" Inherits="gamestopFinal.Index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Gamestop - Power to the Players</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container">
        <div class="panel" style="float: right"><a href="CustRegistration.aspx">Sign up for an account!</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <a href="Cart.aspx"> <img src="/Assets/cart.png" alt="Cart" style="border-style: none; border-color: inherit; border-width: 0; width:32px; height:32px;" /> </a></div>
        <div class="container">
            <div class="row" style="padding-top: 50px;">
                <div class="col-sm-6 col-md-4">
                    <div class="thumbnail">
                        <img src="/Assets/Inventory/rdr2.jpg" alt="Red Dead Redemption 2">
                        <div class="caption">
                            <h3>Red Dead Redemption 2</h3>
                            <p>New-age western open world Adventure!</p>
                            <p><asp:Button ID="btnAddRdr2" runat="server" BackColor="#337AB7" ForeColor="White" Height="30px" Text="Add to Cart" />
                            &nbsp;<asp:Button ID="btnDetailsRdr2" runat="server" Height="30px" Text="Details" /></p>
                        </div>
                   </div>
                </div>

                <div class="col-sm-6 col-md-4">
                    <div class="thumbnail">
                        <img src="/Assets/Inventory/grfs.jpg" alt="Ghost Recon: Future Soldier">
                        <div class="caption">
                            <h3>Tom Clancy's Ghost Recon: Future Soldier</h3>
                            <p>Futuristic First Person Shooter</p>
                            <p><asp:Button ID="btnAddGrfs" runat="server" BackColor="#337AB7" ForeColor="White" Height="30px" Text="Add to Cart" />
                            &nbsp;<asp:Button ID="btnDetailsGrfs" runat="server" Height="30px" Text="Details" /></p>
                        </div>
                   </div>
                </div>

                <div class="col-sm-6 col-md-4">
                    <div class="thumbnail">
                        <img src="/Assets/Inventory/forza7.jpg" alt="Forza 7">
                        <div class="caption">
                            <h3>Forza Motorsport 7</h3>
                            <p>Action Packed Racing Game</p>
                            <p><asp:Button ID="btnAddForza7" runat="server" BackColor="#337AB7" ForeColor="White" Height="30px" Text="Add to Cart" />
                            &nbsp;<asp:Button ID="btnDetailsForza7" runat="server" Height="30px" Text="Details" /></p>
                        </div>
                   </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
