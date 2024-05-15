<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 370px; top: 27px; position: absolute" Text="Find" OnClick="btnFind_Click1" />
        <div>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 11px; top: 28px; position: absolute" Text="Order ID" width="123px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server"  style="z-index: 1; left: 148px; top: 28px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblOrderDescription" runat="server" style="z-index: 1; left: 11px; top: 65px; position: absolute; bottom: 790px" Text="Order Description" width="123px"></asp:Label>
            <asp:TextBox ID="txtOrderDescription" runat="server" style="z-index: 1; left: 148px; top: 64px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateOrdered" runat="server" style="z-index: 1; left: 11px; top: 104px; position: absolute" Text="Date Ordered" width="123px"></asp:Label>
        <asp:TextBox ID="txtDateOrdered" runat="server" style="z-index: 1; left: 148px; top: 101px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 148px; top: 139px; position: absolute"></asp:TextBox>
        <p style="height: 24px">
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 11px; top: 142px; position: absolute" Text="Price" width="123px"></asp:Label>
        </p>
        <p style="height: 24px">
            <asp:Label ID="lblReturnAddress" runat="server" style="z-index: 1; left: 11px; top: 182px; position: absolute" Text="Return Address" width="123px"></asp:Label>
        </p>
        <asp:TextBox ID="txtReturnAddress" runat="server" style="z-index: 1; left: 148px; top: 180px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDeliveryInstructions" runat="server" style="z-index: 1; left: 11px; top: 221px; position: absolute; height: 18px" Text="Delivery Instructions"></asp:Label>
        <p>
            <asp:TextBox ID="txtDeliveryInstructions" runat="server" style="z-index: 1; left: 148px; top: 219px; position: absolute"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkOverseas" runat="server" style="z-index: 1; left: 148px; top: 253px; position: absolute; height: 18px" Text="Overseas" width="123px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 347px; top: 124px; position: absolute" width="123px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 311px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server"  style="z-index: 1; top: 311px; position: absolute; left: 84px" Text="Cancel" />
    </form>
</body>
</html>
