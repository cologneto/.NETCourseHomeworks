<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculate.aspx.cs" Inherits="WebApplication2.Calculate" %>

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
    <div>
         <h3>Calculating the Bugdet</h3>
  <div>
        <asp:DropDownList runat="server" ID ="toggleActivebox" OnSelectedIndexChanged="toggleActivebox_SelectedIndexChanged" AutoPostBack="true">
             <asp:ListItem Text="Please select" Value="0" />
        <asp:ListItem Text="Week" Value="7" />
        <asp:ListItem Text="Month" Value="30" />
        <asp:ListItem Text="Year" Value="365" />
    </asp:DropDownList>
      <br />
          <br />
       <asp:Label Text="Expenses sum: " runat="server" />
          <asp:Label Text="" runat="server" ID = "Sum" />
                        <br />
    </div>
   
    </div>
    </form>
</body>
</html>
