<%@ Page Language="C#" MasterPageFile="~/ACCOUNTS.master" AutoEventWireup="true" CodeFile="VIEW STUDENT FEE DETAILS BY ACCOUNTS.aspx.cs" Inherits="VIEW_STUDENT_FEE_DETAILS_BY_ACCOUNTS" Title="VIEW STUDENT FEE DETAILS BY ACCOUNTS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
            width: 166px;
        }
        .style7
        {
            width: 676px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#C6FFAA">
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: center">
            <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                Text="STUDENT FEE DETAILS" ForeColor="#0080FF"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Panel ID="pnl1" runat="server">
                <table class="style1">
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="DEPARTMENT"></asp:Label>
                        </td>
                        <td class="style6">
                            <asp:DropDownList ID="ddldept" runat="server">
                                <asp:ListItem>--SELECT--</asp:ListItem>
                                <asp:ListItem>CSE</asp:ListItem>
                                <asp:ListItem>ECE</asp:ListItem>
                                <asp:ListItem>IT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style6">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style6">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center">
                            <asp:Button ID="btnsbmt" runat="server" Font-Bold="True" Font-Size="Medium" 
                                onclick="btnsbmt_Click" Text="SUBMIT" Width="114px" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Panel ID="pnl1yr" runat="server">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="ID_NUMBER" DataSourceID="SqlDataSource1" Width="1265px">
                    <Columns>
                        <asp:BoundField DataField="ID_NUMBER" HeaderText="ID_NUMBER" ReadOnly="True" 
                            SortExpression="ID_NUMBER" />
                        <asp:BoundField DataField="NAME_OF_THE_CANDIDATE" 
                            HeaderText="NAME_OF_THE_CANDIDATE" SortExpression="NAME_OF_THE_CANDIDATE" />
                        <asp:BoundField DataField="TOTALAMOUNT" HeaderText="TOTALAMOUNT" 
                            SortExpression="TOTALAMOUNT" />
                        <asp:BoundField DataField="AMOUNTPAID" HeaderText="AMOUNTPAID" 
                            SortExpression="AMOUNTPAID" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT [ID NUMBER] AS ID_NUMBER, [NAME OF THE CANDIDATE] AS NAME_OF_THE_CANDIDATE, [TOTALAMOUNT], [AMOUNTPAID] FROM [STUDENTREGISTRATION] WHERE ([DEPARTMENT] = @DEPARTMENT)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddldept" Name="DEPARTMENT" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

