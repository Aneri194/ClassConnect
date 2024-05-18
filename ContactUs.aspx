<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 35px;
            background: #369;
            color: #fff;
            text-align: center;
            font-size: medium;
            font-weight: bold;
            width: 284px;
        }
        .auto-style2 {
            width: 355px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Contact Us Form</h2>
<form id="contactForm" runat="server">
    <div>
        <label for="txtName">Name:</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="txtEmail">Email:</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="txtSubject">Subject:</label>
        <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="txtMessage">Message:</label>
        <asp:TextBox ID="txtMessage" TextMode="MultiLine" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" runat="server" />
    </div>
</form>
</asp:Content>

