﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            background-color: #CCFFCC;
        }
    </style>
</head>
<body style="background-color: #99FF99">
    <form id="form1" runat="server">
        <div style="height: 569px; background-color: #99FF99">
        </div>
        <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; text-decoration: underline;" Text="Order Login Page"></asp:Label>
        <asp:Label ID="lbluserName" runat="server" style="z-index: 1; left: 13px; top: 97px; position: absolute; height: 19px; width: 32px" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 15px; top: 128px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 99px; top: 95px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 100px; top: 127px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 352px; top: 88px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 88px; top: 178px; position: absolute" Text="Login" CssClass="auto-style1" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 160px; top: 178px; position: absolute" Text="Cancel" CssClass="auto-style1" />
    </form>
</body>
</html>
