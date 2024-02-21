<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="gamestopFinal.Admin.Inventory.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
    <div class="panel panel-success">
        <div class="panel-heading"> 
            <h2>Add a Product to the Store</h2>
        </div>
    </div>

    <div class="panel-body">

        <div class="form-group">
            <label>Product Name: </label>
            <asp:TextBox ID="txtProdName" runat="server" CssClass="form-control"></asp:TextBox>

            <label>Product Description: </label>
            <asp:TextBox ID="txtProdDesc" runat="server" CssClass="form-control"></asp:TextBox>

            <label>Product Cost: </label>
            <asp:TextBox ID="txtProdCost" runat="server" CssClass="form-control"></asp:TextBox>

            <h4>Product Cover Image:</h4>
            <asp:FileUpload ID="flUpload" runat="server" /><br />
            <br /><br />
        </div>

        <div class="form-group text-center">
            <asp:Button ID="btnOK" runat="server" Text="Submit" OnClick="btnOK_Click" />
            <asp:Button ID="btnClr" runat="server" Text="Return" OnClick="btnClr_Click" />
        </div>
    </div>
</asp:Content>
