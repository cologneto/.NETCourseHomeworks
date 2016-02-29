<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCountry.aspx.cs" Inherits="CountryStatistics.AddCountry" %>

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
        <asp:Label Text="Country: " runat="server" ID="lblCountry" />
        <asp:TextBox runat="server"  ID="txtCountry"/>
        <br />
        <br />
        <asp:Label Text="Capital:" runat="server"  ID="lblCapital"/>
        <asp:TextBox runat="server"  ID="txtCapital"/>
        <br />
        <br />
        <asp:Label Text="Population" ID="lblPopulation" runat="server" />
        <asp:TextBox runat="server" ID="txtPopulation" TextMode="Number"/>
        <br />
        <br />
        <asp:Label Text="" ID="lblMessage" runat="server" />
        <br />  
        <br />  
        <asp:Button Text="Add Country" ID="btnAdd" OnClick="btnAdd_Click" runat="server" />    
    </div>
    </form>
</body>
</html>
