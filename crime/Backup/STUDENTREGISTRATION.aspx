<%@ Page Language="C#" MasterPageFile="~/ADMINMASTER.master" AutoEventWireup="true" CodeFile="STUDENTREGISTRATION.aspx.cs" Inherits="STUDENT_REGISTRATION" Title="STUDENTREGISTRATION" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style3
    {
        width: 330px;
    }
    .style4
    {
        width: 13px;
    }
    .style5
    {
            width: 93px;
        }
    .style6
    {
        width: 3px;
    }
    .style7
    {
        width: 2px;
    }
    .style10
    {
            width: 241px;
        }
    .style11
    {
            width: 147px;
        }
    .style12
    {
            width: 120px;
        }
    .style15
    {
        width: 211px;
    }
    .style16
    {
        width: 251px;
    }
    .style17
    {
        width: 231px;
    }
    .style18
    {
        width: 260px;
    }
    .style19
    {
        width: 228px;
    }
        .style21
        {
            text-align: center;
        }
        .style22
        {
            width: 147px;
            text-align: center;
        }
        .style29
        {
            width: 241px;
            text-align: left;
            }
        .style34
        {
            width: 324px;
        }
        .style35
        {
            width: 752px;
        }
        .style36
        {
            width: 13px;
            height: 29px;
        }
        .style37
        {
            width: 93px;
            height: 29px;
        }
        .style38
        {
            width: 330px;
            height: 29px;
        }
        .style39
        {
            width: 228px;
            height: 29px;
        }
        .style40
        {
            height: 29px;
        }
        .style41
        {
            width: 3px;
            height: 30px;
        }
        .style42
        {
            width: 2px;
            height: 30px;
        }
        .style43
        {
            width: 241px;
            height: 30px;
        }
        .style44
        {
            width: 147px;
            height: 30px;
        }
        .style45
        {
            width: 120px;
            height: 30px;
        }
        .style46
        {
            height: 30px;
        }
        .style51
    {
        height: 11px;
    }
        .style52
        {
            height: 44px;
        }
        .style53
        {
            width: 251px;
            height: 44px;
        }
        .style54
        {
            width: 231px;
            height: 44px;
        }
        .style55
        {
            width: 211px;
            height: 44px;
        }
        .style56
        {
            width: 260px;
            height: 44px;
        }
        .style57
        {
            width: 752px;
            height: 44px;
        }
        .style58
        {
            height: 49px;
        }
        .style59
        {
            width: 251px;
            height: 49px;
        }
        .style60
        {
            width: 231px;
            height: 49px;
        }
        .style61
        {
            width: 211px;
            height: 49px;
        }
        .style62
        {
            width: 260px;
            height: 49px;
        }
        .style63
        {
            width: 752px;
            height: 49px;
        }
        .style64
        {
            height: 41px;
        }
        .style65
        {
            width: 251px;
            height: 41px;
        }
        .style66
        {
            width: 231px;
            height: 41px;
        }
        .style67
        {
            width: 211px;
            height: 41px;
        }
        .style68
        {
            width: 260px;
            height: 41px;
        }
        .style69
        {
            width: 752px;
            height: 41px;
        }
        .style70
        {
            height: 30px;
            width: 324px;
        }
        .style71
        {
            text-align: center;
            width: 120px;
        }
        .style72
        {
            width: 25px;
        }
        .style73
        {
            width: 25px;
            height: 29px;
        }
        .style74
        {
            width: 164px;
        }
        .style75
        {
            height: 29px;
            width: 164px;
        }
        .style76
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#FFCCFF">
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
        <td colspan="9" style="text-align: justify">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                Text="STUDENT REGISTRATION FORM" ForeColor="#CC0099"></asp:Label>
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
                            <asp:TextBox ID="txtdt" runat="server" Width="27px" 
                Enabled="False" Visible="False"></asp:TextBox>
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
    <tr>
        <td colspan="9">
            <asp:Panel ID="Panel1" runat="server">
                <table class="style1">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style16">
                            <asp:Label ID="Label12" runat="server" Text="REGISTRATION NO" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style17">
                            <asp:TextBox ID="txtregno" runat="server" Width="200px" 
                                ontextchanged="TextBox1_TextChanged1" Enabled="False"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            <asp:Label ID="Label17" runat="server" Text="ID NUMBER" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style18">
                            <asp:TextBox ID="txtid" runat="server" Width="200px" Enabled="False"></asp:TextBox>
                        </td>
                        <td class="style35">
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
                        <td class="style16">
                            &nbsp;</td>
                        <td class="style17">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            <asp:Label ID="Label28" runat="server" Text="DEPARTMENT" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style18">
                            <asp:DropDownList ID="ddldept" runat="server" 
                                onselectedindexchanged="ddldept_SelectedIndexChanged">
                                <asp:ListItem>--SELECT--</asp:ListItem>
                                <asp:ListItem>CSE</asp:ListItem>
                                <asp:ListItem>IT</asp:ListItem>
                                <asp:ListItem>ECE</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style35">
                            <asp:Button ID="btnid" runat="server" Text="Generate ID" 
                                onclick="btnid_Click" Font-Bold="True" />
                        </td>
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
                        <td class="style16">
                            </td>
                        <td class="style17">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            &nbsp;</td>
                        <td class="style18">
                            &nbsp;</td>
                        <td class="style35">
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
                        <td class="style16">
                            <asp:Label ID="Label15" runat="server" Text="NAME OF THE CANDIDATE" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style17">
                            <asp:TextBox ID="txtname" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            <asp:Label ID="Label33" runat="server" Text="PERSONAL NUMBER" Font-Bold="True"></asp:Label>
                            <br />
                        </td>
                        <td class="style18">
                            <asp:TextBox ID="txtperno" runat="server" ontextchanged="TextBox10_TextChanged" 
                                Width="200px"></asp:TextBox>
                        </td>
                        <td class="style35">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style52">
                            </td>
                        <td class="style52">
                            </td>
                        <td class="style53">
                            <asp:Label ID="Label29" runat="server" Text="FATHER'S /GAURDIAN'S NAME" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style54">
                            <asp:TextBox ID="txtfname" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style52">
                            </td>
                        <td class="style55">
                            <asp:Label ID="Label34" runat="server" Text="FATHER'S PH.NO" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style56">
                            <asp:TextBox ID="txtfphno" runat="server" Width="200px" MaxLength="10"></asp:TextBox>
                        </td>
                        <td class="style57">
                            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                ControlToValidate="txtfphno" ErrorMessage="Enter Only Numbers" 
                                MaximumValue="99999999" MinimumValue="0"></asp:RangeValidator>
                            </td>
                        <td class="style52">
                            </td>
                        <td class="style52">
                            </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style16">
                            <asp:Label ID="Label30" runat="server" Text="MOTHER'S NAME" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style17">
                            <asp:TextBox ID="txtmname" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            <asp:Label ID="Label35" runat="server" Text="MOTHER'S PH.NO" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style18">
                            <asp:TextBox ID="txtmphno" runat="server" Width="200px" Height="23px"></asp:TextBox>
                        </td>
                        <td class="style35">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style58">
                            </td>
                        <td class="style58">
                            </td>
                        <td class="style59">
                            <asp:Label ID="Label31" runat="server" Text="DATE OF BIRTH" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style60">
                            <asp:TextBox ID="txtdb" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style58">
                            </td>
                        <td class="style61">
                            <asp:Label ID="Label58" runat="server" Text="EMAIL ID" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style62">
                            <asp:TextBox ID="txtmailid" runat="server" Height="25px" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style63">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="txtmailid" EnableTheming="True" 
                                ErrorMessage="Enter Correct Mail ID" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </td>
                        <td class="style58">
                            </td>
                        <td class="style58">
                            </td>
                    </tr>
                    <tr>
                        <td class="style64">
                            </td>
                        <td class="style64">
                            </td>
                        <td class="style65">
                            <asp:Label ID="Label16" runat="server" Text="FATHER'S OCCUPATION" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style66">
                            <asp:TextBox ID="txtfoc" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style64">
                            </td>
                        <td class="style67">
                            <asp:Label ID="Label37" runat="server" Text="NATIVE PLACE" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style68">
                            <asp:TextBox ID="txtnapl" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style69">
                            </td>
                        <td class="style64">
                            </td>
                        <td class="style64">
                            </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style16">
                            <asp:Label ID="Label38" runat="server" Text="TEMPORARY ADDRESS" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style17">
                            <asp:TextBox ID="txttmpadd" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            <asp:Label ID="Label40" runat="server" Text="T.PIN CODE" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style18">
                            <asp:TextBox ID="txtpinco" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style35">
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
                        <td class="style16">
                            <asp:Label ID="Label39" runat="server" Text="PERMANENT ADDRESS" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style17">
                            <asp:TextBox ID="txtperadd" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            <asp:Label ID="Label41" runat="server" Text="P.PIN CODE" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style18">
                            <asp:TextBox ID="txtppinco" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style35">
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
                        <td class="style16">
                            <asp:Label ID="Label59" runat="server" Text="PASSWORD" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style17">
                            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style15">
                            <asp:Label ID="Label60" runat="server" Text="RE-ENTER PASSWORD" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style18">
                            <asp:TextBox ID="txtrepwd" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style35">
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="txtpwd" ControlToValidate="txtrepwd" 
                                ErrorMessage="Enter Correct Password"></asp:CompareValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="9">
            <asp:Panel ID="Panel2" runat="server" Height="182px" Width="1000px">
                <table class="style1">
                    <tr>
                        <td class="style4">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                        <td class="style3">
                            &nbsp;</td>
                        <td class="style19">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style74">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style72">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="10">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label42" runat="server" Text="ADMISSION DETAILS" 
                                Font-Bold="True" Font-Size="X-Large" ForeColor="#0D553A"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style36">
                            </td>
                        <td class="style37">
                            </td>
                        <td class="style38">
                            <asp:Label ID="Label43" runat="server" Text="MODE OF ADMISSION" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style39">
                            <asp:DropDownList ID="ddlmoa" runat="server" Width="100px">
                                <asp:ListItem>--SELECT--</asp:ListItem>
                                <asp:ListItem>EAMCET</asp:ListItem>
                                <asp:ListItem>MANAGEMENT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style40">
                            </td>
                        <td class="style75">
                            <asp:Label ID="Label61" runat="server" Text="TOTAL AMOUNT" Font-Bold="True"></asp:Label>
                            </td>
                        <td class="style40">
                            <asp:TextBox ID="txttamt" runat="server" Width="200px"></asp:TextBox>
                            </td>
                        <td class="style40">
                            </td>
                        <td class="style40">
                            </td>
                        <td class="style73">
                            </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                        <td class="style3">
                            <asp:Label ID="Label44" runat="server" Text="EAMCET RANK" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style19">
                            <asp:TextBox ID="txteamra" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style74">
                            <asp:Label ID="Label62" runat="server" Text="AMOUNT PAID" Font-Bold="True"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpamt" runat="server" Width="150px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style72">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                        <td class="style3">
                            <asp:Label ID="Label45" runat="server" Text="ENTRANCE HALL TICKET NUMBER" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style19">
                            <asp:TextBox ID="txthaltickno" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style74">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style72">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style4">
                            &nbsp;</td>
                        <td class="style5">
                            &nbsp;</td>
                        <td class="style3">
                            <asp:Label ID="Label46" runat="server" Text="ENTRANCE MARKS" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style19">
                            <asp:TextBox ID="txtentmar" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td class="style74">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style72">
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
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="9">
            <asp:Panel ID="Panel3" runat="server" Height="221px" Width="2000px" 
                style="margin-bottom: 33px">
                <table class="style1">
                    <tr>
                        <td class="style41">
                            </td>
                        <td class="style42">
                            </td>
                        <td class="style70">
                            <asp:Label ID="Label47" runat="server" Text="PREVIOUS EDUCATIONAL RECORDS" 
                                Font-Bold="True" Font-Size="X-Large" ForeColor="#335A10"></asp:Label>
                        </td>
                        <td class="style43">
                            </td>
                        <td class="style44">
                            </td>
                        <td class="style45">
                            </td>
                        <td class="style46">
                            </td>
                        <td class="style46">
                            </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            </td>
                        <td class="style7">
                            </td>
                        <td class="style34">
                            </td>
                        <td class="style10">
                            </td>
                        <td class="style11">
                            </td>
                        <td class="style12">
                            </td>
                        <td>
                            </td>
                        <td>
                            </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style10">
                            &nbsp;
                            <asp:Label ID="Label53" runat="server" Text="NAME OF THE INSTITUTION" 
                                Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style22">
                            <asp:Label ID="Label55" runat="server" Text="YEAR OF PASSED" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style71">
                            <asp:Label ID="Label57" runat="server" Text="AGGREGATE" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style21">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            <asp:Label ID="Label49" runat="server" Text="SSC/10TH" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style10">
                            <asp:TextBox ID="txtbssc" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style22">
                            <asp:TextBox ID="txtpssc" runat="server"></asp:TextBox>
                        </td>
                        <td class="style71">
                            <asp:TextBox ID="txtsscm" runat="server" ontextchanged="txtsscm_TextChanged" 
                                Width="101px"></asp:TextBox>
                        </td>
                        <td class="style21">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                        </td>
                        <td class="style7">
                        </td>
                        <td class="style34">
                            <asp:Label ID="Label50" runat="server" Text=" I INTER/XI" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style10">
                            <asp:TextBox ID="txtb1stinter" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style22">
                            <asp:TextBox ID="txtp1stinter" runat="server"></asp:TextBox>
                        </td>
                        <td class="style71">
                            <asp:TextBox ID="txt1stinterm" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td class="style21">
                            &nbsp;</td>
                        <td>
                            </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            </td>
                        <td class="style7">
                            </td>
                        <td class="style34">
                            <asp:Label ID="Label51" runat="server" Text="II INTER/XII" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="style29">
                            <asp:TextBox ID="txtb2ndinter" runat="server" Width="200px"></asp:TextBox>
                        </td>
                        <td class="style22">
                            <asp:TextBox ID="txtp2ndinter" runat="server"></asp:TextBox>
                        </td>
                        <td class="style71">
                            <asp:TextBox ID="txt2ndinterm" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td class="style21">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style10">
                            <asp:Button ID="btnsubmit" runat="server" Height="31px" 
                                onclick="btnsubmit_Click" Text="SUBMIT" Width="126px" Font-Bold="True" 
                                Font-Size="Medium" ForeColor="Black" />
                        </td>
                        <td class="style11">
                            <asp:Button ID="btncan" runat="server" Text="CANCEL" Width="103px" 
                                Height="30px" Font-Bold="True" Font-Size="Medium" />
                        </td>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style10">
                            &nbsp;</td>
                        <td class="style11">
                            &nbsp;</td>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style10">
                            &nbsp;</td>
                        <td class="style11">
                            &nbsp;</td>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style10">
                            &nbsp;</td>
                        <td class="style11">
                            &nbsp;</td>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style10">
                            &nbsp;</td>
                        <td class="style11">
                            &nbsp;</td>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style34">
                            &nbsp;</td>
                        <td class="style10">
                            &nbsp;</td>
                        <td class="style11">
                            &nbsp;</td>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
        <td class="style51">
            </td>
    </tr>
    <tr>
        <td class="style76">
            </td>
        <td class="style76">
            </td>
        <td class="style76">
            </td>
        <td class="style76">
            </td>
        <td class="style76">
            </td>
        <td class="style76">
            </td>
        <td class="style76">
            </td>
        <td class="style76">
            </td>
        <td class="style76">
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
</table>
</asp:Content>

