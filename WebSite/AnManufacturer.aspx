<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnManufacturer.aspx.cs" Inherits="AnManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add edit manufacturer</title>
     <link href="StyleSheetBackground.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
        <span style="color:white;"><asp:Label ID="lblYearMade" runat="server" style="z-index: 1; left: 655px; top: 300px; position: absolute; height: 25px; width: 150px" Text="Year Made"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblChairMan" runat="server" style="z-index: 1; left: 655px; top: 350px; position: absolute" Text="Chair Man"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblCarModel" runat="server" style="z-index: 1; left: 655px; top: 400px; position: absolute" Text="Car Model"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 655px; top: 450px; position: absolute; height: 19px; width: 38px" Text="Email"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 655px; top: 500px; position: absolute" Text="PhoneNo"></asp:Label></span>
        <span style="color:white;"><asp:CheckBox ID="ChkAvailable" runat="server" style="z-index: 1; left: 858px; top: 552px; position: absolute" Text="Available" /></span>
        <span style="color:white;"><asp:CheckBox ID="ChkNotAvailable" runat="server" style="z-index: 1; left: 855px; top: 585px; position: absolute; width: 164px;" Text="Not Available" /></span>
         <span style="color:white;"><asp:Label ID="lblBatchProductionNo" runat="server" style="z-index: 1; left: 606px; top: 700px; position: absolute; height: 24px; width: 224px;" Text="Batch Production No"></asp:Label></span>
        <asp:TextBox ID="txtChairMan" runat="server" style="z-index: 1; left: 855px; top: 350px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtCarModel" runat="server" style="z-index: 1; left: 855px; top: 400px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 855px; top: 450px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 855px; top: 500px; position: absolute; width: 168px; bottom: 142px;"></asp:TextBox>
        <asp:TextBox ID="txtYearMade" runat="server" style="z-index: 1; left: 855px; top: 300px; position: absolute; width: 168px"> </asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 1150px; top: 479px; position: absolute; width: 75px; height: 39px;" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 1150px; top: 378px; position: absolute; width: 75px; height: 39px;" Text="OK" OnClick="btnOK_Click" />
        <asp:DropDownList ID="ddlBatchProduction" runat="server" style="z-index: 1; left: 858px; position: absolute; height: 17px; width: 159px; top: 696px;"></asp:DropDownList>
        </h2>
        </div>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 655px; top: 748px; position: absolute; height: 25px; width: 66px" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
