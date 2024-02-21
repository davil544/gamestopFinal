<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="EmpRegistration.aspx.cs" Inherits="gamestopFinal.Admin.Employees.EmpRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="adminBody" runat="server">
    <div class="panel panel-success">
                <div class="panel-heading"> 
                    <h2>Employee Registration</h2>
                </div>
            </div>

            <div class="panel-body">

                <div class="form-group">
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

                    <label>Job Title: </label>
                    <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="btnOK" runat="server" Text="Submit" OnClick="btnOK_Click" />
                    <asp:Button ID="btnClr" runat="server" Text="Return" OnClick="btnClr_Click" />
                </div>

            </div>
</asp:Content>
