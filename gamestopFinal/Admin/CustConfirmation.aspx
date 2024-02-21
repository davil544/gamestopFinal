<%@ Page Title="Gamestop - Account Confirmation" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="CustConfirmation.aspx.cs" Inherits="gamestopFinal.Admin.CustConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
    <div>
            <div class="panel panel-success">
                <div class="panel-heading"> 
                    <h2>Customer Info Confirmation</h2>
                </div>
            </div>

            <div class="panel-body">

                <div class="form-group">
                    <label>First Name: </label>
                    <asp:Label ID="lblFname" runat="server" Text="FirstName" CssClass="form-control"></asp:Label>
                    

                    <label>Last Name: </label>
                     <asp:Label ID="lblLname" runat="server" Text="LastName" CssClass="form-control"></asp:Label>
                    

                    <label>Address 1: </label>
                     <asp:Label ID="lblAdd1" runat="server" Text="Address 1" CssClass="form-control"></asp:Label>
                   

                    <label>Address 2: </label>
                     <asp:Label ID="lblAdd2" runat="server" Text="Address 2" CssClass="form-control"></asp:Label>
                 

                    <label>City: </label>
                     <asp:Label ID="lblCity" runat="server" Text="City" CssClass="form-control"></asp:Label>
                    

                    <label>State: </label>
                     <asp:Label ID="lblState" runat="server" Text="State" CssClass="form-control"></asp:Label>
                   

                    <label>Zip (Postal) Code: </label>
                     <asp:Label ID="lblZip" runat="server" Text="12345" CssClass="form-control"></asp:Label>
                    
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
                </div>

            </div> <%--Closes Panel Body --%>
        </div>
</asp:Content>
