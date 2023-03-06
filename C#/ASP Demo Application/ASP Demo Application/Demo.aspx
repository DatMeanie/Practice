<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="ASP_Demo_Application.Demo" %>

<%@ Register Src="~/WebUserControl.ascx" TagName="WebControl" TagPrefix="TWebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <TWebControl:WebControl ID="Header" runat="server" />
        <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label>
        <p>
            <asp:TextBox ID="NameTxtbox" runat="server"></asp:TextBox>
        </p>
        <asp:ListBox ID="LocationLstbox" runat="server">
            <asp:ListItem>Stockholm</asp:ListItem>
            <asp:ListItem>Berlin</asp:ListItem>
            <asp:ListItem>Tokyo</asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:RadioButton ID="MaleRadioBtn" runat="server" Text="Male" />
        </p>
        <asp:RadioButton ID="FemaleRadioBtn" runat="server" Text="Female" />
        <p>
            <asp:CheckBox ID="ASPChkBox" runat="server" Text="ASP" />
        </p>
        <asp:CheckBox ID="CChkBox" runat="server" Text="C#" />
        <p>
            <asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>
