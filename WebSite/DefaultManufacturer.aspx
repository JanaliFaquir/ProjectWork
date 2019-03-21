<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultManufacturer.aspx.cs" Inherits="DefaultManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
     <link href="StyleSheetBackground.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <span style="color:white;"><asp:Label ID="lblCarAuction" runat="server" style="z-index: 1; left: 853px; top: 156px; position: absolute; width: 176px;" Text="Car Auction"></asp:Label></span>
            </h1>
        <h2>
        <asp:Button ID="btnAddManufacturer" runat="server" style="z-index: 1; left:663px; top: 223px; position: absolute; width: 127px; height: 35px;" Text="Add Manufacturer" OnClick="btnAddManufacturer_Click1" />
        <asp:Button ID="btnUpdateManufacturerDetails" runat="server" style="z-index: 1; left: 867px; top: 223px; position: absolute; height: 35px; width: 173px;" Text="Update Manufacturer Details" OnClick="btnUpdateManufacturerDetails_Click" />
        <asp:Button ID="btnDeleteManufacturer" runat="server" style="z-index: 1; left: 1100px; top: 223px; position: absolute; height: 35px; width: 139px;" Text="Delete Manufacturer" OnClick="btnDeleteManufacturer_Click" />
        <asp:TextBox ID="txtManufacturerID" runat="server" style="z-index: 1; left: 751px; top: 325px; position: absolute; width: 306px; height: 36px; margin-bottom: 0px"></asp:TextBox>
        <span style="color:White;"><asp:Label ID="lblManufacturerID" runat="server" style="z-index: 1; left: 785px; top: 281px; position: absolute; width: 362px" Text="Please search by Manufacturer ID"></asp:Label></span>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 1087px; top: 325px; position: absolute; width: 75px; height: 39px;" Text="Apply" />
        <asp:ListBox ID="lstManufacturers" runat="server" style="z-index: 1; left: 685px; top: 390px; position: absolute; height: 289px; width: 531px"></asp:ListBox>
        <asp:Button ID="btnDisplayAllManufacturer" runat="server" style="z-index: 1; left: 872px; top: 713px; position: absolute; height: 39px; width: 176px;" Text="Display All Manufacturers" />
        </h2>
             <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 655px; top: 748px; position: absolute; height: 25px; width: 66px" Text="lblError"></asp:Label>
        </p>

        </div>
    </form>
        </body>
</html>
