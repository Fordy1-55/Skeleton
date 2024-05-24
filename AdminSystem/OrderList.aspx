<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 585px">
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 432px; width: 396px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 459px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 85px; top: 459px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 497px; top: 180px; position: absolute" Text="lblError"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 147px; top: 458px; position: absolute" Text="Delete" />
            <asp:Label ID="lblOrderDescriptionFilter" runat="server" style="z-index: 1; left: 29px; top: 544px; position: absolute; right: 1401px;" Text="Enter an Order Description"></asp:Label>
            <asp:TextBox ID="txtOrderDescriptionFilter" runat="server" style="z-index: 1; left: 202px; top: 543px; position: absolute" ></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server"  style="z-index: 1; left: 24px; top: 575px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; top: 575px; position: absolute; left: 183px" Text="Clear Filter" />
        </div>
    </form>
</body>
</html>
