<%@ Page Title="" Language="C#" MasterPageFile="~/student.master" AutoEventWireup="true" CodeFile="tuition_pay_student.aspx.cs" Inherits="tuition_pay_student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <form id="Form1" runat="server">
    
 
 
     <center> <h2>Fee Paymet Details</h2> </center>

       <h3> Enter Your Details </h3>
          <asp:TextBox ID="sem" runat="server" placeholder="Semester" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="amt" runat="server" placeholder="AMOUNT" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="dt" runat="server" placeholder="Date" CssClass="a"></asp:TextBox><br />
          <asp:TextBox ID="du" runat="server" placeholder="DU Number" CssClass="a"></asp:TextBox><br />

          <asp:Button ID="submit" runat="server" Text="submit" OnClick="submit_Click" CssClass="k" />
           
        </form>
</asp:Content>

