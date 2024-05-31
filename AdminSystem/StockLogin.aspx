<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 651px">
    <form id="form1" runat="server">
        <div>
            <p>Stock Login Page</p>
        </div>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 60px; top: 153px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 60px; top: 203px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 160px; top: 153px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 160px; top: 203px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 160px; top: 263px; position: absolute; width: 53px;" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 240px; top: 263px; position: absolute; width: 54px;" Text="cencel" height="26px" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 326px; top: 182px; position: absolute" width="70px" ForeColor="#FF3300"></asp:Label>
    </form>
</body>
</html>
