<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACar.aspx.cs" Inherits="ACar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add/Edit Car Details</title>
    <link href="StyleSheetBackground.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <h2>
        <span style="color:white;"><asp:Label ID="lblCarName" runat="server" style="z-index: 1; left: 655px; top: 300px; position: absolute; height: 25px; width: 113px" Text="Car Name"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 655px; top: 350px; position: absolute" Text="Model"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblBodyType" runat="server" style="z-index: 1; left: 655px; top: 400px; position: absolute" Text="Body Type"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 655px; top: 450px; position: absolute; height: 19px; width: 38px" Text="Price"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblStock" runat="server" style="z-index: 1; left: 655px; top: 500px; position: absolute" Text="Stock"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblYearMade" runat="server" style="z-index: 1; left: 655px; top: 550px; position: absolute" Text="Year Made"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblFuel" runat="server" style="z-index: 1; left: 655px; top: 600px; position: absolute" Text="Fuel"></asp:Label></span>
        <span style="color:white;"><asp:CheckBox ID="chkDiesel" runat="server" style="z-index: 1; left: 855px; top: 600px; position: absolute; bottom: 49px;" Text="Diesel" Checked="True" /></span>
        <span style="color:white;"><asp:CheckBox ID="chkPetrol" runat="server" style="z-index: 1; left: 855px; top: 650px; position: absolute" Text="Petrol" Checked="False" /></span>
        <span style="color:white;"><asp:Label ID="lblColourNo" runat="server" style="z-index: 1; left: 655px; top: 700px; position: absolute; height: 24px; width: 112px;" Text="Colour No"></asp:Label></span>
        <span style="color:white;"><asp:Label ID="lblError" runat="server" style="z-index: 1; left: 655px; top: 750px; position: absolute" Text="lblError"></asp:Label></span>
        <asp:DropDownList ID="ddlColourNo" runat="server" style="z-index: 1; left: 855px; top: 700px; position: absolute; height: 17px; width: 148px">
        </asp:DropDownList>
        <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 855px; top: 350px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtBodyType" runat="server" style="z-index: 1; left: 855px; top: 400px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 855px; top: 450px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtStock" runat="server" style="z-index: 1; left: 855px; top: 500px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtYearMade" runat="server" style="z-index: 1; left: 855px; top: 550px; position: absolute; width: 168px"></asp:TextBox>
        <asp:TextBox ID="txtCarName" runat="server" style="z-index: 1; left: 855px; top: 300px; position: absolute; width: 168px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 1150px; top: 479px; position: absolute; width: 75px; height: 39px;" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 1150px; top: 378px; position: absolute; width: 75px; height: 39px;" Text="OK" OnClick="btnOK_Click" />
        </h2>
    </form>

</body>
</html>
