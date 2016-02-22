<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListAllExpenses.aspx.cs" Inherits="WebApplication2.ListAllExpenses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <asp:HyperLink NavigateURL="~/Add.aspx" runat="server" Text="Add new item" Tooltip="Adds new item in the file" />
        <asp:HyperLink NavigateURL="~/Calculate.aspx" runat="server" Text="Calculate items" Tooltip="Calculates all items" />
        <asp:HyperLink NavigateURL="~/ListAllExpenses.aspx" runat="server" Text="List all" Tooltip="Lists all items" />
    </div>
    <form id="form1" runat="server">
          <h3>Import all product</h3>
    <div>
      <asp:Repeater runat="server" ID="ProductsRepeater">
                <ItemTemplate>
                    <div class="Product-container">
                        Date:
                    <asp:Label Text='<%# Eval("Date") %>' runat="server" />
                        <br />
                        Product:
                    <asp:Label Text='<%# Eval("Item") %>' runat="server" />
                        <br />
                        Price:
                    <asp:Label Text='<%# Eval("Price") %>' runat="server" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>

    </div>
    </form>
</body>
</html>
