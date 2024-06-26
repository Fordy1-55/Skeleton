﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="364px" Width="518px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 30px" Text="Edit" />
            <asp:Button runat="server" Text="Delete" ID="btnDelete" OnClick="btnDelete_Click"></asp:Button>
        </p>
        <asp:Label ID="lblEnterName" runat="server" Text="Enter a Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" Height="16px" style="margin-left: 33px; margin-top: 2px" Width="154px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="margin-left: 19px" Text="Apply Filter" Width="93px" />
        <asp:Button ID="btnClear" runat="server" Height="26px" OnClick="btnClear_Click" style="margin-left: 22px" Text="Clear Filter" Width="100px" />
        <asp:Button ID="btnReturnToMain" runat="server" OnClick="btnReturnToMain_Click" style="margin-left: 35px" Text="Return to Main Menu" Width="169px" />
        <p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
