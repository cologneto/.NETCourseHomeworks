<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCountries.aspx.cs" Inherits="CountryStatistics.SearchCountries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:HyperLink NavigateUrl="~/AddCountry.aspx" runat="server" Text="Add country to database" />
        <asp:HyperLink NavigateUrl="~/SearchCountries.aspx" runat="server" Text="Search" />
        <br />
        <br />
        <asp:Label Text="Search by Country name" runat="server" />
        <asp:TextBox runat="server" ID="txtSearchByCountryName"/>
        <br />
        <br />
        <asp:Label Text="Search by Capital Name" ID="lblSearchByCapitalName" runat="server" />
        <asp:TextBox runat="server"  ID="txtSearchByCapitalName"/>
        <br />  
        <br />

        <asp:Button Text="Search" runat="server" ID="btnSearch" OnClick="btnSearch_Click"/>
        <br />
        <br />
        <asp:Label Text="" ID="messageLabel" runat="server" />
        <asp:DataGrid runat="server" ID="myDataGrid">
            </asp:DataGrid>
    </div>
    </form>
</body>
</html>
