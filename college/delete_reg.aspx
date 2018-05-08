<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="delete_reg.aspx.cs" Inherits="delete_reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><form runat="server">
    <asp:TextBox ID="uname" runat="server" placeholder="User Name" CssClass="a"></asp:TextBox><br />
    <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" CssClass="k" />
        </form>
</asp:Content>

