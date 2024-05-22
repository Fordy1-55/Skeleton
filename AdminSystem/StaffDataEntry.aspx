<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="StaffDataEntryForm" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 9px; top: 38px; position: absolute; height: 19px; width: 70px;" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 84px; top: 34px; position: absolute; width: 111px; height: 22px"></asp:TextBox>
        
        <p>
            <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 17px; top: 67px; position: absolute; height: 19px; width: 120px" Text="Role"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtRole" runat="server" OnTextChanged="txtRole_TextChanged" style="z-index: 1; left: 84px; top: 61px; position: absolute; height: 22px; width: 111px"></asp:TextBox>
            <asp:Label ID="lblName" runat="server" height="19px" style="z-index: 1; left: 12px; top: 105px; position: absolute" Text="Name" width="120px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 84px; top: 104px; position: absolute; width: 111px; height: 22px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtShiftType" runat="server" OnTextChanged="txtShiftType_TextChanged" style="z-index: 1; left: 84px; top: 132px; position: absolute; width: 111px; height: 22px; bottom: 710px; margin-top: 9px"></asp:TextBox>
            <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 13px; top: 176px; position: absolute; height: 19px; margin-top: 6px" Text="StartDate" width="120px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblShiftType" runat="server" height="19px" style="z-index: 1; left: 12px; top: 140px; position: absolute" Text="Shift Type" width="120px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkManagerStatus" runat="server" style="z-index: 1; left: 135px; top: 254px; position: absolute" Text="Manager" />
        </p>
        <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 84px; top: 183px; position: absolute; width: 111px"></asp:TextBox>
        <asp:Label ID="lblPerformanceTarget" runat="server" style="z-index: 1; left: 15px; top: 218px; position: absolute" Text="Performance Target"></asp:Label>
        <asp:Label ID="lblManagerStatus" runat="server" height="19px" style="z-index: 1; left: 13px; top: 255px; position: absolute" Text="Manager Status" width="120px"></asp:Label>
        <asp:CheckBox ID="chkPerformanceTarget" runat="server" style="z-index: 1; left: 149px; top: 217px; position: absolute; bottom: 438px" Text="Met" />
        <asp:Label ID="lblError" runat="server" height="19px" style="z-index: 1; left: 25px; top: 353px; position: absolute" width="120px"></asp:Label>
        <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" style="z-index: 1; left: 23px; top: 299px; position: absolute" Text="Enter" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 102px; top: 299px; position: absolute; height: 25px; width: 56px" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" style="margin-left: 189px" Text="Find" Width="97px" OnClick="btnFind_Click1" />
        </p>
    </form>
</body>
</html>
