<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBatchProductionNo.aspx.cs" Inherits="AddBatchProductionNo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
     <link href="StyleSheetBackground.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h2>
        <span style="color:White;"><asp:Label ID="lblBatchProductionNo" runat="server" style="z-index: 1; left: 444px; top: 56px; position: absolute" Text="Batch Production"></asp:Label></span>
        <span style="color:White;"><asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 511px; top: 94px; position: absolute" Text="Car Model"></asp:Label></span>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 636px; top: 96px; position: absolute; width: 180px"></asp:TextBox>
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 633px; top: 144px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 546px; top: 148px; position: absolute; width: 47px" Text="Add" />
        </h2>
        </div>
        <asp:DropDownList ID="ddlBatchProduction" runat="server" Height="87px" style="margin-left: 624px" Width="166px">
        </asp:DropDownList>
    </form>
</body>
</html>
