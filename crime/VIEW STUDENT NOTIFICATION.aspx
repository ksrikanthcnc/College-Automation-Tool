<%@ Page Language="C#" MasterPageFile="~/STUDENT.master" AutoEventWireup="true" CodeFile="VIEW STUDENT NOTIFICATION.aspx.cs" Inherits="VIEW_STUDENT_NOTIFICATION" Title="VIEW STUDENT NOTIFICATION" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#A9C4F3">
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: center">
            <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                Text="LATEST UPDATES" ForeColor="#DF0000"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="COLLEGE EVENTS" ForeColor="#003300"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource1" Width="1271px">
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
    <tr>
        <td>
            <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="FEE DETAILS" ForeColor="#003300"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource2" Width="1269px">
                <Columns>
                    <asp:BoundField DataField="NOTIFICATION" HeaderText="NOTIFICATION" 
                        SortExpression="NOTIFICATION" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                SelectCommand="SELECT * FROM [ACCOUNTNOTIFICATION]"></asp:SqlDataSource>
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
            <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="STUDENT INFORMATION" ForeColor="#003300"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource3" Width="1265px">
                <Columns>
                    <asp:BoundField DataField="NOTIFICATION" HeaderText="NOTIFICATION" 
                        SortExpression="NOTIFICATION" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                SelectCommand="SELECT * FROM [STAFFNOTIFICATION]"></asp:SqlDataSource>
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
</table>
</asp:Content>

