<%@ Page Title="" Language="C#" MasterPageFile="~/Gamestop.Master" AutoEventWireup="true" CodeBehind="CustRegistration.aspx.cs" Inherits="gamestopFinal.CustRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Gamestop - Create an account</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div>
            <div class="panel panel-success">
                <div class="panel-heading"> 
                    <h2>Customer Registration</h2>
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
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="btnOK" runat="server" Text="Submit" OnClick="btnOK_Click" />
                    <asp:Button ID="BtnClr" runat="server" Text="Return" OnClick="BtnClr_Click" />
                </div>

				<div id="EmployeeLink">
					<a href="Admin/Login.aspx">Administrator Login</a>
				</div>

            </div> <%--Closes Panel Body --%>
        </div>
</asp:Content>
