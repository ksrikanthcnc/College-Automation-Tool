<%@ Page Language="C#" MasterPageFile="~/STAFF.master" AutoEventWireup="true" CodeFile="VIEW STUDENT MARKS BY STAFF.aspx.cs" Inherits="VIEW_STUDENT_MARKS_BY_STAFF" Title="VIEW STUDENT MARKS BY STAFF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        width: 100%;
    }
        .style6
        {
            text-align: right;
            height: 2px;
            width: 4305px;
        }
        .style7
        {
            height: 2px;
        }
        .style8
        {
            text-align: center;
            width: 145px;
        }
        .style9
        {
            text-align: center;
            height: 2px;
            width: 145px;
        }
        .style10
        {
            text-align: right;
            width: 4305px;
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
            <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                Text="STUDENT EXAMINATION DETAILS" ForeColor="#6666FF"></asp:Label>
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
            <asp:Panel ID="Panel1" runat="server">
                <table class="style1">
                    <tr>
                        <td colspan="3">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style10">
                            <asp:Label ID="Label25" runat="server" Font-Bold="True" 
                Text="DEPARTMENT"></asp:Label>
                        </td>
                        <td class="style8">
                            <asp:DropDownList ID="ddldept" runat="server" Height="16px" Width="95px">
                                <asp:ListItem>--SELECT--</asp:ListItem>
                                <asp:ListItem>CSE</asp:ListItem>
                                <asp:ListItem>ECE</asp:ListItem>
                                <asp:ListItem>IT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style6">
                            </td>
                        <td class="style9">
                            &nbsp;</td>
                        <td style="text-align: center" class="style7">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style10">
                            <asp:Label ID="Label26" runat="server" Font-Bold="True" 
                Text="YEAR/SEMESTER"></asp:Label>
                        </td>
                        <td class="style8">
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
                            <asp:Button ID="btnsbmt" runat="server" Font-Bold="True" Font-Size="Medium" 
                                Height="29px" Text="SUBMIT" Width="90px" onclick="btnsbmt_Click" />
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
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
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
                        <asp:BoundField DataField="SUB1 THEORY1" HeaderText="SUB1 THEORY1" 
                            SortExpression="SUB1 THEORY1" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE1" HeaderText="SUB1 OBJECTIVE1" 
                            SortExpression="SUB1 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT1" HeaderText="SUB1 ASSIGNMENT1" 
                            SortExpression="SUB1 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB1 THEORY2" HeaderText="SUB1 THEORY2" 
                            SortExpression="SUB1 THEORY2" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE2" HeaderText="SUB1 OBJECTIVE2" 
                            SortExpression="SUB1 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT2" HeaderText="SUB1 ASSIGNMENT2" 
                            SortExpression="SUB1 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB1 THEORY3" HeaderText="SUB1 THEORY3" 
                            SortExpression="SUB1 THEORY3" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE3" HeaderText="SUB1 OBJECTIVE3" 
                            SortExpression="SUB1 OBJECTIVE3" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT3" HeaderText="SUB1 ASSIGNMENT3" 
                            SortExpression="SUB1 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB1 EXTERNAL" HeaderText="SUB1 EXTERNAL" 
                            SortExpression="SUB1 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 THEORY1" HeaderText="SUB2 THEORY1" 
                            SortExpression="SUB2 THEORY1" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE1" HeaderText="SUB2 OBJECTIVE1" 
                            SortExpression="SUB2 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT1" HeaderText="SUB2 ASSIGNMENT1" 
                            SortExpression="SUB2 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB2 THEORY2" HeaderText="SUB2 THEORY2" 
                            SortExpression="SUB2 THEORY2" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE2" HeaderText="SUB2 OBJECTIVE2" 
                            SortExpression="SUB2 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT2" HeaderText="SUB2 ASSIGNMENT2" 
                            SortExpression="SUB2 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB2 THEORY3" HeaderText="SUB2 THEORY3" 
                            SortExpression="SUB2 THEORY3" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE3" HeaderText="SUB2 OBJECTIVE3" 
                            SortExpression="SUB2 OBJECTIVE3" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT3" HeaderText="SUB2 ASSIGNMENT3" 
                            SortExpression="SUB2 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB2 EXTERNAL" HeaderText="SUB2 EXTERNAL" 
                            SortExpression="SUB2 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 THEORY1" HeaderText="SUB3 THEORY1" 
                            SortExpression="SUB3 THEORY1" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE1" HeaderText="SUB3 OBJECTIVE1" 
                            SortExpression="SUB3 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT1" HeaderText="SUB3 ASSIGNMENT1" 
                            SortExpression="SUB3 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB3 THEORY2" HeaderText="SUB3 THEORY2" 
                            SortExpression="SUB3 THEORY2" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE2" HeaderText="SUB3 OBJECTIVE2" 
                            SortExpression="SUB3 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT2" HeaderText="SUB3 ASSIGNMENT2" 
                            SortExpression="SUB3 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB3 THEORY3" HeaderText="SUB3 THEORY3" 
                            SortExpression="SUB3 THEORY3" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE3" HeaderText="SUB3 OBJECTIVE3" 
                            SortExpression="SUB3 OBJECTIVE3" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT3" HeaderText="SUB3 ASSIGNMENT3" 
                            SortExpression="SUB3 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB3 EXTERNAL" HeaderText="SUB3 EXTERNAL" 
                            SortExpression="SUB3 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 THEORY1" HeaderText="SUB4 THEORY1" 
                            SortExpression="SUB4 THEORY1" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE1" HeaderText="SUB4 OBJECTIVE1" 
                            SortExpression="SUB4 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT1" HeaderText="SUB4 ASSIGNMENT1" 
                            SortExpression="SUB4 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB4 THEORY2" HeaderText="SUB4 THEORY2" 
                            SortExpression="SUB4 THEORY2" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE2" HeaderText="SUB4 OBJECTIVE2" 
                            SortExpression="SUB4 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT2" HeaderText="SUB4 ASSIGNMENT2" 
                            SortExpression="SUB4 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB4 THEORY3" HeaderText="SUB4 THEORY3" 
                            SortExpression="SUB4 THEORY3" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE3" HeaderText="SUB4 OBJECTIVE3" 
                            SortExpression="SUB4 OBJECTIVE3" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT3" HeaderText="SUB4 ASSIGNMENT3" 
                            SortExpression="SUB4 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB4 EXTERNAL" HeaderText="SUB4 EXTERNAL" 
                            SortExpression="SUB4 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 THEORY1" HeaderText="SUB5 THEORY1" 
                            SortExpression="SUB5 THEORY1" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE1" HeaderText="SUB5 OBJECTIVE1" 
                            SortExpression="SUB5 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT1" HeaderText="SUB5 ASSIGNMENT1" 
                            SortExpression="SUB5 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB5 THEORY2" HeaderText="SUB5 THEORY2" 
                            SortExpression="SUB5 THEORY2" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE2" HeaderText="SUB5 OBJECTIVE2" 
                            SortExpression="SUB5 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT2" HeaderText="SUB5 ASSIGNMENT2" 
                            SortExpression="SUB5 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB5 THEORY3" HeaderText="SUB5 THEORY3" 
                            SortExpression="SUB5 THEORY3" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE3" HeaderText="SUB5 OBJECTIVE3" 
                            SortExpression="SUB5 OBJECTIVE3" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT3" HeaderText="SUB5 ASSIGNMENT3" 
                            SortExpression="SUB5 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB5 EXTERNAL" HeaderText="SUB5 EXTERNAL" 
                            SortExpression="SUB5 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 THEORY1" HeaderText="SUB6 THEORY1" 
                            SortExpression="SUB6 THEORY1" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE1" HeaderText="SUB6 OBJECTIVE1" 
                            SortExpression="SUB6 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT1" HeaderText="SUB6 ASSIGNMENT1" 
                            SortExpression="SUB6 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB6 THEORY2" HeaderText="SUB6 THEORY2" 
                            SortExpression="SUB6 THEORY2" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE2" HeaderText="SUB6 OBJECTIVE2" 
                            SortExpression="SUB6 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT2" HeaderText="SUB6 ASSIGNMENT2" 
                            SortExpression="SUB6 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB6 THEORY3" HeaderText="SUB6 THEORY3" 
                            SortExpression="SUB6 THEORY3" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE3" HeaderText="SUB6 OBJECTIVE3" 
                            SortExpression="SUB6 OBJECTIVE3" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT3" HeaderText="SUB6 ASSIGNMENT3" 
                            SortExpression="SUB6 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB6 EXTERNAL" HeaderText="SUB6 EXTERNAL" 
                            SortExpression="SUB6 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT7" HeaderText="SUBJECT7" 
                            SortExpression="SUBJECT7" />
                        <asp:BoundField DataField="SUB7 THEORY1" HeaderText="SUB7 THEORY1" 
                            SortExpression="SUB7 THEORY1" />
                        <asp:BoundField DataField="SUB7 OBJECTIVE1" HeaderText="SUB7 OBJECTIVE1" 
                            SortExpression="SUB7 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB7 ASSIGNMENT1" HeaderText="SUB7 ASSIGNMENT1" 
                            SortExpression="SUB7 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB7 THEORY2" HeaderText="SUB7 THEORY2" 
                            SortExpression="SUB7 THEORY2" />
                        <asp:BoundField DataField="SUB7 OBJECTIVE2" HeaderText="SUB7 OBJECTIVE2" 
                            SortExpression="SUB7 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB7 ASSIGNMENT2" HeaderText="SUB7 ASSIGNMENT2" 
                            SortExpression="SUB7 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB7 THEORY3" HeaderText="SUB7 THEORY3" 
                            SortExpression="SUB7 THEORY3" />
                        <asp:BoundField DataField="SUB7 OBJECTIVE3" HeaderText="SUB7 OBJECTIVE3" 
                            SortExpression="SUB7 OBJECTIVE3" />
                        <asp:BoundField DataField="SUB7 ASSIGNMENT3" HeaderText="SUB7 ASSIGNMENT3" 
                            SortExpression="SUB7 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB7 EXTERNAL" HeaderText="SUB7 EXTERNAL" 
                            SortExpression="SUB7 EXTERNAL" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 INTERNAL1" HeaderText="LAB1 INTERNAL1" 
                            SortExpression="LAB1 INTERNAL1" />
                        <asp:BoundField DataField="LAB1 INTERNAL2" HeaderText="LAB1 INTERNAL2" 
                            SortExpression="LAB1 INTERNAL2" />
                        <asp:BoundField DataField="LAB1 EXTERNAL" HeaderText="LAB1 EXTERNAL" 
                            SortExpression="LAB1 EXTERNAL" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 INTERNAL1" HeaderText="LAB2 INTERNAL1" 
                            SortExpression="LAB2 INTERNAL1" />
                        <asp:BoundField DataField="LAB2 INTERNAL2" HeaderText="LAB2 INTERNAL2" 
                            SortExpression="LAB2 INTERNAL2" />
                        <asp:BoundField DataField="LAB2 EXTERNAL" HeaderText="LAB2 EXTERNAL" 
                            SortExpression="LAB2 EXTERNAL" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 INTERNAL1" HeaderText="LAB3 INTERNAL1" 
                            SortExpression="LAB3 INTERNAL1" />
                        <asp:BoundField DataField="LAB3 INTERNAL2" HeaderText="LAB3 INTERNAL2" 
                            SortExpression="LAB3 INTERNAL2" />
                        <asp:BoundField DataField="LAB3 EXTERNAL" HeaderText="LAB3 EXTERNAL" 
                            SortExpression="LAB3 EXTERNAL" />
                        <asp:BoundField DataField="LAB4" HeaderText="LAB4" SortExpression="LAB4" />
                        <asp:BoundField DataField="LAB4 INTERNAL1" HeaderText="LAB4 INTERNAL1" 
                            SortExpression="LAB4 INTERNAL1" />
                        <asp:BoundField DataField="LAB4 INTERNAL2" HeaderText="LAB4 INTERNAL2" 
                            SortExpression="LAB4 INTERNAL2" />
                        <asp:BoundField DataField="LAB4 EXTERNAL" HeaderText="LAB4 EXTERNAL" 
                            SortExpression="LAB4 EXTERNAL" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource8" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FSTYEARSTUDENTEXAMINATIONDETAILS] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FSTYEARSTUDENTEXAMINATIONDETAILS] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
            <asp:Panel ID="pnl21" runat="server">
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
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
                        <asp:BoundField DataField="SUB1 THEORY1" HeaderText="SUB1 THEORY1" 
                            SortExpression="SUB1 THEORY1" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE1" HeaderText="SUB1 OBJECTIVE1" 
                            SortExpression="SUB1 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT1" HeaderText="SUB1 ASSIGNMENT1" 
                            SortExpression="SUB1 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB1 THEORY2" HeaderText="SUB1 THEORY2" 
                            SortExpression="SUB1 THEORY2" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE2" HeaderText="SUB1 OBJECTIVE2" 
                            SortExpression="SUB1 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT2" HeaderText="SUB1 ASSIGNMENT2" 
                            SortExpression="SUB1 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB1 EXTERNAL" HeaderText="SUB1 EXTERNAL" 
                            SortExpression="SUB1 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 THEORY1" HeaderText="SUB2 THEORY1" 
                            SortExpression="SUB2 THEORY1" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE1" HeaderText="SUB2 OBJECTIVE1" 
                            SortExpression="SUB2 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT1" HeaderText="SUB2 ASSIGNMENT1" 
                            SortExpression="SUB2 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB2 THEORY2" HeaderText="SUB2 THEORY2" 
                            SortExpression="SUB2 THEORY2" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE2" HeaderText="SUB2 OBJECTIVE2" 
                            SortExpression="SUB2 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT2" HeaderText="SUB2 ASSIGNMENT2" 
                            SortExpression="SUB2 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB2 EXTERNAL" HeaderText="SUB2 EXTERNAL" 
                            SortExpression="SUB2 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 THEORY1" HeaderText="SUB3 THEORY1" 
                            SortExpression="SUB3 THEORY1" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE1" HeaderText="SUB3 OBJECTIVE1" 
                            SortExpression="SUB3 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT1" HeaderText="SUB3 ASSIGNMENT1" 
                            SortExpression="SUB3 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB3 THEORY2" HeaderText="SUB3 THEORY2" 
                            SortExpression="SUB3 THEORY2" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE2" HeaderText="SUB3 OBJECTIVE2" 
                            SortExpression="SUB3 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT2" HeaderText="SUB3 ASSIGNMENT2" 
                            SortExpression="SUB3 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB3 EXTERNAL" HeaderText="SUB3 EXTERNAL" 
                            SortExpression="SUB3 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 THEORY1" HeaderText="SUB4 THEORY1" 
                            SortExpression="SUB4 THEORY1" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE1" HeaderText="SUB4 OBJECTIVE1" 
                            SortExpression="SUB4 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT1" HeaderText="SUB4 ASSIGNMENT1" 
                            SortExpression="SUB4 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB4 THEORY2" HeaderText="SUB4 THEORY2" 
                            SortExpression="SUB4 THEORY2" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE2" HeaderText="SUB4 OBJECTIVE2" 
                            SortExpression="SUB4 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT2" HeaderText="SUB4 ASSIGNMENT2" 
                            SortExpression="SUB4 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB4 EXTERNAL" HeaderText="SUB4 EXTERNAL" 
                            SortExpression="SUB4 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 THEORY1" HeaderText="SUB5 THEORY1" 
                            SortExpression="SUB5 THEORY1" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE1" HeaderText="SUB5 OBJECTIVE1" 
                            SortExpression="SUB5 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT1" HeaderText="SUB5 ASSIGNMENT1" 
                            SortExpression="SUB5 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB5 THEORY2" HeaderText="SUB5 THEORY2" 
                            SortExpression="SUB5 THEORY2" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE2" HeaderText="SUB5 OBJECTIVE2" 
                            SortExpression="SUB5 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT2" HeaderText="SUB5 ASSIGNMENT2" 
                            SortExpression="SUB5 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB5 EXTERNAL" HeaderText="SUB5 EXTERNAL" 
                            SortExpression="SUB5 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 THEORY1" HeaderText="SUB6 THEORY1" 
                            SortExpression="SUB6 THEORY1" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE1" HeaderText="SUB6 OBJECTIVE1" 
                            SortExpression="SUB6 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT1" HeaderText="SUB6 ASSIGNMENT1" 
                            SortExpression="SUB6 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB6 THEORY2" HeaderText="SUB6 THEORY2" 
                            SortExpression="SUB6 THEORY2" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE2" HeaderText="SUB6 OBJECTIVE2" 
                            SortExpression="SUB6 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT2" HeaderText="SUB6 ASSIGNMENT2" 
                            SortExpression="SUB6 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB6 EXTERNAL" HeaderText="SUB6 EXTERNAL" 
                            SortExpression="SUB6 EXTERNAL" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 INTERNAL" HeaderText="LAB1 INTERNAL" 
                            SortExpression="LAB1 INTERNAL" />
                        <asp:BoundField DataField="LAB1 EXTERNAL" HeaderText="LAB1 EXTERNAL" 
                            SortExpression="LAB1 EXTERNAL" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 INTERNAL" HeaderText="LAB2 INTERNAL" 
                            SortExpression="LAB2 INTERNAL" />
                        <asp:BoundField DataField="LAB2 EXTERNAL" HeaderText="LAB2 EXTERNAL" 
                            SortExpression="LAB2 EXTERNAL" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource9" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOONEYEARSTUDENTEXAMINATIONDETAILS] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOONEYEARSTUDENTEXAMINATIONDETAILS] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
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
                        <asp:BoundField DataField="SUB1 THEORY1" HeaderText="SUB1 THEORY1" 
                            SortExpression="SUB1 THEORY1" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE1" HeaderText="SUB1 OBJECTIVE1" 
                            SortExpression="SUB1 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT1" HeaderText="SUB1 ASSIGNMENT1" 
                            SortExpression="SUB1 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB1 THEORY2" HeaderText="SUB1 THEORY2" 
                            SortExpression="SUB1 THEORY2" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE2" HeaderText="SUB1 OBJECTIVE2" 
                            SortExpression="SUB1 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT2" HeaderText="SUB1 ASSIGNMENT2" 
                            SortExpression="SUB1 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB1 EXTERNAL" HeaderText="SUB1 EXTERNAL" 
                            SortExpression="SUB1 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 THEORY1" HeaderText="SUB2 THEORY1" 
                            SortExpression="SUB2 THEORY1" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE1" HeaderText="SUB2 OBJECTIVE1" 
                            SortExpression="SUB2 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT1" HeaderText="SUB2 ASSIGNMENT1" 
                            SortExpression="SUB2 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB2 THEORY2" HeaderText="SUB2 THEORY2" 
                            SortExpression="SUB2 THEORY2" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE2" HeaderText="SUB2 OBJECTIVE2" 
                            SortExpression="SUB2 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT2" HeaderText="SUB2 ASSIGNMENT2" 
                            SortExpression="SUB2 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB2 EXTERNAL" HeaderText="SUB2 EXTERNAL" 
                            SortExpression="SUB2 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 THEORY1" HeaderText="SUB3 THEORY1" 
                            SortExpression="SUB3 THEORY1" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE1" HeaderText="SUB3 OBJECTIVE1" 
                            SortExpression="SUB3 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT1" HeaderText="SUB3 ASSIGNMENT1" 
                            SortExpression="SUB3 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB3 THEORY2" HeaderText="SUB3 THEORY2" 
                            SortExpression="SUB3 THEORY2" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE2" HeaderText="SUB3 OBJECTIVE2" 
                            SortExpression="SUB3 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT2" HeaderText="SUB3 ASSIGNMENT2" 
                            SortExpression="SUB3 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB3 EXTERNAL" HeaderText="SUB3 EXTERNAL" 
                            SortExpression="SUB3 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 THEORY1" HeaderText="SUB4 THEORY1" 
                            SortExpression="SUB4 THEORY1" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE1" HeaderText="SUB4 OBJECTIVE1" 
                            SortExpression="SUB4 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT" HeaderText="SUB4 ASSIGNMENT" 
                            SortExpression="SUB4 ASSIGNMENT" />
                        <asp:BoundField DataField="SUB4 THEORY2" HeaderText="SUB4 THEORY2" 
                            SortExpression="SUB4 THEORY2" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE2" HeaderText="SUB4 OBJECTIVE2" 
                            SortExpression="SUB4 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT2" HeaderText="SUB4 ASSIGNMENT2" 
                            SortExpression="SUB4 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB4 EXTERNAL" HeaderText="SUB4 EXTERNAL" 
                            SortExpression="SUB4 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 THEORY1" HeaderText="SUB5 THEORY1" 
                            SortExpression="SUB5 THEORY1" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE1" HeaderText="SUB5 OBJECTIVE1" 
                            SortExpression="SUB5 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT1" HeaderText="SUB5 ASSIGNMENT1" 
                            SortExpression="SUB5 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB5 THEORY2" HeaderText="SUB5 THEORY2" 
                            SortExpression="SUB5 THEORY2" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE2" HeaderText="SUB5 OBJECTIVE2" 
                            SortExpression="SUB5 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT2" HeaderText="SUB5 ASSIGNMENT2" 
                            SortExpression="SUB5 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB5 EXTERNAL" HeaderText="SUB5 EXTERNAL" 
                            SortExpression="SUB5 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 THEORY1" HeaderText="SUB6 THEORY1" 
                            SortExpression="SUB6 THEORY1" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE1" HeaderText="SUB6 OBJECTIVE1" 
                            SortExpression="SUB6 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT1" HeaderText="SUB6 ASSIGNMENT1" 
                            SortExpression="SUB6 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB6 THEORY2" HeaderText="SUB6 THEORY2" 
                            SortExpression="SUB6 THEORY2" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE2" HeaderText="SUB6 OBJECTIVE2" 
                            SortExpression="SUB6 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT2" HeaderText="SUB6 ASSIGNMENT2" 
                            SortExpression="SUB6 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB6 EXTERNAL" HeaderText="SUB6 EXTERNAL" 
                            SortExpression="SUB6 EXTERNAL" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 INTERNAL" HeaderText="LAB1 INTERNAL" 
                            SortExpression="LAB1 INTERNAL" />
                        <asp:BoundField DataField="LAB1 EXTERNAL" HeaderText="LAB1 EXTERNAL" 
                            SortExpression="LAB1 EXTERNAL" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 INTERNAL" HeaderText="LAB2 INTERNAL" 
                            SortExpression="LAB2 INTERNAL" />
                        <asp:BoundField DataField="LAB2 EXTERNAL" HeaderText="LAB2 EXTERNAL" 
                            SortExpression="LAB2 EXTERNAL" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 INTERNAL" HeaderText="LAB3 INTERNAL" 
                            SortExpression="LAB3 INTERNAL" />
                        <asp:BoundField DataField="LAB3 EXTERNAL" HeaderText="LAB3 EXTERNAL" 
                            SortExpression="LAB3 EXTERNAL" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource10" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOTWOYEARSTUDENTEXAMINATIONDETAILS] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [TWOTWOYEARSTUDENTEXAMINATIONDETAILS] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
                <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
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
                        <asp:BoundField DataField="SUB1 THEORY1" HeaderText="SUB1 THEORY1" 
                            SortExpression="SUB1 THEORY1" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE1" HeaderText="SUB1 OBJECTIVE1" 
                            SortExpression="SUB1 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT1" HeaderText="SUB1 ASSIGNMENT1" 
                            SortExpression="SUB1 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB1 THEORY2" HeaderText="SUB1 THEORY2" 
                            SortExpression="SUB1 THEORY2" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE2" HeaderText="SUB1 OBJECTIVE2" 
                            SortExpression="SUB1 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT2" HeaderText="SUB1 ASSIGNMENT2" 
                            SortExpression="SUB1 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB1 EXTERNAL" HeaderText="SUB1 EXTERNAL" 
                            SortExpression="SUB1 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 THEORY1" HeaderText="SUB2 THEORY1" 
                            SortExpression="SUB2 THEORY1" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE1" HeaderText="SUB2 OBJECTIVE1" 
                            SortExpression="SUB2 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT1" HeaderText="SUB2 ASSIGNMENT1" 
                            SortExpression="SUB2 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB2 THEORY2" HeaderText="SUB2 THEORY2" 
                            SortExpression="SUB2 THEORY2" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE2" HeaderText="SUB2 OBJECTIVE2" 
                            SortExpression="SUB2 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT2" HeaderText="SUB2 ASSIGNMENT2" 
                            SortExpression="SUB2 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB2 EXTERNAL" HeaderText="SUB2 EXTERNAL" 
                            SortExpression="SUB2 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 THEORY1" HeaderText="SUB3 THEORY1" 
                            SortExpression="SUB3 THEORY1" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE1" HeaderText="SUB3 OBJECTIVE1" 
                            SortExpression="SUB3 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT1" HeaderText="SUB3 ASSIGNMENT1" 
                            SortExpression="SUB3 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB3 THEORY2" HeaderText="SUB3 THEORY2" 
                            SortExpression="SUB3 THEORY2" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE2" HeaderText="SUB3 OBJECTIVE2" 
                            SortExpression="SUB3 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT2" HeaderText="SUB3 ASSIGNMENT2" 
                            SortExpression="SUB3 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB3 EXTERNAL" HeaderText="SUB3 EXTERNAL" 
                            SortExpression="SUB3 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 THEORY1" HeaderText="SUB4 THEORY1" 
                            SortExpression="SUB4 THEORY1" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE1" HeaderText="SUB4 OBJECTIVE1" 
                            SortExpression="SUB4 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT1" HeaderText="SUB4 ASSIGNMENT1" 
                            SortExpression="SUB4 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB4 THEORY2" HeaderText="SUB4 THEORY2" 
                            SortExpression="SUB4 THEORY2" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE2" HeaderText="SUB4 OBJECTIVE2" 
                            SortExpression="SUB4 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT2" HeaderText="SUB4 ASSIGNMENT2" 
                            SortExpression="SUB4 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB4 EXTERNAL" HeaderText="SUB4 EXTERNAL" 
                            SortExpression="SUB4 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 THEORY1" HeaderText="SUB5 THEORY1" 
                            SortExpression="SUB5 THEORY1" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE1" HeaderText="SUB5 OBJECTIVE1" 
                            SortExpression="SUB5 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT1" HeaderText="SUB5 ASSIGNMENT1" 
                            SortExpression="SUB5 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB5 THEORY2" HeaderText="SUB5 THEORY2" 
                            SortExpression="SUB5 THEORY2" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE2" HeaderText="SUB5 OBJECTIVE2" 
                            SortExpression="SUB5 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT2" HeaderText="SUB5 ASSIGNMENT2" 
                            SortExpression="SUB5 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB5 EXTERNAL" HeaderText="SUB5 EXTERNAL" 
                            SortExpression="SUB5 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 THEORY1" HeaderText="SUB6 THEORY1" 
                            SortExpression="SUB6 THEORY1" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE1" HeaderText="SUB6 OBJECTIVE1" 
                            SortExpression="SUB6 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT1" HeaderText="SUB6 ASSIGNMENT1" 
                            SortExpression="SUB6 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB6 THEORY2" HeaderText="SUB6 THEORY2" 
                            SortExpression="SUB6 THEORY2" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE2" HeaderText="SUB6 OBJECTIVE2" 
                            SortExpression="SUB6 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT2" HeaderText="SUB6 ASSIGNMENT2" 
                            SortExpression="SUB6 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB6 EXTERNAL" HeaderText="SUB6 EXTERNAL" 
                            SortExpression="SUB6 EXTERNAL" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 INTERNAL" HeaderText="LAB1 INTERNAL" 
                            SortExpression="LAB1 INTERNAL" />
                        <asp:BoundField DataField="LAB1 EXTERNAL" HeaderText="LAB1 EXTERNAL" 
                            SortExpression="LAB1 EXTERNAL" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 INTERNAL" HeaderText="LAB2 INTERNAL" 
                            SortExpression="LAB2 INTERNAL" />
                        <asp:BoundField DataField="LAB2 EXTERNAL" HeaderText="LAB2 EXTERNAL" 
                            SortExpression="LAB2 EXTERNAL" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource11" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREEONEYEARSTUDENTEXAMINATIONDETAILS] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREEONEYEARSTUDENTEXAMINATIONDETAILS] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
                <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
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
                        <asp:BoundField DataField="SUB1 THEORY1" HeaderText="SUB1 THEORY1" 
                            SortExpression="SUB1 THEORY1" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE1" HeaderText="SUB1 OBJECTIVE1" 
                            SortExpression="SUB1 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT1" HeaderText="SUB1 ASSIGNMENT1" 
                            SortExpression="SUB1 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB1 THEORY2" HeaderText="SUB1 THEORY2" 
                            SortExpression="SUB1 THEORY2" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE2" HeaderText="SUB1 OBJECTIVE2" 
                            SortExpression="SUB1 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT2" HeaderText="SUB1 ASSIGNMENT2" 
                            SortExpression="SUB1 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB1 EXTERNAL" HeaderText="SUB1 EXTERNAL" 
                            SortExpression="SUB1 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 THEORY1" HeaderText="SUB2 THEORY1" 
                            SortExpression="SUB2 THEORY1" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE1" HeaderText="SUB2 OBJECTIVE1" 
                            SortExpression="SUB2 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT1" HeaderText="SUB2 ASSIGNMENT1" 
                            SortExpression="SUB2 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB2 THEORY2" HeaderText="SUB2 THEORY2" 
                            SortExpression="SUB2 THEORY2" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE2" HeaderText="SUB2 OBJECTIVE2" 
                            SortExpression="SUB2 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT2" HeaderText="SUB2 ASSIGNMENT2" 
                            SortExpression="SUB2 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB2 EXTERNAL" HeaderText="SUB2 EXTERNAL" 
                            SortExpression="SUB2 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 THEORY1" HeaderText="SUB3 THEORY1" 
                            SortExpression="SUB3 THEORY1" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE1" HeaderText="SUB3 OBJECTIVE1" 
                            SortExpression="SUB3 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT1" HeaderText="SUB3 ASSIGNMENT1" 
                            SortExpression="SUB3 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB3 THEORY2" HeaderText="SUB3 THEORY2" 
                            SortExpression="SUB3 THEORY2" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE2" HeaderText="SUB3 OBJECTIVE2" 
                            SortExpression="SUB3 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT2" HeaderText="SUB3 ASSIGNMENT2" 
                            SortExpression="SUB3 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB3 EXTERNAL" HeaderText="SUB3 EXTERNAL" 
                            SortExpression="SUB3 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 THEORY1" HeaderText="SUB4 THEORY1" 
                            SortExpression="SUB4 THEORY1" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE1" HeaderText="SUB4 OBJECTIVE1" 
                            SortExpression="SUB4 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT1" HeaderText="SUB4 ASSIGNMENT1" 
                            SortExpression="SUB4 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB4 THEORY2" HeaderText="SUB4 THEORY2" 
                            SortExpression="SUB4 THEORY2" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE2" HeaderText="SUB4 OBJECTIVE2" 
                            SortExpression="SUB4 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT2" HeaderText="SUB4 ASSIGNMENT2" 
                            SortExpression="SUB4 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB4 EXTERNAL" HeaderText="SUB4 EXTERNAL" 
                            SortExpression="SUB4 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 THEORY1" HeaderText="SUB5 THEORY1" 
                            SortExpression="SUB5 THEORY1" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE1" HeaderText="SUB5 OBJECTIVE1" 
                            SortExpression="SUB5 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT1" HeaderText="SUB5 ASSIGNMENT1" 
                            SortExpression="SUB5 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB5 THEORY2" HeaderText="SUB5 THEORY2" 
                            SortExpression="SUB5 THEORY2" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE2" HeaderText="SUB5 OBJECTIVE2" 
                            SortExpression="SUB5 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT2" HeaderText="SUB5 ASSIGNMENT2" 
                            SortExpression="SUB5 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB5 EXTERNAL" HeaderText="SUB5 EXTERNAL" 
                            SortExpression="SUB5 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 THEORY1" HeaderText="SUB6 THEORY1" 
                            SortExpression="SUB6 THEORY1" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE1" HeaderText="SUB6 OBJECTIVE1" 
                            SortExpression="SUB6 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT1" HeaderText="SUB6 ASSIGNMENT1" 
                            SortExpression="SUB6 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB6 THEORY2" HeaderText="SUB6 THEORY2" 
                            SortExpression="SUB6 THEORY2" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE2" HeaderText="SUB6 OBJECTIVE2" 
                            SortExpression="SUB6 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT2" HeaderText="SUB6 ASSIGNMENT2" 
                            SortExpression="SUB6 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB6 EXTERNAL" HeaderText="SUB6 EXTERNAL" 
                            SortExpression="SUB6 EXTERNAL" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 INTERNAL" HeaderText="LAB1 INTERNAL" 
                            SortExpression="LAB1 INTERNAL" />
                        <asp:BoundField DataField="LAB1 EXTERNAL" HeaderText="LAB1 EXTERNAL" 
                            SortExpression="LAB1 EXTERNAL" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 INTERNAL" HeaderText="LAB2 INTERNAL" 
                            SortExpression="LAB2 INTERNAL" />
                        <asp:BoundField DataField="LAB2 EXTERNAL" HeaderText="LAB2 EXTERNAL" 
                            SortExpression="LAB2 EXTERNAL" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 INTERNAL" HeaderText="LAB3 INTERNAL" 
                            SortExpression="LAB3 INTERNAL" />
                        <asp:BoundField DataField="LAB3 EXTERNAL" HeaderText="LAB3 EXTERNAL" 
                            SortExpression="LAB3 EXTERNAL" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource12" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREETWOYEARSSTUDENTEXAMINATIONDETAILS] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [THREETWOYEARSSTUDENTEXAMINATIONDETAILS] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
            <asp:Panel ID="pnl41" runat="server">
                <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource13">
                    <Columns>
                        <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                            SortExpression="ID NUMBER" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                            SortExpression="DEPARTMENT" />
                        <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="SUBJECT1" HeaderText="SUBJECT1" 
                            SortExpression="SUBJECT1" />
                        <asp:BoundField DataField="SUB1 THEORY1" HeaderText="SUB1 THEORY1" 
                            SortExpression="SUB1 THEORY1" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE1" HeaderText="SUB1 OBJECTIVE1" 
                            SortExpression="SUB1 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT1" HeaderText="SUB1 ASSIGNMENT1" 
                            SortExpression="SUB1 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB1 THEORY2" HeaderText="SUB1 THEORY2" 
                            SortExpression="SUB1 THEORY2" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE2" HeaderText="SUB1 OBJECTIVE2" 
                            SortExpression="SUB1 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT2" HeaderText="SUB1 ASSIGNMENT2" 
                            SortExpression="SUB1 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB1 EXTERNAL" HeaderText="SUB1 EXTERNAL" 
                            SortExpression="SUB1 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 THEORY1" HeaderText="SUB2 THEORY1" 
                            SortExpression="SUB2 THEORY1" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE1" HeaderText="SUB2 OBJECTIVE1" 
                            SortExpression="SUB2 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT1" HeaderText="SUB2 ASSIGNMENT1" 
                            SortExpression="SUB2 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB2 THEORY2" HeaderText="SUB2 THEORY2" 
                            SortExpression="SUB2 THEORY2" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE2" HeaderText="SUB2 OBJECTIVE2" 
                            SortExpression="SUB2 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT2" HeaderText="SUB2 ASSIGNMENT2" 
                            SortExpression="SUB2 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB2 EXTERNAL" HeaderText="SUB2 EXTERNAL" 
                            SortExpression="SUB2 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 THEORY1" HeaderText="SUB3 THEORY1" 
                            SortExpression="SUB3 THEORY1" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE1" HeaderText="SUB3 OBJECTIVE1" 
                            SortExpression="SUB3 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT1" HeaderText="SUB3 ASSIGNMENT1" 
                            SortExpression="SUB3 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB3 THEORY2" HeaderText="SUB3 THEORY2" 
                            SortExpression="SUB3 THEORY2" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE2" HeaderText="SUB3 OBJECTIVE2" 
                            SortExpression="SUB3 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT3" HeaderText="SUB3 ASSIGNMENT3" 
                            SortExpression="SUB3 ASSIGNMENT3" />
                        <asp:BoundField DataField="SUB3 EXTERNAL" HeaderText="SUB3 EXTERNAL" 
                            SortExpression="SUB3 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT4" HeaderText="SUBJECT4" 
                            SortExpression="SUBJECT4" />
                        <asp:BoundField DataField="SUB4 THEORY1" HeaderText="SUB4 THEORY1" 
                            SortExpression="SUB4 THEORY1" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE1" HeaderText="SUB4 OBJECTIVE1" 
                            SortExpression="SUB4 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT1" HeaderText="SUB4 ASSIGNMENT1" 
                            SortExpression="SUB4 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB4 THEORY2" HeaderText="SUB4 THEORY2" 
                            SortExpression="SUB4 THEORY2" />
                        <asp:BoundField DataField="SUB4 OBJECTIVE2" HeaderText="SUB4 OBJECTIVE2" 
                            SortExpression="SUB4 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB4 ASSIGNMENT2" HeaderText="SUB4 ASSIGNMENT2" 
                            SortExpression="SUB4 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB4 EXTERNAL" HeaderText="SUB4 EXTERNAL" 
                            SortExpression="SUB4 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT5" HeaderText="SUBJECT5" 
                            SortExpression="SUBJECT5" />
                        <asp:BoundField DataField="SUB5 THEORY1" HeaderText="SUB5 THEORY1" 
                            SortExpression="SUB5 THEORY1" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE1" HeaderText="SUB5 OBJECTIVE1" 
                            SortExpression="SUB5 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT1" HeaderText="SUB5 ASSIGNMENT1" 
                            SortExpression="SUB5 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB5 THEORY2" HeaderText="SUB5 THEORY2" 
                            SortExpression="SUB5 THEORY2" />
                        <asp:BoundField DataField="SUB5 OBJECTIVE2" HeaderText="SUB5 OBJECTIVE2" 
                            SortExpression="SUB5 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB5 ASSIGNMENT2" HeaderText="SUB5 ASSIGNMENT2" 
                            SortExpression="SUB5 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB5 EXTERNAL" HeaderText="SUB5 EXTERNAL" 
                            SortExpression="SUB5 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT6" HeaderText="SUBJECT6" 
                            SortExpression="SUBJECT6" />
                        <asp:BoundField DataField="SUB6 THEORY1" HeaderText="SUB6 THEORY1" 
                            SortExpression="SUB6 THEORY1" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE1" HeaderText="SUB6 OBJECTIVE1" 
                            SortExpression="SUB6 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT1" HeaderText="SUB6 ASSIGNMENT1" 
                            SortExpression="SUB6 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB6 THEORY2" HeaderText="SUB6 THEORY2" 
                            SortExpression="SUB6 THEORY2" />
                        <asp:BoundField DataField="SUB6 OBJECTIVE2" HeaderText="SUB6 OBJECTIVE2" 
                            SortExpression="SUB6 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB6 ASSIGNMENT2" HeaderText="SUB6 ASSIGNMENT2" 
                            SortExpression="SUB6 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB6 EXTERNAL" HeaderText="SUB6 EXTERNAL" 
                            SortExpression="SUB6 EXTERNAL" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 INTERNAL" HeaderText="LAB1 INTERNAL" 
                            SortExpression="LAB1 INTERNAL" />
                        <asp:BoundField DataField="LAB1 EXTERNAL" HeaderText="LAB1 EXTERNAL" 
                            SortExpression="LAB1 EXTERNAL" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 INTERNAL" HeaderText="LAB2 INTERNAL" 
                            SortExpression="LAB2 INTERNAL" />
                        <asp:BoundField DataField="LAB2 EXTERNAL" HeaderText="LAB2 EXTERNAL" 
                            SortExpression="LAB2 EXTERNAL" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource13" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURONEYEARSSTUDENTEXAMINATIONDETAILS] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURONEYEARSSTUDENTEXAMINATIONDETAILS] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
                <asp:GridView ID="GridView8" runat="server" AutoGenerateColumns="False" 
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
                        <asp:BoundField DataField="SUB1 THEORY1" HeaderText="SUB1 THEORY1" 
                            SortExpression="SUB1 THEORY1" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE1" HeaderText="SUB1 OBJECTIVE1" 
                            SortExpression="SUB1 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT1" HeaderText="SUB1 ASSIGNMENT1" 
                            SortExpression="SUB1 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB1 THEORY2" HeaderText="SUB1 THEORY2" 
                            SortExpression="SUB1 THEORY2" />
                        <asp:BoundField DataField="SUB1 OBJECTIVE2" HeaderText="SUB1 OBJECTIVE2" 
                            SortExpression="SUB1 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB1 ASSIGNMENT2" HeaderText="SUB1 ASSIGNMENT2" 
                            SortExpression="SUB1 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB1 EXTERNAL" HeaderText="SUB1 EXTERNAL" 
                            SortExpression="SUB1 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT2" HeaderText="SUBJECT2" 
                            SortExpression="SUBJECT2" />
                        <asp:BoundField DataField="SUB2 THEORY1" HeaderText="SUB2 THEORY1" 
                            SortExpression="SUB2 THEORY1" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE1" HeaderText="SUB2 OBJECTIVE1" 
                            SortExpression="SUB2 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT1" HeaderText="SUB2 ASSIGNMENT1" 
                            SortExpression="SUB2 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB2 THEORY2" HeaderText="SUB2 THEORY2" 
                            SortExpression="SUB2 THEORY2" />
                        <asp:BoundField DataField="SUB2 OBJECTIVE2" HeaderText="SUB2 OBJECTIVE2" 
                            SortExpression="SUB2 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB2 ASSIGNMENT2" HeaderText="SUB2 ASSIGNMENT2" 
                            SortExpression="SUB2 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB2 EXTERNAL" HeaderText="SUB2 EXTERNAL" 
                            SortExpression="SUB2 EXTERNAL" />
                        <asp:BoundField DataField="SUBJECT3" HeaderText="SUBJECT3" 
                            SortExpression="SUBJECT3" />
                        <asp:BoundField DataField="SUB3 THEORY1" HeaderText="SUB3 THEORY1" 
                            SortExpression="SUB3 THEORY1" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE1" HeaderText="SUB3 OBJECTIVE1" 
                            SortExpression="SUB3 OBJECTIVE1" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT1" HeaderText="SUB3 ASSIGNMENT1" 
                            SortExpression="SUB3 ASSIGNMENT1" />
                        <asp:BoundField DataField="SUB3 THEORY2" HeaderText="SUB3 THEORY2" 
                            SortExpression="SUB3 THEORY2" />
                        <asp:BoundField DataField="SUB3 OBJECTIVE2" HeaderText="SUB3 OBJECTIVE2" 
                            SortExpression="SUB3 OBJECTIVE2" />
                        <asp:BoundField DataField="SUB3 ASSIGNMENT2" HeaderText="SUB3 ASSIGNMENT2" 
                            SortExpression="SUB3 ASSIGNMENT2" />
                        <asp:BoundField DataField="SUB3 EXTERNAL" HeaderText="SUB3 EXTERNAL" 
                            SortExpression="SUB3 EXTERNAL" />
                        <asp:BoundField DataField="LAB1" HeaderText="LAB1" SortExpression="LAB1" />
                        <asp:BoundField DataField="LAB1 INTERNAL" HeaderText="LAB1 INTERNAL" 
                            SortExpression="LAB1 INTERNAL" />
                        <asp:BoundField DataField="LAB1 EXTERNAL" HeaderText="LAB1 EXTERNAL" 
                            SortExpression="LAB1 EXTERNAL" />
                        <asp:BoundField DataField="LAB2" HeaderText="LAB2" SortExpression="LAB2" />
                        <asp:BoundField DataField="LAB2 INTERNAL" HeaderText="LAB2 INTERNAL" 
                            SortExpression="LAB2 INTERNAL" />
                        <asp:BoundField DataField="LAB2 EXTERNAL" HeaderText="LAB2 EXTERNAL" 
                            SortExpression="LAB2 EXTERNAL" />
                        <asp:BoundField DataField="LAB3" HeaderText="LAB3" SortExpression="LAB3" />
                        <asp:BoundField DataField="LAB3 INTERNAL" HeaderText="LAB3 INTERNAL" 
                            SortExpression="LAB3 INTERNAL" />
                        <asp:BoundField DataField="LAB3 EXTERNAL" HeaderText="LAB3 EXTERNAL" 
                            SortExpression="LAB3 EXTERNAL" />
                        <asp:BoundField DataField="LAB4" HeaderText="LAB4" SortExpression="LAB4" />
                        <asp:BoundField DataField="LAB4 INTERNAL" HeaderText="LAB4 INTERNAL" 
                            SortExpression="LAB4 INTERNAL" />
                        <asp:BoundField DataField="LAB4 EXTERNAL" HeaderText="LAB4 EXTERNAL" 
                            SortExpression="LAB4 EXTERNAL" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource14" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURTWOYEARSTUDENTEXAMINATIONDETAILS] WHERE ([YEAR] = @YEAR)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlyear" Name="YEAR" 
                            PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                    SelectCommand="SELECT * FROM [FOURTWOYEARSTUDENTEXAMINATIONDETAILS] WHERE ([DEPARTMENT] = @DEPARTMENT)">
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
</table>
</asp:Content>

