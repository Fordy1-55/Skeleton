<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0;
        }
        .auto-style2 {
            margin-top: 0px;
            padding: 1px 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" Height="214px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="262px"></asp:ListBox>
        <p class="auto-style1" style="margin-left: 80px">
            <asp:Button ID="BtnAdd" runat="server" OnClick="Button1_Click" Text="Add" CssClass="auto-style2" height="32px" width="41px" />
            <asp:Button ID="btnEdit" runat="server" CssClass="auto-style2" height="32px" OnClick="btnEdit_Click" style="margin-bottom: 2px" Text="Edit" />
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            &nbsp;</p>
    </form>
</body>
</html>
