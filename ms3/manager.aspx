<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manager.aspx.cs" Inherits="ms3.manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            register<br />
        </div>
        <p>
            name</p>
        <p>
            <asp:TextBox ID="managername" runat="server"></asp:TextBox>
        </p>
        <p>
            username</p>
        <p>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
        </p>
        <p>
            password</p>
        <p>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>

        </p>
        <p>
            existing stadium</p>
        <p>
           <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sqlDataSource1" DataTextField="name" DataValueField="name">
            <asp:ListItem>-- select --</asp:ListItem>
        </asp:DropDownList>
        <asp:sqlDataSource ID="sqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=premierleague;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" ProviderName="System.Data.SqlClient" SelectCommand="select [name] from [stadium]"></asp:sqlDataSource>       
         
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="register" Text="register" />   <asp:Button ID="Button2" runat="server" OnClick="viewstadium" Text="view your stadium" /> 
            <br />
        <asp:GridView ID="GridView1" runat="server"> </asp:GridView><br /><br />
            <asp:Button ID="Button3" runat="server" OnClick="requestsbymanager" Text="view requests" />
            <asp:GridView ID="GridView2" runat="server"> </asp:GridView><br /><br />
         
            <p>
            choose a request to accept or reject</p>
            <asp:TextBox ID="unhandledreqs" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" OnClick="acceptreq" Text="accept it" /> <asp:Button ID="Button5" runat="server" OnClick="rejectreq" Text="reject it" />
                    </p>
    </form>
</body>
</html>
