<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 88px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="height: 52px; width: 636px">
            <asp:Label ID="lblStaffLogin" runat="server" Text="Staff Login Page"></asp:Label>
           
        </p>
        <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Height="16px" style="margin-left: 16px; margin-top: 3px"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 22px" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="margin-left: 45px" Text="Cancel" Width="71px" />
        </p>
    </form>
</body>
</html>
