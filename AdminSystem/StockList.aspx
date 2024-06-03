<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            font-family: Arial;
            background: #bababa;
            height: 879px;
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 49px; top: 50px; position: absolute; height: 404px; width: 451px" BackColor="#EEEEEE"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 48px; top: 485px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Style="z-index: 1; left: 110px; top: 486px; position: absolute" Text="Edit" />
         <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Style="z-index: 1; left: 173px; top: 486px; position: absolute" Text="Delete" />
            <asp:Label ID="lblProductTitleFilter" runat="server" style="z-index: 1; left: 49px; top: 544px; position: absolute; width: 292px; height: 20px; right: 1273px;" Text="Enter a Product Title"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 265px; top: 543px; position: absolute"></asp:TextBox>
            <p>
        <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 16px; top: 703px; position: absolute" width="120px"></asp:Label>
            </p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 43px; top: 603px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" height="26px" OnClick="btnClearFilter_Click" style="z-index: 1; left: 182px; top: 604px; position: absolute; right: 1332px;" Text="Clear Filter" width="100px" />
             <asp:Button ID="btnReturn" runat="server" style="z-index: 1; left: 385px; top: 603px; position: absolute" Text="Return to Main Menu" OnClick="btnReturn_Click" />
        </div>
    </form>
</body>
</html>
