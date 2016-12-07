<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ass5.UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="loginForm" runat="server">
        <div>
            Username<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <div>
            Password<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
        </div>
    </form>
</body>
</html>
