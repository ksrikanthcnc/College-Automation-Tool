<%@ Page Language="C#" MasterPageFile="~/ACCOUNTS.master" AutoEventWireup="true" CodeFile="CERTIFICATE ISSUES.aspx.cs" Inherits="CERTIFICATE_ISSUES" Title="CERTIFICATE ISSUES" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
            width: 205px;
        }
    .style6
    {
        height: 25px;
    }
    .style7
    {
            width: 205px;
            height: 25px;
        }
        .style10
        {
            height: 47px;
        }
        .style11
        {
            width: 205px;
            height: 47px;
        }
        .style14
        {
            height: 39px;
        }
        .style15
        {
            width: 205px;
            height: 39px;
        }
        .style16
        {
            height: 41px;
        }
        .style17
        {
            width: 205px;
            height: 41px;
        }
        .style18
        {
            height: 34px;
        }
        .style19
        {
            width: 205px;
            height: 34px;
        }
        .style20
        {
            height: 40px;
        }
        .style21
        {
            width: 205px;
            height: 40px;
        }
        .style22
        {
            width: 261px;
        }
        .style23
        {
            height: 47px;
            width: 261px;
        }
        .style24
        {
            height: 39px;
            width: 261px;
        }
        .style25
        {
            height: 34px;
            width: 261px;
        }
        .style26
        {
            height: 41px;
            width: 261px;
        }
        .style27
        {
            height: 40px;
            width: 261px;
        }
        .style28
        {
            height: 25px;
            width: 261px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#C6FFAA">
    <tr>
        <td colspan="11" style="text-align: center">
            <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                ForeColor="#400080" Text="CERTIFICATE ISSUE"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style22">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style10">
            </td>
        <td class="style10">
            </td>
        <td class="style11">
            <asp:Label ID="Label12" runat="server" Text="DEPARTEMENT" 
                style="font-weight: 700"></asp:Label>
        </td>
        <td class="style23">
            <asp:DropDownList ID="ddldpt" runat="server" Height="28px" Width="115px">
                <asp:ListItem>--SELECT--</asp:ListItem>
                <asp:ListItem>CSE</asp:ListItem>
                <asp:ListItem>ECE</asp:ListItem>
                <asp:ListItem>IT</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style10">
            </td>
        <td class="style10">
            </td>
        <td class="style10">
            </td>
        <td class="style10">
            </td>
        <td class="style10">
            </td>
        <td class="style10">
            </td>
        <td class="style10">
            </td>
    </tr>
    <tr>
        <td class="style14">
            </td>
        <td class="style14">
            </td>
        <td class="style15">
            <asp:Label ID="Label14" runat="server" Text="ID NO" style="font-weight: 700"></asp:Label>
        </td>
        <td class="style24">
            <asp:TextBox ID="txtidno" runat="server"></asp:TextBox>
        </td>
        <td class="style14">
            </td>
        <td class="style14">
            </td>
        <td class="style14">
            </td>
        <td class="style14">
            </td>
        <td class="style14">
            </td>
        <td class="style14">
            </td>
        <td class="style14">
            </td>
    </tr>
    <tr>
        <td class="style18">
            </td>
        <td class="style18">
            </td>
        <td class="style19">
            <asp:Label ID="Label15" runat="server" Text="MODE OF CERTIFICATE" 
                style="font-weight: 700"></asp:Label>
        </td>
        <td class="style25">
            <asp:DropDownList ID="ddlmoc" runat="server" Height="26px" Width="140px" 
                AutoPostBack="True" onselectedindexchanged="ddlmoc_SelectedIndexChanged">
                <asp:ListItem>--SELECT--</asp:ListItem>
                <asp:ListItem>10TH XEROX</asp:ListItem>
                <asp:ListItem>INTER XEROX</asp:ListItem>
                <asp:ListItem>COURSE COMPLETION CERTIFICATE</asp:ListItem>
                <asp:ListItem>DUPLICATE ID CARD</asp:ListItem>
                <asp:ListItem>DUPLICATE HALL TICKET</asp:ListItem>
                <asp:ListItem>BONAFIED</asp:ListItem>
                <asp:ListItem>CUSTODIAN</asp:ListItem>
                <asp:ListItem>TRANSFER CERTIFICATE</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style18">
            </td>
        <td class="style18">
            </td>
        <td class="style18">
            </td>
        <td class="style18">
            </td>
        <td class="style18">
            </td>
        <td class="style18">
            </td>
        <td class="style18">
            </td>
    </tr>
    <tr>
        <td class="style16">
        </td>
        <td class="style16">
        </td>
        <td class="style17">
            <asp:Label ID="Label16" runat="server" Text="REASON" style="font-weight: 700"></asp:Label>
        </td>
        <td class="style26">
            <asp:TextBox ID="txtmultiline" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td class="style16">
        </td>
        <td class="style16">
        </td>
        <td class="style16">
        </td>
        <td class="style16">
        </td>
        <td class="style16">
        </td>
        <td class="style16">
        </td>
        <td class="style16">
        </td>
    </tr>
    <tr>
        <td class="style20">
            </td>
        <td class="style20">
            </td>
        <td class="style21">
            <asp:Label ID="Label18" runat="server" Text="AMOUNT" style="font-weight: 700"></asp:Label>
        </td>
        <td class="style27">
            <asp:TextBox ID="txtamount" runat="server" Height="22px" Enabled="False"></asp:TextBox>
        </td>
        <td class="style20">
            </td>
        <td class="style20">
            </td>
        <td class="style20">
            </td>
        <td class="style20">
            </td>
        <td class="style20">
            </td>
        <td class="style20">
            </td>
        <td class="style20">
            </td>
    </tr>
    <tr>
        <td class="style6" colspan="11">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
        <td class="style7">
            &nbsp;</td>
        <td class="style28">
            <asp:Button ID="btnok" runat="server" Text="OK" Width="106px" 
                onclick="btnok_Click" Font-Bold="True" Font-Size="Medium" 
                style="font-weight: 700" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td class="style6">
            <asp:Button ID="btncncl" runat="server" Height="27px" Text="CANCEL" 
                Width="94px" Font-Bold="True" Font-Size="Medium" onclick="btncncl_Click" />
        </td>
        <td class="style6">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
        <td class="style6">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

