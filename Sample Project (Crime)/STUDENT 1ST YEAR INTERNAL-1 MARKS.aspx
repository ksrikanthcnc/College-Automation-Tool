<%@ Page Language="C#" MasterPageFile="~/STAFF.master" AutoEventWireup="true" CodeFile="STUDENT 1ST YEAR INTERNAL-1 MARKS.aspx.cs" Inherits="STUDENT_1ST_YEAR_INTERNAL_1_MARKS" Title="SUDENT 1ST YEAR INTERNAL-1 MARKS" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .newStyle1
        {
            border-style: groove;
            border-width: medium;
        }
        .newStyle2
        {
            border-style: groove;
            border-width: medium;
            border-collapse: separate;
        }
        .newStyle3
        {
            border-style: groove;
            border-width: medium;
        }
        .newStyle4
        {
            border-style: groove;
        }
        .style6
        {
            width: 166px;
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnsbmt" runat="server" onclick="btnsbmt_Click" Text="SUBMIT" 
                    Font-Bold="True" Font-Size="Medium" />
&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
            <td colspan="6">
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
                            <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                            </asp:DropDownList>
                        </td>
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
                                    <asp:ListItem>E&amp;E </asp:ListItem>
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
                                    <asp:ListItem>ES&amp;DMDW</asp:ListItem>
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="10" style="text-align: center">
                <asp:Panel ID="pnlfirstyr" runat="server" Font-Bold="True" 
                    Font-Names="Times New Roman" Font-Size="Large" GroupingText=" Marks" 
                    Height="1877px" style="height: 1877px">
                    <table class="style1">
                        <tr style="border-style: groove">
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove" class="style6">
                                &nbsp;</td>
                            <td style="border-style: groove" colspan="10">
                                Subject 
                                </td>
                            <td style="border-style: groove" colspan="3">
                                Labs
                                </td>
                        </tr>
                        <tr style="border-style: groove">
                             <td style="border-style: groove">
                                 &nbsp;</td>
                            <td style="border-style: groove">
                                ID</td>
                            <td style="border-style: groove" class="style6">
                                Name</td>
                            <td style="border-style: groove" colspan="3">
                                I1</td>
                            <td style="border-style: groove" colspan="3">
                                I2</td>
                            <td style="border-style: groove" colspan="3">
                                I3</td>
                            <td style="border-style: groove">
                                E</td>
                            <td style="border-style: groove">
                                I1</td>
                            <td style="border-style: groove">
                                I2</td>
                            <td style="border-style: groove">
                                E</td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove" class="style6">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                S</td>
                            <td style="border-style: groove">
                                O</td>
                            <td style="border-style: groove">
                                A</td>
                            <td style="border-style: groove">
                                S</td>
                            <td style="border-style: groove">
                                O</td>
                            <td style="border-style: groove">
                                A</td>
                            <td style="border-style: groove">
                                S</td>
                            <td style="border-style: groove">
                                O</td>
                            <td style="border-style: groove">
                                A</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno0" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname0" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1A1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE1" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno1" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname1" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1A2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE2" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno2" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname2" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1A3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE3" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno3" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname3" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1A4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S4" runat="server" Width="59px" Height="22px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A4" runat="server" Width="59px" Height="22px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE4" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno4" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname4" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1A5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE5" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno5" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname5" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1A6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE6" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno6" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname6" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A7" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE7" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno7" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname7" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A8" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE8" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno8" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname8" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A9" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE9" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno9" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname9" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A10" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE10" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno10" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname10" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A11" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE11" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno11" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname11" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A12" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE12" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno12" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname12" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A13" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE13" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno13" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname13" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A14" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE14" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno14" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname14" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A15" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE15" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno15" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname15" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A16" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE16" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno16" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname16" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A17" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE17" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno17" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname17" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A18" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE18" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno18" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname18" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A19" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE19" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno19" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname19" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A20" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE20" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno20" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname20" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A21" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE21" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno21" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname21" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A22" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE22" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno22" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname22" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A23" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE23" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno23" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname23" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A24" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE24" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno24" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname24" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A25" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE25" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno25" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname25" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A26" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE26" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno26" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove" class="style6">
                                <asp:TextBox ID="txtname26" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A27" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE27" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno27" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname27" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A28" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE28" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno28" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname28" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A29" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE29" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno29" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname29" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A30" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE30" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno30" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname30" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A31" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE31" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno31" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname31" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A32" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE32" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno32" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname32" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A33" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE33" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno33" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname33" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A34" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE34" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno34" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname34" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A35" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE35" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno35" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname35" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A36" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE36" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno36" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname36" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A37" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE37" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno37" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname37" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A38" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE38" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno38" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname38" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A39" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE39" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno39" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname39" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A40" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE40" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno40" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname40" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A41" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE41" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno41" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname41" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A42" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE42" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno42" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname42" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A43" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE43" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno43" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname43" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A44" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE44" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno44" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname44" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A45" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE45" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtidno45" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style6" style="border-style: groove">
                                <asp:TextBox ID="txtname45" runat="server" Width="200px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1S46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1O46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <b>
                                <asp:TextBox ID="txtI1A46" runat="server" Width="59px"></asp:TextBox>
                                </b></td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI12S46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2O46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2A46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI13S46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3O46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI3A46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtSE46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI1L46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtI2L46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                            <td style="border-style: groove">
                                <asp:TextBox ID="txtLE46" runat="server" Width="59px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td class="style6" style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td class="style6" style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td class="style6" style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td class="style6" style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td class="style6" style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td class="style6" style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                            <td style="border-style: groove">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td colspan="10" style="text-align: center">
                <asp:Button ID="button1" runat="server" onclick="Button1_Click" Text="UPLOAD" 
                    Font-Bold="True" style="width: 82px" />
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
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

