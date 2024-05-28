<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 423px;
        }
    </style>
</head>
<body style="height: 581px">
    <form id="form1" runat="server">
        <div style="height: 416px">
            <asp:Label ID="lblProductId" runat="server" height="19px" style="z-index: 1; left: 12px; top: 19px; position: absolute" Text="Product ID" width="121px"></asp:Label>
            <asp:Button ID="BTNfIND" runat="server" OnClick="BTNfIND_Click" style="z-index: 1; left: 380px; top: 16px; position: absolute; width: 64px" Text="Find" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtProductTitle" runat="server" height="22px" style="z-index: 1; left: 177px; top: 72px; position: absolute" width="128px" OnTextChanged="txtProductTitle_TextChanged"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtProductId" runat="server" height="22px" style="z-index: 1; left: 177px; top: 14px; position: absolute" width="128px" OnTextChanged="txtProductId_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductDescription" runat="server" height="19px" style="z-index: 1; left: 12px; top: 145px; position: absolute; width: 127px;" Text="Product Description"></asp:Label>
        <asp:TextBox ID="txtProductDescription" runat="server" height="22px" style="z-index: 1; left: 177px; top: 137px; position: absolute; bottom: 709px;" width="128px" OnTextChanged="txtProductDescription_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblProductColour" runat="server" style="z-index: 1; left: 12px; top: 214px; position: absolute" Text="Product Colour" width="121px"></asp:Label>
        <br />
        <asp:TextBox ID="txtProductColour" runat="server" height="22px" style="z-index: 1; left: 177px; top: 207px; position: absolute" width="128px" OnTextChanged="txtProductColour_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblProductPrice" runat="server" height="19px" style="z-index: 1; left: 12px; top: 281px; position: absolute" Text="Product Price" width="121px"></asp:Label>
        <asp:TextBox ID="txtProductPrice" runat="server" height="22px" style="z-index: 1; left: 177px; top: 275px; position: absolute; margin-bottom: 1px" width="128px" OnTextChanged="txtProductPrice_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblProductDate" runat="server" height="19px" style="z-index: 1; left: 8px; top: 350px; position: absolute" Text="Product Date" width="121px"></asp:Label>
        <asp:TextBox ID="txtProductDate" runat="server" Height="22px" Style="z-index: 1; left: 177px; top: 343px; position: absolute" Width="128px" OnTextChanged="txtProductDate_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:CheckBox ID="ChkAvaible" runat="server" style="z-index: 1; left: 197px; top: 404px; position: absolute" Text="Available" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 447px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="lblProductTitle" runat="server" style="z-index: 1; left: 12px; top: 81px; position: absolute; height: 19px" Text="Product Title" width="121px"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" height="26px" OnClick="btnOk_Click" style="z-index: 1; left: 13px; top: 492px; position: absolute" Text="Ok" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 96px; top: 492px; position: absolute" Text="Cancel" height="26px" width="60px" />
    </form>
</body>
</html>
