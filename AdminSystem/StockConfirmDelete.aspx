<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: #bababa">
    <form id="form1" runat="server">
        <div style="height: 634px">
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 139px; top: 125px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 223px; top: 126px; position: absolute" Text="No" />
            <asp:Label ID="lblDeleteMsg" runat="server" Height="25px" Style="z-index: 1; left: 83px; top: 80px; position: absolute; width: 294px;">Are you sure you want to delete ?</asp:Label>

        </div>
    </form>
</body>
</html>
