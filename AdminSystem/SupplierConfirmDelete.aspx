<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="btnCnfrmY" runat="server" OnClick="btnCnfrmY_Click" Text="Yes" />
            <asp:Button ID="btnCnfrmN" runat="server" OnClick="btnCnfrmN_Click" Text="No" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
