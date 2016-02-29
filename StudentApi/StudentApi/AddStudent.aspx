<%@ Page  MasterPageFile="~/Master.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="StudentApi.AddStudent" %>


<asp:content contentplaceholderid="CPH1" runat="server">

    
        <form id="form1" runat="server">
            <div>
                <div class="form-group row">
                    <h1 class="">Enter your student details and put you pants on :)</h1>
                </div>
                <br />


                <%--Add some bootstrap here--%>
                <div class="form-group row">
                    <asp:Label Text="Name: " runat="server" CssClass="col-sm-2 form-control-label" />
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
                    </div>
                    <div class="col-sm-3">
                        <asp:RequiredFieldValidator ErrorMessage="Please enter a name." ControlToValidate="txtName" runat="server" CssClass="alert-danger"/>
                    </div>
                </div>
                <br />

                <div class="form-group row">
                    <asp:Label Text="Faculty: " runat="server" CssClass="col-sm-2 form-control-label" />
                    <div class="col-sm-3">
                        <asp:DropDownList ID="toggleActiveBox" OnSelectedIndexChanged="toggleActiveBox_SelectedIndexChanged" runat="server" CssClass="form-control">

                            <asp:ListItem Text="Please select TU faculty" Selected="True" />
                            <asp:ListItem Text="FEET" Value="FEET" />
                            <asp:ListItem Text="FPEPM" Value="FPEPM" />
                            <asp:ListItem Text="FIT" Value="FIT" />
                            <asp:ListItem Text="FCSC" Value="FCSC" />
                            <asp:ListItem Text="FEE" Value="FEE" />

                        </asp:DropDownList>
                    </div>
                  
                </div>

                <br />

                <div class="form-group row">
                    <asp:Label Text="Faculty Number: " runat="server" CssClass="col-sm-2 form-control-label" />
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" ID="txtFacultyNumber" TextMode="Number" MaxLength="6" CssClass="form-control" />
                    </div>
                </div>
                <br />

                <div class="form-group row">
                    <asp:Label Text="Average Assessment:" runat="server" CssClass="col-sm-2 form-control-label" />
                    <div class="col-sm-3">
                        <asp:TextBox runat="server" TextMode="Number" ID="txtAssessment" step="0.01" CssClass="form-control" />
                    </div>
                </div>
                <br />
                <div class="form-group row">
                    <asp:Label Text="" ID="lblMessage" runat="server" CssClass="col-sm-5 form-control-label" />
                </div>
                <br />
                <div class="form-group row">
                    <asp:Button Text="Add" ID="btnAdd" runat="server" OnClick="btnAdd_Click" CssClass="btn btn-lg btn-primary col-sm-5" />
                </div>
            </div>
        </form>
    </div>
    </asp:content>
