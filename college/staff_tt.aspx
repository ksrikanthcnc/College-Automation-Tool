<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="staff_tt.aspx.cs" Inherits="staff_tt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>staff timetable</h2>
    <form runat="server">
        <asp:TextBox ID="uname" placeholder="staff's name" CssClass="a" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="one" placeholder="first"  CssClass="a" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="two" runat="server"  CssClass="a" placeholder="second"  ></asp:TextBox><br />
        <asp:TextBox ID="three" runat="server" CssClass="a" placeholder="third"></asp:TextBox><br />
        <asp:TextBox ID="four" runat="server" CssClass="a" placeholder="fourth" ></asp:TextBox><br />
        <asp:Button ID="submit" runat="server" Text="submit" CssClass="k"  OnClick="submit_Click" />

    </form>


</asp:Content>

