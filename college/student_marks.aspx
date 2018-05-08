<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="student_marks.aspx.cs" Inherits="student_marks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Student Marksa</h2>
    <form runat="server">
    <asp:TextBox ID="uname" placeholder="Student's name" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:TextBox ID="c1" placeholder="Course 1" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:TextBox ID="c2" placeholder="Course 2" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:TextBox ID="c3" placeholder="Course 3" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:TextBox ID="c4" placeholder="Course 4" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:TextBox ID="c5" placeholder="Course 5" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:TextBox ID="c6" placeholder="Course 6" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:TextBox ID="attendence" placeholder="Attendence" runat="server" CssClass="a"></asp:TextBox><br />
    <asp:Button ID="submit" runat="server" Text="Submit" CssClass="k" OnClick="submit_Click" />
        </form>

</asp:Content>

