<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 659px">
    <form id="form1" runat="server">
        <div style="height: 656px">
             <asp:Label ID="lblSupMngmt" runat="server" style="z-index: 1; left: 109px; top: 29px; position: absolute">Supplier Management Login Page</asp:Label> 
             <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 379px; top: 157px; position: absolute" ForeColor="Red"></asp:Label>
             <asp:Button ID="BtnCancel" runat="server" Text="Cancel" style="z-index: 1; left: 279px; top: 211px; position: absolute; margin-bottom: 5px;" height="26px" OnClick="BtnCancel_Click"/>
             <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 206px; top: 139px; position: absolute" OnTextChanged="txtPassword_TextChanged" height="22px" TextMode="Password" width="128px"></asp:TextBox>
             <asp:Label ID="lblUsername" runat="server" Text="Username:" style="z-index: 1; left: 111px; top: 105px; position: absolute; right: 1335px;"></asp:Label>
             <asp:Label ID="lblPassword" runat="server" Text="Password:" style="z-index: 1; left: 111px; top: 145px; position: absolute"></asp:Label>
             <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 206px; top: 106px; position: absolute; margin-bottom: 5px;" height="22px" width="128px"></asp:TextBox>
             <asp:Button ID="BtnLogin" runat="server" Text="Login" style="z-index: 1; left: 201px; top: 211px; position: absolute; margin-bottom: 5px;" OnClick="BtnLogin0_Click"/>
        </div>
    </form>
</body>
</html>
