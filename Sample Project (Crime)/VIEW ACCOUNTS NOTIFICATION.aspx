<%@ Page Language="C#" MasterPageFile="~/ACCOUNTS.master" AutoEventWireup="true" CodeFile="VIEW ACCOUNTS NOTIFICATION.aspx.cs" Inherits="VIEW_ACCOUNTS_NOTIFICATION" Title="VIEW ACCOUNTS NOTIFICATION" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#C6FFAA">
        <tr>
            <td style="text-align: center">
                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                    Text="LATEST UPDATES" ForeColor="#009393"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource1" Width="1286px">
                    <Columns>
                        <asp:BoundField DataField="NOTIFICATION" HeaderText="NOTIFICATION" 
                            SortExpression="NOTIFICATION" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [ADMINNOTIFICATION]"></asp:SqlDataSource>
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
    </table>
</asp:Content>

