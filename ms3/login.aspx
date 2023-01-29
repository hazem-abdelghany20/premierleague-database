<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ms3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            please log in<br />
            <br />
        </div>
        username<br />
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <br />
        passwor<br />
        <asp:TextBox ID="password" runat="server"  style="margin-top: 0px" ></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="log_in" Text="log in" />
        <br />
    </form>
</body>
</html>
