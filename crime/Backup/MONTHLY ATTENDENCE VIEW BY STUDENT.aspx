<%@ Page Language="C#" MasterPageFile="~/STAFF.master" AutoEventWireup="true" CodeFile="MONTHLY ATTENDENCE VIEW BY STUDENT.aspx.cs" Inherits="MONTHLY_ATTENDENCE_VIEW_BY_STUDENT" Title="MONTHLY ATTENDENCE VIEW BY STUDENT" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 217px;
        }
        .style7
        {
            width: 255px;
        }
        .style8
        {
            width: 267px;
        }
        .style9
        {
            height: 32px;
        }
        .style10
        {
            width: 267px;
            height: 32px;
        }
        .style11
        {
            height: 14px;
        }
        .style12
        {
            width: 267px;
            height: 14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#FFFFCC">
        <tr>
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
            <td colspan="9" style="text-align: center">
                <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                    ForeColor="Red" style="text-align: center" 
                    Text="STUDENT ATTENDENCE DETAILS"></asp:Label>
            </td>
        </tr>
        <tr>
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td>
                <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddldept" runat="server">
                    <asp:ListItem>--SELECT--</asp:ListItem>
                    <asp:ListItem>CSE</asp:ListItem>
                    <asp:ListItem>ECE</asp:ListItem>
                    <asp:ListItem>IT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label19" runat="server" Font-Bold="True" Text="Year/Semester"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlyear" runat="server">
                    <asp:ListItem>--SELECT--</asp:ListItem>
                    <asp:ListItem>Ist Year</asp:ListItem>
                    <asp:ListItem>2 - 1</asp:ListItem>
                    <asp:ListItem>2 - 2</asp:ListItem>
                    <asp:ListItem>3 - 1</asp:ListItem>
                    <asp:ListItem>3 - 2</asp:ListItem>
                    <asp:ListItem>4 - 1</asp:ListItem>
                    <asp:ListItem>4 - 2</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                    ID="btnsbmt" runat="server" Font-Bold="True" onclick="btnsbmt_Click" 
                    Text="SUBMIT" Width="110px" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                
&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lblsub" runat="server" Font-Bold="True" Text="Subject"></asp:Label>
            </td>
            <td colspan="5">
                <table class="style1">
                    <tr>
                        <td>
                            <asp:Panel ID="pnl1yr" runat="server" Width="244px">
                                <asp:DropDownList ID="ddl1yrsub" runat="server" Height="16px" 
                                    style="margin-bottom: 0px" Width="125px">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>ENGLISH</asp:ListItem>
                                    <asp:ListItem>C- LANGUAGE</asp:ListItem>
                                    <asp:ListItem>EP</asp:ListItem>
                                    <asp:ListItem>EC</asp:ListItem>
                                    <asp:ListItem>MM</asp:ListItem>
                                    <asp:ListItem>M1</asp:ListItem>
                                    <asp:ListItem>EDP</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddlfistlab" runat="server" Height="16px" Width="92px">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>C-LAB</asp:ListItem>
                                    <asp:ListItem>PHYSICS/CHEMISTRY</asp:ListItem>
                                    <asp:ListItem>IT WORKSHOP</asp:ListItem>
                                    <asp:ListItem>ELCS</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="pnl21cse" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl21csesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>P&amp;S</asp:ListItem>
                                    <asp:ListItem>MFCS</asp:ListItem>
                                    <asp:ListItem>ADS</asp:ListItem>
                                    <asp:ListItem>DLD</asp:ListItem>
                                    <asp:ListItem>EDC</asp:ListItem>
                                    <asp:ListItem>BEE</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl21cselab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>E&amp;E</asp:ListItem>
                                    <asp:ListItem>DS</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl21ece" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl21ecesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>M3</asp:ListItem>
                                    <asp:ListItem>PTSP</asp:ListItem>
                                    <asp:ListItem>ES</asp:ListItem>
                                    <asp:ListItem>EC</asp:ListItem>
                                    <asp:ListItem>EDC</asp:ListItem>
                                    <asp:ListItem>SS</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl21ecelab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>EDC</asp:ListItem>
                                    <asp:ListItem>BS</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl21it" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl21itsub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>DCS</asp:ListItem>
                                    <asp:ListItem>MFCS</asp:ListItem>
                                    <asp:ListItem>DS</asp:ListItem>
                                    <asp:ListItem>DLD&amp;CO</asp:ListItem>
                                    <asp:ListItem>BEE</asp:ListItem>
                                    <asp:ListItem>EDC</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl21itlab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>DS</asp:ListItem>
                                    <asp:ListItem>E&amp;E</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="pnl22cse" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl22csesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>CO</asp:ListItem>
                                    <asp:ListItem>DBMS</asp:ListItem>
                                    <asp:ListItem>OOPS</asp:ListItem>
                                    <asp:ListItem>ES</asp:ListItem>
                                    <asp:ListItem>FLAT</asp:ListItem>
                                    <asp:ListItem>DAA</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl22cselab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>OOPS</asp:ListItem>
                                    <asp:ListItem>DBMS</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl22ece" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl22ecesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>PEE</asp:ListItem>
                                    <asp:ListItem>ECA</asp:ListItem>
                                    <asp:ListItem>PDC</asp:ListItem>
                                    <asp:ListItem>STLD</asp:ListItem>
                                    <asp:ListItem>ETL</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl22ecelab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>EE</asp:ListItem>
                                    <asp:ListItem>ECA</asp:ListItem>
                                    <asp:ListItem>PDC</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl22it" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl22itsub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>PPL</asp:ListItem>
                                    <asp:ListItem>DBMS</asp:ListItem>
                                    <asp:ListItem>OOPS</asp:ListItem>
                                    <asp:ListItem>ES</asp:ListItem>
                                    <asp:ListItem>P&amp;S</asp:ListItem>
                                    <asp:ListItem>DAA</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl22itlab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>OOPS</asp:ListItem>
                                    <asp:ListItem>DBMS</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="pnl31cse" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl31csesub" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>PPL</asp:ListItem>
                                    <asp:ListItem>ORIPRCL</asp:ListItem>
                                    <asp:ListItem>OS</asp:ListItem>
                                    <asp:ListItem>CF</asp:ListItem>
                                    <asp:ListItem>SE</asp:ListItem>
                                    <asp:ListItem>MPI</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:DropDownList ID="ddl31cselab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>CN&amp;OS</asp:ListItem>
                                    <asp:ListItem>MPI</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl31ece" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl31ecesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>CS</asp:ListItem>
                                    <asp:ListItem>CO</asp:ListItem>
                                    <asp:ListItem>AWP</asp:ListItem>
                                    <asp:ListItem>EMI</asp:ListItem>
                                    <asp:ListItem>AC</asp:ListItem>
                                    <asp:ListItem>ICA</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl31ecelab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>AC</asp:ListItem>
                                    <asp:ListItem>IC</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl31it" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl31itsub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>ACD</asp:ListItem>
                                    <asp:ListItem>LP</asp:ListItem>
                                    <asp:ListItem>SE</asp:ListItem>
                                    <asp:ListItem>OS</asp:ListItem>
                                    <asp:ListItem>CN</asp:ListItem>
                                    <asp:ListItem>MEFA</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl31itlab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>OS&amp;CN</asp:ListItem>
                                    <asp:ListItem>AECS</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="pnl32cse" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl32csesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>OOAD</asp:ListItem>
                                    <asp:ListItem>VLSI DSN</asp:ListItem>
                                    <asp:ListItem>NS</asp:ListItem>
                                    <asp:ListItem>CD</asp:ListItem>
                                    <asp:ListItem>MEFA</asp:ListItem>
                                    <asp:ListItem>WT</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl32cselab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>ADVELCS</asp:ListItem>
                                    <asp:ListItem>WT&amp;CD</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl32ece" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl32ecesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>MEFA</asp:ListItem>
                                    <asp:ListItem>DC</asp:ListItem>
                                    <asp:ListItem>MP&amp;MC</asp:ListItem>
                                    <asp:ListItem>DSP</asp:ListItem>
                                    <asp:ListItem>EI</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl32ecelab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>MP&amp;MC</asp:ListItem>
                                    <asp:ListItem>DSP</asp:ListItem>
                                    <asp:ListItem>AECS</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl32it" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl32itsub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>WT</asp:ListItem>
                                    <asp:ListItem>EI</asp:ListItem>
                                    <asp:ListItem>NS</asp:ListItem>
                                    <asp:ListItem>CG</asp:ListItem>
                                    <asp:ListItem>DWDM</asp:ListItem>
                                    <asp:ListItem>ES</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl32itlab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>ES&amp;DWDM</asp:ListItem>
                                    <asp:ListItem>WT</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="pnl41cse" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl41csesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>LP</asp:ListItem>
                                    <asp:ListItem>STM</asp:ListItem>
                                    <asp:ListItem>DWDM</asp:ListItem>
                                    <asp:ListItem>CG</asp:ListItem>
                                    <asp:ListItem>MC</asp:ListItem>
                                    <asp:ListItem>DP</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl41cselab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>LP&amp;DM</asp:ListItem>
                                    <asp:ListItem>CT&amp;ST</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl41ece" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl41ecesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>MS</asp:ListItem>
                                    <asp:ListItem>VLSI DSN</asp:ListItem>
                                    <asp:ListItem>MWE</asp:ListItem>
                                    <asp:ListItem>CN</asp:ListItem>
                                    <asp:ListItem>E1</asp:ListItem>
                                    <asp:ListItem>E2</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl41ecelab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>ECAD&amp;VLSI</asp:ListItem>
                                    <asp:ListItem>MWE&amp;DC</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl41it" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl41itsub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                    <asp:ListItem>D</asp:ListItem>
                                    <asp:ListItem>E</asp:ListItem>
                                    <asp:ListItem>F</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl41itlab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Panel ID="pnl42cse" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl42csesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>MS</asp:ListItem>
                                    <asp:ListItem>E1</asp:ListItem>
                                    <asp:ListItem>E2</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl42cselab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>MINI PRJ</asp:ListItem>
                                    <asp:ListItem>MAJOR PRJ</asp:ListItem>
                                    <asp:ListItem>TECH SEM</asp:ListItem>
                                    <asp:ListItem>CV</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl42ece" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl42ecesub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>E1</asp:ListItem>
                                    <asp:ListItem>E2</asp:ListItem>
                                    <asp:ListItem>E3</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl42ecelab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>MINI PRJ</asp:ListItem>
                                    <asp:ListItem>MAJOR PRJ</asp:ListItem>
                                    <asp:ListItem>TECH SEM</asp:ListItem>
                                    <asp:ListItem>CV</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                        <td>
                            <asp:Panel ID="pnl42it" runat="server" Width="243px">
                                <asp:DropDownList ID="ddl42itsub" 
    runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>E1</asp:ListItem>
                                    <asp:ListItem>E2</asp:ListItem>
                                    <asp:ListItem>E3</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddl42itlab" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>MINI PRJ</asp:ListItem>
                                    <asp:ListItem>MAJOR PRJ</asp:ListItem>
                                    <asp:ListItem>TECH SEM</asp:ListItem>
                                    <asp:ListItem>CV</asp:ListItem>
                                </asp:DropDownList>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
            <td>
                </td>
        </tr>
        <tr>
            <td colspan="9">
                <asp:Panel ID="pnlfirstyr1" runat="server" GroupingText="Attendence">
                    <table class="style1" bgcolor="#FFFFCC" frame="box">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td class="style8">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style6">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style7">
                                &nbsp;</td>
                        </tr>
                        <tr style="border: medium groove #FF0000">
                            <td style="border: medium groove #FFFFFF; font-weight: 700; text-align: center;" 
                                class="style9">
                                </td>
                            <td class="style10" style="border: medium groove #FF0000">
                                </td>
                            <td colspan="2" style="border: medium groove #FF0000" class="style9">
                                <b style="text-align: justify">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SUBJECT</b></td>
                            <td colspan="2" style="border: medium groove #FF0000" class="style9">
                                <b>LAB</b></td>
                        </tr>
                        <tr style="border: medium groove #FF0000">
                            <td style="border: medium groove #FF8000; font-weight: 700; text-align: center;">
                                ID</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <b style="text-align: center">NAME</b></td>
                            <td style="border: medium groove #FF0000">
                                <b>WORKING DAYS</b></td>
                            <td style="border: medium groove #FF0000">
                                <b>PRESENT DAYS</b></td>
                            <td style="border: medium groove #FF0000">
                                <b>WORKING</b><b> DAYS</b></td>
                            <td style="border: medium groove #FF0000">
                                <b>PRESENT DAYS</b></td>
                        </tr>
                        <tr style="border: medium groove #FF0000">
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno0" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname0" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd0" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd0" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd0" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd0" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr style="border: medium groove #FF0000">
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno1" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname1" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd1" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd1" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd1" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd1" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr style="border: medium groove #FF0000">
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno2" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname2" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd2" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd2" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd2" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd2" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr style="border: medium groove #FF0000">
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno3" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname3" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd3" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd3" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd3" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd3" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr style="border: medium groove #FF0000">
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno4" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname4" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd4" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd4" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd4" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd4" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno5" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname5" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd5" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd5" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd5" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd5" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno6" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname6" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd6" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd6" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd6" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd6" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno7" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname7" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd7" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd7" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd7" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd7" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno8" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname8" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd8" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd8" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd8" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd8" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno9" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname9" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd9" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd9" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd9" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd9" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno10" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname10" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd10" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd10" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd10" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd10" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno11" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname11" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd11" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd11" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd11" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd11" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno12" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname12" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd12" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd12" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd12" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd12" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno13" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname13" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd13" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd13" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd13" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd13" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno14" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname14" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd14" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd14" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd14" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd14" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno15" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname15" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd15" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd15" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd15" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd15" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno16" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname16" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd16" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd16" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd16" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd16" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno17" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname17" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd17" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd17" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd17" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd17" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno18" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname18" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd18" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd18" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd18" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd18" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno19" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname19" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd19" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd19" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd19" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd19" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno20" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname20" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd20" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd20" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd20" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd20" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno21" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname21" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd21" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd21" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd21" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd21" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno22" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname22" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd22" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd22" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd22" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd22" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno23" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname23" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd23" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd23" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd23" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd23" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno24" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname24" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd24" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd24" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd24" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd24" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno25" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname25" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd25" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd25" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd25" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd25" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno26" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname26" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd26" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd26" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd26" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd26" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno27" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname27" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd27" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd27" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd27" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd27" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno28" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname28" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd28" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd28" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd28" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd28" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno29" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname29" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd29" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd29" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd29" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd29" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno30" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname30" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd30" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd30" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd30" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd30" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno31" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname31" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd31" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd31" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd31" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd31" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno32" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname32" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd32" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd32" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd32" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd32" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno33" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname33" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd33" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd33" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd33" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd33" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno34" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname34" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd34" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd34" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd34" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd34" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno35" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname35" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd35" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd35" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd35" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd35" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno36" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname36" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd36" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd36" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd36" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd36" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno37" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname37" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd37" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd37" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd37" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd37" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno38" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname38" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd38" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd38" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd38" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd38" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno39" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname39" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd39" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd39" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd39" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd39" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno40" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname40" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd40" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd40" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd40" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd40" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno41" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname41" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd41" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd41" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd41" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd41" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno42" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname42" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd42" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd42" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd42" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd42" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno43" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname43" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd43" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd43" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd43" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd43" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno44" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname44" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd44" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd44" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd44" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd44" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                <asp:TextBox ID="txtidno45" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style8" style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtname45" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtswd45" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtspd45" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlwd45" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border: medium groove #FF0000">
                                <asp:TextBox ID="txtlpd45" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000" class="style11">
                                </td>
                            <td class="style12" style="border: medium groove #FF0000">
                                </td>
                            <td style="border: medium groove #FF0000" class="style11">
                                </td>
                            <td style="border: medium groove #FF0000" class="style11">
                                </td>
                            <td style="border: medium groove #FF0000" class="style11">
                                </td>
                            <td style="border: medium groove #FF0000" class="style11">
                                </td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border: medium groove #FF8000">
                                &nbsp;</td>
                            <td class="style8" style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                            <td style="border: medium groove #FF0000">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td class="style8">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style6">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style7">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: center">
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td class="style8">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style6">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style7">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td class="style8">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style6">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style7">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
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
                <asp:Button ID="btnupload" runat="server" onclick="btnupload_Click1" 
                    Text="Button" />
            </td>
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
    </table>
&nbsp; 
</asp:Content>

