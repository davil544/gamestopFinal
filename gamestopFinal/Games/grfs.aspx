<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.master" AutoEventWireup="true" CodeBehind="grfs.aspx.cs" Inherits="gamestopFinal.Games.grfs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <table style="width: 20%; float:left">
        <tr>
            <td>
                <asp:Image ID="imgGame" runat="server" Height="315px" Width="236px" />
            </td>
        </tr>
    </table> 
    <table style="width: 75%; float:right">
        <tr>
            <td>
                <h2><asp:Label ID="lblTitle" runat="server"></asp:Label></h2> <br />
                <h4><asp:Label ID="lblDesc" runat="server"></asp:Label></h4> <br /><br />
                <h3>
                    $<asp:Label ID="lblPrice" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="btnAddGrfs" runat="server" BackColor="#337AB7" ForeColor="White" Height="30px" Text="Add to Cart" OnClick="btnAddGrfs_Click" />
                </h3>
            </td>
        </tr>
    </table> 
    <br />
</asp:Content>
