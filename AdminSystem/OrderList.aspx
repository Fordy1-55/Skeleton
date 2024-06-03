<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            background-color: #CCFFCC;
        }
    </style>
</head>
<body style="height: 568px; width: 1125px; background-color: #99FF99">
    <form id="form1" runat="server">
        <div style="height: 573px; background-color: #99FF99;">
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 28px; top: 35px; position: absolute; height: 432px; width: 396px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 31px; top: 513px; position: absolute; height: 33px; width: 75px;" Text="Add" CssClass="auto-style2" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; top: 339px; position: absolute; left: 536px; width: 80px;" Text="Clear Filter" CssClass="auto-style2" height="22px" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 447px; top: 376px; position: absolute; height: 26px;" Text="Return to Main Menu" CssClass="auto-style2" width="166px" />
            <asp:TextBox ID="txtOrderDescriptionFilter" runat="server" style="z-index: 1; left: 444px; top: 296px; position: absolute; height: 26px; width: 166px;" ></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 447px; top: 92px; position: absolute" Text="lblError"></asp:Label>
            <asp:Label ID="lblOrderDescriptionFilter" runat="server" style="z-index: 1; left: 447px; top: 264px; position: absolute; right: 233px; height: 23px; text-decoration: underline; font-family: Georgia, 'Times New Roman', Times, serif;" Text="Enter an Order Description"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 443px; top: 339px; position: absolute; height: 22px; width: 80px; right: 614px;" Text="Apply Filter" CssClass="auto-style2" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 189px; top: 513px; position: absolute; height: 33px; width: 75px;" Text="Edit" CssClass="auto-style2" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 345px; top: 513px; position: absolute; height: 33px; width: 75px;" Text="Delete" CssClass="auto-style2" />
            </p>
    </form>
</body>
</html>
