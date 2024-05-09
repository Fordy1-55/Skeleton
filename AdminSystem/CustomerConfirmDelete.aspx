<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 16px; top: 38px; position: absolute" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 110px; top: 36px; position: absolute"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomersName" runat="server" style="z-index: 1; left: 16px; top: 73px; position: absolute" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 123px; top: 72px; position: absolute; height: 15px"></asp:TextBox>
        <asp:Label ID="lblCustomersAddress" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Customers Address"></asp:Label>
    </form>
</body>
</html>
