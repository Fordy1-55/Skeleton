<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
        <p>
            <asp:Label ID="lblMainMenu" runat="server" style="z-index: 1; left: 720px; top: 94px; position: absolute; height: 32px; width: 130px" Text="Fusion Main Menu"></asp:Label>
        </p>
        <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 595px; top: 149px; position: absolute" Text="Customer" height="26px" width="84px" />
        <asp:Button ID="btnOrder" runat="server" height="26px" OnClick="btnOrder_Click" style="z-index: 1; left: 465px; top: 149px; position: absolute" Text="Order" width="84px" />
        <asp:Button ID="btnStaff" runat="server" height="26px" OnClick="btnStaff_Click" style="z-index: 1; left: 730px; top: 149px; position: absolute" Text="Staff" width="84px" />
        <asp:Button ID="btnStock" runat="server" height="26px" OnClick="btnStock_Click" style="z-index: 1; left: 865px; top: 149px; position: absolute" Text="Stock" width="84px" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnSupplier" runat="server" height="26px" OnClick="btnSupplier_Click" style="z-index: 1; top: 149px; position: absolute; left: 1025px" Text="Supplier" width="84px" />
        </div>
    </form>
</body>
</html>
