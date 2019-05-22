<%@ Page Language="C#" MasterPageFile="~/STUDENT.master" AutoEventWireup="true" CodeFile="VIEW FEE DETAILS.aspx.cs" Inherits="VIEW_FEE_DETAILS" Title="VIEW FEE DETAILS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
            width: 451px;
            text-align: right;
        }
    .style7
    {
            width: 437px;
            text-align: center;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#A9C4F3">
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: center">
            <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                ForeColor="#CC0066" Text="FEE DETAILS"></asp:Label>
        </td>
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
                        <td class="style6">
                            <asp:Label ID="Label18" runat="server" Font-Bold="True" Text="DEPARTMENT"></asp:Label>
                        </td>
                        <td class="style7">
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
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            &nbsp;</td>
                        <td class="style7">
                            <asp:Button ID="btnsbmt" runat="server" Font-Bold="True" Font-Size="Medium" 
                                onclick="btnsbmt_Click" Text="SUBMIT" Width="85px" />
                        </td>
                        <td>
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
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="ID_NUMBER" DataSourceID="SqlDataSource1" Width="1254px">
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
</table>
</asp:Content>

