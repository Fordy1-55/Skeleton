<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
           text-align:left;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstSupplierList" runat="server" Height="240px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="285px"></asp:ListBox>
            <asp:Button ID="btnEdit" runat="server" CssClass="auto-style2" style="z-index: 1; left: 111px; top: 312px; position: absolute" Text="Edit" height="26px" width="55px" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 105px; top: 273px; position: absolute"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 207px; top: 312px; position: absolute" Text="Delete" />
            <asp:Button ID="BtnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 17px; top: 312px; position: absolute; right: 1391px; height: 26px;" Text="Add" width="55px" />
        </div>
        
        <asp:Button ID="BtnApplyFltr" runat="server" OnClick="BtnApplyFltr_Click" style="z-index: 1; left: 31px; top: 420px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFltr" runat="server" OnClick="btnClearFltr_Click" style="z-index: 1; left: 169px; top: 421px; position: absolute" Text="ClearFilter" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 30px; top: 374px; position: absolute" Text="Enter a City:"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 131px; top: 374px; position: absolute"></asp:TextBox>
        <asp:Button ID="BtnMainMenu" runat="server" OnClick="Button1_Click2" Text="Return to main menu" style="z-index: 1; left: 347px; top: 312px; position: absolute"/>
        
    </form>
</body>
</html>
