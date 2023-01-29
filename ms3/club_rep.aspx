<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="club_rep.aspx.cs" Inherits="ms3.club_rep1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            please register<br />
            <br />
        </div>
        name<br />
        <asp:TextBox ID="repname" runat="server"></asp:TextBox>
        <br />
        clubname<br />
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sqlDataSource1" DataTextField="name" DataValueField="name">
            <asp:ListItem>-- select --</asp:ListItem>
        </asp:DropDownList>
        <asp:sqlDataSource ID="sqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=premierleague;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" ProviderName="System.Data.SqlClient" SelectCommand="select [name] from [club]"></asp:sqlDataSource>       <br />
         username<br />
        <asp:TextBox ID="username" runat="server"  style="margin-top: 0px" ></asp:TextBox>
        <br />
         password<br />
        <asp:TextBox ID="password" runat="server"  style="margin-top: 0px" ></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="register" Text="register" />
        <br /><br />

        <br /><br /><asp:Button ID="Button2" runat="server" OnClick="viewclub" Text="view information about club" />
        <br />
        <asp:GridView ID="GridView1" runat="server"> </asp:GridView><br /><br />
          club name<br />
        <asp:TextBox ID="clubupcoming" runat="server"  style="margin-top: 0px" ></asp:TextBox>
        <br /><br /><asp:Button ID="Button3" runat="server" OnClick="upcomingmatches" Text="upcoming matches" />
        <br />
        <asp:GridView ID="GridView2" runat="server"> </asp:GridView><br /><br />
        date<br />
        <asp:TextBox ID="stadium" runat="server"  style="margin-top: 0px" ></asp:TextBox>
        <br /><br /><asp:Button ID="Button4" runat="server" OnClick="availablestadiums" Text="check availablity" />
        <br />
        <asp:GridView ID="GridView3" runat="server"> </asp:GridView>
        <br /><br /><br />
        stadiumname<br />
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="sqlDataSource2" DataTextField="name" DataValueField="name">
            <asp:ListItem>-- select --</asp:ListItem>
        </asp:DropDownList>
        <asp:sqlDataSource ID="sqlDataSource2" runat="server" ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=premierleague;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" ProviderName="System.Data.SqlClient" SelectCommand="select [name] from [stadium]"></asp:sqlDataSource>       <br />
         
        date<br />
        <asp:TextBox ID="matchdate" runat="server"  style="margin-top: 0px" ></asp:TextBox>
        
        <asp:Button ID="Button5" runat="server" OnClick="addhostrequest" Text="add request" />
    </form>
</body>
</html>
