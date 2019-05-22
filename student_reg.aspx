<%@ Page Title="" Language="C#" MasterPageFile="~/student.master" AutoEventWireup="true" CodeFile="student_reg.aspx.cs" Inherits="student_reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <form runat="server">
      <asp:TextBox placeholder="Semester" ID="sem" runat="server" CssClass="a"></asp:TextBox><br />
      <asp:TextBox placeholder="CGPA" ID="cgpa" runat="server" CssClass="a"></asp:TextBox><br />
      <asp:TextBox placeholder="Branch" ID="branch" runat="server" CssClass="a"></asp:TextBox><br />
      <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click1" CssClass="k" />
  </form>
</asp:Content>

