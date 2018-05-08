<%@ Page Language="C#" MasterPageFile="~/ADMINMASTER.master" AutoEventWireup="true" CodeFile="STUDENT REGISTRATION VIEW.aspx.cs" Inherits="STUDENT_REGISTRATION_VIEW" Title="STUDENT REGISTRATION VIEW" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style2
    {
        width: 153px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#FFCCFF">
    <tr>
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
        <td>
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
    </tr>
    <tr>
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
        <td>
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
    </tr>
    <tr>
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
        <td>
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="14" style="text-align: center">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="REGISTRATION NO" HeaderText="REGISTRATION NO" 
                        SortExpression="REGISTRATION NO" />
                    <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                        SortExpression="ID NUMBER" />
                    <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                        SortExpression="DEPARTMENT" />
                    <asp:BoundField DataField="NAME OF THE CANDIDATE" 
                        HeaderText="NAME OF THE CANDIDATE" SortExpression="NAME OF THE CANDIDATE" />
                    <asp:BoundField DataField="PERSONAL NUMBER" HeaderText="PERSONAL NUMBER" 
                        SortExpression="PERSONAL NUMBER" />
                    <asp:BoundField DataField="FATHER'S/GUARDIAN'S NAME" 
                        HeaderText="FATHER'S/GUARDIAN'S NAME" 
                        SortExpression="FATHER'S/GUARDIAN'S NAME" />
                    <asp:BoundField DataField="FATHER'S PH.NO." HeaderText="FATHER'S PH.NO." 
                        SortExpression="FATHER'S PH.NO." />
                    <asp:BoundField DataField="MOTHERS NAME" HeaderText="MOTHERS NAME" 
                        SortExpression="MOTHERS NAME" />
                    <asp:BoundField DataField="MOTHER'S PH.NO." HeaderText="MOTHER'S PH.NO." 
                        SortExpression="MOTHER'S PH.NO." />
                    <asp:BoundField DataField="DATE OF BIRTH" 
                        HeaderText="DATE OF BIRTH" SortExpression="DATE OF BIRTH" />
                    <asp:BoundField DataField="FATHER'S OCCUPATION" HeaderText="FATHER'S OCCUPATION" 
                        SortExpression="FATHER'S OCCUPATION" />
                    <asp:BoundField DataField="NATIVE PLACE" HeaderText="NATIVE PLACE" 
                        SortExpression="NATIVE PLACE" />
                    <asp:BoundField DataField="TEMPORARY ADDRESS" HeaderText="TEMPORARY ADDRESS" 
                        SortExpression="TEMPORARY ADDRESS" />
                    <asp:BoundField DataField="T.PINCODE" HeaderText="T.PINCODE" 
                        SortExpression="T.PINCODE" />
                    <asp:BoundField DataField="PERMANENT ADDRESS" HeaderText="PERMANENT ADDRESS" 
                        SortExpression="PERMANENT ADDRESS" />
                    <asp:BoundField DataField="P.PINCODE" HeaderText="P.PINCODE" 
                        SortExpression="P.PINCODE" />
                    <asp:BoundField DataField="MODE OF ADMISSION" HeaderText="MODE OF ADMISSION" 
                        SortExpression="MODE OF ADMISSION" />
                    <asp:BoundField DataField="EAMCET RANK" 
                        HeaderText="EAMCET RANK" 
                        SortExpression="EAMCET RANK" />
                    <asp:BoundField DataField="ENTRANCE HALL TICKET NO." HeaderText="ENTRANCE HALL TICKET NO." 
                        SortExpression="ENTRANCE HALL TICKET NO." />
                    <asp:BoundField DataField="EMAIL ID" HeaderText="EMAIL ID" 
                        SortExpression="EMAIL ID" />
                    <asp:BoundField DataField="SSC NAME OF INSTITUTION/UNIVERSITY" 
                        HeaderText="SSC NAME OF INSTITUTION/UNIVERSITY" 
                        SortExpression="SSC NAME OF INSTITUTION/UNIVERSITY" />
                    <asp:BoundField DataField="SSC YEAR OF PASSED" HeaderText="SSC YEAR OF PASSED" 
                        SortExpression="SSC YEAR OF PASSED" />
                    <asp:BoundField DataField="SSC AGGREGATE" HeaderText="SSC AGGREGATE" 
                        SortExpression="SSC AGGREGATE" />
                    <asp:BoundField DataField="INTER1ST NAME OF INSTITUTION" 
                        HeaderText="INTER1ST NAME OF INSTITUTION" 
                        SortExpression="INTER1ST NAME OF INSTITUTION" />
                    <asp:BoundField DataField="INTER1ST YEAR OF PASSED" 
                        HeaderText="INTER1ST YEAR OF PASSED" SortExpression="INTER1ST YEAR OF PASSED" />
                    <asp:BoundField DataField="INTER1ST AGGREGATE" HeaderText="INTER1ST AGGREGATE" 
                        SortExpression="INTER1ST AGGREGATE" />
                    <asp:BoundField DataField="INTER2ND NAME OF INSTITUTION" 
                        HeaderText="INTER2ND NAME OF INSTITUTION" 
                        SortExpression="INTER2ND NAME OF INSTITUTION" />
                    <asp:BoundField DataField="INTER2ND YEAR OF PASSED" 
                        HeaderText="INTER2ND YEAR OF PASSED" SortExpression="INTER2ND YEAR OF PASSED" />
                    <asp:BoundField DataField="INTER2ND AGGREGATE" HeaderText="INTER2ND AGGREGATE" 
                        SortExpression="INTER2ND AGGREGATE" />
                    <asp:BoundField DataField="PASSWORD" HeaderText="PASSWORD" 
                        SortExpression="PASSWORD" />
                    <asp:BoundField DataField="REENTERPASSWORD" HeaderText="REENTERPASSWORD" 
                        SortExpression="REENTERPASSWORD" />
                    <asp:BoundField DataField="DATE" HeaderText="DATE" 
                        SortExpression="DATE" />
                    <asp:BoundField DataField="TOTALAMOUNT" HeaderText="TOTALAMOUNT" 
                        SortExpression="TOTALAMOUNT" />
                    <asp:BoundField DataField="AMOUNTPAID" HeaderText="AMOUNTPAID" 
                        SortExpression="AMOUNTPAID" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                SelectCommand="SELECT * FROM [STUDENTREGISTRATION]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
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
        <td>
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
    </tr>
    <tr>
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
        <td>
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

