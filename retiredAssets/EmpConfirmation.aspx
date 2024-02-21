<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="EmpConfirmation.aspx.cs" Inherits="gamestopFinal.EmpConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="panel panel-info">
        <div class="panel-heading">
            <h2>Confirm Employee Information</h2>
        </div>
    </div>

    <div class="panel-body">
        <div class="form-group">
            <label>First Name: </label>
            <asp:Label ID="lblFname" runat="server" Text="First Name" CssClass="form-control"></asp:Label>
            
            <label>Last Name: </label>
            <asp:Label ID="lblLname" runat="server" Text="Last Name" CssClass="form-control"></asp:Label>

            <label>Address 1: </label>
            <asp:Label ID="lblAdd1" runat="server" Text="Address 1" CssClass="form-control"></asp:Label>
            
            <label>Address 2: </label>
            <asp:Label ID="lblAdd2" runat="server" Text="Address 2" CssClass="form-control"></asp:Label>

            <label>City: </label>
            <asp:Label ID="lblCity" runat="server" Text="City" CssClass="form-control"></asp:Label>
            
            <label>State: </label>
            <asp:Label ID="lblState" runat="server" Text="State" CssClass="form-control"></asp:Label>

            <label>Zip: </label>
            <asp:Label ID="lblZip" runat="server" Text="Zip" CssClass="form-control"></asp:Label>

            <label>Job Title: </label>
            <asp:Label ID="lblTitle" runat="server" Text="Job Title" CssClass="form-control"></asp:Label>
            
        </div>

        <div class="form-group text-center">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        &nbsp;
            <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />
        </div>
    </div>
</asp:Content>
