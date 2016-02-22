<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_13.WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration form</title>
</head>


<body>
    <form id="form1" runat="server">
    <div style="">
        <p><asp:Label ID="lblName" Text="Name:" runat="server" AssociatedControlID="txtName" />
           <asp:TextBox ID="txtName" runat="server" />
            <asp:RequiredFieldValidator ID="valName" Text="Please enter your name." ControlToValidate="txtName" runat="server" />
        </p>
        <p><asp:Label ID="lblPassword" Text="Password:" runat="server" AssociatedControlID="txtPassword" />
           <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="valPassword" Text="Please enter password" ControlToValidate="txtPassword" runat="server" />
        </p>
        <p><asp:Label ID="lblRepeatPassword" Text="Repeat Password:" runat="server" AssociatedControlID="txtRepeatPassword" />
           <asp:TextBox ID="txtRepeatPassword" runat="server" TextMode="Password" />
        <asp:RequiredFieldValidator ID="valRepeatPassword" Text="Please reenter your password." ControlToValidate="txtRepeatPassword" runat="server" />

        </p>
        <p><asp:Label ID="lblAge" Text="Age:" runat="server" AssociatedControlID="txtAge" />
           <asp:TextBox ID="txtAge" runat="server" TextMode="Number" />
            <asp:RequiredFieldValidator Text="Please enter your age." ControlToValidate="txtAge" runat="server" />
        </p>
        <p><asp:Label ID="lblEmail" Text="Email:" runat="server" AssociatedControlID="txtEmail" />
           <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" />
            <asp:RequiredFieldValidator ID="valEmail" Text="Please enter your email: address" ControlToValidate="txtEmail" runat="server" />
        </p>
           <p><asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click"/></p>      
    </div>
    </form>
</body>
</html>
