<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="_2022_hantane_randevu.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="AD"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="39px" OnTextChanged="TextBox1_TextChanged" Width="401px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="SOYAD"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Height="39px" OnTextChanged="TextBox1_TextChanged" Width="401px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="EMAİL"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Height="39px" OnTextChanged="TextBox1_TextChanged" Width="401px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="ŞİFRE"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" Height="39px" OnTextChanged="TextBox1_TextChanged" Width="401px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="TC"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox5" runat="server" Height="39px" OnTextChanged="TextBox1_TextChanged" Width="401px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="33px" Text="KAYIT OL" Width="406px" OnClick="Button1_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
