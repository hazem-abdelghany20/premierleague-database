<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ms3.home" %>

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
       
        <asp:Button ID="Button1" runat="server" OnClick="clubrep" Text="club representative" />
        <asp:Button ID="Button2" runat="server" OnClick="manager" Text="stadium manager" />
        <br />
    </form>
</body>
</html>
