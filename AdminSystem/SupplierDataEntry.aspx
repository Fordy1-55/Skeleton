<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 16px; top: 42px; position: absolute" Text="Supplier ID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 124px; top: 43px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 16px; top: 75px; position: absolute; width: 92px" Text="Supplier Name"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 124px; top: 76px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierContactEmail" runat="server" style="z-index: 1; left: 16px; top: 105px; position: absolute; width: 93px" Text="Contact Email"></asp:Label>
        <asp:TextBox ID="txtSupplierContactEmail" runat="server" style="z-index: 1; left: 124px; top: 105px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkAvailability" runat="server" style="z-index: 1; left: 124px; top: 228px; position: absolute" Text="Available" width="128px" />
        <asp:Label ID="lblSupplierAddDate" runat="server" style="z-index: 1; left: 16px; top: 197px; position: absolute; width: 99px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtSupplierAddDate" runat="server" style="z-index: 1; left: 124px; top: 194px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierContactPhone" runat="server" style="z-index: 1; left: 16px; top: 135px; position: absolute; width: 101px" Text="Contact Phone"></asp:Label>
        <asp:TextBox ID="txtSupplierContactPhone" runat="server" style="z-index: 1; left: 124px; top: 135px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierCity" runat="server" style="z-index: 1; left: 16px; top: 160px; position: absolute; height: 21px; width: 70px; bottom: 495px" Text="City"></asp:Label>
        <asp:TextBox ID="txtSupplierCity" runat="server" style="z-index: 1; left: 124px; top: 161px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 259px; position: absolute" width="70px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 17px; top: 297px; position: absolute; height: 26px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; top: 297px; position: absolute; left: 124px" Text="Cancel" height="26px" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" style="z-index: 1; left: 310px; top: 42px; position: absolute" Text="Find" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="BtnMainMenu" runat="server" OnClick="Button1_Click2" Text="Return to main menu" style="z-index: 1; left: 373px; top: 297px; position: absolute" height="26px"/>
        
        </p>
    </form>
</body>
</html>
