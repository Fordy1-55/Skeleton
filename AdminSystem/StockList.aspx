<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 568px; width: 527px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 625px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Style="z-index: 1; left: 70px; top: 625px; position: absolute" Text="Edit" />
         <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Style="z-index: 1; left: 124px; top: 625px; position: absolute" Text="Delete" />
            <asp:Label ID="lblProductTitleFilter" runat="server" style="z-index: 1; left: 18px; top: 677px; position: absolute; width: 292px; height: 20px;" Text="Enter a Product Title"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 330px; top: 675px; position: absolute"></asp:TextBox>
            <p>
        <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 16px; top: 778px; position: absolute" width="120px"></asp:Label>
            </p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 16px; top: 723px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" height="26px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 140px; top: 723px; position: absolute" Text="Clear Filter" width="100px" />
             <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 440px; top: 723px; position: absolute" Text="Return to Main Menu" OnClick="btnReturn_Click" />
        </div>
    </form>
</body>
</html>
