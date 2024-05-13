<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; width: 117px; height: 28px; right: 1032px" Text="Customer ID"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 131px; top: 30px; position: absolute; height: 17px" width="95px"></asp:TextBox>
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Customers Name" width="117px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 131px; top: 91px; position: absolute" width="95px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 131px; top: 197px; position: absolute" width="95px"></asp:TextBox>
            <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 7px; top: 199px; position: absolute" Text="Address" width="117px"></asp:Label>
        </p>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 9px; top: 150px; position: absolute" Text="Email" width="117px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 131px; top: 146px; position: absolute" width="95px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerTelephone" runat="server" style="z-index: 1; left: 9px; top: 251px; position: absolute" Text="Telephone Number"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerTelephone" runat="server" style="z-index: 1; left: 131px; top: 249px; position: absolute" width="95px"></asp:TextBox>
        <asp:Label ID="lblCustomerDOB" runat="server" style="z-index: 1; left: 13px; top: 299px; position: absolute" Text="Date Of Birth" width="117px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 131px; top: 296px; position: absolute" width="95px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkSubscription" runat="server" style="z-index: 1; left: 147px; top: 346px; position: absolute" Text="Subscription" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 166px; top: 406px; position: absolute" width="95px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 125px; top: 432px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 32px; top: 431px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
