<%@ Page Title="" Language="C#" MasterPageFile="~/student.master" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="student1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
width:435px;        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
        <table style="border:inset;"><tr><td class="auto-style4">
  <h4>  Registration Details</h4>
            <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" >
        <Columns>
            <asp:BoundField DataField="cgpa" HeaderText="cgpa" SortExpression="cgpa" />
            <asp:BoundField DataField="branch" HeaderText="branch" SortExpression="branch" />
            <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
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
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sriConnectionString2 %>" SelectCommand="SELECT DISTINCT [cgpa], [branch], [sem] FROM [student_sem_reg] WHERE ([uname] = @uname)">
    <SelectParameters>
        <asp:SessionParameter Name="uname" SessionField="ID" Type="String" />
    </SelectParameters>
</asp:SqlDataSource>
    <br />
    <h4>TUITION details</h4>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
            <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
            <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
            <asp:BoundField DataField="du" HeaderText="du" SortExpression="du" />
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
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:sriConnectionString2 %>" SelectCommand="SELECT DISTINCT [sem], [amount], [date], [du] FROM [tution] WHERE ([uname] = @uname)">
        <SelectParameters>
            <asp:SessionParameter Name="uname" SessionField="ID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
   <h4> HOSTEL details</h4><br />
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
            <asp:BoundField DataField="hostel" HeaderText="hostel" SortExpression="hostel" />
            <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
            <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
            <asp:BoundField DataField="du" HeaderText="du" SortExpression="du" />
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
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:sriConnectionString2 %>" SelectCommand="SELECT DISTINCT [sem], [hostel], [amount], [date], [du] FROM [hostel] WHERE ([uname] = @uname)">
        <SelectParameters>
            <asp:SessionParameter Name="uname" SessionField="ID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br /></td><td style="vertical-align:top;">
    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" >
        <Columns>
            <asp:BoundField DataField="attendence" HeaderText="attendence" SortExpression="attendence" />
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
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:sriConnectionString2 %>" SelectCommand="SELECT DISTINCT [attendence] FROM [student_marks] WHERE ([uname] = @uname)">
        <SelectParameters>
            <asp:SessionParameter Name="uname" SessionField="ID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
                <h4>
    Course- wise marks</h4>
                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:BoundField DataField="c1" HeaderText="c1" SortExpression="c1" />
            <asp:BoundField DataField="c3" HeaderText="c3" SortExpression="c3" />
            <asp:BoundField DataField="c2" HeaderText="c2" SortExpression="c2" />
            <asp:BoundField DataField="c4" HeaderText="c4" SortExpression="c4" />
            <asp:BoundField DataField="c5" HeaderText="c5" SortExpression="c5" />
            <asp:BoundField DataField="c6" HeaderText="c6" SortExpression="c6" />
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
    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:sriConnectionString2 %>" SelectCommand="SELECT DISTINCT [c1], [c3], [c2], [c4], [c5], [c6] FROM [student_marks] WHERE ([uname] = @uname)">
        <SelectParameters>
            <asp:SessionParameter Name="uname" SessionField="ID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
        </td></tr>
        </table></form>
</asp:Content>


