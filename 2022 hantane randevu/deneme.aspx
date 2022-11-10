<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deneme.aspx.cs" Inherits="_2022_hantane_randevu.deneme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" style="height: 29px" />
            <br />
            <br />
            <asp:TextBox ID="tctxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:TextBox ID="sifretxt" runat="server"></asp:TextBox>
            &nbsp;<br />
            <br />
            <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
