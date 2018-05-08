<%@ Page Title="" Language="C#" MasterPageFile="~/staff.master" AutoEventWireup="true" CodeFile="staff_tt_view.aspx.cs" Inherits="staff_tt_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <p>
            Time Table</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <Columns>
                    <asp:BoundField DataField="column1" HeaderText="column1" SortExpression="column1" />
                    <asp:BoundField DataField="column2" HeaderText="column2" SortExpression="column2" />
                    <asp:BoundField DataField="column3" HeaderText="column3" SortExpression="column3" />
                    <asp:BoundField DataField="column4" HeaderText="column4" SortExpression="column4" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sriConnectionString2 %>" SelectCommand="SELECT DISTINCT [1st] AS column1, [2nd] AS column2, [3rd] AS column3, [4th] AS column4 FROM [staff_tt] WHERE ([uname] = @uname)">
                <SelectParameters>
                    <asp:SessionParameter Name="uname" SessionField="ID" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Pay Slip</p>
        <p>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <Columns>
                    <asp:BoundField DataField="month" HeaderText="month" SortExpression="month" />
                    <asp:BoundField DataField="gross" HeaderText="gross" SortExpression="gross" />
                    <asp:BoundField DataField="cuts" HeaderText="cuts" SortExpression="cuts" />
                    <asp:BoundField DataField="net" HeaderText="net" SortExpression="net" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:sriConnectionString2 %>" SelectCommand="SELECT DISTINCT [month], [gross], [cuts], [net] FROM [staff_ps] WHERE ([uname] = @uname)">
                <SelectParameters>
                    <asp:SessionParameter Name="uname" SessionField="ID" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
    </form>
</asp:Content>

