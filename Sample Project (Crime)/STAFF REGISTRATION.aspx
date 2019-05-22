<%@ Page Language="C#" MasterPageFile="~/ADMINMASTER.master" AutoEventWireup="true" CodeFile="STAFF REGISTRATION.aspx.cs" Inherits="STAFF_REGISTRATION" Title="STAFF REGISTRATION" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 4px;
        }
        .style4
        {
            width: 333px;
        }
        .style7
        {
            height: 35px;
        }
        .style9
        {
            width: 333px;
            height: 35px;
        }
        .style11
        {
            height: 35px;
            width: 12px;
        }
        .style12
        {
            width: 12px;
        }
        .style15
        {
            height: 35px;
            width: 128px;
        }
        .style16
        {
            width: 128px;
        }
        .style17
        {
            height: 35px;
            width: 222px;
        }
        .style18
        {
            width: 222px;
        }
        .style21
        {
            height: 35px;
            width: 64px;
        }
        .style22
        {
            width: 64px;
        }
        .style23
        {
            height: 35px;
            width: 233px;
        }
        .style24
        {
            width: 233px;
        }
        .style25
        {
            width: 12px;
            height: 28px;
        }
        .style26
        {
            height: 28px;
        }
        .style27
        {
            width: 333px;
            height: 28px;
        }
        .style29
        {
            width: 64px;
            height: 28px;
        }
        .style30
        {
            width: 233px;
            height: 28px;
        }
        .style31
        {
            width: 128px;
            height: 28px;
        }
        .style32
        {
            width: 222px;
            height: 28px;
        }
        .style33
        {
            height: 35px;
            width: 226px;
        }
        .style34
        {
            width: 226px;
        }
        .style35
        {
            height: 28px;
            width: 226px;
        }
        .style38
        {
            height: 35px;
            width: 60px;
        }
        .style39
        {
            width: 60px;
        }
        .style40
        {
            height: 28px;
            width: 60px;
        }
        .style41
        {
        }
        .style42
        {
            width: 20px;
        }
        .style43
        {
            width: 14px;
        }
        .style44
        {
            width: 239px;
        }
        .style45
        {
            width: 232px;
        }
        .style46
        {
            width: 16px;
        }
        .style47
        {
            width: 227px;
        }
    .style48
    {
        height: 326px;
    }
    .style49
    {
        width: 4px;
        height: 326px;
    }
        .style50
        {
            width: 282px;
        }
        .style51
        {
            width: 282px;
            height: 326px;
        }
        .style52
        {
            width: 14px;
            height: 39px;
        }
        .style53
        {
            width: 20px;
            height: 39px;
        }
        .style54
        {
            width: 239px;
            height: 39px;
        }
        .style55
        {
            width: 232px;
            height: 39px;
        }
        .style56
        {
            width: 16px;
            height: 39px;
        }
        .style57
        {
            width: 227px;
            height: 39px;
        }
        .style58
        {
            height: 39px;
        }
        .newStyle1
        {
            text-transform: uppercase;
        }
        .style59
        {
            width: 333px;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="height: 217px; width: 100%" bgcolor="#FFCCFF">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                </td>
            <td class="style50">
                </td>
            <td class="style2">
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
            <td colspan="16" style="text-align: center">
                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                    style="text-align: center" Text="STAFF REGISTRATION" ForeColor="#CC0099"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
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
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Panel ID="Panel1" runat="server" Height="448px" Width="1229px">
                    <table class="style1" style="width: 104%; height: 476px">
                        <tr>
                            <td class="style11">
                            </td>
                            <td class="style7">
                            </td>
                            <td class="style9">
                                <asp:Label ID="Label19" runat="server" Text="REGISTRATION  NO" Font-Bold="True"></asp:Label>
                            </td>
                            <td class="style33">
                                <asp:TextBox ID="txtstfregno" runat="server" Width="198px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="style21">
                                &nbsp;</td>
                            <td class="style23">
                                <asp:Label ID="Label20" runat="server" Text="ID NUMBER" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style15">
                                <asp:TextBox ID="txtidno" runat="server" Height="23px" 
                                    ontextchanged="TextBox2_TextChanged" Width="174px" Enabled="False"></asp:TextBox>
                            </td>
                            <td class="style17">
                                &nbsp;</td>
                            <td class="style7">
                            </td>
                            <td class="style38">
                            </td>
                            <td class="style7">
                            </td>
                            <td class="style7">
                            </td>
                            <td class="style7">
                            </td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style4">
                                &nbsp;</td>
                            <td class="style34">
                                &nbsp;</td>
                            <td class="style22">
                                &nbsp;</td>
                            <td class="style24">
                                <asp:Label ID="Label21" runat="server" Text="DEPARTMENT" Font-Bold="True" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style16">
                                <asp:DropDownList ID="ddldpt" runat="server" Height="16px" Width="173px">
                                    <asp:ListItem Selected="True">--SELECT--</asp:ListItem>
                                    <asp:ListItem>CSE</asp:ListItem>
                                    <asp:ListItem>ECE</asp:ListItem>
                                    <asp:ListItem>IT</asp:ListItem>
                                    <asp:ListItem>ACCOUNTS</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="style18">
                                <asp:Button ID="btnid" runat="server" Text="Generate ID" Width="98px" 
                                    onclick="btnid_Click" Font-Bold="True" />
                            </td>
                            <td>
                                &nbsp;</td>
                            <td class="style39">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style4">
                                &nbsp;</td>
                            <td class="style34">
                                &nbsp;</td>
                            <td class="style22">
                                &nbsp;</td>
                            <td class="style24">
                                &nbsp;</td>
                            <td class="style16">
                                &nbsp;</td>
                            <td class="style18">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style39">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style59">
                                NAME</td>
                            <td class="style34">
                                <asp:TextBox ID="txtname" runat="server" Height="24px" Width="199px" 
                                    CssClass="newStyle1"></asp:TextBox>
                            </td>
                            <td class="style22">
                                &nbsp;</td>
                            <td class="style24">
                                <asp:Label ID="Label33" runat="server" Text="MARITAL STATUS" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style16">
                                <asp:DropDownList ID="ddlmasts" runat="server">
                                    <asp:ListItem>--SELECT--</asp:ListItem>
                                    <asp:ListItem>married</asp:ListItem>
                                    <asp:ListItem>unmarried</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="style18">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style39">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style4">
                                <asp:Label ID="Label29" runat="server" Text="FATHER'S /GAURDIAN'S/HUSBAND NAME" 
                                    Font-Bold="True"></asp:Label>
                            </td>
                            <td class="style34">
                                <asp:TextBox ID="txtfana" runat="server" Width="199px"></asp:TextBox>
                            </td>
                            <td class="style22">
                                &nbsp;</td>
                            <td class="style24">
                                <asp:Label ID="Label34" runat="server" Text="PHONE NO" style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style16">
                                <asp:TextBox ID="txtphno" runat="server" Width="175px" MaxLength="10"></asp:TextBox>
                            </td>
                            <td class="style18">
                                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                    ControlToValidate="txtphno" ErrorMessage="Enter Only Numbers" 
                                    MaximumValue="99999" MinimumValue="0"></asp:RangeValidator>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td class="style39">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style4">
                                <asp:Label ID="Label30" runat="server" Text="DATE OF BIRTH" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style34">
                                <asp:TextBox ID="txtdob" runat="server" style="margin-right: 0px" 
                                    Width="196px"></asp:TextBox>
                            </td>
                            <td class="style22">
                                &nbsp;</td>
                            <td class="style24">
                                <asp:Label ID="Label35" runat="server" Text="PANCARD NO" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style16">
                                <asp:TextBox ID="txtpanno" runat="server" Width="176px"></asp:TextBox>
                            </td>
                            <td class="style18">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style39">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style4">
                                <asp:Label ID="Label31" runat="server" Text="GENDER" style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style34">
                                <asp:TextBox ID="txtgender" runat="server" Width="54px"></asp:TextBox>
                                <asp:RadioButton ID="rdbmale" runat="server" Text="MALE" GroupName="gender" 
                                    style="font-weight: 700" />
                                &nbsp;<asp:RadioButton ID="rdbfemale" runat="server" 
                                    Text="FEMALE" GroupName="gender" style="font-weight: 700" />
                            </td>
                            <td class="style22">
                                &nbsp;</td>
                            <td class="style24">
                                <asp:Label ID="Label37" runat="server" Text="EMAIL ID" style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style16">
                                <asp:TextBox ID="txtemailid" runat="server" Width="177px"></asp:TextBox>
                            </td>
                            <td class="style18">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="txtemailid" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Enter 
                                Valid ID</asp:RegularExpressionValidator>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td class="style39">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td class="style4">
                                <asp:Label ID="Label47" runat="server" Text="PASSWORD" style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style34">
                                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style22">
                                &nbsp;</td>
                            <td class="style24">
                                <asp:Label ID="Label48" runat="server" Text="RE-ENTER PASSWORD" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style16">
                                <asp:TextBox ID="txtrepwd" runat="server" TextMode="Password" Width="177px"></asp:TextBox>
                            </td>
                            <td class="style18">
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ControlToCompare="txtpwd" ControlToValidate="txtrepwd" 
                                    ErrorMessage="Invalid Password"></asp:CompareValidator>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td class="style39">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style25">
                                </td>
                            <td class="style26">
                                </td>
                            <td class="style27">
                                <asp:Label ID="Label32" runat="server" Text="TEMPORARY ADDRESS" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style35">
                                <asp:TextBox ID="txttemadd" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                            </td>
                            <td class="style29">
                                </td>
                            <td class="style30">
                                <asp:Label ID="Label38" runat="server" Text="PINCODE" style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style31">
                                <asp:TextBox ID="txttpin" runat="server" Width="128px"></asp:TextBox>
                            </td>
                            <td class="style32">
                                </td>
                            <td class="style26">
                                </td>
                            <td class="style40">
                                </td>
                            <td class="style26">
                                </td>
                            <td class="style26">
                                </td>
                            <td class="style26">
                                </td>
                        </tr>
                        <tr>
                            <td class="style25">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style27">
                                <asp:Label ID="Label36" runat="server" Text="PERMANENT ADDRESS" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style35">
                                <asp:TextBox ID="txtperadd" runat="server" TextMode="MultiLine" Width="199px"></asp:TextBox>
                            </td>
                            <td class="style29">
                                &nbsp;</td>
                            <td class="style30">
                                <asp:Label ID="Label39" runat="server" Text="PINCODE" style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style31">
                                <asp:TextBox ID="txtppin" runat="server"></asp:TextBox>
                            </td>
                            <td class="style32">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style40">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style25">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style27">
                                &nbsp;</td>
                            <td class="style35">
                                &nbsp;</td>
                            <td class="style29">
                                &nbsp;</td>
                            <td class="style30">
                                &nbsp;</td>
                            <td class="style31">
                                &nbsp;</td>
                            <td class="style32">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style40">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                            <td class="style26">
                                &nbsp;</td>
                        </tr>
                    </table>
                    <asp:Panel ID="Panel2" runat="server">
                    </asp:Panel>
                </asp:Panel>
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
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style51">
                </td>
            <td class="style49">
                </td>
            <td class="style48">
                <asp:Panel ID="Panel3" runat="server" Height="352px" style="margin-top: 25px">
                    <table class="style1" style="height: 316px">
                        <tr>
                            <td class="style41" colspan="15">
                                <asp:Label ID="Label41" runat="server" Font-Bold="True" Font-Size="Large" 
                                    style="text-align: center" Text="OTHER DETAILS" ForeColor="#0D553A"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style41" colspan="15">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style43">
                                &nbsp;</td>
                            <td class="style42">
                                &nbsp;</td>
                            <td class="style44">
                                <asp:Label ID="Label40" runat="server" Text="QUALIFICATION" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style45">
                                <asp:TextBox ID="txtqua" runat="server" Width="206px"></asp:TextBox>
                            </td>
                            <td class="style46">
                                &nbsp;</td>
                            <td class="style47">
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
                            <td class="style43">
                                &nbsp;</td>
                            <td class="style42">
                                &nbsp;</td>
                            <td class="style44">
                                <asp:Label ID="Label42" runat="server" Text="EXPERIENCE(YEARS)" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style45">
                                <asp:TextBox ID="txtexp" runat="server" Height="22px" Width="205px"></asp:TextBox>
                            </td>
                            <td class="style46">
                                &nbsp;</td>
                            <td class="style47">
                                <asp:Label ID="Label43" runat="server" Text="TEACHING EXPERIENCE" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtteach" runat="server"></asp:TextBox>
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
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style43">
                                &nbsp;</td>
                            <td class="style42">
                                &nbsp;</td>
                            <td class="style44">
                                <asp:Label ID="Label45" runat="server" Text="DESIGNATION" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style45">
                                <asp:DropDownList ID="ddldesi" runat="server" Height="23px" Width="169px">
                                    <asp:ListItem>--select--</asp:ListItem>
                                    <asp:ListItem>PROFESSOR</asp:ListItem>
                                    <asp:ListItem>ASST.PROFESSOR</asp:ListItem>
                                    <asp:ListItem>ASSOCIATE PROFESSOR</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="style46">
                                &nbsp;</td>
                            <td class="style47">
                                <asp:Label ID="Label44" runat="server" Text="INDUSTRY EXPERIENCE" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtind" runat="server"></asp:TextBox>
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
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style43">
                                &nbsp;</td>
                            <td class="style42">
                                &nbsp;</td>
                            <td class="style44">
                                <asp:Label ID="Label46" runat="server" Text="PUBLICATIONS" 
                                    style="font-weight: 700"></asp:Label>
                            </td>
                            <td class="style45">
                                <asp:TextBox ID="txtpub" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                            <td class="style46">
                                &nbsp;</td>
                            <td class="style47">
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
                            <td class="style43">
                                &nbsp;</td>
                            <td class="style42">
                                &nbsp;</td>
                            <td class="style44">
                                &nbsp;</td>
                            <td class="style45">
                                &nbsp;</td>
                            <td class="style46">
                                &nbsp;</td>
                            <td class="style47">
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
                            <td class="style52">
                                </td>
                            <td class="style53">
                                </td>
                            <td class="style54">
                                </td>
                            <td class="style55">
                                </td>
                            <td class="style56">
                                </td>
                            <td class="style57">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                            <td class="style58">
                                </td>
                        </tr>
                        <tr>
                            <td class="style43">
                                &nbsp;</td>
                            <td class="style42">
                                &nbsp;</td>
                            <td class="style44">
                                &nbsp;</td>
                            <td class="style45">
                                <asp:Button ID="btnsbmt" runat="server" onclick="btnsbmt_Click" Text="SUBMIT" 
                                    Font-Bold="True" Font-Size="Medium" Width="102px" />
                            </td>
                            <td class="style46">
                                &nbsp;</td>
                            <td class="style47">
                                <asp:Button ID="btncancel" runat="server" Height="31px" Text="CANCEL" 
                                    Width="104px" onclick="btncancel_Click" Font-Bold="True" 
                                    Font-Size="Medium" />
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
                </asp:Panel>
            </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
            <td class="style48">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
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
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
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
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
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
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
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
            <td class="style50">
                &nbsp;</td>
            <td class="style2">
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

