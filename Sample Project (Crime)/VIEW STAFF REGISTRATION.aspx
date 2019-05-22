<%@ Page Language="C#" MasterPageFile="~/ADMINMASTER.master" AutoEventWireup="true" CodeFile="VIEW STAFF REGISTRATION.aspx.cs" Inherits="VIEW_STAFF_REGISTRATION" Title="VIEW STAFF REGISTRATION" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="#FFCCFF">
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
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="REGISTRATIONNO" HeaderText="REGISTRATIONNO" 
                        SortExpression="REGISTRATIONNO" />
                    <asp:BoundField DataField="ID NUMBER" HeaderText="ID NUMBER" 
                        SortExpression="ID NUMBER" />
                    <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                    <asp:BoundField DataField="FATHERSGUARDIANSHUSBANDNAME" 
                        HeaderText="FATHERSGUARDIANSHUSBANDNAME" 
                        SortExpression="FATHERSGUARDIANSHUSBANDNAME" />
                    <asp:BoundField DataField="DATEOFBIRTH" HeaderText="DATEOFBIRTH" 
                        SortExpression="DATEOFBIRTH" />
                    <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" 
                        SortExpression="DEPARTMENT" />
                    <asp:BoundField DataField="MARITALSTATUS" HeaderText="MARITALSTATUS" 
                        SortExpression="MARITALSTATUS" />
                    <asp:BoundField DataField="PHONENO" HeaderText="PHONENO" 
                        SortExpression="PHONENO" />
                    <asp:BoundField DataField="PANCARDNO" HeaderText="PANCARDNO" 
                        SortExpression="PANCARDNO" />
                    <asp:BoundField DataField="EMAILID" HeaderText="EMAILID" 
                        SortExpression="EMAILID" />
                    <asp:BoundField DataField="GENDER" HeaderText="GENDER" 
                        SortExpression="GENDER" />
                    <asp:BoundField DataField="TEMPORARYADDRESS" HeaderText="TEMPORARYADDRESS" 
                        SortExpression="TEMPORARYADDRESS" />
                    <asp:BoundField DataField="T.PINCODE" HeaderText="T.PINCODE" 
                        SortExpression="T.PINCODE" />
                    <asp:BoundField DataField="PERMANENTADDRESS" HeaderText="PERMANENTADDRESS" 
                        SortExpression="PERMANENTADDRESS" />
                    <asp:BoundField DataField="P.PINCODE" HeaderText="P.PINCODE" 
                        SortExpression="P.PINCODE" />
                    <asp:BoundField DataField="QUALIFICATION" HeaderText="QUALIFICATION" 
                        SortExpression="QUALIFICATION" />
                    <asp:BoundField DataField="EXPERIENCE" HeaderText="EXPERIENCE" 
                        SortExpression="EXPERIENCE" />
                    <asp:BoundField DataField="DESIGNATION" HeaderText="DESIGNATION" 
                        SortExpression="DESIGNATION" />
                    <asp:BoundField DataField="TEACHINGEXPERIENCE" HeaderText="TEACHINGEXPERIENCE" 
                        SortExpression="TEACHINGEXPERIENCE" />
                    <asp:BoundField DataField="PUBLICATIONS" HeaderText="PUBLICATIONS" 
                        SortExpression="PUBLICATIONS" />
                    <asp:BoundField DataField="INDUSTRYEXPERIENCE" HeaderText="INDUSTRYEXPERIENCE" 
                        SortExpression="INDUSTRYEXPERIENCE" />
                    <asp:BoundField DataField="PASSWORD" HeaderText="PASSWORD" 
                        SortExpression="PASSWORD" />
                    <asp:BoundField DataField="REENTERPASSWORD" HeaderText="REENTERPASSWORD" 
                        SortExpression="REENTERPASSWORD" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:CollegeAutomationToolConnectionString %>" 
                SelectCommand="SELECT * FROM [STAFFREGISTRATION]"></asp:SqlDataSource>
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

