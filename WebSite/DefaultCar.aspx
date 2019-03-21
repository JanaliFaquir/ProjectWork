<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultCar.aspx.cs" Inherits="DefaultCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default page for car</title>
     <link href="StyleSheetBackground.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <span style="color:white;"><asp:Label ID="lblCarAuction" runat="server" style="z-index: 1; left: 853px; top: 156px; position: absolute; width: 176px;" Text="Car Auction"></asp:Label></span>
            </h1>
        <h2>
        <asp:Button ID="btnAddCar" runat="server" style="z-index: 1; left:700px; top: 223px; position: absolute; width: 90px; height: 35px;" Text="Add Car" OnClick="btnAddCar_Click" />
        <asp:Button ID="btnUpdateCarDetails" runat="server" style="z-index: 1; left: 875px; top: 223px; position: absolute; height: 35px; width: 165px;" Text="Update Car Details" OnClick="btnUpdateCarDetails_Click" />
        <asp:Button ID="btnDeleteCar" runat="server" style="z-index: 1; left: 1100px; top: 223px; position: absolute; height: 35px; width: 100px;" Text="Delete Car" OnClick="btnDeleteCar_Click" />
        <asp:TextBox ID="txtmodel" runat="server" style="z-index: 1; left: 751px; top: 325px; position: absolute; width: 306px; height: 36px; margin-bottom: 0px"></asp:TextBox>
        <span style="color:White;"><asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 785px; top: 281px; position: absolute; width: 362px" Text="Please search by Model of the car"></asp:Label></span>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 1087px; top: 325px; position: absolute; width: 75px; height: 39px;" Text="Apply" />
        <asp:ListBox ID="lstCars" runat="server" style="z-index: 1; left: 685px; top: 390px; position: absolute; height: 289px; width: 531px"></asp:ListBox>
        <asp:Button ID="btnDisplayAllCars" runat="server" style="z-index: 1; left: 872px; top: 713px; position: absolute; height: 39px; width: 176px;" Text="Display All Cars" />
        <span style="color:white;"><asp:Label ID="lblError" runat="server" style="z-index: 1; left: 685px; top: 800px; position: absolute" Text="lblError"></asp:Label></span>
        </h2>
        </div>
    </form>
        </body>
</html>