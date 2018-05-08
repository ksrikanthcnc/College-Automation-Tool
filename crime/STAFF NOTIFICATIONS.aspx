<%@ Page Language="C#" MasterPageFile="~/STAFF.master" AutoEventWireup="true" CodeFile="STAFF NOTIFICATIONS.aspx.cs" Inherits="STAFF_NOTIFICATIONS" Title="STAFF NOTIFICATIONS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style5
    {
        width: 305px;
    }
    .style7
    {
        width: 219px;
        text-align: center;
    }
    .style8
    {
        width: 21px;
    }
    .style9
    {
        width: 261px;
        text-align: center;
    }
        .style10
        {
            height: 23px;
        }
        .style11
        {
            width: 305px;
            height: 23px;
        }
        .style12
        {
            width: 219px;
            text-align: center;
            height: 23px;
        }
        .style13
        {
            width: 21px;
            height: 23px;
        }
        .style14
        {
            width: 261px;
            text-align: center;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#FFFFCC">
        <tr>
            <td>
            &nbsp;</td>
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Large" 
                Text="NOTIFICATION"></asp:Label>
            </td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
                <asp:TextBox ID="txtntf" runat="server" Width="200px" 
                Height="50px" TextMode="MultiLine"></asp:TextBox>
            </td>
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style11">
            </td>
            <td class="style12">
            </td>
            <td class="style13">
            </td>
            <td class="style14">
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
            <td>
            &nbsp;</td>
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
                <asp:Button ID="btnpost" runat="server" Font-Bold="True" Text="POST" 
                Width="100px" onclick="btnpost_Click" Font-Size="Medium" />
            </td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
                <asp:Button ID="btncancel" runat="server" Font-Bold="True" Text="CANCEL" 
                Width="103px" Font-Size="Medium" onclick="btncancel_Click" />
            </td>
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
            <td class="style5">
            &nbsp;</td>
            <td class="style7">
            &nbsp;</td>
            <td class="style8">
            &nbsp;</td>
            <td class="style9">
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
    </table>
</asp:Content>

