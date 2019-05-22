<%@ Page Language="C#" MasterPageFile="~/ADMINMASTER.master" AutoEventWireup="true" CodeFile="VIEW FEE DETAILS BY ADMIN.aspx.cs" Inherits="VIEW_FEE_DETAILS_BY_ADMIN" Title="VIEW FEE DETAILS BY ADMIN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 629px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table bgcolor="#FFCCFF" class="style1">
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
                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                    ForeColor="#CC0000" Text="STUDENT FEE DETAILS"></asp:Label>
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
                            <td class="style2" style="text-align: center">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label19" runat="server" Font-Bold="True" Text="DEPARTMENT" 
                                    style="text-align: center"></asp:Label>
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
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center">
                                <asp:Button ID="btnsbmt" runat="server" Font-Bold="True" Font-Size="Medium" 
                                    Text="SUBMIT" Width="98px" />
                            </td>
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
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnl1yr" runat="server">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="SqlDataSource1" Width="1262px">
                        <Columns>
                            <asp:BoundField DataField="ID_NUMBER" HeaderText="ID_NUMBER" 
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
    </table>
</asp:Content>

