<%@ Page Language="C#" MasterPageFile="~/STAFF.master" AutoEventWireup="true" CodeFile="STAFFHOME.aspx.cs" Inherits="STAFFHOME" Title="HOME" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 306px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#FFFFCC">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td colspan="6">
                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="WELCOME TO "></asp:Label>
&nbsp;
                <asp:Label ID="LBLNMAE" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            </td>
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="ID "></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLID" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="style4">
                <asp:Label ID="Label24" runat="server" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="#3366CC" Text="NAME"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLNAME" runat="server" Font-Bold="True"></asp:Label>
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="DATE OF BIRTH"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLDOB" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style4">
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="DEPARTMENT"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLDEPT" runat="server" Font-Bold="True"></asp:Label>
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="FATHER NAME/HUSBAND NAME"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLFNAME" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style4">
                <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="PAN NUMBER"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLPANNO" runat="server" Font-Bold="True"></asp:Label>
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="CONTACT NUMBER "></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLPHNO" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style4">
                <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="MAIL ID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLMAIL" runat="server" Font-Bold="True"></asp:Label>
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="DESIGNATION"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLDESGNTN" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style4">
                <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#3366CC" Text="ADDRESS"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLADD" runat="server" Font-Bold="True"></asp:Label>
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
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
    </table>
</asp:Content>

