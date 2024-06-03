<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
<body style="height: 590px; width: 1021px; background-color: #99FF99;">
    <form id="form1" runat="server">
        <div>
        </div>
            <asp:Label ID="lblConfirmText" runat="server" style="z-index: 1; left: 75px; top: 132px; position: absolute; height: 47px; width: 411px" Text="Are  you sure you want to delete this record?" BorderColor="White" BorderStyle="None"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 110px; top: 172px; position: absolute" Text="Yes" CssClass="auto-style1" />
        <asp:Button ID="btnNo" runat="server"  style="z-index: 1; left: 268px; top: 173px; position: absolute; width: 39px" Text="No" OnClick="btnNo_Click" CssClass="auto-style1" />
    </form>
</body>
</html>
