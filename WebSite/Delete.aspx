<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Car</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>
        <asp:TextBox ID="txtDeleteCar" runat="server" style="z-index: 1; left: 723px; top: 207px; position: absolute; width: 420px; height: 37px; margin-bottom: 0px"></asp:TextBox>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 772px; top: 286px; position: absolute; width: 85px; height: 39px;" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 991px; top: 286px; position: absolute; height: 39px; bottom: 469px; width: 85px" Text="No" OnClick="btnNo_Click" />
        </h1>
        </div>
    </form>
</body>
</html>
