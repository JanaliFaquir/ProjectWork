<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add/Edit Customer details</title>
     <link href="StyleSheetBackground.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h2>
        <span style="color:white;"><asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 655px; top: 211px; position: absolute; height: 25px; width: 140px" Text="First Name"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 657px; top: 265px; position: absolute; bottom: 393px;" Text="Surname"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 656px; top: 304px; position: absolute" Text="Email"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 655px; top: 357px; position: absolute; height: 19px; width: 42px; right: 608px;" Text="Street"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 651px; top: 404px; position: absolute" Text="Post Code"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 651px; top: 443px; position: absolute" Text="Town"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 655px; top: 650px; position: absolute; width: 65px;" Text="Active"></asp:Label></span>
        <span style="color:white;"><asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 855px; top: 636px; position: absolute; bottom: 58px;" Text="Yes" /></span>
        <span style="color:white;"><asp:CheckBox ID="ChkNo" runat="server" style="z-index: 1; left: 854px; top: 684px; position: absolute" Text="No" /></span>
        <span style="color:white;"><asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 652px; top: 493px; position: absolute; height: 24px; width: 112px;" Text="House No"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 649px; top: 545px; position: absolute; height: 24px; width: 112px;" Text="Phone No"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblDateSold" runat="server" style="z-index: 1; left: 647px; top: 593px; position: absolute; height: 24px; width: 112px;" Text="DateSold"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblError" runat="server" style="z-index: 1; left: 1073px; top: 691px; position: absolute; height: 24px; width: 112px;" Text="lblError"></asp:Label></span>
        <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 854px; top: 264px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 851px; top: 311px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 851px; top: 358px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 853px; top: 404px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 853px; top: 212px; position: absolute; width: 168px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 1150px; top: 479px; position: absolute; width: 75px; height: 39px;" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 1150px; top: 378px; position: absolute; width: 75px; height: 39px;" Text="OK" />
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 854px; top: 493px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" style="z-index: 1; left: 851px; top: 546px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtDateSold" runat="server" style="z-index: 1; left: 851px; top: 593px; position: absolute; width: 168px"></asp:TextBox>
        </h2>
        <asp:DropDownList ID="ddlTown"  runat="server" style="z-index: 1; left: 850px; top: 447px; position: absolute; width: 168px"></asp:DropDownList>>
        
    </form>
</body>
</html>
