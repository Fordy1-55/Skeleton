﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 80px; top: 125px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 130px; top: 125px; position: absolute" Text="No" />
            <asp:Label ID="lblDeleteMsg" runat="server" Height="19px" Style="z-index: 1; left: 16px; top: 80px; position: absolute" Width="120px"></asp:Label>

        </div>
    </form>
</body>
</html>
