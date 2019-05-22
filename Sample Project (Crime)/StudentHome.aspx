<%@ Page Language="C#" MasterPageFile="~/STUDENT.master" AutoEventWireup="true" CodeFile="StudentHome.aspx.cs" Inherits="StudentHome" Title="HOME" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 272px;
            text-align: left;
        }
        .style7
        {
            width: 272px;
            height: 7px;
            text-align: right;
        }
        .style8
        {
            height: 7px;
        }
        .style9
        {
            text-align: left;
        }
        .style10
        {
            height: 7px;
            text-align: right;
        }
        .style11
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#A9C4F3">
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style11">
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
            <td colspan="6" class="style9">
                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="WELCOME " ForeColor="#5B0024"></asp:Label>
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
            <td class="style11">
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
            <td class="style11">
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
            <td class="style11">
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
                    ForeColor="#FF8000" Text="ID "></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLID" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="style11">
                &nbsp;<asp:Label 
                    ID="Label24" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF8000" Text="NAME"></asp:Label>
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
            <td class="style11">
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
                    ForeColor="#FF8000" Text="DATE OF BIRTH"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLDOB" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF8000" Text="DEPARTMENT"></asp:Label>
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
            <td class="style11">
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
                    ForeColor="#FF8000" Text="FATHER NAME"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLFNAME" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF8000" Text="MOTHER NAME"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLMNAME" runat="server" Font-Bold="True"></asp:Label>
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
            <td class="style11">
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
                    ForeColor="#FF8000" Text="CONTACT NUMBER "></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLPHNO" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF8000" Text="MAIL ID"></asp:Label>
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
            <td class="style7">
                </td>
            <td class="style8">
                </td>
            <td class="style8">
                </td>
            <td class="style10">
                </td>
            <td class="style8">
                </td>
            <td class="style8">
                </td>
            <td class="style8">
                </td>
            <td class="style8">
                </td>
            <td class="style8">
                </td>
            <td class="style8">
                </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF8000" Text="MODE OF ADMISSION"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LBLMOD" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF8000" Text="ADDRESS"></asp:Label>
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
            <td class="style11">
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
            <td class="style11">
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
            <td class="style11">
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

