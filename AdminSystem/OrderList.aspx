<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 360px; top: 575px; position: absolute" Text="Return to Main Menu" />
        <div style="height: 585px">
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 7px; top: 50px; position: absolute; height: 432px; width: 396px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 19px; top: 486px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 84px; top: 486px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 497px; top: 180px; position: absolute" Text="lblError"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 144px; top: 486px; position: absolute" Text="Delete" />
            <asp:Label ID="lblOrderDescriptionFilter" runat="server" style="z-index: 1; left: 15px; top: 540px; position: absolute; right: 1592px;" Text="Enter an Order Description"></asp:Label>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 24px; top: 575px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; top: 575px; position: absolute; left: 183px" Text="Clear Filter" />
            <asp:TextBox ID="txtOrderDescriptionFilter" runat="server" style="z-index: 1; left: 202px; top: 543px; position: absolute" ></asp:TextBox>
        </div>
    </form>
</body>
</html>
