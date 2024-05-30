<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 788px; top: 115px; position: absolute; height: 32px; width: 130px" Text="Fusion Main Menu"></asp:Label>
        </p>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 805px; top: 196px; position: absolute" Text="Customer" />
        <asp:Button ID="btnOrder" runat="server" height="26px" OnClick="btnOrder_Click" style="z-index: 1; left: 805px; top: 153px; position: absolute" Text="Order" width="84px" />
        <asp:Button ID="btnStaff" runat="server" height="26px" OnClick="btnStaff_Click" style="z-index: 1; left: 805px; top: 245px; position: absolute" Text="Staff" width="84px" />
        <asp:Button ID="btnStock" runat="server" height="26px" OnClick="btnStock_Click" style="z-index: 1; left: 805px; top: 296px; position: absolute" Text="Stock" width="84px" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnSupplier" runat="server" height="26px" OnClick="btnSupplier_Click" style="z-index: 1; top: 343px; position: absolute; left: 804px" Text="Supplier" width="84px" />
    </form>
</body>
</html>
