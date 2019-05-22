<%@ Page Title="" Language="C#" MasterPageFile="~/accountant.master" AutoEventWireup="true" CodeFile="staff_ps_acc.aspx.cs" Inherits="staff_ps_acc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h2>pay slip..</h2>
    <form id="form1" runat="server">
        <asp:TextBox ID="uname" placeholder="staff's name" CssClass="a" runat="server"></asp:TextBox>

        <br />
         <asp:TextBox ID="month"  CssClass="a" placeholder="month" runat="server"></asp:TextBox>

        <br />
 <asp:TextBox ID="gross" runat="server" CssClass="a" placeholder="gross_amt"></asp:TextBox>

        <br />
 <asp:TextBox ID="cuts" runat="server" CssClass="a" placeholder="cuts_amt"></asp:TextBox>

        <br />
 <asp:TextBox ID="net" runat="server" CssClass="a" placeholder="net"></asp:TextBox>

        <br />

        <asp:Button  CssClass="k" ID="submit" runat="server" Text="submit" OnClick="submit_Click" />
    </form>

</asp:Content>

