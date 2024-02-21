<%@ Page Title="Gamestop - Power to the Players!" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="gamestopFinal.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div class="row" style="padding-top: 50px;">
        <div class="col-sm-6 col-md-4">
            <div class="thumbnail">
                <!-- <img src="/Assets/Inventory/rdr2.jpg" alt="Red Dead Redemption 2"> -->
                <asp:Image ID="imgRdr2" runat="server" />
                <div class="caption">
                    <h3><asp:Label ID="lblRdr2Title" runat="server" Text=""></asp:Label></h3>
                    <p><asp:Label ID="lblRdr2Desc" runat="server" Text=""></asp:Label></p>
                    <p><asp:Label ID="lblRdr2Cost" runat="server" Text=""></asp:Label></p>
                    <p><asp:Button ID="btnAddRdr2" runat="server" BackColor="#337AB7" ForeColor="White" Height="30px" Text="Add to Cart" onClick="btnAddRdr2_Click"/>
                    &nbsp;<asp:Button ID="btnDetailsRdr2" runat="server" Height="30px" Text="Details" OnClick="btnDetailsRdr2_Click" /></p>
                </div>
            </div>
        </div>

        <div class="col-sm-6 col-md-4">
            <div class="thumbnail">
                <!-- <img src="/Assets/Inventory/grfs.jpg" alt="Ghost Recon: Future Soldier"> -->
                <asp:Image ID="imgGrfs" runat="server" />
                <div class="caption">
                    <h3><asp:Label ID="lblGrfsTitle" runat="server" Text=""></asp:Label></h3>
                    <p><asp:Label ID="lblGrfsDesc" runat="server" Text=""></asp:Label></p>
                    <p><asp:Label ID="lblGrfsCost" runat="server" Text=""></asp:Label></p>
                    <p><asp:Button ID="btnAddGrfs" runat="server" BackColor="#337AB7" ForeColor="White" Height="30px" Text="Add to Cart"  onClick="btnAddGrfs_Click"/>
                    &nbsp;<asp:Button ID="btnDetailsGrfs" runat="server" Height="30px" Text="Details" OnClick="btnDetailsGrfs_Click" /></p>
                </div>
           </div>
        </div>

        <div class="col-sm-6 col-md-4">
             <div class="thumbnail">
                <!-- <img src="/Assets/Inventory/forza7.jpg" alt="Forza 7"> -->
                 <asp:Image ID="imgForza7" runat="server" />
                <div class="caption">
                    <h3><asp:Label ID="lblForza7Title" runat="server" Text=""></asp:Label></h3>
                    <p> <asp:Label ID="lblForza7Desc" runat="server" Text=""></asp:Label> </p>
                    <p> <asp:Label ID="lblForza7Cost" runat="server" Text=""></asp:Label> </p>
                    <p><asp:Button ID="btnAddForza7" runat="server" BackColor="#337AB7" ForeColor="White" Height="30px" Text="Add to Cart" onClick="btnAddForza7_Click"/>
                    &nbsp;<asp:Button ID="btnDetailsForza7" runat="server" Height="30px" Text="Details" OnClick="btnDetailsForza7_Click" /></p>
                </div>
           </div>
        </div>
    </div>
</asp:Content>
