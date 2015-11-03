<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Uploads.aspx.cs" Inherits="Uploads"%>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .auto-style6 {
        width: 858px;
        height: 569px;
            z-index: 1;
            left: 390px;
            top: 0px;
            position: relative;
        }
    .auto-style7 {
        width: 378px;
        height: 436px;
        margin-top: 0px;
    }
    .auto-style8 {
        height: 508px;
    }
    .auto-style10 {
        height: 508px;
        width: 417px;
    }
    .auto-style11 {
        width: 417px;
            height: 57px;
        }
    .auto-style12 {
        height: 59px;
        font-size: xx-large;
        background-color: #663300;
            font-family: "맑은 고딕", Arial, Helvetica, sans-serif;
        }
    .auto-style13 {
        height: 20px;
        background-color: #663300;
        font-family: "맑은 고딕", Arial, Helvetica, sans-serif;
        color: #FFFFFF;
    }
    .auto-style15 {
        height: 20px;
            background-color: #FFFFFF;
        }
    .auto-style16 {
        height: 19px;
        background-color: #663300;
        font-family: "맑은 고딕", Arial, Helvetica, sans-serif;
        color: #FFFFFF;
    }
    .auto-style18 {
        height: 21px;
        background-color: #663300;
        font-family: "맑은 고딕", Arial, Helvetica, sans-serif;
            color: #FFFFFF;
        }
        .auto-style19 {
            height: 57px;
        }
        .auto-style20 {
            background-color: #FFFFFF;
        }
        .auto-style21 {
            height: 23px;
            background-color: #FFFFFF;
        }
        .auto-style22 {
            height: 22px;
            background-color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="auto-style6">
    <tr>
        <td class="auto-style10">
            <table class="auto-style7">
                <tr>
                    <td class="auto-style12"><strong>Contents Information</strong></td>
                </tr>
                <tr>
                    <td class="auto-style13">시간적 배경 (DAY_TIME)</td>
                </tr>
                <tr>
                    <td class="auto-style20">                        
                        <asp:DropDownList ID="DayList" runat="server" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">시대적 배경 (ERA)</td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:DropDownList ID="EraList" runat="server" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">공간적 배경 (INANDOUT)</td>
                </tr>
                <tr>
                    <td class="auto-style21">
                        <asp:DropDownList ID="AreaList" runat="server" AutoPostBack="True" Height="16px"  Width="160px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style18">장소 배경 (PLACE)</td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:DropDownList ID="PlaceList" runat="server" AutoPostBack="True" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">계절 (SEASON)</td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        <asp:DropDownList ID="SeasonList" runat="server" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">연령대 (AGE)</td>
                </tr>
                <tr>
                    <td class="auto-style21">
                        <asp:DropDownList ID="AgeList" runat="server" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">성별 (SEX)</td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:DropDownList ID="SexList" runat="server" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">직종 (JOB_CATE1)</td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:DropDownList ID="JobCList" runat="server" Height="16px" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">직업 (JOB)</td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:DropDownList ID="JobList" runat="server" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">사건, 행동 (INCIDENT_CATE1)</td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:DropDownList ID="IncidCList" runat="server" AutoPostBack="True" Height="16px"  Width="160px" OnSelectedIndexChanged="IncidCList_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">사건, 행동 (INCIDENT)</td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:DropDownList ID="IncidList" runat="server" AutoPostBack="True" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </td>
        <td class="auto-style8">
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Upload" Width="82px" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style11">
&nbsp; </td>
        <td class="auto-style19">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>



