<%@ Page Language="C#" MasterPageFile="~/ACCOUNTS.master" AutoEventWireup="true" CodeFile="ACCOUNTSHOME.aspx.cs" Inherits="ACCOUNTSHOME" Title="HOME" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 284px;
            text-align: left;
        }
        .style7
        {
            text-align: left;
            width: 181px;
        }
        .style8
        {
            width: 284px;
            text-align: left;
            height: 23px;
        }
        .style9
        {
            height: 23px;
        }
        .style10
        {
            text-align: left;
            height: 23px;
            width: 181px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#C6FFAA">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style7">
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
            <td class="style7">
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
            <td class="style7">
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
            <td class="style7">
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
                    ForeColor="#CC3300" Text="ID "></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLID" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="style7">
                <asp:Label ID="Label24" 
                    runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#CC3300" 
                    Text="NAME"></asp:Label>
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
            <td class="style7">
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
                    ForeColor="#CC3300" Text="DATE OF BIRTH"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLDOB" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#CC3300" Text="DEPARTMENT"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLDEPT" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td align="right">
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
            <td class="style7">
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
                    ForeColor="#CC3300" Text="FATHER NAME/HUSBAND NAME"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLFNAME" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#CC3300" Text="PAN NUMBER"></asp:Label>
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
            <td class="style7">
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
                    ForeColor="#CC3300" Text="CONTACT NUMBER "></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLPHNO" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#CC3300" Text="MAIL ID"></asp:Label>
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
            <td class="style8">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style10">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#CC3300" Text="DESIGNATION"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLDESGNTN" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#CC3300" Text="ADDRESS"></asp:Label>
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
            <td class="style7">
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
            <td class="style7">
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
            <td class="style7">
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

