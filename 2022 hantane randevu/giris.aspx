<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="_2022_hantane_randevu.giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700">
            <br />
            <asp:Label ID="Label1" runat="server" Text="İl seçiniz"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="drp_il" runat="server" Height="32px" Width="324px" OnSelectedIndexChanged="drp_il_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            &nbsp;
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Hastane seçiniz"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="drp_hastahane" runat="server" Height="32px" Width="324px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            &nbsp;
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="poliklinik seçiniz"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="drp_poliklinik" runat="server" Height="32px" Width="324px" AutoPostBack="True" OnSelectedIndexChanged="drp_poliklinik_SelectedIndexChanged"></asp:DropDownList>
            &nbsp;<br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Doktor seçiniz"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="drp_doktor" runat="server" Height="32px" Width="324px" AutoPostBack="True" OnSelectedIndexChanged="drp_doktor_SelectedIndexChanged"></asp:DropDownList>
            &nbsp;<br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Tarih seçiniz"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="drp_tarih" runat="server" Height="32px" Width="324px" AutoPostBack="True" OnSelectedIndexChanged="drp_tarih_SelectedIndexChanged"></asp:DropDownList>
            &nbsp;
            <br />
            <br />
            <asp:Button ID="btn_randevu" runat="server" Text="RANDEVU AL" Width="363px" OnClick="btn_randevu_Click" />
            <br />
            <br />
            </div>
    </form>
</body>
</html>
