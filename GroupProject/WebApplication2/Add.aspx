<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WebApplication2.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Budget system</title>
</head>
    
<body>
    <div>
        <asp:HyperLink NavigateURL="~/Add.aspx" runat="server" Text="Add new item" Tooltip="Adds new item in the file" />
        <asp:HyperLink NavigateURL="~/Calculate.aspx" runat="server" Text="Calculate items" Tooltip="Calculates all items" />
        <asp:HyperLink NavigateURL="~/ListAllExpenses.aspx" runat="server" Text="List all" Tooltip="Lists all items" />
    </div>
    <h3>Add new item</h3>
    <form id="form1" runat="server">
    <div>
    <asp:label Text="Date:" runat="server" />
        <asp:TextBox ID="DateTxtBox" runat="server" TextMode="Date" />
        <br />
        <br />
        <asp:Label Text="Product:" runat="server" />
        <asp:TextBox ID="productxt" runat="server" />
        <br />
        <br />
        <asp:Label Text="Price" runat="server" />
        <asp:TextBox ID="pricetxtbox" runat="server" TextMode="Number" step="0.01" />
        <br />
        <br />
        <asp:Button ID="importbutton" Text="Add/Import" runat="server" OnClick="importbutton_Click" />
        <asp:Label Text="" runat="server" ID="msglabel"/>
    </div>
    </form>
</body>
</html>
