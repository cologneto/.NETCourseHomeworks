<%@ Page MasterPageFile="~/Master.Master" Language="C#" AutoEventWireup="true" CodeBehind="SearchByFaculty.aspx.cs" Inherits="StudentApi.SearchByFaculty" %>

<asp:content contentplaceholderid="CPH1" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <asp:DropDownList ID="ddlFaculty" OnSelectedIndexChanged="ddlFaculty_SelectedIndexChanged" AutoPostBack="true" runat="server">

                <asp:ListItem Text="Please select TU faculty" Selected="True" />
                <asp:ListItem Text="FEET" Value="FEET" />
                <asp:ListItem Text="FPEPM" Value="FPEPM" />
                <asp:ListItem Text="FIT" Value="FIT" />
                <asp:ListItem Text="FCSC" Value="FCSC" />
                <asp:ListItem Text="FEE" Value="FEE" />

            </asp:DropDownList>
            <br />
            <br />
            <asp:Repeater runat="server" ID="studentsRepeater">
                <ItemTemplate>
                    <div class="book-container">
                        Name:
                    <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                        <br />
                        Faculty:
                    <asp:Label Text='<%# Eval("Faculty") %>' runat="server" />
                        <br />
                        Faculty Number:
                    <asp:Label Text='<%# Eval("FacultyNumber") %>' runat="server" />
                        <br />
                        Assessment:
                    <asp:Label Text='<%# Eval("AverageAssessment") %>' runat="server" />

                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </form>
</asp:content>