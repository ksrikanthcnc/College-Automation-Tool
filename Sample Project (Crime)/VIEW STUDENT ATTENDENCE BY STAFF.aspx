<%@ Page Language="C#" MasterPageFile="~/STAFF.master" AutoEventWireup="true" CodeFile="VIEW STUDENT ATTENDENCE BY STAFF.aspx.cs" Inherits="VIEW_STUDENT_ATTENDENCE_BY_STAFF" Title="VIEW STUDENT ATTENDENCE BY STAFF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        width: 100%;
    }
    .style6
    {
            width: 1323px;
            text-align: right;
        }
    .style7
    {
            width: 166px;
            text-align: center;
        }
    .style8
    {
        height: 17px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style5" bgcolor="#FFFFCC">
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: center">
            <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="X-Large" 
                Text="STUDENT ATTENDENCE"></asp:Label>
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
                <table class="style5">
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
                            <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="DEPARTMENT"></asp:Label>
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
                            <asp:Button ID="btnsbmt" runat="server" Font-Bold="True" Font-Size="Medium" 
                                Text="SUBMIT" Width="106px" onclick="btnsbmt_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="YEAR/SEMESTER"></asp:Label>
                        </td>
                        <td class="style7">
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
            <asp:Panel ID="pnl1year" runat="server">
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource8">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 NO OF CLASSES" HeaderText="SUB1 NO OF CLASSES" 
                            SortExpression="SUB1 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB1 PRESENT DAYS" HeaderText="SUB1 PRESENT DAYS" 
                            SortExpression="SUB1 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 NO OF CLASSES" HeaderText="SUB2 NO OF CLASSES" 
                            SortExpression="SUB2 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB2 PRESENT DAYS" HeaderText="SUB2 PRESENT DAYS" 
                            SortExpression="SUB2 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 NO OF CLASSES" HeaderText="SUB3 NO OF CLASSES" 
                            SortExpression="SUB3 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB3 PRESENT DAYS" HeaderText="SUB3 PRESENT DAYS" 
                            SortExpression="SUB3 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 NO OF CLASSES" HeaderText="SUB4 NO OF CLASSES" 
                            SortExpression="SUB4 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB4 PRESENT DAYS" HeaderText="SUB4 PRESENT DAYS" 
                            SortExpression="SUB4 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 NO OF CLASSES" HeaderText="SUB5 NO OF CLASSES" 
                            SortExpression="SUB5 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB5 PRESENT DAYS" HeaderText="SUB5 PRESENT DAYS" 
                            SortExpression="SUB5 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 NO OF CLASSES" HeaderText="SUB6 NO OF CLASSES" 
                            SortExpression="SUB6 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB6 PRESENT DAYS" HeaderText="SUB6 PRESENT DAYS" 
                            SortExpression="SUB6 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT7" HeaderText="SUBJECT7" 
                            SortExpression="SUBJECT7" />
                        <asp:BoundField DataField="SUB7 NO OF CLASSES" HeaderText="SUB7 NO OF CLASSES" 
                            SortExpression="SUB7 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB7 PRESENT DAYS" HeaderText="SUB7 PRESENT DAYS" 
                            SortExpression="SUB7 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 NO OF CLASSES" HeaderText="LAB1 NO OF CLASSES" 
                            SortExpression="LAB1 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB1 PRESENT DAYS" HeaderText="LAB1 PRESENT DAYS" 
                            SortExpression="LAB1 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 NO OF CLASSES" HeaderText="LAB2 NO OF CLASSES" 
                            SortExpression="LAB2 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB2 PRESENT DAYS" HeaderText="LAB2 PRESENT DAYS" 
                            SortExpression="LAB2 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 NO OF CLASSES" HeaderText="LAB3 NO OF CLASSES" 
                            SortExpression="LAB3 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB3 PRESENT DAYS" HeaderText="LAB3 PRESENT DAYS" 
                            SortExpression="LAB3 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB4" HeaderText="LAB4" SortExpression="LAB4" />
                        <asp:BoundField DataField="LAB4 NO OF CLASSES" HeaderText="LAB4 NO OF CLASSES" 
                            SortExpression="LAB4 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB4 PRESENT DAYS" HeaderText="LAB4 PRESENT DAYS" 
                            SortExpression="LAB4 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB5" HeaderText="LAB5" SortExpression="LAB5" />
                        <asp:BoundField DataField="LAB5 NO OF CLASSES" HeaderText="LAB5 NO OF CLASSES" 
                            SortExpression="LAB5 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB5 PRESENT DAYS" HeaderText="LAB5 PRESENT DAYS" 
                            SortExpression="LAB5 PRESENT DAYS" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource8" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FSTYEARSTUDENTATTENDENCE] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FSTYEARSTUDENTATTENDENCE] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
        <td class="style8">
            <asp:Panel ID="pnl21" runat="server">
                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource9">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 NO OF CLASSES" HeaderText="SUB1 NO OF CLASSES" 
                            SortExpression="SUB1 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB1 PRESENT DAYS" HeaderText="SUB1 PRESENT DAYS" 
                            SortExpression="SUB1 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 NO OF CLASSES" HeaderText="SUB2 NO OF CLASSES" 
                            SortExpression="SUB2 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB2 PRESENT DAYS" HeaderText="SUB2 PRESENT DAYS" 
                            SortExpression="SUB2 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 NO OF CLASSES" HeaderText="SUB3 NO OF CLASSES" 
                            SortExpression="SUB3 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB3 PRESENT DAYS" HeaderText="SUB3 PRESENT DAYS" 
                            SortExpression="SUB3 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 NO OF CLASSES" HeaderText="SUB4 NO OF CLASSES" 
                            SortExpression="SUB4 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB4 PRESENT DAYS" HeaderText="SUB4 PRESENT DAYS" 
                            SortExpression="SUB4 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 NO OF CLASSES" HeaderText="SUB5 NO OF CLASSES" 
                            SortExpression="SUB5 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB5 PRESENT DAYS" HeaderText="SUB5 PRESENT DAYS" 
                            SortExpression="SUB5 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 NO OF CLASSES" HeaderText="SUB6 NO OF CLASSES" 
                            SortExpression="SUB6 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB6 PRESENT DAYS" HeaderText="SUB6 PRESENT DAYS" 
                            SortExpression="SUB6 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 NO OF CLASSES" HeaderText="LAB1 NO OF CLASSES" 
                            SortExpression="LAB1 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB1 PRESENT DAYS" HeaderText="LAB1 PRESENT DAYS" 
                            SortExpression="LAB1 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 NO OF CLASSES" HeaderText="LAB2 NO OF CLASSES" 
                            SortExpression="LAB2 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB2 PRESENT DAYS" HeaderText="LAB2 PRESENT DAYS" 
                            SortExpression="LAB2 PRESENT DAYS" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource9" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOONEYEARSTUDENTATTENDENCE] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOONEYEARSTUDENTATTENDENCE] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
            <asp:Panel ID="pnl22" runat="server">
                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource10">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 NO OF CLASSES" HeaderText="SUB1 NO OF CLASSES" 
                            SortExpression="SUB1 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB1 PRESENT DAYS" HeaderText="SUB1 PRESENT DAYS" 
                            SortExpression="SUB1 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 NO OF CLASSES" HeaderText="SUB2 NO OF CLASSES" 
                            SortExpression="SUB2 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB2 PRESENT DAYS" HeaderText="SUB2 PRESENT DAYS" 
                            SortExpression="SUB2 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 NO OF CLASSES" HeaderText="SUB3 NO OF CLASSES" 
                            SortExpression="SUB3 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB3 PRESENT DAYS" HeaderText="SUB3 PRESENT DAYS" 
                            SortExpression="SUB3 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 NO OF CLASSES" HeaderText="SUB4 NO OF CLASSES" 
                            SortExpression="SUB4 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB4 PRESENT DAYS" HeaderText="SUB4 PRESENT DAYS" 
                            SortExpression="SUB4 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 NO OF CLASSES" HeaderText="SUB5 NO OF CLASSES" 
                            SortExpression="SUB5 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB5 PRESENT DAYS" HeaderText="SUB5 PRESENT DAYS" 
                            SortExpression="SUB5 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 NO OF CLASSES" HeaderText="SUB6 NO OF CLASSES" 
                            SortExpression="SUB6 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB6 PRESENT DAYS" HeaderText="SUB6 PRESENT DAYS" 
                            SortExpression="SUB6 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 NO OF CLASSES" HeaderText="LAB1 NO OF CLASSES" 
                            SortExpression="LAB1 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB1 PRESENT DAYS" HeaderText="LAB1 PRESENT DAYS" 
                            SortExpression="LAB1 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 NO OF CLASSES" HeaderText="LAB2 NO OF CLASSES" 
                            SortExpression="LAB2 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB2 PRESENT DAYS" HeaderText="LAB2 PRESENT DAYS" 
                            SortExpression="LAB2 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 NO OF CLASSES" HeaderText="LAB3 NO OF CLASSES" 
                            SortExpression="LAB3 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB3 PRESENT DAYS" HeaderText="LAB3 PRESENT DAYS" 
                            SortExpression="LAB3 PRESENT DAYS" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource10" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOTWOYEARSTUDENTATTENDENCE] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOTWOYEARSTUDENTATTENDENCE] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
            <asp:Panel ID="pnl31" runat="server">
                <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource11">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 NO OF CLASSES" HeaderText="SUB1 NO OF CLASSES" 
                            SortExpression="SUB1 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB1 PRESENT DAYS" HeaderText="SUB1 PRESENT DAYS" 
                            SortExpression="SUB1 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 NO OF CLASSES" HeaderText="SUB2 NO OF CLASSES" 
                            SortExpression="SUB2 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB2 PRESENT DAYS" HeaderText="SUB2 PRESENT DAYS" 
                            SortExpression="SUB2 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 NO OF CLASSES" HeaderText="SUB3 NO OF CLASSES" 
                            SortExpression="SUB3 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB3 PRESENT DAYS" HeaderText="SUB3 PRESENT DAYS" 
                            SortExpression="SUB3 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 NO OF CLASSES" HeaderText="SUB4 NO OF CLASSES" 
                            SortExpression="SUB4 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB4 PRESENT DAYS" HeaderText="SUB4 PRESENT DAYS" 
                            SortExpression="SUB4 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 NO OF CLASSES" HeaderText="SUB5 NO OF CLASSES" 
                            SortExpression="SUB5 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB5 PRESENT DAYS" HeaderText="SUB5 PRESENT DAYS" 
                            SortExpression="SUB5 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 NO OF CLASSES" HeaderText="SUB6 NO OF CLASSES" 
                            SortExpression="SUB6 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB6 PRESENT DAYS" HeaderText="SUB6 PRESENT DAYS" 
                            SortExpression="SUB6 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 NO OF CLASSES" HeaderText="LAB1 NO OF CLASSES" 
                            SortExpression="LAB1 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB1 PRESENT DAYS" HeaderText="LAB1 PRESENT DAYS" 
                            SortExpression="LAB1 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 NO OF CLASSES" HeaderText="LAB2 NO OF CLASSES" 
                            SortExpression="LAB2 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB2 PRESENT DAYS" HeaderText="LAB2 PRESENT DAYS" 
                            SortExpression="LAB2 PRESENT DAYS" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource11" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREEONEYEARSTUDENTATTENDENCE] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREEONEYEARSTUDENTATTENDENCE] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
            <asp:Panel ID="pnl32" runat="server">
                <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREETWOYEARSTUDENTATTENDENCE] WHERE ([DEPARTMENT] = @DEPARTMENT)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddldept" Name="DEPARTMENT" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource12">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 NO OF CLASSES" HeaderText="SUB1 NO OF CLASSES" 
                            SortExpression="SUB1 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB1 PRESENT DAYS" HeaderText="SUB1 PRESENT DAYS" 
                            SortExpression="SUB1 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 NO OF CLASSES" HeaderText="SUB2 NO OF CLASSES" 
                            SortExpression="SUB2 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB2 PRESENT DAYS" HeaderText="SUB2 PRESENT DAYS" 
                            SortExpression="SUB2 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 NO OF CLASSES" HeaderText="SUB3 NO OF CLASSES" 
                            SortExpression="SUB3 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB3 PRESENT DAYS" HeaderText="SUB3 PRESENT DAYS" 
                            SortExpression="SUB3 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 NO OF CLASSES" HeaderText="SUB4 NO OF CLASSES" 
                            SortExpression="SUB4 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB4 PRESENT DAYS" HeaderText="SUB4 PRESENT DAYS" 
                            SortExpression="SUB4 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 NO OF CLASSES" HeaderText="SUB5 NO OF CLASSES" 
                            SortExpression="SUB5 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB5 PRESENT DAYS" HeaderText="SUB5 PRESENT DAYS" 
                            SortExpression="SUB5 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 NO OF CLASSES" HeaderText="SUB6 NO OF CLASSES" 
                            SortExpression="SUB6 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB6 PRESENT DAYS" HeaderText="SUB6 PRESENT DAYS" 
                            SortExpression="SUB6 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 NO OF CLASSES" HeaderText="LAB1 NO OF CLASSES" 
                            SortExpression="LAB1 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB1 PRESENT DAYS" HeaderText="LAB1 PRESENT DAYS" 
                            SortExpression="LAB1 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 NO OF CLASSES" HeaderText="LAB2 NO OF CLASSES" 
                            SortExpression="LAB2 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB2 PRESENT DAYS" HeaderText="LAB2 PRESENT DAYS" 
                            SortExpression="LAB2 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 NO OF CLASSES" HeaderText="LAB3 NO OF CLASSES" 
                            SortExpression="LAB3 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB3 PRESENT DAYS" HeaderText="LAB3 PRESENT DAYS" 
                            SortExpression="LAB3 PRESENT DAYS" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource12" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREETWOYEARSTUDENTATTENDENCE] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>
                <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource13" 
                onselectedindexchanged="GridView8_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 NO OF CLASSES" HeaderText="SUB1 NO OF CLASSES" 
                            SortExpression="SUB1 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB1 PRESENT DAYS" HeaderText="SUB1 PRESENT DAYS" 
                            SortExpression="SUB1 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 NO OF CLASSES" HeaderText="SUB2 NO OF CLASSES" 
                            SortExpression="SUB2 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB2 PRESENT DAYS" HeaderText="SUB2 PRESENT DAYS" 
                            SortExpression="SUB2 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 NO OF CLASSES" HeaderText="SUB3 NO OF CLASSES" 
                            SortExpression="SUB3 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB3 PRESENT DAYS" HeaderText="SUB3 PRESENT DAYS" 
                            SortExpression="SUB3 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 NO OF CLASSES" HeaderText="SUB4 NO OF CLASSES" 
                            SortExpression="SUB4 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB4 PRESENT DAYS" HeaderText="SUB4 PRESENT DAYS" 
                            SortExpression="SUB4 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 NO OF CLASSES" HeaderText="SUB5 NO OF CLASSES" 
                            SortExpression="SUB5 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB5 PRESENT DAYS" HeaderText="SUB5 PRESENT DAYS" 
                            SortExpression="SUB5 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 NO OF CLASSES" HeaderText="SUB6 NO OF CLASSES" 
                            SortExpression="SUB6 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB6 PRESENT DAYS" HeaderText="SUB6 PRESENT DAYS" 
                            SortExpression="SUB6 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 NO OF CLASSES" HeaderText="LAB1 NO OF CLASSES" 
                            SortExpression="LAB1 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB1 PRESENT DAYS" HeaderText="LAB1 PRESENT DAYS" 
                            SortExpression="LAB1 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 NO OF CLASSES" HeaderText="LAB2 NO OF CLASSES" 
                            SortExpression="LAB2 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB2 PRESENT DAYS" HeaderText="LAB2 PRESENT DAYS" 
                            SortExpression="LAB2 PRESENT DAYS" />
                    </Columns>
                </asp:GridView>
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
            <asp:Panel ID="pnl41" runat="server">
                <asp:SqlDataSource ID="SqlDataSource13" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURONEYEARSTUDENTATTENDENCE] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURONEYEARSTUDENTATTENDENCE] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
            <asp:Panel ID="pnl42" runat="server">
                <asp:GridView ID="GridView9" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource14">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 NO OF CLASSES" HeaderText="SUB1 NO OF CLASSES" 
                            SortExpression="SUB1 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB1 PRESENT DAYS" HeaderText="SUB1 PRESENT DAYS" 
                            SortExpression="SUB1 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 NO OF CLASSES" HeaderText="SUB2 NO OF CLASSES" 
                            SortExpression="SUB2 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB2 PRESENT DAYS" HeaderText="SUB2 PRESENT DAYS" 
                            SortExpression="SUB2 PRESENT DAYS" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 NO OF CLASSES" HeaderText="SUB3 NO OF CLASSES" 
                            SortExpression="SUB3 NO OF CLASSES" />
                        <asp:BoundField DataField="SUB3 PRESENT DAYS" HeaderText="SUB3 PRESENT DAYS" 
                            SortExpression="SUB3 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 NO OF CLASSES" HeaderText="LAB1 NO OF CLASSES" 
                            SortExpression="LAB1 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB1 PRESENT DAYS" HeaderText="LAB1 PRESENT DAYS" 
                            SortExpression="LAB1 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 NO OF CLASSES" HeaderText="LAB2 NO OF CLASSES" 
                            SortExpression="LAB2 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB2 PRESENT DAYS" HeaderText="LAB2 PRESENT DAYS" 
                            SortExpression="LAB2 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 NO OF CLASSES" HeaderText="LAB3 NO OF CLASSES" 
                            SortExpression="LAB3 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB3 PRESENT DAYS" HeaderText="LAB3 PRESENT DAYS" 
                            SortExpression="LAB3 PRESENT DAYS" />
                        <asp:BoundField DataField="LAB4" HeaderText="LAB4" SortExpression="LAB4" />
                        <asp:BoundField DataField="LAB4 NO OF CLASSES" HeaderText="LAB4 NO OF CLASSES" 
                            SortExpression="LAB4 NO OF CLASSES" />
                        <asp:BoundField DataField="LAB4 PRESENT DAYS" HeaderText="LAB4 PRESENT DAYS" 
                            SortExpression="LAB4 PRESENT DAYS" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource14" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURTWOYEARSTUDENTATTENDENCE] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURTWOYEARSTUDENTATTENDENCE] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
</table>
</asp:Content>

