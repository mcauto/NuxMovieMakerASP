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
    <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 458px; top: 459px; position: absolute; width: 245px; height: 20px"></asp:TextBox>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" Font-Size="Larger" style="z-index: 1; left: 727px; top: 405px; position: absolute; height: 85px; width: 99px" ForeColor="#666666" />
<asp:Label ID="Label1" runat="server" Text=" " style="z-index: 1; left: 464px; top: 436px; position: absolute" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx" style="z-index: 1; left: 891px; top: 439px; position: absolute">HyperLink</asp:HyperLink>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<table class="auto-style3">
    <tr>
        <td class="auto-style5" colspan="3"><asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 458px; top: 409px; position: absolute; width: 245px; height: 20px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="#996633" style="z-index: 1; left: 513px; top: 259px; position: absolute" Text="NuxMovieMaker"></asp:Label>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Registration.aspx" style="z-index: 1; left: 557px; top: 526px; position: absolute">Create New Account</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:Label ID="Label2" runat="server" Font-Size="Larger" ForeColor="Gray" style="z-index: 1; left: 350px; top: 409px; position: absolute; height: 21px; width: 38px" Text="ID"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Size="Larger" ForeColor="Gray" style="z-index: 1; left: 294px; top: 463px; position: absolute" Text="PASSWORD"></asp:Label>
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
    username: kim <br />
    password: 110 <br />
<br />
    username: son <br />
    password: 4916
<br />
<br />
</asp:Content>

