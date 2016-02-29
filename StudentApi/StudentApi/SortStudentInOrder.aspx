<%@ Page MasterPageFile="~/Master.Master" Language="C#" AutoEventWireup="true" CodeBehind="SortStudentInOrder.aspx.cs" Inherits="StudentApi.SortStudentInOrder" %>

<asp:content contentplaceholderid="CPH1" runat="server">
    <form id="form1" runat="server">
        <div>
            <h1>Sort students by Average Assessment</h1>
            <asp:Label Text="Please select order type:" runat="server" />

            <asp:DropDownList runat="server" ID="ddlOrder" OnSelectedIndexChanged="ddlOrder_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Please select order type..." />
                <asp:ListItem Text="Descending" Value="Descending" />
                <asp:ListItem Text="Accending" Value="Accending" />
            </asp:DropDownList>

            <br />
            <br />

            <asp:DataGrid runat="server" ID="myDataGrid">
            </asp:DataGrid>

        </div>
    </form>
</asp:content>
