<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
        width: 100%;
        height: 510px;
    }
    .auto-style4 {
        height: 42px;
    }
    .auto-style5 {
        height: 148px;
    }
        .auto-style6 {
            height: 243px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 724px; top: 413px; position: absolute; width: 250px; height: 20px"></asp:TextBox>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" Font-Size="Larger" style="z-index: 1; left: 993px; top: 411px; position: absolute; height: 85px; width: 99px" ForeColor="#666666" TabIndex="3" />
<asp:Label ID="Label1" runat="server" Text=" " style="z-index: 1; left: 464px; top: 436px; position: absolute" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<table class="auto-style3">
    <tr>
        <td class="auto-style5" colspan="3"><asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 723px; top: 463px; position: absolute; width: 250px; height: 20px" OnTextChanged="TextBox1_TextChanged" TextMode="Password"></asp:TextBox>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Registration.aspx" style="z-index: 1; left: 725px; top: 507px; position: absolute" TabIndex="2">Create New Account</asp:HyperLink>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="#996633" style="z-index: 1; left: 325px; top: 219px; position: absolute; font-size: 82pt; font-family: '맑은 고딕', Arial, Helvetica, sans-serif;" Text="NuxMediaCenter"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="Label2" runat="server" Font-Size="Larger" ForeColor="Gray" style="z-index: 1; left: 552px; top: 421px; position: absolute; height: 21px; width: 38px" Text="ID"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Size="Larger" ForeColor="Gray" style="z-index: 1; left: 552px; top: 469px; position: absolute" Text="PASSWORD"></asp:Label>
        </td>
        <td class="auto-style6"></td>
        <td class="auto-style6"></td>
    </tr>
    <tr>
        <td class="auto-style4"></td>
        <td class="auto-style4"></td>
        <td class="auto-style4"></td>
    </tr>
</table>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
</asp:Content>

